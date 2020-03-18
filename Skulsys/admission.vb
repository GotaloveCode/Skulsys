Imports System.Data.SqlClient
Public Class admission
    Dim sqlcont As New sqlcontrol
    Private Sub admission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dob.Format = DateTimePickerFormat.Custom
        admissionYr.Format = DateTimePickerFormat.Custom

        cmbStudentStatus.Items.Add(New CListItem("Fresh Admission", "Fresh Admission"))
        cmbStudentStatus.Items.Add(New CListItem("Transfer", "transfer"))
        cmbStudentStatus.Items.Add(New CListItem("Re-admission after suspension", "suspension"))
        cmbStudentStatus.Items.Add(New CListItem("Re-admission after expulsion", "expulsion"))
        cmbStudentStatus.Items.Add(New CListItem("Registration of existing students", "existing"))



    End Sub
    Dim fname = txtfname.Text.Trim.ToString
    Dim lname = txtsurname.Text.Trim.ToString
    Dim mname = txtmname.Text.Trim.ToString
    Dim oname = txtoname.Text.Trim.ToString
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim studentactive As Integer = 0
        Dim gender As String
        If rActiveYes.Checked Then
            studentactive = 1
        End If
        If rmale.Checked Then
            gender = "male"
        ElseIf rfemale.Checked Then
            gender = "female"
        Else
            gender = ""
        End If
        If txtfname.Text.Length = 0 And txtsurname.Text.Length = 0 Then
            MessageBox.Show("Please enter surname and 1st name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf IsNumeric(txtfname.Text) Then
            MessageBox.Show("Please enter a valid 1st name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf IsNumeric(txtsurname.Text) Then
            MessageBox.Show("Please enter a valid surname", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf rmale.Checked = False And rfemale.Checked = False Then
            MessageBox.Show("Please select gender", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf dob.Value > Date.Now Then
            MessageBox.Show("Please select valid date of birth", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf rActiveYes.Checked = False And rActiveNo.Checked = False Then
            MessageBox.Show("Please select student active status", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim sqlcmd As New SqlCommand("SELECT stud_id FROM student_details WHERE fname=@fname AND mname=@mname AND lname=@lname AND others=@oname", sqlcont.Conn)
            sqlcmd.CommandType = CommandType.Text
            sqlcmd.Parameters.AddWithValue("@fname", fname)
            sqlcmd.Parameters.AddWithValue("@mname", mname)
            sqlcmd.Parameters.AddWithValue("@lname", lname)
            sqlcmd.Parameters.AddWithValue("@oname", oname)
            Dim affectedrows As Integer = sqlcmd.ExecuteReader.RecordsAffected
            sqlcont.Conn.Close()
            If affectedrows > 0 Then
                MessageBox.Show("A Student with the same name already exists." & Environment.NewLine & "A Student may only be registered once", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim sqlcmd2 As New SqlCommand("insert into student_details (fname,mname,lname,others,gender,dob,active,admission_year) values (@fname,@mname,@lname,@oname,@gender,@dob,@active,@admission_year)", sqlcont.Conn)
                sqlcmd2.CommandType = CommandType.Text
                sqlcmd2.Parameters.AddWithValue("@fname", fname)
                sqlcmd2.Parameters.AddWithValue("@mname", mname)
                sqlcmd2.Parameters.AddWithValue("@lname", lname)
                sqlcmd2.Parameters.AddWithValue("@oname", oname)
                sqlcmd2.Parameters.AddWithValue("@gender", gender)
                sqlcmd2.Parameters.AddWithValue("@dob", dob.Value.Date)
                sqlcmd2.Parameters.AddWithValue("@active", studentactive)
                sqlcmd2.Parameters.AddWithValue("@admission_year", admissionYr.Value.Year)
                sqlcmd2.ExecuteNonQuery()
                MessageBox.Show("Student" & fname & " " & mname & " " & lname & " has been registered successfully" & Environment.NewLine & "Proceed to upload student photo if available", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnBrowse.Focus()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clear student details groupbox
        For Each element As Control In GroupBox1.Controls
            If TypeOf element Is TextBox Then
                element.Text = ""
            End If
            If TypeOf element Is ComboBox Then
                Dim cmbx As ComboBox = element
                cmbx.SelectedIndex = -1
            End If
            If TypeOf element Is GroupBox Then
                For Each elementchild As Control In Grpgender.Controls
                    If TypeOf elementchild Is RadioButton Then
                        Dim rbtn As RadioButton = elementchild
                        rbtn.Checked = False
                    End If
                Next
                For Each elementchild As Control In Grpdiet.Controls
                    If TypeOf elementchild Is RadioButton Then
                        Dim rbtn As RadioButton = elementchild
                        rbtn.Checked = False
                    End If
                Next
            End If
        Next

        'clear sys parameters
        For Each ctrl As Control In GroupBox4.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim cmbx As ComboBox = ctrl
                cmbx.SelectedIndex = -1
            End If
            If TypeOf ctrl Is GroupBox Then
                For Each elementchild As Control In GrpStudentActive.Controls
                    If TypeOf elementchild Is RadioButton Then
                        Dim rbtn As RadioButton = elementchild
                        rbtn.Checked = False
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim openfiledialog As OpenFileDialog = New OpenFileDialog
        'Using openfiledialog As New OpenFileDialog
        Dim fd As FileDialog = openfiledialog
        fd.Title = "Browse for student photo"
        fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        txtphoto.Text = fd.FileName
        'End Using
    End Sub
End Class