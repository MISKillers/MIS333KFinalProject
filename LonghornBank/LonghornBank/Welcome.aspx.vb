Public Class Welcome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            'EmpDB.GetAllEmployees()
            Session("Count") = 0
        End If
    End Sub

    Dim mintCount As Integer

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'define an instance of the customer DB class
        Dim CustDB As New ClassCustomerDB
        Dim Format As New ClassFormat

        'declare strings for checking password and username
        Dim strUsername As String

        'Get AccountType to see if he/she has registered
        'Dim intAccountType As Integer = CInt(Session("AccountType"))

        strUsername = txtUsernameLogin.Text

        CustDB.GetCustomerUsername(txtUsernameLogin.Text)

        If txtUsernameLogin.Text = "" Then
            'error message and exit
            lblError.Visible = True
            lblError.Text = ("Please enter a username")
            SessionCount()
            Exit Sub
        End If

        If txtPasswordLogin.Text = "" Then
            'error message and exit
            lblError.Visible = True
            lblError.Text = ("Please enter a password")
            SessionCount()
            Exit Sub
        End If

        If CustDB.MyView.Count = 0 Then
            lblError.Visible = True
            lblError.Text = "Incorrect username"
            SessionCount()
            Exit Sub
        End If

        If txtUsernameLogin.Text <> CustDB.MyView(0).Item("Username").ToString Then
            lblError.Visible = True
            lblError.Text = ("Incorrect Username")
            SessionCount()
            Exit Sub
        End If

        If txtPasswordLogin.Text <> CustDB.MyView(0).Item("Password").ToString Then
            lblError.Visible = True
            lblError.Text = ("Incorrect Password")
            Exit Sub
        End If

        'Session("RecordID") = CustDB.GetRecordID(txtUsernameLogin.Text)

        'Session("AccountType") = CustDB.GetAccountType(txtUsernameLogin.Text)

        '        'set session EmpType
        '        'hard code for now YOU CANT DO THIS
        '        'if login goes well, put session in here and go to view customers
        '        Session("AccountType") = CustDB.CustDataset.Tables("tblCustomers").Rows(0).Item("AccountType").ToString

        '        If intAccountType = Nothing Then
        '            'call Employee Home
        '            Response.Redirect("RegisterAccount.aspx")
        '        Else:
        '            'call manager home
        '            Response.Redirect("MyAccounts.aspx")
        '        End If

        'call search form
        Response.Redirect("MyAccounts.aspx")

        'empty password and username
        txtUsernameLogin.Text = ""
        txtPasswordLogin.Text = ""
    End Sub


    Public Function SessionCount()
        'name: SessionCount()
        'purpose: Count number of sessions to give error when customer fails to log in too many times
        'arguments: n/a
        'returns: n/a
        'author: E. Clarissa Anjani Gondoprawiro

        'if bad login add 1 to session count
        Session("Count") = CInt(Session("Count")) + 1
        mintCount = CInt(Session("Count"))

        'if 3 times bad, disable login button, end if
        If mintCount > 2 Then
            btnLogin.Enabled = False
            lblError.Visible = True
            lblError.Text = "Too many incorrect attempts"
        End If

        Return True
    End Function

    Protected Sub btnSignUp_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSignUp_Click1(sender As Object, e As EventArgs) Handles btnSignUp.Click

    End Sub

    Protected Sub txtUsernameLogin_TextChanged(sender As Object, e As EventArgs) Handles txtUsernameLogin.TextChanged

    End Sub

    Protected Sub txtPasswordLogin_TextChanged(sender As Object, e As EventArgs) Handles txtPasswordLogin.TextChanged

    End Sub
End Class