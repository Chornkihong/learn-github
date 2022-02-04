<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateDelete
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ទីតាំងដើម"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ទីតាំងដាក់ឬលុប"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(178, 60)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(510, 44)
        Me.txtSource.TabIndex = 2
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(178, 125)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(510, 44)
        Me.txtDestination.TabIndex = 2
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(348, 192)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(111, 49)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "បិទ"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'frmUpdateDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 438)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Khmer OS System", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmUpdateDelete"
        Me.Text = "UpdateDeletePhoto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnclose As Button
    Public WithEvents txtSource As TextBox
    Public WithEvents txtDestination As TextBox
End Class
