<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deductionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deductionFrm))
        Me.btndelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.DeducDGControl = New DevExpress.XtraGrid.GridControl()
        Me.DeducDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLoanAmt = New DevExpress.XtraEditors.TextEdit()
        Me.dpEnable = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dpEmployee = New System.Windows.Forms.ComboBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdescription = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtamount = New DevExpress.XtraEditors.TextEdit()
        Me.dpType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtpercent = New DevExpress.XtraEditors.TextEdit()
        Me.dpDate = New DevExpress.XtraEditors.DateEdit()
        Me.btnedit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.DeducDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeducDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtLoanAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpEnable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(242, 413)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(109, 21)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "Delete"
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(12, 413)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(109, 21)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "New"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.DeducDGControl)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 143)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(581, 265)
        Me.GroupControl2.TabIndex = 64
        Me.GroupControl2.Text = "Deduction List"
        '
        'DeducDGControl
        '
        Me.DeducDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeducDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeducDGControl.Location = New System.Drawing.Point(2, 20)
        Me.DeducDGControl.MainView = Me.DeducDG
        Me.DeducDGControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeducDGControl.Name = "DeducDGControl"
        Me.DeducDGControl.Size = New System.Drawing.Size(577, 243)
        Me.DeducDGControl.TabIndex = 11
        Me.DeducDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DeducDG})
        '
        'DeducDG
        '
        Me.DeducDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn6, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn7, Me.GridColumn8})
        Me.DeducDG.GridControl = Me.DeducDGControl
        Me.DeducDG.Name = "DeducDG"
        Me.DeducDG.OptionsBehavior.Editable = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Employee"
        Me.GridColumn2.FieldName = "employee"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 118
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Description"
        Me.GridColumn6.FieldName = "description"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 167
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Date"
        Me.GridColumn3.DisplayFormat.FormatString = "d"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "date"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 60
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Loan Amount"
        Me.GridColumn4.DisplayFormat.FormatString = "g"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "amount"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 59
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Deduc. Method"
        Me.GridColumn5.FieldName = "deduct_type"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 61
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Deduc. Amt/Perc."
        Me.GridColumn7.FieldName = "amount_type"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 49
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Auto Deduc."
        Me.GridColumn8.FieldName = "auto"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 45
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtLoanAmt)
        Me.GroupControl1.Controls.Add(Me.dpEnable)
        Me.GroupControl1.Controls.Add(Me.dpEmployee)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtdescription)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtamount)
        Me.GroupControl1.Controls.Add(Me.dpType)
        Me.GroupControl1.Controls.Add(Me.txtpercent)
        Me.GroupControl1.Controls.Add(Me.dpDate)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 11)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(581, 128)
        Me.GroupControl1.TabIndex = 63
        Me.GroupControl1.Text = "Deduction Infos"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(323, 78)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl5.TabIndex = 64
        Me.LabelControl5.Text = "Loan Amount:"
        '
        'txtLoanAmt
        '
        Me.txtLoanAmt.EditValue = ""
        Me.txtLoanAmt.Enabled = False
        Me.txtLoanAmt.Location = New System.Drawing.Point(420, 75)
        Me.txtLoanAmt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLoanAmt.Name = "txtLoanAmt"
        Me.txtLoanAmt.Properties.Mask.EditMask = "n2"
        Me.txtLoanAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLoanAmt.Size = New System.Drawing.Size(82, 20)
        Me.txtLoanAmt.TabIndex = 5
        '
        'dpEnable
        '
        Me.dpEnable.EditValue = "Y"
        Me.dpEnable.Enabled = False
        Me.dpEnable.Location = New System.Drawing.Point(420, 51)
        Me.dpEnable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpEnable.Name = "dpEnable"
        Me.dpEnable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpEnable.Properties.Items.AddRange(New Object() {"Y", "N"})
        Me.dpEnable.Size = New System.Drawing.Size(40, 20)
        Me.dpEnable.TabIndex = 4
        '
        'dpEmployee
        '
        Me.dpEmployee.Enabled = False
        Me.dpEmployee.FormattingEnabled = True
        Me.dpEmployee.Location = New System.Drawing.Point(75, 24)
        Me.dpEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpEmployee.Name = "dpEmployee"
        Me.dpEmployee.Size = New System.Drawing.Size(232, 21)
        Me.dpEmployee.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(323, 52)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl6.TabIndex = 56
        Me.LabelControl6.Text = "Auto Deduction:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 54)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Description:"
        '
        'txtdescription
        '
        Me.txtdescription.Enabled = False
        Me.txtdescription.Location = New System.Drawing.Point(75, 52)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Properties.LinesCount = 2
        Me.txtdescription.Size = New System.Drawing.Size(231, 53)
        Me.txtdescription.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(323, 101)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl3.TabIndex = 49
        Me.LabelControl3.Text = "Deduction Method:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(323, 27)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 48
        Me.LabelControl2.Text = "Date:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 27)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 47
        Me.LabelControl1.Text = "Employee:"
        '
        'txtamount
        '
        Me.txtamount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtamount.Location = New System.Drawing.Point(508, 98)
        Me.txtamount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Properties.Mask.EditMask = "n2"
        Me.txtamount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtamount.Size = New System.Drawing.Size(63, 20)
        Me.txtamount.TabIndex = 7
        '
        'dpType
        '
        Me.dpType.EditValue = "FIX"
        Me.dpType.Enabled = False
        Me.dpType.Location = New System.Drawing.Point(420, 98)
        Me.dpType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpType.Name = "dpType"
        Me.dpType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpType.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpType.Properties.DropDownRows = 2
        Me.dpType.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpType.Properties.Items.AddRange(New Object() {"FIX", "PERCENT"})
        Me.dpType.Size = New System.Drawing.Size(82, 20)
        Me.dpType.TabIndex = 6
        '
        'txtpercent
        '
        Me.txtpercent.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpercent.Location = New System.Drawing.Point(508, 98)
        Me.txtpercent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpercent.Name = "txtpercent"
        Me.txtpercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtpercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtpercent.Properties.Mask.EditMask = "p"
        Me.txtpercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtpercent.Size = New System.Drawing.Size(63, 20)
        Me.txtpercent.TabIndex = 63
        '
        'dpDate
        '
        Me.dpDate.EditValue = New Date(2018, 7, 2, 0, 0, 0, 0)
        Me.dpDate.Enabled = False
        Me.dpDate.Location = New System.Drawing.Point(420, 25)
        Me.dpDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpDate.Name = "dpDate"
        Me.dpDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpDate.Properties.DisplayFormat.FormatString = ""
        Me.dpDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpDate.Properties.EditFormat.FormatString = ""
        Me.dpDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpDate.Size = New System.Drawing.Size(82, 20)
        Me.dpDate.TabIndex = 3
        '
        'btnedit
        '
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnedit.Location = New System.Drawing.Point(127, 413)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(109, 21)
        Me.btnedit.TabIndex = 9
        Me.btnedit.Text = "Edit"
        '
        'deductionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 440)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "deductionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deduction Form"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.DeducDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeducDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtLoanAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpEnable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btndelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DeducDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents DeducDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dpEnable As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dpEmployee As ComboBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtamount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dpType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtpercent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnedit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dpDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLoanAmt As DevExpress.XtraEditors.TextEdit
End Class
