using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace NewFaceRecognition
{
    public partial class LOGIN
    {
        #region Declares
        private MySqlDataAdapter conAdpater;
        private DataTable dataTable;

        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBConnection.ConnDB();

            try
            {
                DBConnection.sql = "Select * FROM accounts WHERE username = '" + txtuser.Text + "' And password = '" + txtpass.Text + "'";
                DBConnection.cmd = new MySqlCommand(DBConnection.sql, DBConnection.conn);
                DBConnection.dr = DBConnection.cmd.ExecuteReader();
                DBConnection.dr.Read();

                if (string.IsNullOrEmpty(txtuser.Text) | string.IsNullOrEmpty(txtpass.Text))
                {
                    Interaction.MsgBox("Please fill ip the empty fields");
                    return;
                }
                // Redirect to Admin Account/Register,Update, Search Employee
                if (DBConnection.dr.HasRows == true)
                {
                    string lvl = DBConnection.dr["user_type"].ToString();
                    if (lvl == "admin")
                    {
                        Hide();
                        My.MyProject.Forms.RegisterEmployee.Show();
                    }

                    // Redirect to Time IN/OUT OF EMPLOYEES
                    else if (lvl == "user")
                    {
                        Hide();
                        My.MyProject.Forms.TimeInOut.Show();
                    }
                }
                else
                {
                    Interaction.MsgBox("LOGIN FAILED! Incorrect Username or Password", MsgBoxStyle.Critical);
                    txtuser.Clear();
                    txtpass.Clear();
                    txtuser.Focus();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}