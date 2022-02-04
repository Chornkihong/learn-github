Imports System.Data.OleDb

Public Class clsUser

    Dim m_UserID As Integer
    Dim m_UserName As String
    Dim m_Password As String

    Public Property UserID As Integer
        Get
            Return m_UserID
        End Get
        Set(value As Integer)
            m_UserID = value
        End Set
    End Property

    Public Property UserName As String
        Get
            Return m_UserName
        End Get
        Set(value As String)
            m_UserName = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return m_Password
        End Get
        Set(value As String)
            m_Password = value
        End Set
    End Property
    Function Insert() As Boolean
        Dim check As Boolean = False
        Dim cmd As New OleDbCommand("INSERT INTO tblUser ( UserName, Password )
values( @UserName, @Password )", cn)
        cmd.Parameters.Add("@UserName", OleDbType.VarChar).Value = UserName
        cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = Password

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
        Dim cmd As New OleDbCommand("UPDATE tblUser SET 
                                      UserName = @UserName,Password = @Password, 
                                      WHERE UserID = @UserID", cn)


        cmd.Parameters.Add("@UserID", OleDbType.VarChar).Value = UserID
        cmd.Parameters.Add("@UserName", OleDbType.VarChar).Value = UserName
        cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = Password


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
        Dim cmd As New OleDbCommand("DELETE FROM tblUser WHERE UserID = @UserID", cn)

        cmd.Parameters.Add("@UserID", OleDbType.Integer).Value = UserID

        Try
            cmd.ExecuteNonQuery()
            check = True
        Catch ex As Exception
            check = False
        End Try
        Return check

    End Function
    Function Getdata(TableName As String) As DataTable
        Dim dt As New DataTable
        Dim DA As New OleDbDataAdapter("Select * From " + TableName, cn)
        'DA.SelectCommand.Parameters.AddWithValue("@q", q)
        Try
            DA.Fill(dt)
        Catch ex As Exception
            dt = Nothing
        End Try
        Return dt
    End Function


    Function Login(pUserName As String, pPassword As String) As Boolean
        Dim check As Boolean
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("SELECT tblUser.UserID FROM tblUser WHERE tblUser.UserName = @UserName AND tblUser.Password = @Password;", cn)
        da.SelectCommand.Parameters.AddWithValue("@UserName", pUserName)
        da.SelectCommand.Parameters.AddWithValue("@Password", pPassword)
        Try
            da.Fill(dt)
            modConnection.UserID = dt.Rows(0)(0)
            check = True
        Catch ex As Exception
            check = False
        End Try
        Return check

    End Function
    Sub GetMenu(mnu As MenuStrip, pUserID As Integer)
        Dim da As New OleDbDataAdapter("SELECT tblRole.ControlName FROM tblRole INNER JOIN tblUserRole ON tblRole.RoleID = tblUserRole.RoleID  WHERE tblUserRole.UserID=@UserID;", cn)
        da.SelectCommand.Parameters.AddWithValue("@UserID", pUserID)
        Dim dt As New DataTable
        Dim m As ToolStripMenuItem
        Dim ready As Boolean = False

        Try
            da.Fill(dt)
            For Each m In mnu.Items
                Dim strM As String
                For Each dr In dt.Rows
                    strM = dr(0)
                    If dr(0) = mnu.Name Then
                        mnu.Enabled = True
                        ready = True
                        GoTo ExitMenu
                    Else
                        mnu.Enabled = False

                    End If
                    If ready = True Then
                        ready = False
                        For Each sm As ToolStripMenuItem In m.DropDownItems
                            Dim str As String = dr(0)
                            If sm.Name = str Then
                                sm.Enabled = True
                                GoTo ExitMenu
                            Else
                                sm.Enabled = False

                            End If

                        Next
                    End If
                Next
ExitMenu:
            Next
        Catch ex As Exception

        End Try
    End Sub
    Sub GetMenuByUserID(mnu As MenuStrip, pUserID As Integer)
        Dim ready As Boolean = False
        Dim m As ToolStripMenuItem
        For Each sm As ToolStripMenuItem In mnu.Items
            For Each sim As ToolStripMenuItem In sm.DropDownItems
                m = sim
                Dim da As New OleDbDataAdapter("SELECT tblRole.ControlName FROM tblRole INNER JOIN tblUserRole ON tblRole.RoleID = tblUserRole.RoleID  WHERE tblUserRole.UserID=@UserID and ControlName =@mnu;", cn)
                da.SelectCommand.Parameters.AddWithValue("@UserID", pUserID)
                da.SelectCommand.Parameters.AddWithValue("@mnu", m.Name)
                Dim dt As New DataTable


                Try
                    da.Fill(dt)
                    If dt.Rows.Count >= 1 Then
                        sim.Enabled = True
                    Else
                        sim.Enabled = False
                    End If

                Catch ex As Exception
                    sim.Enabled = False

                End Try

            Next
        Next
    End Sub

End Class
