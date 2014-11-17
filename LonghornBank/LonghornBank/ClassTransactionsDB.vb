Public Class ClassTransactionsDB
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
End Class
