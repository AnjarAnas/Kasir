Imports MySql.Data.MySqlClient
Public Class Form2
    Dim str As String = "server=localhost;uid=root;pwd=;database=kantin"
    Dim con As New MySqlConnection(str)

    Sub tampil()
        con.Open()
        Dim query As String = "select * from pesan"
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub
End Class