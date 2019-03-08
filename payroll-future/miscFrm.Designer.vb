<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class miscFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(miscFrm))
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDesc = New DevExpress.XtraEditors.TextEdit()
        Me.miscId = New System.Windows.Forms.TextBox()
        Me.lbltax = New DevExpress.XtraEditors.LabelControl()
        Me.cbTaxable = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTaxable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(96, 9)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Size = New System.Drawing.Size(125, 22)
        Me.txtAmount.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Amount:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 44)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 16)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Description:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(180, 70)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(77, 26)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "Save"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(96, 41)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(329, 22)
        Me.txtDesc.TabIndex = 2
        '
        'miscId
        '
        Me.miscId.Location = New System.Drawing.Point(75, 70)
        Me.miscId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.miscId.Name = "miscId"
        Me.miscId.Size = New System.Drawing.Size(54, 23)
        Me.miscId.TabIndex = 34
        Me.miscId.Visible = False
        '
        'lbltax
        '
        Me.lbltax.Location = New System.Drawing.Point(244, 11)
        Me.lbltax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(50, 16)
        Me.lbltax.TabIndex = 36
        Me.lbltax.Text = "Taxable:"
        Me.lbltax.Visible = False
        '
        'cbTaxable
        '
        Me.cbTaxable.Location = New System.Drawing.Point(300, 8)
        Me.cbTaxable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbTaxable.Name = "cbTaxable"
        Me.cbTaxable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTaxable.Properties.Items.AddRange(New Object() {"Taxable", "Not-Taxable"})
        Me.cbTaxable.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbTaxable.Size = New System.Drawing.Size(125, 22)
        Me.cbTaxable.TabIndex = 35
        Me.cbTaxable.Visible = False
        '
        'miscFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 102)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.miscId)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cbTaxable)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "miscFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "miscFrm"
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTaxable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents miscId As TextBox
    Friend WithEvents lbltax As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTaxable As DevExpress.XtraEditors.ComboBoxEdit
End Class
