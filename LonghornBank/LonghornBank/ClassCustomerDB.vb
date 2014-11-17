
'Author: E. Clarissa Anjani Gondoprawiro
'Assignment: ASP 2 Clarissa's Cake Shop
'Date: September 18, 2014
'Program Description: To access customer's data by logging in
Imports System.Data
Imports System.Data.SqlClient



Public Class ClassCustomerDB
    'these variables are internal to object
    Dim mDatasetCustomer As New DataSet
    Dim mstrQuery As String
    Dim mdbdataAdapter As New SqlDataAdapter 'show us the connection
    Dim mdbConn As SqlConnection
    Dim mstrConnection As String = "workstation id=COMPUTER;packet size=4096;data source=MISSQL.mccombs.utexas.edu;integrated security=False; initial catalog=mis333k_msbcs549;user id=msbcs549;password=1234567Asdf"
    Dim mMyView As New DataView
    'declaration for finding max customer number
    Dim mDatasetMaxCustomerNumber As New DataSet
    Dim mMyCustomerNumberView As New DataView

    Public Function CheckPassword(strPassword As String) As Boolean
        'name: CheckPassword
        'purpose: check if password is correct
        'arguments: strPassword
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro

        'Do not run a query here
        'simple compare the password on the form to the password in row zero of the dataset
        'it it matches, return true
        'else, return false
        If strPassword = mMyView(0).Item("Password").ToString Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckEmail(strEmail As String) As Boolean
        'name:   CheckUsername()
        'purpose:  check if username is correct
        'arguments: strUserName()
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro

        mMyView.RowFilter = "Email = '" & strEmail & "'"

        'Check number records is 
        'if one return true
        'if zero return false
        If mDatasetCustomer.Tables("tblCustomers").Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function CheckBirthday(strPassword As String) As Boolean
        'name: CheckPassword
        'purpose: check if password is correct
        'arguments: strPassword
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro

        'Do not run a query here
        'simple compare the password on the form to the password in row zero of the dataset
        'it it matches, return true
        'else, return false
        If strPassword = mMyView(0).Item("DOB").ToString Then
            Return True
        Else
            Return False
        End If
    End Function


    'define a public read only property for the outside world to access the dataset filled by this class
    Public ReadOnly Property CustomerDataset() As DataSet
        Get
            'return Dataset to user
            Return mDatasetCustomer
        End Get
    End Property


    'define a public read only property for the outside world to access the dataset filled by this class
    Public ReadOnly Property MyView() As DataView
        Get
            'return Dataset to user
            Return mMyView
        End Get
    End Property

    Public Sub GetCustomerEmail(ByVal strParamValue As String)
        'name: GetCustomerEmail
        'purpose: Get customer email to sign in
        'arguments: strParamValue
        'returns: none
        'author: E.Clarissa Anjani Gondoprawiro

        RunSPwithOneParam("usp_Customers_Get_By_EmailAddr", "@email", strParamValue)
    End Sub

    Public Function GetMaxCustomerNumber()
        'name: GetMaxCustomerNumber
        'purpose: Get customernumber to increment for the customer sign up
        Dim intMaxCustomerNumber As Integer

        RunProcedureMaxCustomerNumber("usp_Get_Max_CustomerNumber")
        intMaxCustomerNumber = mDatasetMaxCustomerNumber.Tables("tblCustomers").Rows(0).Item(0)
        Return intMaxCustomerNumber
    End Function

    Public Sub InsertCustomer(strCustomerNumber As String, strPassword As String, strLastName As String, strFirstName As String, strInitial As String, strAddress As String, strZipcode As String, strEmail As String, strPhone As String, strBirthday As String)
        Dim aryNames As New ArrayList
        Dim aryValues As New ArrayList

        aryNames.Add("@CustomerNumber")
        aryNames.Add("@Password")
        aryNames.Add("@LastName")
        aryNames.Add("@FirstName")
        aryNames.Add("@MI")
        aryNames.Add("@Address")
        aryNames.Add("@ZipCode")
        aryNames.Add("@EmailAddr")
        aryNames.Add("@Phone")
        aryNames.Add("@DOB")

        aryValues.Add(strCustomerNumber)
        aryValues.Add(strPassword)
        aryValues.Add(strLastName)
        aryValues.Add(strFirstName)
        aryValues.Add(strInitial)
        aryValues.Add(strAddress)
        aryValues.Add(strZipcode)
        aryValues.Add(strEmail)
        aryValues.Add(strPhone)
        aryValues.Add(strBirthday)

        'call the SP to insert the record
        UseSPforInsertOrUpdateQuery("usp_Customer_Insert", aryNames, aryValues)

    End Sub

    Public Sub GetAllCustomers()
        'name: GetEmployeeRecord
        'purpose: Get Employee Record id
        'arguments: strParamValue
        'returns: none
        'author: E.Clarissa Anjani Gondoprawiro

        RunProcedureGetAllCustomers("usp_customers_get_all")
    End Sub

    Public Sub RunProcedureGetAllTransactions(ByVal strAccountNumber As String)
        'author: Katie Seo

        ' CREATES INSTANCES OF THE CONNECTION AND COMMAND OBJECT
        Dim objConnection As New SqlConnection(mstrConnection)
        ' Tell SQL server the name of the stored procedure you will be executing
        Dim mdbDataAdapter As New SqlDataAdapter(strAccountNumber, objConnection)
        Try
            ' SETS THE COMMAND TYPE TO "STORED PROCEDURE"
            mdbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            ' clear dataset
            Me.mDatasetCustomer.Clear()
            ' OPEN CONNECTION AND FILL DATASET
            mdbDataAdapter.Fill(mDatasetCustomer, "tblTransactions")
            ' copy dataset to dataview
            mMyView.Table = mDatasetCustomer.Tables("tblTransactions")
        Catch ex As Exception
            Throw New Exception("stored procedure is " & strAccountNumber.ToString & " error is " & ex.Message)
        End Try
    End Sub

    Public Sub GetAllTransactions()

    End Sub

    Public Sub RunSPwithOneParam(ByVal strSPName As String, ByVal strParamName As String, ByVal strParamValue As String)
        ' purpose to run a stored procedure with one parameter
        ' inputs:  stored procedure name, parameter name, parameter value
        ' returns: dataset filled with correct records

        ' CREATES INSTANCES OF THE CONNECTION AND COMMAND OBJECT
        Dim objConnection As New SqlConnection(mstrConnection)
        ' Tell SQL server the name of the stored procedure you will be executing
        Dim mdbDataAdapter As New SqlDataAdapter(strSPName, objConnection)
        Try
            ' SETS THE COMMAND TYPE TO "STORED PROCEDURE"
            mdbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure

            ' ADD PARAMETER(S) TO SPROC
            mdbDataAdapter.SelectCommand.Parameters.Add(New SqlParameter(strParamName, strParamValue))
            ' clear dataset
            Me.mDatasetCustomer.Clear()

            ' OPEN CONNECTION AND FILL DATASET
            mdbDataAdapter.Fill(mDatasetCustomer, "tblCustomers")

            ' copy dataset to dataview
            mMyView.Table = mDatasetCustomer.Tables("tblCustomers")

        Catch ex As Exception
            Throw New Exception("params are " & strSPName.ToString & " " & strParamName.ToString & " " & strParamValue.ToString & " error is " & ex.Message)
        End Try
    End Sub

    Public Sub RunProcedureMaxCustomerNumber(ByVal strName As String)
        'name: Run procedure
        'purpose: Run procedure to get all customers
        'arguments: strName
        'returns: n/a
        'author: E. Clarissa Anjani Gondoprawiro

        ' CREATES INSTANCES OF THE CONNECTION AND COMMAND OBJECT
        Dim objConnection As New SqlConnection(mstrConnection)
        ' Tell SQL server the name of the stored procedure you will be executing
        Dim mdbDataAdapter As New SqlDataAdapter(strName, objConnection)
        Try
            ' SETS THE COMMAND TYPE TO "STORED PROCEDURE"
            mdbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            ' clear dataset
            Me.mDatasetMaxCustomerNumber.Clear()
            ' OPEN CONNECTION AND FILL DATASET
            mdbDataAdapter.Fill(mDatasetMaxCustomerNumber, "tblCustomers")
            ' copy dataset to dataview
            mMyCustomerNumberView.Table = mDatasetMaxCustomerNumber.Tables("tblCustomers")
        Catch ex As Exception
            Throw New Exception("stored procedure is " & strName.ToString & " error is " & ex.Message)
        End Try
    End Sub

    'define a public read only property for the outside world to access the dataset filled by this class
    Public ReadOnly Property MaxCustomerNumberDataset() As DataSet
        Get
            'return Dataset to user
            Return mDatasetMaxCustomerNumber
        End Get
    End Property


    'define a public read only property for the outside world to access the dataset filled by this class
    Public ReadOnly Property MyCustomerNumberView() As DataView
        Get
            'return Dataset to user
            Return mMyCustomerNumberView
        End Get
    End Property


    Public Sub RunProcedureGetAllCustomers(ByVal strName As String)
        'name: Run procedure
        'purpose: Run procedure to get all customers
        'arguments: strName
        'returns: n/a
        'author: E. Clarissa Anjani Gondoprawiro

        ' CREATES INSTANCES OF THE CONNECTION AND COMMAND OBJECT
        Dim objConnection As New SqlConnection(mstrConnection)
        ' Tell SQL server the name of the stored procedure you will be executing
        Dim mdbDataAdapter As New SqlDataAdapter(strName, objConnection)
        Try
            ' SETS THE COMMAND TYPE TO "STORED PROCEDURE"
            mdbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            ' clear dataset
            Me.mDatasetCustomer.Clear()
            ' OPEN CONNECTION AND FILL DATASET
            mdbDataAdapter.Fill(mDatasetCustomer, "tblCustomers")
            ' copy dataset to dataview
            mMyView.Table = mDatasetCustomer.Tables("tblCustomers")
        Catch ex As Exception
            Throw New Exception("stored procedure is " & strName.ToString & " error is " & ex.Message)
        End Try
    End Sub

    Protected Sub UseSPforInsertOrUpdateQuery(ByVal strUSPName As String, ByVal aryParamNames As ArrayList, ByVal aryParamValues As ArrayList)
        'Purpose: Sort the dataview by the argument (general sub)
        'Arguments: Stored procedure name, Arraylist of parameter names, and  arraylist of parameter values
        'Returns: Nothing
        'Author: Rick Byars
        'Date: 4/03/12

        'Creates instances of the connection and command object
        Dim objConnection As New SqlConnection(mstrConnection)
        'Tell SQL server the name of the stored procedure
        Dim objCommand As New SqlDataAdapter(strUSPName, objConnection)
        Try
            'Sets the command type to stored procedure
            objCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Add parameters to stored procedure
            Dim index As Integer = 0
            For Each paramName As String In aryParamNames
                objCommand.SelectCommand.Parameters.Add(New SqlParameter(CStr(aryParamNames(index)), CStr(aryParamValues(index))))
                index = index + 1
            Next

            ' OPEN CONNECTION AND RUN INSERT/UPDATE QUERY
            objCommand.SelectCommand.Connection = objConnection
            objConnection.Open()
            objCommand.SelectCommand.ExecuteNonQuery()
            objConnection.Close()

            'Print out each element of our arraylists if error occured
        Catch ex As Exception
            Dim strError As String = ""
            Dim index As Integer = 0
            For Each paramName As String In aryParamNames
                strError = strError & "ParamName: " & CStr(aryParamNames(index))
                strError = strError & " ParamValue: " & CStr(aryParamValues(index))
                index = index + 1
            Next
            Throw New Exception(strError & " error message is " & ex.Message)
        End Try
    End Sub

    Public Function GetCustomerNumber(intCustomerNumber As Integer) As Integer

        intCustomerNumber = CInt(mDatasetCustomer.Tables("tblCustomers").Rows(0).Item("Email"))

        Return intCustomerNumber
    End Function

    Public Sub DoSortPriceSearch(ByVal strSortValue As String)
        If strSortValue = "Sort By Name" Then
            MyView.Sort = "lastname, firstname"
        Else
            MyView.Sort = "username"
        End If
    End Sub
End Class