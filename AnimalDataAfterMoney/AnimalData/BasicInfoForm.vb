Public Class BasicInfoForm
    Public ConVarChipped As Byte = 0
    Public ConVarQuarentine As Byte = 1
    Private Property Message As Object

    Private Property index_1 As Object

    Private Property Check As Boolean

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        McDateDateTimePicker.Enabled = True
        OwnerTextBox.Enabled = False
        DateContactedDateTimePicker.Enabled = False


    End Sub
    Private Sub Form2_Leave(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Try
            Me.AnimalMasterBindingSource.RemoveCurrent()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CageNumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CageNumTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub RelinPrtyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RelinPrtyTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False And Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub OwnerTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles OwnerTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub ChipNumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChipNumTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub AgeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgeTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub TypeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonContinue.Click

        lbl_AgeError.Hide()
        lbl_CageNumError.Hide()
        lbl_ChipNumError.Hide()
        lbl_InfoError.Hide()
        lbl_NameError.Hide()
        lbl_OwnerNameError.Hide()
        lbl_RelinPrtyError.Hide()


        AllDataDataSet.animalMaster.dobColumn.DefaultValue = DobDateTimePicker.Value
        AllDataDataSet.animalMaster.doaColumn.DefaultValue = DoaDateTimePicker.Value

        Try
            If ChippedCheckBox.Checked = True Then
                AnimalMasterTableAdapter.Insert(AnimalMasterTableAdapter.GetCaseNumMax + 1, NameTextBox.Text, ComboBox1.SelectedIndex, AgeTextBox.Text, DobDateTimePicker.Value, DoaDateTimePicker.Value, ChipNumTextBox.Text, OwnerTextBox.Text, Nothing, McDateDateTimePicker.Value, RelinPrtyTextBox.Text, CageNumTextBox.Text, ConVarChipped, ConVarQuarentine)
            Else
                AnimalMasterTableAdapter.Insert(AnimalMasterTableAdapter.GetCaseNumMax + 1, NameTextBox.Text, ComboBox1.SelectedIndex, AgeTextBox.Text, DobDateTimePicker.Value, DoaDateTimePicker.Value, ChipNumTextBox.Text, OwnerTextBox.Text, DateContactedDateTimePicker.Value, Nothing, RelinPrtyTextBox.Text, CageNumTextBox.Text, ConVarChipped, ConVarQuarentine)
            End If
            
            If ComboBox1.SelectedIndex = 0 Then
                Me.Hide()
                DogInfoForm.Show()
            ElseIf ComboBox1.SelectedIndex = 1 Then
                Me.Hide()
                CatInfoForm.Show()
            ElseIf ComboBox1.SelectedIndex = 2 Then
                Me.Hide()
                OtherAnimalForm.Show()
            End If


        Catch ex As Exception
            Me.Height = 420
            If NameTextBox.Text.Equals("") = True Then
                lbl_InfoError.Show()
                lbl_NameError.Show()
            End If
            If AgeTextBox.Text.Equals("") = True Then
                lbl_InfoError.Show()
                lbl_AgeError.Show()
            End If
            If ChipNumTextBox.Text.Equals("") = True Then
                lbl_InfoError.Show()
                lbl_ChipNumError.Show()
            End If
            If OwnerTextBox.Text.Equals("") = True And OwnerTextBox.Enabled = True Then
                lbl_InfoError.Show()
                lbl_OwnerNameError.Show()
            End If
            If RelinPrtyTextBox.Text.Equals("") = True Then
                lbl_InfoError.Show()
                lbl_RelinPrtyError.Show()
            End If
            If CageNumTextBox.Text.Equals("") = True Then
                lbl_InfoError.Show()
                lbl_CageNumError.Show()
            End If

            MsgBox("Some areas are missing information." + ex.Message, MsgBoxStyle.OkOnly, Title:="Error")

        End Try

    End Sub

    Private Sub ButtonCancle_Click(sender As Object, e As EventArgs) Handles ButtonCancle.Click
        Me.Hide()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
    Private Sub ChippedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ChippedCheckBox.CheckedChanged
        If ChippedCheckBox.Checked = True Then
            ConVarChipped = 1
            McDateDateTimePicker.Enabled = False
            AllDataDataSet.animalMaster.mcDateColumn.AllowDBNull = False

            OwnerTextBox.Enabled = True
            AllDataDataSet.animalMaster.ownerColumn.AllowDBNull = True

            DateContactedDateTimePicker.Enabled = True
            AllDataDataSet.animalMaster.dateContactedColumn.AllowDBNull = True

        Else
            ConVarChipped = 0
            McDateDateTimePicker.Enabled = True
            AllDataDataSet.animalMaster.mcDateColumn.AllowDBNull = True

            OwnerTextBox.Enabled = False
            AllDataDataSet.animalMaster.ownerColumn.AllowDBNull = False

            DateContactedDateTimePicker.Enabled = False
            AllDataDataSet.animalMaster.dateContactedColumn.AllowDBNull = False
        End If
    End Sub

End Class

