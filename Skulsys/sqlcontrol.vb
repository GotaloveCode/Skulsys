Imports System.Data.SqlClient
Public Class sqlcontrol
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
End Class
