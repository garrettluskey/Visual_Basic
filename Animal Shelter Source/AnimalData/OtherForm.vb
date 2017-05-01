Public Class OtherAnimalForm
    Public CombVarWeight



    Private Sub OtherAnimalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtWeight.Text = ""
        RTxtVaccinations.Text = ""
        RTxtGeneral.Text = ""
        RTxtWeight.Text = ""
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            If RdioKg.Checked = True Then
                CombVarWeight = TxtWeight.Text + " Kg"
            ElseIf RdioLbs.Checked = True Then
                CombVarWeight = TxtWeight.Text + " Lbs"
            Else
                Throw New Exception("Forced Exeption")
            End If

            OtherInfoTableAdapter.Insert(TxtWeight.Text, RTxtWeight.Text, RTxtGeneral.Text, RTxtVaccinations.Text, OtherInfoTableAdapter.MaxIndex + 1, BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax, TextBox1.Text)
            Me.Close()
        Catch ex As Exception
            MsgBox("Some areas are missing information.", MsgBoxStyle.OkOnly, Title:="Error")
        End Try
    End Sub
    Private Sub CancleBtn_Click(sender As Object, e As EventArgs) Handles CancleBtn.Click
        BasicInfoForm.AnimalMasterTableAdapter.DeleteQuery(BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax)
        Me.Close()
        BasicInfoForm.Close()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        BasicInfoForm.Show()
        BasicInfoForm.AnimalMasterBindingSource.MoveLast()
        BasicInfoForm.AnimalMasterTableAdapter.DeleteQuery(BasicInfoForm.AnimalMasterTableAdapter.GetCaseNumMax)
        Me.Hide()
    End Sub

    Private Sub txt_Weight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtWeight.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

End Class

