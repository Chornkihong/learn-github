Public Class frmUpdateDelete
    Public Delete As Boolean = False
    Private Sub frmUpdateDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer = 1
        For Each line As String In IO.File.ReadLines(Application.StartupPath + "\UpdateDelete.txt")
            'desplay the line
            If i = 1 Then
                txtSource.Text = line
            Else
                txtDestination.Text = line
            End If
            i += 1
        Next
        If txtDestination.Text = "Delete" Then
            IO.File.Delete(txtSource.Text)
        Else
            IO.File.Copy(txtSource.Text, txtDestination.Text, True)

        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        IO.File.WriteAllText(Application.StartupPath + "\StartUpForm.txt", "frmTeacher")
        Process.Start(Application.StartupPath + "\HongPro.exe")
        Close()

    End Sub
End Class
