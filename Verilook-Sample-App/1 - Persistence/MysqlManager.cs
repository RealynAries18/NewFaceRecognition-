using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verilook_Sample_App.Models;
using static Verilook_Sample_App.Shared.Prompts;

namespace Verilook_Sample_App.Persistence
{
    public class MysqlManager : IFaceProfilePersistenceManager
    {
        //private MySqlConnection _connection;

        public MysqlManager(string connectionString)
        {
            //_connection = new MySqlConnection(connectionString);
        }


        public IEnumerable<FaceProfile> GetAllFaceProfile()
        {
            var faceProfiles = new List<FaceProfile>();
            //_connection.Open();
            //try
            //{
            //    using (MySqlDataReader reader = new MySqlCommand("SELECT * FROM faceprofile;", _connection).ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            var face = new FaceProfile()
            //            {
            //                Id = reader.GetString(0),
            //                Active = reader.GetBoolean(1),
            //                Admin = reader.GetBoolean(2),
            //            };
            //            face.SetFaceSubject((byte[])reader.GetValue(3));

            //            faceProfiles.Add(face);
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    ShowError(ex.Message, ex.Source);
            //}
            //finally
            //{
            //    _connection.Close();
            //}

            return faceProfiles;
        }

        public void SaveFaceProfile(FaceProfile face)
        {
            //_connection.Open();
            //try
            //{
            //    MySqlCommand command = new MySqlCommand("REPLACE INTO faceprofile (id,active,admin,face) VALUES (?,?,?,?)", _connection);
            //    command.Parameters.AddWithValue("p1", face.Id);
            //    command.Parameters.AddWithValue("p2", face.Active);
            //    command.Parameters.AddWithValue("p3", face.Admin);
            //    command.Parameters.Add("p4", MySqlDbType.Binary).Value = face.ConvertToInsertableFaceSubject();
            //    command.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    ShowError(ex.Message, ex.Source);
            //}
            //finally
            //{
            //    _connection.Close();
            //}


        }


    }
}
