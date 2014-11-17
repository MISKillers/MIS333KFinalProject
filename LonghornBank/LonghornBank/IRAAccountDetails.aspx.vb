Public Class IRAAccountDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If radPriceSearch.SelectedValue = "Custom Range" Then
            txtPriceLower.Visible = True
            txtPriceUpper.Visible = True
        End If
    End Sub

  

End Class