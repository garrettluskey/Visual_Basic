<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.AllDataDataSet = New FurryFriendsAnimalShelter.AllDataDataSet()
        Me.AnimalMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnimalMasterTableAdapter = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.animalMasterTableAdapter()
        Me.TableAdapterManager = New FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AllDataDataSet
        '
        Me.AllDataDataSet.DataSetName = "AllDataDataSet"
        Me.AllDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnimalMasterBindingSource
        '
        Me.AnimalMasterBindingSource.DataMember = "animalMaster"
        Me.AnimalMasterBindingSource.DataSource = Me.AllDataDataSet
        '
        'AnimalMasterTableAdapter
        '
        Me.AnimalMasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.animalMasterTableAdapter = Me.AnimalMasterTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatInfoTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager.CostReportTableAdapter = Nothing
        Me.TableAdapterManager.dogInfoTableAdapter = Nothing
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add New Entry"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 50)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit Existing"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(259, 37)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(128, 28)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.Location = New System.Drawing.Point(255, 16)
        Me.lblReports.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(58, 17)
        Me.lblReports.TabIndex = 4
        Me.lblReports.Text = "Reports"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(259, 71)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Total Expenses"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 111)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(165, 28)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Help"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(399, 151)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblReports)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MenuForm"
        Me.Text = "Animal Log"
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AllDataDataSet As FurryFriendsAnimalShelter.AllDataDataSet
    Friend WithEvents AnimalMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnimalMasterTableAdapter As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.animalMasterTableAdapter
    Friend WithEvents TableAdapterManager As FurryFriendsAnimalShelter.AllDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents lblReports As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
