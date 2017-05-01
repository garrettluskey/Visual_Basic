<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryReportOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryReportOptions))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RdioBW = New System.Windows.Forms.RadioButton()
        Me.RdioColor = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Color Options"
        '
        'RdioBW
        '
        Me.RdioBW.AutoSize = True
        Me.RdioBW.Checked = True
        Me.RdioBW.Location = New System.Drawing.Point(12, 25)
        Me.RdioBW.Name = "RdioBW"
        Me.RdioBW.Size = New System.Drawing.Size(105, 17)
        Me.RdioBW.TabIndex = 6
        Me.RdioBW.TabStop = True
        Me.RdioBW.Text = "Black And White"
        Me.RdioBW.UseVisualStyleBackColor = True
        '
        'RdioColor
        '
        Me.RdioColor.AutoSize = True
        Me.RdioColor.Location = New System.Drawing.Point(123, 25)
        Me.RdioColor.Name = "RdioColor"
        Me.RdioColor.Size = New System.Drawing.Size(49, 17)
        Me.RdioColor.TabIndex = 5
        Me.RdioColor.Text = "Color"
        Me.RdioColor.UseVisualStyleBackColor = True
        '
        'InventoryReportOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(352, 62)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RdioBW)
        Me.Controls.Add(Me.RdioColor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InventoryReportOptions"
        Me.Text = "Report Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RdioBW As System.Windows.Forms.RadioButton
    Friend WithEvents RdioColor As System.Windows.Forms.RadioButton
End Class
