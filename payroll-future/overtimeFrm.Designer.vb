﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overtimeFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(overtimeFrm))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.OverTimeDGControl = New DevExpress.XtraGrid.GridControl()
        Me.OverTimeDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.dpTo = New DevExpress.XtraEditors.TimeEdit()
        Me.dpEmployee = New System.Windows.Forms.ComboBox()
        Me.dpApprove = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdescription = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dpFrom = New DevExpress.XtraEditors.TimeEdit()
        Me.btndelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.OverTimeDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OverTimeDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dpTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpApprove.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.OverTimeDGControl)
        Me.GroupControl2.Location = New System.Drawing.Point(14, 161)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(635, 310)
        Me.GroupControl2.TabIndex = 49
        Me.GroupControl2.Text = "Leave Application List"
        '
        'OverTimeDGControl
        '
        Me.OverTimeDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OverTimeDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OverTimeDGControl.Location = New System.Drawing.Point(2, 24)
        Me.OverTimeDGControl.MainView = Me.OverTimeDG
        Me.OverTimeDGControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OverTimeDGControl.Name = "OverTimeDGControl"
        Me.OverTimeDGControl.Size = New System.Drawing.Size(631, 284)
        Me.OverTimeDGControl.TabIndex = 8
        Me.OverTimeDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.OverTimeDG})
        '
        'OverTimeDG
        '
        Me.OverTimeDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn6, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.OverTimeDG.GridControl = Me.OverTimeDGControl
        Me.OverTimeDG.Name = "OverTimeDG"
        Me.OverTimeDG.OptionsBehavior.Editable = False
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
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Description"
        Me.GridColumn6.FieldName = "description"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "From"
        Me.GridColumn3.DisplayFormat.FormatString = "g"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "from_time"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "To"
        Me.GridColumn4.DisplayFormat.FormatString = "g"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "to_time"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Approve"
        Me.GridColumn5.FieldName = "approve"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.dpTo)
        Me.GroupControl1.Controls.Add(Me.dpEmployee)
        Me.GroupControl1.Controls.Add(Me.dpApprove)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtdescription)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.dpFrom)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 14)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(635, 143)
        Me.GroupControl1.TabIndex = 48
        Me.GroupControl1.Text = "Leave Infos"
        '
        'dpTo
        '
        Me.dpTo.EditValue = New Date(2018, 7, 2, 6, 17, 2, 0)
        Me.dpTo.Enabled = False
        Me.dpTo.Location = New System.Drawing.Point(443, 58)
        Me.dpTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpTo.Name = "dpTo"
        Me.dpTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpTo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dpTo.Properties.Mask.EditMask = "g"
        Me.dpTo.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.dpTo.Size = New System.Drawing.Size(185, 22)
        Me.dpTo.TabIndex = 4
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
        'dpApprove
        '
        Me.dpApprove.EditValue = "Y"
        Me.dpApprove.Enabled = False
        Me.dpApprove.Location = New System.Drawing.Point(443, 87)
        Me.dpApprove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpApprove.Name = "dpApprove"
        Me.dpApprove.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpApprove.Properties.Items.AddRange(New Object() {"Y", "N"})
        Me.dpApprove.Size = New System.Drawing.Size(47, 22)
        Me.dpApprove.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(377, 90)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl6.TabIndex = 56
        Me.LabelControl6.Text = "Approve:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 66)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 16)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Description:"
        '
        'txtdescription
        '
        Me.txtdescription.Enabled = False
        Me.txtdescription.Location = New System.Drawing.Point(87, 64)
        Me.txtdescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Properties.LinesCount = 2
        Me.txtdescription.Size = New System.Drawing.Size(269, 65)
        Me.txtdescription.TabIndex = 2
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
        Me.dpFrom.EditValue = New Date(2018, 7, 2, 6, 17, 2, 0)
        Me.dpFrom.Enabled = False
        Me.dpFrom.Location = New System.Drawing.Point(443, 30)
        Me.dpFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpFrom.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dpFrom.Properties.Mask.EditMask = "g"
        Me.dpFrom.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.dpFrom.Size = New System.Drawing.Size(185, 22)
        Me.dpFrom.TabIndex = 3
        '
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(148, 478)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(127, 26)
        Me.btndelete.TabIndex = 7
        Me.btndelete.Text = "Delete"
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(14, 478)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(127, 26)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "New"
        '
        'overtimeFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 512)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "overtimeFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OverTime Form"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.OverTimeDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OverTimeDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dpTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpApprove.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents OverTimeDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents OverTimeDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dpEmployee As ComboBox
    Friend WithEvents dpApprove As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btndelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dpFrom As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents dpTo As DevExpress.XtraEditors.TimeEdit
End Class
