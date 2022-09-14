using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verilook_Sample_App.Models;
using Verilook_Sample_App.Persistence;

namespace Verilook_Sample_App.Services.Face_Profile
{
    public class FaceProfileProvider : IFaceProfileProvider
    {
        private readonly IFaceProfilePersistenceManager _databaseManager;

        public FaceProfileProvider(IFaceProfilePersistenceManager databaseManager)
        {
            _databaseManager = databaseManager;
        }


        public IEnumerable<FaceProfile> Collect() =>
            _databaseManager.GetAllFaceProfile();
    }
}
