<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exportGovDeductionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(exportGovDeductionFrm))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dpFrom = New DevExpress.XtraEditors.TimeEdit()
        Me.dpType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dpTo = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.dpFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(46, 100)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(125, 28)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Export to Excel"
        '
        'dpFrom
        '
        Me.dpFrom.EditValue = New Date(2018, 7, 2, 6, 17, 2, 0)
        Me.dpFrom.Location = New System.Drawing.Point(94, 35)
        Me.dpFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpFrom.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dpFrom.Properties.Mask.EditMask = "d"
        Me.dpFrom.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.dpFrom.Size = New System.Drawing.Size(100, 22)
        Me.dpFrom.TabIndex = 5
        '
        'dpType
        '
        Me.dpType.EditValue = "SSS"
        Me.dpType.Location = New System.Drawing.Point(94, 9)
        Me.dpType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpType.Name = "dpType"
        Me.dpType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpType.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpType.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpType.Properties.Items.AddRange(New Object() {"SSS", "PAG-IBIG", "PHIL-HEALTH", "WHTAX"})
        Me.dpType.Size = New System.Drawing.Size(100, 22)
        Me.dpType.TabIndex = 4
        '
        'dpTo
        '
        Me.dpTo.EditValue = New Date(2018, 7, 2, 6, 17, 2, 0)
        Me.dpTo.Location = New System.Drawing.Point(94, 61)
        Me.dpTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpTo.Name = "dpTo"
        Me.dpTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpTo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dpTo.Properties.Mask.EditMask = "d"
        Me.dpTo.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.dpTo.Size = New System.Drawing.Size(100, 22)
        Me.dpTo.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Contribution"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "From"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(15, 16)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "To"
        '
        'exportGovDeductionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 140)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.dpTo)
        Me.Controls.Add(Me.dpFrom)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.dpType)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "exportGovDeductionFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Contributions"
        CType(Me.dpFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents dpFrom As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents dpType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dpTo As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
