using System;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace NewFaceRecognition
{

    static class DBConnection
    {
        public static string sql;
        public static MySqlCommand cmd;
        public static MySqlDataReader dr;
        public static MySqlConnection conn = new MySqlConnection();

        public static void ConnDB()
        {
            conn.Close();
            try
            {
                conn.ConnectionString = "datasource=localhost;port=3306;username=root;password=admin;database=employeedb";
                conn.Open();
            }

            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
        }
    }
}

