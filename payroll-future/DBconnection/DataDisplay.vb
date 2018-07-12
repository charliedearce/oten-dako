Imports System.Data.SqlClient

Module DataDisplay
    Public Function getData(ByVal sqlStatement As String, ByVal tablename As String, ByVal datagrid As Object)
        Dim sql As String = sqlStatement
        Dim connection As New SqlConnection(SQLServerConnection)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, tablename)
        datagrid.DataSource = ds.Tables(0)

        datagrid.Refresh()
        connection.Close()
    End Function

    Public Function getDataMultiple(ByVal sqlStatement As String, ByVal tablename() As String, ByVal datagrid As Object)
        Dim sql As String = sqlStatement
        Dim connection As New SqlConnection(SQLServerConnection)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        Dim i As Integer
        For i = 0 To (tablename.Length - 1)
            dataadapter.Fill(ds, tablename(i))
        Next

        datagrid.DataSource = ds.Tables(0)

        datagrid.Refresh()
        connection.Close()
    End Function

    Public Function DisplayDP(ByVal SQLstatement As String, ByVal field As String, ByVal dropdown As Object)
        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader
        Try
            ' Open Connection
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = SQLstatement
            rows = myCommand.ExecuteReader()

            If rows.HasRows Then
                Do While rows.Read()
                    Dim query_result As String
                    If Not IsDBNull(rows(field)) Then
                        dropdown.Properties.Items.Add(rows(field).ToString())
                    End If
                Loop
                dropdown.SelectedIndex = 0
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            ' Close Connection
            myConnection.Close()
        End Try
    End Function

    Public Function DisplayDPwithID(ByVal SQLstatement As String, ByVal field() As String, ByVal dropdown As Object)
        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader
        Try
            ' Open Connection
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = SQLstatement
            rows = myCommand.ExecuteReader()
            Dim comboSource As New Dictionary(Of String, String)()
            If rows.HasRows Then
                Do While rows.Read()
                    Dim query_result As String
                    If Not IsDBNull(rows(field(0))) Then
                        comboSource.Add(rows(field(0)).ToString(), rows(field(1)).ToString())
                    End If
                Loop

                dropdown.DataSource = New BindingSource(comboSource, Nothing)
                dropdown.DisplayMember = "Value"
                dropdown.ValueMember = "Key"

                dropdown.SelectedIndex = 0
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            ' Close Connection
            myConnection.Close()
        End Try
    End Function
    Public Function showHideColumn(ByVal dataGridName As Object, ByVal columnNames() As String, ByVal Condition As Boolean)
        'datagrid.Columns("id").Visible = False
        For Each element As String In columnNames
            dataGridName.Columns(element).Visible = Condition
        Next
    End Function

    Public Function showDGValue(ByVal dataGridName As Object, ByVal columnNames As String)
        Return dataGridName.GetFocusedRowCellValue(columnNames)
    End Function

    Public Function updateDB(ByVal SqlStatement As String)
        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim rows As Integer
        'Create Command object
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Try
            ' Open Connection
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = SqlStatement
            rows = myCommand.ExecuteNonQuery()
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            ' Close Connection
            myConnection.Close()
        End Try
        Return True
    End Function

    Public Function readDB(ByVal SQLstatement As String, ByVal field As String)
        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader
        Try
            ' Open Connection
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = SQLstatement
            rows = myCommand.ExecuteReader()

            If rows.HasRows Then

                Do While rows.Read()
                    Dim query_result As String
                    If Not IsDBNull(rows(field)) Then
                        Return rows(field)
                    End If
                Loop
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            ' Close Connection
            myConnection.Close()
        End Try
    End Function
    Public Function getpayno()
        Dim test As Array
        test("test") = "haha"
        test("test1") = "huhu"
        Return test
    End Function

    Public Function OverallComputations(ByVal SQLstatement As String)

        Dim pay_from As Date
        Dim pay_to As Date
        Dim pay_id As Integer

        Dim payfield() As String = {"from_date", "to_date", "id"}
        Dim payinfo() As Object


        payinfo = readDBMulti("SELECT * FROM payroll_info WHERE type='Regular' and status='Open'", payfield)

        pay_from = payinfo(0)
        pay_to = payinfo(1)
        pay_id = payinfo(2)

        updateDB("DELETE FROM work_time WHERE payroll_no = '" & pay_id & "'")

        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader

        Dim emp_id As Integer


        Dim fromdate As Date = pay_from.ToString("MM-dd-yyyy")
        Dim todate As Date = pay_to.ToString("MM-dd-yyyy")

        Dim first_in As TimeSpan
        Dim first_out As TimeSpan
        Dim second_in As TimeSpan
        Dim second_out As TimeSpan

        Dim bio_first_in As TimeSpan
        Dim bio_first_out As TimeSpan
        Dim bio_second_in As TimeSpan
        Dim bio_second_out As TimeSpan
        Dim holiday As String

        Dim TS As TimeSpan
        Dim day As Integer
        Dim hour As Integer
        Dim mins As Integer

        Dim sched_TS_first As TimeSpan
        Dim sched_TS_second As TimeSpan

        Dim first_late As Double
        Dim second_late As Double

        Dim total_working_hrs As Double = 0

        Dim total_time As String

        Dim cur_pay_date As Date

        Dim bypass As Integer

        Dim schedulefield() As String = {"first_in", "first_out", "second_in", "second_out"}
        Dim scheduleinfo() As Object

        Try
            importBioDB.SplashScreenManager1.ShowForm(GetType(progressbar))
            ' Open Connection
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = SQLstatement
            rows = myCommand.ExecuteReader()



            If rows.HasRows Then
                Do While rows.Read()
                    emp_id = rows("emp_id")
                    bypass = rows("bypass")
                    ' total attendance in biometrics on specific date range
                    'getloop = readDB("SELECT COUNT(USERID) as row FROM biometrics WHERE USERID ='" & emp_id & "' AND CONVERT(date,CHECKTIME,110) BETWEEN '" & fromdate.ToString("MM-dd-yyyy") & "' AND '" & todate.ToString("MM-dd-yyyy") & "'", "row")
                    ' get employee time schedule
                    scheduleinfo = readDBMulti("SELECT * FROM schedule WHERE emp_id = '" & emp_id & "'", schedulefield)

                    first_in = scheduleinfo(0)
                    first_out = scheduleinfo(1)
                    second_in = scheduleinfo(2)
                    second_out = scheduleinfo(3)

                    TS = todate - fromdate
                    day = TS.Days

                    sched_TS_first = first_out - first_in
                    sched_TS_second = second_out - second_in

                    For index As Integer = 0 To day
                        cur_pay_date = fromdate.AddDays(index)
                        ' get employee time on biometrics
                        bio_first_in = readDB("SELECT convert(time, CHECKTIME, 114) as firstin FROM biometrics WHERE convert(time, CHECKTIME, 114) < '" & first_out.ToString & "' AND CHECKTYPE = 'I' AND USERID = " & emp_id & " AND CONVERT(date,CHECKTIME,110) = '" & cur_pay_date.ToString("MM-dd-yyyy") & "'", "firstin")
                        bio_first_out = readDB("SELECT convert(time, CHECKTIME, 114) as firstout FROM biometrics WHERE convert(time, CHECKTIME, 114) < '" & second_in.ToString & "' AND CHECKTYPE = 'O' AND USERID = " & emp_id & " AND CONVERT(date,CHECKTIME,110) = '" & cur_pay_date.ToString("MM-dd-yyyy") & "'", "firstout")
                        bio_second_in = readDB("SELECT convert(time, CHECKTIME, 114) as secondin FROM biometrics WHERE convert(time, CHECKTIME, 114) > '" & first_out.ToString & "' AND CHECKTYPE = 'I' AND USERID = " & emp_id & " AND CONVERT(date,CHECKTIME,110) = '" & cur_pay_date.ToString("MM-dd-yyyy") & "'", "secondin")
                        bio_second_out = readDB("SELECT convert(time, CHECKTIME, 114) as secondout FROM biometrics WHERE convert(time, CHECKTIME, 114) > '" & second_in.ToString & "' AND CHECKTYPE = 'O' AND USERID = " & emp_id & " AND CONVERT(date,CHECKTIME,110) = '" & cur_pay_date.ToString("MM-dd-yyyy") & "'", "secondout")
                        'holiday = readDB("SELECT type FROM holiday WHERE enable = 'Y' AND convert(varchar(5), date, 110) = '" & cur_pay_date.ToString("MM-dd") & "'", "type")

                        'Dim days_leave As Integer = readDB("SELECT days FROM leave WHERE emp_id = '" & emp_id & "' AND approve = 'Y' AND convert(varchar(10), from_leave, 110) = '" & cur_pay_date.ToString("MM-dd-yyyy") & "'", "days")

                        'MsgBox("holiday: " & holiday & ": " & emp_id & "curdate: " & cur_pay_date)

                        If (bio_first_in.ToString <> "00:00:00" And bio_first_out.ToString <> "00:00:00") Then
                            'number of hours base on employee schedule time

                            If (bio_first_in <= first_in And bio_first_out >= first_out) Then 'if not late and not early out
                                TS = sched_TS_first
                                hour = TS.Hours
                                mins = TS.Minutes
                                total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                first_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                first_late = (first_late / 60)
                            ElseIf (bio_first_in <= first_in And bio_first_out < first_out) Then 'if not late but early out
                                TS = first_out - bio_first_out
                                hour = TS.Hours
                                mins = TS.Minutes
                                total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                first_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                first_late = Integer.Parse(sched_TS_first.Hours.ToString("00")) - (first_late / 60)
                            ElseIf (bio_first_in > first_in And bio_first_out > first_out) Then 'if late but not early out
                                TS = bio_first_in - first_in
                                hour = TS.Hours
                                mins = TS.Minutes
                                total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                first_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                first_late = Integer.Parse(sched_TS_first.Hours.ToString("00")) - (first_late / 60)
                            ElseIf (bio_first_in > first_in And bio_first_out < first_out) Then 'if late or early out
                                Dim first_timein_late As TimeSpan = bio_first_in - first_in
                                Dim first_timeout_late As TimeSpan = bio_first_out - first_out
                                TS = (first_timein_late + first_timeout_late)
                                hour = TS.Hours
                                mins = TS.Minutes
                                total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                first_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                first_late = Integer.Parse(sched_TS_first.Hours.ToString("00")) - (first_late / 60)
                            End If

                        ElseIf (bio_first_in.ToString = "00:00:00" And bio_first_out.ToString = "00:00:00") Then
                            first_late = 0
                        Else
                            If (bypass = 1) Then
                                If (bio_first_in <= first_in) Then
                                    TS = sched_TS_first
                                    hour = TS.Hours
                                    mins = TS.Minutes
                                    total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                    first_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                    first_late = (first_late / 60)
                                ElseIf (bio_first_in > first_in) Then
                                    TS = bio_first_in - first_in
                                    hour = TS.Hours
                                    mins = TS.Minutes
                                    total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                    first_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                    first_late = Integer.Parse(sched_TS_first.Hours.ToString("00")) - (first_late / 60)
                                End If
                            End If
                        End If

                        If (bio_second_in.ToString <> "00:00:00" And bio_second_out.ToString <> "00:00:00") Then
                            'number of hours base on employee schedule time

                            If (bio_second_in <= second_in And bio_second_out >= second_out) Then 'if not late and not early out
                                TS = sched_TS_second
                                hour = TS.Hours
                                mins = TS.Minutes
                                total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                second_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                second_late = (second_late / 60)
                            ElseIf (bio_second_in <= second_in And bio_second_out < second_out) Then 'if not late but early out
                                TS = second_out - bio_second_out
                                hour = TS.Hours
                                mins = TS.Minutes
                                total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                second_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                second_late = Integer.Parse(sched_TS_second.Hours.ToString("00")) - (second_late / 60)
                            ElseIf (bio_second_in > second_in And bio_second_out > second_out) Then 'if late but not early out
                                TS = bio_second_in - second_in
                                hour = TS.Hours
                                mins = TS.Minutes
                                total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                second_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                second_late = Integer.Parse(sched_TS_second.Hours.ToString("00")) - (second_late / 60)
                            ElseIf (bio_second_in > second_in And bio_second_out < second_out) Then 'if late or early out
                                Dim second_timein_late As TimeSpan = bio_second_in - second_in
                                Dim second_timeout_late As TimeSpan = bio_second_out - second_out
                                TS = (second_timein_late + second_timeout_late)
                                hour = TS.Hours
                                mins = TS.Minutes
                                total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                second_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                second_late = Integer.Parse(sched_TS_second.Hours.ToString("00")) - (second_late / 60)
                            End If

                        ElseIf (bio_second_in.ToString = "00:00:00" And bio_second_out.ToString = "00:00:00") Then
                            second_late = 0
                        Else
                            If (bypass = 1) Then
                                If (bio_second_out >= second_out) Then
                                    TS = sched_TS_second
                                    hour = TS.Hours
                                    mins = TS.Minutes
                                    total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                    second_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                    second_late = (second_late / 60)
                                ElseIf (bio_second_out < second_out) Then
                                    TS = second_out - bio_second_out
                                    hour = TS.Hours
                                    mins = TS.Minutes
                                    total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                                    second_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                                    second_late = Integer.Parse(sched_TS_second.Hours.ToString("00")) - (second_late / 60)
                                End If
                            End If
                        End If

                        'If days_leave <> 0 Then

                        '    TS = sched_TS_first + sched_TS_second
                        '    hour = TS.Hours
                        '    mins = TS.Minutes
                        '    total_time = ((hour.ToString("00") & ":" & mins.ToString("00")))
                        '    first_late = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                        '    first_late = (first_late / 60)

                        '    first_late = first_late * days_leave
                        'End If

                        total_working_hrs = first_late + second_late
                        'MsgBox(total_working_hrs & " - " & days_leave & " - " & cur_pay_date.ToString("MM-dd-yyyy"))
                        'If total_working_hrs <> 0 Then
                        'MsgBox(total_working_hrs & "emp_id: " & emp_id & " date: " & cur_pay_date)
                        updateDB("INSERT INTO work_time (emp_id, payroll_no, hours, date) VALUES (" & emp_id & ",'" & pay_id & "','" & total_working_hrs & "' ,'" & cur_pay_date & "')")
                        'End If
                    Next
                Loop
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            ' Close Connection
            myConnection.Close()
        End Try

        importBioDB.SplashScreenManager1.CloseForm()
    End Function


    Public Function PayrollComputations()
        'updateDB("DELETE FROM work_time WHERE payroll_no = '" & importBioDB.paynolbl.Text & "'")




        Dim pay_from As Date = readDB("SELECT from_date FROM payroll_info WHERE type='Regular' and status='Open'", "from_date")
        Dim pay_to As Date = readDB("SELECT to_date FROM payroll_info WHERE type='Regular' and status='Open'", "to_date")
        Dim pay_id As Integer = readDB("SELECT id FROM payroll_info WHERE type='Regular' and status='Open'", "id")

        Dim work_days As Integer = readDB("SELECT work_days FROM settings", "work_days")

        updateDB("DELETE FROM earnings WHERE payroll_no = '" & pay_id & "'")
        updateDB("DELETE FROM deduction WHERE payroll_no = '" & pay_id & "'")

        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader

        Dim emp_id As Integer
        Dim work_date As Date
        Dim work_hrs As Double
        Dim payroll_no As Integer
        Dim cola As Double

        Dim base_pay As Double
        Dim rate_hr As Double
        Dim gross_pay As Double
        Dim overtime As Integer = 0

        Dim desc As String = ""


        Try
            'importBioDB.SplashScreenManager1.ShowForm(GetType(progressbar))
            ' Open Connection
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = "SELECT * FROM work_time WHERE payroll_no ='" & pay_id & "'"
            rows = myCommand.ExecuteReader()



            If rows.HasRows Then
                Do While rows.Read()
                    emp_id = rows("emp_id")
                    work_date = rows("date")
                    payroll_no = rows("payroll_no")
                    work_hrs = rows("hours")

                    base_pay = readDB("SELECT base_pay FROM employees WHERE emp_id = '" & emp_id & "'", "base_pay") ' get base pay
                    cola = readDB("SELECT cola FROM employees WHERE emp_id = '" & emp_id & "'", "cola")
                    Dim overtime_from As DateTime = readDB("SELECT from_time FROM overtime WHERE emp_id = '" & emp_id & "' AND convert(varchar(10), from_time, 110) = '" & work_date.ToString("MM-dd-yyyy") & "' AND approve = 'Y'", "from_time")
                    Dim overtime_to As DateTime = readDB("SELECT to_time FROM overtime WHERE emp_id = '" & emp_id & "' AND convert(varchar(10), to_time, 110) = '" & work_date.ToString("MM-dd-yyyy") & "' AND approve = 'Y'", "to_time")
                    Dim first_in As TimeSpan = readDB("SELECT convert(time, first_in, 114) as first_in FROM schedule WHERE emp_id = '" & emp_id & "'", "first_in")
                    Dim first_out As TimeSpan = readDB("SELECT convert(time, first_out, 114) as first_out FROM schedule WHERE emp_id = '" & emp_id & "'", "first_out")
                    Dim second_in As TimeSpan = readDB("SELECT convert(time, second_in, 114) as second_in FROM schedule WHERE emp_id = '" & emp_id & "'", "second_in")
                    Dim second_out As TimeSpan = readDB("SELECT convert(time, second_out, 114) as second_out FROM schedule WHERE emp_id = '" & emp_id & "'", "second_out")
                    Dim restday As String = readDB("SELECT restday FROM restday WHERE emp_id = '" & emp_id & "' AND restday = '" & work_date.ToString("dddd") & "'", "restday")
                    Dim shift As String = readDB("SELECT shift FROM schedule WHERE emp_id = '" & emp_id & "'", "shift")
                    Dim holiday As String = readDB("SELECT type FROM holiday WHERE enable = 'Y' AND date = '" & work_date.ToString("MM-dd-yyyy") & "'", "type")

                    Dim days_leave As Double = readDB("SELECT days FROM leave WHERE emp_id = '" & emp_id & "' AND approve = 'Y' AND convert(date, from_leave, 110) <= '" & work_date.ToString("MM-dd-yyyy") & "' AND convert(date, to_leave, 110) >= '" & work_date.ToString("MM-dd-yyyy") & "'", "days")

                    Dim first_half As TimeSpan = first_out - first_in
                    Dim second_half As TimeSpan = second_out - second_in

                    Dim total_hrs As TimeSpan = first_half + second_half
                    Dim hr As Integer = total_hrs.Hours
                    Dim minute As Integer = total_hrs.Minutes
                    Dim total_time As String = ((hr.ToString("00") & ":" & minute.ToString("00")))
                    Dim total_minutes = CInt(Split(total_time, ":")(0)) * 60 + CInt((Split(total_time, ":")(1)))
                    Dim sched_wrk_hrs As Double = total_minutes / 60 'scheduled working hours
                    rate_hr = (base_pay / work_days) / sched_wrk_hrs ' rate per hour

                    If shift = "Night" Then
                        rate_hr = rate_hr * 1.1
                    End If

                    Dim over_time As TimeSpan = overtime_to - overtime_from
                    overtime = over_time.Hours
                    overtime = CInt(overtime.ToString("00"))
                    'MsgBox(emp_id & " - " & work_date.ToString("MM-dd-yyyy") & " - " & days_leave)
                    If work_hrs = 0 And holiday = "Regular" Then ' did not work on regular holiday
                        gross_pay = (rate_hr * sched_wrk_hrs) + cola
                        desc = "Regular Holiday"
                    ElseIf work_date.ToString("dddd") <> restday And holiday = "Regular" And work_hrs <> 0 And overtime = 0 Then ' did work on regular holiday
                        gross_pay = ((rate_hr * work_hrs) + cola) * 2
                        desc = "Work on RH [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") <> restday And holiday = "Regular" And overtime <> 0 And work_hrs <> 0 Then ' overtime work on regular holiday
                        gross_pay = (((rate_hr * work_hrs) + cola) * 2) + (rate_hr * overtime * 2.6)
                        desc = "Work on RH w/ OT [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") = restday And holiday = "Regular" And work_hrs <> 0 And overtime = 0 Then ' did work on regular holiday and rest day
                        gross_pay = (((rate_hr * work_hrs) + cola) * 2) + ((rate_hr * work_hrs) * 0.3)
                        desc = "Work on RH during RD [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") = restday And holiday = "Regular" And overtime <> 0 And work_hrs <> 0 Then 'overtime work on regular holiday and rest day
                        gross_pay = (((rate_hr * work_hrs) + cola) * 2) + ((rate_hr * work_hrs) * 0.3) + ((rate_hr * 2.6) * overtime * 1.3)
                        desc = "Work on RH during RD w/ OT [" & shift & " Shift]"
                    ElseIf work_hrs = 0 And holiday = "Special" Then 'did not work on Special holiday
                        gross_pay = (rate_hr * sched_wrk_hrs) + cola
                        desc = "Special Holiday"
                    ElseIf work_date.ToString("dddd") <> restday And holiday = "Special" And work_hrs <> 0 And overtime = 0 Then ' did work on Special holiday
                        gross_pay = ((rate_hr * 1.3) * work_hrs) + cola
                        desc = "Work on SH [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") <> restday And holiday = "Special" And overtime <> 0 And work_hrs <> 0 Then ' overtime work on Special holiday
                        gross_pay = (((rate_hr * 1.3) * work_hrs) + cola) + ((rate_hr * 1.3) * overtime)
                        desc = "Work on SH w/ OT [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") = restday And holiday = "Special" And work_hrs <> 0 And overtime = 0 Then ' did work on Special holiday and rest day
                        gross_pay = ((rate_hr * 1.5) * work_hrs) + cola
                        desc = "Work on SH during RD [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") = restday And holiday = "Special" And overtime <> 0 And work_hrs <> 0 Then 'overtime work on Special holiday and rest day
                        gross_pay = (((rate_hr * 1.5) * work_hrs) + cola) + ((rate_hr * 1.95) * overtime)
                        desc = "Work on SH during RD w/ OT [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") = restday And holiday = "" And work_hrs <> 0 And overtime = 0 Then ' working on restday
                        gross_pay = ((rate_hr * 1.3) * work_hrs) + cola
                        desc = "Work on RD [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") = restday And holiday = "" And overtime <> 0 And work_hrs <> 0 Then ' working on rest day and overtime
                        gross_pay = (((rate_hr * 1.3) * work_hrs) + cola) + ((rate_hr * 1.1) * overtime)
                        desc = "Work on RD w/ OT [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") <> restday And days_leave = 0 And holiday = "" And work_hrs <> 0 And overtime = 0 Then ' working regular day
                        gross_pay = (rate_hr * work_hrs) + cola
                        desc = "Regular Work [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") <> restday And holiday = "" And days_leave = 0 And overtime <> 0 And work_hrs <> 0 Then ' working regular day with over time
                        gross_pay = ((rate_hr * work_hrs) + cola) + ((rate_hr * 1.25) * overtime)
                        desc = "Regular Work w/ OT [" & shift & " Shift]"
                    ElseIf work_date.ToString("dddd") <> restday And holiday = "" And overtime = 0 And days_leave <> 0 And work_hrs <> 0 Then ' half day work and halfday leave
                        Dim get_leave_hrs As Double = work_hrs + (sched_wrk_hrs * days_leave)
                        gross_pay = (rate_hr * get_leave_hrs) + cola
                        desc = "Halfday Work w/ Leave"
                    ElseIf work_date.ToString("dddd") <> restday And holiday = "" And overtime = 0 And days_leave <> 0 And work_hrs = 0 Then ' leave pay
                        gross_pay = (rate_hr * sched_wrk_hrs) + cola
                        desc = "Leave"
                    ElseIf days_leave = 0 And holiday = "" And work_hrs = 0 And work_date.ToString("dddd") <> restday And overtime = 0 Then 'absent
                        gross_pay = 0
                        desc = "Absent"
                    ElseIf work_date.ToString("dddd") = restday And work_hrs = 0 Then
                        gross_pay = 0
                        desc = "Rest Day"
                    Else
                        gross_pay = 0
                        desc = "Something went wrong."
                    End If
                    If Double.IsNaN(gross_pay) Then
                        gross_pay = 0
                    End If
                    'MsgBox(emp_id & " - " & gross_pay & " - " & payroll_no & " - " & desc & " - " & work_date.ToString("MM-dd-yyyy"))

                    updateDB("INSERT INTO earnings (emp_id, earning_type, amount, payroll_no, description, date) VALUES (" & emp_id & ",'WORK'," & gross_pay & " ," & payroll_no & ", '" & desc & "', '" & work_date.ToString("MM-dd-yyyy") & "')")



                Loop

            End If
            payrollGovernmentDeduction(pay_id)
            'updateDB("INSERT INTO deduction (emp_id, deduction_type,description, amount, payroll_no) VALUES (" & emp_id & ",'GVNMNT','PHILHEALTH'," & philhealth & " ," & payroll_no & ")")
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            ' Close Connection
            myConnection.Close()
        End Try

        'importBioDB.SplashScreenManager1.CloseForm()
    End Function

    Public Function payrollGovernmentDeduction(ByVal pay_id As Integer)

        Dim philhealth As Double
        Dim sss As Double
        Dim tax As Double
        Dim base_pay As Double
        Dim pagibig As Double

        Dim fieldinfo() As String = {"base_pay", "philhealth", "sss", "pagibig", "tax"}
        Dim resultinfo() As Object

        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader
        Try
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = "SELECT emp_id FROM work_time WHERE payroll_no ='" & pay_id & "' GROUP BY emp_id"
            rows = myCommand.ExecuteReader()



            If rows.HasRows Then
                Do While rows.Read()
                    Dim emp_id As Integer = rows("emp_id")

                    resultinfo = readDBMulti("SELECT * FROM employees WHERE emp_id = '" & emp_id & "'", fieldinfo)
                    base_pay = resultinfo(0) ' get base pay

                    'goverment deductions
                    philhealth = readDB("SELECT amount FROM philhealth WHERE phil_from <= '" & base_pay & "' AND phil_to >= '" & base_pay & "'", "amount")
                    pagibig = readDB("SELECT amount FROM pagibig WHERE pagibig_from <= '" & base_pay & "' AND pagibig_to >= '" & base_pay & "'", "amount")
                    sss = readDB("SELECT amount FROM sss WHERE sss_from <= '" & base_pay & "' AND sss_to >= '" & base_pay & "'", "amount")
                    tax = readDB("SELECT amount FROM tax WHERE tax_from <= '" & base_pay & "' AND tax_to >= '" & base_pay & "'", "amount")

                    If resultinfo(1) <> 0 Then
                        updateDB("INSERT INTO deduction (emp_id, deduction_type,description, amount, payroll_no) VALUES (" & emp_id & ",'GVNMNT','PHILHEALTH'," & philhealth & " ," & pay_id & ")")
                    End If

                    If resultinfo(2) <> 0 Then
                        updateDB("INSERT INTO deduction (emp_id, deduction_type,description, amount, payroll_no) VALUES (" & emp_id & ",'GVNMNT','SSS'," & sss & " ," & pay_id & ")")
                    End If

                    If resultinfo(3) <> 0 Then
                        updateDB("INSERT INTO deduction (emp_id, deduction_type,description, amount, payroll_no) VALUES (" & emp_id & ",'GVNMNT','PAG-IBIG'," & pagibig & " ," & pay_id & ")")
                    End If

                    If resultinfo(4) <> 0 Then
                        updateDB("INSERT INTO deduction (emp_id, deduction_type,description, amount, payroll_no) VALUES (" & emp_id & ",'GVNMNT','HTAX'," & tax & " ," & pay_id & ")")
                    End If

                    payrollMiscDeduction(emp_id, pay_id)
                Loop
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            ' Close Connection
            myConnection.Close()
        End Try
    End Function

    Public Function payrollMiscDeduction(ByVal emp_id As Integer, ByVal pay_id As Integer)
        Dim amount_deduct As Double

        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader
        Try
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = "SELECT * FROM misc_deduction WHERE emp_id ='" & emp_id & "' AND auto = 'Y'"
            rows = myCommand.ExecuteReader()

            If rows.HasRows Then
                Do While rows.Read()
                    Dim empid As Integer = rows("emp_id")
                    Dim desc As String = rows("description")
                    Dim amount As Double = rows("amount")
                    Dim auto As String = rows("auto")
                    Dim deduct_type As String = rows("deduct_type")
                    Dim amount_type As Double = rows("amount_type")
                    Dim misc_id As Integer = rows("id")

                    Dim field() As String = {"amount"}
                    Dim result() As String
                    Dim paid As Double
                    result = readDBMulti("SELECT SUM(amount) as amount FROM deduction WHERE misc_id = " & misc_id & " GROUP BY misc_id", field)
                    If result IsNot Nothing Then
                        paid = result(0)
                    Else
                        paid = 0
                    End If

                    If paid < amount Then


                        If deduct_type = "PERCENT" Then
                            amount_deduct = amount * amount_type
                        ElseIf deduct_type = "FIX" Then
                            amount_deduct = amount_type
                        End If

                        updateDB("INSERT INTO deduction (emp_id, deduction_type, description, amount, payroll_no, misc_id) VALUES (" & emp_id & ",'MISC','" & desc & "'," & amount_deduct & " ," & pay_id & ", " & misc_id & ")")
                        result = readDBMulti("SELECT SUM(amount) as amount FROM deduction WHERE misc_id = " & misc_id & " GROUP BY misc_id", field)
                        If result IsNot Nothing Then
                            If result(0) > amount Then
                                Dim adjusted As Double = result(0) - amount
                                updateDB("UPDATE deduction SET amount = " & adjusted & " WHERE misc_id = " & misc_id & " AND payroll_no = " & pay_id)
                            End If
                        End If
                    End If
                Loop
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            ' Close Connection
            myConnection.Close()
        End Try
    End Function

    Public Function readDBMulti(ByVal SQLstatement As String, ByVal field() As String)
        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader
        Try
            ' Open Connection
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = SQLstatement
            rows = myCommand.ExecuteReader()
            Dim fieldarray((field.Length - 1)) As Object

            If rows.HasRows Then
                Dim x As Integer
                Do While rows.Read()
                    Dim query_result As String
                    Dim i As Integer
                    For i = 0 To (field.Length - 1)
                        If Not IsDBNull(rows(field(i))) Then
                            fieldarray(i) = rows(field(i))
                        End If
                    Next
                Loop
                Return fieldarray
            Else
                Return fieldarray
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            ' Close Connection
            myConnection.Close()
        End Try
    End Function

    Public Function displaySchedule(ByVal id As Integer)
        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader
        Try
            ' Open Connection
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = "SELECT * FROM schedule WHERE emp_id = '" & id & "'"
            rows = myCommand.ExecuteReader()


            If rows.HasRows Then

                Do While rows.Read()
                    If Not IsDBNull(rows) Then
                        With employeeForm
                            .txtFirstTimein.Text = Format(Convert.ToDateTime(rows("first_in").ToString), "hh:mm tt")
                            .txtFirstTimeout.Text = Format(Convert.ToDateTime(rows("first_out").ToString), "hh:mm tt")
                            .txtSecondTimein.Text = Format(Convert.ToDateTime(rows("second_in").ToString), "hh:mm tt")
                            .txtSecondTimeout.Text = Format(Convert.ToDateTime(rows("second_out").ToString), "hh:mm tt")
                            .dpShift.Text = rows("shift")
                        End With
                    End If
                Loop


            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            ' Close Connection
            myConnection.Close()
        End Try
    End Function

    Public Function displayRestDay(ByVal id As Integer)
        Dim myConnection As New SqlConnection(SQLServerConnection)
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        Dim rows As SqlDataReader
        Try
            ' Open Connection
            myConnection.Open()
            ' Execute NonQuery To Create Table
            myCommand.CommandText = "SELECT * FROM restday WHERE emp_id = '" & id & "'"
            rows = myCommand.ExecuteReader()

            With employeeForm
                If rows.HasRows Then

                    Do While rows.Read()
                        If Not IsDBNull(rows) Then

                            If (rows("restday") = "Monday") Then
                                .txtMonday.Checked = True

                            End If
                            If (rows("restday") = "Tuesday") Then
                                .txtTuesday.Checked = True

                            End If
                            If (rows("restday") = "Wednesday") Then
                                .txtWednesday.Checked = True

                            End If
                            If (rows("restday") = "Thursday") Then
                                .txtThursday.Checked = True

                            End If
                            If (rows("restday") = "Friday") Then
                                .txtFriday.Checked = True

                            End If
                            If (rows("restday") = "Saturday") Then
                                .txtSaturday.Checked = True

                            End If
                            If (rows("restday") = "Sunday") Then
                                .txtSunday.Checked = True

                            End If
                        End If
                    Loop

                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            ' Close Connection
            myConnection.Close()
        End Try
    End Function


    Public Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" &
        "{impersonationLevel=impersonate}!\\" &
        computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " &
        "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids =
        cpu_ids.Substring(2)

        Return cpu_ids
    End Function

End Module
