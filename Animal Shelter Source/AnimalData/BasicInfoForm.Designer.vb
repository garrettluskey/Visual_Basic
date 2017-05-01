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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasicInfoForm))
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AnimalMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllDataDataSet = New FurryFriendsAnimalShelter.AllDataDataSet()
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
        Me.AnimalMasterTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.animalMasterTableAdapter()
        Me.TableAdapterManager = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager()
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
        NameLabel.Location = New System.Drawing.Point(5, 15)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(5, 41)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 6
        TypeLabel.Text = "Type:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(5, 67)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "Age:"
        '
        'DobLabel
        '
        DobLabel.AutoSize = True
        DobLabel.Location = New System.Drawing.Point(5, 94)
        DobLabel.Name = "DobLabel"
        DobLabel.Size = New System.Drawing.Size(69, 13)
        DobLabel.TabIndex = 10
        DobLabel.Text = "Date of Birth:"
        '
        'DoaLabel
        '
        DoaLabel.AutoSize = True
        DoaLabel.Location = New System.Drawing.Point(5, 120)
        DoaLabel.Name = "DoaLabel"
        DoaLabel.Size = New System.Drawing.Size(77, 13)
        DoaLabel.TabIndex = 12
        DoaLabel.Text = "Date of Arrival:"
        '
        'ChippedLabel
        '
        ChippedLabel.AutoSize = True
        ChippedLabel.Location = New System.Drawing.Point(5, 147)
        ChippedLabel.Name = "ChippedLabel"
        ChippedLabel.Size = New System.Drawing.Size(59, 13)
        ChippedLabel.TabIndex = 14
        ChippedLabel.Text = "Micro-chip:"
        '
        'ChipNumLabel
        '
        ChipNumLabel.AutoSize = True
        ChipNumLabel.Location = New System.Drawing.Point(5, 175)
        ChipNumLabel.Name = "ChipNumLabel"
        ChipNumLabel.Size = New System.Drawing.Size(71, 13)
        ChipNumLabel.TabIndex = 16
        ChipNumLabel.Text = "Chip Number:"
        '
        'OwnerLabel
        '
        OwnerLabel.AutoSize = True
        OwnerLabel.Location = New System.Drawing.Point(5, 201)
        OwnerLabel.Name = "OwnerLabel"
        OwnerLabel.Size = New System.Drawing.Size(72, 13)
        OwnerLabel.TabIndex = 18
        OwnerLabel.Text = "Owner Name:"
        '
        'DateContactedLabel
        '
        DateContactedLabel.AutoSize = True
        DateContactedLabel.Location = New System.Drawing.Point(5, 228)
        DateContactedLabel.Name = "DateContactedLabel"
        DateContactedLabel.Size = New System.Drawing.Size(73, 13)
        DateContactedLabel.TabIndex = 20
        DateContactedLabel.Text = "Contact Date:"
        '
        'McDateLabel
        '
        McDateLabel.AutoSize = True
        McDateLabel.Location = New System.Drawing.Point(5, 254)
        McDateLabel.Name = "McDateLabel"
        McDateLabel.Size = New System.Drawing.Size(102, 13)
        McDateLabel.TabIndex = 22
        McDateLabel.Text = "Microchipping Date:"
        '
        'RelinPrtyLabel
        '
        RelinPrtyLabel.AutoSize = True
        RelinPrtyLabel.Location = New System.Drawing.Point(5, 279)
        RelinPrtyLabel.Name = "RelinPrtyLabel"
        RelinPrtyLabel.Size = New System.Drawing.Size(94, 13)
        RelinPrtyLabel.TabIndex = 24
        RelinPrtyLabel.Text = "Relinquising Party:"
        '
        'CageNumLabel
        '
        CageNumLabel.AutoSize = True
        CageNumLabel.Location = New System.Drawing.Point(5, 305)
        CageNumLabel.Name = "CageNumLabel"
        CageNumLabel.Size = New System.Drawing.Size(75, 13)
        CageNumLabel.TabIndex = 26
        CageNumLabel.Text = "Cage Number:"
        '
        'QuarentineLabel
        '
        QuarentineLabel.AutoSize = True
        QuarentineLabel.Location = New System.Drawing.Point(5, 333)
        QuarentineLabel.Name = "QuarentineLabel"
        QuarentineLabel.Size = New System.Drawing.Size(62, 13)
        QuarentineLabel.TabIndex = 28
        QuarentineLabel.Text = "Quarantine:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(49, 12)
        Me.NameTextBox.MaxLength = 50
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(147, 20)
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
        Me.AgeTextBox.Location = New System.Drawing.Point(49, 64)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(35, 20)
        Me.AgeTextBox.TabIndex = 9
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.Checked = False
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "dob", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "d"))
        Me.DobDateTimePicker.Location = New System.Drawing.Point(94, 90)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DobDateTimePicker.TabIndex = 11
        '
        'DoaDateTimePicker
        '
        Me.DoaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "doa", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "d"))
        Me.DoaDateTimePicker.Location = New System.Drawing.Point(94, 116)
        Me.DoaDateTimePicker.Name = "DoaDateTimePicker"
        Me.DoaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DoaDateTimePicker.TabIndex = 13
        '
        'ChippedCheckBox
        '
        Me.ChippedCheckBox.Location = New System.Drawing.Point(94, 142)
        Me.ChippedCheckBox.Name = "ChippedCheckBox"
        Me.ChippedCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.ChippedCheckBox.TabIndex = 15
        Me.ChippedCheckBox.Text = "Y/N"
        Me.ChippedCheckBox.UseVisualStyleBackColor = True
        '
        'ChipNumTextBox
        '
        Me.ChipNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "chipNum", True))
        Me.ChipNumTextBox.Location = New System.Drawing.Point(94, 172)
        Me.ChipNumTextBox.Name = "ChipNumTextBox"
        Me.ChipNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ChipNumTextBox.TabIndex = 17
        '
        'OwnerTextBox
        '
        Me.OwnerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "owner", True))
        Me.OwnerTextBox.Location = New System.Drawing.Point(94, 198)
        Me.OwnerTextBox.Name = "OwnerTextBox"
        Me.OwnerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OwnerTextBox.TabIndex = 19
        '
        'DateContactedDateTimePicker
        '
        Me.DateContactedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnimalMasterBindingSource, "dateContacted", True))
        Me.DateContactedDateTimePicker.Location = New System.Drawing.Point(94, 224)
        Me.DateContactedDateTimePicker.Name = "DateContactedDateTimePicker"
        Me.DateContactedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateContactedDateTimePicker.TabIndex = 21
        '
        'McDateDateTimePicker
        '
        Me.McDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnimalMasterBindingSource, "mcDate", True))
        Me.McDateDateTimePicker.Location = New System.Drawing.Point(113, 250)
        Me.McDateDateTimePicker.Name = "McDateDateTimePicker"
        Me.McDateDateTimePicker.Size = New System.Drawing.Size(181, 20)
        Me.McDateDateTimePicker.TabIndex = 23
        '
        'RelinPrtyTextBox
        '
        Me.RelinPrtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "relinPrty", True))
        Me.RelinPrtyTextBox.Location = New System.Drawing.Point(113, 276)
        Me.RelinPrtyTextBox.Name = "RelinPrtyTextBox"
        Me.RelinPrtyTextBox.Size = New System.Drawing.Size(181, 20)
        Me.RelinPrtyTextBox.TabIndex = 25
        '
        'CageNumTextBox
        '
        Me.CageNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "cageNum", True))
        Me.CageNumTextBox.Location = New System.Drawing.Point(94, 302)
        Me.CageNumTextBox.Name = "CageNumTextBox"
        Me.CageNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CageNumTextBox.TabIndex = 27
        '
        'QuarentineCheckBox
        '
        Me.QuarentineCheckBox.Checked = True
        Me.QuarentineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.QuarentineCheckBox.Location = New System.Drawing.Point(91, 329)
        Me.QuarentineCheckBox.Name = "QuarentineCheckBox"
        Me.QuarentineCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.QuarentineCheckBox.TabIndex = 29
        Me.QuarentineCheckBox.Text = "Y/N"
        Me.QuarentineCheckBox.UseVisualStyleBackColor = True
        '
        'ButtonContinue
        '
        Me.ButtonContinue.Location = New System.Drawing.Point(219, 328)
        Me.ButtonContinue.Name = "ButtonContinue"
        Me.ButtonContinue.Size = New System.Drawing.Size(75, 23)
        Me.ButtonContinue.TabIndex = 30
        Me.ButtonContinue.Text = "Continue"
        Me.ButtonContinue.UseVisualStyleBackColor = True
        '
        'ButtonCancle
        '
        Me.ButtonCancle.Location = New System.Drawing.Point(138, 329)
        Me.ButtonCancle.Name = "ButtonCancle"
        Me.ButtonCancle.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancle.TabIndex = 31
        Me.ButtonCancle.Text = "Cancel"
        Me.ButtonCancle.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Dog", "Cat", "Other"})
        Me.ComboBox1.Location = New System.Drawing.Point(49, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Tag = "2"
        Me.ComboBox1.Text = "Dog"
        '
        'lbl_InfoError
        '
        Me.lbl_InfoError.AutoSize = True
        Me.lbl_InfoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_InfoError.ForeColor = System.Drawing.Color.Red
        Me.lbl_InfoError.Location = New System.Drawing.Point(171, 355)
        Me.lbl_InfoError.Name = "lbl_InfoError"
        Me.lbl_InfoError.Size = New System.Drawing.Size(123, 13)
        Me.lbl_InfoError.TabIndex = 33
        Me.lbl_InfoError.Text = "*- Required Field Missing"
        Me.lbl_InfoError.Visible = False
        '
        'lbl_CageNumError
        '
        Me.lbl_CageNumError.AutoSize = True
        Me.lbl_CageNumError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_CageNumError.ForeColor = System.Drawing.Color.Red
        Me.lbl_CageNumError.Location = New System.Drawing.Point(296, 305)
        Me.lbl_CageNumError.Name = "lbl_CageNumError"
        Me.lbl_CageNumError.Size = New System.Drawing.Size(13, 17)
        Me.lbl_CageNumError.TabIndex = 34
        Me.lbl_CageNumError.Text = "*"
        Me.lbl_CageNumError.Visible = False
        '
        'lbl_RelinPrtyError
        '
        Me.lbl_RelinPrtyError.AutoSize = True
        Me.lbl_RelinPrtyError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_RelinPrtyError.ForeColor = System.Drawing.Color.Red
        Me.lbl_RelinPrtyError.Location = New System.Drawing.Point(296, 276)
        Me.lbl_RelinPrtyError.Name = "lbl_RelinPrtyError"
        Me.lbl_RelinPrtyError.Size = New System.Drawing.Size(13, 17)
        Me.lbl_RelinPrtyError.TabIndex = 36
        Me.lbl_RelinPrtyError.Text = "*"
        Me.lbl_RelinPrtyError.Visible = False
        '
        'lbl_OwnerNameError
        '
        Me.lbl_OwnerNameError.AutoSize = True
        Me.lbl_OwnerNameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_OwnerNameError.ForeColor = System.Drawing.Color.Red
        Me.lbl_OwnerNameError.Location = New System.Drawing.Point(296, 198)
        Me.lbl_OwnerNameError.Name = "lbl_OwnerNameError"
        Me.lbl_OwnerNameError.Size = New System.Drawing.Size(13, 17)
        Me.lbl_OwnerNameError.TabIndex = 37
        Me.lbl_OwnerNameError.Text = "*"
        Me.lbl_OwnerNameError.Visible = False
        '
        'lbl_ChipNumError
        '
        Me.lbl_ChipNumError.AutoSize = True
        Me.lbl_ChipNumError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_ChipNumError.ForeColor = System.Drawing.Color.Red
        Me.lbl_ChipNumError.Location = New System.Drawing.Point(296, 172)
        Me.lbl_ChipNumError.Name = "lbl_ChipNumError"
        Me.lbl_ChipNumError.Size = New System.Drawing.Size(13, 17)
        Me.lbl_ChipNumError.TabIndex = 41
        Me.lbl_ChipNumError.Text = "*"
        Me.lbl_ChipNumError.Visible = False
        '
        'lbl_NameError
        '
        Me.lbl_NameError.AutoSize = True
        Me.lbl_NameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_NameError.ForeColor = System.Drawing.Color.Red
        Me.lbl_NameError.Location = New System.Drawing.Point(198, 12)
        Me.lbl_NameError.Name = "lbl_NameError"
        Me.lbl_NameError.Size = New System.Drawing.Size(13, 17)
        Me.lbl_NameError.TabIndex = 43
        Me.lbl_NameError.Text = "*"
        Me.lbl_NameError.Visible = False
        '
        'lbl_AgeError
        '
        Me.lbl_AgeError.AutoSize = True
        Me.lbl_AgeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_AgeError.ForeColor = System.Drawing.Color.Red
        Me.lbl_AgeError.Location = New System.Drawing.Point(88, 64)
        Me.lbl_AgeError.Name = "lbl_AgeError"
        Me.lbl_AgeError.Size = New System.Drawing.Size(13, 17)
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
        Me.TableAdapterManager.CostReportTableAdapter = Nothing
        Me.TableAdapterManager.dogInfoTableAdapter = Nothing
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BasicInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(319, 364)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BasicInfoForm"
        Me.Text = "Basic Information"
        CType(Me.AnimalMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AllDataDataSet As FurryFriendsAnimalShelter.AllDataDataSet
    Friend WithEvents AnimalMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnimalMasterTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.animalMasterTableAdapter
    Friend WithEvents TableAdapterManager As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager
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
