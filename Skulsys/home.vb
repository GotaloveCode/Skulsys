Public Class home
    Dim log As New LoginForm1
    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbluser.Text = user.ToUpper
    End Sub
    Private _user As String
    Public Property [user]() As String
        Get 'grabing the passd uname
            Return _user
        End Get
        Set(ByVal Value As String)
            _user = Value
        End Set
    End Property

    Private Sub AcademicsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcademicsToolStripMenuItem.Click
        Me.Hide()
        academics.Show()
    End Sub

    Private Sub AdmissionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmissionsToolStripMenuItem.Click
        admissions.Show()
        Me.Dispose()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        useraccounts.Show()
        Me.Dispose()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Dispose()
        LoginForm1.Show()
    End Sub

End Class