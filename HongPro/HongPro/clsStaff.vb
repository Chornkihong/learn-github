Imports System.Data.OleDb

Public Class clsStaff
    Dim kFirstName As String
    Dim kLastName As String
    Dim kSex As String
    Dim kDOB As Date
    Dim kPOB As String
    Dim kAddress As String
    Dim kPhone As String
    Dim kEmail As String

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
    Function Getage() As Integer
        Dim Age As Integer

        Age = Now().Year - kDOB.Year
        Return Age
    End Function



End Class
