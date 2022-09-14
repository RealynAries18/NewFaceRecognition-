using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verilook_Sample_App.Models;
using Verilook_Sample_App.Persistence;

namespace Verilook_Sample_App.Services.Face_Profile
{
    public class FaceProfileManager : IFaceProfileManager
    {

        private readonly IFaceProfilePersistenceManager _databaseManager;

        public FaceProfileManager(IFaceProfilePersistenceManager databaseManager)
        {
            _databaseManager = databaseManager;
        }


        public void Save(FaceProfile face) =>
            _databaseManager.SaveFaceProfile(face);
    }
}
