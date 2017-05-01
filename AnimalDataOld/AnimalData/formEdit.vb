Public Class formEdit
    Public SelectedColumn As Int32 = 0
    Public Doa As Date
    Public Dob As Date
    Public caseNum As Integer
    Public StrReport As String = Nothing

    Private Sub AnimalMasterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AnimalMasterBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.AnimalMasterBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AllDataDataSet)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Title:="Error")
        End Try
    End Sub

    Private Sub formEdit_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        Me.ClientTableTableAdapter.Fill(Me.AllDataDataSet.ClientTable)
        Me.OtherInfoTableAdapter.Fill(Me.AllDataDataSet.OtherInfo)
        Me.DogInfoTableAdapter.Fill(Me.AllDataDataSet.dogInfo)
        Me.CatInfoTableAdapter.Fill(Me.AllDataDataSet.CatInfo)
        Me.AnimalMasterTableAdapter.Fill(Me.AllDataDataSet.animalMaster)
    End Sub

    Private Sub formEdit_Leave(sender As Object, e As EventArgs) Handles Me.FormClosing

        Try
            Me.Validate()
            Me.AnimalMasterBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AllDataDataSet)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Title:="Error")
        End Try
    End Sub

    Private Sub formEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllDataDataSet.CostReport' table. You can move, or remove it, as needed.
        Try
            Me.CostReportTableAdapter.Fill(Me.AllDataDataSet.CostReport)

            'TODO: This line of code loads data into the 'AllDataDataSet.OtherClientReport' table. You can move, or remove it, as needed.
            Me.OtherClientReportTableAdapter.Fill(Me.AllDataDataSet.OtherClientReport)
            'TODO: This line of code loads data into the 'AllDataDataSet.dogInfo' table. You can move, or remove it, as needed.
            Me.DogInfoTableAdapter.Fill(Me.AllDataDataSet.dogInfo)
        Catch ex As Exception
            MsgBox("An Error Has Occured! While attempting to open Edit Form " + ex.Message + " prevented it from opening")
        End Try
        CatVisibile(False)
        DogVisible(False)
        OtherVisible(False)
        MiscVisible(False)

        Me.WindowState = FormWindowState.Maximized
        RefreshForm()
        'These lines of code populates data into the datagridviewtables.
        Me.ClientTableTableAdapter.Fill(Me.AllDataDataSet.ClientTable)
        Me.OtherInfoTableAdapter.Fill(Me.AllDataDataSet.OtherInfo)
        Me.DogInfoTableAdapter.Fill(Me.AllDataDataSet.dogInfo)
        Me.CatInfoTableAdapter.Fill(Me.AllDataDataSet.CatInfo)
        Me.AnimalMasterTableAdapter.Fill(Me.AllDataDataSet.animalMaster)

        For number As Int32 = 0 To Me.AnimalMasterTableAdapter.GetCaseNumMax - 1 Step 1
            If AnimalMasterDataGridView.Rows(number).Cells(5).Value = 0 Then
                AnimalMasterDataGridView.Rows(number).Cells(4).Value = "Dog"
            ElseIf AnimalMasterDataGridView.Rows(number).Cells(5).Value = 1 Then
                AnimalMasterDataGridView.Rows(number).Cells(4).Value = "Cat"
            ElseIf AnimalMasterDataGridView.Rows(number).Cells(5).Value = 2 Then
                AnimalMasterDataGridView.Rows(number).Cells(4).Value = "Other"
            End If
        Next
        cboxType.SelectedIndex = cboxType.Tag




    End Sub
    Private Sub CatVisibile(visible As Boolean)
        CatInfoDataGridView.Visible = visible

        chkDeclawedCat.Visible = visible
        chkFleaTestCat.Visible = visible
        chkFutureDeclawCat.Visible = visible
        chkFutureDeclawInfoCat.Visible = visible
        chkGenderCat.Visible = visible
        chkHairtypeCat.Visible = visible
        chkLeukemiaCat.Visible = visible
        chkNeuteredCat.Visible = visible
        chkRabiesCat.Visible = visible

        datePickerFleaTestCat.Visible = visible
        datePickerLeukemiaCat.Visible = visible
        datePickerNeuteredCat.Visible = visible

        txtBreedCat.Visible = visible
        txtHairColorCat.Visible = visible
        txtWeightCat.Visible = visible

        lbl1Cat.Visible = visible
        lbl2Cat.Visible = visible
        lbl3Cat.Visible = visible
        lbl4Cat.Visible = visible
        lbl5Cat.Visible = visible
        lbl6Cat.Visible = visible
    End Sub
    Private Sub DogVisible(visible As Boolean)
        DogInfoDataGridView.Visible = visible

        chkBordetellaDog.Visible = visible
        chkDistemperDog.Visible = visible
        chkFleatestDog.Visible = visible
        chkGenderDog.Visible = visible
        chkHairTypeDog.Visible = visible
        chkHeartwormtestDog.Visible = visible
        chkNeuteredDog.Visible = visible
        chkRabiesDog.Visible = visible

        datePickerBordetellaDog.Visible = visible
        datePickerDistemperDog.Visible = visible
        datePickerLastTestDog.Visible = visible
        datePickerMedStartDog.Visible = visible
        datePickerProcedureDog.Visible = visible
        datePickerRabiesDog.Visible = visible
        datePickerRetestDog.Visible = visible
        datePickerStartMedDog.Visible = visible

        txtBreedDog.Visible = visible
        txtHairColorDog.Visible = visible
        txtWeightDog.Visible = visible

        lbl1Dog.Visible = visible
        lbl2Dog.Visible = visible
        lbl3Dog.Visible = visible
        lbl4Dog.Visible = visible
        lbl5Dog.Visible = visible
        lbl6Dog.Visible = visible
        lbl7Dog.Visible = visible
        lbl8Dog.Visible = visible
        lbl9Dog.Visible = visible
        lbl10Dog.Visible = visible
    End Sub
    Public Sub OtherVisible(visible As Boolean)
        lbl1Other.Visible = visible
        lbl2VaccinationsOther.Visible = visible
        lbl3GeneralDescriptionOther.Visible = visible
        lblWeightOther.Visible = visible

        rtxtAppearance.Visible = visible
        rtxtGeneralDescription.Visible = visible
        rtxtVaccinations.Visible = visible

        txtWeightOther.Visible = visible
        txtWeightOther.Visible = visible

        OtherInfoDataGridView.Visible = visible
    End Sub
    Public Sub MiscVisible(visible As Boolean)
        lblBreed.Visible = visible
        lblWeightDogCat.Visible = visible
        lblHairColor.Visible = visible
        lblHairType.Visible = visible
        lblGender.Visible = visible
        lblNeutered.Visible = visible
        lblProcedureDate.Visible = visible
        lblFleaTest.Visible = visible
        lblStartMed.Visible = visible
    End Sub


    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboxType.KeyPress
        e.Handled = True
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxType.SelectedIndexChanged

        cboxType.Tag = cboxType.SelectedIndex
        SelectedColumn = AnimalMasterDataGridView.CurrentCell.RowIndex()

        Try
            If cboxType.SelectedIndex = 0 Then
                AnimalMasterDataGridView.Rows(SelectedColumn).Cells(4).Value = "Dog"
            ElseIf cboxType.SelectedIndex = 1 Then
                AnimalMasterDataGridView.Rows(SelectedColumn).Cells(4).Value = "Cat"
            ElseIf cboxType.SelectedIndex = 2 Then
                AnimalMasterDataGridView.Rows(SelectedColumn).Cells(4).Value = "Other"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub RunGridViewUpdate(index As Integer)
        If AnimalMasterDataGridView.Rows(index).Cells(5).Value = 0 Then
            AnimalMasterDataGridView.Rows(index).Cells(4).Value = "Dog"
        ElseIf AnimalMasterDataGridView.Rows(index).Cells(5).Value = 1 Then
            AnimalMasterDataGridView.Rows(index).Cells(4).Value = "Cat"
        ElseIf AnimalMasterDataGridView.Rows(index).Cells(5).Value = 2 Then
            AnimalMasterDataGridView.Rows(index).Cells(4).Value = "Other"
        End If
    End Sub
    Public Sub AnimalMasterDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles AnimalMasterDataGridView.CellClick
        Try
            cboxType.SelectedIndex = cboxType.Tag

            SelectedColumn = e.ColumnIndex
            RunGridViewUpdate(e.RowIndex)
            
            Dim ColumnIndex As Int32 = e.ColumnIndex
        Catch ex As Exception
        End Try
        If e.ColumnIndex <> 1 Then

            Exit Sub
        End If
    End Sub



    Private Sub AnimalMasterDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AnimalMasterDataGridView.CellContentClick
        SelectedColumn = e.RowIndex
        caseNum = AnimalMasterDataGridView.Rows(e.RowIndex).Cells(2).Value
        If e.ColumnIndex <> 1 And e.ColumnIndex <> 0 Then
            Exit Sub
        End If
        Try
            If AnimalMasterDataGridView.Rows(e.RowIndex).Cells(5).Value = 0 Then
                DogVisible(True)
                CatVisibile(False)
                OtherVisible(False)
                MiscVisible(True)
            ElseIf AnimalMasterDataGridView.Rows(e.RowIndex).Cells(5).Value = 1 Then
                DogVisible(False)
                CatVisibile(True)
                OtherVisible(False)
                MiscVisible(True)
            ElseIf AnimalMasterDataGridView.Rows(e.RowIndex).Cells(5).Value = 2 Then
                DogVisible(False)
                CatVisibile(False)
                OtherVisible(True)
                MiscVisible(False)
            Else
                DogVisible(False)
                CatVisibile(False)
                OtherVisible(False)
                MiscVisible(False)
            End If
        Catch ex As Exception
        End Try
        If e.ColumnIndex = 1 Then


            CostReportTableAdapter.DeleteQuery()

            ClientTableTableAdapter.UpdateClientReport(AnimalMasterDataGridView.Rows(e.RowIndex).Cells(3).Value, "Animal Name")
            ClientTableTableAdapter.UpdateClientReport(AnimalMasterDataGridView.Rows(e.RowIndex).Cells(6).Value, "Animal Age")
            If AnimalMasterDataGridView.Rows(e.RowIndex).Cells(9).Value = True Then
                ClientTableTableAdapter.UpdateClientReport("Yes", "Micro-chipped")
            Else

                ClientTableTableAdapter.UpdateClientReport("No", "Micro-chipped")
                CostReportTableAdapter.InsertCost("Micro-chipped", "5.00")

            End If

            Dim ArrivalDate As Date = AnimalMasterDataGridView.Rows(e.RowIndex).Cells(8).Value
            Dim TimeSpan As TimeSpan = (Date.Today - ArrivalDate)
            Dim StrTimeSpan As Double = TimeSpan.TotalDays * 10
            CostReportTableAdapter.InsertCost("Daily Cost", StrTimeSpan.ToString + ".00")

            If DogInfoDataGridView.Visible = True Then
                ClientTableTableAdapter.UpdateClientReport(txtBreedDog.Text, "Breed")
                ClientTableTableAdapter.UpdateClientReport(txtWeightDog.Text, "Weight")
                ClientTableTableAdapter.UpdateClientReport(txtHairColorDog.Text, "Hair Color")
                If chkFleatestDog.Checked = False Then
                    CostReportTableAdapter.InsertCost("Flea Treatment", "10.00")
                    CostReportTableAdapter.InsertCost("Monthly Flea Prevention", (Today.Month - ArrivalDate.Month) * 3)
                End If
                If chkHeartwormtestDog.Checked = True Then
                    CostReportTableAdapter.InsertCost("Heartworm Test", "10.00")
                End If
                If chkHairTypeDog.Checked = True Then
                    ClientTableTableAdapter.UpdateClientReport("Long", "Hair Type")
                Else
                    ClientTableTableAdapter.UpdateClientReport("Short", "Hair Type")
                End If

                If chkNeuteredDog.Checked = True Then
                    ClientTableTableAdapter.UpdateClientReport("Yes", "Spayed/Neutered")
                Else
                    CostReportTableAdapter.InsertCost("Spayed/Neutered", "75.00")
                    ClientTableTableAdapter.UpdateClientReport("No", "Spayed/Neutered")
                End If

                If chkRabiesDog.Checked = True Then
                    ClientTableTableAdapter.Insert("Rabies Vaccination", "Yes")
                Else
                    ClientTableTableAdapter.Insert("Rabies Vaccination", "No")
                    CostReportTableAdapter.InsertCost("Rabies Test", "30.00")
                    CostReportTableAdapter.InsertCost("Rabies Vaccination", "15.00")
                End If

                If chkDistemperDog.Checked = True Then
                    ClientTableTableAdapter.Insert("Distemper Vaccination", "Yes")
                Else
                    ClientTableTableAdapter.Insert("Distemper Vaccination", "No")
                    CostReportTableAdapter.InsertCost("Distemper Vaccination", "15.00")
                End If
                If chkBordetellaDog.Checked = True Then
                    ClientTableTableAdapter.Insert("Bordetella Vaccination", "Yes")
                Else
                    ClientTableTableAdapter.Insert("Bordetella Vaccination", "No")
                    CostReportTableAdapter.InsertCost("Bordetella Vaccination", "15.00")
                End If
                StrReport = "CatDogReport"
            ElseIf CatInfoDataGridView.Visible = True Then
                ClientTableTableAdapter.UpdateClientReport(txtBreedCat.Text, "Breed")
                ClientTableTableAdapter.UpdateClientReport(txtWeightCat.Text, "Weight")
                ClientTableTableAdapter.UpdateClientReport(txtHairColorCat.Text, "Hair Color")
                If chkFleaTestCat.Checked = False Then

                    CostReportTableAdapter.InsertCost("Flea Treatment", "10.00")
                    CostReportTableAdapter.InsertCost("Monthly Flea Prevention", (Today.Month - ArrivalDate.Month) * 3)
                End If
                If chkLeukemiaCat.Checked = True Then

                    CostReportTableAdapter.InsertCost("Feline Leukemia", "15.00")
                End If
                If chkHairtypeCat.Checked = True Then
                    ClientTableTableAdapter.UpdateClientReport("Long", "Hair Type")
                Else

                    ClientTableTableAdapter.UpdateClientReport("Short", "Hair Type")
                End If
                If chkGenderCat.Checked = True Then
                    ClientTableTableAdapter.UpdateClientReport("Male", "Gender")
                Else
                    ClientTableTableAdapter.UpdateClientReport("Female", "Gender")
                End If

                If chkNeuteredCat.Checked = True Then
                    ClientTableTableAdapter.UpdateClientReport("Yes", "Spayed/Neutered")
                Else
                    ClientTableTableAdapter.UpdateClientReport("No", "Spayed/Neutered")
                    CostReportTableAdapter.InsertCost("Spayed/Neutered", "75.00")

                End If

                If chkRabiesCat.Checked = True Then
                    ClientTableTableAdapter.Insert("Yes", "Rabies Test")
                Else
                    ClientTableTableAdapter.Insert("No", "Rabies Test")
                    CostReportTableAdapter.InsertCost("Rabies Test", "30.00")
                    CostReportTableAdapter.InsertCost("Rabies Vaccination", "15.00")
                End If
                StrReport = "CatDogReport"
            ElseIf OtherInfoDataGridView.Visible = True Then
                OtherClientReportTableAdapter.UpdateQuery(txtWeightOther.Text, "Weight")
                OtherClientReportTableAdapter.UpdateQuery(rtxtAppearance.Text, "Appearance")
                OtherClientReportTableAdapter.UpdateQuery(rtxtGeneralDescription.Text, "General Description")
                OtherClientReportTableAdapter.UpdateQuery(rtxtVaccinations.Text, "Vaccinations")
                StrReport = "OtherClientReport"
                IndividualReportSelectForm.Show()
            End If


            IndividualReportSelectForm.Show()
        End If
    End Sub

    Private Sub DogInfoDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)
        DogInfoTableAdapter.IndexFromId(e.RowIndex + 1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


       

        If caseNumSearch.Text <> "" Then
            Try
                Me.AnimalMasterTableAdapter.FillByCaseNum(Me.AllDataDataSet.animalMaster, CType(caseNumSearch.Text, Integer))
            Catch ex As System.Exception
                Me.AnimalMasterTableAdapter.Fill(Me.AllDataDataSet.animalMaster)
            End Try
        End If
        
        
        RunGridViewUpdate(SelectedColumn)
    End Sub
    Private Sub RefreshForm()

        caseNumSearch.Text = ""
        
        Me.AnimalMasterTableAdapter.Fill(Me.AllDataDataSet.animalMaster)
        For number As Int32 = 0 To Me.AnimalMasterTableAdapter.GetCaseNumMax - 1 Step 1
            If AnimalMasterDataGridView.Rows(number).Cells(5).Value = 0 Then
                AnimalMasterDataGridView.Rows(number).Cells(4).Value = "Dog"
            ElseIf AnimalMasterDataGridView.Rows(number).Cells(5).Value = 1 Then
                AnimalMasterDataGridView.Rows(number).Cells(4).Value = "Cat"
            ElseIf AnimalMasterDataGridView.Rows(number).Cells(5).Value = 2 Then
                AnimalMasterDataGridView.Rows(number).Cells(4).Value = "Other"
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RefreshForm()
    End Sub


    Private Sub NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsWhiteSpace(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub



    Private Sub CaseNumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CaseNumTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub


    Private Sub AgeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgeTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub


    Private Sub ChipNumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChipNumTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub CageNumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CageNumTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

        Try
            CatInfoTableAdapter.DeleteByCaseNum(caseNum)
        Catch ex As Exception
        End Try
        Try
            DogInfoTableAdapter.DeleteQuery(caseNum)
        Catch ex As Exception
        End Try
        Try
            OtherInfoTableAdapter.DeleteQuery(caseNum)
        Catch ex As Exception
        End Try

    End Sub
End Class


