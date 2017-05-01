<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtherAnimalForm
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtWeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RTxtWeight = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RTxtGeneral = New System.Windows.Forms.RichTextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.CancleBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.AllDataDataSet = New WindowsApplication1.AllDataDataSet()
        Me.OtherInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtherInfoTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.OtherInfoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager()
        Me.RTxtVaccinations = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RdioKg = New System.Windows.Forms.RadioButton()
        Me.RdioLbs = New System.Windows.Forms.RadioButton()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtWeight
        '
        Me.TxtWeight.Location = New System.Drawing.Point(83, 7)
        Me.TxtWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtWeight.Name = "TxtWeight"
        Me.TxtWeight.Size = New System.Drawing.Size(56, 22)
        Me.TxtWeight.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Weight:"
        '
        'RTxtWeight
        '
        Me.RTxtWeight.Location = New System.Drawing.Point(16, 59)
        Me.RTxtWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.RTxtWeight.Name = "RTxtWeight"
        Me.RTxtWeight.Size = New System.Drawing.Size(341, 117)
        Me.RTxtWeight.TabIndex = 2
        Me.RTxtWeight.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Animal Appearence Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vaccinations:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "General Description:"
        '
        'RTxtGeneral
        '
        Me.RTxtGeneral.Location = New System.Drawing.Point(367, 59)
        Me.RTxtGeneral.Margin = New System.Windows.Forms.Padding(4)
        Me.RTxtGeneral.Name = "RTxtGeneral"
        Me.RTxtGeneral.Size = New System.Drawing.Size(339, 261)
        Me.RTxtGeneral.TabIndex = 6
        Me.RTxtGeneral.Text = ""
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(611, 329)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(100, 28)
        Me.AddBtn.TabIndex = 106
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'CancleBtn
        '
        Me.CancleBtn.Location = New System.Drawing.Point(503, 329)
        Me.CancleBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CancleBtn.Name = "CancleBtn"
        Me.CancleBtn.Size = New System.Drawing.Size(100, 28)
        Me.CancleBtn.TabIndex = 105
        Me.CancleBtn.Text = "Cancle"
        Me.CancleBtn.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(16, 329)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(100, 28)
        Me.BackBtn.TabIndex = 104
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'AllDataDataSet
        '
        Me.AllDataDataSet.DataSetName = "AllDataDataSet"
        Me.AllDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OtherInfoBindingSource
        '
        Me.OtherInfoBindingSource.DataMember = "OtherInfo"
        Me.OtherInfoBindingSource.DataSource = Me.AllDataDataSet
        '
        'OtherInfoTableAdapter
        '
        Me.OtherInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.animalMasterTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatInfoTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager.dogInfoTableAdapter = Nothing
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Me.OtherInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RTxtVaccinations
        '
        Me.RTxtVaccinations.Location = New System.Drawing.Point(16, 203)
        Me.RTxtVaccinations.Margin = New System.Windows.Forms.Padding(4)
        Me.RTxtVaccinations.Name = "RTxtVaccinations"
        Me.RTxtVaccinations.Size = New System.Drawing.Size(341, 117)
        Me.RTxtVaccinations.TabIndex = 107
        Me.RTxtVaccinations.Text = ""
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RdioKg)
        Me.Panel4.Controls.Add(Me.RdioLbs)
        Me.Panel4.Location = New System.Drawing.Point(147, 7)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(103, 25)
        Me.Panel4.TabIndex = 183
        '
        'RdioKg
        '
        Me.RdioKg.AutoSize = True
        Me.RdioKg.Location = New System.Drawing.Point(52, 4)
        Me.RdioKg.Margin = New System.Windows.Forms.Padding(4)
        Me.RdioKg.Name = "RdioKg"
        Me.RdioKg.Size = New System.Drawing.Size(46, 21)
        Me.RdioKg.TabIndex = 1
        Me.RdioKg.TabStop = True
        Me.RdioKg.Text = "Kg"
        Me.RdioKg.UseVisualStyleBackColor = True
        '
        'RdioLbs
        '
        Me.RdioLbs.AutoSize = True
        Me.RdioLbs.Location = New System.Drawing.Point(0, 4)
        Me.RdioLbs.Margin = New System.Windows.Forms.Padding(4)
        Me.RdioLbs.Name = "RdioLbs"
        Me.RdioLbs.Size = New System.Drawing.Size(52, 21)
        Me.RdioLbs.TabIndex = 0
        Me.RdioLbs.TabStop = True
        Me.RdioLbs.Text = "Lbs"
        Me.RdioLbs.UseVisualStyleBackColor = True
        '
        'OtherAnimalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(717, 385)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.RTxtVaccinations)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.CancleBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RTxtGeneral)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RTxtWeight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtWeight)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OtherAnimalForm"
        Me.Text = "Other Animal"
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RTxtWeight As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RTxtGeneral As System.Windows.Forms.RichTextBox
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents CancleBtn As System.Windows.Forms.Button
    Friend WithEvents BackBtn As System.Windows.Forms.Button
    Friend WithEvents AllDataDataSet As WindowsApplication1.AllDataDataSet
    Friend WithEvents OtherInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtherInfoTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.OtherInfoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RTxtVaccinations As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RdioKg As System.Windows.Forms.RadioButton
    Friend WithEvents RdioLbs As System.Windows.Forms.RadioButton
End Class
