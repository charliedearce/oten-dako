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
        Me.permissionsDGControl = New DevExpress.XtraGrid.GridControl()
        Me.permissionsDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btsave = New DevExpress.XtraEditors.SimpleButton()
        Me.cbPermission = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.btndelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnadd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.permissionsDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.permissionsDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPermission.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbEmployee
        '
        Me.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmployee.FormattingEnabled = True
        Me.cbEmployee.Location = New System.Drawing.Point(85, 11)
        Me.cbEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbEmployee.Name = "cbEmployee"
        Me.cbEmployee.Size = New System.Drawing.Size(270, 24)
        Me.cbEmployee.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Employee"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 52)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Permissions"
        '
        'permissionsDGControl
        '
        Me.permissionsDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.permissionsDGControl.Location = New System.Drawing.Point(14, 78)
        Me.permissionsDGControl.MainView = Me.permissionsDG
        Me.permissionsDGControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.permissionsDGControl.Name = "permissionsDGControl"
        Me.permissionsDGControl.Size = New System.Drawing.Size(342, 258)
        Me.permissionsDGControl.TabIndex = 10
        Me.permissionsDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.permissionsDG})
        '
        'permissionsDG
        '
        Me.permissionsDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn1})
        Me.permissionsDG.GridControl = Me.permissionsDGControl
        Me.permissionsDG.Name = "permissionsDG"
        Me.permissionsDG.OptionsBehavior.Editable = False
        Me.permissionsDG.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "System Permissions"
        Me.GridColumn2.FieldName = "description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'btsave
        '
        Me.btsave.Image = CType(resources.GetObject("btsave.Image"), System.Drawing.Image)
        Me.btsave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btsave.Location = New System.Drawing.Point(135, 482)
        Me.btsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(92, 26)
        Me.btsave.TabIndex = 11
        Me.btsave.Text = "Save"
        '
        'cbPermission
        '
        Me.cbPermission.Location = New System.Drawing.Point(85, 48)
        Me.cbPermission.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPermission.Name = "cbPermission"
        Me.cbPermission.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPermission.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbPermission.Size = New System.Drawing.Size(271, 22)
        Me.cbPermission.TabIndex = 15
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtUsername)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtPass)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 382)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(342, 94)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "System Credentials"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(134, 28)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(190, 22)
        Me.txtUsername.TabIndex = 23
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 32)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "Username"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 64)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(134, 60)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(190, 22)
        Me.txtPass.TabIndex = 20
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(264, 342)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(92, 26)
        Me.btndelete.TabIndex = 21
        Me.btndelete.Text = "Delete"
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(14, 342)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(93, 26)
        Me.btnadd.TabIndex = 20
        Me.btnadd.Text = "Add"
        '
        'userFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 517)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cbPermission)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.permissionsDGControl)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "userFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userFrm"
        CType(Me.permissionsDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.permissionsDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPermission.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbEmployee As ComboBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents permissionsDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents permissionsDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbPermission As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btndelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnadd As DevExpress.XtraEditors.SimpleButton
End Class
