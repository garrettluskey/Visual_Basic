<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatInfoForm
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
        Me.LastTestingDateLbl = New System.Windows.Forms.Label()
        Me.DatePicker_FleaTest = New System.Windows.Forms.DateTimePicker()
        Me.CatInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllDataDataSet = New WindowsApplication1.AllDataDataSet()
        Me.MedicalInformationLbl = New System.Windows.Forms.Label()
        Me.FleaTestLbl = New System.Windows.Forms.Label()
        Me.FleaCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NeuteredCheckbox = New System.Windows.Forms.CheckBox()
        Me.GndrLbl = New System.Windows.Forms.Label()
        Me.txt_Weight = New System.Windows.Forms.TextBox()
        Me.txt_HairColor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WeightLbl = New System.Windows.Forms.Label()
        Me.BreedInformationLbl = New System.Windows.Forms.Label()
        Me.DeclawedCheckBox = New System.Windows.Forms.CheckBox()
        Me.FutureDeclawCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RdioFrontPaws = New System.Windows.Forms.RadioButton()
        Me.RdioFrontAndBackPaws = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RdioLeukemiaNegative = New System.Windows.Forms.RadioButton()
        Me.RdioLekemiaPositive = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DatePicker_LeukemiaTest = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RabiesCheckBox = New System.Windows.Forms.CheckBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.CancleBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RdioLong = New System.Windows.Forms.RadioButton()
        Me.lbl_HairType = New System.Windows.Forms.Label()
        Me.RdioShort = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RdioFemale = New System.Windows.Forms.RadioButton()
        Me.lbl_Gender = New System.Windows.Forms.Label()
        Me.RdioMale = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_FutureDeclaw = New System.Windows.Forms.Label()
        Me.lbl_Weight = New System.Windows.Forms.Label()
        Me.lbl_HairColor = New System.Windows.Forms.Label()
        Me.lbl_Leukemia = New System.Windows.Forms.Label()
        Me.lbl_InfoError = New System.Windows.Forms.Label()
        Me.txt_Breed = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl_breed = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datePickerNeutered = New System.Windows.Forms.DateTimePicker()
        Me.CatInfoTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.CatInfoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RdioKg = New System.Windows.Forms.RadioButton()
        Me.RdioLbs = New System.Windows.Forms.RadioButton()
        CType(Me.CatInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LastTestingDateLbl
        '
        Me.LastTestingDateLbl.AutoSize = True
        Me.LastTestingDateLbl.Location = New System.Drawing.Point(172, 206)
        Me.LastTestingDateLbl.Name = "LastTestingDateLbl"
        Me.LastTestingDateLbl.Size = New System.Drawing.Size(106, 13)
        Me.LastTestingDateLbl.TabIndex = 127
        Me.LastTestingDateLbl.Text = "First Treatment Date:"
        '
        'DatePicker_FleaTest
        '
        Me.DatePicker_FleaTest.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CatInfoBindingSource, "fleaTestDate", True))
        Me.DatePicker_FleaTest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_FleaTest.Location = New System.Drawing.Point(284, 201)
        Me.DatePicker_FleaTest.Name = "DatePicker_FleaTest"
        Me.DatePicker_FleaTest.Size = New System.Drawing.Size(111, 20)
        Me.DatePicker_FleaTest.TabIndex = 9
        '
        'CatInfoBindingSource
        '
        Me.CatInfoBindingSource.DataMember = "CatInfo"
        Me.CatInfoBindingSource.DataSource = Me.AllDataDataSet
        '
        'AllDataDataSet
        '
        Me.AllDataDataSet.DataSetName = "AllDataDataSet"
        Me.AllDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicalInformationLbl
        '
        Me.MedicalInformationLbl.AutoSize = True
        Me.MedicalInformationLbl.Location = New System.Drawing.Point(10, 134)
        Me.MedicalInformationLbl.Name = "MedicalInformationLbl"
        Me.MedicalInformationLbl.Size = New System.Drawing.Size(99, 13)
        Me.MedicalInformationLbl.TabIndex = 125
        Me.MedicalInformationLbl.Text = "Medical Information"
        '
        'FleaTestLbl
        '
        Me.FleaTestLbl.AutoSize = True
        Me.FleaTestLbl.Location = New System.Drawing.Point(29, 205)
        Me.FleaTestLbl.Name = "FleaTestLbl"
        Me.FleaTestLbl.Size = New System.Drawing.Size(54, 13)
        Me.FleaTestLbl.TabIndex = 121
        Me.FleaTestLbl.Text = "Flea Test:"
        '
        'FleaCheckBox
        '
        Me.FleaCheckBox.AutoSize = True
        Me.FleaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CatInfoBindingSource, "fleaTest", True))
        Me.FleaCheckBox.Location = New System.Drawing.Point(127, 206)
        Me.FleaCheckBox.Name = "FleaCheckBox"
        Me.FleaCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.FleaCheckBox.TabIndex = 8
        Me.FleaCheckBox.Text = "Y/N"
        Me.FleaCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Spayed/Neutered:"
        '
        'NeuteredCheckbox
        '
        Me.NeuteredCheckbox.AutoSize = True
        Me.NeuteredCheckbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CatInfoBindingSource, "neutered", True))
        Me.NeuteredCheckbox.Location = New System.Drawing.Point(127, 157)
        Me.NeuteredCheckbox.Name = "NeuteredCheckbox"
        Me.NeuteredCheckbox.Size = New System.Drawing.Size(46, 17)
        Me.NeuteredCheckbox.TabIndex = 7
        Me.NeuteredCheckbox.Text = "Y/N"
        Me.NeuteredCheckbox.UseVisualStyleBackColor = True
        '
        'GndrLbl
        '
        Me.GndrLbl.AutoSize = True
        Me.GndrLbl.Location = New System.Drawing.Point(29, 116)
        Me.GndrLbl.Name = "GndrLbl"
        Me.GndrLbl.Size = New System.Drawing.Size(45, 13)
        Me.GndrLbl.TabIndex = 115
        Me.GndrLbl.Text = "Gender:"
        '
        'txt_Weight
        '
        Me.txt_Weight.Location = New System.Drawing.Point(79, 56)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.Size = New System.Drawing.Size(35, 20)
        Me.txt_Weight.TabIndex = 1
        '
        'txt_HairColor
        '
        Me.txt_HairColor.Location = New System.Drawing.Point(269, 58)
        Me.txt_HairColor.Name = "txt_HairColor"
        Me.txt_HairColor.Size = New System.Drawing.Size(72, 20)
        Me.txt_HairColor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Hair Color:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Hair Type:"
        '
        'WeightLbl
        '
        Me.WeightLbl.AutoSize = True
        Me.WeightLbl.Location = New System.Drawing.Point(29, 59)
        Me.WeightLbl.Name = "WeightLbl"
        Me.WeightLbl.Size = New System.Drawing.Size(44, 13)
        Me.WeightLbl.TabIndex = 108
        Me.WeightLbl.Text = "Weight:"
        '
        'BreedInformationLbl
        '
        Me.BreedInformationLbl.AutoSize = True
        Me.BreedInformationLbl.Location = New System.Drawing.Point(12, 9)
        Me.BreedInformationLbl.Name = "BreedInformationLbl"
        Me.BreedInformationLbl.Size = New System.Drawing.Size(90, 13)
        Me.BreedInformationLbl.TabIndex = 107
        Me.BreedInformationLbl.Text = "Breed Information"
        '
        'DeclawedCheckBox
        '
        Me.DeclawedCheckBox.AutoSize = True
        Me.DeclawedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CatInfoBindingSource, "declawed", True))
        Me.DeclawedCheckBox.Location = New System.Drawing.Point(127, 229)
        Me.DeclawedCheckBox.Name = "DeclawedCheckBox"
        Me.DeclawedCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.DeclawedCheckBox.TabIndex = 11
        Me.DeclawedCheckBox.Text = "Y/N"
        Me.DeclawedCheckBox.UseVisualStyleBackColor = True
        '
        'FutureDeclawCheckBox
        '
        Me.FutureDeclawCheckBox.AutoSize = True
        Me.FutureDeclawCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CatInfoBindingSource, "futureDeclaw", True))
        Me.FutureDeclawCheckBox.Location = New System.Drawing.Point(145, 248)
        Me.FutureDeclawCheckBox.Name = "FutureDeclawCheckBox"
        Me.FutureDeclawCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.FutureDeclawCheckBox.TabIndex = 12
        Me.FutureDeclawCheckBox.Text = "Y/N"
        Me.FutureDeclawCheckBox.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "Future Declawing:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Declawed:"
        '
        'RdioFrontPaws
        '
        Me.RdioFrontPaws.AutoSize = True
        Me.RdioFrontPaws.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CatInfoBindingSource, "futureDeclawInfo", True))
        Me.RdioFrontPaws.Enabled = False
        Me.RdioFrontPaws.Location = New System.Drawing.Point(3, 3)
        Me.RdioFrontPaws.Name = "RdioFrontPaws"
        Me.RdioFrontPaws.Size = New System.Drawing.Size(78, 17)
        Me.RdioFrontPaws.TabIndex = 13
        Me.RdioFrontPaws.TabStop = True
        Me.RdioFrontPaws.Text = "Front Paws"
        Me.RdioFrontPaws.UseVisualStyleBackColor = True
        '
        'RdioFrontAndBackPaws
        '
        Me.RdioFrontAndBackPaws.AutoSize = True
        Me.RdioFrontAndBackPaws.Enabled = False
        Me.RdioFrontAndBackPaws.Location = New System.Drawing.Point(87, 3)
        Me.RdioFrontAndBackPaws.Name = "RdioFrontAndBackPaws"
        Me.RdioFrontAndBackPaws.Size = New System.Drawing.Size(127, 17)
        Me.RdioFrontAndBackPaws.TabIndex = 14
        Me.RdioFrontAndBackPaws.TabStop = True
        Me.RdioFrontAndBackPaws.Text = "Front and Back Paws"
        Me.RdioFrontAndBackPaws.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 268)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 13)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "Future Declawing Information"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 13)
        Me.Label14.TabIndex = 156
        Me.Label14.Text = "Feline Leukemia Test:"
        '
        'RdioLeukemiaNegative
        '
        Me.RdioLeukemiaNegative.AutoSize = True
        Me.RdioLeukemiaNegative.Location = New System.Drawing.Point(210, 310)
        Me.RdioLeukemiaNegative.Name = "RdioLeukemiaNegative"
        Me.RdioLeukemiaNegative.Size = New System.Drawing.Size(68, 17)
        Me.RdioLeukemiaNegative.TabIndex = 16
        Me.RdioLeukemiaNegative.TabStop = True
        Me.RdioLeukemiaNegative.Text = "Negative"
        Me.RdioLeukemiaNegative.UseVisualStyleBackColor = True
        '
        'RdioLekemiaPositive
        '
        Me.RdioLekemiaPositive.AutoSize = True
        Me.RdioLekemiaPositive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CatInfoBindingSource, "leukemia", True))
        Me.RdioLekemiaPositive.Location = New System.Drawing.Point(145, 310)
        Me.RdioLekemiaPositive.Name = "RdioLekemiaPositive"
        Me.RdioLekemiaPositive.Size = New System.Drawing.Size(62, 17)
        Me.RdioLekemiaPositive.TabIndex = 15
        Me.RdioLekemiaPositive.TabStop = True
        Me.RdioLekemiaPositive.Text = "Positive"
        Me.RdioLekemiaPositive.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 330)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 160
        Me.Label13.Text = "Test Date:"
        '
        'DatePicker_LeukemiaTest
        '
        Me.DatePicker_LeukemiaTest.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CatInfoBindingSource, "leukemiaTestDate", True))
        Me.DatePicker_LeukemiaTest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_LeukemiaTest.Location = New System.Drawing.Point(112, 328)
        Me.DatePicker_LeukemiaTest.Name = "DatePicker_LeukemiaTest"
        Me.DatePicker_LeukemiaTest.Size = New System.Drawing.Size(111, 20)
        Me.DatePicker_LeukemiaTest.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 347)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 26)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Rabies " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vaccination:"
        '
        'RabiesCheckBox
        '
        Me.RabiesCheckBox.AutoSize = True
        Me.RabiesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CatInfoBindingSource, "rabiesTest", True))
        Me.RabiesCheckBox.Location = New System.Drawing.Point(102, 354)
        Me.RabiesCheckBox.Name = "RabiesCheckBox"
        Me.RabiesCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.RabiesCheckBox.TabIndex = 18
        Me.RabiesCheckBox.Text = "Y/N"
        Me.RabiesCheckBox.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(320, 376)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 21
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'CancleBtn
        '
        Me.CancleBtn.Location = New System.Drawing.Point(239, 376)
        Me.CancleBtn.Name = "CancleBtn"
        Me.CancleBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancleBtn.TabIndex = 20
        Me.CancleBtn.Text = "Cancle"
        Me.CancleBtn.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(10, 376)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(75, 23)
        Me.BackBtn.TabIndex = 19
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RdioLong)
        Me.Panel1.Controls.Add(Me.lbl_HairType)
        Me.Panel1.Controls.Add(Me.RdioShort)
        Me.Panel1.Location = New System.Drawing.Point(81, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 24)
        Me.Panel1.TabIndex = 166
        '
        'RdioLong
        '
        Me.RdioLong.AutoSize = True
        Me.RdioLong.Location = New System.Drawing.Point(59, 3)
        Me.RdioLong.Name = "RdioLong"
        Me.RdioLong.Size = New System.Drawing.Size(49, 17)
        Me.RdioLong.TabIndex = 4
        Me.RdioLong.TabStop = True
        Me.RdioLong.Text = "Long"
        Me.RdioLong.UseVisualStyleBackColor = True
        '
        'lbl_HairType
        '
        Me.lbl_HairType.AutoSize = True
        Me.lbl_HairType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_HairType.ForeColor = System.Drawing.Color.Red
        Me.lbl_HairType.Location = New System.Drawing.Point(104, 2)
        Me.lbl_HairType.Name = "lbl_HairType"
        Me.lbl_HairType.Size = New System.Drawing.Size(13, 17)
        Me.lbl_HairType.TabIndex = 172
        Me.lbl_HairType.Text = "*"
        Me.lbl_HairType.Visible = False
        '
        'RdioShort
        '
        Me.RdioShort.AutoSize = True
        Me.RdioShort.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CatInfoBindingSource, "hairtype", True))
        Me.RdioShort.Location = New System.Drawing.Point(3, 3)
        Me.RdioShort.Name = "RdioShort"
        Me.RdioShort.Size = New System.Drawing.Size(50, 17)
        Me.RdioShort.TabIndex = 3
        Me.RdioShort.TabStop = True
        Me.RdioShort.Text = "Short"
        Me.RdioShort.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RdioFemale)
        Me.Panel2.Controls.Add(Me.lbl_Gender)
        Me.Panel2.Controls.Add(Me.RdioMale)
        Me.Panel2.Location = New System.Drawing.Point(81, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(126, 25)
        Me.Panel2.TabIndex = 167
        '
        'RdioFemale
        '
        Me.RdioFemale.AutoSize = True
        Me.RdioFemale.Location = New System.Drawing.Point(58, 3)
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
        Me.lbl_Gender.Location = New System.Drawing.Point(116, 4)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Gender.TabIndex = 171
        Me.lbl_Gender.Text = "*"
        Me.lbl_Gender.Visible = False
        '
        'RdioMale
        '
        Me.RdioMale.AutoSize = True
        Me.RdioMale.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CatInfoBindingSource, "gender", True))
        Me.RdioMale.Location = New System.Drawing.Point(3, 3)
        Me.RdioMale.Name = "RdioMale"
        Me.RdioMale.Size = New System.Drawing.Size(48, 17)
        Me.RdioMale.TabIndex = 5
        Me.RdioMale.TabStop = True
        Me.RdioMale.Text = "Male"
        Me.RdioMale.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RdioFrontPaws)
        Me.Panel3.Controls.Add(Me.lbl_FutureDeclaw)
        Me.Panel3.Controls.Add(Me.RdioFrontAndBackPaws)
        Me.Panel3.Location = New System.Drawing.Point(98, 284)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 25)
        Me.Panel3.TabIndex = 168
        '
        'lbl_FutureDeclaw
        '
        Me.lbl_FutureDeclaw.AutoSize = True
        Me.lbl_FutureDeclaw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_FutureDeclaw.ForeColor = System.Drawing.Color.Red
        Me.lbl_FutureDeclaw.Location = New System.Drawing.Point(209, 2)
        Me.lbl_FutureDeclaw.Name = "lbl_FutureDeclaw"
        Me.lbl_FutureDeclaw.Size = New System.Drawing.Size(13, 17)
        Me.lbl_FutureDeclaw.TabIndex = 170
        Me.lbl_FutureDeclaw.Text = "*"
        Me.lbl_FutureDeclaw.Visible = False
        '
        'lbl_Weight
        '
        Me.lbl_Weight.AutoSize = True
        Me.lbl_Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Weight.ForeColor = System.Drawing.Color.Red
        Me.lbl_Weight.Location = New System.Drawing.Point(118, 56)
        Me.lbl_Weight.Name = "lbl_Weight"
        Me.lbl_Weight.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Weight.TabIndex = 169
        Me.lbl_Weight.Text = "*"
        Me.lbl_Weight.Visible = False
        '
        'lbl_HairColor
        '
        Me.lbl_HairColor.AutoSize = True
        Me.lbl_HairColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_HairColor.ForeColor = System.Drawing.Color.Red
        Me.lbl_HairColor.Location = New System.Drawing.Point(341, 57)
        Me.lbl_HairColor.Name = "lbl_HairColor"
        Me.lbl_HairColor.Size = New System.Drawing.Size(13, 17)
        Me.lbl_HairColor.TabIndex = 173
        Me.lbl_HairColor.Text = "*"
        Me.lbl_HairColor.Visible = False
        '
        'lbl_Leukemia
        '
        Me.lbl_Leukemia.AutoSize = True
        Me.lbl_Leukemia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Leukemia.ForeColor = System.Drawing.Color.Red
        Me.lbl_Leukemia.Location = New System.Drawing.Point(275, 310)
        Me.lbl_Leukemia.Name = "lbl_Leukemia"
        Me.lbl_Leukemia.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Leukemia.TabIndex = 171
        Me.lbl_Leukemia.Text = "*"
        Me.lbl_Leukemia.Visible = False
        '
        'lbl_InfoError
        '
        Me.lbl_InfoError.AutoSize = True
        Me.lbl_InfoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_InfoError.ForeColor = System.Drawing.Color.Red
        Me.lbl_InfoError.Location = New System.Drawing.Point(272, 402)
        Me.lbl_InfoError.Name = "lbl_InfoError"
        Me.lbl_InfoError.Size = New System.Drawing.Size(123, 13)
        Me.lbl_InfoError.TabIndex = 174
        Me.lbl_InfoError.Text = "*- Required Field Missing"
        Me.lbl_InfoError.Visible = False
        '
        'txt_Breed
        '
        Me.txt_Breed.Location = New System.Drawing.Point(79, 33)
        Me.txt_Breed.MaxLength = 50
        Me.txt_Breed.Name = "txt_Breed"
        Me.txt_Breed.Size = New System.Drawing.Size(100, 20)
        Me.txt_Breed.TabIndex = 175
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(29, 36)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(38, 13)
        Me.lbl1.TabIndex = 177
        Me.lbl1.Text = "Breed:"
        '
        'lbl_breed
        '
        Me.lbl_breed.AutoSize = True
        Me.lbl_breed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_breed.ForeColor = System.Drawing.Color.Red
        Me.lbl_breed.Location = New System.Drawing.Point(179, 30)
        Me.lbl_breed.Name = "lbl_breed"
        Me.lbl_breed.Size = New System.Drawing.Size(13, 17)
        Me.lbl_breed.TabIndex = 178
        Me.lbl_breed.Text = "*"
        Me.lbl_breed.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "Procedure Date:"
        '
        'datePickerNeutered
        '
        Me.datePickerNeutered.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePickerNeutered.Location = New System.Drawing.Point(139, 180)
        Me.datePickerNeutered.Name = "datePickerNeutered"
        Me.datePickerNeutered.Size = New System.Drawing.Size(173, 20)
        Me.datePickerNeutered.TabIndex = 179
        '
        'CatInfoTableAdapter
        '
        Me.CatInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.animalMasterTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatInfoTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.dogInfoTableAdapter = Nothing
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RdioKg)
        Me.Panel4.Controls.Add(Me.RdioLbs)
        Me.Panel4.Location = New System.Drawing.Point(127, 56)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(77, 20)
        Me.Panel4.TabIndex = 181
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
        'CatInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(407, 417)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.datePickerNeutered)
        Me.Controls.Add(Me.lbl_breed)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txt_Breed)
        Me.Controls.Add(Me.lbl_InfoError)
        Me.Controls.Add(Me.lbl_Leukemia)
        Me.Controls.Add(Me.lbl_HairColor)
        Me.Controls.Add(Me.lbl_Weight)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.CancleBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.RabiesCheckBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DatePicker_LeukemiaTest)
        Me.Controls.Add(Me.RdioLeukemiaNegative)
        Me.Controls.Add(Me.RdioLekemiaPositive)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FutureDeclawCheckBox)
        Me.Controls.Add(Me.DeclawedCheckBox)
        Me.Controls.Add(Me.LastTestingDateLbl)
        Me.Controls.Add(Me.DatePicker_FleaTest)
        Me.Controls.Add(Me.MedicalInformationLbl)
        Me.Controls.Add(Me.FleaTestLbl)
        Me.Controls.Add(Me.FleaCheckBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NeuteredCheckbox)
        Me.Controls.Add(Me.GndrLbl)
        Me.Controls.Add(Me.txt_Weight)
        Me.Controls.Add(Me.txt_HairColor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WeightLbl)
        Me.Controls.Add(Me.BreedInformationLbl)
        Me.Name = "CatInfoForm"
        Me.Text = "Cat Information"
        CType(Me.CatInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LastTestingDateLbl As System.Windows.Forms.Label
    Friend WithEvents DatePicker_FleaTest As System.Windows.Forms.DateTimePicker
    Friend WithEvents MedicalInformationLbl As System.Windows.Forms.Label
    Friend WithEvents FleaTestLbl As System.Windows.Forms.Label
    Friend WithEvents FleaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NeuteredCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents GndrLbl As System.Windows.Forms.Label
    Friend WithEvents txt_Weight As System.Windows.Forms.TextBox
    Friend WithEvents txt_HairColor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WeightLbl As System.Windows.Forms.Label
    Friend WithEvents BreedInformationLbl As System.Windows.Forms.Label
    Friend WithEvents DeclawedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FutureDeclawCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RdioFrontPaws As System.Windows.Forms.RadioButton
    Friend WithEvents RdioFrontAndBackPaws As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RdioLeukemiaNegative As System.Windows.Forms.RadioButton
    Friend WithEvents RdioLekemiaPositive As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DatePicker_LeukemiaTest As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RabiesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents CancleBtn As System.Windows.Forms.Button
    Friend WithEvents BackBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RdioLong As System.Windows.Forms.RadioButton
    Friend WithEvents RdioShort As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RdioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RdioMale As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Weight As System.Windows.Forms.Label
    Friend WithEvents lbl_HairType As System.Windows.Forms.Label
    Friend WithEvents lbl_Gender As System.Windows.Forms.Label
    Friend WithEvents lbl_FutureDeclaw As System.Windows.Forms.Label
    Friend WithEvents lbl_HairColor As System.Windows.Forms.Label
    Friend WithEvents lbl_Leukemia As System.Windows.Forms.Label
    Friend WithEvents AllDataDataSet As WindowsApplication1.AllDataDataSet
    Friend WithEvents CatInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CatInfoTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.CatInfoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lbl_InfoError As System.Windows.Forms.Label
    Friend WithEvents txt_Breed As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl_breed As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents datePickerNeutered As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RdioKg As System.Windows.Forms.RadioButton
    Friend WithEvents RdioLbs As System.Windows.Forms.RadioButton
End Class
