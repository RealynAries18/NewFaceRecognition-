Imports MySql.Data.MySqlClient

Module DBConnection
    Public sql As String
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public conn As New MySqlConnection

    Public Sub ConnDB()
        conn.Close()
        Try
            conn.ConnectionString = "datasource=localhost;port=3306;username=root;password=admin;database=employeedb"
            conn.Open()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module



'Public Class DBConnection
REM LOGIN CONNECTION
'Dim con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=employeedb")
'Public Function open() As MySqlConnection
'     Try
'con.Open()
'Catch ex As Exception
'MessageBox.Show(ex.Message)
'End Try
'Return con
'End Function

'Public Function close() As MySqlConnection
'Try
'con.Close()
'Catch ex As Exception
'MessageBox.Show(ex.Message)
'End Try
'Return con
'End Function


'End Class