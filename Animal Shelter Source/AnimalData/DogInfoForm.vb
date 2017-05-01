Public Class DogInfoForm

    Public CombVarWeight As String = Nothing
    Public ConVarHairType As Byte = Nothing
    Public ConVarGender As Byte = Nothing
    Public ConVarNeutered As Byte = 0
    Public ConVarFleaTest As Byte = 0
    Public ConVarHeartworm As Byte = Nothing
    Public ConVarRabies As Byte = 0
    Public ConVarDistemper As Byte = 0
    Public ConVarBordetella As Byte = 0

    Private Sub DogInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datePickerNeutered.Enabled = True
        datePickerStartMed.Enabled = False

        RdioLong.Checked = False
        RdioShort.Checked = False
        RdioMale.Checked = False
        RdioFemale.Checked = False
        RdioPositive.Checked = False
        RdioNegative.Checked = False

        txt_Breed.Text = ""
        HaircolorTextbox.Text = ""
        WeightTextbox.Text = ""
        'TODO: This line of code loads data into the 'AllDataDataSet.dogInfo' table. You can move, or remove it, as needed.
        Me.DogInfoTableAdapter.Fill(Me.AllDataDataSet.dogInfo)
        DatePicker_MedicationDate.Enabled = False
        DatePicker_RetestDate.Enabled = False
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        lbl_InfoError.Hide()
        lbl_Haircolor.Hide()
        lbl_Gender.Hide()
        lbl_Hairtype.Hide()
        lbl_Weight.Hide()
        lbl_heartworm.Hide()

        If RdioKg.Checked = True Then
            CombVarWeight = WeightTextbox.Text + " Kg"
        ElseIf RdioLbs.Checked = True Then
            CombVarWeight = WeightTextbox.Text + " Lbs"
        End If

        If RdioLong.Checked = True Then
            ConVarHairType = 1
        ElseIf RdioShort.Checked = True Then
            ConVarHairType = 0
        End If

        If RdioLong.Checked = True Then
            ConVarGender = 1
        ElseIf RdioShort.Checked = True Then
            ConVarGender = 0
        End If

        If RdioPositive.Checked = True Then
            ConVarHeartworm = 1
        ElseIf RdioNegative.Checked = True Then
            ConVarHeartworm = 0
        End If


        Try
            If RdioKg.Checked = False And RdioLbs.Checked = False Then
                Throw New Exception("Forced Exeption")
            End If
            If RdioLong.Checked = False And RdioShort.Checked = False Then
                Throw New Exception("Forced Exeption")
            End If
            If RdioMale.Checked = False And RdioFemale.Checked = False Then
                Throw New Exception("Forced Exeption")
            End If
            If RdioPositive.Checked = False And RdioNegative.Checked = False Then
                Throw New Exception("Forced Exeption")
            End If

            AllDataDataSet.dogInfo.firstTestDateColumn.DefaultValue = DatePicker_LastTestDate.Value
            AllDataDataSet.dogInfo.medDateColumn.DefaultValue = DatePicker_MedicationDate.Value
            AllDataDataSet.dogInfo.lastTestDateColumn.DefaultValue = DatePicker_RetestDate.Value
            AllDataDataSet.dogInfo.rabiesTestDateColumn.DefaultValue = DatePicker_Rabies.Value
            AllDataDataSet.dogInfo.distemperTestDateColumn.DefaultValue = DatePicker_Distemper.Value
            AllDataDataSet.dogInfo.bordetellaTestDateColumn.DefaultValue = DatePicker_Bordetella.Value
            AllDataDataSet.dogInfo.neuteredDateColumn.DefaultValue = datePickerNeutered.Value
            AllDataDataSet.dogInfo.startmedDateColumn.DefaultValue = datePickerStartMed.Value
            Me.DogInfoTableAdapter.InsertDogRow(BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax, CombVarWeight, HaircolorTextbox.Text, ConVarHairType, ConVarGender, ConVarNeutered, datePickerNeutered.Value, ConVarFleaTest, datePickerStartMed.Value, ConVarHeartworm, DatePicker_LastTestDate.Value, DatePicker_MedicationDate.Value, DatePicker_RetestDate.Value, ConVarRabies, ConVarDistemper, ConVarBordetella, DatePicker_Rabies.Value, DatePicker_Distemper.Value, DatePicker_Bordetella.Value, txt_Breed.Text, DogInfoTableAdapter.MaxIndex + 1)

            Me.Close()
        Catch ex As Exception
            MsgBox("Some areas are missing information.", MsgBoxStyle.OkOnly, Title:="Error")
            lbl_InfoError.Show()

            If WeightTextbox.Text = "" Then
                lbl_Weight.Show()
            End If
            If RdioLbs.Checked = False And RdioKg.Checked = False Then
                lbl_Weight.Show()
            End If
            If HaircolorTextbox.Text = "" Then
                lbl_Haircolor.Show()
            End If

            If RdioLong.Checked = False And RdioShort.Checked = False Then
                lbl_Hairtype.Show()
            End If
            If RdioMale.Checked = False And RdioFemale.Checked = False Then
                lbl_Gender.Show()
            End If
            If RdioPositive.Checked = False And RdioNegative.Checked = False Then
                lbl_heartworm.Show()
            End If
        End Try
    End Sub

    Private Sub HaircolorTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HaircolorTextbox.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub PositiveRdio_CheckedChanged(sender As Object, e As EventArgs) Handles RdioPositive.CheckedChanged
        If RdioPositive.Checked = True Then
            DatePicker_MedicationDate.Enabled = True
            DatePicker_RetestDate.Enabled = True
        Else
            DatePicker_MedicationDate.Enabled = False
            DatePicker_RetestDate.Enabled = False
        End If
    End Sub

    Private Sub NeuteredCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckboxNeutered.CheckedChanged
        If CheckboxNeutered.Checked = True Then
            ConVarNeutered = 1
            datePickerNeutered.Enabled = False
        Else
            ConVarNeutered = 0
            datePickerNeutered.Enabled = True
        End If
    End Sub


    Private Sub FleatestCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckboxFleaTest.CheckedChanged
        If CheckboxFleaTest.Checked = True Then
            ConVarFleaTest = 1
            datePickerStartMed.Enabled = True
        Else
            ConVarFleaTest = 0
            datePickerStartMed.Enabled = False
        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        BasicInfoForm.Show()
        BasicInfoForm.AnimalMasterBindingSource.MoveLast()
        BasicInfoForm.AnimalMasterTableAdapter.DeleteQuery(BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax)
        Me.Hide()
    End Sub

    Private Sub CancleBtn_Click(sender As Object, e As EventArgs) Handles CancleBtn.Click
        BasicInfoForm.AnimalMasterTableAdapter.DeleteQuery(BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax)
        Me.Close()
        BasicInfoForm.Close()
    End Sub

    Private Sub WeightTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WeightTextbox.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub



    Private Sub txt_Breed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Breed.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Breed_TextChanged(sender As Object, e As EventArgs) Handles txt_Breed.TextChanged

    End Sub

    Private Sub CheckboxRabies_CheckedChanged(sender As Object, e As EventArgs) Handles CheckboxRabies.CheckedChanged
        If CheckboxRabies.Checked = True Then
            ConVarRabies = 1
        Else
            ConVarRabies = 0
        End If
    End Sub

    Private Sub CheckboxDistemper_CheckedChanged(sender As Object, e As EventArgs) Handles CheckboxDistemper.CheckedChanged
        If CheckboxDistemper.Checked = True Then
            ConVarDistemper = 1
        Else
            ConVarDistemper = 0
        End If
    End Sub

    Private Sub CheckboxBordetella_CheckedChanged(sender As Object, e As EventArgs) Handles CheckboxBordetella.CheckedChanged
        If CheckboxBordetella.Checked = True Then
            ConVarBordetella = 1
        Else
            ConVarBordetella = 0
        End If
    End Sub
End Class