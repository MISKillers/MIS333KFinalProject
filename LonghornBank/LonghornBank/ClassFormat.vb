'Author: E. Clarissa Anjani Gondoprawiro
'Assignment: ASP 2 Clarissa's Cake Shop
'Date: September 18, 2014
'Program Description: To access customer's data by logging in

Public Class ClassFormat
    'name: FormatPhone
    'purpose: To format the phone number into (###) ### - ####
    'arguments: any string
    'returns: any string
    'author: E. Clarissa Anjani Gondoprawiro

    Public Function FormatPhone(strIN As String) As String
        Dim strPhone As String
        Dim dblPhone As Double = CDbl(strIN)

        strPhone = dblPhone.ToString("(###)###-####")

        Return strPhone

    End Function
End Class
