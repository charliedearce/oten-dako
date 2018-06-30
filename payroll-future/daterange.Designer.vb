<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daterange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(daterange))
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dpFrom = New DevExpress.XtraEditors.DateEdit()
        Me.dpTo = New DevExpress.XtraEditors.DateEdit()
        CType(Me.dpFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(25, 105)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 23)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "Generate"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 10)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl1.TabIndex = 31
        Me.LabelControl1.Text = "From:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 57)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "To:"
        '
        'dpFrom
        '
        Me.dpFrom.EditValue = New Date(2018, 4, 9, 23, 36, 9, 442)
        Me.dpFrom.Location = New System.Drawing.Point(10, 28)
        Me.dpFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpFrom.Properties.Appearance.Options.UseFont = True
        Me.dpFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpFrom.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.dpFrom.Properties.DisplayFormat.FormatString = "MM-dd-yyyy"
        Me.dpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpFrom.Properties.Mask.EditMask = "MM-dd-yyyy"
        Me.dpFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dpFrom.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dpFrom.Size = New System.Drawing.Size(122, 26)
        Me.dpFrom.TabIndex = 33
        '
        'dpTo
        '
        Me.dpTo.EditValue = New Date(2018, 4, 9, 23, 36, 9, 442)
        Me.dpTo.Location = New System.Drawing.Point(10, 75)
        Me.dpTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dpTo.Name = "dpTo"
        Me.dpTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpTo.Properties.Appearance.Options.UseFont = True
        Me.dpTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpTo.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.dpTo.Properties.DisplayFormat.FormatString = "MM-dd-yyyy"
        Me.dpTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dpTo.Properties.Mask.EditMask = "MM-dd-yyyy"
        Me.dpTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dpTo.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dpTo.Size = New System.Drawing.Size(122, 26)
        Me.dpTo.TabIndex = 34
        '
        'daterange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(142, 137)
        Me.Controls.Add(Me.dpTo)
        Me.Controls.Add(Me.dpFrom)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "daterange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "daterange"
        CType(Me.dpFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dpFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dpTo As DevExpress.XtraEditors.DateEdit
End Class
