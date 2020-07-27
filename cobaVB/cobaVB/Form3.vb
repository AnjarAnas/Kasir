Public Class Form3
    Sub hapus()
        usernam.Text = ""
        pass.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If usernam.Text = "admin" And pass.Text = "admin" Then
            Form2.Show()
            Me.Hide()
            hapus()
        ElseIf usernam.Text = "" And pass.Text = "" Then
            MsgBox("Form Tidak Boleh Kosong")
        Else
            MsgBox("Password Dan Username Anda Salah")
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernam.Text = "admin"
        pass.Text = "admin"
        pass.UseSystemPasswordChar = True
    End Sub
End Class