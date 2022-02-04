Imports System.Data.OleDb

Module modConnection
    Public cn As New OleDbConnection
    Public UserID As Integer
    Sub ClearTextBox(frm As Form)
        For Each c As Control In frm.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub

    Sub LookUpComBobox(cbo As ComboBox, sql As String)
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cbo.DataSource = dt
            cbo.ValueMember = dt.Columns(0).ColumnName
            cbo.DisplayMember = dt.Columns(1).ColumnName
        Catch ex As Exception

        End Try

    End Sub
    Sub LookUpCombobox(cbo As DataGridViewComboBoxColumn, sql As String)
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cbo.DataSource = dt
            cbo.ValueMember = dt.Columns(0).ColumnName
            cbo.DisplayMember = dt.Columns(1).ColumnName
        Catch ex As Exception

        End Try

    End Sub
End Module
