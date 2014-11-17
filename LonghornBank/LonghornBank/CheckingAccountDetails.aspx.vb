Public Class CheckingAccountDetails
    Inherits System.Web.UI.Page
    Dim CustDB As New ClassCustomerDB

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CustDB.GetAllUsingSP()

        SortAndBind()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvTransactions.SelectedIndexChanged
        'retrieve manage customer page
        'Create session with RecordID for next form
        'Cell 1 because it's in the second column(0,1,2..)

        'GET TRANS NUMBER FROM URL!!!
        Session("RecordID") = gvTransactions.SelectedRow.Cells(1).Text

        'call the next form or webpage
        Response.Redirect("DisputeTransaction.aspx")
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SortAndBind()

    End Sub


    Public Sub SortAndBind()

        CustDB.DoSortPriceSearch(radPriceSearch.SelectedItem.ToString)

        'then bind the grid to the data view
        gvTransactions.DataSource = CustDB.MyView
        gvTransactions.DataBind()

    End Sub
End Class