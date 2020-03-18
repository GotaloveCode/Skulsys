Imports System.Data.SqlClient
Public Class LoginForm1
    
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim user As String = txtuser.Text.Trim
        Dim pass As String = txtpass.Text.Trim
        Dim salt As String = "skulsys"
        'Create the salted hash.
        Dim rawSalted As String = salt & pass
        Dim sha1 As New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
        Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)

        If user = "" Then
            MessageBox.Show("Please Enter Your Username !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pass = "" Then
            MessageBox.Show("Please Enter Your Password !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cmd As New SqlCommand("select User_Name,Password from tblusers where User_Name = @user and [Password] = @pass", Conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPw
            Try
                Dim dr As SqlDataReader = cmd.ExecuteReader
                If dr.HasRows = True Then
                    dr.Read()
                    If user = dr.Item("User_Name").ToString And hashedPw = dr.Item("Password").ToString Then
                        MsgBox("Welcome " + user, MsgBoxStyle.Information)
                        txtuser.Text = ""
                        txtpass.Text = ""
                        Dim hm As New home
                        hm.user = user
                        Me.Hide()
                        hm.Show()
                        Me.Close()
                        'Dim Obj As New home
                        'Obj.Passeduser = user
                        'Obj.Show()

                    ElseIf user.ToLower = dr.Item("User_Name").ToString.ToLower And txtpass.Text.ToLower = dr.Item("Password").ToString.ToLower Then
                        MessageBox.Show("Login Failed." & Environment.NewLine & _
                                             "Username and password are casesensitive.", _
                                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Login Failed." & Environment.NewLine & _
                                             "No credentials matched", _
                                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub
    Public Function Conn() As SqlConnection
        Dim Xdoc As XDocument = XDocument.Load("C:\Users\Martin\Documents\Visual Studio 2008\Projects\sms.xml")
        Dim title = From t In Xdoc.Descendants("ServerName") Select t.Value
        Dim Servername1 As String = title.First
        Dim title2 = From t In Xdoc.Descendants("DatabaseName") Select t.Value
        Dim DatabaseName1 = title2.First()
        Dim title3 = From t In Xdoc.Descendants("UserID") Select t.Value
        Dim UserID1 = title3.First()
        Dim title4 = From t In Xdoc.Descendants("Password") Select t.Value
        Dim password1 = title4.First()
        Dim con As New SqlConnection("Server=" & Servername1 & ";Database=" & DatabaseName1 & ";User ID=" & UserID1 & ";Password=" & password1 & ";")
        con.Open()
        Return con
    End Function
    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("IF OBJECT_ID (N'tblusers', N'U') IS NOT NULL " & _
              "SELECT * from tblusers else CREATE TABLE [dbo].[tblusers]( " & _
            "[User_ID] [int] IDENTITY(1,1) NOT NULL," & _
            "[User_Name] [nvarchar](50) NULL," & _
            "[Password] [nvarchar](50) NULL," & _
            "[Date_created] [smalldatetime] NULL,[Admin] [bit] NOT null,[Created by] [nvarchar](50) NULL)", Conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Conn.Close()
        Try
            Dim cmd2 As New SqlCommand("if not exists (select * from tblusers where User_Name ='admin' and Password ='J7wgJU6uj9Mq1d1K0RBtMk4Sg3s=' )insert into tblusers ([User_Name],[Password],[Date_created],[Admin],[Created by])values ('admin','J7wgJU6uj9Mq1d1K0RBtMk4Sg3s=',CURRENT_TIMESTAMP,1,'admin')", Conn)
            '2014solutions
            cmd2.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Conn.Close()
    End Sub
End Class
