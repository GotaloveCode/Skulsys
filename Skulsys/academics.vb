Public Class academics
    Private _passeduser As String
    Public Property [Passeduser]() As String
        Get 'grabing the passd uname
            Return _passeduser
        End Get
        Set(ByVal Value As String)
            _passeduser = Value
        End Set
    End Property

    Private Sub AdmissionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        admissions.Show()
        Me.Close()
    End Sub

    Private Sub academics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbltime.Text = DateTime.Now.ToLongDateString

    End Sub

    
    Private Sub AdmissionsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmissionsToolStripMenuItem.Click
        admissions.Show()
        Me.Dispose()
    End Sub

    
    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        useraccounts.Show()
        Me.Dispose()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Dispose()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()
        Me.Dispose()
    End Sub
End Class