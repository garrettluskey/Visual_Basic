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
        Me.RTxtVaccinations = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RdioKg = New System.Windows.Forms.RadioButton()
        Me.RdioLbs = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AllDataDataSet = New WindowsApplication1.AllDataDataSet()
        Me.OtherInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtherInfoTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.OtherInfoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager()
        Me.Panel4.SuspendLayout()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtWeight
        '
        Me.TxtWeight.Location = New System.Drawing.Point(62, 6)
        Me.TxtWeight.Name = "TxtWeight"
        Me.TxtWeight.Size = New System.Drawing.Size(43, 20)
        Me.TxtWeight.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Weight:"
        '
        'RTxtWeight
        '
        Me.RTxtWeight.Location = New System.Drawing.Point(12, 48)
        Me.RTxtWeight.Name = "RTxtWeight"
        Me.RTxtWeight.Size = New System.Drawing.Size(383, 96)
        Me.RTxtWeight.TabIndex = 2
        Me.RTxtWeight.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Animal Appearence Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vaccinations:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(398, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "General Description:"
        '
        'RTxtGeneral
        '
        Me.RTxtGeneral.Location = New System.Drawing.Point(401, 48)
        Me.RTxtGeneral.Name = "RTxtGeneral"
        Me.RTxtGeneral.Size = New System.Drawing.Size(255, 213)
        Me.RTxtGeneral.TabIndex = 6
        Me.RTxtGeneral.Text = ""
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(581, 267)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 106
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'CancleBtn
        '
        Me.CancleBtn.Location = New System.Drawing.Point(500, 267)
        Me.CancleBtn.Name = "CancleBtn"
        Me.CancleBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancleBtn.TabIndex = 105
        Me.CancleBtn.Text = "Cancle"
        Me.CancleBtn.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(12, 267)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(75, 23)
        Me.BackBtn.TabIndex = 104
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'RTxtVaccinations
        '
        Me.RTxtVaccinations.Location = New System.Drawing.Point(12, 165)
        Me.RTxtVaccinations.Name = "RTxtVaccinations"
        Me.RTxtVaccinations.Size = New System.Drawing.Size(257, 96)
        Me.RTxtVaccinations.TabIndex = 107
        Me.RTxtVaccinations.Text = ""
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RdioKg)
        Me.Panel4.Controls.Add(Me.RdioLbs)
        Me.Panel4.Location = New System.Drawing.Point(110, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(77, 20)
        Me.Panel4.TabIndex = 183
        '
        'RdioKg
        '
        Me.RdioKg.AutoSize = True
        Me.RdioKg.Location = New System.Drawing.Point(39, 3)
        Me.RdioKg.Name = "RdioKg"
        Me.RdioKg.Size = New System.Drawing.Size(38, 17)
        Me.RdioKg.TabIndex = 1
        Me.RdioKg.TabStop = True
        Me.RdioKg.Text = "Kg"
        Me.RdioKg.UseVisualStyleBackColor = True
        '
        'RdioLbs
        '
        Me.RdioLbs.AutoSize = True
        Me.RdioLbs.Location = New System.Drawing.Point(0, 3)
        Me.RdioLbs.Name = "RdioLbs"
        Me.RdioLbs.Size = New System.Drawing.Size(42, 17)
        Me.RdioLbs.TabIndex = 0
        Me.RdioLbs.TabStop = True
        Me.RdioLbs.Text = "Lbs"
        Me.RdioLbs.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(275, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 184
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 185
        Me.Label5.Text = "Number of Vaccinations"
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
        Me.TableAdapterManager.CostReportTableAdapter = Nothing
        Me.TableAdapterManager.dogInfoTableAdapter = Nothing
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Me.OtherInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OtherAnimalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(674, 313)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Name = "OtherAnimalForm"
        Me.Text = "Other Animal"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
