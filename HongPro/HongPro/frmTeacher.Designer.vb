<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTeacher
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
        Me.dgvTeacher = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTeacherID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPOB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.opfPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTeacher
        '
        Me.dgvTeacher.AllowUserToAddRows = False
        Me.dgvTeacher.AllowUserToDeleteRows = False
        Me.dgvTeacher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTeacher.BackgroundColor = System.Drawing.Color.ForestGreen
        Me.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeacher.Location = New System.Drawing.Point(7, 483)
        Me.dgvTeacher.Name = "dgvTeacher"
        Me.dgvTeacher.ReadOnly = True
        Me.dgvTeacher.RowHeadersVisible = False
        Me.dgvTeacher.RowHeadersWidth = 51
        Me.dgvTeacher.RowTemplate.Height = 24
        Me.dgvTeacher.Size = New System.Drawing.Size(994, 249)
        Me.dgvTeacher.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "អត្តលេខ"
        '
        'txtTeacherID
        '
        Me.txtTeacherID.Location = New System.Drawing.Point(225, 92)
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.ReadOnly = True
        Me.txtTeacherID.Size = New System.Drawing.Size(173, 44)
        Me.txtTeacherID.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "នាមត្រកូល"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(225, 151)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(173, 44)
        Me.txtFirstName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 36)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "នាមខ្លួន"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(225, 201)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(173, 44)
        Me.txtLastName.TabIndex = 2
        '
        'cboSex
        '
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"ប្រុស", "ស្រី", "មិនដឹង"})
        Me.cboSex.Location = New System.Drawing.Point(225, 267)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(173, 44)
        Me.cboSex.TabIndex = 3
        Me.cboSex.Text = "ប្រុស"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ភេទ"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MMM\yyyy"
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(225, 339)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(212, 44)
        Me.dtpDOB.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 36)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ថ្ងៃខែឆ្នាំកំណើត"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(858, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 36)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "រូបថត"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(404, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 36)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "ទីកន្លែងកំណើត"
        '
        'txtPOB
        '
        Me.txtPOB.Location = New System.Drawing.Point(571, 92)
        Me.txtPOB.Name = "txtPOB"
        Me.txtPOB.Size = New System.Drawing.Size(173, 44)
        Me.txtPOB.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(404, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 36)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "អាស្រ័យដ្នាន"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(571, 151)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(173, 44)
        Me.txtAddress.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(404, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 36)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "លេខទូរស័ព្ទ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(404, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 36)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "សារអេឡិចត្រូនិច"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(571, 201)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(173, 44)
        Me.txtPhone.TabIndex = 7
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 420)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(109, 48)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "ថ្មី"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(127, 420)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 48)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "កែប្រែ"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(242, 420)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 48)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "រក្សាទុក"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(357, 420)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 48)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(864, 420)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 48)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "បិទ"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(749, 420)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(109, 48)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "ស្វែងរក"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(477, 422)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(267, 44)
        Me.txtSearch.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer Muol", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(351, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 50)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ព័ត៌មានគ្រូ"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(571, 267)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 44)
        Me.txtEmail.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(779, 309)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(156, 55)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "បញ្ចូលរូបភាព"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(941, 309)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(60, 55)
        Me.btnRemove.TabIndex = 18
        Me.btnRemove.Text = "X"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'opfPhoto
        '
        '
        'picPhoto
        '
        Me.picPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Image = Global.HongPro.My.Resources.Resources.pic
        Me.picPhoto.Location = New System.Drawing.Point(794, 111)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(167, 181)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 6
        Me.picPhoto.TabStop = False
        '
        'frmTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1013, 744)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPOB)
        Me.Controls.Add(Me.txtTeacherID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvTeacher)
        Me.Font = New System.Drawing.Font("Khmer OS System", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmTeacher"
        Me.Text = "Teacher"
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTeacher As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTeacherID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cboSex As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents picPhoto As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPOB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents opfPhoto As OpenFileDialog
End Class
