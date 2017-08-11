<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PS9300ClientMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.cbCommand = New System.Windows.Forms.ComboBox()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.lblCommand = New System.Windows.Forms.Label()
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.btnGetSignal = New System.Windows.Forms.Button()
        Me.pbScreen = New System.Windows.Forms.PictureBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnSingle = New System.Windows.Forms.Button()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblXEnd = New System.Windows.Forms.Label()
        Me.lblXStart = New System.Windows.Forms.Label()
        Me.lblYTop = New System.Windows.Forms.Label()
        Me.lblYBottom = New System.Windows.Forms.Label()
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOn
        '
        Me.btnOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOn.Location = New System.Drawing.Point(12, 12)
        Me.btnOn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(70, 25)
        Me.btnOn.TabIndex = 0
        Me.btnOn.Text = "On"
        Me.btnOn.UseVisualStyleBackColor = False
        '
        'btnOff
        '
        Me.btnOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOff.Location = New System.Drawing.Point(88, 12)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(70, 25)
        Me.btnOff.TabIndex = 1
        Me.btnOff.Text = "Off"
        Me.btnOff.UseVisualStyleBackColor = False
        '
        'cbCommand
        '
        Me.cbCommand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCommand.FormattingEnabled = True
        Me.cbCommand.Items.AddRange(New Object() {"*RunControl:Run", "*RunControl:Single", "*RunControl:Stop", "*Autoscale:Auto", "Wfm:Data?", "Wfm:Preamb?", "Header Off", "Header On"})
        Me.cbCommand.Location = New System.Drawing.Point(117, 57)
        Me.cbCommand.Name = "cbCommand"
        Me.cbCommand.Size = New System.Drawing.Size(249, 24)
        Me.cbCommand.TabIndex = 3
        Me.cbCommand.Text = "*RunControl:Run"
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.Location = New System.Drawing.Point(372, 57)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 24)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.Text = "Send"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'lblCommand
        '
        Me.lblCommand.AutoSize = True
        Me.lblCommand.Location = New System.Drawing.Point(12, 61)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.Size = New System.Drawing.Size(71, 16)
        Me.lblCommand.TabIndex = 2
        Me.lblCommand.Text = "&Command:"
        '
        'tbResult
        '
        Me.tbResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbResult.Location = New System.Drawing.Point(117, 89)
        Me.tbResult.Multiline = True
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ReadOnly = True
        Me.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbResult.Size = New System.Drawing.Size(330, 76)
        Me.tbResult.TabIndex = 6
        '
        'btnGetSignal
        '
        Me.btnGetSignal.Location = New System.Drawing.Point(356, 187)
        Me.btnGetSignal.Name = "btnGetSignal"
        Me.btnGetSignal.Size = New System.Drawing.Size(91, 25)
        Me.btnGetSignal.TabIndex = 10
        Me.btnGetSignal.Text = "&Get Signal"
        Me.btnGetSignal.UseVisualStyleBackColor = True
        '
        'pbScreen
        '
        Me.pbScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbScreen.BackColor = System.Drawing.Color.Black
        Me.pbScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbScreen.Location = New System.Drawing.Point(117, 218)
        Me.pbScreen.Name = "pbScreen"
        Me.pbScreen.Size = New System.Drawing.Size(330, 117)
        Me.pbScreen.TabIndex = 7
        Me.pbScreen.TabStop = False
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(117, 187)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(70, 25)
        Me.btnRun.TabIndex = 7
        Me.btnRun.Text = "&Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(269, 187)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(70, 25)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "&Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnSingle
        '
        Me.btnSingle.Location = New System.Drawing.Point(193, 187)
        Me.btnSingle.Name = "btnSingle"
        Me.btnSingle.Size = New System.Drawing.Size(70, 25)
        Me.btnSingle.TabIndex = 8
        Me.btnSingle.Text = "Si&ngle"
        Me.btnSingle.UseVisualStyleBackColor = True
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Location = New System.Drawing.Point(12, 89)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(70, 16)
        Me.lblResponse.TabIndex = 5
        Me.lblResponse.Text = "Res&ponse:"
        '
        'lblXEnd
        '
        Me.lblXEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblXEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXEnd.Location = New System.Drawing.Point(262, 338)
        Me.lblXEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.lblXEnd.Name = "lblXEnd"
        Me.lblXEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblXEnd.Size = New System.Drawing.Size(188, 17)
        Me.lblXEnd.TabIndex = 14
        Me.lblXEnd.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblXStart
        '
        Me.lblXStart.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblXStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblXStart.Location = New System.Drawing.Point(114, 338)
        Me.lblXStart.Margin = New System.Windows.Forms.Padding(0)
        Me.lblXStart.Name = "lblXStart"
        Me.lblXStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblXStart.Size = New System.Drawing.Size(188, 17)
        Me.lblXStart.TabIndex = 13
        '
        'lblYTop
        '
        Me.lblYTop.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblYTop.Location = New System.Drawing.Point(9, 218)
        Me.lblYTop.Margin = New System.Windows.Forms.Padding(0)
        Me.lblYTop.Name = "lblYTop"
        Me.lblYTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYTop.Size = New System.Drawing.Size(188, 17)
        Me.lblYTop.TabIndex = 11
        '
        'lblYBottom
        '
        Me.lblYBottom.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblYBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblYBottom.Location = New System.Drawing.Point(9, 318)
        Me.lblYBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.lblYBottom.Name = "lblYBottom"
        Me.lblYBottom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYBottom.Size = New System.Drawing.Size(188, 17)
        Me.lblYBottom.TabIndex = 12
        '
        'PS9300MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 364)
        Me.Controls.Add(Me.lblXStart)
        Me.Controls.Add(Me.lblXEnd)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.btnSingle)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.pbScreen)
        Me.Controls.Add(Me.btnGetSignal)
        Me.Controls.Add(Me.tbResult)
        Me.Controls.Add(Me.lblCommand)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.cbCommand)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.lblYTop)
        Me.Controls.Add(Me.lblYBottom)
        Me.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PS9300MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "PicoScope 9300 VB.NET Client Example"
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOn As System.Windows.Forms.Button
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents cbCommand As System.Windows.Forms.ComboBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents lblCommand As System.Windows.Forms.Label
    Friend WithEvents tbResult As System.Windows.Forms.TextBox
    Friend WithEvents btnGetSignal As System.Windows.Forms.Button
    Friend WithEvents pbScreen As System.Windows.Forms.PictureBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnSingle As System.Windows.Forms.Button
    Friend WithEvents lblResponse As System.Windows.Forms.Label
    Friend WithEvents lblXEnd As System.Windows.Forms.Label
    Friend WithEvents lblXStart As System.Windows.Forms.Label
    Friend WithEvents lblYTop As System.Windows.Forms.Label
    Friend WithEvents lblYBottom As System.Windows.Forms.Label

End Class
