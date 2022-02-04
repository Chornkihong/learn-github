<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
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
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvUserRole = New System.Windows.Forms.DataGridView()
        Me.UserRoleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddSecurity = New System.Windows.Forms.Button()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUserRole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvUser.BackgroundColor = System.Drawing.Color.ForestGreen
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Location = New System.Drawing.Point(49, 434)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.RowHeadersWidth = 51
        Me.dgvUser.RowTemplate.Height = 24
        Me.dgvUser.Size = New System.Drawing.Size(450, 248)
        Me.dgvUser.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 36)
        Me.Label2.TabIndex = 2
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(241, 92)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(610, 44)
        Me.txtUserID.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ឈ្មោះអ្នកប្រើប្រាស់"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(241, 151)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(610, 44)
        Me.txtUserName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 36)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ពាក្យសម្ងាត់"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(241, 201)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(610, 44)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(49, 300)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(109, 48)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "ថ្មី"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(164, 300)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 48)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "កែប្រែ"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(279, 300)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 48)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "រក្សាទុក"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(394, 300)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 48)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(394, 361)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 48)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "បិទ"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(279, 361)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(109, 48)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "ស្វែងរក"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(51, 365)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(222, 44)
        Me.txtSearch.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer Muol", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(352, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 50)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ព័ត៌មានគ្រូ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "លេខកូដ"
        '
        'dgvUserRole
        '
        Me.dgvUserRole.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUserRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserRole.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserRoleID, Me.UserID, Me.RoleID})
        Me.dgvUserRole.Location = New System.Drawing.Point(519, 434)
        Me.dgvUserRole.Name = "dgvUserRole"
        Me.dgvUserRole.RowHeadersWidth = 51
        Me.dgvUserRole.RowTemplate.Height = 34
        Me.dgvUserRole.Size = New System.Drawing.Size(490, 247)
        Me.dgvUserRole.TabIndex = 18
        '
        'UserRoleID
        '
        Me.UserRoleID.DataPropertyName = "UserRoleID"
        Me.UserRoleID.HeaderText = "UserRoleID"
        Me.UserRoleID.MinimumWidth = 6
        Me.UserRoleID.Name = "UserRoleID"
        Me.UserRoleID.Width = 125
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "UserID"
        Me.UserID.MinimumWidth = 6
        Me.UserID.Name = "UserID"
        Me.UserID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserID.Width = 125
        '
        'RoleID
        '
        Me.RoleID.DataPropertyName = "RoleID"
        Me.RoleID.FillWeight = 300.0!
        Me.RoleID.HeaderText = "RoleID"
        Me.RoleID.MinimumWidth = 6
        Me.RoleID.Name = "RoleID"
        Me.RoleID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RoleID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RoleID.Width = 298
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer Moul", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(509, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 55)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "សិទិ្ធអ្នកប្រើប្រាស់"
        '
        'btnAddSecurity
        '
        Me.btnAddSecurity.Location = New System.Drawing.Point(722, 359)
        Me.btnAddSecurity.Name = "btnAddSecurity"
        Me.btnAddSecurity.Size = New System.Drawing.Size(129, 53)
        Me.btnAddSecurity.TabIndex = 20
        Me.btnAddSecurity.Text = "ដាក់សិទិ្ធ"
        Me.btnAddSecurity.UseVisualStyleBackColor = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1036, 697)
        Me.Controls.Add(Me.btnAddSecurity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvUserRole)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvUser)
        Me.Font = New System.Drawing.Font("Khmer OS System", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmUser"
        Me.Text = "Teacher"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUserRole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvUserRole As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddSecurity As Button
    Friend WithEvents UserRoleID As DataGridViewTextBoxColumn
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents RoleID As DataGridViewComboBoxColumn
End Class
