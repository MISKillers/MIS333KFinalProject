Public Class CheckingAccountDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvCheckingTransactions.SelectedIndexChanged
        'retrieve manage customer page
        'Create session with RecordID for next form
        'Cell 1 because it's in the second column(0,1,2..)

        'GET TRANS NUMBER FROM URL!!!
        Session("RecordID") = gvCheckingTransactions.SelectedRow.Cells(1).Text

        'call the next form or webpage
        Response.Redirect("DisputeTransaction.aspx")
    End Sub
End Class