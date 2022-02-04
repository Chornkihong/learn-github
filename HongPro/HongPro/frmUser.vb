Public Class frmUser
    Dim objUser As New clsUser
    Dim objUserRole As New clsUserRole

    Private Sub frmTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LookUpCombobox(RoleID, "Select RoleID,RoleName From tblRole")
        dgvUser.DataSource = objUser.Getdata("tblUser")
        dgvUserRole.DataSource = objUserRole.Getdata("tblUserRole", txtUserID.Text)
        dgvUser.Columns("Password").Visible = False
        dgvUser.Columns("UserID").HeaderText = "លេខកូដ"
        dgvUser.Columns("UserName").HeaderText = "ឈ្មោះអ្នកប្រើប្រាស់"
        dgvUser.Columns("UserName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        objUser.UserName = txtUserName.Text
        objUser.Password = txtPassword.Text
        If objUser.Insert() Then
            dgvUser.DataSource = objUser.Getdata("tblUser")
            MsgBox("Success!")
        Else
            MsgBox("Fail")
        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        objUser.UserID = Val(txtUserID.Text)
        objUser.UserName = txtUserName.Text
        objUser.Password = txtPassword.Text

        If objUser.Update() Then
            dgvUser.DataSource = objUser.Getdata(" tblUser ")
            MsgBox("Success!")
        Else
            MsgBox("Fail")
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        objUser.UserID = Val(txtUserID.Text)
        If objUser.Delete() Then
            dgvUser.DataSource = objUser.Getdata(" tblUser ")
            MsgBox("Success!")
        Else
            MsgBox("Fail")
        End If
    End Sub

    Private Sub dgvTeacher_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUser.SelectionChanged
        Try
            txtUserID.Text = dgvUser.CurrentRow.Cells("UserID").Value
            txtUserName.Text = dgvUser.CurrentRow.Cells("UserName").Value
            txtPassword.Text = dgvUser.CurrentRow.Cells("Password").Value
            dgvUserRole.DataSource = objUserRole.Getdata("tblUserRole", txtUserID.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'dgvUser.DataSource = objUser.GetdataSearch("tblTeacher", txtSearch.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearTextBox(Me)
        txtUserName.Focus()
    End Sub

    Private Sub btnAddSecurity_Click(sender As Object, e As EventArgs) Handles btnAddSecurity.Click
        Dim check As Boolean = False

        For Each dr As DataGridViewRow In dgvUserRole.Rows
            If dr.Index < dgvUserRole.Rows.Count - 1 Then
                objUserRole.UserID = Val(txtUserID.Text)
                objUserRole.RoleID = Val(dr.Cells("RoleID").Value)

                If IsDBNull(dr.Cells("UserRoleID").Value) Then
                    If objUserRole.Insert() = False Then

                        check = False
                        Exit For

                    End If
                Else
                    objUserRole.UserRoleID = Val(dr.Cells("UserRoleID").Value)
                    If objUserRole.Update() = False Then
                        check = False
                        Exit For

                    End If

                End If
            End If

            check = True

        Next
        If check Then
            MsgBox("Assign Role Success!")
        Else
            MsgBox("Assign Role Fail!")
        End If
    End Sub
End Class