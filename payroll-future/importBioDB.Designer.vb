<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class importBioDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(importBioDB))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFn = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.payroll_future.progressbar), True, True, True)
        Me.EmployeesDGControl = New DevExpress.XtraGrid.GridControl()
        Me.EmployeesDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AttDatesControl = New DevExpress.XtraGrid.GridControl()
        Me.AttDates = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDate = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmpName = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FirstOutDGControl = New DevExpress.XtraGrid.GridControl()
        Me.FirstOutDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FirstInDGControl = New DevExpress.XtraGrid.GridControl()
        Me.FirstInDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SecondOutDGControl = New DevExpress.XtraGrid.GridControl()
        Me.SecondOutDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SecondInDGControl = New DevExpress.XtraGrid.GridControl()
        Me.SecondInDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.paynolbl = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.EmployeesDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttDatesControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttDates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FirstOutDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstOutDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstInDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirstInDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SecondOutDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondOutDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondInDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondInDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(14, 15)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(87, 28)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Browse"
        '
        'txtFn
        '
        Me.txtFn.Location = New System.Drawing.Point(110, 17)
        Me.txtFn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(331, 23)
        Me.txtFn.TabIndex = 4
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton2.Location = New System.Drawing.Point(448, 17)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(90, 26)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Import"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'EmployeesDGControl
        '
        Me.EmployeesDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeesDGControl.Location = New System.Drawing.Point(13, 98)
        Me.EmployeesDGControl.MainView = Me.EmployeesDG
        Me.EmployeesDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeesDGControl.Name = "EmployeesDGControl"
        Me.EmployeesDGControl.Size = New System.Drawing.Size(524, 246)
        Me.EmployeesDGControl.TabIndex = 7
        Me.EmployeesDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.EmployeesDG})
        '
        'EmployeesDG
        '
        Me.EmployeesDG.GridControl = Me.EmployeesDGControl
        Me.EmployeesDG.Name = "EmployeesDG"
        Me.EmployeesDG.OptionsBehavior.Editable = False
        Me.EmployeesDG.OptionsView.ShowGroupPanel = False
        '
        'AttDatesControl
        '
        Me.AttDatesControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AttDatesControl.Location = New System.Drawing.Point(14, 375)
        Me.AttDatesControl.MainView = Me.AttDates
        Me.AttDatesControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AttDatesControl.Name = "AttDatesControl"
        Me.AttDatesControl.Size = New System.Drawing.Size(155, 218)
        Me.AttDatesControl.TabIndex = 8
        Me.AttDatesControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AttDates})
        '
        'AttDates
        '
        Me.AttDates.GridControl = Me.AttDatesControl
        Me.AttDates.Name = "AttDates"
        Me.AttDates.OptionsBehavior.Editable = False
        Me.AttDates.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 75)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(78, 16)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Employee List"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 352)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 16)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "Attendance Dates"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(176, 375)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(97, 16)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Employee Name:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(176, 469)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Date:"
        '
        'txtDate
        '
        Me.txtDate.EditValue = "Attendance Dates"
        Me.txtDate.Location = New System.Drawing.Point(177, 492)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.txtDate.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.txtDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Properties.Appearance.Options.UseBackColor = True
        Me.txtDate.Properties.Appearance.Options.UseBorderColor = True
        Me.txtDate.Properties.Appearance.Options.UseFont = True
        Me.txtDate.Properties.Appearance.Options.UseForeColor = True
        Me.txtDate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDate.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDate.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.Transparent
        Me.txtDate.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent
        Me.txtDate.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtDate.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txtDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.Transparent
        Me.txtDate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Transparent
        Me.txtDate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDate.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtDate.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.Transparent
        Me.txtDate.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Transparent
        Me.txtDate.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDate.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txtDate.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtDate.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDate.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDate.Properties.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(360, 28)
        Me.txtDate.TabIndex = 22
        Me.txtDate.TabStop = False
        '
        'txtEmpName
        '
        Me.txtEmpName.EditValue = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Me.txtEmpName.Location = New System.Drawing.Point(177, 399)
        Me.txtEmpName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmpName.Properties.Appearance.Options.UseFont = True
        Me.txtEmpName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEmpName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEmpName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtEmpName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtEmpName.Properties.ReadOnly = True
        Me.txtEmpName.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmpName.Size = New System.Drawing.Size(360, 63)
        Me.txtEmpName.TabIndex = 23
        Me.txtEmpName.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FirstOutDGControl)
        Me.GroupBox1.Controls.Add(Me.FirstInDGControl)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 633)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 154)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "First Half"
        '
        'FirstOutDGControl
        '
        Me.FirstOutDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstOutDGControl.Location = New System.Drawing.Point(6, 85)
        Me.FirstOutDGControl.MainView = Me.FirstOutDG
        Me.FirstOutDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstOutDGControl.Name = "FirstOutDGControl"
        Me.FirstOutDGControl.Size = New System.Drawing.Size(247, 54)
        Me.FirstOutDGControl.TabIndex = 14
        Me.FirstOutDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.FirstOutDG})
        '
        'FirstOutDG
        '
        Me.FirstOutDG.GridControl = Me.FirstOutDGControl
        Me.FirstOutDG.Name = "FirstOutDG"
        Me.FirstOutDG.OptionsBehavior.Editable = False
        Me.FirstOutDG.OptionsView.ShowGroupPanel = False
        '
        'FirstInDGControl
        '
        Me.FirstInDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstInDGControl.Location = New System.Drawing.Point(6, 23)
        Me.FirstInDGControl.MainView = Me.FirstInDG
        Me.FirstInDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstInDGControl.Name = "FirstInDGControl"
        Me.FirstInDGControl.Size = New System.Drawing.Size(247, 54)
        Me.FirstInDGControl.TabIndex = 10
        Me.FirstInDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.FirstInDG})
        '
        'FirstInDG
        '
        Me.FirstInDG.GridControl = Me.FirstInDGControl
        Me.FirstInDG.Name = "FirstInDG"
        Me.FirstInDG.OptionsBehavior.Editable = False
        Me.FirstInDG.OptionsView.ShowGroupPanel = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SecondOutDGControl)
        Me.GroupBox2.Controls.Add(Me.SecondInDGControl)
        Me.GroupBox2.Location = New System.Drawing.Point(280, 633)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 154)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Second Half"
        '
        'SecondOutDGControl
        '
        Me.SecondOutDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SecondOutDGControl.Location = New System.Drawing.Point(6, 85)
        Me.SecondOutDGControl.MainView = Me.SecondOutDG
        Me.SecondOutDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SecondOutDGControl.Name = "SecondOutDGControl"
        Me.SecondOutDGControl.Size = New System.Drawing.Size(247, 54)
        Me.SecondOutDGControl.TabIndex = 14
        Me.SecondOutDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SecondOutDG})
        '
        'SecondOutDG
        '
        Me.SecondOutDG.GridControl = Me.SecondOutDGControl
        Me.SecondOutDG.Name = "SecondOutDG"
        Me.SecondOutDG.OptionsBehavior.Editable = False
        Me.SecondOutDG.OptionsView.ShowGroupPanel = False
        '
        'SecondInDGControl
        '
        Me.SecondInDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SecondInDGControl.Location = New System.Drawing.Point(6, 23)
        Me.SecondInDGControl.MainView = Me.SecondInDG
        Me.SecondInDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SecondInDGControl.Name = "SecondInDGControl"
        Me.SecondInDGControl.Size = New System.Drawing.Size(247, 54)
        Me.SecondInDGControl.TabIndex = 10
        Me.SecondInDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SecondInDG})
        '
        'SecondInDG
        '
        Me.SecondInDG.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow
        Me.SecondInDG.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Yellow
        Me.SecondInDG.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SecondInDG.Appearance.SelectedRow.Options.UseBackColor = True
        Me.SecondInDG.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.SecondInDG.GridControl = Me.SecondInDGControl
        Me.SecondInDG.Name = "SecondInDG"
        Me.SecondInDG.OptionsBehavior.Editable = False
        Me.SecondInDG.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton4.Location = New System.Drawing.Point(20, 795)
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(125, 26)
        Me.SimpleButton4.TabIndex = 27
        Me.SimpleButton4.Text = "New Time"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton3.Location = New System.Drawing.Point(368, 794)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(165, 26)
        Me.SimpleButton3.TabIndex = 28
        Me.SimpleButton3.Text = "Process Attendance"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 51)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Payroll No:"
        '
        'paynolbl
        '
        Me.paynolbl.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paynolbl.Location = New System.Drawing.Point(113, 51)
        Me.paynolbl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.paynolbl.Name = "paynolbl"
        Me.paynolbl.Size = New System.Drawing.Size(21, 21)
        Me.paynolbl.TabIndex = 30
        Me.paynolbl.Text = "---"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton5.Location = New System.Drawing.Point(45, 600)
        Me.SimpleButton5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(77, 26)
        Me.SimpleButton5.TabIndex = 31
        Me.SimpleButton5.Text = "Refresh"
        '
        'importBioDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 834)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.paynolbl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.AttDatesControl)
        Me.Controls.Add(Me.EmployeesDGControl)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.txtFn)
        Me.Controls.Add(Me.SimpleButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "importBioDB"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "importBioDB"
        CType(Me.EmployeesDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttDatesControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttDates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.FirstOutDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstOutDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstInDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirstInDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.SecondOutDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondOutDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondInDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondInDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFn As TextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents EmployeesDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents EmployeesDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AttDatesControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents AttDates As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmpName As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FirstOutDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents FirstOutDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FirstInDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents FirstInDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SecondOutDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents SecondOutDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SecondInDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents SecondInDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents paynolbl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
End Class
