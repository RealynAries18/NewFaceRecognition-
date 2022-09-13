using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using Neurotec;
using Neurotec.Biometrics;

namespace NewFaceRecognition
{



    public partial class RegisterEmployee
    {
        private MySqlCommand cmd = new MySqlCommand();
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=admin;database=hrms");
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter1;

        public RegisterEmployee()
        {
            adapter1 = new MySqlDataAdapter("SELECT * FROM hrms.tbl_personal_info", connection);
            InitializeComponent();
        }
        // Dim conn As DBConnection()


        public bool execCommand(MySqlCommand cmd)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // REM 'Logout'
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // REM 'Add Employee'
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var add_command = new MySqlCommand("INSERT INTO `table_employee`( `EMPLOYEEID`, `LAST_NAME`, `FIRST_NAME`, `MIDDLE_NAME`, `OFFICE`) VALUES (@EMPLOYEEID, @LAST_NAME, @FIRST_NAME, @MIDDLE_NAME, @OFFICE)", connection);
            add_command.Parameters.Add("@EMPLOYEEID", MySqlDbType.VarChar).Value = EMPLOYEEID.Text;
            add_command.Parameters.Add("@LAST_NAME", MySqlDbType.VarChar).Value = LAST_NAME.Text;
            add_command.Parameters.Add("@FIRST_NAME", MySqlDbType.VarChar).Value = FIRST_NAME.Text;
            add_command.Parameters.Add("@MIDDLE_NAME", MySqlDbType.VarChar).Value = MIDDLE_NAME.Text;
            add_command.Parameters.Add("@OFFICE", MySqlDbType.VarChar).Value = OFFICE.Text;

            if (execCommand(add_command))
            {
                MessageBox.Show("Employee Registered");
            }

            else
            {
                MessageBox.Show("Error saving employee");
            }

            adapter1.Fill(table);

            dataEmployeeList.DataSource = table;

            // REM 'Clear Textbox'
            EMPLOYEEID.Text = "";
            LAST_NAME.Text = "";
            FIRST_NAME.Text = "";
            MIDDLE_NAME.Text = "";
            OFFICE.Text = "";


        }

        // REM 'Search Employee'
        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            var search_command = new MySqlCommand("SELECT * FROM `table_employee` WHERE `EMPLOYEEID` = @EMPLOYEEID", connection);
            search_command.Parameters.Add("@EMPLOYEEID", MySqlDbType.Int64).Value = EMPLOYEEID.Text;
            // REM 'search_command.Parameters.Add("@LAST_NAME", MySqlDbType.Int64).Value = LAST_NAME.Text

            var adapter = new MySqlDataAdapter(search_command);
            var table = new DataTable();
            adapter.Fill(table);

            LAST_NAME.Text = Conversions.ToString(table.AsEnumerable().ElementAtOrDefault(0)[2]);
            FIRST_NAME.Text = Conversions.ToString(table.AsEnumerable().ElementAtOrDefault(0)[3]);
            MIDDLE_NAME.Text = Conversions.ToString(table.AsEnumerable().ElementAtOrDefault(0)[4]);
            OFFICE.Text = Conversions.ToString(table.AsEnumerable().ElementAtOrDefault(0)[5]);
            dataEmployeeList.DataSource = table;

            if (execCommand(search_command))
            {
                MessageBox.Show("Employee Number Not Found", "Showing Related Employee Number");
            }

            else
            {
                MessageBox.Show("Employee Registered");
            }

        }


        public void RegisterEmployee_Load(object sender, EventArgs e)
        {
            var connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=admin");
            var table = new DataTable();
            var adapter = new MySqlDataAdapter("SELECT * FROM hrms.tbl_personal_info", connection);
            adapter.Fill(table);

            dataEmployeeList.DataSource = table;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=admin");
            var table = new DataTable();
            var adapter = new MySqlDataAdapter("SELECT * FROM hrms.tbl_personal_info", connection);
            adapter.Fill(table);

            dataEmployeeList.DataSource = table;

            // REM 'Clear Textbox'
            EMPLOYEEID.Text = "";
            LAST_NAME.Text = "";
            FIRST_NAME.Text = "";
            MIDDLE_NAME.Text = "";
            OFFICE.Text = "";
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            var update_command = new MySqlCommand("UPDATE `table_employee` SET `LAST_NAME`=@LAST_NAME,`FIRST_NAME`=@FIRST_NAME,`MIDDLE_NAME`=@MIDDLE_NAME,`OFFICE`=@OFFICE WHERE `EMPLOYEEID` = @EMPLOYEEID", connection);
            update_command.Parameters.Add("@EMPLOYEEID", MySqlDbType.VarChar).Value = EMPLOYEEID.Text;
            update_command.Parameters.Add("@LAST_NAME", MySqlDbType.VarChar).Value = LAST_NAME.Text;
            update_command.Parameters.Add("@FIRST_NAME", MySqlDbType.VarChar).Value = FIRST_NAME.Text;
            update_command.Parameters.Add("@MIDDLE_NAME", MySqlDbType.VarChar).Value = MIDDLE_NAME.Text;
            update_command.Parameters.Add("@OFFICE", MySqlDbType.VarChar).Value = OFFICE.Text;

            if (execCommand(update_command))
            {
                MessageBox.Show("Employee Updated");
            }

            else
            {
                MessageBox.Show("Error updating employee");
            }

            adapter1.Fill(table);

            dataEmployeeList.DataSource = table;

            // REM 'Clear Textbox'
            EMPLOYEEID.Text = "";
            LAST_NAME.Text = "";
            FIRST_NAME.Text = "";
            MIDDLE_NAME.Text = "";
            OFFICE.Text = "";
        }
    }
}