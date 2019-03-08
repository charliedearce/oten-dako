<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class holiday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(holiday))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.holidayDGControl = New DevExpress.XtraGrid.GridControl()
        Me.holidayDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.employee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDate = New DevExpress.XtraEditors.DateEdit()
        Me.dpEnable = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dpType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdescription = New DevExpress.XtraEditors.MemoEdit()
        Me.btndelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.holidayDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.holidayDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpEnable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.holidayDGControl)
        Me.GroupControl2.Location = New System.Drawing.Point(14, 187)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(597, 284)
        Me.GroupControl2.TabIndex = 49
        Me.GroupControl2.Text = "Leave Application List"
        '
        'holidayDGControl
        '
        Me.holidayDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.holidayDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.holidayDGControl.Location = New System.Drawing.Point(2, 24)
        Me.holidayDGControl.MainView = Me.holidayDG
        Me.holidayDGControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.holidayDGControl.Name = "holidayDGControl"
        Me.holidayDGControl.Size = New System.Drawing.Size(593, 258)
        Me.holidayDGControl.TabIndex = 7
        Me.holidayDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.holidayDG})
        '
        'holidayDG
        '
        Me.holidayDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.employee, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.holidayDG.GridControl = Me.holidayDGControl
        Me.holidayDG.Name = "holidayDG"
        Me.holidayDG.OptionsBehavior.Editable = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'employee
        '
        Me.employee.Caption = "Date"
        Me.employee.FieldName = "date"
        Me.employee.Name = "employee"
        Me.employee.Visible = True
        Me.employee.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Description"
        Me.GridColumn3.FieldName = "description"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Type"
        Me.GridColumn4.FieldName = "type"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Enable"
        Me.GridColumn5.FieldName = "enable"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtDate)
        Me.GroupControl1.Controls.Add(Me.dpEnable)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.dpType)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtdescription)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 14)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(597, 167)
        Me.GroupControl1.TabIndex = 48
        Me.GroupControl1.Text = "Leave Infos"
        '
        'txtDate
        '
        Me.txtDate.EditValue = Nothing
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(87, 27)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.txtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDate.Properties.EditFormat.FormatString = ""
        Me.txtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtDate.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.txtDate.Size = New System.Drawing.Size(135, 22)
        Me.txtDate.TabIndex = 1
        '
        'dpEnable
        '
        Me.dpEnable.EditValue = "Y"
        Me.dpEnable.Enabled = False
        Me.dpEnable.Location = New System.Drawing.Point(307, 27)
        Me.dpEnable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpEnable.Name = "dpEnable"
        Me.dpEnable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpEnable.Properties.Items.AddRange(New Object() {"Y", "N"})
        Me.dpEnable.Size = New System.Drawing.Size(50, 22)
        Me.dpEnable.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(232, 31)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl1.TabIndex = 64
        Me.LabelControl1.Text = "Enable:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 31)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl2.TabIndex = 62
        Me.LabelControl2.Text = "date:"
        '
        'dpType
        '
        Me.dpType.EditValue = "Special"
        Me.dpType.Enabled = False
        Me.dpType.Location = New System.Drawing.Point(87, 58)
        Me.dpType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpType.Name = "dpType"
        Me.dpType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpType.Properties.Items.AddRange(New Object() {"Special", "Regular"})
        Me.dpType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
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
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(150, 478)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(127, 26)
        Me.btndelete.TabIndex = 6
        Me.btndelete.Text = "Delete"
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(16, 478)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(127, 26)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "New"
        '
        'holiday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 512)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "holiday"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Holidays"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.holidayDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.holidayDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpEnable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents holidayDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents holidayDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents employee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dpType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btndelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dpEnable As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDate As DevExpress.XtraEditors.DateEdit
End Class
