Public Class Parents
    Private Sub cmbmarital_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim marit As String = CType(cmbmarital.SelectedItem, CListItem).ItemData
        MessageBox.Show(marit)
    End Sub
    Private Sub Parents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbmarital.Items.Add(New CListItem("Single", "Fresh Admission"))
        cmbmarital.Items.Add(New CListItem("Married", 2))
        cmbmarital.Items.Add(New CListItem("Divorced", 3))
       
    End Sub
End Class