Imports System.Data.OleDb

Public Class clsTeacher
    Inherits clsStaff
    Dim kTeacherID As Integer
    Dim kPhoto As String

    Property TeacherID As Integer
        Get
            Return kTeacherID

        End Get
        Set(value As Integer)
            kTeacherID = value
        End Set
    End Property
    Property Photo As String
        Get
            Return kPhoto

        End Get
        Set(value As String)
            kPhoto = value
        End Set
    End Property
    Function Insert() As Boolean
        Dim check As Boolean = False
        Dim cmd As New OleDbCommand("INSERT INTO tblTeacher ( FirstName, LastName, Sex, DOB, POB, Address, Phone, Email,Photo )
values( @FirstName, @LastName, @Sex, @DOB, @POB,@Address, @Phone, @Email,@Photo )", cn)
        cmd.Parameters.Add("@FirstName", OleDbType.VarChar).Value = FirstName
        cmd.Parameters.Add("@LastName", OleDbType.VarChar).Value = LastName
        cmd.Parameters.Add("@Sex", OleDbType.VarChar).Value = Sex
        cmd.Parameters.Add("@DOB", OleDbType.Date).Value = DOB
        cmd.Parameters.Add("@POB", OleDbType.VarChar).Value = POB
        cmd.Parameters.Add("@Address", OleDbType.VarChar).Value = Address
        cmd.Parameters.Add("@Phone", OleDbType.VarChar).Value = Phone
        cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = Email
        cmd.Parameters.Add("@Photo", OleDbType.VarChar).Value = Photo

        Try
            cmd.ExecuteNonQuery()
            check = True
        Catch ex As Exception
            check = False
        End Try
        Return check

    End Function
    Function Update() As Boolean
        Dim check As Boolean = False
        Dim cmd As New OleDbCommand("UPDATE tblTeacher SET 
 tblTeacher.FirstName = @FirstName, tblTeacher.LastName = @LastName, tblTeacher.Sex = @Sex, tblTeacher.DOB = @DOB, tblTeacher.POB = @POB, tblTeacher.Address = @Address, tblTeacher.Phone = @Phone, tblTeacher.Email = @Email, tblTeacher.Photo = @Photo

WHERE TeacherID = @TeacherID", cn)


        cmd.Parameters.Add("@FirstName", OleDbType.VarChar).Value = FirstName
        cmd.Parameters.Add("@LastName", OleDbType.VarChar).Value = LastName
        cmd.Parameters.Add("@Sex", OleDbType.VarChar).Value = Sex
        cmd.Parameters.Add("@DOB", OleDbType.Date).Value = DOB
        cmd.Parameters.Add("@POB", OleDbType.VarChar).Value = POB
        cmd.Parameters.Add("@Address", OleDbType.VarChar).Value = Address
        cmd.Parameters.Add("@Phone", OleDbType.VarChar).Value = Phone
        cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = Email
        If Photo <> "" Then
            cmd.Parameters.Add("@Photo", OleDbType.VarChar).Value = Photo
        End If

        cmd.Parameters.Add("@TeacherID", OleDbType.Integer).Value = TeacherID

        Try
            cmd.ExecuteNonQuery()
            check = True
        Catch ex As Exception
            check = False
        End Try
        Return check

    End Function
    Function Delete() As Boolean
        Dim check As Boolean = False
        Dim cmd As New OleDbCommand("DELETE FROM tblTeacher WHERE TeacherID = @TeacherID;", cn)

        cmd.Parameters.Add("@TeacherID", OleDbType.Integer).Value = TeacherID

        Try
            cmd.ExecuteNonQuery()
            check = True
        Catch ex As Exception
            check = False
        End Try
        Return check

    End Function
    Function GetdataSearch(TableName As String, q As String) As DataTable
        Dim dt As New DataTable
        Dim DA As New OleDbDataAdapter("Select * From " + TableName + " where FirstName & LastName like '%' & @q & '%' ", cn)
        DA.SelectCommand.Parameters.AddWithValue("@q", q)
        Try
            DA.Fill(dt)
        Catch ex As Exception
            dt = Nothing
        End Try
        Return dt
    End Function

End Class
