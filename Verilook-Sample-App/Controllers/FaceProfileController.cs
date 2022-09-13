using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verilook_Sample_App.Models;
using Verilook_Sample_App.Services;

namespace Verilook_Sample_App.Controllers
{
    public class FaceProfileController
    {
        IFaceProfileProvider _provider;
        IFaceProfileManager _manager;
        IVerilookManager _verilookManager;


        public FaceProfileController(IFaceProfileProvider provider, IFaceProfileManager manager, IVerilookManager verilookManager)
        {
            _provider = provider;
            _manager = manager;
            _verilookManager = verilookManager;
        }

        public async Task<bool> EnrollUser(string id)
        {
            FaceProfile face = new FaceProfile()
            {
                Id = id,
                Active = true,
                Admin = false,
            };
            face.FaceSubject = await _verilookManager.EnrollAsync();
            if (face.FaceSubject != null)
                _manager.Save(face);
            else return false;
            return true;
        }

    }
}
