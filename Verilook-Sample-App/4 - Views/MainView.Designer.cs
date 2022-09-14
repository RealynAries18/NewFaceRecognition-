
namespace Verilook_Sample_App
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainFaceView = new Neurotec.Biometrics.Gui.NFaceView();
            this.EnrollButton = new System.Windows.Forms.Button();
            this.lbStatusMessage = new System.Windows.Forms.Label();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainFaceView
            // 
            this.MainFaceView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFaceView.BackColor = System.Drawing.Color.Black;
            this.MainFaceView.Face = null;
            this.MainFaceView.FaceIds = null;
            this.MainFaceView.IcaoArrowsColor = System.Drawing.Color.Red;
            this.MainFaceView.Location = new System.Drawing.Point(10, 10);
            this.MainFaceView.Margin = new System.Windows.Forms.Padding(1);
            this.MainFaceView.Name = "MainFaceView";
            this.MainFaceView.ShowIcaoArrows = true;
            this.MainFaceView.ShowTokenImageRectangle = true;
            this.MainFaceView.Size = new System.Drawing.Size(587, 430);
            this.MainFaceView.TabIndex = 18;
            this.MainFaceView.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // EnrollButton
            // 
            this.EnrollButton.Location = new System.Drawing.Point(601, 38);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Size = new System.Drawing.Size(75, 23);
            this.EnrollButton.TabIndex = 19;
            this.EnrollButton.Text = "ENROLL";
            this.EnrollButton.UseVisualStyleBackColor = true;
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // lbStatusMessage
            // 
            this.lbStatusMessage.Location = new System.Drawing.Point(611, 417);
            this.lbStatusMessage.Name = "lbStatusMessage";
            this.lbStatusMessage.Size = new System.Drawing.Size(177, 23);
            this.lbStatusMessage.TabIndex = 20;
            this.lbStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(601, 67);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(75, 23);
            this.btnIdentify.TabIndex = 21;
            this.btnIdentify.Text = "IDENTIFY";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(601, 12);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(187, 20);
            this.tbId.TabIndex = 22;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.lbStatusMessage);
            this.Controls.Add(this.EnrollButton);
            this.Controls.Add(this.MainFaceView);
            this.Name = "MainView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Neurotec.Biometrics.Gui.NFaceView MainFaceView;
        private System.Windows.Forms.Button EnrollButton;
        private System.Windows.Forms.Label lbStatusMessage;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.TextBox tbId;
    }
}

