<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admission
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admission))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AdmissionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddStudentsParentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllocateClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllocateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllocateDutiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllocateHostelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdditionalInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcademicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FinanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmbStudentStatus = New System.Windows.Forms.ComboBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.admissionYr = New System.Windows.Forms.DateTimePicker
        Me.GrpStudentActive = New System.Windows.Forms.GroupBox
        Me.rActiveNo = New System.Windows.Forms.RadioButton
        Me.rActiveYes = New System.Windows.Forms.RadioButton
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbfamily = New System.Windows.Forms.ComboBox
        Me.Grpgender = New System.Windows.Forms.GroupBox
        Me.rfemale = New System.Windows.Forms.RadioButton
        Me.rmale = New System.Windows.Forms.RadioButton
        Me.Grpdiet = New System.Windows.Forms.GroupBox
        Me.rDietNo = New System.Windows.Forms.RadioButton
        Me.rDietYes = New System.Windows.Forms.RadioButton
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtmedic = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dob = New System.Windows.Forms.DateTimePicker
        Me.txtphoto = New System.Windows.Forms.TextBox
        Me.txtoname = New System.Windows.Forms.TextBox
        Me.txtmname = New System.Windows.Forms.TextBox
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.txtsurname = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GrpStudentActive.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Grpgender.SuspendLayout()
        Me.Grpdiet.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdmissionsToolStripMenuItem, Me.AcademicsToolStripMenuItem, Me.LibraryToolStripMenuItem, Me.FinanceToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1290, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdmissionsToolStripMenuItem
        '
        Me.AdmissionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterStudentToolStripMenuItem, Me.AllocateClassToolStripMenuItem, Me.AllocateToolStripMenuItem, Me.AllocateDutiesToolStripMenuItem, Me.AllocateHostelToolStripMenuItem, Me.AdditionalInfoToolStripMenuItem})
        Me.AdmissionsToolStripMenuItem.Name = "AdmissionsToolStripMenuItem"
        Me.AdmissionsToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AdmissionsToolStripMenuItem.Text = "Admissions"
        '
        'RegisterStudentToolStripMenuItem
        '
        Me.RegisterStudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentsParentsToolStripMenuItem})
        Me.RegisterStudentToolStripMenuItem.Name = "RegisterStudentToolStripMenuItem"
        Me.RegisterStudentToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RegisterStudentToolStripMenuItem.Text = "Register &Student"
        '
        'AddStudentsParentsToolStripMenuItem
        '
        Me.AddStudentsParentsToolStripMenuItem.Name = "AddStudentsParentsToolStripMenuItem"
        Me.AddStudentsParentsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AddStudentsParentsToolStripMenuItem.Text = "Add Student's Parents"
        '
        'AllocateClassToolStripMenuItem
        '
        Me.AllocateClassToolStripMenuItem.Name = "AllocateClassToolStripMenuItem"
        Me.AllocateClassToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AllocateClassToolStripMenuItem.Text = "Allocate &Class"
        '
        'AllocateToolStripMenuItem
        '
        Me.AllocateToolStripMenuItem.Name = "AllocateToolStripMenuItem"
        Me.AllocateToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AllocateToolStripMenuItem.Text = "Allocate &Subjects"
        '
        'AllocateDutiesToolStripMenuItem
        '
        Me.AllocateDutiesToolStripMenuItem.Name = "AllocateDutiesToolStripMenuItem"
        Me.AllocateDutiesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AllocateDutiesToolStripMenuItem.Text = "Allocate &Duty"
        '
        'AllocateHostelToolStripMenuItem
        '
        Me.AllocateHostelToolStripMenuItem.Name = "AllocateHostelToolStripMenuItem"
        Me.AllocateHostelToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AllocateHostelToolStripMenuItem.Text = "Allocate &Hostel"
        '
        'AdditionalInfoToolStripMenuItem
        '
        Me.AdditionalInfoToolStripMenuItem.Name = "AdditionalInfoToolStripMenuItem"
        Me.AdditionalInfoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AdditionalInfoToolStripMenuItem.Text = "Additional &Info"
        '
        'AcademicsToolStripMenuItem
        '
        Me.AcademicsToolStripMenuItem.Name = "AcademicsToolStripMenuItem"
        Me.AcademicsToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AcademicsToolStripMenuItem.Text = "Academics"
        '
        'LibraryToolStripMenuItem
        '
        Me.LibraryToolStripMenuItem.Name = "LibraryToolStripMenuItem"
        Me.LibraryToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.LibraryToolStripMenuItem.Text = "Library"
        '
        'FinanceToolStripMenuItem
        '
        Me.FinanceToolStripMenuItem.Name = "FinanceToolStripMenuItem"
        Me.FinanceToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.FinanceToolStripMenuItem.Text = "Finance"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1095, 571)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 85)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbStudentStatus)
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Controls.Add(Me.btnsave)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.admissionYr)
        Me.GroupBox4.Controls.Add(Me.GrpStudentActive)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Location = New System.Drawing.Point(441, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(299, 314)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        '
        'cmbStudentStatus
        '
        Me.cmbStudentStatus.FormattingEnabled = True
        Me.cmbStudentStatus.Location = New System.Drawing.Point(125, 90)
        Me.cmbStudentStatus.Name = "cmbStudentStatus"
        Me.cmbStudentStatus.Size = New System.Drawing.Size(145, 21)
        Me.cmbStudentStatus.TabIndex = 42
        Me.cmbStudentStatus.Text = "---Select---"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(172, 183)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(59, 184)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 17
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Student Status"
        '
        'admissionYr
        '
        Me.admissionYr.CustomFormat = "yyyy"
        Me.admissionYr.Location = New System.Drawing.Point(125, 134)
        Me.admissionYr.Name = "admissionYr"
        Me.admissionYr.Size = New System.Drawing.Size(144, 20)
        Me.admissionYr.TabIndex = 38
        '
        'GrpStudentActive
        '
        Me.GrpStudentActive.Controls.Add(Me.rActiveNo)
        Me.GrpStudentActive.Controls.Add(Me.rActiveYes)
        Me.GrpStudentActive.Location = New System.Drawing.Point(16, 36)
        Me.GrpStudentActive.Name = "GrpStudentActive"
        Me.GrpStudentActive.Size = New System.Drawing.Size(253, 54)
        Me.GrpStudentActive.TabIndex = 37
        Me.GrpStudentActive.TabStop = False
        Me.GrpStudentActive.Text = "Student Active"
        '
        'rActiveNo
        '
        Me.rActiveNo.AutoSize = True
        Me.rActiveNo.Location = New System.Drawing.Point(192, 19)
        Me.rActiveNo.Name = "rActiveNo"
        Me.rActiveNo.Size = New System.Drawing.Size(39, 17)
        Me.rActiveNo.TabIndex = 35
        Me.rActiveNo.TabStop = True
        Me.rActiveNo.Text = "No"
        Me.rActiveNo.UseVisualStyleBackColor = True
        '
        'rActiveYes
        '
        Me.rActiveYes.AutoSize = True
        Me.rActiveYes.Location = New System.Drawing.Point(109, 19)
        Me.rActiveYes.Name = "rActiveYes"
        Me.rActiveYes.Size = New System.Drawing.Size(43, 17)
        Me.rActiveYes.TabIndex = 34
        Me.rActiveYes.TabStop = True
        Me.rActiveYes.Text = "Yes"
        Me.rActiveYes.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.PaleGreen
        Me.Label27.Location = New System.Drawing.Point(0, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Padding = New System.Windows.Forms.Padding(3)
        Me.Label27.Size = New System.Drawing.Size(299, 23)
        Me.Label27.TabIndex = 28
        Me.Label27.Text = "System Parameters"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(13, 134)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(91, 13)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Year of Admission"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbfamily)
        Me.GroupBox1.Controls.Add(Me.Grpgender)
        Me.GroupBox1.Controls.Add(Me.Grpdiet)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.txtmedic)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dob)
        Me.GroupBox1.Controls.Add(Me.txtphoto)
        Me.GroupBox1.Controls.Add(Me.txtoname)
        Me.GroupBox1.Controls.Add(Me.txtmname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.txtsurname)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 501)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'cmbfamily
        '
        Me.cmbfamily.FormattingEnabled = True
        Me.cmbfamily.Location = New System.Drawing.Point(124, 261)
        Me.cmbfamily.Name = "cmbfamily"
        Me.cmbfamily.Size = New System.Drawing.Size(145, 21)
        Me.cmbfamily.TabIndex = 38
        Me.cmbfamily.Text = "---Select---"
        '
        'Grpgender
        '
        Me.Grpgender.Controls.Add(Me.rfemale)
        Me.Grpgender.Controls.Add(Me.rmale)
        Me.Grpgender.Location = New System.Drawing.Point(6, 164)
        Me.Grpgender.Name = "Grpgender"
        Me.Grpgender.Size = New System.Drawing.Size(264, 54)
        Me.Grpgender.TabIndex = 37
        Me.Grpgender.TabStop = False
        Me.Grpgender.Text = "Gender"
        '
        'rfemale
        '
        Me.rfemale.AutoSize = True
        Me.rfemale.Location = New System.Drawing.Point(192, 19)
        Me.rfemale.Name = "rfemale"
        Me.rfemale.Size = New System.Drawing.Size(59, 17)
        Me.rfemale.TabIndex = 35
        Me.rfemale.TabStop = True
        Me.rfemale.Text = "Female"
        Me.rfemale.UseVisualStyleBackColor = True
        '
        'rmale
        '
        Me.rmale.AutoSize = True
        Me.rmale.Location = New System.Drawing.Point(109, 19)
        Me.rmale.Name = "rmale"
        Me.rmale.Size = New System.Drawing.Size(48, 17)
        Me.rmale.TabIndex = 34
        Me.rmale.TabStop = True
        Me.rmale.Text = "Male"
        Me.rmale.UseVisualStyleBackColor = True
        '
        'Grpdiet
        '
        Me.Grpdiet.Controls.Add(Me.rDietNo)
        Me.Grpdiet.Controls.Add(Me.rDietYes)
        Me.Grpdiet.Location = New System.Drawing.Point(16, 412)
        Me.Grpdiet.Name = "Grpdiet"
        Me.Grpdiet.Size = New System.Drawing.Size(253, 54)
        Me.Grpdiet.TabIndex = 36
        Me.Grpdiet.TabStop = False
        Me.Grpdiet.Text = "Special Diet"
        '
        'rDietNo
        '
        Me.rDietNo.AutoSize = True
        Me.rDietNo.Location = New System.Drawing.Point(192, 19)
        Me.rDietNo.Name = "rDietNo"
        Me.rDietNo.Size = New System.Drawing.Size(39, 17)
        Me.rDietNo.TabIndex = 35
        Me.rDietNo.TabStop = True
        Me.rDietNo.Text = "No"
        Me.rDietNo.UseVisualStyleBackColor = True
        '
        'rDietYes
        '
        Me.rDietYes.AutoSize = True
        Me.rDietYes.Location = New System.Drawing.Point(109, 19)
        Me.rDietYes.Name = "rDietYes"
        Me.rDietYes.Size = New System.Drawing.Size(43, 17)
        Me.rDietYes.TabIndex = 34
        Me.rDietYes.TabStop = True
        Me.rDietYes.Text = "Yes"
        Me.rDietYes.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.PaleGreen
        Me.Label38.Location = New System.Drawing.Point(1, 335)
        Me.Label38.Name = "Label38"
        Me.Label38.Padding = New System.Windows.Forms.Padding(3)
        Me.Label38.Size = New System.Drawing.Size(299, 23)
        Me.Label38.TabIndex = 33
        Me.Label38.Text = "Student Medical Details"
        '
        'txtmedic
        '
        Me.txtmedic.Location = New System.Drawing.Point(125, 386)
        Me.txtmedic.Name = "txtmedic"
        Me.txtmedic.Size = New System.Drawing.Size(144, 20)
        Me.txtmedic.TabIndex = 31
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(15, 386)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(91, 13)
        Me.Label37.TabIndex = 29
        Me.Label37.Text = "Medical Condition"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.PaleGreen
        Me.Label10.Location = New System.Drawing.Point(1, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(3)
        Me.Label10.Size = New System.Drawing.Size(299, 23)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Student Details"
        '
        'dob
        '
        Me.dob.CustomFormat = "dd/MM/yyyy"
        Me.dob.Location = New System.Drawing.Point(125, 227)
        Me.dob.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(144, 20)
        Me.dob.TabIndex = 27
        '
        'txtphoto
        '
        Me.txtphoto.Location = New System.Drawing.Point(125, 294)
        Me.txtphoto.Name = "txtphoto"
        Me.txtphoto.Size = New System.Drawing.Size(144, 20)
        Me.txtphoto.TabIndex = 24
        '
        'txtoname
        '
        Me.txtoname.Location = New System.Drawing.Point(125, 138)
        Me.txtoname.Name = "txtoname"
        Me.txtoname.Size = New System.Drawing.Size(144, 20)
        Me.txtoname.TabIndex = 20
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(125, 103)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(144, 20)
        Me.txtmname.TabIndex = 19
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(125, 69)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(144, 20)
        Me.txtfname.TabIndex = 18
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(125, 36)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(144, 20)
        Me.txtsurname.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Passport Photo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Family Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Other Names"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Surname"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 629)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1290, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(105, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright Skulsys 2014"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(508, 272)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 21
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'admission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1290, 651)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "admission"
        Me.Text = "admission"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GrpStudentActive.ResumeLayout(False)
        Me.GrpStudentActive.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Grpgender.ResumeLayout(False)
        Me.Grpgender.PerformLayout()
        Me.Grpdiet.ResumeLayout(False)
        Me.Grpdiet.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdmissionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcademicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibraryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RegisterStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocateClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocateDutiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocateHostelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdditionalInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents admissionYr As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrpStudentActive As System.Windows.Forms.GroupBox
    Friend WithEvents rActiveNo As System.Windows.Forms.RadioButton
    Friend WithEvents rActiveYes As System.Windows.Forms.RadioButton
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Grpgender As System.Windows.Forms.GroupBox
    Friend WithEvents rfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rmale As System.Windows.Forms.RadioButton
    Friend WithEvents Grpdiet As System.Windows.Forms.GroupBox
    Friend WithEvents rDietNo As System.Windows.Forms.RadioButton
    Friend WithEvents rDietYes As System.Windows.Forms.RadioButton
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtmedic As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtphoto As System.Windows.Forms.TextBox
    Friend WithEvents txtoname As System.Windows.Forms.TextBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmbfamily As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStudentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents AddStudentsParentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
End Class
