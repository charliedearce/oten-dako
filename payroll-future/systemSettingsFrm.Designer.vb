<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class systemSettingsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(systemSettingsFrm))
        Me.btsave = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txthtax = New DevExpress.XtraEditors.TextEdit()
        Me.txtphilhealth = New DevExpress.XtraEditors.TextEdit()
        Me.txtpagibig = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtsss = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtworkdays = New DevExpress.XtraEditors.TextEdit()
        Me.txttelno = New DevExpress.XtraEditors.TextEdit()
        Me.txtaddress = New DevExpress.XtraEditors.TextEdit()
        Me.txtname = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txthtax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtphilhealth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpagibig.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtworkdays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttelno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtaddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btsave
        '
        Me.btsave.Image = CType(resources.GetObject("btsave.Image"), System.Drawing.Image)
        Me.btsave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btsave.Location = New System.Drawing.Point(196, 334)
        Me.btsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(92, 26)
        Me.btsave.TabIndex = 17
        Me.btsave.Text = "Save"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GroupControl1)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.txtworkdays)
        Me.GroupControl2.Controls.Add(Me.txttelno)
        Me.GroupControl2.Controls.Add(Me.txtaddress)
        Me.GroupControl2.Controls.Add(Me.txtname)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(458, 314)
        Me.GroupControl2.TabIndex = 18
        Me.GroupControl2.Text = "Settings"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txthtax)
        Me.GroupControl1.Controls.Add(Me.txtphilhealth)
        Me.GroupControl1.Controls.Add(Me.txtpagibig)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtsss)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 138)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(209, 162)
        Me.GroupControl1.TabIndex = 25
        Me.GroupControl1.Text = "Employer Government Share"
        '
        'txthtax
        '
        Me.txthtax.Location = New System.Drawing.Point(139, 114)
        Me.txthtax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txthtax.Name = "txthtax"
        Me.txthtax.Properties.Mask.EditMask = "p"
        Me.txthtax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txthtax.Size = New System.Drawing.Size(55, 22)
        Me.txthtax.TabIndex = 26
        '
        'txtphilhealth
        '
        Me.txtphilhealth.Location = New System.Drawing.Point(139, 87)
        Me.txtphilhealth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtphilhealth.Name = "txtphilhealth"
        Me.txtphilhealth.Properties.Mask.EditMask = "p"
        Me.txtphilhealth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtphilhealth.Size = New System.Drawing.Size(55, 22)
        Me.txtphilhealth.TabIndex = 25
        '
        'txtpagibig
        '
        Me.txtpagibig.Location = New System.Drawing.Point(139, 59)
        Me.txtpagibig.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpagibig.Name = "txtpagibig"
        Me.txtpagibig.Properties.Mask.EditMask = "p"
        Me.txtpagibig.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtpagibig.Size = New System.Drawing.Size(55, 22)
        Me.txtpagibig.TabIndex = 24
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 118)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "WHTAX:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 90)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(80, 16)
        Me.LabelControl7.TabIndex = 22
        Me.LabelControl7.Text = "PHIL-HEALTH:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 62)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl6.TabIndex = 21
        Me.LabelControl6.Text = "PAG-IBIG:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 34)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(29, 16)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "SSS:"
        '
        'txtsss
        '
        Me.txtsss.Location = New System.Drawing.Point(139, 31)
        Me.txtsss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtsss.Name = "txtsss"
        Me.txtsss.Properties.Mask.EditMask = "p"
        Me.txtsss.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtsss.Size = New System.Drawing.Size(55, 22)
        Me.txtsss.TabIndex = 16
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 116)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(156, 16)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "# of Work Days per Month:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 85)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 16)
        Me.LabelControl3.TabIndex = 23
        Me.LabelControl3.Text = "Company Tel. #:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 57)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(108, 16)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "Company Address:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 27)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 16)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Company Name:"
        '
        'txtworkdays
        '
        Me.txtworkdays.Location = New System.Drawing.Point(167, 110)
        Me.txtworkdays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtworkdays.Name = "txtworkdays"
        Me.txtworkdays.Properties.Mask.EditMask = "f0"
        Me.txtworkdays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtworkdays.Size = New System.Drawing.Size(45, 22)
        Me.txtworkdays.TabIndex = 20
        '
        'txttelno
        '
        Me.txttelno.Location = New System.Drawing.Point(167, 82)
        Me.txttelno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttelno.Name = "txttelno"
        Me.txttelno.Properties.Mask.EditMask = "(999) 000-0000"
        Me.txttelno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txttelno.Size = New System.Drawing.Size(150, 22)
        Me.txttelno.TabIndex = 19
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(167, 54)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Properties.Mask.EditMask = "\p{Lu}+"
        Me.txtaddress.Size = New System.Drawing.Size(285, 22)
        Me.txtaddress.TabIndex = 18
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(167, 26)
        Me.txtname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtname.Name = "txtname"
        Me.txtname.Properties.Mask.EditMask = "\p{Lu}+"
        Me.txtname.Size = New System.Drawing.Size(285, 22)
        Me.txtname.TabIndex = 17
        '
        'systemSettingsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 366)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.btsave)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "systemSettingsFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Settings"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txthtax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtphilhealth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpagibig.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtworkdays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttelno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtaddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtworkdays As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttelno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtaddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txthtax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtphilhealth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpagibig As DevExpress.XtraEditors.TextEdit
End Class
