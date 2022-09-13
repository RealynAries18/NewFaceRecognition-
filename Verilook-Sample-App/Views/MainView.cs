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
            _controller = new FaceProfileController(new FaceProfileProvider(), new FaceProfileManager(manager), _factory.CreateManager());
        }

        private async void EnrollButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = await _controller.EnrollUser("testid");
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
}
