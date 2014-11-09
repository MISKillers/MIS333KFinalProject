
'Author: E. Clarissa Anjani Gondoprawiro
'Assignment: ASP 5 Clarissa's Cake Shop
'Date: October 7, 2014
'Program Description: To learn how to hook forms

Imports System.Data
Imports System.Data.SqlClient

Public Class ClassEmployeeDB
    'these variables are internal to object
    Dim mDatasetEmployee As New DataSet
    Dim mstrQuery As String
    Dim mdbdataAdapter As New SqlDataAdapter 'show us the connection
    Dim mdbConn As SqlConnection
    Dim mstrConnection As String = "workstation id=COMPUTER;packet size=4096;data source=MISSQL.mccombs.utexas.edu;integrated security=False; initial catalog=mis333k_msbcs549;user id=msbcs549;password=1234567Asdf"
    Dim mMyView As New DataView
    'Public Sub GetAllEmployees()
    '    'name: GetAllEmployees()
    '    'purpose: get all employeess from database
    '    'arguments: n/a
    '    'returns: n/a
    '    'author: E. Clarissa Anjani Gondoprawiro

    '    mstrQuery = "select * from tblemployee"
    '    SelectQuery(mstrQuery)
    'End Sub

    'Public Sub Addemployees(strUsername As String, strPassword As String, strFirstName As String, strInitial As String, strLastName As String, strAddress As String, strCity As String, strState As String, strZip As String, strEmail As String, strPhone As String)
    '    'name: Addemployees()
    '    'purpose: insert items into the dataset
    '    'arguments: n/a
    '    'returns: n/a
    '    'author: E. Clarissa Anjani Gondoprawiro


    '    'build insert query
    '    'neet to change to str
    '    mstrQuery = "INSERT INTO tblemployee (UserName, Password, FirstName, MI, LastName, Address, City, State, ZipCode, EmailAddr, Phone) VALUES (" & _
    '  "'" & strUsername & "', " & _
    '  "'" & strPassword & "', " & _
    '  "'" & strFirstName & "', " & _
    '  "'" & strInitial & "', " & _
    '  "'" & strLastName & "', " & _
    '  "'" & strAddress & "', " & _
    '  "'" & strCity & "', " & _
    '  "'" & strState & "', " & _
    '  "'" & strZip & "', " & _
    '  "'" & strEmail & "', " & _
    '  "'" & strPhone & "')"

    '    UpdateDB(mstrQuery)

    'End Sub

    Public Sub UpdateDB(ByVal strQuery As String)
        'name: UpdateDB
        'purpose: run given query to update database
        'argument: one string(any SQL statement)
        'return: nothing
        'author: E. Clarissa Anjani Gondoprawiro

        Try
            'make connection using the connection string above
            mdbConn = New SqlConnection(mstrConnection)
            Dim dbCommand As New SqlCommand(strQuery, mdbConn)

            'open the connection
            mdbConn.Open()

            'run the query
            dbCommand.ExecuteNonQuery()

            'close the connection
            mdbConn.Close()

        Catch ex As Exception
            Throw New Exception("query is " & strQuery.ToString & " error is " & ex.Message)
        End Try
    End Sub

    'Public Function CheckEmpID(intEmpID As Integer) As Boolean
    '    'name: CheckUsername
    '    'purpose:  check if username is correct
    '    'arguments: strUserName
    '    'returns: boolean
    '    'author: E. Clarissa Anjani Gondoprawiro

    '    mstrQuery = "select * from tblemployee where EmpID ='" & intEmpID & "'"
    '    SelectQuery(mstrQuery)
    '    'check the number of records in dataset
    '    'if one return true
    '    'if zero return false

    '    If mDatasetEmployee.Tables("tblemployee").Rows.Count = 0 Then
    '        Return False
    '    Else
    '        Return True
    '    End If

    'End Function


    'Public Function CheckPassword(strPassword As String) As Boolean
    '    '    'name: CheckPassword
    '    '    'purpose: check if password is correct
    '    '    'arguments: strPassword
    '    '    'returns: boolean
    '    '    'author: E. Clarissa Anjani Gondoprawiro

    '    'DO NOT RUN A QUERY HERE

    '    'simply compare the password on the form to the password in row zero of data set
    '    'if it matches
    '    'return true
    '    'else
    '    'return false

    '    If strPassword = mDatasetEmployee.Tables("tblemployee").Rows(0).Item("password") Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    Public Function CheckEmpID(strEmployeeID As String) As Boolean
        'name:   CheckUsername()
        'purpose:  check if username is correct
        'arguments: strUserName()
        'returns: boolean
        'author: E. Clarissa Anjani Gondoprawiro

        mMyView.RowFilter = "EmpID = '" & strEmployeeID & "'"

        'Check number records is 
        'if one return true
        'if zero return false
        If mDatasetEmployee.Tables("tblemployee").Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

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


    'define a public read only property for the outside world to access the dataset filled by this class
    Public ReadOnly Property EmpDataset() As DataSet
        Get
            'return Dataset to user
            Return mDatasetEmployee
        End Get
    End Property


    'define a public read only property for the outside world to access the dataset filled by this class
    Public ReadOnly Property MyView() As DataView
        Get
            'return Dataset to user
            Return mMyView
        End Get
    End Property

    Public Sub GetEmployeeRecord(ByVal strParamValue As String)
        'name: GetEmployeeRecord
        'purpose: Get Employee Record id
        'arguments: strParamValue
        'returns: none
        'author: E.Clarissa Anjani Gondoprawiro

        RunSPwithOneParam("usp_Employee_Get_All", "@EmpID", strParamValue)
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
            Me.mDatasetEmployee.Clear()

            ' OPEN CONNECTION AND FILL DATASET
            mdbDataAdapter.Fill(mDatasetEmployee, "tblemployee")

            ' copy dataset to dataview
            mMyView.Table = mDatasetEmployee.Tables("tblemployee")

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
            Me.mDatasetEmployee.Clear()
            ' OPEN CONNECTION AND FILL DATASET
            mdbDataAdapter.Fill(mDatasetEmployee, "tblemployee")
            ' copy dataset to dataview
            mMyView.Table = mDatasetEmployee.Tables("tblemployee")
        Catch ex As Exception
            Throw New Exception("stored procedure is " & strName.ToString & " error is " & ex.Message)
        End Try
    End Sub

    Public Sub SelectQuery(ByVal strQuery As String)
        'name: SelectQuery
        'purpose: run any select query and fill dataset
        'arguments: strQuery
        'returns: n/a
        'author: E. Clarissa Anjani Gondoprawiro

        Try
            'define data connection and data adapter
            mdbConn = New SqlConnection(mstrConnection)
            mdbdataAdapter = New SqlDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear the dataset before filling
            mDatasetEmployee.Clear()

            'fill the dataset
            mdbdataAdapter.Fill(mDatasetEmployee, "tblemployee")

            'close the connection
            mdbConn.Close()

        Catch ex As Exception
            Throw New Exception("query is " & strQuery.ToString & " error is " & ex.Message)
        End Try

    End Sub

    Public Function GetEmpType(intEmpType As Integer) As Integer

        intEmpType = CInt(mDatasetEmployee.Tables("tblemployee").Rows(0).Item("EmpType"))

        Return intEmpType
    End Function
End Class
