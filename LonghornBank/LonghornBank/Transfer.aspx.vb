Public Class Transfer
    Inherits System.Web.UI.Page

    ' Dim DB As New DBCustomers


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '    DB.GetAllAccountsSP()

        'If IsPostBack = False Then

        '    'fill ddl
        '    ddlTransferFrom.DataSource = DB.CustDataset
        '    ddlTransferFrom.DataTextField = "AccountName, AcountNumber, AccountBalance"
        '    ddlTransferFrom.DataValueField = "Account"
        '    ddlTransferFrom.DataBind()

        '    ddlTransferTo.DataSource = DB.CustDataset
        '    ddlTransferTo.DataTextField = "AccountName, AcountNumber, AccountBalance"
        '    ddlTransferTo.DataValueField = "Account"
        '    ddlTransferTo.DataBind()

        'End If

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTransferFrom.SelectedIndexChanged

    End Sub

    Protected Sub btnMakeTranfer_Click(sender As Object, e As EventArgs) Handles btnMakeTranfer.Click
        'make sure there is enough money in account to transfer

        If ddlTransferFrom.SelectedIndex = ddlTransferTo.SelectedIndex Then
            MsgBox("Transfer successful")
        End If

    End Sub
End Class