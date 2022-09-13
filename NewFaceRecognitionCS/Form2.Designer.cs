using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NewFaceRecognition
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class RegisterEmployee : Form
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
            PicDetected = new PictureBox();
            EMPLOYEEID = new TextBox();
            LAST_NAME = new TextBox();
            FIRST_NAME = new TextBox();
            MIDDLE_NAME = new TextBox();
            btnAddEmployee = new Button();
            btnAddEmployee.Click += new EventHandler(btnAddEmployee_Click);
            btnCapture = new Button();
            OFFICE = new TextBox();
            dataEmployeeList = new DataGridView();
            btnReload = new Button();
            btnReload.Click += new EventHandler(btnReload_Click);
            labelRegisterEmployee = new Label();
            Panel1 = new Panel();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            lalbelIDNumber = new Label();
            LabelLastName = new Label();
            labelFirstName = new Label();
            LabelMiddleName = new Label();
            LabelOffice = new Label();
            btnSearchEmployee = new Button();
            btnSearchEmployee.Click += new EventHandler(btnSearchEmployee_Click);
            btnUpdateEmployee = new Button();
            btnUpdateEmployee.Click += new EventHandler(btnUpdateEmployee_Click);
            ((System.ComponentModel.ISupportInitialize)PicDetected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataEmployeeList).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PicDetected
            // 
            PicDetected.BorderStyle = BorderStyle.FixedSingle;
            PicDetected.Location = new Point(45, 104);
            PicDetected.Name = "PicDetected";
            PicDetected.Size = new Size(365, 212);
            PicDetected.TabIndex = 0;
            PicDetected.TabStop = false;
            // 
            // EMPLOYEEID
            // 
            EMPLOYEEID.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            EMPLOYEEID.ForeColor = Color.Black;
            EMPLOYEEID.Location = new Point(160, 447);
            EMPLOYEEID.Multiline = true;
            EMPLOYEEID.Name = "EMPLOYEEID";
            EMPLOYEEID.Size = new Size(250, 30);
            EMPLOYEEID.TabIndex = 1;
            // 
            // LAST_NAME
            // 
            LAST_NAME.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LAST_NAME.ForeColor = Color.Black;
            LAST_NAME.Location = new Point(160, 483);
            LAST_NAME.Multiline = true;
            LAST_NAME.Name = "LAST_NAME";
            LAST_NAME.Size = new Size(250, 30);
            LAST_NAME.TabIndex = 2;
            // 
            // FIRST_NAME
            // 
            FIRST_NAME.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FIRST_NAME.ForeColor = Color.Black;
            FIRST_NAME.Location = new Point(160, 519);
            FIRST_NAME.Multiline = true;
            FIRST_NAME.Name = "FIRST_NAME";
            FIRST_NAME.Size = new Size(250, 30);
            FIRST_NAME.TabIndex = 3;
            // 
            // MIDDLE_NAME
            // 
            MIDDLE_NAME.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MIDDLE_NAME.ForeColor = Color.Black;
            MIDDLE_NAME.Location = new Point(160, 555);
            MIDDLE_NAME.Multiline = true;
            MIDDLE_NAME.Name = "MIDDLE_NAME";
            MIDDLE_NAME.Size = new Size(250, 30);
            MIDDLE_NAME.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.LightGreen;
            btnAddEmployee.Font = new Font("Yu Gothic UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.Black;
            btnAddEmployee.Location = new Point(160, 628);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(250, 40);
            btnAddEmployee.TabIndex = 5;
            btnAddEmployee.Text = "ADD EMPLOYEE";
            btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnCapture
            // 
            btnCapture.BackColor = Color.LightGreen;
            btnCapture.Font = new Font("Yu Gothic UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapture.ForeColor = Color.Black;
            btnCapture.Location = new Point(97, 322);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(250, 40);
            btnCapture.TabIndex = 6;
            btnCapture.Text = "CAPTURE";
            btnCapture.UseVisualStyleBackColor = false;
            // 
            // OFFICE
            // 
            OFFICE.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            OFFICE.AutoCompleteSource = AutoCompleteSource.HistoryList;
            OFFICE.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            OFFICE.ForeColor = Color.Black;
            OFFICE.Location = new Point(160, 591);
            OFFICE.Multiline = true;
            OFFICE.Name = "OFFICE";
            OFFICE.Size = new Size(250, 30);
            OFFICE.TabIndex = 7;
            // 
            // dataEmployeeList
            // 
            dataEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEmployeeList.GridColor = SystemColors.Control;
            dataEmployeeList.Location = new Point(442, 104);
            dataEmployeeList.Name = "dataEmployeeList";
            dataEmployeeList.Size = new Size(1002, 612);
            dataEmployeeList.TabIndex = 8;
            // 
            // btnReload
            // 
            btnReload.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.Location = new Point(779, 732);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(322, 31);
            btnReload.TabIndex = 9;
            btnReload.Text = "RELOAD EMPLOYEE LIST";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // labelRegisterEmployee
            // 
            labelRegisterEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            labelRegisterEmployee.Font = new Font("Yu Gothic UI", 27.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelRegisterEmployee.ForeColor = Color.White;
            labelRegisterEmployee.Location = new Point(0, 9);
            labelRegisterEmployee.Name = "labelRegisterEmployee";
            labelRegisterEmployee.Size = new Size(1373, 64);
            labelRegisterEmployee.TabIndex = 10;
            labelRegisterEmployee.Text = "Employee Registration Form";
            labelRegisterEmployee.TextAlign = ContentAlignment.TopCenter;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.LightSteelBlue;
            Panel1.Controls.Add(Button1);
            Panel1.Controls.Add(labelRegisterEmployee);
            Panel1.Dock = DockStyle.Top;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1485, 73);
            Panel1.TabIndex = 11;
            // 
            // Button1
            // 
            Button1.BackColor = Color.OrangeRed;
            Button1.Dock = DockStyle.Right;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Yu Gothic UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(1379, 0);
            Button1.Name = "Button1";
            Button1.Size = new Size(106, 73);
            Button1.TabIndex = 17;
            Button1.Text = "LOGOUT";
            Button1.UseVisualStyleBackColor = false;
            // 
            // lalbelIDNumber
            // 
            lalbelIDNumber.AutoSize = true;
            lalbelIDNumber.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lalbelIDNumber.Location = new Point(59, 447);
            lalbelIDNumber.Name = "lalbelIDNumber";
            lalbelIDNumber.Size = new Size(90, 21);
            lalbelIDNumber.TabIndex = 12;
            lalbelIDNumber.Text = "ID Number:";
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLastName.Location = new Point(62, 483);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(87, 21);
            LabelLastName.TabIndex = 13;
            LabelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(59, 519);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(89, 21);
            labelFirstName.TabIndex = 14;
            labelFirstName.Text = "First Name:";
            // 
            // LabelMiddleName
            // 
            LabelMiddleName.AutoSize = true;
            LabelMiddleName.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMiddleName.Location = new Point(41, 555);
            LabelMiddleName.Name = "LabelMiddleName";
            LabelMiddleName.Size = new Size(107, 21);
            LabelMiddleName.TabIndex = 15;
            LabelMiddleName.Text = "Middle Name:";
            // 
            // LabelOffice
            // 
            LabelOffice.AutoSize = true;
            LabelOffice.Font = new Font("Yu Gothic UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelOffice.Location = new Point(93, 591);
            LabelOffice.Name = "LabelOffice";
            LabelOffice.Size = new Size(55, 21);
            LabelOffice.TabIndex = 16;
            LabelOffice.Text = "Office:";
            // 
            // btnSearchEmployee
            // 
            btnSearchEmployee.Font = new Font("Yu Gothic UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchEmployee.Location = new Point(160, 676);
            btnSearchEmployee.Name = "btnSearchEmployee";
            btnSearchEmployee.Size = new Size(250, 40);
            btnSearchEmployee.TabIndex = 17;
            btnSearchEmployee.Text = "Search Employee";
            btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Font = new Font("Yu Gothic UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateEmployee.Location = new Point(160, 723);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(250, 40);
            btnUpdateEmployee.TabIndex = 18;
            btnUpdateEmployee.Text = "Update Employee";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // RegisterEmployee
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1485, 786);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(btnSearchEmployee);
            Controls.Add(LabelOffice);
            Controls.Add(LabelMiddleName);
            Controls.Add(labelFirstName);
            Controls.Add(LabelLastName);
            Controls.Add(lalbelIDNumber);
            Controls.Add(Panel1);
            Controls.Add(btnReload);
            Controls.Add(dataEmployeeList);
            Controls.Add(OFFICE);
            Controls.Add(btnCapture);
            Controls.Add(btnAddEmployee);
            Controls.Add(MIDDLE_NAME);
            Controls.Add(FIRST_NAME);
            Controls.Add(LAST_NAME);
            Controls.Add(EMPLOYEEID);
            Controls.Add(PicDetected);
            Name = "RegisterEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Employee";
            ((System.ComponentModel.ISupportInitialize)PicDetected).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataEmployeeList).EndInit();
            Panel1.ResumeLayout(false);
            Load += new EventHandler(RegisterEmployee_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal PictureBox PicDetected;
        internal TextBox EMPLOYEEID;
        internal TextBox LAST_NAME;
        internal TextBox FIRST_NAME;
        internal TextBox MIDDLE_NAME;
        internal Button btnAddEmployee;
        internal Button btnCapture;
        internal TextBox OFFICE;
        internal DataGridView dataEmployeeList;
        internal Button btnReload;
        internal Label labelRegisterEmployee;
        internal Panel Panel1;
        internal Label lalbelIDNumber;
        internal Label LabelLastName;
        internal Label labelFirstName;
        internal Label LabelMiddleName;
        internal Label LabelOffice;
        internal Button Button1;
        internal Button btnSearchEmployee;
        internal Button btnUpdateEmployee;
    }
}