<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoggin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSecurity = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTeacher = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExam = New System.Windows.Forms.ToolStripMenuItem()
        Me.ជនយToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ជនយToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Font = New System.Drawing.Font("Khmer OS System", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSystem, Me.mnuSecurity, Me.mnuSetup, Me.mnuTransaction, Me.ជនយToolStripMenuItem, Me.ជនយToolStripMenuItem1})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(808, 44)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuSystem
        '
        Me.mnuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLoggin, Me.mnuExit})
        Me.mnuSystem.Name = "mnuSystem"
        Me.mnuSystem.Size = New System.Drawing.Size(82, 40)
        Me.mnuSystem.Text = "ប្រព័ន្ធ"
        '
        'mnuLoggin
        '
        Me.mnuLoggin.Name = "mnuLoggin"
        Me.mnuLoggin.Size = New System.Drawing.Size(242, 40)
        Me.mnuLoggin.Text = "ប្តូរអ្នកប្រើប្រាស់"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(242, 40)
        Me.mnuExit.Text = "ចាកចេញ"
        '
        'mnuSecurity
        '
        Me.mnuSecurity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUser})
        Me.mnuSecurity.Name = "mnuSecurity"
        Me.mnuSecurity.Size = New System.Drawing.Size(113, 40)
        Me.mnuSecurity.Text = "សុវត្ថិភាព"
        '
        'mnuUser
        '
        Me.mnuUser.Name = "mnuUser"
        Me.mnuUser.Size = New System.Drawing.Size(224, 40)
        Me.mnuUser.Text = "អ្នកប្រើប្រាស់"
        '
        'mnuSetup
        '
        Me.mnuSetup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTeacher, Me.mnuStudent, Me.mnuStaff})
        Me.mnuSetup.Name = "mnuSetup"
        Me.mnuSetup.Size = New System.Drawing.Size(82, 40)
        Me.mnuSetup.Text = "បង្កើត"
        '
        'mnuTeacher
        '
        Me.mnuTeacher.Name = "mnuTeacher"
        Me.mnuTeacher.Size = New System.Drawing.Size(195, 40)
        Me.mnuTeacher.Text = "ព័ត៌មានគ្រូ"
        '
        'mnuStudent
        '
        Me.mnuStudent.Name = "mnuStudent"
        Me.mnuStudent.Size = New System.Drawing.Size(195, 40)
        Me.mnuStudent.Text = "សិស្ស"
        '
        'mnuStaff
        '
        Me.mnuStaff.Name = "mnuStaff"
        Me.mnuStaff.Size = New System.Drawing.Size(195, 40)
        Me.mnuStaff.Text = "បុគ្គលិក"
        '
        'mnuTransaction
        '
        Me.mnuTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExam})
        Me.mnuTransaction.Name = "mnuTransaction"
        Me.mnuTransaction.Size = New System.Drawing.Size(158, 40)
        Me.mnuTransaction.Text = "ប្រតិបត្តិការណ៍"
        '
        'mnuExam
        '
        Me.mnuExam.Name = "mnuExam"
        Me.mnuExam.Size = New System.Drawing.Size(165, 40)
        Me.mnuExam.Text = "ប្រឡង"
        '
        'ជនយToolStripMenuItem
        '
        Me.ជនយToolStripMenuItem.Name = "ជនយToolStripMenuItem"
        Me.ជនយToolStripMenuItem.Size = New System.Drawing.Size(150, 40)
        Me.ជនយToolStripMenuItem.Text = "បម្រុងទិន្នន័យ"
        '
        'ជនយToolStripMenuItem1
        '
        Me.ជនយToolStripMenuItem1.Name = "ជនយToolStripMenuItem1"
        Me.ជនយToolStripMenuItem1.Size = New System.Drawing.Size(82, 40)
        Me.ជនយToolStripMenuItem1.Text = "ជំនួយ"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 442)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(808, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 464)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnuMain)
        Me.Font = New System.Drawing.Font("Khmer OS System", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuSystem As ToolStripMenuItem
    Friend WithEvents mnuLoggin As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuSecurity As ToolStripMenuItem
    Friend WithEvents mnuSetup As ToolStripMenuItem
    Friend WithEvents mnuTeacher As ToolStripMenuItem
    Friend WithEvents mnuTransaction As ToolStripMenuItem
    Friend WithEvents ជនយToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ជនយToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents mnuUser As ToolStripMenuItem
    Friend WithEvents mnuStudent As ToolStripMenuItem
    Friend WithEvents mnuStaff As ToolStripMenuItem
    Friend WithEvents mnuExam As ToolStripMenuItem
End Class
