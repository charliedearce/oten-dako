<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userFrm))
        Me.cbEmployee = New System.Windows.Forms.ComboBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PayListDGControl = New DevExpress.XtraGrid.GridControl()
        Me.PayListDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btndelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btadd = New DevExpress.XtraEditors.SimpleButton()
        Me.cbPermission = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PayListDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayListDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPermission.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbEmployee
        '
        Me.cbEmployee.FormattingEnabled = True
        Me.cbEmployee.Location = New System.Drawing.Point(73, 9)
        Me.cbEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbEmployee.Name = "cbEmployee"
        Me.cbEmployee.Size = New System.Drawing.Size(232, 21)
        Me.cbEmployee.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Employee"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Permissions"
        '
        'PayListDGControl
        '
        Me.PayListDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PayListDGControl.Location = New System.Drawing.Point(12, 160)
        Me.PayListDGControl.MainView = Me.PayListDG
        Me.PayListDGControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PayListDGControl.Name = "PayListDGControl"
        Me.PayListDGControl.Size = New System.Drawing.Size(293, 227)
        Me.PayListDGControl.TabIndex = 10
        Me.PayListDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.PayListDG})
        '
        'PayListDG
        '
        Me.PayListDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
        Me.PayListDG.GridControl = Me.PayListDGControl
        Me.PayListDG.Name = "PayListDG"
        Me.PayListDG.OptionsBehavior.Editable = False
        Me.PayListDG.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "System Permissions"
        Me.GridColumn2.FieldName = "role_desc"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(196, 392)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(109, 21)
        Me.btndelete.TabIndex = 12
        Me.btndelete.Text = "Delete"
        '
        'btadd
        '
        Me.btadd.Image = CType(resources.GetObject("btadd.Image"), System.Drawing.Image)
        Me.btadd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btadd.Location = New System.Drawing.Point(12, 392)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(109, 21)
        Me.btadd.TabIndex = 11
        Me.btadd.Text = "Add"
        '
        'cbPermission
        '
        Me.cbPermission.Location = New System.Drawing.Point(73, 39)
        Me.cbPermission.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPermission.Name = "cbPermission"
        Me.cbPermission.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPermission.Size = New System.Drawing.Size(232, 20)
        Me.cbPermission.TabIndex = 15
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 64)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(293, 76)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "System Credentials"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(115, 23)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextEdit1.Size = New System.Drawing.Size(163, 20)
        Me.TextEdit1.TabIndex = 23
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "Re-Type Password"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Password"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(115, 49)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextEdit2.Size = New System.Drawing.Size(163, 20)
        Me.TextEdit2.TabIndex = 20
        '
        'userFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 420)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cbPermission)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btadd)
        Me.Controls.Add(Me.PayListDGControl)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "userFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userFrm"
        CType(Me.PayListDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayListDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPermission.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbEmployee As ComboBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PayListDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents PayListDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btndelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbPermission As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
