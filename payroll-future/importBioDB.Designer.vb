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
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.payroll_future.progressbar), True, True, True)
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FirstOutDGControl = New DevExpress.XtraGrid.GridControl()
        Me.FirstOutDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FirstInDGControl = New DevExpress.XtraGrid.GridControl()
        Me.FirstInDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SecondOutDGControl = New DevExpress.XtraGrid.GridControl()
        Me.SecondOutDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SecondInDGControl = New DevExpress.XtraGrid.GridControl()
        Me.SecondInDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.paynolbl = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lblfrom = New DevExpress.XtraEditors.LabelControl()
        Me.lblto = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpName = New DevExpress.XtraEditors.LabelControl()
        Me.txtDate = New DevExpress.XtraEditors.LabelControl()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.EmployeesDGControl = New DevExpress.XtraGrid.GridControl()
        Me.EmployeesDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.AttDatesControl = New DevExpress.XtraGrid.GridControl()
        Me.AttDates = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.EmployeesDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.AttDatesControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttDates, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnImport
        '
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnImport.Location = New System.Drawing.Point(448, 17)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(90, 26)
        Me.btnImport.TabIndex = 5
        Me.btnImport.Text = "Import"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 103)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(97, 16)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Employee Name:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 127)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FirstOutDGControl)
        Me.GroupBox1.Controls.Add(Me.FirstInDGControl)
        Me.GroupBox1.Location = New System.Drawing.Point(652, 150)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(161, 274)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "First Half"
        '
        'FirstOutDGControl
        '
        Me.FirstOutDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstOutDGControl.Location = New System.Drawing.Point(6, 147)
        Me.FirstOutDGControl.MainView = Me.FirstOutDG
        Me.FirstOutDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstOutDGControl.Name = "FirstOutDGControl"
        Me.FirstOutDGControl.Size = New System.Drawing.Size(148, 116)
        Me.FirstOutDGControl.TabIndex = 14
        Me.FirstOutDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.FirstOutDG})
        '
        'FirstOutDG
        '
        Me.FirstOutDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7})
        Me.FirstOutDG.GridControl = Me.FirstOutDGControl
        Me.FirstOutDG.Name = "FirstOutDG"
        Me.FirstOutDG.OptionsBehavior.Editable = False
        Me.FirstOutDG.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.FieldName = "id"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "TimeOut"
        Me.GridColumn7.FieldName = "TimeOut"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'FirstInDGControl
        '
        Me.FirstInDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstInDGControl.Location = New System.Drawing.Point(6, 23)
        Me.FirstInDGControl.MainView = Me.FirstInDG
        Me.FirstInDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FirstInDGControl.Name = "FirstInDGControl"
        Me.FirstInDGControl.Size = New System.Drawing.Size(148, 116)
        Me.FirstInDGControl.TabIndex = 10
        Me.FirstInDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.FirstInDG})
        '
        'FirstInDG
        '
        Me.FirstInDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5})
        Me.FirstInDG.GridControl = Me.FirstInDGControl
        Me.FirstInDG.Name = "FirstInDG"
        Me.FirstInDG.OptionsBehavior.Editable = False
        Me.FirstInDG.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "GridColumn4"
        Me.GridColumn4.FieldName = "id"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "TimeIn"
        Me.GridColumn5.FieldName = "TimeIn"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SecondOutDGControl)
        Me.GroupBox2.Controls.Add(Me.SecondInDGControl)
        Me.GroupBox2.Location = New System.Drawing.Point(819, 150)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(164, 274)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Second Half"
        '
        'SecondOutDGControl
        '
        Me.SecondOutDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SecondOutDGControl.Location = New System.Drawing.Point(6, 147)
        Me.SecondOutDGControl.MainView = Me.SecondOutDG
        Me.SecondOutDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SecondOutDGControl.Name = "SecondOutDGControl"
        Me.SecondOutDGControl.Size = New System.Drawing.Size(155, 116)
        Me.SecondOutDGControl.TabIndex = 14
        Me.SecondOutDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SecondOutDG})
        '
        'SecondOutDG
        '
        Me.SecondOutDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11})
        Me.SecondOutDG.GridControl = Me.SecondOutDGControl
        Me.SecondOutDG.Name = "SecondOutDG"
        Me.SecondOutDG.OptionsBehavior.Editable = False
        Me.SecondOutDG.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "GridColumn10"
        Me.GridColumn10.FieldName = "id"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "TimeOut"
        Me.GridColumn11.FieldName = "TimeOut"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        '
        'SecondInDGControl
        '
        Me.SecondInDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SecondInDGControl.Location = New System.Drawing.Point(6, 23)
        Me.SecondInDGControl.MainView = Me.SecondInDG
        Me.SecondInDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SecondInDGControl.Name = "SecondInDGControl"
        Me.SecondInDGControl.Size = New System.Drawing.Size(155, 116)
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
        Me.SecondInDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9})
        Me.SecondInDG.GridControl = Me.SecondInDGControl
        Me.SecondInDG.Name = "SecondInDG"
        Me.SecondInDG.OptionsBehavior.Editable = False
        Me.SecondInDG.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GridColumn8"
        Me.GridColumn8.FieldName = "id"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "TimeIn"
        Me.GridColumn9.CustomizationCaption = "TimeIn"
        Me.GridColumn9.FieldName = "TimeIn"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton4.Location = New System.Drawing.Point(669, 436)
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
        Me.SimpleButton3.Location = New System.Drawing.Point(819, 436)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(164, 26)
        Me.SimpleButton3.TabIndex = 28
        Me.SimpleButton3.Text = "Process Attendance"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(16, 51)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Payroll No:"
        '
        'paynolbl
        '
        Me.paynolbl.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paynolbl.Location = New System.Drawing.Point(113, 50)
        Me.paynolbl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.paynolbl.Name = "paynolbl"
        Me.paynolbl.Size = New System.Drawing.Size(21, 21)
        Me.paynolbl.TabIndex = 30
        Me.paynolbl.Text = "---"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 79)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 16)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Payroll Date From:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(262, 79)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(92, 16)
        Me.LabelControl7.TabIndex = 33
        Me.LabelControl7.Text = "Payroll Date To:"
        '
        'lblfrom
        '
        Me.lblfrom.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrom.Location = New System.Drawing.Point(129, 78)
        Me.lblfrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(127, 17)
        Me.lblfrom.TabIndex = 34
        Me.lblfrom.Text = "Payroll Date From:"
        '
        'lblto
        '
        Me.lblto.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.Location = New System.Drawing.Point(360, 78)
        Me.lblto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(127, 17)
        Me.lblto.TabIndex = 35
        Me.lblto.Text = "Payroll Date From:"
        '
        'txtEmpName
        '
        Me.txtEmpName.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtEmpName.Location = New System.Drawing.Point(120, 103)
        Me.txtEmpName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(863, 16)
        Me.txtEmpName.TabIndex = 36
        Me.txtEmpName.Text = "employee"
        '
        'txtDate
        '
        Me.txtDate.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtDate.Location = New System.Drawing.Point(53, 127)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(243, 16)
        Me.txtDate.TabIndex = 37
        Me.txtDate.Text = "attendance date"
        '
        'GridColumn13
        '
        Me.GridColumn13.FieldName = "AttendanceDates"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        '
        'GridColumn14
        '
        Me.GridColumn14.FieldName = "AttendanceDates"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.EmployeesDGControl)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 150)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(427, 312)
        Me.GroupControl1.TabIndex = 39
        Me.GroupControl1.Text = "Employee List"
        '
        'EmployeesDGControl
        '
        Me.EmployeesDGControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeesDGControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeesDGControl.Location = New System.Drawing.Point(2, 24)
        Me.EmployeesDGControl.MainView = Me.EmployeesDG
        Me.EmployeesDGControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeesDGControl.Name = "EmployeesDGControl"
        Me.EmployeesDGControl.Size = New System.Drawing.Size(423, 286)
        Me.EmployeesDGControl.TabIndex = 10
        Me.EmployeesDGControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.EmployeesDG})
        '
        'EmployeesDG
        '
        Me.EmployeesDG.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn1, Me.GridColumn2})
        Me.EmployeesDG.GridControl = Me.EmployeesDGControl
        Me.EmployeesDG.Name = "EmployeesDG"
        Me.EmployeesDG.OptionsBehavior.Editable = False
        Me.EmployeesDG.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.FieldName = "emp_id"
        Me.GridColumn3.Name = "GridColumn3"
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
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton5)
        Me.GroupControl2.Controls.Add(Me.AttDatesControl)
        Me.GroupControl2.Location = New System.Drawing.Point(446, 150)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(200, 312)
        Me.GroupControl2.TabIndex = 40
        Me.GroupControl2.Text = "Attendance Dates"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton5.Location = New System.Drawing.Point(58, 276)
        Me.SimpleButton5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(77, 26)
        Me.SimpleButton5.TabIndex = 32
        Me.SimpleButton5.Text = "Refresh"
        '
        'AttDatesControl
        '
        Me.AttDatesControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AttDatesControl.Location = New System.Drawing.Point(5, 24)
        Me.AttDatesControl.MainView = Me.AttDates
        Me.AttDatesControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AttDatesControl.Name = "AttDatesControl"
        Me.AttDatesControl.Size = New System.Drawing.Size(190, 244)
        Me.AttDatesControl.TabIndex = 9
        Me.AttDatesControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AttDates})
        '
        'AttDates
        '
        Me.AttDates.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12})
        Me.AttDates.GridControl = Me.AttDatesControl
        Me.AttDates.Name = "AttDates"
        Me.AttDates.OptionsBehavior.Editable = False
        Me.AttDates.OptionsView.ShowGroupPanel = False
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Date"
        Me.GridColumn12.FieldName = "AttendanceDates"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Attendance Dates"
        Me.GridColumn15.FieldName = "AttendanceDates"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Attendance Dates"
        Me.GridColumn16.FieldName = "AttendanceDates"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 0
        '
        'importBioDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 479)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.lblfrom)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.paynolbl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.btnImport)
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.EmployeesDGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.AttDatesControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttDates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFn As TextBox
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblfrom As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents EmployeesDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents EmployeesDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents AttDatesControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents AttDates As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
End Class
