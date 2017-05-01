Imports System.Math
Public Class MenuForm

    Private Sub AnimalMasterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AnimalMasterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AllDataDataSet)
    End Sub
    Private Sub ButtonVisibile(visible As Boolean)
        Button1.Visible = visible
        Button2.Visible = visible
        btnInventory.Visible = visible
        lblReports.Visible = visible
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AnimalMasterDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.AnimalMasterTableAdapter.Fill(Me.AllDataDataSet.animalMaster)
    End Sub

    Private Sub McDateDateTimePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        BasicInfoForm.Show()
        BasicInfoForm.AgeTextBox.Text = ""
        BasicInfoForm.CageNumTextBox.Text = ""
        BasicInfoForm.ChipNumTextBox.Text = ""
        BasicInfoForm.NameTextBox.Text = ""
        BasicInfoForm.OwnerTextBox.Text = ""
        BasicInfoForm.RelinPrtyTextBox.Text = ""
    End Sub

    Private Sub Validate()
        Throw New System.NotImplementedException
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        InventoryReportViewerForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formEdit.Show()
    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim testdate As Date = "4/20/2015"
        Dim timespan As TimeSpan = Today.Date - testdate
        MsgBox(timespan.ToString)
    End Sub
End Class
