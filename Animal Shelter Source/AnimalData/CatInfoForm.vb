Public Class CatInfoForm
    'combination variable combines the weight text box with the kg and lbs radio buttons
    Public CombVarWeight As String = Nothing
    'conversion variables purpose is to change boolean values to bytes
    Public ConVarHairType As Byte = Nothing
    Public ConVarGender As Byte = Nothing
    Public ConVarNeutered As Byte = 0
    Public ConVarFleaTest As Byte = 0
    Public ConVarDeclawed As Byte = 0
    Public ConVarFutureDeclawing As Byte = 0
    Public ConVarDeclawInfo As Byte = Nothing
    Public ConVarRabiesVaccination As Byte = 0
    Public ConVarLeukemia As Byte = Nothing
    Private Property testvar As Integer?


    Private Sub CatInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'empties text boxes
        txt_Breed.Text = ""
        txt_HairColor.Text = ""
        txt_Weight.Text = ""

        'starts form by defaulting check boxes
        RdioShort.Checked = False
        RdioLong.Checked = False
        RdioFrontAndBackPaws.Checked = False
        RdioFrontPaws.Checked = False
        RdioLekemiaPositive.Checked = False
        RdioLeukemiaNegative.Checked = False
        RdioMale.Checked = False
        RdioFemale.Checked = False

        'enables date time picker
        datePickerNeutered.Enabled = True

        'fills cat info table adapter with information
        Me.CatInfoTableAdapter.Fill(Me.AllDataDataSet.CatInfo)

        'sets default value for date time pickers
        AllDataDataSet.CatInfo.fleaTestDateColumn.DefaultValue = DatePicker_FleaTest.Value
        AllDataDataSet.CatInfo.leukemiaTestDateColumn.DefaultValue = DatePicker_LeukemiaTest.Value

    End Sub


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        'sets labels to default visibility for rechecking of errors
        lbl_FutureDeclaw.Hide()
        lbl_Gender.Hide()
        lbl_HairColor.Hide()
        lbl_HairType.Hide()
        lbl_InfoError.Hide()
        lbl_Leukemia.Hide()
        lbl_Weight.Hide()

        'uses combining variable to add pounds or kilograms to the end of the integer
        If RdioLbs.Checked = True Then
            CombVarWeight = txt_Weight.Text + " Lbs"
        ElseIf RdioKg.Checked = True Then
            CombVarWeight = txt_HairColor.Text + " Kg"
        End If

        'converts all boolean radio buttons and check boxes to byte variables
        If RdioShort.Checked = True Then
            ConVarHairType = 1
        ElseIf RdioLong.Checked = True Then
            ConVarHairType = 0
        End If
        If RdioMale.Checked = True Then
            ConVarGender = 1
        ElseIf RdioFemale.Checked = True Then
            ConVarGender = 0
        End If
        If RdioFrontPaws.Checked = True Then
            ConVarFutureDeclawing = 1
        ElseIf RdioFrontAndBackPaws.Checked = True Then
            ConVarFutureDeclawing = 0
        End If
        If RdioLekemiaPositive.Checked = True Then
            ConVarLeukemia = 1
        ElseIf RdioLeukemiaNegative.Checked = True Then
            ConVarLeukemia = 0
        End If

        'checks data for errors and trys to insert a row into the cat info table
        Try
            'checks to make sure all radio buttons have a valid value
            If RdioShort.Checked = False And RdioLong.Checked = False Then
                lbl_HairType.Show()
                Throw New Exception("ForcedExeption")
            End If
            If RdioMale.Checked = False And RdioFemale.Checked = False Then
                Throw New Exception("ForcedExeption")
            End If
            If FutureDeclawCheckBox.Checked = True Then
                If RdioFrontPaws.Checked = False And RdioFrontAndBackPaws.Checked = False Then
                    Throw New Exception("ForcedExeption")
                End If
            End If
            If RdioLekemiaPositive.Checked = False And RdioLeukemiaNegative.Checked = False Then
                Throw New Exception("ForcedExeption")
            End If

            'sets case number column to maximum case number. Otherwise a null case number exeption will arise
            Me.AllDataDataSet.CatInfo.caseNumColumn.DefaultValue = BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax

            'attempts to fill a row in the cat info data table with conversion variables, combination variables, and text boxes
            Me.CatInfoTableAdapter.Insert(CombVarWeight, txt_HairColor.Text, DatePicker_FleaTest.Value, DatePicker_LeukemiaTest.Value, txt_Breed.Text, datePickerNeutered.Value, CatInfoTableAdapter.MaxIndex + 1, BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax, ConVarHairType, ConVarGender, ConVarNeutered, ConVarFleaTest, ConVarDeclawed, ConVarFutureDeclawing, ConVarDeclawInfo, ConVarLeukemia, ConVarRabiesVaccination)

            'closes form if all requests worked
            Me.Close()

        Catch ex As Exception
            'shows general error label
            lbl_InfoError.Show()

            'ckecks to see if radio buttons, textboxes, and ckeck boxes are all valid data
            If RdioShort.Checked = False And RdioLong.Checked = False Then
                lbl_HairType.Show()
            End If
            If RdioMale.Checked = False And RdioFemale.Checked = False Then
                lbl_Gender.Show()
            End If
            If FutureDeclawCheckBox.Checked = True Then
                If RdioFrontPaws.Checked = False And RdioFrontAndBackPaws.Checked = False Then
                    lbl_FutureDeclaw.Show()
                End If
            End If
            If RdioLekemiaPositive.Checked = False And RdioLeukemiaNegative.Checked = False Then
                lbl_Leukemia.Show()
            End If
            If txt_Weight.Text.Equals("") = True Then
                lbl_Weight.Show()
            End If
            If txt_HairColor.Text.Equals("") = True Then
                lbl_HairColor.Show()
            End If
            If txt_Breed.Text.Equals("") = True Then

            End If

            'shows the user an error message
            MsgBox("Some fields are missing information", MsgBoxStyle.OkOnly, Title:="Error")

        End Try
    End Sub

    Private Sub NoNullAllowedException()
        Throw New NotImplementedException
    End Sub

    Private Sub FleaCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FleaCheckBox.CheckedChanged
        'sets conversion variable to flea test check box and enables/disables the datetime picker for it
        If FleaCheckBox.Checked = True Then
            ConVarFleaTest = 1
            DatePicker_FleaTest.Enabled = True
        Else
            ConVarFleaTest = 0
            DatePicker_FleaTest.Enabled = False
        End If

    End Sub

    Private Sub NeuteredCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NeuteredCheckbox.CheckedChanged
        'sets conversion variable to neutered/spayed check box and enables/disables the datetime picker for it
        If NeuteredCheckbox.Checked = True Then
            ConVarNeutered = 1
            datePickerNeutered.Enabled = False
        Else
            ConVarNeutered = 0
            datePickerNeutered.Enabled = True
        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        'shows the basic information form if back button is pressed
        BasicInfoForm.Show()
        'tries to move to last entry in animal master table
        BasicInfoForm.AnimalMasterBindingSource.MoveLast()
        'delets the last row in animal master table
        BasicInfoForm.AnimalMasterTableAdapter.DeleteQuery(BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax)
        'hides for future reference
        Me.Hide()
    End Sub

    Private Sub CancleBtn_Click(sender As Object, e As EventArgs) Handles CancleBtn.Click
        'deletes last row in animal master table
        BasicInfoForm.AnimalMasterTableAdapter.DeleteQuery(BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax)
        'closes form to reset resources on form
        Me.Close()
        'closes basic info form to reset resources on that form
        BasicInfoForm.Close()
    End Sub

    Private Sub txt_Weight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Weight.KeyPress
        'only allows numbers and backspaces on the weight text box
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Breed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Breed.KeyPress
        'only allows letters, backspaces, and spaces
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt_HairColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_HairColor.KeyPress
        'only allows letter,
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub



    Private Sub FutureDeclawCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FutureDeclawCheckBox.CheckedChanged
        'enables furure declawing check box and 'front' or 'front and back' check boxes.
        If FutureDeclawCheckBox.Checked = True Then
            ConVarDeclawInfo = 1
            RdioFrontAndBackPaws.Enabled = True
            RdioFrontPaws.Enabled = True
        Else
            ConVarDeclawInfo = 0
            RdioFrontAndBackPaws.Enabled = False
            RdioFrontPaws.Enabled = False
        End If
    End Sub

    Private Sub DeclawedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DeclawedCheckBox.CheckedChanged
        If DeclawedCheckBox.Checked = True Then
            ConVarDeclawed = 1
            FutureDeclawCheckBox.Enabled = False
        Else
            ConVarDeclawed = 0
            FutureDeclawCheckBox.Enabled = True
        End If
    End Sub

    Private Sub txt_Breed_TextChanged(sender As Object, e As EventArgs) Handles txt_Breed.TextChanged

    End Sub

    Private Sub ShortRdio_CheckedChanged_1(sender As Object, e As EventArgs) Handles RdioShort.CheckedChanged
        If RdioShort.Checked = True Then

        End If
    End Sub

    Private Sub RabiesCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RabiesCheckBox.CheckedChanged
        If RabiesCheckBox.Checked = True Then
            ConVarRabiesVaccination = 1
        Else
            ConVarRabiesVaccination = 0
        End If
    End Sub
End Class