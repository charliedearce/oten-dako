﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDailiesPayrollNo
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailiesPayrollNo))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.EmployeesDGControl = New DevExpress.XtraGrid.GridControl()
        Me.EmployeesDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.EmpImportDGControl = New DevExpress.XtraGrid.GridControl()
        Me.EmpImportDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDeductions = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtpayno = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.EmployeesDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.EmpImportDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpImportDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.EmployeesDGControl)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 48)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(380, 322)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Employee List"
        '
        'EmployeesDGControl
        '
        Me.EmployeesDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeesDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmployeesDGControl.Location = New System.Drawing.Point(2, 24)
        Me.EmployeesDGControl.MainView = Me.EmployeesDG
        Me.EmployeesDGControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmployeesDGControl.Name = "EmployeesDGControl"
        Me.EmployeesDGControl.Size = New System.Drawing.Size(376, 296)
        Me.EmployeesDGControl.TabIndex = 1
        Me.EmployeesDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.EmployeesDG})
        '
        'EmployeesDG
        '
        Me.EmployeesDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn1, Me.GridColumn2})
        Me.EmployeesDG.GridControl = Me.EmployeesDGControl
        Me.EmployeesDG.Name = "EmployeesDG"
        Me.EmployeesDG.OptionsSelection.MultiSelect = True
        Me.EmployeesDG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.EmployeesDG.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "GridColumn5"
        Me.GridColumn5.FieldName = "emp_id"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Employee"
        Me.GridColumn2.FieldName = "emp"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.EmpImportDGControl)
        Me.GroupControl2.Location = New System.Drawing.Point(398, 48)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(380, 322)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Employee List for payroll"
        '
        'EmpImportDGControl
        '
        Me.EmpImportDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpImportDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpImportDGControl.Location = New System.Drawing.Point(2, 24)
        Me.EmpImportDGControl.MainView = Me.EmpImportDG
        Me.EmpImportDGControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpImportDGControl.Name = "EmpImportDGControl"
        Me.EmpImportDGControl.Size = New System.Drawing.Size(376, 296)
        Me.EmpImportDGControl.TabIndex = 1
        Me.EmpImportDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.EmpImportDG})
        '
        'EmpImportDG
        '
        Me.EmpImportDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn3, Me.GridColumn4})
        Me.EmpImportDG.GridControl = Me.EmpImportDGControl
        Me.EmpImportDG.Name = "EmpImportDG"
        Me.EmpImportDG.OptionsSelection.MultiSelect = True
        Me.EmpImportDG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.EmpImportDG.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.FieldName = "emp_id"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn1"
        Me.GridColumn3.FieldName = "id"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Employee"
        Me.GridColumn4.FieldName = "emp"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'btnDeductions
        '
        Me.btnDeductions.Image = CType(resources.GetObject("btnDeductions.Image"), System.Drawing.Image)
        Me.btnDeductions.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDeductions.Location = New System.Drawing.Point(170, 377)
        Me.btnDeductions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDeductions.Name = "btnDeductions"
        Me.btnDeductions.Size = New System.Drawing.Size(45, 26)
        Me.btnDeductions.TabIndex = 36
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(570, 377)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(45, 26)
        Me.SimpleButton1.TabIndex = 37
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 24)
        Me.LabelControl1.TabIndex = 38
        Me.LabelControl1.Text = "Payroll No:"
        '
        'txtpayno
        '
        Me.txtpayno.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayno.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.txtpayno.Location = New System.Drawing.Point(124, 15)
        Me.txtpayno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpayno.Name = "txtpayno"
        Me.txtpayno.Size = New System.Drawing.Size(260, 24)
        Me.txtpayno.TabIndex = 39
        Me.txtpayno.Text = "12322222222222222222"
        '
        'frmDailiesPayrollNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 412)
        Me.Controls.Add(Me.txtpayno)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnDeductions)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDailiesPayrollNo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDailiesPayrollNo"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.EmployeesDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.EmpImportDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpImportDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents EmployeesDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents EmployeesDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents EmpImportDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents EmpImportDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDeductions As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtpayno As DevExpress.XtraEditors.LabelControl
End Class
