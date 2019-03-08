<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class leaveFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(leaveFrm))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.dpEmployee = New System.Windows.Forms.ComboBox()
        Me.dpTo = New DevExpress.XtraEditors.DateEdit()
        Me.dpApprove = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dpType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdescription = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dpFrom = New DevExpress.XtraEditors.DateEdit()
        Me.dpDays = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LeaveDGControl = New DevExpress.XtraGrid.GridControl()
        Me.LeaveDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btndelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dpTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpApprove.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.LeaveDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaveDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.dpEmployee)
        Me.GroupControl1.Controls.Add(Me.dpTo)
        Me.GroupControl1.Controls.Add(Me.dpApprove)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.dpType)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtdescription)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.dpFrom)
        Me.GroupControl1.Controls.Add(Me.dpDays)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(597, 167)
        Me.GroupControl1.TabIndex = 46
        Me.GroupControl1.Text = "Leave Infos"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(377, 89)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl7.TabIndex = 60
        Me.LabelControl7.Text = "# of Days:"
        '
        'dpEmployee
        '
        Me.dpEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dpEmployee.Enabled = False
        Me.dpEmployee.FormattingEnabled = True
        Me.dpEmployee.Location = New System.Drawing.Point(87, 30)
        Me.dpEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpEmployee.Name = "dpEmployee"
        Me.dpEmployee.Size = New System.Drawing.Size(270, 24)
        Me.dpEmployee.TabIndex = 1
        '
        'dpTo
        '
        Me.dpTo.EditValue = Nothing
        Me.dpTo.Enabled = False
        Me.dpTo.Location = New System.Drawing.Point(443, 58)
        Me.dpTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpTo.Name = "dpTo"
        Me.dpTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpTo.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.dpTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpTo.Properties.EditFormat.FormatString = ""
        Me.dpTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpTo.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.dpTo.Size = New System.Drawing.Size(135, 22)
        Me.dpTo.TabIndex = 5
        '
        'dpApprove
        '
        Me.dpApprove.EditValue = "Y"
        Me.dpApprove.Enabled = False
        Me.dpApprove.Location = New System.Drawing.Point(443, 112)
        Me.dpApprove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpApprove.Name = "dpApprove"
        Me.dpApprove.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpApprove.Properties.Items.AddRange(New Object() {"Y", "N"})
        Me.dpApprove.Size = New System.Drawing.Size(47, 22)
        Me.dpApprove.TabIndex = 7
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(377, 114)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl6.TabIndex = 56
        Me.LabelControl6.Text = "Approve:"
        '
        'dpType
        '
        Me.dpType.EditValue = "Vacation"
        Me.dpType.Enabled = False
        Me.dpType.Location = New System.Drawing.Point(87, 62)
        Me.dpType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpType.Name = "dpType"
        Me.dpType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpType.Properties.Items.AddRange(New Object() {"Vacation", "Sick"})
        Me.dpType.Size = New System.Drawing.Size(135, 22)
        Me.dpType.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(13, 62)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl5.TabIndex = 54
        Me.LabelControl5.Text = "Type:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 91)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 16)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Description:"
        '
        'txtdescription
        '
        Me.txtdescription.Enabled = False
        Me.txtdescription.Location = New System.Drawing.Point(87, 89)
        Me.txtdescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Properties.LinesCount = 2
        Me.txtdescription.Size = New System.Drawing.Size(269, 65)
        Me.txtdescription.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(377, 62)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 16)
        Me.LabelControl3.TabIndex = 49
        Me.LabelControl3.Text = "To:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(377, 33)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl2.TabIndex = 48
        Me.LabelControl2.Text = "From:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 33)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl1.TabIndex = 47
        Me.LabelControl1.Text = "Employee:"
        '
        'dpFrom
        '
        Me.dpFrom.EditValue = Nothing
        Me.dpFrom.Enabled = False
        Me.dpFrom.Location = New System.Drawing.Point(443, 30)
        Me.dpFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpFrom.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.dpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpFrom.Properties.EditFormat.FormatString = ""
        Me.dpFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpFrom.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.dpFrom.Size = New System.Drawing.Size(135, 22)
        Me.dpFrom.TabIndex = 4
        '
        'dpDays
        '
        Me.dpDays.EditValue = "0.5"
        Me.dpDays.Enabled = False
        Me.dpDays.Location = New System.Drawing.Point(443, 85)
        Me.dpDays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpDays.Name = "dpDays"
        Me.dpDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpDays.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.dpDays.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpDays.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpDays.Properties.Items.AddRange(New Object() {"0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4", "5.5", "6", "6.5", "7"})
        Me.dpDays.Size = New System.Drawing.Size(135, 22)
        Me.dpDays.TabIndex = 6
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LeaveDGControl)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 186)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(597, 284)
        Me.GroupControl2.TabIndex = 47
        Me.GroupControl2.Text = "Leave Application List"
        '
        'LeaveDGControl
        '
        Me.LeaveDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeaveDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LeaveDGControl.Location = New System.Drawing.Point(2, 24)
        Me.LeaveDGControl.MainView = Me.LeaveDG
        Me.LeaveDGControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LeaveDGControl.Name = "LeaveDGControl"
        Me.LeaveDGControl.Size = New System.Drawing.Size(593, 258)
        Me.LeaveDGControl.TabIndex = 10
        Me.LeaveDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LeaveDG})
        '
        'LeaveDG
        '
        Me.LeaveDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn8, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.LeaveDG.GridControl = Me.LeaveDGControl
        Me.LeaveDG.Name = "LeaveDG"
        Me.LeaveDG.OptionsBehavior.Editable = False
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
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "From"
        Me.GridColumn3.FieldName = "from_leave"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "To"
        Me.GridColumn4.FieldName = "to_leave"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Description"
        Me.GridColumn8.FieldName = "description"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Approve"
        Me.GridColumn5.FieldName = "approve"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Type"
        Me.GridColumn6.FieldName = "type"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "# of Days"
        Me.GridColumn7.FieldName = "days"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(146, 478)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(127, 26)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "Delete"
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(12, 478)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(127, 26)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "New"
        '
        'leaveFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 514)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "leaveFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave Application Form"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dpTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpApprove.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.LeaveDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaveDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dpApprove As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dpType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dpFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btndelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LeaveDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents LeaveDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dpTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dpEmployee As ComboBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dpDays As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
