<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.finance = New System.Windows.Forms.PictureBox
        Me.academics = New System.Windows.Forms.PictureBox
        Me.users = New System.Windows.Forms.PictureBox
        Me.library = New System.Windows.Forms.PictureBox
        Me.settings = New System.Windows.Forms.PictureBox
        Me.studdetails = New System.Windows.Forms.PictureBox
        Me.admission = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AdmissionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcademicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FinanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbluser = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.finance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.academics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.users, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.library, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.studdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.admission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.finance)
        Me.Panel1.Controls.Add(Me.academics)
        Me.Panel1.Controls.Add(Me.users)
        Me.Panel1.Controls.Add(Me.library)
        Me.Panel1.Controls.Add(Me.settings)
        Me.Panel1.Controls.Add(Me.studdetails)
        Me.Panel1.Controls.Add(Me.admission)
        Me.Panel1.Location = New System.Drawing.Point(108, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 235)
        Me.Panel1.TabIndex = 10
        '
        'finance
        '
        Me.finance.Image = CType(resources.GetObject("finance.Image"), System.Drawing.Image)
        Me.finance.Location = New System.Drawing.Point(346, 3)
        Me.finance.Name = "finance"
        Me.finance.Size = New System.Drawing.Size(116, 106)
        Me.finance.TabIndex = 6
        Me.finance.TabStop = False
        '
        'academics
        '
        Me.academics.Image = CType(resources.GetObject("academics.Image"), System.Drawing.Image)
        Me.academics.Location = New System.Drawing.Point(218, 0)
        Me.academics.Name = "academics"
        Me.academics.Size = New System.Drawing.Size(131, 148)
        Me.academics.TabIndex = 5
        Me.academics.TabStop = False
        '
        'users
        '
        Me.users.Image = CType(resources.GetObject("users.Image"), System.Drawing.Image)
        Me.users.Location = New System.Drawing.Point(346, 115)
        Me.users.Name = "users"
        Me.users.Size = New System.Drawing.Size(116, 106)
        Me.users.TabIndex = 4
        Me.users.TabStop = False
        '
        'library
        '
        Me.library.Image = CType(resources.GetObject("library.Image"), System.Drawing.Image)
        Me.library.Location = New System.Drawing.Point(3, 125)
        Me.library.Name = "library"
        Me.library.Size = New System.Drawing.Size(83, 83)
        Me.library.TabIndex = 3
        Me.library.TabStop = False
        '
        'settings
        '
        Me.settings.Image = CType(resources.GetObject("settings.Image"), System.Drawing.Image)
        Me.settings.Location = New System.Drawing.Point(105, 125)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(98, 107)
        Me.settings.TabIndex = 2
        Me.settings.TabStop = False
        '
        'studdetails
        '
        Me.studdetails.Image = CType(resources.GetObject("studdetails.Image"), System.Drawing.Image)
        Me.studdetails.Location = New System.Drawing.Point(105, 3)
        Me.studdetails.Name = "studdetails"
        Me.studdetails.Size = New System.Drawing.Size(116, 116)
        Me.studdetails.TabIndex = 1
        Me.studdetails.TabStop = False
        '
        'admission
        '
        Me.admission.Image = CType(resources.GetObject("admission.Image"), System.Drawing.Image)
        Me.admission.Location = New System.Drawing.Point(3, 3)
        Me.admission.Name = "admission"
        Me.admission.Size = New System.Drawing.Size(112, 116)
        Me.admission.TabIndex = 0
        Me.admission.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 85)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdmissionsToolStripMenuItem, Me.AcademicsToolStripMenuItem, Me.LibraryToolStripMenuItem, Me.FinanceToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.UsersToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(590, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 311)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(590, 22)
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(105, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright Skulsys 2014"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(590, 24)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(0, 13)
        Me.lbluser.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(538, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Welcome"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 333)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.Name = "home"
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        CType(Me.finance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.academics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.users, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.library, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.studdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.admission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents finance As System.Windows.Forms.PictureBox
    Friend WithEvents academics As System.Windows.Forms.PictureBox
    Friend WithEvents users As System.Windows.Forms.PictureBox
    Friend WithEvents library As System.Windows.Forms.PictureBox
    Friend WithEvents settings As System.Windows.Forms.PictureBox
    Friend WithEvents studdetails As System.Windows.Forms.PictureBox
    Friend WithEvents admission As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdmissionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcademicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibraryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
