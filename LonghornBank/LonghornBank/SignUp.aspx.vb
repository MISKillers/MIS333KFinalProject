Public Class SignUp
    Inherits System.Web.UI.Page

    Dim CustDB As New ClassCustomerDB
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim intCustomerNumber As Integer
        intCustomerNumber = CustDB.GetMaxCustomerNumber()
        txtCustNumber.Text = Convert.ToString(intCustomerNumber)

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim newCustomerNumber As Integer

        newCustomerNumber = txtCustNumber.Text + 1
        'call the SP to insert the record
        CustDB.InsertCustomer(newCustomerNumber, txtPassword.Text, txtLastName.Text, txtFirstName.Text, txtInitial.Text, txtAddress.Text, txtZip.Text, txtEmail.Text, txtPhone.Text, txtBirthday.Text)

        'if record is successfully added add 1 to the customer number


        Response.Redirect("RegisterAccount.aspx")
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCustNumber.TextChanged

    End Sub
End Class