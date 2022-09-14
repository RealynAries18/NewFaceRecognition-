using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verilook_Sample_App.Controllers;
using Verilook_Sample_App.Persistence;
using Verilook_Sample_App.Services;
using Verilook_Sample_App.Services.Face_Profile;

namespace Verilook_Sample_App
{
    public partial class MainView : Form
    {
        FaceProfileController _controller;
        VerilookManagerFactory _factory;

        public MainView()
        {
            InitializeComponent();

            MysqlManager manager = new MysqlManager("Server=localhost;Database=facerec_db;Uid=root;Pwd=Soft1234;");

            _factory = new VerilookManagerFactory(MainFaceView);

            _controller = new FaceProfileController(
                new FaceProfileProvider(manager),
                new FaceProfileManager(manager),
                _factory.CreateManager()
            );
        }

        private async void EnrollButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbId.Text))
            {
                try
                {
                    bool result = await _controller.EnrollFace(tbId.Text);
                    if (result)
                        lbStatusMessage.Text = "Saved.";
                    else
                        lbStatusMessage.Text = "Capture failed, please try again.";
                }
                catch (Exception ex)
                {
                    lbStatusMessage.Text = ex.Message;
                }
            }
        }

        private async void btnIdentify_Click(object sender, EventArgs e)
        {
            try
            {
                string result = await _controller.IdentifyFace();
                if (!string.IsNullOrEmpty(result))
                    lbStatusMessage.Text = $"Matched with Id:{result}.";
                else
                    lbStatusMessage.Text = "No match found, please try again.";
            }
            catch (Exception ex)
            {
                lbStatusMessage.Text = ex.Message;
            }
        }
    }
}
