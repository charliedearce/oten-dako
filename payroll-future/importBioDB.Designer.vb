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
        Me.EmployeesDGControl = New DevExpress.XtraGrid.GridControl()
        Me.EmployeesDG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AttDatesControl = New DevExpress.XtraGrid.GridControl()
        Me.AttDates = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
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
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lblfrom = New DevExpress.XtraEditors.LabelControl()
        Me.lblto = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpName = New DevExpress.XtraEditors.LabelControl()
        Me.txtDate = New DevExpress.XtraEditors.LabelControl()
        CType(Me.EmployeesDGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttDatesControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttDates, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Browse"
        '
        'txtFn
        '
        Me.txtFn.Location = New System.Drawing.Point(94, 14)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(284, 21)
        Me.txtFn.TabIndex = 4
        '
        'btnImport
        '
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnImport.Location = New System.Drawing.Point(384, 14)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(77, 21)
        Me.btnImport.TabIndex = 5
        Me.btnImport.Text = "Import"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'EmployeesDGControl
        '
        Me.EmployeesDGControl.Location = New System.Drawing.Point(10, 109)
        Me.EmployeesDGControl.MainView = Me.EmployeesDG
        Me.EmployeesDGControl.Name = "EmployeesDGControl"
        Me.EmployeesDGControl.Size = New System.Drawing.Size(449, 200)
        Me.EmployeesDGControl.TabIndex = 7
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
        'AttDatesControl
        '
        Me.AttDatesControl.Location = New System.Drawing.Point(11, 334)
        Me.AttDatesControl.MainView = Me.AttDates
        Me.AttDatesControl.Name = "AttDatesControl"
        Me.AttDatesControl.Size = New System.Drawing.Size(133, 177)
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
        Me.LabelControl3.Location = New System.Drawing.Point(10, 90)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Employee List"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 315)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "Attendance Dates"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(150, 334)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Employee Name:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(150, 410)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FirstOutDGControl)
        Me.GroupBox1.Controls.Add(Me.FirstInDGControl)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 543)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(222, 125)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "First Half"
        '
        'FirstOutDGControl
        '
        Me.FirstOutDGControl.Location = New System.Drawing.Point(5, 69)
        Me.FirstOutDGControl.MainView = Me.FirstOutDG
        Me.FirstOutDGControl.Name = "FirstOutDGControl"
        Me.FirstOutDGControl.Size = New System.Drawing.Size(212, 44)
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
        Me.FirstInDGControl.Location = New System.Drawing.Point(5, 19)
        Me.FirstInDGControl.MainView = Me.FirstInDG
        Me.FirstInDGControl.Name = "FirstInDGControl"
        Me.FirstInDGControl.Size = New System.Drawing.Size(212, 44)
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
        Me.GroupBox2.Location = New System.Drawing.Point(239, 543)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(222, 125)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Second Half"
        '
        'SecondOutDGControl
        '
        Me.SecondOutDGControl.Location = New System.Drawing.Point(5, 69)
        Me.SecondOutDGControl.MainView = Me.SecondOutDG
        Me.SecondOutDGControl.Name = "SecondOutDGControl"
        Me.SecondOutDGControl.Size = New System.Drawing.Size(212, 44)
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
        Me.SecondInDGControl.Location = New System.Drawing.Point(5, 19)
        Me.SecondInDGControl.MainView = Me.SecondInDG
        Me.SecondInDGControl.Name = "SecondInDGControl"
        Me.SecondInDGControl.Size = New System.Drawing.Size(212, 44)
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
        Me.GridColumn9.DisplayFormat.FormatString = "d"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "TimeIn"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton4.Location = New System.Drawing.Point(16, 675)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(107, 21)
        Me.SimpleButton4.TabIndex = 27
        Me.SimpleButton4.Text = "New Time"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton3.Location = New System.Drawing.Point(314, 674)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(141, 21)
        Me.SimpleButton3.TabIndex = 28
        Me.SimpleButton3.Text = "Process Attendance"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(10, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Payroll No:"
        '
        'paynolbl
        '
        Me.paynolbl.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paynolbl.Location = New System.Drawing.Point(97, 41)
        Me.paynolbl.Name = "paynolbl"
        Me.paynolbl.Size = New System.Drawing.Size(18, 17)
        Me.paynolbl.TabIndex = 30
        Me.paynolbl.Text = "---"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton5.Location = New System.Drawing.Point(38, 517)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(66, 21)
        Me.SimpleButton5.TabIndex = 31
        Me.SimpleButton5.Text = "Refresh"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Payroll Date From:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(212, 69)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl7.TabIndex = 33
        Me.LabelControl7.Text = "Payroll Date To:"
        '
        'lblfrom
        '
        Me.lblfrom.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrom.Location = New System.Drawing.Point(104, 69)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(104, 13)
        Me.lblfrom.TabIndex = 34
        Me.lblfrom.Text = "Payroll Date From:"
        '
        'lblto
        '
        Me.lblto.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.Location = New System.Drawing.Point(295, 69)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(104, 13)
        Me.lblto.TabIndex = 35
        Me.lblto.Text = "Payroll Date From:"
        '
        'txtEmpName
        '
        Me.txtEmpName.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEmpName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtEmpName.Location = New System.Drawing.Point(151, 353)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(304, 19)
        Me.txtEmpName.TabIndex = 36
        Me.txtEmpName.Text = "employee"
        '
        'txtDate
        '
        Me.txtDate.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtDate.Location = New System.Drawing.Point(151, 429)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(304, 19)
        Me.txtDate.TabIndex = 37
        Me.txtDate.Text = "attendance date"
        '
        'importBioDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 706)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.lblfrom)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.paynolbl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.AttDatesControl)
        Me.Controls.Add(Me.EmployeesDGControl)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.txtFn)
        Me.Controls.Add(Me.SimpleButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
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
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents EmployeesDGControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents EmployeesDG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AttDatesControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents AttDates As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
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
End Class
