<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listDeductionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listDeductionFrm))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblemp = New DevExpress.XtraEditors.LabelControl()
        Me.lblDesc = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.deductionListDGControl = New DevExpress.XtraGrid.GridControl()
        Me.deductionListDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDeductions = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtId = New System.Windows.Forms.TextBox()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.deductionListDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deductionListDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Employee:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 65)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(128, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Deduction Description:"
        '
        'lblemp
        '
        Me.lblemp.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemp.Location = New System.Drawing.Point(14, 38)
        Me.lblemp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblemp.Name = "lblemp"
        Me.lblemp.Size = New System.Drawing.Size(85, 19)
        Me.lblemp.TabIndex = 2
        Me.lblemp.Text = "Employee:"
        '
        'lblDesc
        '
        Me.lblDesc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(14, 89)
        Me.lblDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(85, 19)
        Me.lblDesc.TabIndex = 3
        Me.lblDesc.Text = "Employee:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.deductionListDGControl)
        Me.GroupControl2.Controls.Add(Me.btnDeductions)
        Me.GroupControl2.Controls.Add(Me.SimpleButton5)
        Me.GroupControl2.Location = New System.Drawing.Point(14, 114)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(514, 225)
        Me.GroupControl2.TabIndex = 34
        Me.GroupControl2.Text = "Deduction Detail List"
        '
        'deductionListDGControl
        '
        Me.deductionListDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deductionListDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.deductionListDGControl.Location = New System.Drawing.Point(2, 24)
        Me.deductionListDGControl.MainView = Me.deductionListDG
        Me.deductionListDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.deductionListDGControl.Name = "deductionListDGControl"
        Me.deductionListDGControl.Size = New System.Drawing.Size(510, 199)
        Me.deductionListDGControl.TabIndex = 38
        Me.deductionListDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.deductionListDG})
        '
        'deductionListDG
        '
        Me.deductionListDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn17, Me.GridColumn1})
        Me.deductionListDG.GridControl = Me.deductionListDGControl
        Me.deductionListDG.Name = "deductionListDG"
        Me.deductionListDG.OptionsBehavior.Editable = False
        Me.deductionListDG.OptionsView.EnableAppearanceEvenRow = True
        Me.deductionListDG.OptionsView.ShowFooter = True
        Me.deductionListDG.OptionsView.ShowGroupPanel = False
        Me.deductionListDG.PaintStyleName = "Skin"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Payroll No."
        Me.GridColumn17.FieldName = "payroll_no"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Amount Deduc."
        Me.GridColumn1.FieldName = "amount"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amount", "Php {0:0,0.00}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'btnDeductions
        '
        Me.btnDeductions.Image = CType(resources.GetObject("btnDeductions.Image"), System.Drawing.Image)
        Me.btnDeductions.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDeductions.Location = New System.Drawing.Point(19, 462)
        Me.btnDeductions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDeductions.Name = "btnDeductions"
        Me.btnDeductions.Size = New System.Drawing.Size(45, 26)
        Me.btnDeductions.TabIndex = 35
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton5.Location = New System.Drawing.Point(363, 462)
        Me.SimpleButton5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(45, 26)
        Me.SimpleButton5.TabIndex = 34
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(272, 32)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(116, 23)
        Me.txtId.TabIndex = 35
        Me.txtId.Visible = False
        '
        'listDeductionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 353)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblemp)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "listDeductionFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Deduction List"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.deductionListDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deductionListDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblemp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents deductionListDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents deductionListDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDeductions As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtId As TextBox
End Class
