Public Class RegisterAccount
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If MyAccounts type is 0 need to go here
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Validations, initial deposit amount cannot be blank
        If chkCheckingAcc.Checked = True Then
            If txtDepositChecking.Text = "" Then
                lblErrorChecking.Text = "Initial Deposit Amount for Checking Account cannot be blank"
            End If
        End If
        If chkSavingAcc.Checked = True Then
            If txtDepositSavings.Text = "" Then
                lblErrorSavings.Text = "Initial Deposit Amount for Savings Account cannot be blank"
            End If
        End If
        If chkIRA.Checked = True Then
            If txtDepositIRA.Text = "" Then
                lblErrorIRA.Text = "Initial Deposit Amount for Individual Retirement Account cannot be blank"
            End If
        End If


        lblErrorIRA.Text = "*"
        lblErrorChecking.Text = "*"
        lblErrorSavings.Text = 
        lblMessage.Text = "Application for product has been successful"

        Response.AddHeader("Refresh", "4; URL=MyAccounts.aspx")
    End Sub
End Class