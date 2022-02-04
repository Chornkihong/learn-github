Imports System.Data.OleDb

Public Class clsSave
    Dim ySaveID As Integer
    Dim ySaveDate As Date
    Dim ySaverID As Integer
    Dim yCashin As Double
    Dim yInterest As Integer
    Dim yEmployeeID As Integer
    Dim yCurrencyID As Integer

    Public Property SaveID As Integer
        Get
            Return ySaveID
        End Get
        Set(value As Integer)
            ySaveID = value
        End Set
    End Property

    Public Property SaveDate As Date
        Get
            Return ySaveDate
        End Get
        Set(value As Date)
            ySaveDate = value
        End Set
    End Property

    Public Property SaverID As Integer
        Get
            Return ySaverID
        End Get
        Set(value As Integer)
            ySaverID = value
        End Set
    End Property

    Public Property Cashin As Double
        Get
            Return yCashin
        End Get
        Set(value As Double)
            yCashin = value
        End Set
    End Property

    Public Property Interest As Integer
        Get
            Return yInterest
        End Get
        Set(value As Integer)
            yInterest = value
        End Set
    End Property

    Public Property EmployeeID As Integer
        Get
            Return yEmployeeID
        End Get
        Set(value As Integer)
            yEmployeeID = value
        End Set
    End Property

    Public Property CurrencyID As Integer
        Get
            Return yCurrencyID
        End Get
        Set(value As Integer)
            yCurrencyID = value
        End Set
    End Property
    Function Getdata(TableName As String) As DataTable
        Dim dt As New DataTable
        Dim DA As New OleDbDataAdapter("Select * From " + TableName, cn)
        Try
            DA.Fill(dt)
        Catch ex As Exception
            dt = Nothing
        End Try
        Return dt
    End Function
    Function Insert() As Boolean
        Dim check As Boolean = False
        Dim cmd As New OleDbCommand("INSERT INTO Save_Tbl (SaverID,SaveDate,Cashin,Interest,EmployeeID,CurrencyID)
values( @SaverID, @SaveDate, @Cashin, @Interest, @EmployeeID,@CurrencyID )", cn)
        cmd.Parameters.Add("@SaverID", OleDbType.VarChar).Value = SaverID
        cmd.Parameters.Add("@SaveDate", OleDbType.VarChar).Value = SaveDate
        cmd.Parameters.Add("@Cashin", OleDbType.VarChar).Value = Cashin
        cmd.Parameters.Add("@Interest", OleDbType.Date).Value = Interest
        cmd.Parameters.Add("@EmployeeID", OleDbType.VarChar).Value = EmployeeID
        cmd.Parameters.Add("@CurrencyID", OleDbType.Date).Value = CurrencyID

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
        Dim cmd As New OleDbCommand("UPDATE Save_Tbl SET SaverID = @SaverID, SaveDate = @SaveDate, Cashin = @Cashin, Interest = @Interest, EmployeeID = @EmployeeID, CurrencyID = @CurrencyID,WHERE SaveID = @SaveID", cn)
        cmd.Parameters.Add("@SaverID", OleDbType.VarChar).Value = SaverID
        cmd.Parameters.Add("@SaveDate", OleDbType.VarChar).Value = SaveDate
        cmd.Parameters.Add("@Cashin", OleDbType.VarChar).Value = Cashin
        cmd.Parameters.Add("@Interest", OleDbType.Date).Value = Interest
        cmd.Parameters.Add("@EmployeeID", OleDbType.VarChar).Value = EmployeeID
        cmd.Parameters.Add("@CurrencyID", OleDbType.Date).Value = CurrencyID
        cmd.Parameters.Add("@SaveID", OleDbType.Integer).Value = SaveID
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
        Dim cmd As New OleDbCommand("DELETE FROM Save_Tbl WHERE SaveID = @SaveID;", cn)
        cmd.Parameters.Add("@SaveID", OleDbType.Integer).Value = SaveID
        Try
            cmd.ExecuteNonQuery()
            check = True
        Catch ex As Exception
            check = False
        End Try
        Return check
    End Function

End Class
