Imports System.Net.Mail


Public Class ForgotPassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        'define an instance of the customer DB class
        Dim CustDB As New ClassCustomerDB

        'CustDB.GetCustomerEmail(txtEmail.Text)


        'If txtEmail.Text <> CustDB.MyView(0).Item("EmailAddr").ToString Then
        '    lblError.Visible = True
        '    lblError.Text = ("That email does not match records in our database")
        '    SessionCount()
        '    Exit Sub
        'End If

        'If txtBirthday.Text <> CustDB.MyView(0).Item("DOB").ToString Then
        '    lblError.Visible = True
        '    lblError.Text = ("Incorrect Birthday Year")
        '    Exit Sub
        'End If


        lblError.Text = "Your password has been sent to your email"


    End Sub
End Class

'Partial Class _Default
'    Inherits Systems.Web.UI.Page

'    Dim Msg As MailMessage = New MailMessage()
'    Dim MailObj As New SmtpClient("smtp.mccombs.utexas.edu")
'    Msg.From = New MailAddress(strEmail, strName)
'    Msg.To.Add(New MailAddress(strEmail, strName))
'    Msg.IsBodyHtml = "False"
'    Msg.Body = ("Hi valued customer! This is your password")
'    Msg.Subject = "Password"
'    MailObj.Send(Msg)
'    Msg.To.Clear

'End Class
