Imports MySql.Data.MySqlClient
Public Class Form4
    Dim str As String = "server=localhost;uid=root;pwd=;database=voucher"
    Dim con As New MySqlConnection(str)
    Sub tampil()
        con.Open()
        Dim query As String = "select * from kode"
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub
End Class