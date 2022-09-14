using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Biometrics.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verilook_Sample_App.Models;

namespace Verilook_Sample_App.Services
{
    public class VerilookManager : IVerilookManager
    {

        private NBiometricTask _faceTask { get; set; }

        private NBiometricClient _faceClient { get; set; }
        private NFaceView _faceView { get; set; }

        private NBiometricCaptureOptions _captureOptions { get; set; }


        public VerilookManager(NBiometricClient faceClient, NFaceView faceView, NBiometricCaptureOptions captureOptions)
        {
            _faceClient = faceClient;
            _faceView = faceView;
            _captureOptions = captureOptions;


            _faceTask = new NBiometricTask(NBiometricOperations.Identify);
        }

        public async Task<NSubject> CaptureFaceAsync()
        {
            NSubject newFaceSubject = new NSubject();
            newFaceSubject.Faces.Add(new NFace() { CaptureOptions = _captureOptions });

            _faceView.Face = newFaceSubject.Faces.Last();

            NBiometricStatus status = await _faceClient.CaptureAsync(newFaceSubject);
            if (status == NBiometricStatus.Ok)
                return newFaceSubject;
            return null;
        }

        public async Task<string> IdentifyAsync()
        {
            NSubject fs = await CaptureFaceAsync();
             
            if (fs != null)
            {
                _faceTask.Operations = NBiometricOperations.Enroll;
                _faceTask = await _faceClient.PerformTaskAsync(_faceTask);
                NBiometricStatus res = await _faceClient.IdentifyAsync(fs);
                if (res == NBiometricStatus.Ok)
                    return fs.MatchingResults.First().Id;
            }


            return "";
        }


        public void SetFaceProfiles(IEnumerable<FaceProfile> faceProfiles)
        {
            foreach (NSubject faceSubject in faceProfiles.Select(f => f.FaceSubject))
                _faceTask.Subjects.Add(faceSubject);
        }
    }
}
