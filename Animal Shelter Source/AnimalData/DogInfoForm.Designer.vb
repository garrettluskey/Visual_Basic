<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DogInfoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DogInfoForm))
        Me.BreedInformationLbl = New System.Windows.Forms.Label()
        Me.WeightLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HaircolorTextbox = New System.Windows.Forms.TextBox()
        Me.WeightTextbox = New System.Windows.Forms.TextBox()
        Me.RdioLong = New System.Windows.Forms.RadioButton()
        Me.RdioMale = New System.Windows.Forms.RadioButton()
        Me.GndrLbl = New System.Windows.Forms.Label()
        Me.CheckboxNeutered = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FleaTestLbl = New System.Windows.Forms.Label()
        Me.CheckboxFleaTest = New System.Windows.Forms.CheckBox()
        Me.RdioNegative = New System.Windows.Forms.RadioButton()
        Me.RdioPositive = New System.Windows.Forms.RadioButton()
        Me.HeatwormTextLbl = New System.Windows.Forms.Label()
        Me.MedicalInformationLbl = New System.Windows.Forms.Label()
        Me.DatePicker_LastTestDate = New System.Windows.Forms.DateTimePicker()
        Me.LastTestingDateLbl = New System.Windows.Forms.Label()
        Me.MedicationDateLbl = New System.Windows.Forms.Label()
        Me.DatePicker_MedicationDate = New System.Windows.Forms.DateTimePicker()
        Me.RetestDateLbl = New System.Windows.Forms.Label()
        Me.DatePicker_RetestDate = New System.Windows.Forms.DateTimePicker()
        Me.CheckboxRabies = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RabiesLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckboxBordetella = New System.Windows.Forms.CheckBox()
        Me.CheckboxDistemper = New System.Windows.Forms.CheckBox()
        Me.DatePicker_Bordetella = New System.Windows.Forms.DateTimePicker()
        Me.DatePicker_Distemper = New System.Windows.Forms.DateTimePicker()
        Me.DatePicker_Rabies = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.CancleBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RdioShort = New System.Windows.Forms.RadioButton()
        Me.lbl_Hairtype = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RdioFemale = New System.Windows.Forms.RadioButton()
        Me.lbl_Gender = New System.Windows.Forms.Label()
        Me.lbl_InfoError = New System.Windows.Forms.Label()
        Me.lbl_Weight = New System.Windows.Forms.Label()
        Me.lbl_Haircolor = New System.Windows.Forms.Label()
        Me.lbl_heartworm = New System.Windows.Forms.Label()
        Me.txt_Breed = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Breed = New System.Windows.Forms.Label()
        Me.datePickerNeutered = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.datePickerStartMed = New System.Windows.Forms.DateTimePicker()
        Me.DogInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllDataDataSet = New FurryFriendsAnimalShelter.AllDataDataSet()
        Me.DogInfoTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.dogInfoTableAdapter()
        Me.TableAdapterManager = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RdioKg = New System.Windows.Forms.RadioButton()
        Me.RdioLbs = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DogInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BreedInformationLbl
        '
        Me.BreedInformationLbl.AutoSize = True
        Me.BreedInformationLbl.Location = New System.Drawing.Point(12, 9)
        Me.BreedInformationLbl.Name = "BreedInformationLbl"
        Me.BreedInformationLbl.Size = New System.Drawing.Size(90, 13)
        Me.BreedInformationLbl.TabIndex = 60
        Me.BreedInformationLbl.Text = "Breed Information"
        '
        'WeightLbl
        '
        Me.WeightLbl.AutoSize = True
        Me.WeightLbl.Location = New System.Drawing.Point(31, 54)
        Me.WeightLbl.Name = "WeightLbl"
        Me.WeightLbl.Size = New System.Drawing.Size(44, 13)
        Me.WeightLbl.TabIndex = 61
        Me.WeightLbl.Text = "Weight:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Hair Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Hair Color:"
        '
        'HaircolorTextbox
        '
        Me.HaircolorTextbox.Location = New System.Drawing.Point(93, 76)
        Me.HaircolorTextbox.Name = "HaircolorTextbox"
        Me.HaircolorTextbox.Size = New System.Drawing.Size(72, 20)
        Me.HaircolorTextbox.TabIndex = 2
        '
        'WeightTextbox
        '
        Me.WeightTextbox.Location = New System.Drawing.Point(81, 51)
        Me.WeightTextbox.Name = "WeightTextbox"
        Me.WeightTextbox.Size = New System.Drawing.Size(35, 20)
        Me.WeightTextbox.TabIndex = 1
        '
        'RdioLong
        '
        Me.RdioLong.AutoSize = True
        Me.RdioLong.Location = New System.Drawing.Point(10, 3)
        Me.RdioLong.Name = "RdioLong"
        Me.RdioLong.Size = New System.Drawing.Size(49, 17)
        Me.RdioLong.TabIndex = 3
        Me.RdioLong.Text = "Long"
        Me.RdioLong.UseVisualStyleBackColor = True
        '
        'RdioMale
        '
        Me.RdioMale.AutoSize = True
        Me.RdioMale.Location = New System.Drawing.Point(10, 3)
        Me.RdioMale.Name = "RdioMale"
        Me.RdioMale.Size = New System.Drawing.Size(48, 17)
        Me.RdioMale.TabIndex = 5
        Me.RdioMale.TabStop = True
        Me.RdioMale.Text = "Male"
        Me.RdioMale.UseVisualStyleBackColor = True
        '
        'GndrLbl
        '
        Me.GndrLbl.AutoSize = True
        Me.GndrLbl.Location = New System.Drawing.Point(31, 131)
        Me.GndrLbl.Name = "GndrLbl"
        Me.GndrLbl.Size = New System.Drawing.Size(45, 13)
        Me.GndrLbl.TabIndex = 69
        Me.GndrLbl.Text = "Gender:"
        '
        'CheckboxNeutered
        '
        Me.CheckboxNeutered.AutoSize = True
        Me.CheckboxNeutered.Location = New System.Drawing.Point(129, 167)
        Me.CheckboxNeutered.Name = "CheckboxNeutered"
        Me.CheckboxNeutered.Size = New System.Drawing.Size(46, 17)
        Me.CheckboxNeutered.TabIndex = 7
        Me.CheckboxNeutered.Text = "Y/N"
        Me.CheckboxNeutered.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Spayed/Neutered:"
        '
        'FleaTestLbl
        '
        Me.FleaTestLbl.AutoSize = True
        Me.FleaTestLbl.Location = New System.Drawing.Point(31, 216)
        Me.FleaTestLbl.Name = "FleaTestLbl"
        Me.FleaTestLbl.Size = New System.Drawing.Size(54, 13)
        Me.FleaTestLbl.TabIndex = 75
        Me.FleaTestLbl.Text = "Flea Test:"
        '
        'CheckboxFleaTest
        '
        Me.CheckboxFleaTest.AutoSize = True
        Me.CheckboxFleaTest.Location = New System.Drawing.Point(129, 217)
        Me.CheckboxFleaTest.Name = "CheckboxFleaTest"
        Me.CheckboxFleaTest.Size = New System.Drawing.Size(46, 17)
        Me.CheckboxFleaTest.TabIndex = 9
        Me.CheckboxFleaTest.Text = "Y/N"
        Me.CheckboxFleaTest.UseVisualStyleBackColor = True
        '
        'RdioNegative
        '
        Me.RdioNegative.AutoSize = True
        Me.RdioNegative.Location = New System.Drawing.Point(184, 278)
        Me.RdioNegative.Name = "RdioNegative"
        Me.RdioNegative.Size = New System.Drawing.Size(68, 17)
        Me.RdioNegative.TabIndex = 12
        Me.RdioNegative.TabStop = True
        Me.RdioNegative.Text = "Negative"
        Me.RdioNegative.UseVisualStyleBackColor = True
        '
        'RdioPositive
        '
        Me.RdioPositive.AutoSize = True
        Me.RdioPositive.Location = New System.Drawing.Point(116, 278)
        Me.RdioPositive.Name = "RdioPositive"
        Me.RdioPositive.Size = New System.Drawing.Size(62, 17)
        Me.RdioPositive.TabIndex = 11
        Me.RdioPositive.TabStop = True
        Me.RdioPositive.Text = "Positive"
        Me.RdioPositive.UseVisualStyleBackColor = True
        '
        'HeatwormTextLbl
        '
        Me.HeatwormTextLbl.AutoSize = True
        Me.HeatwormTextLbl.Location = New System.Drawing.Point(28, 280)
        Me.HeatwormTextLbl.Name = "HeatwormTextLbl"
        Me.HeatwormTextLbl.Size = New System.Drawing.Size(85, 13)
        Me.HeatwormTextLbl.TabIndex = 76
        Me.HeatwormTextLbl.Text = "Heartworm Test:"
        '
        'MedicalInformationLbl
        '
        Me.MedicalInformationLbl.AutoSize = True
        Me.MedicalInformationLbl.Location = New System.Drawing.Point(12, 145)
        Me.MedicalInformationLbl.Name = "MedicalInformationLbl"
        Me.MedicalInformationLbl.Size = New System.Drawing.Size(99, 13)
        Me.MedicalInformationLbl.TabIndex = 79
        Me.MedicalInformationLbl.Text = "Medical Information"
        '
        'DatePicker_LastTestDate
        '
        Me.DatePicker_LastTestDate.Location = New System.Drawing.Point(116, 301)
        Me.DatePicker_LastTestDate.Name = "DatePicker_LastTestDate"
        Me.DatePicker_LastTestDate.Size = New System.Drawing.Size(200, 20)
        Me.DatePicker_LastTestDate.TabIndex = 13
        '
        'LastTestingDateLbl
        '
        Me.LastTestingDateLbl.AutoSize = True
        Me.LastTestingDateLbl.Location = New System.Drawing.Point(28, 307)
        Me.LastTestingDateLbl.Name = "LastTestingDateLbl"
        Me.LastTestingDateLbl.Size = New System.Drawing.Size(80, 13)
        Me.LastTestingDateLbl.TabIndex = 81
        Me.LastTestingDateLbl.Text = "Last Test Date:"
        '
        'MedicationDateLbl
        '
        Me.MedicationDateLbl.AutoSize = True
        Me.MedicationDateLbl.Location = New System.Drawing.Point(28, 333)
        Me.MedicationDateLbl.Name = "MedicationDateLbl"
        Me.MedicationDateLbl.Size = New System.Drawing.Size(113, 13)
        Me.MedicationDateLbl.TabIndex = 83
        Me.MedicationDateLbl.Text = "Start Medication Date:"
        '
        'DatePicker_MedicationDate
        '
        Me.DatePicker_MedicationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_MedicationDate.Location = New System.Drawing.Point(147, 327)
        Me.DatePicker_MedicationDate.Name = "DatePicker_MedicationDate"
        Me.DatePicker_MedicationDate.Size = New System.Drawing.Size(169, 20)
        Me.DatePicker_MedicationDate.TabIndex = 14
        '
        'RetestDateLbl
        '
        Me.RetestDateLbl.AutoSize = True
        Me.RetestDateLbl.Location = New System.Drawing.Point(28, 359)
        Me.RetestDateLbl.Name = "RetestDateLbl"
        Me.RetestDateLbl.Size = New System.Drawing.Size(67, 13)
        Me.RetestDateLbl.TabIndex = 85
        Me.RetestDateLbl.Text = "Retest Date:"
        '
        'DatePicker_RetestDate
        '
        Me.DatePicker_RetestDate.Location = New System.Drawing.Point(116, 353)
        Me.DatePicker_RetestDate.Name = "DatePicker_RetestDate"
        Me.DatePicker_RetestDate.Size = New System.Drawing.Size(200, 20)
        Me.DatePicker_RetestDate.TabIndex = 15
        '
        'CheckboxRabies
        '
        Me.CheckboxRabies.AutoSize = True
        Me.CheckboxRabies.Location = New System.Drawing.Point(91, 396)
        Me.CheckboxRabies.Name = "CheckboxRabies"
        Me.CheckboxRabies.Size = New System.Drawing.Size(46, 17)
        Me.CheckboxRabies.TabIndex = 16
        Me.CheckboxRabies.Text = "Y/N"
        Me.CheckboxRabies.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 375)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Vaccination Information"
        '
        'RabiesLbl
        '
        Me.RabiesLbl.AutoSize = True
        Me.RabiesLbl.Location = New System.Drawing.Point(28, 400)
        Me.RabiesLbl.Name = "RabiesLbl"
        Me.RabiesLbl.Size = New System.Drawing.Size(43, 13)
        Me.RabiesLbl.TabIndex = 90
        Me.RabiesLbl.Text = "Rabies:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Bordetella:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Distemper:"
        '
        'CheckboxBordetella
        '
        Me.CheckboxBordetella.AutoSize = True
        Me.CheckboxBordetella.Location = New System.Drawing.Point(91, 443)
        Me.CheckboxBordetella.Name = "CheckboxBordetella"
        Me.CheckboxBordetella.Size = New System.Drawing.Size(46, 17)
        Me.CheckboxBordetella.TabIndex = 20
        Me.CheckboxBordetella.Text = "Y/N"
        Me.CheckboxBordetella.UseVisualStyleBackColor = True
        '
        'CheckboxDistemper
        '
        Me.CheckboxDistemper.AutoSize = True
        Me.CheckboxDistemper.Location = New System.Drawing.Point(91, 420)
        Me.CheckboxDistemper.Name = "CheckboxDistemper"
        Me.CheckboxDistemper.Size = New System.Drawing.Size(46, 17)
        Me.CheckboxDistemper.TabIndex = 18
        Me.CheckboxDistemper.Text = "Y/N"
        Me.CheckboxDistemper.UseVisualStyleBackColor = True
        '
        'DatePicker_Bordetella
        '
        Me.DatePicker_Bordetella.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Bordetella.Location = New System.Drawing.Point(218, 440)
        Me.DatePicker_Bordetella.Name = "DatePicker_Bordetella"
        Me.DatePicker_Bordetella.Size = New System.Drawing.Size(98, 20)
        Me.DatePicker_Bordetella.TabIndex = 21
        '
        'DatePicker_Distemper
        '
        Me.DatePicker_Distemper.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Distemper.Location = New System.Drawing.Point(218, 417)
        Me.DatePicker_Distemper.Name = "DatePicker_Distemper"
        Me.DatePicker_Distemper.Size = New System.Drawing.Size(98, 20)
        Me.DatePicker_Distemper.TabIndex = 19
        '
        'DatePicker_Rabies
        '
        Me.DatePicker_Rabies.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Rabies.Location = New System.Drawing.Point(218, 394)
        Me.DatePicker_Rabies.Name = "DatePicker_Rabies"
        Me.DatePicker_Rabies.Size = New System.Drawing.Size(98, 20)
        Me.DatePicker_Rabies.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Date Tested:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(143, 444)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Date Tested:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Date Tested:"
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(7, 466)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(75, 23)
        Me.BackBtn.TabIndex = 22
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'CancleBtn
        '
        Me.CancleBtn.Location = New System.Drawing.Point(175, 466)
        Me.CancleBtn.Name = "CancleBtn"
        Me.CancleBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancleBtn.TabIndex = 23
        Me.CancleBtn.Text = "Cancel"
        Me.CancleBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(256, 466)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 24
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RdioShort)
        Me.Panel1.Controls.Add(Me.lbl_Hairtype)
        Me.Panel1.Controls.Add(Me.RdioLong)
        Me.Panel1.Location = New System.Drawing.Point(93, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 23)
        Me.Panel1.TabIndex = 104
        '
        'RdioShort
        '
        Me.RdioShort.AutoSize = True
        Me.RdioShort.Location = New System.Drawing.Point(65, 3)
        Me.RdioShort.Name = "RdioShort"
        Me.RdioShort.Size = New System.Drawing.Size(50, 17)
        Me.RdioShort.TabIndex = 4
        Me.RdioShort.TabStop = True
        Me.RdioShort.Text = "Short"
        Me.RdioShort.UseVisualStyleBackColor = True
        '
        'lbl_Hairtype
        '
        Me.lbl_Hairtype.AutoSize = True
        Me.lbl_Hairtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Hairtype.ForeColor = System.Drawing.Color.Red
        Me.lbl_Hairtype.Location = New System.Drawing.Point(111, 3)
        Me.lbl_Hairtype.Name = "lbl_Hairtype"
        Me.lbl_Hairtype.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Hairtype.TabIndex = 107
        Me.lbl_Hairtype.Text = "*"
        Me.lbl_Hairtype.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RdioFemale)
        Me.Panel2.Controls.Add(Me.lbl_Gender)
        Me.Panel2.Controls.Add(Me.RdioMale)
        Me.Panel2.Location = New System.Drawing.Point(93, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(135, 23)
        Me.Panel2.TabIndex = 69
        '
        'RdioFemale
        '
        Me.RdioFemale.AutoSize = True
        Me.RdioFemale.Location = New System.Drawing.Point(64, 3)
        Me.RdioFemale.Name = "RdioFemale"
        Me.RdioFemale.Size = New System.Drawing.Size(59, 17)
        Me.RdioFemale.TabIndex = 6
        Me.RdioFemale.TabStop = True
        Me.RdioFemale.Text = "Female"
        Me.RdioFemale.UseVisualStyleBackColor = True
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Gender.ForeColor = System.Drawing.Color.Red
        Me.lbl_Gender.Location = New System.Drawing.Point(119, 3)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Gender.TabIndex = 109
        Me.lbl_Gender.Text = "*"
        Me.lbl_Gender.Visible = False
        '
        'lbl_InfoError
        '
        Me.lbl_InfoError.AutoSize = True
        Me.lbl_InfoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_InfoError.ForeColor = System.Drawing.Color.Red
        Me.lbl_InfoError.Location = New System.Drawing.Point(208, 492)
        Me.lbl_InfoError.Name = "lbl_InfoError"
        Me.lbl_InfoError.Size = New System.Drawing.Size(123, 13)
        Me.lbl_InfoError.TabIndex = 105
        Me.lbl_InfoError.Text = "*- Required Field Missing"
        Me.lbl_InfoError.Visible = False
        '
        'lbl_Weight
        '
        Me.lbl_Weight.AutoSize = True
        Me.lbl_Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Weight.ForeColor = System.Drawing.Color.Red
        Me.lbl_Weight.Location = New System.Drawing.Point(116, 50)
        Me.lbl_Weight.Name = "lbl_Weight"
        Me.lbl_Weight.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Weight.TabIndex = 106
        Me.lbl_Weight.Text = "*"
        Me.lbl_Weight.Visible = False
        '
        'lbl_Haircolor
        '
        Me.lbl_Haircolor.AutoSize = True
        Me.lbl_Haircolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Haircolor.ForeColor = System.Drawing.Color.Red
        Me.lbl_Haircolor.Location = New System.Drawing.Point(165, 72)
        Me.lbl_Haircolor.Name = "lbl_Haircolor"
        Me.lbl_Haircolor.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Haircolor.TabIndex = 108
        Me.lbl_Haircolor.Text = "*"
        Me.lbl_Haircolor.Visible = False
        '
        'lbl_heartworm
        '
        Me.lbl_heartworm.AutoSize = True
        Me.lbl_heartworm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_heartworm.ForeColor = System.Drawing.Color.Red
        Me.lbl_heartworm.Location = New System.Drawing.Point(246, 278)
        Me.lbl_heartworm.Name = "lbl_heartworm"
        Me.lbl_heartworm.Size = New System.Drawing.Size(13, 17)
        Me.lbl_heartworm.TabIndex = 109
        Me.lbl_heartworm.Text = "*"
        Me.lbl_heartworm.Visible = False
        '
        'txt_Breed
        '
        Me.txt_Breed.Location = New System.Drawing.Point(81, 25)
        Me.txt_Breed.Name = "txt_Breed"
        Me.txt_Breed.Size = New System.Drawing.Size(100, 20)
        Me.txt_Breed.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Breed:"
        '
        'lbl_Breed
        '
        Me.lbl_Breed.AutoSize = True
        Me.lbl_Breed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Breed.ForeColor = System.Drawing.Color.Red
        Me.lbl_Breed.Location = New System.Drawing.Point(181, 23)
        Me.lbl_Breed.Name = "lbl_Breed"
        Me.lbl_Breed.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Breed.TabIndex = 112
        Me.lbl_Breed.Text = "*"
        Me.lbl_Breed.Visible = False
        '
        'datePickerNeutered
        '
        Me.datePickerNeutered.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePickerNeutered.Location = New System.Drawing.Point(146, 191)
        Me.datePickerNeutered.Name = "datePickerNeutered"
        Me.datePickerNeutered.Size = New System.Drawing.Size(116, 20)
        Me.datePickerNeutered.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Procedure Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(55, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Start Med Date:"
        '
        'datePickerStartMed
        '
        Me.datePickerStartMed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePickerStartMed.Location = New System.Drawing.Point(146, 236)
        Me.datePickerStartMed.Name = "datePickerStartMed"
        Me.datePickerStartMed.Size = New System.Drawing.Size(116, 20)
        Me.datePickerStartMed.TabIndex = 10
        '
        'DogInfoBindingSource
        '
        Me.DogInfoBindingSource.DataMember = "dogInfo"
        Me.DogInfoBindingSource.DataSource = Me.AllDataDataSet
        '
        'AllDataDataSet
        '
        Me.AllDataDataSet.DataSetName = "AllDataDataSet"
        Me.AllDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DogInfoTableAdapter
        '
        Me.DogInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.animalMasterTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatInfoTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager.CostReportTableAdapter = Nothing
        Me.TableAdapterManager.dogInfoTableAdapter = Me.DogInfoTableAdapter
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RdioKg)
        Me.Panel4.Controls.Add(Me.RdioLbs)
        Me.Panel4.Location = New System.Drawing.Point(129, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(77, 20)
        Me.Panel4.TabIndex = 182
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
        'DogInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(337, 506)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.datePickerStartMed)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.datePickerNeutered)
        Me.Controls.Add(Me.lbl_Breed)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Breed)
        Me.Controls.Add(Me.lbl_heartworm)
        Me.Controls.Add(Me.lbl_Haircolor)
        Me.Controls.Add(Me.lbl_Weight)
        Me.Controls.Add(Me.lbl_InfoError)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.CancleBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DatePicker_Rabies)
        Me.Controls.Add(Me.DatePicker_Distemper)
        Me.Controls.Add(Me.DatePicker_Bordetella)
        Me.Controls.Add(Me.CheckboxDistemper)
        Me.Controls.Add(Me.CheckboxBordetella)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RabiesLbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckboxRabies)
        Me.Controls.Add(Me.RetestDateLbl)
        Me.Controls.Add(Me.DatePicker_RetestDate)
        Me.Controls.Add(Me.MedicationDateLbl)
        Me.Controls.Add(Me.DatePicker_MedicationDate)
        Me.Controls.Add(Me.LastTestingDateLbl)
        Me.Controls.Add(Me.DatePicker_LastTestDate)
        Me.Controls.Add(Me.MedicalInformationLbl)
        Me.Controls.Add(Me.RdioNegative)
        Me.Controls.Add(Me.RdioPositive)
        Me.Controls.Add(Me.HeatwormTextLbl)
        Me.Controls.Add(Me.FleaTestLbl)
        Me.Controls.Add(Me.CheckboxFleaTest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckboxNeutered)
        Me.Controls.Add(Me.GndrLbl)
        Me.Controls.Add(Me.WeightTextbox)
        Me.Controls.Add(Me.HaircolorTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WeightLbl)
        Me.Controls.Add(Me.BreedInformationLbl)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DogInfoForm"
        Me.Text = "Dog Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DogInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BreedInformationLbl As System.Windows.Forms.Label
    Friend WithEvents WeightLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HaircolorTextbox As System.Windows.Forms.TextBox
    Friend WithEvents WeightTextbox As System.Windows.Forms.TextBox
    Friend WithEvents RdioLong As System.Windows.Forms.RadioButton
    Friend WithEvents RdioMale As System.Windows.Forms.RadioButton
    Friend WithEvents GndrLbl As System.Windows.Forms.Label
    Friend WithEvents CheckboxNeutered As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FleaTestLbl As System.Windows.Forms.Label
    Friend WithEvents CheckboxFleaTest As System.Windows.Forms.CheckBox
    Friend WithEvents RdioNegative As System.Windows.Forms.RadioButton
    Friend WithEvents RdioPositive As System.Windows.Forms.RadioButton
    Friend WithEvents HeatwormTextLbl As System.Windows.Forms.Label
    Friend WithEvents MedicalInformationLbl As System.Windows.Forms.Label
    Friend WithEvents DatePicker_LastTestDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LastTestingDateLbl As System.Windows.Forms.Label
    Friend WithEvents MedicationDateLbl As System.Windows.Forms.Label
    Friend WithEvents DatePicker_MedicationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents RetestDateLbl As System.Windows.Forms.Label
    Friend WithEvents DatePicker_RetestDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckboxRabies As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RabiesLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckboxBordetella As System.Windows.Forms.CheckBox
    Friend WithEvents CheckboxDistemper As System.Windows.Forms.CheckBox
    Friend WithEvents DatePicker_Bordetella As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatePicker_Distemper As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatePicker_Rabies As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BackBtn As System.Windows.Forms.Button
    Friend WithEvents CancleBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents AllDataDataSet As FurryFriendsAnimalShelter.AllDataDataSet
    Friend WithEvents DogInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DogInfoTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.dogInfoTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableAdapterManager As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lbl_InfoError As System.Windows.Forms.Label
    Friend WithEvents lbl_Hairtype As System.Windows.Forms.Label
    Friend WithEvents lbl_Gender As System.Windows.Forms.Label
    Friend WithEvents lbl_Weight As System.Windows.Forms.Label
    Friend WithEvents lbl_Haircolor As System.Windows.Forms.Label
    Friend WithEvents lbl_heartworm As System.Windows.Forms.Label
    Friend WithEvents RdioShort As System.Windows.Forms.RadioButton
    Friend WithEvents RdioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents txt_Breed As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_Breed As System.Windows.Forms.Label
    Friend WithEvents datePickerNeutered As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents datePickerStartMed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RdioKg As System.Windows.Forms.RadioButton
    Friend WithEvents RdioLbs As System.Windows.Forms.RadioButton
End Class
