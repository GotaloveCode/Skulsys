Imports System.Data.SqlClient

Public Class admissions
    Dim sqlcont As New sqlcontrol

    Private Sub AcademicsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcademicsToolStripMenuItem.Click
        academics.Show()
        Me.Close()
    End Sub

    Private Sub admissions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        lbltime.Text = DateTime.Now.ToLongDateString


    End Sub
    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedIndex = 3 Then
            Try
                Dim cmd As New SqlCommand("SELECT stud_id,(fname+ ' '+mname+' '+lname) as name FROM student_details WHERE stud_id NOT IN (SELECT stud_id FROM student_details WHERE hostel_id!=0)", sqlcont.Conn)
                Dim dr As SqlDataReader = cmd.ExecuteReader
                Dim dat As New DataTable
                Dim j As Integer
                For j = 0 To dat.Rows.Count - 1
                    dr.Read()
                Next
                dat.Load(dr)
                cmbstud.DisplayMember = "name"
                cmbstud.ValueMember = "stud_id"
                cmbstud.DataSource = dat
                dr.Close()
                sqlcont.Conn.Close()
                Dim sda As New SqlCommand("Select hostel_id,hostel_name,hostel_gender,capacity,in_use FROM hostel ORDER by hostel_name ASC", sqlcont.Conn)
                Dim datreadr As SqlDataReader = sda.ExecuteReader
                Dim dt As New DataTable
                Dim i As Integer
                For i = 0 To dt.Rows.Count - 1
                    datreadr.Read()
                Next
                dt.Load(datreadr)
                DataGridView1.DataSource = dt
                DataGridView1.AutoGenerateColumns = True
                DataGridView1.Refresh()
                sqlcont.Conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        ElseIf TabControl1.SelectedIndex = 4 Then
            Dim sqcm2 As New SqlCommand("SELECT stud_id,(fname+' '+mname+' '+lname) as name FROM student_details WHERE duty_id=0", sqlcont.Conn)
            Dim datreadr2 As SqlDataReader = sqcm2.ExecuteReader
            Dim dt2 As New DataTable
            Dim k As Integer
            For k = 0 To dt2.Rows.Count - 1
                datreadr2.Read()
            Next
            dt2.Load(datreadr2)
            cmbstud1.ValueMember = "stud_id"
            cmbstud1.DisplayMember = "name"
            cmbstud1.DataSource = dt2
            sqlcont.Conn.Close()
            Dim sqcm3 As New SqlCommand("select * from duties", sqlcont.Conn)
            Dim datreadr3 As SqlDataReader = sqcm3.ExecuteReader
            Dim dt3 As New DataTable
            Dim l As Integer
            For l = 0 To dt3.Rows.Count - 1
                datreadr3.Read()
            Next
            dt3.Load(datreadr3)
            Dim column As New DataColumn
            column.ColumnName = "Remaining"
            column.DataType = GetType(System.Int16)
            dt3.Columns.Add(column)
            dt3.Columns("Remaining").Expression = "[required_manpower] - [allocated]"
            DataGridView2.DataSource = dt3
            DataGridView2.Refresh()
            cmbduty.ValueMember = "duty_id"
            cmbduty.DisplayMember = "duty"
            cmbduty.DataSource = dt3
            sqlcont.Conn.Close()
        End If
        Me.DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub

    Private Sub btnhostel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhostel.Click
        Dim hostid As Integer = cmbhostel.SelectedValue
        Dim stud_id As Integer = cmbstud.SelectedValue
        Dim sqcm As New SqlCommand("UPDATE hostel SET in_use=in_use+1 WHERE hostel_id=@hostid", sqlcont.Conn)
        sqcm.CommandType = CommandType.Text
        sqcm.Parameters.Add("@hostid", SqlDbType.Int).Value = hostid
        Dim rowcount As Integer = sqcm.ExecuteNonQuery()
        sqlcont.Conn.Close()
        Dim sqcm1 As New SqlCommand("UPDATE student_details SET hostel_id=@hostid where stud_id=@stud_id", sqlcont.Conn)
        sqcm1.CommandType = CommandType.Text
        sqcm1.Parameters.Add("@stud_id", SqlDbType.Int).Value = stud_id
        sqcm1.Parameters.Add("@hostid", SqlDbType.Int).Value = hostid
        Dim rowcount2 As Integer = sqcm1.ExecuteNonQuery()
        sqlcont.Conn.Close()
        If rowcount > 0 And rowcount2 > 0 Then
            MessageBox.Show("Successfully updated " + rowcount.ToString + " records")
        End If

    End Sub

    Private Sub btnduty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnduty.Click
        Try
            Dim dutyid As Integer = cmbduty.SelectedValue
            Dim stud_id2 As Integer = cmbstud1.SelectedValue
            Dim sqcm4 As New SqlCommand("UPDATE duties SET allocated=allocated+1 where duty_id=@dutyid", sqlcont.Conn)
            sqcm4.CommandType = CommandType.Text
            sqcm4.Parameters.Add("@dutyid", SqlDbType.Int).Value = dutyid
            MessageBox.Show(dutyid, "test1")
            Dim rowcount3 As Integer = sqcm4.ExecuteNonQuery()
            sqlcont.Conn.Close()
            Dim sqcm6 As New SqlCommand("UPDATE student_details SET duty_id=@dutyid2 where stud_id=@stud_id", sqlcont.Conn)
            sqcm4.CommandType = CommandType.Text
            sqcm4.Parameters.Add("@dutyid2", SqlDbType.Int).Value = dutyid
            sqcm4.Parameters.Add("@stud_id", SqlDbType.Int).Value = stud_id2
            MessageBox.Show(dutyid & stud_id2, "test1")
            Dim rowcount4 As Integer = sqcm4.ExecuteNonQuery()
            sqlcont.Conn.Close()
            If rowcount3 > 0 And rowcount4 > 0 Then
                MessageBox.Show("Successfully updated " + rowcount4.ToString + " records")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmbstud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstud.SelectedIndexChanged
        Dim sqcm5 As New SqlCommand("Select hostel.hostel_id,hostel.hostel_name From hostel Inner Join student_details On student_details.gender = hostel.hostel_gender where stud_id=" & cmbstud.SelectedValue.ToString & "", sqlcont.Conn)
        Dim datreadr5 As SqlDataReader = sqcm5.ExecuteReader
        Dim dt5 As New DataTable
        Dim n As Integer
        For n = 0 To dt5.Rows.Count - 1
            datreadr5.Read()
        Next
        dt5.Load(datreadr5)
        cmbhostel.ValueMember = "hostel_id" 'asign value & display member b4 datasource to avoid errors
        cmbhostel.DisplayMember = "hostel_name"
        cmbhostel.DataSource = dt5
        
    End Sub
End Class