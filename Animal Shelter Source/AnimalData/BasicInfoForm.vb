Public Class BasicInfoForm
    'conversion variables for booleans to bytes
    Public ConVarChipped As Byte = 0
    Public ConVarQuarentine As Byte = 1
    'generated code, too scared to touch
    Private Property Message As Object

    Private Property index_1 As Object

    Private Property Check As Boolean

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'default enable and disabling for the form
        McDateDateTimePicker.Enabled = True
        OwnerTextBox.Enabled = False
        DateContactedDateTimePicker.Enabled = False


    End Sub
    Private Sub Form2_Leave(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        'attempts to remove the current data row, although probably obsilete now because there are no data bindings
        Try
            Me.AnimalMasterBindingSource.RemoveCurrent()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CageNumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CageNumTextBox.KeyPress
        'only allows numbers and backspace to be used in the cage number text box
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub RelinPrtyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RelinPrtyTextBox.KeyPress
        'only allows letters, backspaces, spaces, and numbers in the relinquising party textbox
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False And Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTextBox.KeyPress
        'only allows letters, spaces, and backspaces in the name text box
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub OwnerTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles OwnerTextBox.KeyPress
        'only allows letters, spaces, and backspaces in the owner text box
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub ChipNumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChipNumTextBox.KeyPress
        'only allows numbers and backspaces in the chip number text box
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub AgeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgeTextBox.KeyPress
        'only allows numbers and backspaces in the age text box
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub TypeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        'only allows letters, backspaces, and spaces in type text box
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonContinue.Click
        'hides all the error messages before checking for errors
        lbl_AgeError.Hide()
        lbl_CageNumError.Hide()
        lbl_ChipNumError.Hide()
        lbl_InfoError.Hide()
        lbl_NameError.Hide()
        lbl_OwnerNameError.Hide()
        lbl_RelinPrtyError.Hide()

        'Inserts a default value to the date columns in the data table
        AllDataDataSet.animalMaster.dobColumn.DefaultValue = DobDateTimePicker.Value
        AllDataDataSet.animalMaster.doaColumn.DefaultValue = DoaDateTimePicker.Value

        'Catches something that goes wrong
        Try
            'Inserts a row of data into the table based on the micro-chipped check box value, each one differes on inserting 'nothing' into a date column
            'Both inserts get the max case number and add one to it.
            If ChippedCheckBox.Checked = True Then
                AnimalMasterTableAdapter.Insert(AnimalMasterTableAdapter.GetCaseNumMax + 1, NameTextBox.Text, ComboBox1.SelectedIndex, AgeTextBox.Text, DobDateTimePicker.Value, DoaDateTimePicker.Value, ChipNumTextBox.Text, OwnerTextBox.Text, Nothing, McDateDateTimePicker.Value, RelinPrtyTextBox.Text, CageNumTextBox.Text, ConVarChipped, ConVarQuarentine)
            Else
                AnimalMasterTableAdapter.Insert(AnimalMasterTableAdapter.GetCaseNumMax + 1, NameTextBox.Text, ComboBox1.SelectedIndex, AgeTextBox.Text, DobDateTimePicker.Value, DoaDateTimePicker.Value, ChipNumTextBox.Text, OwnerTextBox.Text, DateContactedDateTimePicker.Value, Nothing, RelinPrtyTextBox.Text, CageNumTextBox.Text, ConVarChipped, ConVarQuarentine)
            End If

            'based on what type of animal, it shows the correct screen for the type
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

            'catches any exeption
        Catch ex As Exception
            'expands height to show the error message at the bottom of the screen
            Me.Height = 420
            'if any textbox is blank, it shows the corrisponding error
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
            'shows a message to the user that information is missing
            MsgBox("Some areas are missing information.", MsgBoxStyle.OkOnly, Title:="Error")

        End Try

    End Sub

    Private Sub ButtonCancle_Click(sender As Object, e As EventArgs) Handles ButtonCancle.Click
        'closes form when the cancel button is clicked
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        'doesn't allow user to modify the type of animal combo box
        e.Handled = True
    End Sub
    Private Sub ChippedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ChippedCheckBox.CheckedChanged
        'checks if the micro-chipped check box is checked
        If ChippedCheckBox.Checked = True Then
            'converts check to byte by making a variable(see top)
            ConVarChipped = 1
            'changes the enabled state of the date time pickers reliant on the animal being micro-chipped or not
            McDateDateTimePicker.Enabled = False
            'changes the dataset to not allow null values on micro-chipping date causing an error to be thrown on the continue button
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

