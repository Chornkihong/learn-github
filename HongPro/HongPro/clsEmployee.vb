Imports System.Data.OleDb

Public Class clsEmployee
    Dim kEmployeeID As Integer, kFirstName As String, kLastName As String, kSex As String, kDOB As Date, kPOB As String, kAddress As String
    Dim kPhone As String, kEmail As String, kPhoto As String
    Property EmployeeID As String
        Get
            Return kEmployeeID
        End Get
        Set(value As String)
            kEmployeeID = value
        End Set
    End Property
    Property FirstName As String
        Get
            Return kFirstName
        End Get
        Set(value As String)
            kFirstName = value
        End Set
    End Property
    Property LastName As String
        Get
            Return kLastName
        End Get
        Set(value As String)
            kLastName = value
        End Set
    End Property
    Property Sex As String
        Get
            Return kSex
        End Get
        Set(value As String)
            kSex = value
        End Set
    End Property
    Property DOB As Date
        Get
            Return kDOB
        End Get
        Set(value As Date)
            kDOB = value
        End Set
    End Property
    Property POB As String
        Get
            Return kPOB
        End Get
        Set(value As String)
            kPOB = value
        End Set
    End Property
    Property Address As String
        Get
            Return kAddress
        End Get
        Set(value As String)
            kAddress = value
        End Set
    End Property
    Property Phone As String
        Get
            Return kPhone
        End Get
        Set(value As String)
            kPhone = value
        End Set
    End Property
    Property Email As String
        Get
            Return kEmail
        End Get
        Set(value As String)
            kEmail = value
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
    Function Getdata(TableName As String, q As String) As DataTable
        Dim dt As New DataTable
        Dim DA As New OleDbDataAdapter("Select * From " + TableName, cn)
        DA.SelectCommand.Parameters.AddWithValue("@q", q)
        Try
            DA.Fill(dt)
        Catch ex As Exception
            dt = Nothing
        End Try
        Return dt
    End Function
    Function Insert() As Boolean
        Dim check As Boolean = False
        Dim cmd As New OleDbCommand("INSERT INTO tblEmployee ( FirstName, LastName, Sex, DOB, POB, Address, Phone, Email,Photo )
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
        Dim cmd As New OleDbCommand("UPDATE tblEmployee SET FirstName = @FirstName, LastName = @LastName, Sex = @Sex, DOB = @DOB, POB = @POB, Address = @Address, Phone = @Phone, Email = @Email, Photo = @Photo,WHERE EmployeeID = @EmployeeID", cn)
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
        cmd.Parameters.Add("@EmployeeID", OleDbType.Integer).Value = EmployeeID
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
        Dim cmd As New OleDbCommand("DELETE FROM tblEmployee WHERE EmployeeID = @EmployeeID;", cn)
        cmd.Parameters.Add("@EmployeeID", OleDbType.Integer).Value = EmployeeID
        Try
            cmd.ExecuteNonQuery()
            check = True
        Catch ex As Exception
            check = False
        End Try
        Return check
    End Function
End Class
