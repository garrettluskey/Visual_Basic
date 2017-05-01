Public Class CatInfoForm
    Public CombVarWeight As String = Nothing
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

    Private Sub HeatwormTextLbl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CatInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Breed.Text = ""
        txt_HairColor.Text = ""
        txt_Weight.Text = ""

        RdioShort.Checked = False
        RdioLong.Checked = False
        RdioFrontAndBackPaws.Checked = False
        RdioFrontPaws.Checked = False
        RdioLekemiaPositive.Checked = False
        RdioLeukemiaNegative.Checked = False
        RdioMale.Checked = False
        RdioFemale.Checked = False

        datePickerNeutered.Enabled = True
        'TODO: This line of code loads data into the 'AllDataDataSet.CatInfo' table. You can move, or remove it, as needed.
        Me.CatInfoTableAdapter.Fill(Me.AllDataDataSet.CatInfo)
        AllDataDataSet.CatInfo.fleaTestDateColumn.DefaultValue = DatePicker_FleaTest.Value
        AllDataDataSet.CatInfo.leukemiaTestDateColumn.DefaultValue = DatePicker_LeukemiaTest.Value

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DatePicker_FleaTest.ValueChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RdioFrontAndBackPaws.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RdioFrontPaws.CheckedChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub ShortRdio_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        lbl_FutureDeclaw.Hide()
        lbl_Gender.Hide()
        lbl_HairColor.Hide()
        lbl_HairType.Hide()
        lbl_InfoError.Hide()
        lbl_Leukemia.Hide()
        lbl_Weight.Hide()

        If RdioLbs.Checked = True Then
            CombVarWeight = txt_Weight.Text + " Lbs"
        ElseIf RdioKg.Checked = True Then
            CombVarWeight = txt_HairColor.Text + " Kg"
        End If
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
        Try
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


            'AllDataDataSet.CatInfo.IdColumn.DefaultValue = BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax
            'Me.CatInfoTableAdapter.Insert(BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax, txt_Weight.Text, txt_HairColor.Text, ShortRdio.Checked, MaleRdio.Checked, NeuteredCheckbox.Checked, FleaCheckBox.Checked, DatePicker_FleaTest.Value, HeartwormCheckBox.Checked, DeclawedCheckBox.Checked, FutureDeclawCheckBox.Checked, FrontRdio.Checked, PositiveRdio.Checked, DatePicker_LeukemiaTest.Value, RabiesCheckBox.Checked, 1)
            'Me.AllDataDataSet.CatInfo.caseNumColumn.DefaultValue = BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax
            Me.AllDataDataSet.CatInfo.caseNumColumn.DefaultValue = BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax
            Me.CatInfoTableAdapter.Insert(CombVarWeight, txt_HairColor.Text, DatePicker_FleaTest.Value, DatePicker_LeukemiaTest.Value, txt_Breed.Text, datePickerNeutered.Value, CatInfoTableAdapter.MaxIndex + 1, BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax, ConVarHairType, ConVarGender, ConVarNeutered, ConVarFleaTest, ConVarDeclawed, ConVarFutureDeclawing, ConVarDeclawInfo, ConVarLeukemia, ConVarRabiesVaccination)
            Me.Hide()

        Catch ex As Exception
            lbl_InfoError.Show()
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

            MsgBox("Some fields are missing information", MsgBoxStyle.OkOnly, Title:="Error")

        End Try
    End Sub

    Private Sub NoNullAllowedException()
        Throw New NotImplementedException
    End Sub

    Private Sub FleaCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FleaCheckBox.CheckedChanged
        If FleaCheckBox.Checked = True Then
            ConVarFleaTest = 1
            DatePicker_FleaTest.Enabled = True
        Else
            ConVarFleaTest = 0
            DatePicker_FleaTest.Enabled = False
        End If

    End Sub

    Private Sub NeuteredCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles NeuteredCheckbox.CheckedChanged
        If NeuteredCheckbox.Checked = True Then
            ConVarNeutered = 1
            datePickerNeutered.Enabled = False
        Else
            ConVarNeutered = 0
            datePickerNeutered.Enabled = True
        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        BasicInfoForm.Show()
        BasicInfoForm.AnimalMasterBindingSource.MoveLast()
        Me.Hide()
    End Sub

    Private Sub CancleBtn_Click(sender As Object, e As EventArgs) Handles CancleBtn.Click
        BasicInfoForm.AnimalMasterTableAdapter.DeleteQuery(BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax)
        Me.Hide()
    End Sub

    Private Sub txt_Weight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Weight.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Weight_TextChanged(sender As Object, e As EventArgs) Handles txt_Weight.TextChanged

    End Sub

    Private Sub txt_Breed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Breed.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub


    Private Sub txt_HairColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_HairColor.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub



    Private Sub FutureDeclawCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FutureDeclawCheckBox.CheckedChanged
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