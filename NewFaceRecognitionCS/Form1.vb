Imports MySql.Data.MySqlClient
Public Class LOGIN
#Region "Declares"
    Dim conAdpater As MySqlDataAdapter
    Dim dataTable As DataTable

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ConnDB()

        Try
            sql = "Select * FROM accounts WHERE username = '" & txtuser.Text & "' And password = '" & txtpass.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If txtuser.Text = "" Or txtpass.Text = "" Then
                MsgBox("Please fill ip the empty fields")
                Exit Sub
            End If
            ' Redirect to Admin Account/Register,Update, Search Employee
            If dr.HasRows = True Then
                Dim lvl As String = dr("user_type").ToString
                If lvl = "admin" Then
                    Me.Hide()
                    RegisterEmployee.Show()

                    ' Redirect to Time IN/OUT OF EMPLOYEES
                ElseIf lvl = "user" Then
                    Me.Hide()
                    TimeInOut.Show()
                End If
            Else
                MsgBox("LOGIN FAILED! Incorrect Username or Password", MsgBoxStyle.Critical)
                txtuser.Clear()
                txtpass.Clear()
                txtuser.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

#End Region
End Class
