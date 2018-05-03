<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class computationFrm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(computationFrm))
        Me.earningsDGControl = New DevExpress.XtraGrid.GridControl()
        Me.earningsDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deductionsDG = New DevExpress.XtraGrid.GridControl()
        Me.deductionsDGControl = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.EmployeesDGControl = New DevExpress.XtraGrid.GridControl()
        Me.EmployeesDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.earningsDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.earningsDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deductionsDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deductionsDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'earningsDGControl
        '
        Me.earningsDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.earningsDGControl.Location = New System.Drawing.Point(376, 36)
        Me.earningsDGControl.MainView = Me.earningsDG
        Me.earningsDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.earningsDGControl.Name = "earningsDGControl"
        Me.earningsDGControl.Size = New System.Drawing.Size(359, 217)
        Me.earningsDGControl.TabIndex = 9
        Me.earningsDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.earningsDG})
        '
        'earningsDG
        '
        Me.earningsDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.Amount, Me.GridColumn3})
        Me.earningsDG.GridControl = Me.earningsDGControl
        Me.earningsDG.GroupCount = 1
        Me.earningsDG.Name = "earningsDG"
        Me.earningsDG.OptionsBehavior.Editable = False
        Me.earningsDG.OptionsView.EnableAppearanceEvenRow = True
        Me.earningsDG.OptionsView.ShowGroupPanel = False
        Me.earningsDG.PaintStyleName = "Skin"
        Me.earningsDG.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'Amount
        '
        Me.Amount.Caption = "Amount"
        Me.Amount.DisplayFormat.FormatString = "N2"
        Me.Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Amount.FieldName = "amount"
        Me.Amount.MaxWidth = 80
        Me.Amount.MinWidth = 80
        Me.Amount.Name = "Amount"
        Me.Amount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", "SUM={0:N2}")})
        Me.Amount.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.Amount.Visible = True
        Me.Amount.VisibleIndex = 1
        Me.Amount.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Description"
        Me.GridColumn2.FieldName = "description"
        Me.GridColumn2.MaxWidth = 400
        Me.GridColumn2.MinWidth = 100
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 100
        '
        'deductionsDG
        '
        Me.deductionsDG.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.deductionsDG.Location = New System.Drawing.Point(376, 283)
        Me.deductionsDG.MainView = Me.deductionsDGControl
        Me.deductionsDG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.deductionsDG.Name = "deductionsDG"
        Me.deductionsDG.Size = New System.Drawing.Size(359, 217)
        Me.deductionsDG.TabIndex = 10
        Me.deductionsDG.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.deductionsDGControl})
        '
        'deductionsDGControl
        '
        Me.deductionsDGControl.GridControl = Me.deductionsDG
        Me.deductionsDGControl.Name = "deductionsDGControl"
        Me.deductionsDGControl.OptionsBehavior.Editable = False
        Me.deductionsDGControl.OptionsView.EnableAppearanceEvenRow = True
        Me.deductionsDGControl.OptionsView.ShowGroupPanel = False
        Me.deductionsDGControl.PaintStyleName = "Skin"
        '
        'hideContainerLeft
        '
        Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.hideContainerLeft.Location = New System.Drawing.Point(0, 0)
        Me.hideContainerLeft.Name = "hideContainerLeft"
        Me.hideContainerLeft.Size = New System.Drawing.Size(22, 875)
        '
        'EmployeesDGControl
        '
        Me.EmployeesDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeesDGControl.Location = New System.Drawing.Point(12, 13)
        Me.EmployeesDGControl.MainView = Me.EmployeesDG
        Me.EmployeesDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeesDGControl.Name = "EmployeesDGControl"
        Me.EmployeesDGControl.Size = New System.Drawing.Size(358, 849)
        Me.EmployeesDGControl.TabIndex = 14
        Me.EmployeesDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.EmployeesDG})
        '
        'EmployeesDG
        '
        Me.EmployeesDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn5})
        Me.EmployeesDG.GridControl = Me.EmployeesDGControl
        Me.EmployeesDG.GroupCount = 1
        Me.EmployeesDG.Name = "EmployeesDG"
        Me.EmployeesDG.OptionsBehavior.Editable = False
        Me.EmployeesDG.OptionsView.EnableAppearanceEvenRow = True
        Me.EmployeesDG.OptionsView.ShowGroupPanel = False
        Me.EmployeesDG.PaintStyleName = "Skin"
        Me.EmployeesDG.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "employee"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Working Hrs"
        Me.GridColumn4.FieldName = "hours"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Working Date"
        Me.GridColumn5.FieldName = "date"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton3.Location = New System.Drawing.Point(783, 810)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(127, 26)
        Me.SimpleButton3.TabIndex = 29
        Me.SimpleButton3.Text = "Process Payroll"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(376, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "Earnings"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(376, 260)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl2.TabIndex = 31
        Me.LabelControl2.Text = "Deductions"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Date"
        Me.GridColumn3.FieldName = "date"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'computationFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1759, 875)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.EmployeesDGControl)
        Me.Controls.Add(Me.deductionsDG)
        Me.Controls.Add(Me.earningsDGControl)
        Me.Name = "computationFrm"
        Me.Text = "computationFrm"
        CType(Me.earningsDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.earningsDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deductionsDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deductionsDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents earningsDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents earningsDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents deductionsDG As DevExpress.XtraGrid.GridControl
    Friend WithEvents deductionsDGControl As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents EmployeesDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents EmployeesDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
End Class
