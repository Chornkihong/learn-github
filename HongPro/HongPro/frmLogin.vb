Imports System.Data.OleDb

Public Class frmLogin
    Dim obj As New clsUser
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If obj.Login(txtUserName.Text, txtPassword.Text) Then
            Me.Close()
            obj.GetMenuByUserID(frmMain.mnuMain, UserID)
            MsgBox("Login Success!")
        Else
            MsgBox("Login Fail!")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmMain.Close()

    End Sub

End Class
