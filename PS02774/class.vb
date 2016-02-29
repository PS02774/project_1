Imports System.Data.SqlClient
Imports System.IO

Module class1

    Public ds As New DataSet

    Public ConnectionString As String = " workstation id=PS02774.mssql.somee.com;packet size=4096;user id=PS02774_SQLLogin_1;pwd=g73invx149;data source=PS02774.mssql.somee.com;persist security info=False;initial catalog=PS02774"

    ' Public ConnectionString As String = "Server=GIAHUY-PC\SQLEXPRESS;Database=VBPS02774;Integrated Security=True" '
    Public Sub ExecuteNonQuery(Sql As String)
        Dim Connection As New SqlConnection(ConnectionString)
        Dim Command As New SqlCommand(Sql, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Public Sub connect(Sql As String, TableName As String)
        Dim Connection As New SqlConnection(ConnectionString)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        If ds.Tables.Contains(TableName) Then
            ds.Tables(TableName).Clear()
        End If
        DataAdapter.Fill(ds, TableName)

    End Sub

End Module
