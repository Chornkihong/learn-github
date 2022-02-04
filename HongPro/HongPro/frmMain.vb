Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\SchooDB.mdb"
        Try
            cn.Open()
            If IO.File.ReadAllText(Application.StartupPath + "\StartUpForm.txt") = "frmTeacher" Then
                frmUser.MdiParent = Me
                frmUser.WindowState = FormWindowState.Maximized
                IO.File.WriteAllText(Application.StartupPath + "\StartUpForm.txt", "")
                frmUser.Show()
            Else
                'frmLogin.MdiParent = Me
                frmLogin.StartPosition = FormStartPosition.CenterScreen
                frmLogin.ShowDialog()


            End If
        Catch ex As Exception
            MsgBox("Connection Fail!")

        End Try
    End Sub

    Private Sub ពតមនគរToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTeacher.Click
        frmUser.MdiParent = Me
        frmUser.WindowState = FormWindowState.Maximized
        frmUser.Show()
    End Sub

    Private Sub mnuLoggin_Click(sender As Object, e As EventArgs) Handles mnuLoggin.Click
        frmLogin.txtUserName.Text = ""
        frmLogin.txtPassword.Text = ""
        frmLogin.StartPosition = FormStartPosition.CenterScreen
        frmLogin.ShowDialog()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()

    End Sub

    Private Sub mnuUser_Click(sender As Object, e As EventArgs) Handles mnuUser.Click
        frmUser.MdiParent = Me
        frmUser.WindowState = FormWindowState.Maximized
        frmUser.Show()

    End Sub
End Class
