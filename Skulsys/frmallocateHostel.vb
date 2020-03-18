Imports System.Data.SqlClient
Public Class frmallocateHostel
    Dim sqlcont As New sqlcontrol
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
        cmbstud.ResetText()
        frmallocateHostel_Load(Nothing, Nothing)

        
    End Sub
      Private Sub frmallocateHostel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            If cmbstud.Items.Count = 0 Then
                btnhostel.Enabled = False
            End If
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
    End Sub

    Private Sub cmbstud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstud.SelectedIndexChanged
        Dim sqcm5 As New SqlCommand("Select hostel.hostel_id,hostel.hostel_name From hostel Inner Join student_details On student_details.gender = hostel.hostel_gender where student_details.stud_id =" & cmbstud.SelectedValue.ToString & " ", sqlcont.Conn)
        Dim datreadr5 As SqlDataReader = sqcm5.ExecuteReader
        Dim dt5 As New DataTable
        Dim n As Integer
        For n = 0 To dt5.Rows.Count - 1
            datreadr5.Read()
        Next
        dt5.Load(datreadr5)
        cmbhostel.ValueMember = "hostel_id" 'asign value & display member b4 datasource to avoid errors
        cmbhostel.DisplayMember = "hostel_name"
        Dim c As New BindingSource
        c.DataSource = dt5
        cmbhostel.DataSource = c

    End Sub
End Class