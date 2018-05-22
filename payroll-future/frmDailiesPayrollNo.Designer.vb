<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.EmpImportDGControl = New DevExpress.XtraGrid.GridControl()
        Me.EmpImportDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDeductions = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
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
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(380, 358)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Employee List"
        '
        'EmployeesDGControl
        '
        Me.EmployeesDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeesDGControl.Location = New System.Drawing.Point(2, 24)
        Me.EmployeesDGControl.MainView = Me.EmployeesDG
        Me.EmployeesDGControl.Name = "EmployeesDGControl"
        Me.EmployeesDGControl.Size = New System.Drawing.Size(376, 332)
        Me.EmployeesDGControl.TabIndex = 1
        Me.EmployeesDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.EmployeesDG})
        '
        'EmployeesDG
        '
        Me.EmployeesDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.EmployeesDG.GridControl = Me.EmployeesDGControl
        Me.EmployeesDG.Name = "EmployeesDG"
        Me.EmployeesDG.OptionsSelection.MultiSelect = True
        Me.EmployeesDG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.EmployeesDG.OptionsView.ShowGroupPanel = False
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
        Me.GroupControl2.Location = New System.Drawing.Point(398, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(380, 358)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Employee List for payroll"
        '
        'EmpImportDGControl
        '
        Me.EmpImportDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpImportDGControl.Location = New System.Drawing.Point(2, 24)
        Me.EmpImportDGControl.MainView = Me.EmpImportDG
        Me.EmpImportDGControl.Name = "EmpImportDGControl"
        Me.EmpImportDGControl.Size = New System.Drawing.Size(376, 332)
        Me.EmpImportDGControl.TabIndex = 1
        Me.EmpImportDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.EmpImportDG})
        '
        'EmpImportDG
        '
        Me.EmpImportDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.EmpImportDG.GridControl = Me.EmpImportDGControl
        Me.EmpImportDG.Name = "EmpImportDG"
        Me.EmpImportDG.OptionsSelection.MultiSelect = True
        Me.EmpImportDG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.EmpImportDG.OptionsView.ShowGroupPanel = False
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
        Me.btnDeductions.Size = New System.Drawing.Size(46, 26)
        Me.btnDeductions.TabIndex = 36
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(570, 377)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(46, 26)
        Me.SimpleButton1.TabIndex = 37
        '
        'frmDailiesPayrollNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 412)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnDeductions)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmDailiesPayrollNo"
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
End Class
