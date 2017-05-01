<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicInfoForm
    Inherits System.Windows.Forms.form

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
        Dim NameLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim DobLabel As System.Windows.Forms.Label
        Dim DoaLabel As System.Windows.Forms.Label
        Dim ChippedLabel As System.Windows.Forms.Label
        Dim ChipNumLabel As System.Windows.Forms.Label
        Dim OwnerLabel As System.Windows.Forms.Label
        Dim DateContactedLabel As System.Windows.Forms.Label
        Dim McDateLabel As System.Windows.Forms.Label
        Dim RelinPrtyLabel As System.Windows.Forms.Label
        Dim CageNumLabel As System.Windows.Forms.Label
        Dim QuarentineLabel As System.Windows.Forms.Label
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AnimalMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllDataDataSet = New WindowsApplication1.AllDataDataSet()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.DobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DoaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ChippedCheckBox = New System.Windows.Forms.CheckBox()
        Me.ChipNumTextBox = New System.Windows.Forms.TextBox()
        Me.OwnerTextBox = New System.Windows.Forms.TextBox()
        Me.DateContactedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.McDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RelinPrtyTextBox = New System.Windows.Forms.TextBox()
        Me.CageNumTextBox = New System.Windows.Forms.TextBox()
        Me.QuarentineCheckBox = New System.Windows.Forms.CheckBox()
        Me.ButtonContinue = New System.Windows.Forms.Button()
        Me.ButtonCancle = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbl_InfoError = New System.Windows.Forms.Label()
        Me.lbl_CageNumError = New System.Windows.Forms.Label()
        Me.lbl_RelinPrtyError = New System.Windows.Forms.Label()
        Me.lbl_OwnerNameError = New System.Windows.Forms.Label()
        Me.lbl_ChipNumError = New System.Windows.Forms.Label()
        Me.lbl_NameError = New System.Windows.Forms.Label()
        Me.lbl_AgeError = New System.Windows.Forms.Label()
        Me.AnimalMasterTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.animalMasterTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager()
        NameLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        DobLabel = New System.Windows.Forms.Label()
        DoaLabel = New System.Windows.Forms.Label()
        ChippedLabel = New System.Windows.Forms.Label()
        ChipNumLabel = New System.Windows.Forms.Label()
        OwnerLabel = New System.Windows.Forms.Label()
        DateContactedLabel = New System.Windows.Forms.Label()
        McDateLabel = New System.Windows.Forms.Label()
        RelinPrtyLabel = New System.Windows.Forms.Label()
        CageNumLabel = New System.Windows.Forms.Label()
        QuarentineLabel = New System.Windows.Forms.Label()
        CType(Me.AnimalMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(7, 18)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(7, 50)
        TypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(44, 17)
        TypeLabel.TabIndex = 6
        TypeLabel.Text = "Type:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(7, 82)
        AgeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(37, 17)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "Age:"
        '
        'DobLabel
        '
        DobLabel.AutoSize = True
        DobLabel.Location = New System.Drawing.Point(7, 116)
        DobLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DobLabel.Name = "DobLabel"
        DobLabel.Size = New System.Drawing.Size(91, 17)
        DobLabel.TabIndex = 10
        DobLabel.Text = "Date of Birth:"
        '
        'DoaLabel
        '
        DoaLabel.AutoSize = True
        DoaLabel.Location = New System.Drawing.Point(7, 148)
        DoaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DoaLabel.Name = "DoaLabel"
        DoaLabel.Size = New System.Drawing.Size(102, 17)
        DoaLabel.TabIndex = 12
        DoaLabel.Text = "Date of Arrival:"
        '
        'ChippedLabel
        '
        ChippedLabel.AutoSize = True
        ChippedLabel.Location = New System.Drawing.Point(7, 181)
        ChippedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ChippedLabel.Name = "ChippedLabel"
        ChippedLabel.Size = New System.Drawing.Size(77, 17)
        ChippedLabel.TabIndex = 14
        ChippedLabel.Text = "Micro-chip:"
        '
        'ChipNumLabel
        '
        ChipNumLabel.AutoSize = True
        ChipNumLabel.Location = New System.Drawing.Point(7, 215)
        ChipNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ChipNumLabel.Name = "ChipNumLabel"
        ChipNumLabel.Size = New System.Drawing.Size(94, 17)
        ChipNumLabel.TabIndex = 16
        ChipNumLabel.Text = "Chip Number:"
        '
        'OwnerLabel
        '
        OwnerLabel.AutoSize = True
        OwnerLabel.Location = New System.Drawing.Point(7, 247)
        OwnerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OwnerLabel.Name = "OwnerLabel"
        OwnerLabel.Size = New System.Drawing.Size(94, 17)
        OwnerLabel.TabIndex = 18
        OwnerLabel.Text = "Owner Name:"
        '
        'DateContactedLabel
        '
        DateContactedLabel.AutoSize = True
        DateContactedLabel.Location = New System.Drawing.Point(7, 281)
        DateContactedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateContactedLabel.Name = "DateContactedLabel"
        DateContactedLabel.Size = New System.Drawing.Size(102, 17)
        DateContactedLabel.TabIndex = 20
        DateContactedLabel.Text = "Contanct Date:"
        '
        'McDateLabel
        '
        McDateLabel.AutoSize = True
        McDateLabel.Location = New System.Drawing.Point(7, 313)
        McDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        McDateLabel.Name = "McDateLabel"
        McDateLabel.Size = New System.Drawing.Size(133, 17)
        McDateLabel.TabIndex = 22
        McDateLabel.Text = "Microchipping Date:"
        '
        'RelinPrtyLabel
        '
        RelinPrtyLabel.AutoSize = True
        RelinPrtyLabel.Location = New System.Drawing.Point(7, 343)
        RelinPrtyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RelinPrtyLabel.Name = "RelinPrtyLabel"
        RelinPrtyLabel.Size = New System.Drawing.Size(126, 17)
        RelinPrtyLabel.TabIndex = 24
        RelinPrtyLabel.Text = "Relinquising Party:"
        '
        'CageNumLabel
        '
        CageNumLabel.AutoSize = True
        CageNumLabel.Location = New System.Drawing.Point(7, 375)
        CageNumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CageNumLabel.Name = "CageNumLabel"
        CageNumLabel.Size = New System.Drawing.Size(99, 17)
        CageNumLabel.TabIndex = 26
        CageNumLabel.Text = "Cage Number:"
        '
        'QuarentineLabel
        '
        QuarentineLabel.AutoSize = True
        QuarentineLabel.Location = New System.Drawing.Point(7, 410)
        QuarentineLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QuarentineLabel.Name = "QuarentineLabel"
        QuarentineLabel.Size = New System.Drawing.Size(83, 17)
        QuarentineLabel.TabIndex = 28
        QuarentineLabel.Text = "Quarantine:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(65, 15)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NameTextBox.MaxLength = 50
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(195, 22)
        Me.NameTextBox.TabIndex = 5
        '
        'AnimalMasterBindingSource
        '
        Me.AnimalMasterBindingSource.DataMember = "animalMaster"
        Me.AnimalMasterBindingSource.DataSource = Me.AllDataDataSet
        '
        'AllDataDataSet
        '
        Me.AllDataDataSet.DataSetName = "AllDataDataSet"
        Me.AllDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(65, 79)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(45, 22)
        Me.AgeTextBox.TabIndex = 9
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.Checked = False
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "dob", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "d"))
        Me.DobDateTimePicker.Location = New System.Drawing.Point(125, 111)
        Me.DobDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DobDateTimePicker.TabIndex = 11
        '
        'DoaDateTimePicker
        '
        Me.DoaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "doa", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "d"))
        Me.DoaDateTimePicker.Location = New System.Drawing.Point(125, 143)
        Me.DoaDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DoaDateTimePicker.Name = "DoaDateTimePicker"
        Me.DoaDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DoaDateTimePicker.TabIndex = 13
        '
        'ChippedCheckBox
        '
        Me.ChippedCheckBox.Location = New System.Drawing.Point(125, 175)
        Me.ChippedCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChippedCheckBox.Name = "ChippedCheckBox"
        Me.ChippedCheckBox.Size = New System.Drawing.Size(267, 30)
        Me.ChippedCheckBox.TabIndex = 15
        Me.ChippedCheckBox.Text = "Y/N"
        Me.ChippedCheckBox.UseVisualStyleBackColor = True
        '
        'ChipNumTextBox
        '
        Me.ChipNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "chipNum", True))
        Me.ChipNumTextBox.Location = New System.Drawing.Point(125, 212)
        Me.ChipNumTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChipNumTextBox.Name = "ChipNumTextBox"
        Me.ChipNumTextBox.Size = New System.Drawing.Size(265, 22)
        Me.ChipNumTextBox.TabIndex = 17
        '
        'OwnerTextBox
        '
        Me.OwnerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "owner", True))
        Me.OwnerTextBox.Location = New System.Drawing.Point(125, 244)
        Me.OwnerTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OwnerTextBox.Name = "OwnerTextBox"
        Me.OwnerTextBox.Size = New System.Drawing.Size(265, 22)
        Me.OwnerTextBox.TabIndex = 19
        '
        'DateContactedDateTimePicker
        '
        Me.DateContactedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnimalMasterBindingSource, "dateContacted", True))
        Me.DateContactedDateTimePicker.Location = New System.Drawing.Point(125, 276)
        Me.DateContactedDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateContactedDateTimePicker.Name = "DateContactedDateTimePicker"
        Me.DateContactedDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DateContactedDateTimePicker.TabIndex = 21
        '
        'McDateDateTimePicker
        '
        Me.McDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnimalMasterBindingSource, "mcDate", True))
        Me.McDateDateTimePicker.Location = New System.Drawing.Point(151, 308)
        Me.McDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.McDateDateTimePicker.Name = "McDateDateTimePicker"
        Me.McDateDateTimePicker.Size = New System.Drawing.Size(240, 22)
        Me.McDateDateTimePicker.TabIndex = 23
        '
        'RelinPrtyTextBox
        '
        Me.RelinPrtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "relinPrty", True))
        Me.RelinPrtyTextBox.Location = New System.Drawing.Point(151, 340)
        Me.RelinPrtyTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RelinPrtyTextBox.Name = "RelinPrtyTextBox"
        Me.RelinPrtyTextBox.Size = New System.Drawing.Size(240, 22)
        Me.RelinPrtyTextBox.TabIndex = 25
        '
        'CageNumTextBox
        '
        Me.CageNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "cageNum", True))
        Me.CageNumTextBox.Location = New System.Drawing.Point(125, 372)
        Me.CageNumTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CageNumTextBox.Name = "CageNumTextBox"
        Me.CageNumTextBox.Size = New System.Drawing.Size(265, 22)
        Me.CageNumTextBox.TabIndex = 27
        '
        'QuarentineCheckBox
        '
        Me.QuarentineCheckBox.Checked = True
        Me.QuarentineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.QuarentineCheckBox.Location = New System.Drawing.Point(121, 405)
        Me.QuarentineCheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.QuarentineCheckBox.Name = "QuarentineCheckBox"
        Me.QuarentineCheckBox.Size = New System.Drawing.Size(267, 30)
        Me.QuarentineCheckBox.TabIndex = 29
        Me.QuarentineCheckBox.Text = "Y/N"
        Me.QuarentineCheckBox.UseVisualStyleBackColor = True
        '
        'ButtonContinue
        '
        Me.ButtonContinue.Location = New System.Drawing.Point(292, 404)
        Me.ButtonContinue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonContinue.Name = "ButtonContinue"
        Me.ButtonContinue.Size = New System.Drawing.Size(100, 28)
        Me.ButtonContinue.TabIndex = 30
        Me.ButtonContinue.Text = "Continue"
        Me.ButtonContinue.UseVisualStyleBackColor = True
        '
        'ButtonCancle
        '
        Me.ButtonCancle.Location = New System.Drawing.Point(184, 405)
        Me.ButtonCancle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCancle.Name = "ButtonCancle"
        Me.ButtonCancle.Size = New System.Drawing.Size(100, 28)
        Me.ButtonCancle.TabIndex = 31
        Me.ButtonCancle.Text = "Cancle"
        Me.ButtonCancle.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Dog", "Cat", "Other"})
        Me.ComboBox1.Location = New System.Drawing.Point(65, 46)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(195, 24)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Tag = "2"
        Me.ComboBox1.Text = "Dog"
        '
        'lbl_InfoError
        '
        Me.lbl_InfoError.AutoSize = True
        Me.lbl_InfoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_InfoError.ForeColor = System.Drawing.Color.Red
        Me.lbl_InfoError.Location = New System.Drawing.Point(228, 437)
        Me.lbl_InfoError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_InfoError.Name = "lbl_InfoError"
        Me.lbl_InfoError.Size = New System.Drawing.Size(165, 17)
        Me.lbl_InfoError.TabIndex = 33
        Me.lbl_InfoError.Text = "*- Required Field Missing"
        Me.lbl_InfoError.Visible = False
        '
        'lbl_CageNumError
        '
        Me.lbl_CageNumError.AutoSize = True
        Me.lbl_CageNumError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_CageNumError.ForeColor = System.Drawing.Color.Red
        Me.lbl_CageNumError.Location = New System.Drawing.Point(395, 375)
        Me.lbl_CageNumError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CageNumError.Name = "lbl_CageNumError"
        Me.lbl_CageNumError.Size = New System.Drawing.Size(15, 20)
        Me.lbl_CageNumError.TabIndex = 34
        Me.lbl_CageNumError.Text = "*"
        Me.lbl_CageNumError.Visible = False
        '
        'lbl_RelinPrtyError
        '
        Me.lbl_RelinPrtyError.AutoSize = True
        Me.lbl_RelinPrtyError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_RelinPrtyError.ForeColor = System.Drawing.Color.Red
        Me.lbl_RelinPrtyError.Location = New System.Drawing.Point(395, 340)
        Me.lbl_RelinPrtyError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_RelinPrtyError.Name = "lbl_RelinPrtyError"
        Me.lbl_RelinPrtyError.Size = New System.Drawing.Size(15, 20)
        Me.lbl_RelinPrtyError.TabIndex = 36
        Me.lbl_RelinPrtyError.Text = "*"
        Me.lbl_RelinPrtyError.Visible = False
        '
        'lbl_OwnerNameError
        '
        Me.lbl_OwnerNameError.AutoSize = True
        Me.lbl_OwnerNameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_OwnerNameError.ForeColor = System.Drawing.Color.Red
        Me.lbl_OwnerNameError.Location = New System.Drawing.Point(395, 244)
        Me.lbl_OwnerNameError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_OwnerNameError.Name = "lbl_OwnerNameError"
        Me.lbl_OwnerNameError.Size = New System.Drawing.Size(15, 20)
        Me.lbl_OwnerNameError.TabIndex = 37
        Me.lbl_OwnerNameError.Text = "*"
        Me.lbl_OwnerNameError.Visible = False
        '
        'lbl_ChipNumError
        '
        Me.lbl_ChipNumError.AutoSize = True
        Me.lbl_ChipNumError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_ChipNumError.ForeColor = System.Drawing.Color.Red
        Me.lbl_ChipNumError.Location = New System.Drawing.Point(395, 212)
        Me.lbl_ChipNumError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ChipNumError.Name = "lbl_ChipNumError"
        Me.lbl_ChipNumError.Size = New System.Drawing.Size(15, 20)
        Me.lbl_ChipNumError.TabIndex = 41
        Me.lbl_ChipNumError.Text = "*"
        Me.lbl_ChipNumError.Visible = False
        '
        'lbl_NameError
        '
        Me.lbl_NameError.AutoSize = True
        Me.lbl_NameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_NameError.ForeColor = System.Drawing.Color.Red
        Me.lbl_NameError.Location = New System.Drawing.Point(264, 15)
        Me.lbl_NameError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NameError.Name = "lbl_NameError"
        Me.lbl_NameError.Size = New System.Drawing.Size(15, 20)
        Me.lbl_NameError.TabIndex = 43
        Me.lbl_NameError.Text = "*"
        Me.lbl_NameError.Visible = False
        '
        'lbl_AgeError
        '
        Me.lbl_AgeError.AutoSize = True
        Me.lbl_AgeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_AgeError.ForeColor = System.Drawing.Color.Red
        Me.lbl_AgeError.Location = New System.Drawing.Point(117, 79)
        Me.lbl_AgeError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_AgeError.Name = "lbl_AgeError"
        Me.lbl_AgeError.Size = New System.Drawing.Size(15, 20)
        Me.lbl_AgeError.TabIndex = 44
        Me.lbl_AgeError.Text = "*"
        Me.lbl_AgeError.Visible = False
        '
        'AnimalMasterTableAdapter
        '
        Me.AnimalMasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.animalMasterTableAdapter = Me.AnimalMasterTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatInfoTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager.dogInfoTableAdapter = Nothing
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BasicInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(425, 448)
        Me.Controls.Add(Me.lbl_AgeError)
        Me.Controls.Add(Me.lbl_NameError)
        Me.Controls.Add(Me.lbl_ChipNumError)
        Me.Controls.Add(Me.lbl_OwnerNameError)
        Me.Controls.Add(Me.lbl_RelinPrtyError)
        Me.Controls.Add(Me.lbl_CageNumError)
        Me.Controls.Add(Me.lbl_InfoError)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonCancle)
        Me.Controls.Add(Me.ButtonContinue)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(DobLabel)
        Me.Controls.Add(Me.DobDateTimePicker)
        Me.Controls.Add(DoaLabel)
        Me.Controls.Add(Me.DoaDateTimePicker)
        Me.Controls.Add(ChippedLabel)
        Me.Controls.Add(Me.ChippedCheckBox)
        Me.Controls.Add(ChipNumLabel)
        Me.Controls.Add(Me.ChipNumTextBox)
        Me.Controls.Add(OwnerLabel)
        Me.Controls.Add(Me.OwnerTextBox)
        Me.Controls.Add(DateContactedLabel)
        Me.Controls.Add(Me.DateContactedDateTimePicker)
        Me.Controls.Add(McDateLabel)
        Me.Controls.Add(Me.McDateDateTimePicker)
        Me.Controls.Add(RelinPrtyLabel)
        Me.Controls.Add(Me.RelinPrtyTextBox)
        Me.Controls.Add(CageNumLabel)
        Me.Controls.Add(Me.CageNumTextBox)
        Me.Controls.Add(QuarentineLabel)
        Me.Controls.Add(Me.QuarentineCheckBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BasicInfoForm"
        Me.Text = "Basic Information"
        CType(Me.AnimalMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AllDataDataSet As WindowsApplication1.AllDataDataSet
    Friend WithEvents AnimalMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnimalMasterTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.animalMasterTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DobDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DoaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChippedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChipNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OwnerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateContactedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents McDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RelinPrtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CageNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuarentineCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonContinue As System.Windows.Forms.Button
    Friend WithEvents ButtonCancle As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_InfoError As System.Windows.Forms.Label
    Friend WithEvents lbl_CageNumError As System.Windows.Forms.Label
    Friend WithEvents lbl_RelinPrtyError As System.Windows.Forms.Label
    Friend WithEvents lbl_OwnerNameError As System.Windows.Forms.Label
    Friend WithEvents lbl_ChipNumError As System.Windows.Forms.Label
    Friend WithEvents lbl_NameError As System.Windows.Forms.Label
    Friend WithEvents lbl_AgeError As System.Windows.Forms.Label
End Class
