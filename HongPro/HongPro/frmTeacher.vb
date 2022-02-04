Public Class frmTeacher
    Dim obj As New clsTeacher

    Private Sub frmTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTeacher.DataSource = obj.Getdata("tblTeacher")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        obj.FirstName = txtFirstName.Text
        obj.LastName = txtLastName.Text
        obj.Sex = cboSex.Text
        obj.DOB = dtpDOB.Value
        obj.POB = txtPOB.Text
        obj.Address = txtAddress.Text
        obj.Phone = txtPhone.Text
        obj.Email = txtEmail.Text
        obj.Photo = ""
        ' open image from open file dialog


        If opfPhoto.FileName <> "" Then
            Dim m As New IO.FileInfo(opfPhoto.FileName)
            obj.Photo = (dgvTeacher.Rows.Count + 1).ToString() + m.Extension
        End If

        If obj.Insert() Then
            If opfPhoto.FileName <> "" Then
                IO.File.Copy(opfPhoto.FileName, Application.StartupPath + "\Photo\" + obj.Photo, True)
            End If


            dgvTeacher.DataSource = obj.Getdata("tblTeacher")
            MsgBox("Success!")
        Else
            MsgBox("Fail")
        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        obj.TeacherID = Val(txtTeacherID.Text)
        obj.FirstName = txtFirstName.Text
        obj.LastName = txtLastName.Text
        obj.Sex = cboSex.Text
        obj.DOB = dtpDOB.Value
        obj.POB = txtPOB.Text
        obj.Address = txtAddress.Text
        obj.Phone = txtPhone.Text
        obj.Email = txtEmail.Text


        If opfPhoto.FileName <> "" Then
            Dim m As New IO.FileInfo(opfPhoto.FileName)
            obj.Photo = dgvTeacher.CurrentRow.Cells("TeacherID").Value.ToString() + m.Extension
        Else
            obj.Photo = dgvTeacher.CurrentRow.Cells("Photo").Value
        End If

        If obj.Update() Then
            'IO.File.Copy(opfPhoto.FileName, Application.StartupPath + "\Photo\" + obj.Photo, True)
            'Dim frm As New frmUpdateDelete()
            'frm.Delete = False
            'frm.txtSource.Text = opfPhoto.FileName
            'frm.txtDestination.Text = Application.StartupPath + "\Photo\" + obj.Photo
            'frm.ShowDialog()
            If opfPhoto.FileName <> "" Then
                IO.File.WriteAllText(Application.StartupPath + "\UpdateDelete.txt", opfPhoto.FileName + vbNewLine + Application.StartupPath + "\Photo\" + obj.Photo)
                Process.Start(Application.StartupPath + "\UpdateDeletePhoto.exe")
                frmMain.Close()
            End If
            dgvTeacher.DataSource = obj.Getdata(" tblTeacher ")
            MsgBox("Success!")
        Else
            MsgBox("Fail")
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        obj.TeacherID = Val(txtTeacherID.Text)
        If obj.Delete() Then
            IO.File.WriteAllText(Application.StartupPath + "\UpdateDelete.txt", Application.StartupPath + "\Photo\" + dgvTeacher.CurrentRow.Cells("Photo").Value.ToString() + vbNewLine + "Delete")
            Process.Start(Application.StartupPath + "\UpdateDeletePhoto.exe")
            frmMain.Close()
            dgvTeacher.DataSource = obj.Getdata(" tblTeacher ")
            MsgBox("Success!")
        Else
            MsgBox("Fail")
        End If
    End Sub

    Private Sub dgvTeacher_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTeacher.SelectionChanged
        Try
            txtTeacherID.Text = dgvTeacher.CurrentRow.Cells("TeacherID").Value
            txtFirstName.Text = dgvTeacher.CurrentRow.Cells("FirstName").Value
            txtLastName.Text = dgvTeacher.CurrentRow.Cells("LastName").Value
            cboSex.Text = dgvTeacher.CurrentRow.Cells("Sex").Value
            dtpDOB.Value = dgvTeacher.CurrentRow.Cells("DOB").Value
            txtPOB.Text = dgvTeacher.CurrentRow.Cells("POB").Value
            txtAddress.Text = dgvTeacher.CurrentRow.Cells("Address").Value
            txtPhone.Text = dgvTeacher.CurrentRow.Cells("Phone").Value
            txtEmail.Text = dgvTeacher.CurrentRow.Cells("Email").Value
            'if have a photo
            If dgvTeacher.CurrentRow.Cells("Photo").Value <> "" Then
                picPhoto.Image = Image.FromFile(Application.StartupPath + "\Photo\" + dgvTeacher.CurrentRow.Cells("Photo").Value.ToString())
            Else
                picPhoto.Image = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dgvTeacher.DataSource = obj.GetdataSearch("tblTeacher", txtSearch.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearTextBox(Me)
        txtFirstName.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        opfPhoto.Filter = "All File|*.jpg;*.png;*.gif|*.jpg|*.jpg|*.png|*.png|*.gif|*.gif"
        opfPhoto.ShowDialog()

    End Sub

    Private Sub opfPhoto_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opfPhoto.FileOk
        picPhoto.Image = Image.FromFile(opfPhoto.FileName)
    End Sub

End Class