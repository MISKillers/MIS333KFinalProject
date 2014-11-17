Public Class EmployeeHome
    Inherits System.Web.UI.Page

    

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        Label1.Text = Calendar1.SelectedDate
    End Sub
End Class