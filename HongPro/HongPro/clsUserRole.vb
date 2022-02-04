Imports System.Data.OleDb

Public Class clsUserRole

    Dim m_UserRoleID As Integer
    Dim m_UserID As Integer
    Dim m_RoleID As Integer

    Public Property UserRoleID As Integer
        Get
            Return m_UserRoleID
        End Get
        Set(value As Integer)
            m_UserRoleID = value
        End Set
    End Property

    Public Property UserID As Integer
        Get
            Return m_UserID
        End Get
        Set(value As Integer)
            m_UserID = value
        End Set
    End Property

    Public Property RoleID As Integer
        Get
            Return m_RoleID
        End Get
        Set(value As Integer)
            m_RoleID = value
        End Set
    End Property
    Function Getdata(TableName As String, pUserID As Integer) As DataTable
        Dim dt As New DataTable
        Dim DA As New OleDbDataAdapter("Select * From " + TableName + " Where UserID = @UserID ", cn)
        DA.SelectCommand.Parameters.AddWithValue("@UserID", pUserID)
        Try
            DA.Fill(dt)
        Catch ex As Exception
            dt = Nothing
        End Try
        Return dt
    End Function
    Function Insert() As Boolean
        Dim check As Boolean = False
        Dim cmd As New OleDbCommand("INSERT INTO tblUserRole ( UserID, RoleID )
                                    values( @UserID, @RoleID )", cn)
        cmd.Parameters.Add("@UserID", OleDbType.Integer).Value = UserID
        cmd.Parameters.Add("@RoleID", OleDbType.Integer).Value = RoleID

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
        Dim cmd As New OleDbCommand("UPDATE tblUserRole SET 
                                      UserID = @UserID,RoleID = @RoleID, 
                                      WHERE UserRoleID = @UserRoleID", cn)


        cmd.Parameters.Add("@UserID", OleDbType.Integer).Value = UserID
        cmd.Parameters.Add("@RoleID", OleDbType.Integer).Value = RoleID
        cmd.Parameters.Add("@UserRoleID", OleDbType.Integer).Value = UserRoleID


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
        Dim cmd As New OleDbCommand("DELETE FROM tblUserRole WHERE UserRoleID = @UserRoleID", cn)

        cmd.Parameters.Add("@UserRoleID", OleDbType.Integer).Value = UserRoleID

        Try
            cmd.ExecuteNonQuery()
            check = True
        Catch ex As Exception
            check = False
        End Try
        Return check

    End Function

End Class
