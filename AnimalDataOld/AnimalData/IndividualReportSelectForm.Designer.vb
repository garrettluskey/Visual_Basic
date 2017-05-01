<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualReportSelectForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RdioBlackAndWhite = New System.Windows.Forms.RadioButton()
        Me.RdioColor = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RdioCost = New System.Windows.Forms.RadioButton()
        Me.RdioClient = New System.Windows.Forms.RadioButton()
        Me.LblPrinterOptions = New System.Windows.Forms.Label()
        Me.LblReports = New System.Windows.Forms.Label()
        Me.BtnCancle = New System.Windows.Forms.Button()
        Me.BtnContinue = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RdioBlackAndWhite)
        Me.Panel1.Controls.Add(Me.RdioColor)
        Me.Panel1.Location = New System.Drawing.Point(15, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 29)
        Me.Panel1.TabIndex = 0
        '
        'RdioBlackAndWhite
        '
        Me.RdioBlackAndWhite.AutoSize = True
        Me.RdioBlackAndWhite.Checked = True
        Me.RdioBlackAndWhite.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RdioBlackAndWhite.Location = New System.Drawing.Point(71, 3)
        Me.RdioBlackAndWhite.Name = "RdioBlackAndWhite"
        Me.RdioBlackAndWhite.Size = New System.Drawing.Size(131, 21)
        Me.RdioBlackAndWhite.TabIndex = 3
        Me.RdioBlackAndWhite.TabStop = True
        Me.RdioBlackAndWhite.Text = "Black and White"
        Me.RdioBlackAndWhite.UseVisualStyleBackColor = True
        '
        'RdioColor
        '
        Me.RdioColor.AutoSize = True
        Me.RdioColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RdioColor.Location = New System.Drawing.Point(3, 3)
        Me.RdioColor.Name = "RdioColor"
        Me.RdioColor.Size = New System.Drawing.Size(62, 21)
        Me.RdioColor.TabIndex = 2
        Me.RdioColor.Text = "Color"
        Me.RdioColor.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RdioCost)
        Me.Panel2.Controls.Add(Me.RdioClient)
        Me.Panel2.Location = New System.Drawing.Point(15, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(228, 31)
        Me.Panel2.TabIndex = 0
        '
        'RdioCost
        '
        Me.RdioCost.AutoSize = True
        Me.RdioCost.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RdioCost.Location = New System.Drawing.Point(120, 3)
        Me.RdioCost.Name = "RdioCost"
        Me.RdioCost.Size = New System.Drawing.Size(104, 21)
        Me.RdioCost.TabIndex = 1
        Me.RdioCost.TabStop = True
        Me.RdioCost.Text = "Cost Report"
        Me.RdioCost.UseVisualStyleBackColor = True
        '
        'RdioClient
        '
        Me.RdioClient.AutoSize = True
        Me.RdioClient.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RdioClient.Location = New System.Drawing.Point(3, 3)
        Me.RdioClient.Name = "RdioClient"
        Me.RdioClient.Size = New System.Drawing.Size(111, 21)
        Me.RdioClient.TabIndex = 0
        Me.RdioClient.TabStop = True
        Me.RdioClient.Text = "Client Report"
        Me.RdioClient.UseVisualStyleBackColor = True
        '
        'LblPrinterOptions
        '
        Me.LblPrinterOptions.AutoSize = True
        Me.LblPrinterOptions.Location = New System.Drawing.Point(9, 9)
        Me.LblPrinterOptions.Name = "LblPrinterOptions"
        Me.LblPrinterOptions.Size = New System.Drawing.Size(103, 17)
        Me.LblPrinterOptions.TabIndex = 4
        Me.LblPrinterOptions.Text = "Printer Options"
        '
        'LblReports
        '
        Me.LblReports.AutoSize = True
        Me.LblReports.Location = New System.Drawing.Point(9, 61)
        Me.LblReports.Name = "LblReports"
        Me.LblReports.Size = New System.Drawing.Size(58, 17)
        Me.LblReports.TabIndex = 5
        Me.LblReports.Text = "Reports"
        '
        'BtnCancle
        '
        Me.BtnCancle.Location = New System.Drawing.Point(12, 151)
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(100, 28)
        Me.BtnCancle.TabIndex = 6
        Me.BtnCancle.Text = "Cancle"
        Me.BtnCancle.UseVisualStyleBackColor = True
        '
        'BtnContinue
        '
        Me.BtnContinue.Location = New System.Drawing.Point(206, 151)
        Me.BtnContinue.Name = "BtnContinue"
        Me.BtnContinue.Size = New System.Drawing.Size(100, 28)
        Me.BtnContinue.TabIndex = 7
        Me.BtnContinue.Text = "Continue"
        Me.BtnContinue.UseVisualStyleBackColor = True
        '
        'IndividualReportSelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(318, 191)
        Me.Controls.Add(Me.BtnContinue)
        Me.Controls.Add(Me.BtnCancle)
        Me.Controls.Add(Me.LblReports)
        Me.Controls.Add(Me.LblPrinterOptions)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "IndividualReportSelectForm"
        Me.Text = "Report Customization"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RdioBlackAndWhite As System.Windows.Forms.RadioButton
    Friend WithEvents RdioColor As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RdioCost As System.Windows.Forms.RadioButton
    Friend WithEvents RdioClient As System.Windows.Forms.RadioButton
    Friend WithEvents LblPrinterOptions As System.Windows.Forms.Label
    Friend WithEvents LblReports As System.Windows.Forms.Label
    Friend WithEvents BtnCancle As System.Windows.Forms.Button
    Friend WithEvents BtnContinue As System.Windows.Forms.Button
End Class
