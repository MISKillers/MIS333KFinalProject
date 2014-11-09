Public Class SignUp
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim CustDB As New ClassCustomerDB

        'call the SP to insert the record
        CustDB.AddCustomerStoredProcedureShorterParams(txtPassword.Text, txtLastName.Text, txtFirstName.Text, txtInitial.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text, txtEmail.Text, txtPhone.Text) 'txtBirthday.text'

        Response.Redirect("RegisterAccount.aspx")
    End Sub
End Class