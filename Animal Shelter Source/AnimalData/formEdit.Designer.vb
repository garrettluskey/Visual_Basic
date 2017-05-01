<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Dim CaseNumLabel As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditForm))
        Me.AnimalMasterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AnimalMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllDataDataSet = New FurryFriendsAnimalShelter.AllDataDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AnimalMasterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CaseNumTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
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
        Me.AnimalMasterDataGridView = New System.Windows.Forms.DataGridView()
        Me.ColumnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColumnClientReport = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTypeConvert = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cboxType = New System.Windows.Forms.ComboBox()
        Me.lblWeightDogCat = New System.Windows.Forms.Label()
        Me.txtWeightDog = New System.Windows.Forms.TextBox()
        Me.DogInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblHairColor = New System.Windows.Forms.Label()
        Me.txtHairColorDog = New System.Windows.Forms.TextBox()
        Me.lblHairType = New System.Windows.Forms.Label()
        Me.chkHairTypeDog = New System.Windows.Forms.CheckBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.chkGenderDog = New System.Windows.Forms.CheckBox()
        Me.lblNeutered = New System.Windows.Forms.Label()
        Me.chkNeuteredDog = New System.Windows.Forms.CheckBox()
        Me.lblFleaTest = New System.Windows.Forms.Label()
        Me.chkFleatestDog = New System.Windows.Forms.CheckBox()
        Me.lbl1Dog = New System.Windows.Forms.Label()
        Me.chkHeartwormtestDog = New System.Windows.Forms.CheckBox()
        Me.lbl2Dog = New System.Windows.Forms.Label()
        Me.datePickerLastTestDog = New System.Windows.Forms.DateTimePicker()
        Me.lbl3Dog = New System.Windows.Forms.Label()
        Me.datePickerMedStartDog = New System.Windows.Forms.DateTimePicker()
        Me.lbl4Dog = New System.Windows.Forms.Label()
        Me.datePickerRetestDog = New System.Windows.Forms.DateTimePicker()
        Me.lbl5Dog = New System.Windows.Forms.Label()
        Me.chkRabiesDog = New System.Windows.Forms.CheckBox()
        Me.lbl7Dog = New System.Windows.Forms.Label()
        Me.chkDistemperDog = New System.Windows.Forms.CheckBox()
        Me.lbl9Dog = New System.Windows.Forms.Label()
        Me.chkBordetellaDog = New System.Windows.Forms.CheckBox()
        Me.lbl6Dog = New System.Windows.Forms.Label()
        Me.datePickerRabiesDog = New System.Windows.Forms.DateTimePicker()
        Me.lbl8Dog = New System.Windows.Forms.Label()
        Me.datePickerDistemperDog = New System.Windows.Forms.DateTimePicker()
        Me.lbl10Dog = New System.Windows.Forms.Label()
        Me.datePickerBordetellaDog = New System.Windows.Forms.DateTimePicker()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.txtBreedDog = New System.Windows.Forms.TextBox()
        Me.lbl_ScrollPlaceHolder = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.caseNumSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWeightCat = New System.Windows.Forms.TextBox()
        Me.CatInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtHairColorCat = New System.Windows.Forms.TextBox()
        Me.chkHairtypeCat = New System.Windows.Forms.CheckBox()
        Me.chkGenderCat = New System.Windows.Forms.CheckBox()
        Me.chkNeuteredCat = New System.Windows.Forms.CheckBox()
        Me.chkFleaTestCat = New System.Windows.Forms.CheckBox()
        Me.datePickerFleaTestCat = New System.Windows.Forms.DateTimePicker()
        Me.lbl1Cat = New System.Windows.Forms.Label()
        Me.chkDeclawedCat = New System.Windows.Forms.CheckBox()
        Me.lbl2Cat = New System.Windows.Forms.Label()
        Me.chkFutureDeclawCat = New System.Windows.Forms.CheckBox()
        Me.lbl3Cat = New System.Windows.Forms.Label()
        Me.chkFutureDeclawInfoCat = New System.Windows.Forms.CheckBox()
        Me.lbl4Cat = New System.Windows.Forms.Label()
        Me.chkLeukemiaCat = New System.Windows.Forms.CheckBox()
        Me.lbl5Cat = New System.Windows.Forms.Label()
        Me.datePickerLeukemiaCat = New System.Windows.Forms.DateTimePicker()
        Me.lbl6Cat = New System.Windows.Forms.Label()
        Me.chkRabiesCat = New System.Windows.Forms.CheckBox()
        Me.txtBreedCat = New System.Windows.Forms.TextBox()
        Me.lblProcedureDate = New System.Windows.Forms.Label()
        Me.datePickerProcedureDog = New System.Windows.Forms.DateTimePicker()
        Me.lblStartMed = New System.Windows.Forms.Label()
        Me.datePickerStartMedDog = New System.Windows.Forms.DateTimePicker()
        Me.datePickerNeuteredCat = New System.Windows.Forms.DateTimePicker()
        Me.CatInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn13 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn17 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn18 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn19 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OtherInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rtxtAppearance = New System.Windows.Forms.RichTextBox()
        Me.txtWeightOther = New System.Windows.Forms.TextBox()
        Me.lblWeightOther = New System.Windows.Forms.Label()
        Me.rtxtVaccinations = New System.Windows.Forms.RichTextBox()
        Me.rtxtGeneralDescription = New System.Windows.Forms.RichTextBox()
        Me.lbl1Other = New System.Windows.Forms.Label()
        Me.lbl2VaccinationsOther = New System.Windows.Forms.Label()
        Me.lbl3GeneralDescriptionOther = New System.Windows.Forms.Label()
        Me.DogInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bordetella = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnimalMasterTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.animalMasterTableAdapter()
        Me.TableAdapterManager = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager()
        Me.CatInfoTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.CatInfoTableAdapter()
        Me.OtherInfoTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.OtherInfoTableAdapter()
        Me.ClientTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.ClientTableTableAdapter()
        Me.DogInfoTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.dogInfoTableAdapter()
        Me.OtherClientReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtherClientReportTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.OtherClientReportTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CostReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CostReportTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.CostReportTableAdapter()
        CaseNumLabel = New System.Windows.Forms.Label()
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
        CType(Me.AnimalMasterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnimalMasterBindingNavigator.SuspendLayout()
        CType(Me.AnimalMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalMasterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DogInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DogInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherClientReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaseNumLabel
        '
        CaseNumLabel.AutoSize = True
        CaseNumLabel.Location = New System.Drawing.Point(6, 31)
        CaseNumLabel.Name = "CaseNumLabel"
        CaseNumLabel.Size = New System.Drawing.Size(74, 13)
        CaseNumLabel.TabIndex = 1
        CaseNumLabel.Text = "Case Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(6, 57)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(72, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Animal Name:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(6, 83)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(68, 13)
        TypeLabel.TabIndex = 5
        TypeLabel.Text = "Animal Type:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(6, 109)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 7
        AgeLabel.Text = "Age:"
        '
        'DobLabel
        '
        DobLabel.AutoSize = True
        DobLabel.Location = New System.Drawing.Point(6, 136)
        DobLabel.Name = "DobLabel"
        DobLabel.Size = New System.Drawing.Size(69, 13)
        DobLabel.TabIndex = 9
        DobLabel.Text = "Date of Birth:"
        '
        'DoaLabel
        '
        DoaLabel.AutoSize = True
        DoaLabel.Location = New System.Drawing.Point(6, 162)
        DoaLabel.Name = "DoaLabel"
        DoaLabel.Size = New System.Drawing.Size(77, 13)
        DoaLabel.TabIndex = 11
        DoaLabel.Text = "Date of Arrival:"
        '
        'ChippedLabel
        '
        ChippedLabel.AutoSize = True
        ChippedLabel.Location = New System.Drawing.Point(6, 189)
        ChippedLabel.Name = "ChippedLabel"
        ChippedLabel.Size = New System.Drawing.Size(77, 13)
        ChippedLabel.TabIndex = 13
        ChippedLabel.Text = "Micro-chipped:"
        '
        'ChipNumLabel
        '
        ChipNumLabel.AutoSize = True
        ChipNumLabel.Location = New System.Drawing.Point(6, 217)
        ChipNumLabel.Name = "ChipNumLabel"
        ChipNumLabel.Size = New System.Drawing.Size(71, 13)
        ChipNumLabel.TabIndex = 15
        ChipNumLabel.Text = "Chip Number:"
        '
        'OwnerLabel
        '
        OwnerLabel.AutoSize = True
        OwnerLabel.Location = New System.Drawing.Point(6, 243)
        OwnerLabel.Name = "OwnerLabel"
        OwnerLabel.Size = New System.Drawing.Size(72, 13)
        OwnerLabel.TabIndex = 17
        OwnerLabel.Text = "Owner Name:"
        '
        'DateContactedLabel
        '
        DateContactedLabel.AutoSize = True
        DateContactedLabel.Location = New System.Drawing.Point(6, 270)
        DateContactedLabel.Name = "DateContactedLabel"
        DateContactedLabel.Size = New System.Drawing.Size(85, 13)
        DateContactedLabel.TabIndex = 19
        DateContactedLabel.Text = "Date Contacted:"
        '
        'McDateLabel
        '
        McDateLabel.AutoSize = True
        McDateLabel.Location = New System.Drawing.Point(6, 296)
        McDateLabel.Name = "McDateLabel"
        McDateLabel.Size = New System.Drawing.Size(85, 13)
        McDateLabel.TabIndex = 21
        McDateLabel.Text = "Micro-chip Date:"
        '
        'RelinPrtyLabel
        '
        RelinPrtyLabel.AutoSize = True
        RelinPrtyLabel.Location = New System.Drawing.Point(6, 314)
        RelinPrtyLabel.Name = "RelinPrtyLabel"
        RelinPrtyLabel.Size = New System.Drawing.Size(73, 26)
        RelinPrtyLabel.TabIndex = 23
        RelinPrtyLabel.Text = "Relinquishing " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Party:"
        '
        'CageNumLabel
        '
        CageNumLabel.AutoSize = True
        CageNumLabel.Location = New System.Drawing.Point(6, 347)
        CageNumLabel.Name = "CageNumLabel"
        CageNumLabel.Size = New System.Drawing.Size(75, 13)
        CageNumLabel.TabIndex = 25
        CageNumLabel.Text = "Cage Number:"
        '
        'QuarentineLabel
        '
        QuarentineLabel.AutoSize = True
        QuarentineLabel.Location = New System.Drawing.Point(6, 375)
        QuarentineLabel.Name = "QuarentineLabel"
        QuarentineLabel.Size = New System.Drawing.Size(62, 13)
        QuarentineLabel.TabIndex = 27
        QuarentineLabel.Text = "Quarantine:"
        '
        'AnimalMasterBindingNavigator
        '
        Me.AnimalMasterBindingNavigator.AddNewItem = Nothing
        Me.AnimalMasterBindingNavigator.BindingSource = Me.AnimalMasterBindingSource
        Me.AnimalMasterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnimalMasterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AnimalMasterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.AnimalMasterBindingNavigatorSaveItem})
        Me.AnimalMasterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnimalMasterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AnimalMasterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AnimalMasterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AnimalMasterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AnimalMasterBindingNavigator.Name = "AnimalMasterBindingNavigator"
        Me.AnimalMasterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnimalMasterBindingNavigator.Size = New System.Drawing.Size(1333, 25)
        Me.AnimalMasterBindingNavigator.TabIndex = 0
        Me.AnimalMasterBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AnimalMasterBindingNavigatorSaveItem
        '
        Me.AnimalMasterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnimalMasterBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnimalMasterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnimalMasterBindingNavigatorSaveItem.Name = "AnimalMasterBindingNavigatorSaveItem"
        Me.AnimalMasterBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AnimalMasterBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CaseNumTextBox
        '
        Me.CaseNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "caseNum", True))
        Me.CaseNumTextBox.Location = New System.Drawing.Point(95, 28)
        Me.CaseNumTextBox.Name = "CaseNumTextBox"
        Me.CaseNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CaseNumTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(95, 54)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(95, 106)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgeTextBox.TabIndex = 8
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnimalMasterBindingSource, "dob", True))
        Me.DobDateTimePicker.Location = New System.Drawing.Point(95, 132)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DobDateTimePicker.TabIndex = 10
        '
        'DoaDateTimePicker
        '
        Me.DoaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnimalMasterBindingSource, "doa", True))
        Me.DoaDateTimePicker.Location = New System.Drawing.Point(95, 158)
        Me.DoaDateTimePicker.Name = "DoaDateTimePicker"
        Me.DoaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DoaDateTimePicker.TabIndex = 12
        '
        'ChippedCheckBox
        '
        Me.ChippedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AnimalMasterBindingSource, "chipped", True))
        Me.ChippedCheckBox.Location = New System.Drawing.Point(95, 184)
        Me.ChippedCheckBox.Name = "ChippedCheckBox"
        Me.ChippedCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.ChippedCheckBox.TabIndex = 14
        Me.ChippedCheckBox.Text = "Y/N"
        Me.ChippedCheckBox.UseVisualStyleBackColor = True
        '
        'ChipNumTextBox
        '
        Me.ChipNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "chipNum", True))
        Me.ChipNumTextBox.Location = New System.Drawing.Point(95, 214)
        Me.ChipNumTextBox.Name = "ChipNumTextBox"
        Me.ChipNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ChipNumTextBox.TabIndex = 16
        '
        'OwnerTextBox
        '
        Me.OwnerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "owner", True))
        Me.OwnerTextBox.Location = New System.Drawing.Point(95, 240)
        Me.OwnerTextBox.Name = "OwnerTextBox"
        Me.OwnerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OwnerTextBox.TabIndex = 18
        '
        'DateContactedDateTimePicker
        '
        Me.DateContactedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnimalMasterBindingSource, "dateContacted", True))
        Me.DateContactedDateTimePicker.Location = New System.Drawing.Point(95, 266)
        Me.DateContactedDateTimePicker.Name = "DateContactedDateTimePicker"
        Me.DateContactedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateContactedDateTimePicker.TabIndex = 20
        '
        'McDateDateTimePicker
        '
        Me.McDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AnimalMasterBindingSource, "mcDate", True))
        Me.McDateDateTimePicker.Location = New System.Drawing.Point(95, 292)
        Me.McDateDateTimePicker.Name = "McDateDateTimePicker"
        Me.McDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.McDateDateTimePicker.TabIndex = 22
        '
        'RelinPrtyTextBox
        '
        Me.RelinPrtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "relinPrty", True))
        Me.RelinPrtyTextBox.Location = New System.Drawing.Point(95, 318)
        Me.RelinPrtyTextBox.Name = "RelinPrtyTextBox"
        Me.RelinPrtyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RelinPrtyTextBox.TabIndex = 24
        '
        'CageNumTextBox
        '
        Me.CageNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnimalMasterBindingSource, "cageNum", True))
        Me.CageNumTextBox.Location = New System.Drawing.Point(95, 344)
        Me.CageNumTextBox.Name = "CageNumTextBox"
        Me.CageNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CageNumTextBox.TabIndex = 26
        '
        'QuarentineCheckBox
        '
        Me.QuarentineCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AnimalMasterBindingSource, "quarentine", True))
        Me.QuarentineCheckBox.Location = New System.Drawing.Point(95, 370)
        Me.QuarentineCheckBox.Name = "QuarentineCheckBox"
        Me.QuarentineCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.QuarentineCheckBox.TabIndex = 28
        Me.QuarentineCheckBox.Text = "Y/N"
        Me.QuarentineCheckBox.UseVisualStyleBackColor = True
        '
        'AnimalMasterDataGridView
        '
        Me.AnimalMasterDataGridView.AllowUserToAddRows = False
        Me.AnimalMasterDataGridView.AutoGenerateColumns = False
        Me.AnimalMasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnimalMasterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnEdit, Me.ColumnClientReport, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.ColumnType, Me.ColumnTypeConvert, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn2})
        Me.AnimalMasterDataGridView.DataSource = Me.AnimalMasterBindingSource
        Me.AnimalMasterDataGridView.Location = New System.Drawing.Point(391, 83)
        Me.AnimalMasterDataGridView.MultiSelect = False
        Me.AnimalMasterDataGridView.Name = "AnimalMasterDataGridView"
        Me.AnimalMasterDataGridView.Size = New System.Drawing.Size(942, 347)
        Me.AnimalMasterDataGridView.TabIndex = 29
        '
        'ColumnEdit
        '
        Me.ColumnEdit.DataPropertyName = "caseNum"
        Me.ColumnEdit.HeaderText = "Select For Edit/Delete"
        Me.ColumnEdit.Name = "ColumnEdit"
        Me.ColumnEdit.Text = "Edit"
        Me.ColumnEdit.UseColumnTextForButtonValue = True
        '
        'ColumnClientReport
        '
        Me.ColumnClientReport.HeaderText = "Client Report"
        Me.ColumnClientReport.Name = "ColumnClientReport"
        Me.ColumnClientReport.Text = "Select"
        Me.ColumnClientReport.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "caseNum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Case Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'ColumnType
        '
        Me.ColumnType.HeaderText = "Animal Type"
        Me.ColumnType.Name = "ColumnType"
        '
        'ColumnTypeConvert
        '
        Me.ColumnTypeConvert.DataPropertyName = "type"
        Me.ColumnTypeConvert.HeaderText = "Animal Type"
        Me.ColumnTypeConvert.Name = "ColumnTypeConvert"
        Me.ColumnTypeConvert.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "dob"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date of Birth"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "doa"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date of Arrival"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "chipped"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Microchipped"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "chipNum"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Chip Number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "owner"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Owner Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "dateContacted"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Contact Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "mcDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Microchipping Date"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "relinPrty"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Relinquising Party"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cageNum"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cage Number"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "quarentine"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Quarentine"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'cboxType
        '
        Me.cboxType.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.AnimalMasterBindingSource, "type", True))
        Me.cboxType.Items.AddRange(New Object() {"Dog", "Cat", "Other"})
        Me.cboxType.Location = New System.Drawing.Point(95, 79)
        Me.cboxType.Name = "cboxType"
        Me.cboxType.Size = New System.Drawing.Size(200, 21)
        Me.cboxType.TabIndex = 33
        '
        'lblWeightDogCat
        '
        Me.lblWeightDogCat.AutoSize = True
        Me.lblWeightDogCat.Location = New System.Drawing.Point(6, 426)
        Me.lblWeightDogCat.Name = "lblWeightDogCat"
        Me.lblWeightDogCat.Size = New System.Drawing.Size(44, 13)
        Me.lblWeightDogCat.TabIndex = 41
        Me.lblWeightDogCat.Text = "Weight:"
        '
        'txtWeightDog
        '
        Me.txtWeightDog.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DogInfoBindingSource, "weight", True))
        Me.txtWeightDog.Location = New System.Drawing.Point(95, 426)
        Me.txtWeightDog.Name = "txtWeightDog"
        Me.txtWeightDog.Size = New System.Drawing.Size(200, 20)
        Me.txtWeightDog.TabIndex = 42
        '
        'DogInfoBindingSource
        '
        Me.DogInfoBindingSource.DataMember = "dogInfo"
        Me.DogInfoBindingSource.DataSource = Me.AllDataDataSet
        '
        'lblHairColor
        '
        Me.lblHairColor.AutoSize = True
        Me.lblHairColor.Location = New System.Drawing.Point(6, 452)
        Me.lblHairColor.Name = "lblHairColor"
        Me.lblHairColor.Size = New System.Drawing.Size(56, 13)
        Me.lblHairColor.TabIndex = 43
        Me.lblHairColor.Text = "Hair Color:"
        '
        'txtHairColorDog
        '
        Me.txtHairColorDog.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DogInfoBindingSource, "hairColor", True))
        Me.txtHairColorDog.Location = New System.Drawing.Point(95, 452)
        Me.txtHairColorDog.Name = "txtHairColorDog"
        Me.txtHairColorDog.Size = New System.Drawing.Size(200, 20)
        Me.txtHairColorDog.TabIndex = 44
        '
        'lblHairType
        '
        Me.lblHairType.AutoSize = True
        Me.lblHairType.Location = New System.Drawing.Point(6, 480)
        Me.lblHairType.Name = "lblHairType"
        Me.lblHairType.Size = New System.Drawing.Size(56, 13)
        Me.lblHairType.TabIndex = 45
        Me.lblHairType.Text = "Hair Type:"
        '
        'chkHairTypeDog
        '
        Me.chkHairTypeDog.Location = New System.Drawing.Point(95, 478)
        Me.chkHairTypeDog.Name = "chkHairTypeDog"
        Me.chkHairTypeDog.Size = New System.Drawing.Size(200, 24)
        Me.chkHairTypeDog.TabIndex = 46
        Me.chkHairTypeDog.Text = "Long/Short"
        Me.chkHairTypeDog.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(6, 510)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 47
        Me.lblGender.Text = "Gender:"
        '
        'chkGenderDog
        '
        Me.chkGenderDog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DogInfoBindingSource, "gender", True))
        Me.chkGenderDog.Location = New System.Drawing.Point(95, 508)
        Me.chkGenderDog.Name = "chkGenderDog"
        Me.chkGenderDog.Size = New System.Drawing.Size(200, 24)
        Me.chkGenderDog.TabIndex = 48
        Me.chkGenderDog.Text = "Male/Female"
        Me.chkGenderDog.UseVisualStyleBackColor = True
        '
        'lblNeutered
        '
        Me.lblNeutered.AutoSize = True
        Me.lblNeutered.Location = New System.Drawing.Point(6, 536)
        Me.lblNeutered.Name = "lblNeutered"
        Me.lblNeutered.Size = New System.Drawing.Size(55, 26)
        Me.lblNeutered.TabIndex = 49
        Me.lblNeutered.Text = "Spayed or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Neutered:"
        '
        'chkNeuteredDog
        '
        Me.chkNeuteredDog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DogInfoBindingSource, "neutered", True))
        Me.chkNeuteredDog.Location = New System.Drawing.Point(95, 538)
        Me.chkNeuteredDog.Name = "chkNeuteredDog"
        Me.chkNeuteredDog.Size = New System.Drawing.Size(200, 24)
        Me.chkNeuteredDog.TabIndex = 50
        Me.chkNeuteredDog.Text = "Y/N"
        Me.chkNeuteredDog.UseVisualStyleBackColor = True
        '
        'lblFleaTest
        '
        Me.lblFleaTest.AutoSize = True
        Me.lblFleaTest.Location = New System.Drawing.Point(6, 596)
        Me.lblFleaTest.Name = "lblFleaTest"
        Me.lblFleaTest.Size = New System.Drawing.Size(54, 13)
        Me.lblFleaTest.TabIndex = 51
        Me.lblFleaTest.Text = "Flea Test:"
        '
        'chkFleatestDog
        '
        Me.chkFleatestDog.Location = New System.Drawing.Point(95, 594)
        Me.chkFleatestDog.Name = "chkFleatestDog"
        Me.chkFleatestDog.Size = New System.Drawing.Size(200, 24)
        Me.chkFleatestDog.TabIndex = 52
        Me.chkFleatestDog.Text = "Pos/Neg"
        Me.chkFleatestDog.UseVisualStyleBackColor = True
        '
        'lbl1Dog
        '
        Me.lbl1Dog.AutoSize = True
        Me.lbl1Dog.Location = New System.Drawing.Point(6, 652)
        Me.lbl1Dog.Name = "lbl1Dog"
        Me.lbl1Dog.Size = New System.Drawing.Size(85, 13)
        Me.lbl1Dog.TabIndex = 53
        Me.lbl1Dog.Text = "Heartworm Test:"
        '
        'chkHeartwormtestDog
        '
        Me.chkHeartwormtestDog.Location = New System.Drawing.Point(95, 650)
        Me.chkHeartwormtestDog.Name = "chkHeartwormtestDog"
        Me.chkHeartwormtestDog.Size = New System.Drawing.Size(200, 24)
        Me.chkHeartwormtestDog.TabIndex = 54
        Me.chkHeartwormtestDog.Text = "Pos/Neg"
        Me.chkHeartwormtestDog.UseVisualStyleBackColor = True
        '
        'lbl2Dog
        '
        Me.lbl2Dog.AutoSize = True
        Me.lbl2Dog.Location = New System.Drawing.Point(6, 674)
        Me.lbl2Dog.Name = "lbl2Dog"
        Me.lbl2Dog.Size = New System.Drawing.Size(71, 26)
        Me.lbl2Dog.TabIndex = 55
        Me.lbl2Dog.Text = "Most Recent " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test Date:"
        '
        'datePickerLastTestDog
        '
        Me.datePickerLastTestDog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DogInfoBindingSource, "firstTestDate", True))
        Me.datePickerLastTestDog.Location = New System.Drawing.Point(95, 680)
        Me.datePickerLastTestDog.Name = "datePickerLastTestDog"
        Me.datePickerLastTestDog.Size = New System.Drawing.Size(200, 20)
        Me.datePickerLastTestDog.TabIndex = 56
        '
        'lbl3Dog
        '
        Me.lbl3Dog.AutoSize = True
        Me.lbl3Dog.Location = New System.Drawing.Point(6, 703)
        Me.lbl3Dog.Name = "lbl3Dog"
        Me.lbl3Dog.Size = New System.Drawing.Size(87, 26)
        Me.lbl3Dog.TabIndex = 57
        Me.lbl3Dog.Text = "Start Medication " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date:"
        '
        'datePickerMedStartDog
        '
        Me.datePickerMedStartDog.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DogInfoBindingSource, "medDate", True))
        Me.datePickerMedStartDog.Location = New System.Drawing.Point(95, 706)
        Me.datePickerMedStartDog.Name = "datePickerMedStartDog"
        Me.datePickerMedStartDog.Size = New System.Drawing.Size(200, 20)
        Me.datePickerMedStartDog.TabIndex = 58
        '
        'lbl4Dog
        '
        Me.lbl4Dog.AutoSize = True
        Me.lbl4Dog.Location = New System.Drawing.Point(6, 738)
        Me.lbl4Dog.Name = "lbl4Dog"
        Me.lbl4Dog.Size = New System.Drawing.Size(67, 13)
        Me.lbl4Dog.TabIndex = 59
        Me.lbl4Dog.Text = "Retest Date:"
        '
        'datePickerRetestDog
        '
        Me.datePickerRetestDog.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DogInfoBindingSource, "lastTestDate", True))
        Me.datePickerRetestDog.Location = New System.Drawing.Point(95, 732)
        Me.datePickerRetestDog.Name = "datePickerRetestDog"
        Me.datePickerRetestDog.Size = New System.Drawing.Size(200, 20)
        Me.datePickerRetestDog.TabIndex = 60
        '
        'lbl5Dog
        '
        Me.lbl5Dog.AutoSize = True
        Me.lbl5Dog.Location = New System.Drawing.Point(6, 756)
        Me.lbl5Dog.Name = "lbl5Dog"
        Me.lbl5Dog.Size = New System.Drawing.Size(66, 26)
        Me.lbl5Dog.TabIndex = 61
        Me.lbl5Dog.Text = "Rabies " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vaccination:"
        '
        'chkRabiesDog
        '
        Me.chkRabiesDog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DogInfoBindingSource, "rabies", True))
        Me.chkRabiesDog.Location = New System.Drawing.Point(95, 758)
        Me.chkRabiesDog.Name = "chkRabiesDog"
        Me.chkRabiesDog.Size = New System.Drawing.Size(200, 24)
        Me.chkRabiesDog.TabIndex = 62
        Me.chkRabiesDog.Text = "Y/N"
        Me.chkRabiesDog.UseVisualStyleBackColor = True
        '
        'lbl7Dog
        '
        Me.lbl7Dog.AutoSize = True
        Me.lbl7Dog.Location = New System.Drawing.Point(6, 822)
        Me.lbl7Dog.Name = "lbl7Dog"
        Me.lbl7Dog.Size = New System.Drawing.Size(66, 26)
        Me.lbl7Dog.TabIndex = 63
        Me.lbl7Dog.Text = "Distemper " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vaccination:"
        '
        'chkDistemperDog
        '
        Me.chkDistemperDog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DogInfoBindingSource, "distemper", True))
        Me.chkDistemperDog.Location = New System.Drawing.Point(95, 824)
        Me.chkDistemperDog.Name = "chkDistemperDog"
        Me.chkDistemperDog.Size = New System.Drawing.Size(200, 24)
        Me.chkDistemperDog.TabIndex = 64
        Me.chkDistemperDog.Text = "Y/N"
        Me.chkDistemperDog.UseVisualStyleBackColor = True
        '
        'lbl9Dog
        '
        Me.lbl9Dog.AutoSize = True
        Me.lbl9Dog.Location = New System.Drawing.Point(6, 890)
        Me.lbl9Dog.Name = "lbl9Dog"
        Me.lbl9Dog.Size = New System.Drawing.Size(66, 26)
        Me.lbl9Dog.TabIndex = 65
        Me.lbl9Dog.Text = "Bordetella" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vaccination:"
        '
        'chkBordetellaDog
        '
        Me.chkBordetellaDog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DogInfoBindingSource, "bordetella", True))
        Me.chkBordetellaDog.Location = New System.Drawing.Point(95, 892)
        Me.chkBordetellaDog.Name = "chkBordetellaDog"
        Me.chkBordetellaDog.Size = New System.Drawing.Size(200, 24)
        Me.chkBordetellaDog.TabIndex = 66
        Me.chkBordetellaDog.Text = "Y/N"
        Me.chkBordetellaDog.UseVisualStyleBackColor = True
        '
        'lbl6Dog
        '
        Me.lbl6Dog.AutoSize = True
        Me.lbl6Dog.Location = New System.Drawing.Point(6, 782)
        Me.lbl6Dog.Name = "lbl6Dog"
        Me.lbl6Dog.Size = New System.Drawing.Size(57, 26)
        Me.lbl6Dog.TabIndex = 67
        Me.lbl6Dog.Text = "Rabies " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test Date:"
        '
        'datePickerRabiesDog
        '
        Me.datePickerRabiesDog.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DogInfoBindingSource, "rabiesTestDate", True))
        Me.datePickerRabiesDog.Location = New System.Drawing.Point(95, 788)
        Me.datePickerRabiesDog.Name = "datePickerRabiesDog"
        Me.datePickerRabiesDog.Size = New System.Drawing.Size(200, 20)
        Me.datePickerRabiesDog.TabIndex = 68
        '
        'lbl8Dog
        '
        Me.lbl8Dog.AutoSize = True
        Me.lbl8Dog.Location = New System.Drawing.Point(6, 848)
        Me.lbl8Dog.Name = "lbl8Dog"
        Me.lbl8Dog.Size = New System.Drawing.Size(57, 26)
        Me.lbl8Dog.TabIndex = 69
        Me.lbl8Dog.Text = "Distemper " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test Date:"
        '
        'datePickerDistemperDog
        '
        Me.datePickerDistemperDog.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DogInfoBindingSource, "distemperTestDate", True))
        Me.datePickerDistemperDog.Location = New System.Drawing.Point(95, 854)
        Me.datePickerDistemperDog.Name = "datePickerDistemperDog"
        Me.datePickerDistemperDog.Size = New System.Drawing.Size(200, 20)
        Me.datePickerDistemperDog.TabIndex = 70
        '
        'lbl10Dog
        '
        Me.lbl10Dog.AutoSize = True
        Me.lbl10Dog.Location = New System.Drawing.Point(6, 916)
        Me.lbl10Dog.Name = "lbl10Dog"
        Me.lbl10Dog.Size = New System.Drawing.Size(57, 26)
        Me.lbl10Dog.TabIndex = 71
        Me.lbl10Dog.Text = "Bordetella " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test Date:"
        '
        'datePickerBordetellaDog
        '
        Me.datePickerBordetellaDog.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DogInfoBindingSource, "bordetellaTestDate", True))
        Me.datePickerBordetellaDog.Location = New System.Drawing.Point(95, 922)
        Me.datePickerBordetellaDog.Name = "datePickerBordetellaDog"
        Me.datePickerBordetellaDog.Size = New System.Drawing.Size(200, 20)
        Me.datePickerBordetellaDog.TabIndex = 72
        '
        'lblBreed
        '
        Me.lblBreed.AutoSize = True
        Me.lblBreed.Location = New System.Drawing.Point(6, 400)
        Me.lblBreed.Name = "lblBreed"
        Me.lblBreed.Size = New System.Drawing.Size(38, 13)
        Me.lblBreed.TabIndex = 73
        Me.lblBreed.Text = "Breed:"
        '
        'txtBreedDog
        '
        Me.txtBreedDog.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DogInfoBindingSource, "breed", True))
        Me.txtBreedDog.Location = New System.Drawing.Point(95, 400)
        Me.txtBreedDog.Name = "txtBreedDog"
        Me.txtBreedDog.Size = New System.Drawing.Size(200, 20)
        Me.txtBreedDog.TabIndex = 74
        '
        'lbl_ScrollPlaceHolder
        '
        Me.lbl_ScrollPlaceHolder.AutoSize = True
        Me.lbl_ScrollPlaceHolder.Location = New System.Drawing.Point(184, 945)
        Me.lbl_ScrollPlaceHolder.Name = "lbl_ScrollPlaceHolder"
        Me.lbl_ScrollPlaceHolder.Size = New System.Drawing.Size(0, 13)
        Me.lbl_ScrollPlaceHolder.TabIndex = 78
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(530, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 23)
        Me.Button3.TabIndex = 85
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(432, 52)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 23)
        Me.Button4.TabIndex = 84
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'caseNumSearch
        '
        Me.caseNumSearch.Location = New System.Drawing.Point(631, 54)
        Me.caseNumSearch.Name = "caseNumSearch"
        Me.caseNumSearch.Size = New System.Drawing.Size(94, 20)
        Me.caseNumSearch.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(628, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Case Number"
        '
        'txtWeightCat
        '
        Me.txtWeightCat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatInfoBindingSource, "weight", True))
        Me.txtWeightCat.Location = New System.Drawing.Point(95, 427)
        Me.txtWeightCat.Name = "txtWeightCat"
        Me.txtWeightCat.Size = New System.Drawing.Size(200, 20)
        Me.txtWeightCat.TabIndex = 95
        '
        'CatInfoBindingSource
        '
        Me.CatInfoBindingSource.DataMember = "CatInfo"
        Me.CatInfoBindingSource.DataSource = Me.AllDataDataSet
        '
        'txtHairColorCat
        '
        Me.txtHairColorCat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatInfoBindingSource, "haircolor", True))
        Me.txtHairColorCat.Location = New System.Drawing.Point(95, 453)
        Me.txtHairColorCat.Name = "txtHairColorCat"
        Me.txtHairColorCat.Size = New System.Drawing.Size(200, 20)
        Me.txtHairColorCat.TabIndex = 97
        '
        'chkHairtypeCat
        '
        Me.chkHairtypeCat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CatInfoBindingSource, "hairtype", True))
        Me.chkHairtypeCat.Location = New System.Drawing.Point(95, 479)
        Me.chkHairtypeCat.Name = "chkHairtypeCat"
        Me.chkHairtypeCat.Size = New System.Drawing.Size(200, 24)
        Me.chkHairtypeCat.TabIndex = 99
        Me.chkHairtypeCat.Text = "Long/Short"
        Me.chkHairtypeCat.UseVisualStyleBackColor = True
        '
        'chkGenderCat
        '
        Me.chkGenderCat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CatInfoBindingSource, "gender", True))
        Me.chkGenderCat.Location = New System.Drawing.Point(95, 509)
        Me.chkGenderCat.Name = "chkGenderCat"
        Me.chkGenderCat.Size = New System.Drawing.Size(200, 24)
        Me.chkGenderCat.TabIndex = 101
        Me.chkGenderCat.Text = "Male/Female"
        Me.chkGenderCat.UseVisualStyleBackColor = True
        '
        'chkNeuteredCat
        '
        Me.chkNeuteredCat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CatInfoBindingSource, "neutered", True))
        Me.chkNeuteredCat.Location = New System.Drawing.Point(95, 539)
        Me.chkNeuteredCat.Name = "chkNeuteredCat"
        Me.chkNeuteredCat.Size = New System.Drawing.Size(200, 24)
        Me.chkNeuteredCat.TabIndex = 103
        Me.chkNeuteredCat.Text = "Y/N"
        Me.chkNeuteredCat.UseVisualStyleBackColor = True
        '
        'chkFleaTestCat
        '
        Me.chkFleaTestCat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CatInfoBindingSource, "fleaTest", True))
        Me.chkFleaTestCat.Location = New System.Drawing.Point(95, 595)
        Me.chkFleaTestCat.Name = "chkFleaTestCat"
        Me.chkFleaTestCat.Size = New System.Drawing.Size(200, 24)
        Me.chkFleaTestCat.TabIndex = 105
        Me.chkFleaTestCat.Text = "Pos/Neg"
        Me.chkFleaTestCat.UseVisualStyleBackColor = True
        '
        'datePickerFleaTestCat
        '
        Me.datePickerFleaTestCat.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CatInfoBindingSource, "fleaTestDate", True))
        Me.datePickerFleaTestCat.Location = New System.Drawing.Point(113, 625)
        Me.datePickerFleaTestCat.Name = "datePickerFleaTestCat"
        Me.datePickerFleaTestCat.Size = New System.Drawing.Size(182, 20)
        Me.datePickerFleaTestCat.TabIndex = 107
        '
        'lbl1Cat
        '
        Me.lbl1Cat.AutoSize = True
        Me.lbl1Cat.Location = New System.Drawing.Point(6, 650)
        Me.lbl1Cat.Name = "lbl1Cat"
        Me.lbl1Cat.Size = New System.Drawing.Size(58, 13)
        Me.lbl1Cat.TabIndex = 108
        Me.lbl1Cat.Text = "Declawed:"
        '
        'chkDeclawedCat
        '
        Me.chkDeclawedCat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CatInfoBindingSource, "declawed", True))
        Me.chkDeclawedCat.Location = New System.Drawing.Point(95, 652)
        Me.chkDeclawedCat.Name = "chkDeclawedCat"
        Me.chkDeclawedCat.Size = New System.Drawing.Size(200, 24)
        Me.chkDeclawedCat.TabIndex = 109
        Me.chkDeclawedCat.Text = "Y/N"
        Me.chkDeclawedCat.UseVisualStyleBackColor = True
        '
        'lbl2Cat
        '
        Me.lbl2Cat.AutoSize = True
        Me.lbl2Cat.Location = New System.Drawing.Point(6, 674)
        Me.lbl2Cat.Name = "lbl2Cat"
        Me.lbl2Cat.Size = New System.Drawing.Size(60, 26)
        Me.lbl2Cat.TabIndex = 110
        Me.lbl2Cat.Text = "Schedule " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Declawing:"
        '
        'chkFutureDeclawCat
        '
        Me.chkFutureDeclawCat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CatInfoBindingSource, "futureDeclaw", True))
        Me.chkFutureDeclawCat.Location = New System.Drawing.Point(95, 682)
        Me.chkFutureDeclawCat.Name = "chkFutureDeclawCat"
        Me.chkFutureDeclawCat.Size = New System.Drawing.Size(200, 24)
        Me.chkFutureDeclawCat.TabIndex = 111
        Me.chkFutureDeclawCat.Text = "Y/N"
        Me.chkFutureDeclawCat.UseVisualStyleBackColor = True
        '
        'lbl3Cat
        '
        Me.lbl3Cat.AutoSize = True
        Me.lbl3Cat.Location = New System.Drawing.Point(6, 701)
        Me.lbl3Cat.Name = "lbl3Cat"
        Me.lbl3Cat.Size = New System.Drawing.Size(61, 39)
        Me.lbl3Cat.TabIndex = 112
        Me.lbl3Cat.Text = "Scheduled " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Declaw" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Procedure:"
        '
        'chkFutureDeclawInfoCat
        '
        Me.chkFutureDeclawInfoCat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CatInfoBindingSource, "futureDeclawInfo", True))
        Me.chkFutureDeclawInfoCat.Location = New System.Drawing.Point(95, 712)
        Me.chkFutureDeclawInfoCat.Name = "chkFutureDeclawInfoCat"
        Me.chkFutureDeclawInfoCat.Size = New System.Drawing.Size(200, 24)
        Me.chkFutureDeclawInfoCat.TabIndex = 113
        Me.chkFutureDeclawInfoCat.Text = "Front/Front and Back"
        Me.chkFutureDeclawInfoCat.UseVisualStyleBackColor = True
        '
        'lbl4Cat
        '
        Me.lbl4Cat.AutoSize = True
        Me.lbl4Cat.Location = New System.Drawing.Point(6, 740)
        Me.lbl4Cat.Name = "lbl4Cat"
        Me.lbl4Cat.Size = New System.Drawing.Size(56, 26)
        Me.lbl4Cat.TabIndex = 114
        Me.lbl4Cat.Text = "Leukemia " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test:"
        '
        'chkLeukemiaCat
        '
        Me.chkLeukemiaCat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CatInfoBindingSource, "leukemia", True))
        Me.chkLeukemiaCat.Location = New System.Drawing.Point(95, 742)
        Me.chkLeukemiaCat.Name = "chkLeukemiaCat"
        Me.chkLeukemiaCat.Size = New System.Drawing.Size(200, 24)
        Me.chkLeukemiaCat.TabIndex = 115
        Me.chkLeukemiaCat.Text = "Pos/Neg"
        Me.chkLeukemiaCat.UseVisualStyleBackColor = True
        '
        'lbl5Cat
        '
        Me.lbl5Cat.AutoSize = True
        Me.lbl5Cat.Location = New System.Drawing.Point(6, 769)
        Me.lbl5Cat.Name = "lbl5Cat"
        Me.lbl5Cat.Size = New System.Drawing.Size(57, 26)
        Me.lbl5Cat.TabIndex = 116
        Me.lbl5Cat.Text = "Leukemia " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test Date:"
        '
        'datePickerLeukemiaCat
        '
        Me.datePickerLeukemiaCat.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CatInfoBindingSource, "leukemiaTestDate", True))
        Me.datePickerLeukemiaCat.Location = New System.Drawing.Point(95, 772)
        Me.datePickerLeukemiaCat.Name = "datePickerLeukemiaCat"
        Me.datePickerLeukemiaCat.Size = New System.Drawing.Size(200, 20)
        Me.datePickerLeukemiaCat.TabIndex = 117
        '
        'lbl6Cat
        '
        Me.lbl6Cat.AutoSize = True
        Me.lbl6Cat.Location = New System.Drawing.Point(6, 796)
        Me.lbl6Cat.Name = "lbl6Cat"
        Me.lbl6Cat.Size = New System.Drawing.Size(66, 26)
        Me.lbl6Cat.TabIndex = 118
        Me.lbl6Cat.Text = "Rabies " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vaccination:"
        '
        'chkRabiesCat
        '
        Me.chkRabiesCat.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CatInfoBindingSource, "rabiesTest", True))
        Me.chkRabiesCat.Location = New System.Drawing.Point(95, 798)
        Me.chkRabiesCat.Name = "chkRabiesCat"
        Me.chkRabiesCat.Size = New System.Drawing.Size(200, 24)
        Me.chkRabiesCat.TabIndex = 119
        Me.chkRabiesCat.Text = "Y/N"
        Me.chkRabiesCat.UseVisualStyleBackColor = True
        '
        'txtBreedCat
        '
        Me.txtBreedCat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatInfoBindingSource, "breed", True))
        Me.txtBreedCat.Location = New System.Drawing.Point(95, 400)
        Me.txtBreedCat.Name = "txtBreedCat"
        Me.txtBreedCat.Size = New System.Drawing.Size(200, 20)
        Me.txtBreedCat.TabIndex = 121
        '
        'lblProcedureDate
        '
        Me.lblProcedureDate.AutoSize = True
        Me.lblProcedureDate.Location = New System.Drawing.Point(24, 568)
        Me.lblProcedureDate.Name = "lblProcedureDate"
        Me.lblProcedureDate.Size = New System.Drawing.Size(85, 13)
        Me.lblProcedureDate.TabIndex = 123
        Me.lblProcedureDate.Text = "Procedure Date:"
        '
        'datePickerProcedureDog
        '
        Me.datePickerProcedureDog.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DogInfoBindingSource, "neuteredDate", True))
        Me.datePickerProcedureDog.Location = New System.Drawing.Point(113, 568)
        Me.datePickerProcedureDog.Name = "datePickerProcedureDog"
        Me.datePickerProcedureDog.Size = New System.Drawing.Size(182, 20)
        Me.datePickerProcedureDog.TabIndex = 124
        '
        'lblStartMed
        '
        Me.lblStartMed.AutoSize = True
        Me.lblStartMed.Location = New System.Drawing.Point(24, 624)
        Me.lblStartMed.Name = "lblStartMed"
        Me.lblStartMed.Size = New System.Drawing.Size(82, 13)
        Me.lblStartMed.TabIndex = 124
        Me.lblStartMed.Text = "Start Med Date:"
        '
        'datePickerStartMedDog
        '
        Me.datePickerStartMedDog.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DogInfoBindingSource, "startmedDate", True))
        Me.datePickerStartMedDog.Location = New System.Drawing.Point(113, 624)
        Me.datePickerStartMedDog.Name = "datePickerStartMedDog"
        Me.datePickerStartMedDog.Size = New System.Drawing.Size(182, 20)
        Me.datePickerStartMedDog.TabIndex = 125
        '
        'datePickerNeuteredCat
        '
        Me.datePickerNeuteredCat.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CatInfoBindingSource, "neuteredDate", True))
        Me.datePickerNeuteredCat.Location = New System.Drawing.Point(113, 569)
        Me.datePickerNeuteredCat.Name = "datePickerNeuteredCat"
        Me.datePickerNeuteredCat.Size = New System.Drawing.Size(182, 20)
        Me.datePickerNeuteredCat.TabIndex = 126
        '
        'CatInfoDataGridView
        '
        Me.CatInfoDataGridView.AllowUserToAddRows = False
        Me.CatInfoDataGridView.AutoGenerateColumns = False
        Me.CatInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CatInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewCheckBoxColumn11, Me.DataGridViewCheckBoxColumn12, Me.DataGridViewCheckBoxColumn13, Me.DataGridViewCheckBoxColumn14, Me.DataGridViewTextBoxColumn26, Me.DataGridViewCheckBoxColumn15, Me.DataGridViewCheckBoxColumn16, Me.DataGridViewCheckBoxColumn17, Me.DataGridViewCheckBoxColumn18, Me.DataGridViewTextBoxColumn27, Me.DataGridViewCheckBoxColumn19})
        Me.CatInfoDataGridView.DataSource = Me.CatInfoBindingSource
        Me.CatInfoDataGridView.Location = New System.Drawing.Point(391, 445)
        Me.CatInfoDataGridView.Name = "CatInfoDataGridView"
        Me.CatInfoDataGridView.Size = New System.Drawing.Size(942, 464)
        Me.CatInfoDataGridView.TabIndex = 126
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "breed"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Breed"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 80
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "weight"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 80
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "haircolor"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Hair Color"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 80
        '
        'DataGridViewCheckBoxColumn11
        '
        Me.DataGridViewCheckBoxColumn11.DataPropertyName = "hairtype"
        Me.DataGridViewCheckBoxColumn11.HeaderText = "Hair Type Long/Short"
        Me.DataGridViewCheckBoxColumn11.Name = "DataGridViewCheckBoxColumn11"
        Me.DataGridViewCheckBoxColumn11.Width = 80
        '
        'DataGridViewCheckBoxColumn12
        '
        Me.DataGridViewCheckBoxColumn12.DataPropertyName = "gender"
        Me.DataGridViewCheckBoxColumn12.HeaderText = "Gender Male/Female"
        Me.DataGridViewCheckBoxColumn12.Name = "DataGridViewCheckBoxColumn12"
        '
        'DataGridViewCheckBoxColumn13
        '
        Me.DataGridViewCheckBoxColumn13.DataPropertyName = "neutered"
        Me.DataGridViewCheckBoxColumn13.HeaderText = "Spayed/Neutered Y/N"
        Me.DataGridViewCheckBoxColumn13.Name = "DataGridViewCheckBoxColumn13"
        '
        'DataGridViewCheckBoxColumn14
        '
        Me.DataGridViewCheckBoxColumn14.DataPropertyName = "fleaTest"
        Me.DataGridViewCheckBoxColumn14.HeaderText = "Flea Test"
        Me.DataGridViewCheckBoxColumn14.Name = "DataGridViewCheckBoxColumn14"
        Me.DataGridViewCheckBoxColumn14.Width = 50
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "fleaTestDate"
        Me.DataGridViewTextBoxColumn26.HeaderText = "fleaTestDate"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewCheckBoxColumn15
        '
        Me.DataGridViewCheckBoxColumn15.DataPropertyName = "declawed"
        Me.DataGridViewCheckBoxColumn15.HeaderText = "Declawed Y/N"
        Me.DataGridViewCheckBoxColumn15.Name = "DataGridViewCheckBoxColumn15"
        Me.DataGridViewCheckBoxColumn15.Width = 70
        '
        'DataGridViewCheckBoxColumn16
        '
        Me.DataGridViewCheckBoxColumn16.DataPropertyName = "futureDeclaw"
        Me.DataGridViewCheckBoxColumn16.HeaderText = "futureDeclaw"
        Me.DataGridViewCheckBoxColumn16.Name = "DataGridViewCheckBoxColumn16"
        Me.DataGridViewCheckBoxColumn16.Visible = False
        '
        'DataGridViewCheckBoxColumn17
        '
        Me.DataGridViewCheckBoxColumn17.DataPropertyName = "futureDeclawInfo"
        Me.DataGridViewCheckBoxColumn17.HeaderText = "futureDeclawInfo"
        Me.DataGridViewCheckBoxColumn17.Name = "DataGridViewCheckBoxColumn17"
        Me.DataGridViewCheckBoxColumn17.Visible = False
        '
        'DataGridViewCheckBoxColumn18
        '
        Me.DataGridViewCheckBoxColumn18.DataPropertyName = "leukemia"
        Me.DataGridViewCheckBoxColumn18.HeaderText = "Leukemia Test Pos/Neg"
        Me.DataGridViewCheckBoxColumn18.Name = "DataGridViewCheckBoxColumn18"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "leukemiaTestDate"
        Me.DataGridViewTextBoxColumn27.HeaderText = "leukemiaTestDate"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewCheckBoxColumn19
        '
        Me.DataGridViewCheckBoxColumn19.DataPropertyName = "rabiesTest"
        Me.DataGridViewCheckBoxColumn19.HeaderText = "Rabies Vaccination Y/N"
        Me.DataGridViewCheckBoxColumn19.Name = "DataGridViewCheckBoxColumn19"
        '
        'OtherInfoDataGridView
        '
        Me.OtherInfoDataGridView.AllowUserToAddRows = False
        Me.OtherInfoDataGridView.AutoGenerateColumns = False
        Me.OtherInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OtherInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33})
        Me.OtherInfoDataGridView.DataSource = Me.OtherInfoBindingSource
        Me.OtherInfoDataGridView.Location = New System.Drawing.Point(391, 445)
        Me.OtherInfoDataGridView.Name = "OtherInfoDataGridView"
        Me.OtherInfoDataGridView.Size = New System.Drawing.Size(942, 464)
        Me.OtherInfoDataGridView.TabIndex = 126
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "weight"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 60
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "appearance"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Appearance"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 250
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "vaccinations"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Vaccinations"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 250
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "generalDescription"
        Me.DataGridViewTextBoxColumn33.HeaderText = "General Description"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 250
        '
        'OtherInfoBindingSource
        '
        Me.OtherInfoBindingSource.DataMember = "OtherInfo"
        Me.OtherInfoBindingSource.DataSource = Me.AllDataDataSet
        '
        'rtxtAppearance
        '
        Me.rtxtAppearance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OtherInfoBindingSource, "appearance", True))
        Me.rtxtAppearance.Location = New System.Drawing.Point(95, 423)
        Me.rtxtAppearance.Name = "rtxtAppearance"
        Me.rtxtAppearance.Size = New System.Drawing.Size(200, 140)
        Me.rtxtAppearance.TabIndex = 127
        Me.rtxtAppearance.Text = ""
        '
        'txtWeightOther
        '
        Me.txtWeightOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatInfoBindingSource, "weight", True))
        Me.txtWeightOther.Location = New System.Drawing.Point(95, 401)
        Me.txtWeightOther.Name = "txtWeightOther"
        Me.txtWeightOther.Size = New System.Drawing.Size(200, 20)
        Me.txtWeightOther.TabIndex = 130
        '
        'lblWeightOther
        '
        Me.lblWeightOther.AutoSize = True
        Me.lblWeightOther.Location = New System.Drawing.Point(6, 401)
        Me.lblWeightOther.Name = "lblWeightOther"
        Me.lblWeightOther.Size = New System.Drawing.Size(44, 13)
        Me.lblWeightOther.TabIndex = 131
        Me.lblWeightOther.Text = "Weight:"
        '
        'rtxtVaccinations
        '
        Me.rtxtVaccinations.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OtherInfoBindingSource, "vaccinations", True))
        Me.rtxtVaccinations.Location = New System.Drawing.Point(95, 569)
        Me.rtxtVaccinations.Name = "rtxtVaccinations"
        Me.rtxtVaccinations.Size = New System.Drawing.Size(200, 140)
        Me.rtxtVaccinations.TabIndex = 132
        Me.rtxtVaccinations.Text = ""
        '
        'rtxtGeneralDescription
        '
        Me.rtxtGeneralDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OtherInfoBindingSource, "generalDescription", True))
        Me.rtxtGeneralDescription.Location = New System.Drawing.Point(95, 714)
        Me.rtxtGeneralDescription.Name = "rtxtGeneralDescription"
        Me.rtxtGeneralDescription.Size = New System.Drawing.Size(200, 140)
        Me.rtxtGeneralDescription.TabIndex = 133
        Me.rtxtGeneralDescription.Text = ""
        '
        'lbl1Other
        '
        Me.lbl1Other.AutoSize = True
        Me.lbl1Other.Location = New System.Drawing.Point(6, 423)
        Me.lbl1Other.Name = "lbl1Other"
        Me.lbl1Other.Size = New System.Drawing.Size(65, 13)
        Me.lbl1Other.TabIndex = 134
        Me.lbl1Other.Text = "Appearance"
        '
        'lbl2VaccinationsOther
        '
        Me.lbl2VaccinationsOther.AutoSize = True
        Me.lbl2VaccinationsOther.Location = New System.Drawing.Point(6, 569)
        Me.lbl2VaccinationsOther.Name = "lbl2VaccinationsOther"
        Me.lbl2VaccinationsOther.Size = New System.Drawing.Size(68, 13)
        Me.lbl2VaccinationsOther.TabIndex = 135
        Me.lbl2VaccinationsOther.Text = "Vaccinations"
        '
        'lbl3GeneralDescriptionOther
        '
        Me.lbl3GeneralDescriptionOther.AutoSize = True
        Me.lbl3GeneralDescriptionOther.Location = New System.Drawing.Point(6, 714)
        Me.lbl3GeneralDescriptionOther.Name = "lbl3GeneralDescriptionOther"
        Me.lbl3GeneralDescriptionOther.Size = New System.Drawing.Size(61, 26)
        Me.lbl3GeneralDescriptionOther.TabIndex = 136
        Me.lbl3GeneralDescriptionOther.Text = "General " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Descripton:"
        '
        'DogInfoDataGridView
        '
        Me.DogInfoDataGridView.AllowUserToAddRows = False
        Me.DogInfoDataGridView.AutoGenerateColumns = False
        Me.DogInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DogInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn18, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewCheckBoxColumn9, Me.bordetella, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn34})
        Me.DogInfoDataGridView.DataSource = Me.DogInfoBindingSource
        Me.DogInfoDataGridView.Location = New System.Drawing.Point(391, 445)
        Me.DogInfoDataGridView.Name = "DogInfoDataGridView"
        Me.DogInfoDataGridView.Size = New System.Drawing.Size(942, 464)
        Me.DogInfoDataGridView.TabIndex = 136
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "breed"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Breed"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 80
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "weight"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 60
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "hairColor"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Hair Color"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 80
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "hairType"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Hair Type Long/Short"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 80
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "gender"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Gender Male/Female"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 80
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "neutered"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Spayed/Neutered Y/N"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "fleaTest"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "Flea Test Pos/Neg"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.Width = 70
        '
        'DataGridViewCheckBoxColumn7
        '
        Me.DataGridViewCheckBoxColumn7.DataPropertyName = "heartwormTest"
        Me.DataGridViewCheckBoxColumn7.HeaderText = "Heartworm Test Pos/Neg"
        Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "firstTestDate"
        Me.DataGridViewTextBoxColumn15.HeaderText = "firstTestDate"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "medDate"
        Me.DataGridViewTextBoxColumn16.HeaderText = "medDate"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "lastTestDate"
        Me.DataGridViewTextBoxColumn18.HeaderText = "lastTestDate"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "rabies"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "Rabies Vacine Y/N"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.Width = 80
        '
        'DataGridViewCheckBoxColumn9
        '
        Me.DataGridViewCheckBoxColumn9.DataPropertyName = "distemper"
        Me.DataGridViewCheckBoxColumn9.HeaderText = "Distemper Vacine Y/N"
        Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
        '
        'bordetella
        '
        Me.bordetella.DataPropertyName = "bordetella"
        Me.bordetella.HeaderText = "Bordetella Vaccine"
        Me.bordetella.Name = "bordetella"
        Me.bordetella.Width = 70
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "rabiesTestDate"
        Me.DataGridViewTextBoxColumn19.HeaderText = "rabiesTestDate"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "distemperTestDate"
        Me.DataGridViewTextBoxColumn20.HeaderText = "distemperTestDate"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Index"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Index"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Visible = False
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
        'CatInfoTableAdapter
        '
        Me.CatInfoTableAdapter.ClearBeforeFill = True
        '
        'OtherInfoTableAdapter
        '
        Me.OtherInfoTableAdapter.ClearBeforeFill = True
        '
        'ClientTableBindingSource
        '
        Me.ClientTableBindingSource.DataMember = "ClientTable"
        Me.ClientTableBindingSource.DataSource = Me.AllDataDataSet
        '
        'ClientTableTableAdapter
        '
        Me.ClientTableTableAdapter.ClearBeforeFill = True
        '
        'DogInfoTableAdapter
        '
        Me.DogInfoTableAdapter.ClearBeforeFill = True
        '
        'OtherClientReportBindingSource
        '
        Me.OtherClientReportBindingSource.DataMember = "OtherClientReport"
        Me.OtherClientReportBindingSource.DataSource = Me.AllDataDataSet
        '
        'OtherClientReportTableAdapter
        '
        Me.OtherClientReportTableAdapter.ClearBeforeFill = True
        '
        'CostReportBindingSource
        '
        Me.CostReportBindingSource.DataMember = "CostReport"
        Me.CostReportBindingSource.DataSource = Me.AllDataDataSet
        '
        'CostReportTableAdapter
        '
        Me.CostReportTableAdapter.ClearBeforeFill = True
        '
        'formEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1250, 602)
        Me.Controls.Add(Me.DogInfoDataGridView)
        Me.Controls.Add(Me.lbl3GeneralDescriptionOther)
        Me.Controls.Add(Me.lbl2VaccinationsOther)
        Me.Controls.Add(Me.lbl1Other)
        Me.Controls.Add(Me.rtxtGeneralDescription)
        Me.Controls.Add(Me.rtxtVaccinations)
        Me.Controls.Add(Me.lblWeightOther)
        Me.Controls.Add(Me.txtWeightOther)
        Me.Controls.Add(Me.rtxtAppearance)
        Me.Controls.Add(Me.OtherInfoDataGridView)
        Me.Controls.Add(Me.CatInfoDataGridView)
        Me.Controls.Add(Me.datePickerNeuteredCat)
        Me.Controls.Add(Me.lblStartMed)
        Me.Controls.Add(Me.datePickerStartMedDog)
        Me.Controls.Add(Me.lblProcedureDate)
        Me.Controls.Add(Me.datePickerProcedureDog)
        Me.Controls.Add(Me.txtWeightCat)
        Me.Controls.Add(Me.txtHairColorCat)
        Me.Controls.Add(Me.chkHairtypeCat)
        Me.Controls.Add(Me.chkGenderCat)
        Me.Controls.Add(Me.chkNeuteredCat)
        Me.Controls.Add(Me.chkFleaTestCat)
        Me.Controls.Add(Me.datePickerFleaTestCat)
        Me.Controls.Add(Me.lbl1Cat)
        Me.Controls.Add(Me.chkDeclawedCat)
        Me.Controls.Add(Me.lbl2Cat)
        Me.Controls.Add(Me.chkFutureDeclawCat)
        Me.Controls.Add(Me.lbl3Cat)
        Me.Controls.Add(Me.chkFutureDeclawInfoCat)
        Me.Controls.Add(Me.lbl4Cat)
        Me.Controls.Add(Me.chkLeukemiaCat)
        Me.Controls.Add(Me.lbl5Cat)
        Me.Controls.Add(Me.datePickerLeukemiaCat)
        Me.Controls.Add(Me.lbl6Cat)
        Me.Controls.Add(Me.chkRabiesCat)
        Me.Controls.Add(Me.txtBreedCat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.caseNumSearch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lbl_ScrollPlaceHolder)
        Me.Controls.Add(Me.lblWeightDogCat)
        Me.Controls.Add(Me.txtWeightDog)
        Me.Controls.Add(Me.lblHairColor)
        Me.Controls.Add(Me.txtHairColorDog)
        Me.Controls.Add(Me.lblHairType)
        Me.Controls.Add(Me.chkHairTypeDog)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.chkGenderDog)
        Me.Controls.Add(Me.lblNeutered)
        Me.Controls.Add(Me.chkNeuteredDog)
        Me.Controls.Add(Me.lblFleaTest)
        Me.Controls.Add(Me.chkFleatestDog)
        Me.Controls.Add(Me.lbl1Dog)
        Me.Controls.Add(Me.chkHeartwormtestDog)
        Me.Controls.Add(Me.lbl2Dog)
        Me.Controls.Add(Me.datePickerLastTestDog)
        Me.Controls.Add(Me.lbl3Dog)
        Me.Controls.Add(Me.datePickerMedStartDog)
        Me.Controls.Add(Me.lbl4Dog)
        Me.Controls.Add(Me.datePickerRetestDog)
        Me.Controls.Add(Me.lbl5Dog)
        Me.Controls.Add(Me.chkRabiesDog)
        Me.Controls.Add(Me.lbl7Dog)
        Me.Controls.Add(Me.chkDistemperDog)
        Me.Controls.Add(Me.lbl9Dog)
        Me.Controls.Add(Me.chkBordetellaDog)
        Me.Controls.Add(Me.lbl6Dog)
        Me.Controls.Add(Me.datePickerRabiesDog)
        Me.Controls.Add(Me.lbl8Dog)
        Me.Controls.Add(Me.datePickerDistemperDog)
        Me.Controls.Add(Me.lbl10Dog)
        Me.Controls.Add(Me.datePickerBordetellaDog)
        Me.Controls.Add(Me.lblBreed)
        Me.Controls.Add(Me.txtBreedDog)
        Me.Controls.Add(Me.cboxType)
        Me.Controls.Add(Me.AnimalMasterDataGridView)
        Me.Controls.Add(CaseNumLabel)
        Me.Controls.Add(Me.CaseNumTextBox)
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
        Me.Controls.Add(Me.AnimalMasterBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formEdit"
        Me.Text = "Edit Form"
        CType(Me.AnimalMasterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnimalMasterBindingNavigator.ResumeLayout(False)
        Me.AnimalMasterBindingNavigator.PerformLayout()
        CType(Me.AnimalMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalMasterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DogInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DogInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherClientReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AllDataDataSet As FurryFriendsAnimalShelter.AllDataDataSet
    Friend WithEvents AnimalMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnimalMasterTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.animalMasterTableAdapter
    Friend WithEvents TableAdapterManager As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnimalMasterBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnimalMasterBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CaseNumTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents AnimalMasterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CatInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CatInfoTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.CatInfoTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtherInfoTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.OtherInfoTableAdapter
    Friend WithEvents cboxType As System.Windows.Forms.ComboBox
    Friend WithEvents ClientTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.ClientTableTableAdapter
    Friend WithEvents txtWeightDog As System.Windows.Forms.TextBox
    Friend WithEvents txtHairColorDog As System.Windows.Forms.TextBox
    Friend WithEvents chkHairTypeDog As System.Windows.Forms.CheckBox
    Friend WithEvents chkGenderDog As System.Windows.Forms.CheckBox
    Friend WithEvents chkNeuteredDog As System.Windows.Forms.CheckBox
    Friend WithEvents chkFleatestDog As System.Windows.Forms.CheckBox
    Friend WithEvents chkHeartwormtestDog As System.Windows.Forms.CheckBox
    Friend WithEvents datePickerLastTestDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents datePickerMedStartDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents datePickerRetestDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkRabiesDog As System.Windows.Forms.CheckBox
    Friend WithEvents chkDistemperDog As System.Windows.Forms.CheckBox
    Friend WithEvents chkBordetellaDog As System.Windows.Forms.CheckBox
    Friend WithEvents datePickerRabiesDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents datePickerDistemperDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents datePickerBordetellaDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBreedDog As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ScrollPlaceHolder As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents caseNumSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWeightCat As System.Windows.Forms.TextBox
    Friend WithEvents txtHairColorCat As System.Windows.Forms.TextBox
    Friend WithEvents chkHairtypeCat As System.Windows.Forms.CheckBox
    Friend WithEvents chkGenderCat As System.Windows.Forms.CheckBox
    Friend WithEvents chkNeuteredCat As System.Windows.Forms.CheckBox
    Friend WithEvents chkFleaTestCat As System.Windows.Forms.CheckBox
    Friend WithEvents datePickerFleaTestCat As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDeclawedCat As System.Windows.Forms.CheckBox
    Friend WithEvents chkFutureDeclawCat As System.Windows.Forms.CheckBox
    Friend WithEvents chkFutureDeclawInfoCat As System.Windows.Forms.CheckBox
    Friend WithEvents chkLeukemiaCat As System.Windows.Forms.CheckBox
    Friend WithEvents datePickerLeukemiaCat As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkRabiesCat As System.Windows.Forms.CheckBox
    Friend WithEvents txtBreedCat As System.Windows.Forms.TextBox
    Friend WithEvents datePickerProcedureDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents datePickerStartMedDog As System.Windows.Forms.DateTimePicker
    Friend WithEvents datePickerNeuteredCat As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl2Dog As System.Windows.Forms.Label
    Friend WithEvents lbl3Dog As System.Windows.Forms.Label
    Friend WithEvents lbl4Dog As System.Windows.Forms.Label
    Friend WithEvents lbl5Dog As System.Windows.Forms.Label
    Friend WithEvents lbl7Dog As System.Windows.Forms.Label
    Friend WithEvents lbl9Dog As System.Windows.Forms.Label
    Friend WithEvents lbl6Dog As System.Windows.Forms.Label
    Friend WithEvents lbl8Dog As System.Windows.Forms.Label
    Friend WithEvents lbl10Dog As System.Windows.Forms.Label
    Friend WithEvents lbl2Cat As System.Windows.Forms.Label
    Friend WithEvents lbl3Cat As System.Windows.Forms.Label
    Friend WithEvents lbl4Cat As System.Windows.Forms.Label
    Friend WithEvents lbl5Cat As System.Windows.Forms.Label
    Friend WithEvents lbl6Cat As System.Windows.Forms.Label
    Friend WithEvents lbl1Dog As System.Windows.Forms.Label
    Friend WithEvents lbl1Cat As System.Windows.Forms.Label
    Friend WithEvents CatInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn11 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn12 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn13 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn14 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn15 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn16 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn17 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn18 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn19 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OtherInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rtxtAppearance As System.Windows.Forms.RichTextBox
    Friend WithEvents txtWeightOther As System.Windows.Forms.TextBox
    Friend WithEvents rtxtVaccinations As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxtGeneralDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl1Other As System.Windows.Forms.Label
    Friend WithEvents lbl2VaccinationsOther As System.Windows.Forms.Label
    Friend WithEvents lbl3GeneralDescriptionOther As System.Windows.Forms.Label
    Friend WithEvents lblWeightDogCat As System.Windows.Forms.Label
    Friend WithEvents lblHairColor As System.Windows.Forms.Label
    Friend WithEvents lblHairType As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblNeutered As System.Windows.Forms.Label
    Friend WithEvents lblFleaTest As System.Windows.Forms.Label
    Friend WithEvents lblBreed As System.Windows.Forms.Label
    Friend WithEvents lblProcedureDate As System.Windows.Forms.Label
    Friend WithEvents lblStartMed As System.Windows.Forms.Label
    Friend WithEvents lblWeightOther As System.Windows.Forms.Label
    Friend WithEvents ColumnEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColumnClientReport As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTypeConvert As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DogInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DogInfoTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.dogInfoTableAdapter
    Friend WithEvents DogInfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn10 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherClientReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtherClientReportTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.OtherClientReportTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn9 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents bordetella As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CostReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostReportTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.CostReportTableAdapter
End Class
