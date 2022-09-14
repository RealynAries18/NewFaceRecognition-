<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PicDetected = New System.Windows.Forms.PictureBox()
        Me.EMPLOYEEID = New System.Windows.Forms.TextBox()
        Me.LAST_NAME = New System.Windows.Forms.TextBox()
        Me.FIRST_NAME = New System.Windows.Forms.TextBox()
        Me.MIDDLE_NAME = New System.Windows.Forms.TextBox()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.OFFICE = New System.Windows.Forms.TextBox()
        Me.dataEmployeeList = New System.Windows.Forms.DataGridView()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.labelRegisterEmployee = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lalbelIDNumber = New System.Windows.Forms.Label()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.labelFirstName = New System.Windows.Forms.Label()
        Me.LabelMiddleName = New System.Windows.Forms.Label()
        Me.LabelOffice = New System.Windows.Forms.Label()
        Me.btnSearchEmployee = New System.Windows.Forms.Button()
        Me.btnUpdateEmployee = New System.Windows.Forms.Button()
        CType(Me.PicDetected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicDetected
        '
        Me.PicDetected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicDetected.Location = New System.Drawing.Point(45, 104)
        Me.PicDetected.Name = "PicDetected"
        Me.PicDetected.Size = New System.Drawing.Size(365, 212)
        Me.PicDetected.TabIndex = 0
        Me.PicDetected.TabStop = False
        '
        'EMPLOYEEID
        '
        Me.EMPLOYEEID.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMPLOYEEID.ForeColor = System.Drawing.Color.Black
        Me.EMPLOYEEID.Location = New System.Drawing.Point(160, 447)
        Me.EMPLOYEEID.Multiline = True
        Me.EMPLOYEEID.Name = "EMPLOYEEID"
        Me.EMPLOYEEID.Size = New System.Drawing.Size(250, 30)
        Me.EMPLOYEEID.TabIndex = 1
        '
        'LAST_NAME
        '
        Me.LAST_NAME.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAST_NAME.ForeColor = System.Drawing.Color.Black
        Me.LAST_NAME.Location = New System.Drawing.Point(160, 483)
        Me.LAST_NAME.Multiline = True
        Me.LAST_NAME.Name = "LAST_NAME"
        Me.LAST_NAME.Size = New System.Drawing.Size(250, 30)
        Me.LAST_NAME.TabIndex = 2
        '
        'FIRST_NAME
        '
        Me.FIRST_NAME.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIRST_NAME.ForeColor = System.Drawing.Color.Black
        Me.FIRST_NAME.Location = New System.Drawing.Point(160, 519)
        Me.FIRST_NAME.Multiline = True
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.Size = New System.Drawing.Size(250, 30)
        Me.FIRST_NAME.TabIndex = 3
        '
        'MIDDLE_NAME
        '
        Me.MIDDLE_NAME.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MIDDLE_NAME.ForeColor = System.Drawing.Color.Black
        Me.MIDDLE_NAME.Location = New System.Drawing.Point(160, 555)
        Me.MIDDLE_NAME.Multiline = True
        Me.MIDDLE_NAME.Name = "MIDDLE_NAME"
        Me.MIDDLE_NAME.Size = New System.Drawing.Size(250, 30)
        Me.MIDDLE_NAME.TabIndex = 4
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.LightGreen
        Me.btnAddEmployee.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmployee.ForeColor = System.Drawing.Color.Black
        Me.btnAddEmployee.Location = New System.Drawing.Point(160, 628)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(250, 40)
        Me.btnAddEmployee.TabIndex = 5
        Me.btnAddEmployee.Text = "ADD EMPLOYEE"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.LightGreen
        Me.btnCapture.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.ForeColor = System.Drawing.Color.Black
        Me.btnCapture.Location = New System.Drawing.Point(97, 322)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(250, 40)
        Me.btnCapture.TabIndex = 6
        Me.btnCapture.Text = "CAPTURE"
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'OFFICE
        '
        Me.OFFICE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.OFFICE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.OFFICE.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OFFICE.ForeColor = System.Drawing.Color.Black
        Me.OFFICE.Location = New System.Drawing.Point(160, 591)
        Me.OFFICE.Multiline = True
        Me.OFFICE.Name = "OFFICE"
        Me.OFFICE.Size = New System.Drawing.Size(250, 30)
        Me.OFFICE.TabIndex = 7
        '
        'dataEmployeeList
        '
        Me.dataEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataEmployeeList.GridColor = System.Drawing.SystemColors.Control
        Me.dataEmployeeList.Location = New System.Drawing.Point(442, 104)
        Me.dataEmployeeList.Name = "dataEmployeeList"
        Me.dataEmployeeList.Size = New System.Drawing.Size(1002, 612)
        Me.dataEmployeeList.TabIndex = 8
        '
        'btnReload
        '
        Me.btnReload.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.Location = New System.Drawing.Point(785, 722)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(322, 31)
        Me.btnReload.TabIndex = 9
        Me.btnReload.Text = "RELOAD EMPLOYEE LIST"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'labelRegisterEmployee
        '
        Me.labelRegisterEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelRegisterEmployee.Font = New System.Drawing.Font("Yu Gothic UI", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRegisterEmployee.ForeColor = System.Drawing.Color.White
        Me.labelRegisterEmployee.Location = New System.Drawing.Point(0, 9)
        Me.labelRegisterEmployee.Name = "labelRegisterEmployee"
        Me.labelRegisterEmployee.Size = New System.Drawing.Size(1373, 64)
        Me.labelRegisterEmployee.TabIndex = 10
        Me.labelRegisterEmployee.Text = "Employee Registration Form"
        Me.labelRegisterEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.labelRegisterEmployee)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1485, 73)
        Me.Panel1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1379, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 73)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "LOGOUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lalbelIDNumber
        '
        Me.lalbelIDNumber.AutoSize = True
        Me.lalbelIDNumber.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lalbelIDNumber.Location = New System.Drawing.Point(59, 447)
        Me.lalbelIDNumber.Name = "lalbelIDNumber"
        Me.lalbelIDNumber.Size = New System.Drawing.Size(90, 21)
        Me.lalbelIDNumber.TabIndex = 12
        Me.lalbelIDNumber.Text = "ID Number:"
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(62, 483)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(87, 21)
        Me.LabelLastName.TabIndex = 13
        Me.LabelLastName.Text = "Last Name:"
        '
        'labelFirstName
        '
        Me.labelFirstName.AutoSize = True
        Me.labelFirstName.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFirstName.Location = New System.Drawing.Point(59, 519)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(89, 21)
        Me.labelFirstName.TabIndex = 14
        Me.labelFirstName.Text = "First Name:"
        '
        'LabelMiddleName
        '
        Me.LabelMiddleName.AutoSize = True
        Me.LabelMiddleName.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMiddleName.Location = New System.Drawing.Point(41, 555)
        Me.LabelMiddleName.Name = "LabelMiddleName"
        Me.LabelMiddleName.Size = New System.Drawing.Size(107, 21)
        Me.LabelMiddleName.TabIndex = 15
        Me.LabelMiddleName.Text = "Middle Name:"
        '
        'LabelOffice
        '
        Me.LabelOffice.AutoSize = True
        Me.LabelOffice.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOffice.Location = New System.Drawing.Point(93, 591)
        Me.LabelOffice.Name = "LabelOffice"
        Me.LabelOffice.Size = New System.Drawing.Size(55, 21)
        Me.LabelOffice.TabIndex = 16
        Me.LabelOffice.Text = "Office:"
        '
        'btnSearchEmployee
        '
        Me.btnSearchEmployee.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchEmployee.Location = New System.Drawing.Point(160, 676)
        Me.btnSearchEmployee.Name = "btnSearchEmployee"
        Me.btnSearchEmployee.Size = New System.Drawing.Size(250, 40)
        Me.btnSearchEmployee.TabIndex = 17
        Me.btnSearchEmployee.Text = "Search Employee"
        Me.btnSearchEmployee.UseVisualStyleBackColor = True
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(160, 723)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(250, 40)
        Me.btnUpdateEmployee.TabIndex = 18
        Me.btnUpdateEmployee.Text = "Update Employee"
        Me.btnUpdateEmployee.UseVisualStyleBackColor = True
        '
        'RegisterEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1485, 786)
        Me.Controls.Add(Me.btnUpdateEmployee)
        Me.Controls.Add(Me.btnSearchEmployee)
        Me.Controls.Add(Me.LabelOffice)
        Me.Controls.Add(Me.LabelMiddleName)
        Me.Controls.Add(Me.labelFirstName)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.lalbelIDNumber)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.dataEmployeeList)
        Me.Controls.Add(Me.OFFICE)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.MIDDLE_NAME)
        Me.Controls.Add(Me.FIRST_NAME)
        Me.Controls.Add(Me.LAST_NAME)
        Me.Controls.Add(Me.EMPLOYEEID)
        Me.Controls.Add(Me.PicDetected)
        Me.Name = "RegisterEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Employee"
        CType(Me.PicDetected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicDetected As PictureBox
    Friend WithEvents EMPLOYEEID As TextBox
    Friend WithEvents LAST_NAME As TextBox
    Friend WithEvents FIRST_NAME As TextBox
    Friend WithEvents MIDDLE_NAME As TextBox
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents OFFICE As TextBox
    Friend WithEvents dataEmployeeList As DataGridView
    Friend WithEvents btnReload As Button
    Friend WithEvents labelRegisterEmployee As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lalbelIDNumber As Label
    Friend WithEvents LabelLastName As Label
    Friend WithEvents labelFirstName As Label
    Friend WithEvents LabelMiddleName As Label
    Friend WithEvents LabelOffice As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSearchEmployee As Button
    Friend WithEvents btnUpdateEmployee As Button
End Class
