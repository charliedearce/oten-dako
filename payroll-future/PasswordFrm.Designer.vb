<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordFrm))
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.btnClosePayroll = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(14, 15)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(232, 22)
        Me.txtPass.TabIndex = 0
        '
        'btnClosePayroll
        '
        Me.btnClosePayroll.Image = CType(resources.GetObject("btnClosePayroll.Image"), System.Drawing.Image)
        Me.btnClosePayroll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnClosePayroll.Location = New System.Drawing.Point(79, 47)
        Me.btnClosePayroll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClosePayroll.Name = "btnClosePayroll"
        Me.btnClosePayroll.Size = New System.Drawing.Size(104, 26)
        Me.btnClosePayroll.TabIndex = 3
        Me.btnClosePayroll.Text = "Confirm"
        '
        'PasswordFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 86)
        Me.Controls.Add(Me.btnClosePayroll)
        Me.Controls.Add(Me.txtPass)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PasswordFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Password"
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnClosePayroll As DevExpress.XtraEditors.SimpleButton
End Class
