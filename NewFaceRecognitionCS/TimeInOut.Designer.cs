using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NewFaceRecognition
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TimeInOut : Form
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
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = SystemColors.ActiveCaption;
            Panel1.Controls.Add(Button1);
            Panel1.Controls.Add(Label1);
            Panel1.Location = new Point(-2, -1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(806, 62);
            Panel1.TabIndex = 0;
            // 
            // Button1
            // 
            Button1.BackColor = Color.OrangeRed;
            Button1.Dock = DockStyle.Right;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(700, 0);
            Button1.Name = "Button1";
            Button1.Size = new Size(106, 62);
            Button1.TabIndex = 18;
            Button1.Text = "EXIT";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Yu Gothic UI", 21.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(14, 10);
            Label1.Name = "Label1";
            Label1.Size = new Size(668, 40);
            Label1.TabIndex = 0;
            Label1.Text = "Welcome to Employee Facial Recognation System";
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImageLayout = ImageLayout.Center;
            PictureBox1.BorderStyle = BorderStyle.FixedSingle;
            PictureBox1.Location = new Point(139, 67);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(506, 322);
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // TimeInOut
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PictureBox1);
            Controls.Add(Panel1);
            Name = "TimeInOut";
            Text = "TimeInOut";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(TimeInOut_Load);
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Button Button1;
    }
}