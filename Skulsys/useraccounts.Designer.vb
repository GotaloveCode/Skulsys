<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useraccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(useraccounts))
        Me.lbltime = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdmissionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcademicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FinanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnvalidate = New System.Windows.Forms.Button
        Me.txtadpas = New System.Windows.Forms.TextBox
        Me.txtadmin = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.chkadmin = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btncreate = New System.Windows.Forms.Button
        Me.txtpas2 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtpas = New System.Windows.Forms.TextBox
        Me.txtusr = New System.Windows.Forms.TextBox
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltime
        '
        Me.lbltime.Location = New System.Drawing.Point(544, 19)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(161, 21)
        Me.lbltime.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 85)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.AdmissionsToolStripMenuItem, Me.AcademicsToolStripMenuItem, Me.LibraryToolStripMenuItem, Me.FinanceToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.UsersToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AdmissionsToolStripMenuItem
        '
        Me.AdmissionsToolStripMenuItem.Name = "AdmissionsToolStripMenuItem"
        Me.AdmissionsToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AdmissionsToolStripMenuItem.Text = "Admissions"
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
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(97, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(777, 502)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(769, 476)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create Account"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(6, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 37)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Only admin accounts can create user accounts."
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnvalidate)
        Me.Panel1.Controls.Add(Me.txtadpas)
        Me.Panel1.Controls.Add(Me.txtadmin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Location = New System.Drawing.Point(6, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 224)
        Me.Panel1.TabIndex = 96
        '
        'btnvalidate
        '
        Me.btnvalidate.Location = New System.Drawing.Point(84, 159)
        Me.btnvalidate.Name = "btnvalidate"
        Me.btnvalidate.Size = New System.Drawing.Size(86, 25)
        Me.btnvalidate.TabIndex = 10
        Me.btnvalidate.Text = "VALIDATE"
        Me.btnvalidate.UseVisualStyleBackColor = True
        '
        'txtadpas
        '
        Me.txtadpas.Location = New System.Drawing.Point(23, 121)
        Me.txtadpas.Name = "txtadpas"
        Me.txtadpas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtadpas.Size = New System.Drawing.Size(220, 20)
        Me.txtadpas.TabIndex = 7
        '
        'txtadmin
        '
        Me.txtadmin.Location = New System.Drawing.Point(24, 64)
        Me.txtadmin.Name = "txtadmin"
        Me.txtadmin.Size = New System.Drawing.Size(220, 20)
        Me.txtadmin.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&User name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(202, 13)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "VERIFY ADMIN STATUS TO PROCEED"
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Location = New System.Drawing.Point(312, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(290, 37)
        Me.Label18.TabIndex = 95
        Me.Label18.Text = "Ensure your password has at least one number,includes mixed case(upper and lower " & _
            "case) as well as alphabets. "
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.chkadmin)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btncreate)
        Me.Panel3.Controls.Add(Me.txtpas2)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txtpas)
        Me.Panel3.Controls.Add(Me.txtusr)
        Me.Panel3.Controls.Add(Me.PasswordLabel)
        Me.Panel3.Controls.Add(Me.UsernameLabel)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(312, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(290, 282)
        Me.Panel3.TabIndex = 94
        '
        'chkadmin
        '
        Me.chkadmin.AutoSize = True
        Me.chkadmin.Location = New System.Drawing.Point(39, 217)
        Me.chkadmin.Name = "chkadmin"
        Me.chkadmin.Size = New System.Drawing.Size(66, 17)
        Me.chkadmin.TabIndex = 91
        Me.chkadmin.Text = "Is &Admin"
        Me.chkadmin.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "CREATE USER ACCOUNT"
        '
        'btncreate
        '
        Me.btncreate.Location = New System.Drawing.Point(169, 237)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(86, 25)
        Me.btncreate.TabIndex = 10
        Me.btncreate.Text = "CREATE"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'txtpas2
        '
        Me.txtpas2.Location = New System.Drawing.Point(36, 185)
        Me.txtpas2.Name = "txtpas2"
        Me.txtpas2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpas2.Size = New System.Drawing.Size(220, 20)
        Me.txtpas2.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(35, 159)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(220, 23)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Match &Password"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpas
        '
        Me.txtpas.Location = New System.Drawing.Point(38, 121)
        Me.txtpas.Name = "txtpas"
        Me.txtpas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpas.Size = New System.Drawing.Size(220, 20)
        Me.txtpas.TabIndex = 7
        '
        'txtusr
        '
        Me.txtusr.Location = New System.Drawing.Point(38, 64)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(220, 20)
        Me.txtusr.TabIndex = 5
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(36, 101)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 6
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(36, 44)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(769, 476)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Update Account"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 580)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(783, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(105, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright Skulsys 2014"
        '
        'useraccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 602)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "useraccounts"
        Me.Text = "useraccounts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdmissionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcademicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibraryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnvalidate As System.Windows.Forms.Button
    Friend WithEvents txtadpas As System.Windows.Forms.TextBox
    Friend WithEvents txtadmin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents chkadmin As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btncreate As System.Windows.Forms.Button
    Friend WithEvents txtpas2 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtpas As System.Windows.Forms.TextBox
    Friend WithEvents txtusr As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
