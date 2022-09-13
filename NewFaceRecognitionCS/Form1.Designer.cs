using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NewFaceRecognition
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LOGIN : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Panel1 = new Panel();
            btnExit = new Button();
            btnExit.Click += new EventHandler(btnExit_Click);
            btnLogin = new Button();
            btnLogin.Click += new EventHandler(btnLogin_Click);
            txtpass = new TextBox();
            Label2 = new Label();
            txtuser = new TextBox();
            Label1 = new Label();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = SystemColors.GradientInactiveCaption;
            Panel1.Controls.Add(btnExit);
            Panel1.Controls.Add(btnLogin);
            Panel1.Controls.Add(txtpass);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(txtuser);
            Panel1.Controls.Add(Label1);
            Panel1.Location = new Point(29, 22);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(472, 252);
            Panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Crimson;
            btnExit.Font = new Font("Yu Gothic UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(306, 173);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 30);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.Font = new Font("Yu Gothic UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(146, 173);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(121, 122);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(300, 30);
            txtpass.TabIndex = 3;
            txtpass.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(31, 122);
            Label2.Name = "Label2";
            Label2.Size = new Size(80, 21);
            Label2.TabIndex = 2;
            Label2.Text = "Password:";
            // 
            // txtuser
            // 
            txtuser.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(121, 68);
            txtuser.Multiline = true;
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(300, 30);
            txtuser.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(31, 68);
            Label1.Name = "Label1";
            Label1.Size = new Size(84, 21);
            Label1.TabIndex = 0;
            Label1.Text = "Username:";
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(538, 305);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal TextBox txtpass;
        internal Label Label2;
        internal TextBox txtuser;
        internal Label Label1;
        internal Button btnExit;
        internal Button btnLogin;
    }
}