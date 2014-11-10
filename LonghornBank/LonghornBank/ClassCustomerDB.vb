
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

    'Public Function CheckUsername(strUsername As String) As Boolean
    '    'name:   CheckUsername()
    '    'purpose:  check if username is correct
    '    'arguments: strUserName()
    '    'returns: boolean
    '    'author: E. Clarissa Anjani Gondoprawiro

    '    mMyView.RowFilter = "Email = '" & strUsername & "'"

    '    'Check number records is 
    '    'if one return true
    '    'if zero return false
    '    If mDatasetCustomer.Tables("tblCustomers").Rows.Count = 0 Then
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function

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
        'name: GetEmployeeRecord
        'purpose: Get Employee Record id
        'arguments: strParamValue
        'returns: none
        'author: E.Clarissa Anjani Gondoprawiro

        RunSPwithOneParam("usp_Customers_Get_By_EmailAddr", "@email", strParamValue)
    End Sub

    Public Sub GetAllCustomers()
        'name: GetEmployeeRecord
        'purpose: Get Employee Record id
        'arguments: strParamValue
        'returns: none
        'author: E.Clarissa Anjani Gondoprawiro

        RunProcedure("usp_customers_get_all")
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


    Public Sub RunProcedure(ByVal strName As String)
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

    
    Public Sub AddCustomerStoredProcedureShorterParams(mPassword, mLastname, mFirstName, mMI, mAddress, mCity, mState, mZipcode, mEmailAddr, mPhone) 'mDOB
        ' CREATES INSTANCES OF THE CONNECTION AND COMMAND OBJECT
        Dim objConnection As New SqlConnection(mstrConnection)

        ' Tell SQL server the name of the stored procedure you will be executing
        Dim objCommand As New SqlDataAdapter("usp_Customer_Insert", objConnection)
        Try
            ' SETS THE COMMAND TYPE TO "STORED PROCEDURE"
            objCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' ADD PARAMETER(S) TO SPROC
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@password", mPassword))
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@lastname", mLastname))
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@firstname", mFirstName))
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@MI", mMI))
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@address", mAddress))
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@city", mCity))
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@state", mState))
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@zipcode", mZipcode))
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@emailaddr", mEmailAddr))
            objCommand.SelectCommand.Parameters.Add(New SqlParameter("@phone", mPhone))
            'objCommand.SelectCommand.Parameters.Add(New SqlParameter("@DOB", mDOB))

            ' OPEN CONNECTION AND RUN INSERT QUERY
            objCommand.SelectCommand.Connection = objConnection
            objConnection.Open()
            objCommand.SelectCommand.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            Throw New Exception(" error is " & ex.Message)
        End Try

    End Sub




    Public Function GetCustomerNumber(intCustomerNumber As Integer) As Integer

        intCustomerNumber = CInt(mDatasetCustomer.Tables("tblCustomers").Rows(0).Item("Email"))

        Return intCustomerNumber
    End Function
End Class