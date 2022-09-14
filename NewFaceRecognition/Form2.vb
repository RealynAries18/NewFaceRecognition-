Imports Neurotec
Imports Neurotec.Biometrics
Imports MySql.Data.MySqlClient



Public Class RegisterEmployee
    Dim cmd As New MySqlCommand
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=hrms")
    Dim table As New DataTable()
    Dim adapter1 As New MySqlDataAdapter("SELECT * FROM employeedb.table_employee", connection)
    'Dim conn As DBConnection()


    Function execCommand(ByVal cmd As MySqlCommand) As Boolean
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        If cmd.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Function

    REM 'Logout'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    REM 'Add Employee'
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim add_command As New MySqlCommand("INSERT INTO `table_employee`( `EMPLOYEEID`, `LAST_NAME`, `FIRST_NAME`, `MIDDLE_NAME`, `OFFICE`) VALUES (@EMPLOYEEID, @LAST_NAME, @FIRST_NAME, @MIDDLE_NAME, @OFFICE)", connection)
        add_command.Parameters.Add("@EMPLOYEEID", MySqlDbType.VarChar).Value = EMPLOYEEID.Text
        add_command.Parameters.Add("@LAST_NAME", MySqlDbType.VarChar).Value = LAST_NAME.Text
        add_command.Parameters.Add("@FIRST_NAME", MySqlDbType.VarChar).Value = FIRST_NAME.Text
        add_command.Parameters.Add("@MIDDLE_NAME", MySqlDbType.VarChar).Value = MIDDLE_NAME.Text
        add_command.Parameters.Add("@OFFICE", MySqlDbType.VarChar).Value = OFFICE.Text

        If execCommand(add_command) Then
            MessageBox.Show("Employee Registered")

        Else
            MessageBox.Show("Error saving employee")
        End If

        adapter1.Fill(table)

        dataEmployeeList.DataSource = table

        REM 'Clear Textbox'
        EMPLOYEEID.Text = ""
        LAST_NAME.Text = ""
        FIRST_NAME.Text = ""
        MIDDLE_NAME.Text = ""
        OFFICE.Text = ""


    End Sub

    REM 'Search Employee'
    Private Sub btnSearchEmployee_Click(sender As Object, e As EventArgs) Handles btnSearchEmployee.Click
        Dim search_command As New MySqlCommand("SELECT * FROM `table_employee` WHERE `EMPLOYEEID` = @EMPLOYEEID", connection)
        search_command.Parameters.Add("@EMPLOYEEID", MySqlDbType.Int64).Value = EMPLOYEEID.Text
        REM 'search_command.Parameters.Add("@LAST_NAME", MySqlDbType.Int64).Value = LAST_NAME.Text

        Dim adapter As New MySqlDataAdapter(search_command)
        Dim table As New DataTable()
        adapter.Fill(table)

        LAST_NAME.Text = table(0)(2)
        FIRST_NAME.Text = table(0)(3)
        MIDDLE_NAME.Text = table(0)(4)
        OFFICE.Text = table(0)(5)
        dataEmployeeList.DataSource = table

        If execCommand(search_command) Then
            MessageBox.Show("Employee Number Not Found", "Showing Related Employee Number")

        Else
            MessageBox.Show("Employee Registered")
        End If

    End Sub


    Public Sub RegisterEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM employeedb.table_employee", connection)
        adapter.Fill(table)

        dataEmployeeList.DataSource = table
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=admin")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM employeedb.table_employee", connection)
        adapter.Fill(table)

        dataEmployeeList.DataSource = table

        REM 'Clear Textbox'
        EMPLOYEEID.Text = ""
        LAST_NAME.Text = ""
        FIRST_NAME.Text = ""
        MIDDLE_NAME.Text = ""
        OFFICE.Text = ""
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        Dim update_command As New MySqlCommand("UPDATE `table_employee` SET `LAST_NAME`=@LAST_NAME,`FIRST_NAME`=@FIRST_NAME,`MIDDLE_NAME`=@MIDDLE_NAME,`OFFICE`=@OFFICE WHERE `EMPLOYEEID` = @EMPLOYEEID", connection)
        update_command.Parameters.Add("@EMPLOYEEID", MySqlDbType.VarChar).Value = EMPLOYEEID.Text
        update_command.Parameters.Add("@LAST_NAME", MySqlDbType.VarChar).Value = LAST_NAME.Text
        update_command.Parameters.Add("@FIRST_NAME", MySqlDbType.VarChar).Value = FIRST_NAME.Text
        update_command.Parameters.Add("@MIDDLE_NAME", MySqlDbType.VarChar).Value = MIDDLE_NAME.Text
        update_command.Parameters.Add("@OFFICE", MySqlDbType.VarChar).Value = OFFICE.Text

        If execCommand(update_command) Then
            MessageBox.Show("Employee Updated")

        Else
            MessageBox.Show("Error updating employee")
        End If

        adapter1.Fill(table)

        dataEmployeeList.DataSource = table

        REM 'Clear Textbox'
        EMPLOYEEID.Text = ""
        LAST_NAME.Text = ""
        FIRST_NAME.Text = ""
        MIDDLE_NAME.Text = ""
        OFFICE.Text = ""
    End Sub
End Class