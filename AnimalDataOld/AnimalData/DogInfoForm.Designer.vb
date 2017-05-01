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
        Me.AllDataDataSet = New WindowsApplication1.AllDataDataSet()
        Me.DogInfoTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.dogInfoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager()
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
        Me.BreedInformationLbl.Location = New System.Drawing.Point(16, 11)
        Me.BreedInformationLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BreedInformationLbl.Name = "BreedInformationLbl"
        Me.BreedInformationLbl.Size = New System.Drawing.Size(120, 17)
        Me.BreedInformationLbl.TabIndex = 60
        Me.BreedInformationLbl.Text = "Breed Information"
        '
        'WeightLbl
        '
        Me.WeightLbl.AutoSize = True
        Me.WeightLbl.Location = New System.Drawing.Point(41, 66)
        Me.WeightLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WeightLbl.Name = "WeightLbl"
        Me.WeightLbl.Size = New System.Drawing.Size(56, 17)
        Me.WeightLbl.TabIndex = 61
        Me.WeightLbl.Text = "Weight:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Hair Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Hair Color:"
        '
        'HaircolorTextbox
        '
        Me.HaircolorTextbox.Location = New System.Drawing.Point(124, 93)
        Me.HaircolorTextbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HaircolorTextbox.Name = "HaircolorTextbox"
        Me.HaircolorTextbox.Size = New System.Drawing.Size(95, 22)
        Me.HaircolorTextbox.TabIndex = 2
        '
        'WeightTextbox
        '
        Me.WeightTextbox.Location = New System.Drawing.Point(108, 63)
        Me.WeightTextbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WeightTextbox.Name = "WeightTextbox"
        Me.WeightTextbox.Size = New System.Drawing.Size(45, 22)
        Me.WeightTextbox.TabIndex = 1
        '
        'RdioLong
        '
        Me.RdioLong.AutoSize = True
        Me.RdioLong.Location = New System.Drawing.Point(13, 4)
        Me.RdioLong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RdioLong.Name = "RdioLong"
        Me.RdioLong.Size = New System.Drawing.Size(61, 21)
        Me.RdioLong.TabIndex = 3
        Me.RdioLong.Text = "Long"
        Me.RdioLong.UseVisualStyleBackColor = True
        '
        'RdioMale
        '
        Me.RdioMale.AutoSize = True
        Me.RdioMale.Location = New System.Drawing.Point(13, 4)
        Me.RdioMale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RdioMale.Name = "RdioMale"
        Me.RdioMale.Size = New System.Drawing.Size(59, 21)
        Me.RdioMale.TabIndex = 5
        Me.RdioMale.TabStop = True
        Me.RdioMale.Text = "Male"
        Me.RdioMale.UseVisualStyleBackColor = True
        '
        'GndrLbl
        '
        Me.GndrLbl.AutoSize = True
        Me.GndrLbl.Location = New System.Drawing.Point(41, 161)
        Me.GndrLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GndrLbl.Name = "GndrLbl"
        Me.GndrLbl.Size = New System.Drawing.Size(60, 17)
        Me.GndrLbl.TabIndex = 69
        Me.GndrLbl.Text = "Gender:"
        '
        'CheckboxNeutered
        '
        Me.CheckboxNeutered.AutoSize = True
        Me.CheckboxNeutered.Location = New System.Drawing.Point(172, 206)
        Me.CheckboxNeutered.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckboxNeutered.Name = "CheckboxNeutered"
        Me.CheckboxNeutered.Size = New System.Drawing.Size(53, 21)
        Me.CheckboxNeutered.TabIndex = 7
        Me.CheckboxNeutered.Text = "Y/N"
        Me.CheckboxNeutered.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 205)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Spayed/Neutered:"
        '
        'FleaTestLbl
        '
        Me.FleaTestLbl.AutoSize = True
        Me.FleaTestLbl.Location = New System.Drawing.Point(41, 266)
        Me.FleaTestLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FleaTestLbl.Name = "FleaTestLbl"
        Me.FleaTestLbl.Size = New System.Drawing.Size(71, 17)
        Me.FleaTestLbl.TabIndex = 75
        Me.FleaTestLbl.Text = "Flea Test:"
        '
        'CheckboxFleaTest
        '
        Me.CheckboxFleaTest.AutoSize = True
        Me.CheckboxFleaTest.Location = New System.Drawing.Point(172, 267)
        Me.CheckboxFleaTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckboxFleaTest.Name = "CheckboxFleaTest"
        Me.CheckboxFleaTest.Size = New System.Drawing.Size(53, 21)
        Me.CheckboxFleaTest.TabIndex = 9
        Me.CheckboxFleaTest.Text = "Y/N"
        Me.CheckboxFleaTest.UseVisualStyleBackColor = True
        '
        'RdioNegative
        '
        Me.RdioNegative.AutoSize = True
        Me.RdioNegative.Location = New System.Drawing.Point(245, 342)
        Me.RdioNegative.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RdioNegative.Name = "RdioNegative"
        Me.RdioNegative.Size = New System.Drawing.Size(85, 21)
        Me.RdioNegative.TabIndex = 12
        Me.RdioNegative.TabStop = True
        Me.RdioNegative.Text = "Negative"
        Me.RdioNegative.UseVisualStyleBackColor = True
        '
        'RdioPositive
        '
        Me.RdioPositive.AutoSize = True
        Me.RdioPositive.Location = New System.Drawing.Point(155, 342)
        Me.RdioPositive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RdioPositive.Name = "RdioPositive"
        Me.RdioPositive.Size = New System.Drawing.Size(78, 21)
        Me.RdioPositive.TabIndex = 11
        Me.RdioPositive.TabStop = True
        Me.RdioPositive.Text = "Positive"
        Me.RdioPositive.UseVisualStyleBackColor = True
        '
        'HeatwormTextLbl
        '
        Me.HeatwormTextLbl.AutoSize = True
        Me.HeatwormTextLbl.Location = New System.Drawing.Point(37, 344)
        Me.HeatwormTextLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HeatwormTextLbl.Name = "HeatwormTextLbl"
        Me.HeatwormTextLbl.Size = New System.Drawing.Size(112, 17)
        Me.HeatwormTextLbl.TabIndex = 76
        Me.HeatwormTextLbl.Text = "Heartworm Test:"
        '
        'MedicalInformationLbl
        '
        Me.MedicalInformationLbl.AutoSize = True
        Me.MedicalInformationLbl.Location = New System.Drawing.Point(16, 178)
        Me.MedicalInformationLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MedicalInformationLbl.Name = "MedicalInformationLbl"
        Me.MedicalInformationLbl.Size = New System.Drawing.Size(130, 17)
        Me.MedicalInformationLbl.TabIndex = 79
        Me.MedicalInformationLbl.Text = "Medical Information"
        '
        'DatePicker_LastTestDate
        '
        Me.DatePicker_LastTestDate.Location = New System.Drawing.Point(155, 370)
        Me.DatePicker_LastTestDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatePicker_LastTestDate.Name = "DatePicker_LastTestDate"
        Me.DatePicker_LastTestDate.Size = New System.Drawing.Size(265, 22)
        Me.DatePicker_LastTestDate.TabIndex = 13
        '
        'LastTestingDateLbl
        '
        Me.LastTestingDateLbl.AutoSize = True
        Me.LastTestingDateLbl.Location = New System.Drawing.Point(37, 378)
        Me.LastTestingDateLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LastTestingDateLbl.Name = "LastTestingDateLbl"
        Me.LastTestingDateLbl.Size = New System.Drawing.Size(105, 17)
        Me.LastTestingDateLbl.TabIndex = 81
        Me.LastTestingDateLbl.Text = "Last Test Date:"
        '
        'MedicationDateLbl
        '
        Me.MedicationDateLbl.AutoSize = True
        Me.MedicationDateLbl.Location = New System.Drawing.Point(37, 410)
        Me.MedicationDateLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MedicationDateLbl.Name = "MedicationDateLbl"
        Me.MedicationDateLbl.Size = New System.Drawing.Size(148, 17)
        Me.MedicationDateLbl.TabIndex = 83
        Me.MedicationDateLbl.Text = "Start Medication Date:"
        '
        'DatePicker_MedicationDate
        '
        Me.DatePicker_MedicationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_MedicationDate.Location = New System.Drawing.Point(196, 402)
        Me.DatePicker_MedicationDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatePicker_MedicationDate.Name = "DatePicker_MedicationDate"
        Me.DatePicker_MedicationDate.Size = New System.Drawing.Size(224, 22)
        Me.DatePicker_MedicationDate.TabIndex = 14
        '
        'RetestDateLbl
        '
        Me.RetestDateLbl.AutoSize = True
        Me.RetestDateLbl.Location = New System.Drawing.Point(37, 442)
        Me.RetestDateLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RetestDateLbl.Name = "RetestDateLbl"
        Me.RetestDateLbl.Size = New System.Drawing.Size(87, 17)
        Me.RetestDateLbl.TabIndex = 85
        Me.RetestDateLbl.Text = "Retest Date:"
        '
        'DatePicker_RetestDate
        '
        Me.DatePicker_RetestDate.Location = New System.Drawing.Point(155, 434)
        Me.DatePicker_RetestDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatePicker_RetestDate.Name = "DatePicker_RetestDate"
        Me.DatePicker_RetestDate.Size = New System.Drawing.Size(265, 22)
        Me.DatePicker_RetestDate.TabIndex = 15
        '
        'CheckboxRabies
        '
        Me.CheckboxRabies.AutoSize = True
        Me.CheckboxRabies.Location = New System.Drawing.Point(121, 488)
        Me.CheckboxRabies.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckboxRabies.Name = "CheckboxRabies"
        Me.CheckboxRabies.Size = New System.Drawing.Size(53, 21)
        Me.CheckboxRabies.TabIndex = 16
        Me.CheckboxRabies.Text = "Y/N"
        Me.CheckboxRabies.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 462)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 17)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Vaccination Information"
        '
        'RabiesLbl
        '
        Me.RabiesLbl.AutoSize = True
        Me.RabiesLbl.Location = New System.Drawing.Point(37, 492)
        Me.RabiesLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RabiesLbl.Name = "RabiesLbl"
        Me.RabiesLbl.Size = New System.Drawing.Size(56, 17)
        Me.RabiesLbl.TabIndex = 90
        Me.RabiesLbl.Text = "Rabies:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 547)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Bordetella:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 518)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Distemper:"
        '
        'CheckboxBordetella
        '
        Me.CheckboxBordetella.AutoSize = True
        Me.CheckboxBordetella.Location = New System.Drawing.Point(121, 545)
        Me.CheckboxBordetella.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckboxBordetella.Name = "CheckboxBordetella"
        Me.CheckboxBordetella.Size = New System.Drawing.Size(53, 21)
        Me.CheckboxBordetella.TabIndex = 20
        Me.CheckboxBordetella.Text = "Y/N"
        Me.CheckboxBordetella.UseVisualStyleBackColor = True
        '
        'CheckboxDistemper
        '
        Me.CheckboxDistemper.AutoSize = True
        Me.CheckboxDistemper.Location = New System.Drawing.Point(121, 517)
        Me.CheckboxDistemper.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckboxDistemper.Name = "CheckboxDistemper"
        Me.CheckboxDistemper.Size = New System.Drawing.Size(53, 21)
        Me.CheckboxDistemper.TabIndex = 18
        Me.CheckboxDistemper.Text = "Y/N"
        Me.CheckboxDistemper.UseVisualStyleBackColor = True
        '
        'DatePicker_Bordetella
        '
        Me.DatePicker_Bordetella.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Bordetella.Location = New System.Drawing.Point(291, 541)
        Me.DatePicker_Bordetella.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatePicker_Bordetella.Name = "DatePicker_Bordetella"
        Me.DatePicker_Bordetella.Size = New System.Drawing.Size(129, 22)
        Me.DatePicker_Bordetella.TabIndex = 21
        '
        'DatePicker_Distemper
        '
        Me.DatePicker_Distemper.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Distemper.Location = New System.Drawing.Point(291, 513)
        Me.DatePicker_Distemper.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatePicker_Distemper.Name = "DatePicker_Distemper"
        Me.DatePicker_Distemper.Size = New System.Drawing.Size(129, 22)
        Me.DatePicker_Distemper.TabIndex = 19
        '
        'DatePicker_Rabies
        '
        Me.DatePicker_Rabies.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Rabies.Location = New System.Drawing.Point(291, 485)
        Me.DatePicker_Rabies.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatePicker_Rabies.Name = "DatePicker_Rabies"
        Me.DatePicker_Rabies.Size = New System.Drawing.Size(129, 22)
        Me.DatePicker_Rabies.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(191, 490)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Date Tested:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(191, 546)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Date Tested:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(191, 517)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Date Tested:"
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(9, 573)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(100, 28)
        Me.BackBtn.TabIndex = 22
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'CancleBtn
        '
        Me.CancleBtn.Location = New System.Drawing.Point(233, 573)
        Me.CancleBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CancleBtn.Name = "CancleBtn"
        Me.CancleBtn.Size = New System.Drawing.Size(100, 28)
        Me.CancleBtn.TabIndex = 23
        Me.CancleBtn.Text = "Cancle"
        Me.CancleBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(341, 573)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(100, 28)
        Me.AddBtn.TabIndex = 24
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RdioShort)
        Me.Panel1.Controls.Add(Me.lbl_Hairtype)
        Me.Panel1.Controls.Add(Me.RdioLong)
        Me.Panel1.Location = New System.Drawing.Point(124, 123)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 28)
        Me.Panel1.TabIndex = 104
        '
        'RdioShort
        '
        Me.RdioShort.AutoSize = True
        Me.RdioShort.Location = New System.Drawing.Point(87, 4)
        Me.RdioShort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RdioShort.Name = "RdioShort"
        Me.RdioShort.Size = New System.Drawing.Size(63, 21)
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
        Me.lbl_Hairtype.Location = New System.Drawing.Point(148, 4)
        Me.lbl_Hairtype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Hairtype.Name = "lbl_Hairtype"
        Me.lbl_Hairtype.Size = New System.Drawing.Size(15, 20)
        Me.lbl_Hairtype.TabIndex = 107
        Me.lbl_Hairtype.Text = "*"
        Me.lbl_Hairtype.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RdioFemale)
        Me.Panel2.Controls.Add(Me.lbl_Gender)
        Me.Panel2.Controls.Add(Me.RdioMale)
        Me.Panel2.Location = New System.Drawing.Point(124, 155)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 28)
        Me.Panel2.TabIndex = 69
        '
        'RdioFemale
        '
        Me.RdioFemale.AutoSize = True
        Me.RdioFemale.Location = New System.Drawing.Point(85, 4)
        Me.RdioFemale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RdioFemale.Name = "RdioFemale"
        Me.RdioFemale.Size = New System.Drawing.Size(75, 21)
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
        Me.lbl_Gender.Location = New System.Drawing.Point(159, 4)
        Me.lbl_Gender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(15, 20)
        Me.lbl_Gender.TabIndex = 109
        Me.lbl_Gender.Text = "*"
        Me.lbl_Gender.Visible = False
        '
        'lbl_InfoError
        '
        Me.lbl_InfoError.AutoSize = True
        Me.lbl_InfoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_InfoError.ForeColor = System.Drawing.Color.Red
        Me.lbl_InfoError.Location = New System.Drawing.Point(277, 605)
        Me.lbl_InfoError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_InfoError.Name = "lbl_InfoError"
        Me.lbl_InfoError.Size = New System.Drawing.Size(165, 17)
        Me.lbl_InfoError.TabIndex = 105
        Me.lbl_InfoError.Text = "*- Required Field Missing"
        Me.lbl_InfoError.Visible = False
        '
        'lbl_Weight
        '
        Me.lbl_Weight.AutoSize = True
        Me.lbl_Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Weight.ForeColor = System.Drawing.Color.Red
        Me.lbl_Weight.Location = New System.Drawing.Point(155, 62)
        Me.lbl_Weight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Weight.Name = "lbl_Weight"
        Me.lbl_Weight.Size = New System.Drawing.Size(15, 20)
        Me.lbl_Weight.TabIndex = 106
        Me.lbl_Weight.Text = "*"
        Me.lbl_Weight.Visible = False
        '
        'lbl_Haircolor
        '
        Me.lbl_Haircolor.AutoSize = True
        Me.lbl_Haircolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Haircolor.ForeColor = System.Drawing.Color.Red
        Me.lbl_Haircolor.Location = New System.Drawing.Point(220, 89)
        Me.lbl_Haircolor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Haircolor.Name = "lbl_Haircolor"
        Me.lbl_Haircolor.Size = New System.Drawing.Size(15, 20)
        Me.lbl_Haircolor.TabIndex = 108
        Me.lbl_Haircolor.Text = "*"
        Me.lbl_Haircolor.Visible = False
        '
        'lbl_heartworm
        '
        Me.lbl_heartworm.AutoSize = True
        Me.lbl_heartworm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_heartworm.ForeColor = System.Drawing.Color.Red
        Me.lbl_heartworm.Location = New System.Drawing.Point(328, 342)
        Me.lbl_heartworm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_heartworm.Name = "lbl_heartworm"
        Me.lbl_heartworm.Size = New System.Drawing.Size(15, 20)
        Me.lbl_heartworm.TabIndex = 109
        Me.lbl_heartworm.Text = "*"
        Me.lbl_heartworm.Visible = False
        '
        'txt_Breed
        '
        Me.txt_Breed.Location = New System.Drawing.Point(108, 31)
        Me.txt_Breed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Breed.Name = "txt_Breed"
        Me.txt_Breed.Size = New System.Drawing.Size(132, 22)
        Me.txt_Breed.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Breed:"
        '
        'lbl_Breed
        '
        Me.lbl_Breed.AutoSize = True
        Me.lbl_Breed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Breed.ForeColor = System.Drawing.Color.Red
        Me.lbl_Breed.Location = New System.Drawing.Point(241, 28)
        Me.lbl_Breed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Breed.Name = "lbl_Breed"
        Me.lbl_Breed.Size = New System.Drawing.Size(15, 20)
        Me.lbl_Breed.TabIndex = 112
        Me.lbl_Breed.Text = "*"
        Me.lbl_Breed.Visible = False
        '
        'datePickerNeutered
        '
        Me.datePickerNeutered.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePickerNeutered.Location = New System.Drawing.Point(195, 235)
        Me.datePickerNeutered.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datePickerNeutered.Name = "datePickerNeutered"
        Me.datePickerNeutered.Size = New System.Drawing.Size(153, 22)
        Me.datePickerNeutered.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(73, 235)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 17)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Procedure Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 291)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 17)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Start Med Date:"
        '
        'datePickerStartMed
        '
        Me.datePickerStartMed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePickerStartMed.Location = New System.Drawing.Point(195, 291)
        Me.datePickerStartMed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datePickerStartMed.Name = "datePickerStartMed"
        Me.datePickerStartMed.Size = New System.Drawing.Size(153, 22)
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
        Me.TableAdapterManager.dogInfoTableAdapter = Me.DogInfoTableAdapter
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RdioKg)
        Me.Panel4.Controls.Add(Me.RdioLbs)
        Me.Panel4.Location = New System.Drawing.Point(172, 61)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(103, 25)
        Me.Panel4.TabIndex = 182
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
        'DogInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(449, 623)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents AllDataDataSet As WindowsApplication1.AllDataDataSet
    Friend WithEvents DogInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DogInfoTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.dogInfoTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableAdapterManager As WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager
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
