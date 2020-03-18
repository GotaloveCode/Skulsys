Imports System.Data.SqlClient
Public Class useraccounts
    Dim sqlcon As New sqlcontrol
    Private Sub btnvalidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvalidate.Click
        Dim adm As String = txtadmin.Text.Trim
        Dim adpas As String = txtadpas.Text.Trim
        Dim salt As String = "skulsys"
        Dim rawSalted As String = salt & adpas
        Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha1 As New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
        Dim hashedadPw As String = Convert.ToBase64String(hashedPwBytes)
        Dim cmd As New SqlCommand("select User_Name,Password from tblusers where User_Name = @user and [Password] = @pass", sqlcon.Conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = adm
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedadPw
        Try
            Dim readr As SqlDataReader = cmd.ExecuteReader
            If readr.HasRows Then
                Panel3.Enabled = True
                MessageBox.Show("Admin " + adm + " valid" & Environment.NewLine & "Proceed to create account", "Admin Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("The account " + adm + " is not a valid admin account", "Admin Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlcon.Conn.Close()
        End Try
    End Sub

    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click
        Dim adm As String = txtadmin.Text.Trim
        Dim usr As String = txtusr.Text.Trim
        Dim pas As String = txtpas.Text.Trim
        Dim salt As String = "skulsys"
        Dim rawSalted As String = salt & pas
        Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha1 As New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
        Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)
        Dim admin As Integer = 0
        If chkadmin.Checked = True Then
            admin = 1
        End If
        If usr.Length = 0 Then
            MessageBox.Show("Please enter Username", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pas.Length < 8 Then
            MessageBox.Show("Please enter password at least 8 characters", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pas.Length < 8 Then
            MessageBox.Show("Please enter confirm password at least 8 characters", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtpas.Text <> txtpas2.Text Then
            MessageBox.Show("Password mismatch", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cmd As New SqlCommand("select User_Name,Password from tblusers where User_Name = @user and [Password] = @pass", sqlcon.Conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = usr
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPw
              Try
                Dim dr As SqlDataReader = cmd.ExecuteReader
                If dr.HasRows = True Then
                    MessageBox.Show("User account already exists", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtusr.Text = ""
                    txtpas.Text = ""
                    txtpas2.Text = ""
                Else
                    Dim cmd2 As New SqlCommand("insert into tblusers([User_Name],[Password],[Date_created],[Admin],[Created by])values ('" & usr & "','" & hashedPw & "',CURRENT_TIMESTAMP," & admin & ",'" & adm & "')", sqlcon.Conn)
                    cmd2.ExecuteNonQuery()
                    MessageBox.Show("User Registration successful.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                sqlcon.Conn.Close()
            End Try
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Dispose()
        LoginForm1.Show()
    End Sub

    Private Sub AdmissionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmissionsToolStripMenuItem.Click
        admissions.Show()
        Me.Dispose()
    End Sub

    Private Sub AcademicsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcademicsToolStripMenuItem.Click
        academics.Show()
        Me.Dispose()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()
        Me.Dispose()
    End Sub
End Class