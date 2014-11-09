Public Class ClassValidation
    'copy code on page 7

    Public Function CheckDigits(ByVal strIn As String) As Boolean
        'name: CheckDigits
        'purpose: check if string contains digits
        'arguments: strIn
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro

        'check to see that each character is 0-9
        Dim i As Integer
        Dim strOne As String

        For i = 0 To Len(strIn) - 1
            'get one character from the string
            strOne = strIn.Substring(i, 1)
            Select Case strOne
                'if the character is 0 -9, then keep going
                Case "0" To "9"
                    'if the character is anything else, stop looking and return false
                Case Else
                    'if bad data, return false
                    Return False
            End Select
        Next

        'if we made it through the loop, return true
        Return True

    End Function

    Public Function CheckLetters(ByVal strIn As String) As Boolean 'use for password, state, city
        'name:   Check Letters
        'purpose: check if string contains letters
        'arguments: strIn
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro


        Dim i As Integer
        Dim strOne As String

        For i = 0 To Len(strIn) - 1
            'get one character from the string
            strOne = strIn.Substring(i, 1)
            Select Case strOne.ToLower
                'if the character is a-z keep going
                Case "a" To "z"
                    'if the character is anything else, stop looking and return false
                Case Else
                    'if bad data, return false
                    Return False
            End Select
        Next

        'if we made it through the loop
        Return True

    End Function

    Public Function CheckPhone(strIn As String) As Boolean
        'name:   CheckPhone
        'purpose: check if phone number contains digits
        'arguments: strIn
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro


        'check length
        If strIn.Length <> 10 Then
            Return False
        End If

        'check to make sure its all digits
        If CheckDigits(strIn) = False Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function CheckZipcode(strIn As String) As Boolean
        'name:   CheckZipcode
        'purpose: check if zipcode has digits and has appropriate length
        'arguments: strIn
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro


        'check length
        If strIn.Length <> 5 And strIn.Length <> 9 Then
            Return False
        End If

        'check to make sure its all digits
        If CheckDigits(strIn) = False Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function CheckState(strIn As String) As Boolean
        'name:   CheckState
        'purpose: check if string contains letters and only two letters
        'arguments: strIn
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro

        'check length
        If strIn.Length <> 2 Then
            Return False
        End If

        'check to make sure its all letters
        If CheckLetters(strIn) = False Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function CheckInitial(strIn As String) As Boolean
        'name:   CheckInitial
        'purpose: check if initial has one letter
        'arguments: strIn
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro

        'check length
        If strIn.Length <> 1 Then
            Return False
        End If

        'check to make sure its all letters
        If CheckLetters(strIn) = False Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function CheckPassword(strIn As String) As Boolean
        'name:   CheckPhone
        'purpose: validate password
        'arguments: strIn
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro


        'password 6 - 10 characters, start with a letter, contain at least one letter and one number

        'check length
        If strIn.Length < 6 Or strIn.Length > 10 Then
            Return False
        End If

        'check to see that first character is a letter
        If CheckLetters(strIn.Substring(0, 1)) = False Then
            Return False
        End If

        'check to see that remainder of string has one digit
        Dim i As Integer
        Dim strOne As String
        Dim intDigitCount As Integer

        For i = 0 To Len(strIn) - 1
            'get one character from the string
            strOne = strIn.Substring(i, 1)
            Select Case strOne.ToLower
                'if the character is 0-9 keep going
                Case "0" To "9"
                    intDigitCount += 1
                Case "a" To "z"
                    'nothing goes here just keep going
                Case Else
                    'if bad data, return false
                    Return False
            End Select
        Next

        'was there at least ONE digit present in the string
        'boolean is not useful, counter is better 

        If intDigitCount > 0 Then
            Return True
        Else
            Return False
        End If


    End Function

End Class
