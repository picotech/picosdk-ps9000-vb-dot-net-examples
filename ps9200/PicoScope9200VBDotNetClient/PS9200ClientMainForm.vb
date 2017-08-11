'===================================================================================================
'	
'   Filename: PS9200ClientMainForm.vb
'
'	Description: 
'	    This file provides an example ActiveX client to communicate with the server provided by
'       the PicoScope9200 software application for PicoScope 9200 Series sampling oscilloscopes.
'
'   Copyright © 2015-2017 Pico Technology Ltd. See LICENSE file for terms.
'
'===================================================================================================

Public Class PS9200ClientMainForm

    Private Class COMRCWrapper
        Dim COMRC As PicoScope9000.COMRC  ' COM object of the oscilloscope 
        ' Project | Add Reference... | COM | PicoScope9000 
        Sub New()
            COMRC = New PicoScope9000.COMRC
        End Sub
        Public Function ExecCommand(ByVal command As String) As String
            ' Executes a command, returns string result or raises an exception
            Dim result = COMRC.ExecCommand(command)
            If IsNothing(result) Then
                Return ""
            ElseIf result = "ERROR" Then
                Throw New Exception("PicoScope9000.COMRC command error (" & command & ")")
            Else
                Return result
            End If
        End Function
    End Class


    Dim COMRCW As COMRCWrapper


    Private Sub updateUI()
        Dim connected = Not IsNothing(COMRCW)
        btnOff.Enabled = connected
        btnOn.Enabled = Not connected
        lblCommand.Enabled = connected
        lblResponse.Enabled = connected
        cbCommand.Enabled = connected
        btnExecute.Enabled = connected
        btnGetSignal.Enabled = connected
        btnRun.Enabled = connected
        btnSingle.Enabled = connected
        btnStop.Enabled = connected
    End Sub


    Private Sub btnOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn.Click
        COMRCW = New COMRCWrapper
        updateUI()
    End Sub


    Private Sub btnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOff.Click
        COMRCW = Nothing
        GC.Collect() ' Forse GC to release the COM object
        updateUI()
    End Sub


    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateUI()
        MinimumSize = Size
    End Sub


    Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click
        Try
            Dim result = COMRCW.ExecCommand(cbCommand.Text)
            tbResult.Text = result
            cbCommand.Items.Insert(0, cbCommand.Text)
            cbCommand.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cbCommand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCommand.TextChanged
        btnExecute.Enabled = Not String.IsNullOrEmpty(cbCommand.Text)
    End Sub


    Private Sub cbCommand_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCommand.KeyPress
        If e.KeyChar = vbCr And btnExecute.Enabled Then
            btnExecute_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        COMRCW.ExecCommand("*Run")
    End Sub


    Private Sub btnSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSingle.Click
        COMRCW.ExecCommand("*StopSingle Single")
    End Sub


    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        COMRCW.ExecCommand("*StopSingle Stop")
    End Sub


    Private Sub btnGetSignal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetSignal.Click
        ' Getting data 
        COMRCW.ExecCommand("Header Off") ' Switching off headers in results
        Dim strdata = COMRCW.ExecCommand("Wfm:Data?") ' Getting points
        Dim YU = COMRCW.ExecCommand("Wfm:Preamb:YU?") ' Y-axis units
        Dim XU = COMRCW.ExecCommand("Wfm:Preamb:XU?") ' X-axis units
        Dim XInc = COMRCW.ExecCommand("Wfm:Preamb:XInc?") ' X-axis step
        Dim XOrg = COMRCW.ExecCommand("Wfm:Preamb:XOrg?") ' Y-axis origin

        ' Converting string of values to array of doubles
        Dim arraystrdata = strdata.Split(", ")
        Dim data(arraystrdata.Length - 1) As Double
        For i As Integer = 0 To arraystrdata.Length - 1
            data(i) = CDbl(arraystrdata(i))
        Next

        ' Determining the vertical scale
        Dim XMax As Double = Double.MinValue
        Dim XMin As Double = Double.MaxValue
        For Each point In data
            XMax = Math.Max(XMax, point)
            XMin = Math.Min(XMin, point)
        Next
        Dim XSize = XMax - XMin
        XMax += 0.1 * XSize
        XMin -= 0.1 * XSize
        If XSize <= 0 Then
            XMax = 1
            XMin = -1
        End If
        XSize = XMax - XMin

        ' Screen width and height
        Dim width = pbScreen.ClientRectangle.Width
        Dim height = pbScreen.ClientRectangle.Height

        ' Creating screen bitmap
        Dim bitmap = New Bitmap(width, height)

        ' Painting the Ox axis
        Dim x = 0
        Dim y = Math.Round((0 - XMin / XSize) * (height - 1))
        y = height - y - 1 ' inverse because of inversed GDI y-coordinate
        If y >= 0 And y < height Then
            For x = 0 To width - 1
                bitmap.SetPixel(x, y, Color.Lime)
            Next
        End If

        ' Painting the signal
        For i = 0 To data.Length - 1
            x = i * (width - 1) \ (data.Length - 1) ' Scale signal to screen width
            y = Math.Round((((data(i) - XMin) / XSize)) * (height - 1)) ' Scale signal to screen height
            y = height - y - 1 ' inverse because of inversed GDI y-coordinate
            bitmap.SetPixel(x, y, Color.Yellow)
        Next

        ' Assigning screen bitmap to screen
        pbScreen.Image = bitmap

        ' Axis limits
        lblXStart.Text = XOrg & " " & XU
        lblXEnd.Text = (XOrg + XInc * (data.Length - 1)) & " " & XU
        lblYTop.Text = XMax & " " & YU
        lblYBottom.Text = XMin & " " & YU
    End Sub
End Class
