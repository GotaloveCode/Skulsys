<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmallocateHostel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmallocateHostel))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AdmissionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbhostel = New System.Windows.Forms.ComboBox
        Me.btnhostel = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbstud = New System.Windows.Forms.ComboBox
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 580)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1324, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(105, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright Skulsys 2014"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdmissionsToolStripMenuItem, Me.AcademicsToolStripMenuItem, Me.LibraryToolStripMenuItem, Me.FinanceToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1324, 24)
        Me.MenuStrip1.TabIndex = 21
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
        Me.RegisterStudentToolStripMenuItem.Name = "RegisterStudentToolStripMenuItem"
        Me.RegisterStudentToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RegisterStudentToolStripMenuItem.Text = "Register &Student"
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(10, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1216, 494)
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PaleGreen
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(546, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(3)
        Me.Label1.Size = New System.Drawing.Size(512, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Hostels and Current Occupancy"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 85)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(547, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(511, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.cmbhostel)
        Me.GroupBox4.Controls.Add(Me.btnhostel)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.cmbstud)
        Me.GroupBox4.Location = New System.Drawing.Point(129, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(388, 183)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.PaleGreen
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(3)
        Me.Label10.Size = New System.Drawing.Size(392, 23)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Allocate Hostel"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(24, 87)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(3)
        Me.Label18.Size = New System.Drawing.Size(43, 19)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Hostel"
        '
        'cmbhostel
        '
        Me.cmbhostel.FormattingEnabled = True
        Me.cmbhostel.Location = New System.Drawing.Point(112, 87)
        Me.cmbhostel.Name = "cmbhostel"
        Me.cmbhostel.Size = New System.Drawing.Size(229, 21)
        Me.cmbhostel.TabIndex = 11
        Me.cmbhostel.Text = "hostel"
        '
        'btnhostel
        '
        Me.btnhostel.Location = New System.Drawing.Point(226, 127)
        Me.btnhostel.Name = "btnhostel"
        Me.btnhostel.Size = New System.Drawing.Size(87, 23)
        Me.btnhostel.TabIndex = 10
        Me.btnhostel.Text = "Allocate"
        Me.btnhostel.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(23, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Padding = New System.Windows.Forms.Padding(3)
        Me.Label21.Size = New System.Drawing.Size(50, 19)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Student"
        '
        'cmbstud
        '
        Me.cmbstud.FormattingEnabled = True
        Me.cmbstud.Location = New System.Drawing.Point(112, 58)
        Me.cmbstud.Name = "cmbstud"
        Me.cmbstud.Size = New System.Drawing.Size(229, 21)
        Me.cmbstud.TabIndex = 0
        Me.cmbstud.Text = "student name"
        '
        'frmallocateHostel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 602)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmallocateHostel"
        Me.Text = "frmallocateHostel"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdmissionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocateClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocateDutiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocateHostelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdditionalInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcademicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibraryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbhostel As System.Windows.Forms.ComboBox
    Friend WithEvents btnhostel As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbstud As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
