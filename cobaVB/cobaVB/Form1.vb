Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim angka As Integer
    Dim minuman As Integer
    Dim diskon As Integer
    Dim total As Integer
    Dim bayar As Integer
    Dim total_makan As Integer
    Dim total_minum As Integer
    Dim kembalian As Integer
    Dim hasil As Double
    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Nasi Goreng" Then
            TextBox1.Text = "Rp 10.000"
        ElseIf ComboBox1.Text = "Soto" Then
            TextBox1.Text = "Rp 7.000"
        ElseIf ComboBox1.Text = "Rames" Then
            TextBox1.Text = "Rp 5.000"
        ElseIf ComboBox1.Text = "Pecel" Then
            TextBox1.Text = "Rp 6.000"
        End If
        If ComboBox1.Text = "Nasi Goreng" Then
            angka = 10000
        ElseIf ComboBox1.Text = "Soto" Then
            angka = 7000
        ElseIf ComboBox1.Text = "Rames" Then
            angka = 5000
        ElseIf ComboBox1.Text = "Pecel" Then
            angka = 6000
        End If
        total_makan = (angka * Val(JumlahBox.Text))
        total_minum = (minuman * Val(jumlah_minuman.Text))
        total = total_makan + total_minum
        Label14.Text = ("Rp" & total)
        total_bayar.Text = ("Rp" & total)
    End Sub

    Sub input()
        Dim cmd As MySqlCommand
        Dim str As String = "server=localhost;uid=root;pwd=;database=kantin"
        Dim con As New MySqlConnection(str)
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "insert into pesan (makanan,jlm_makanan,minuman,jlm_minuman,diskon,total) values(@makan,@harga_makan,@minum,@harga_minum,@diskon,@total)"
            cmd.Parameters.AddWithValue("@makan", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@harga_makan", JumlahBox.Text)
            cmd.Parameters.AddWithValue("@minum", menu_minuman.Text)
            cmd.Parameters.AddWithValue("@harga_minum", jumlah_minuman.Text)
            cmd.Parameters.AddWithValue("@diskon", tampil_diskon.Text)
            cmd.Parameters.AddWithValue("@total", total_bayar.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Nasi Goreng" Then
            angka = 10000
        ElseIf ComboBox1.Text = "Soto" Then
            angka = 7000
        ElseIf ComboBox1.Text = "Rames" Then
            angka = 5000
        ElseIf ComboBox1.Text = "Pecel" Then
            angka = 6000
        End If

        If menu_minuman.Text = "Es Teh" Then
            minuman = 2000
        ElseIf menu_minuman.Text = "Es Jeruk" Then
            minuman = 3000
        ElseIf menu_minuman.Text = "Degan" Then
            minuman = 5000
        ElseIf menu_minuman.Text = "Es Jus" Then
            minuman = 4000
        ElseIf menu_minuman.Text = "Teh Angget" Then
            minuman = 1500
        ElseIf menu_minuman.Text = "Kopi" Then
            minuman = 4500
        End If
        If ComboBox1.Text = "" Then
            total_bayar.Text = ""
            MsgBox("Form Tidak Boleh Kosong")
        Else
            total_makan = (angka * Val(JumlahBox.Text))
            total_minum = (minuman * Val(jumlah_minuman.Text))
            total = total_makan + total_minum
            bayar = total - diskon
            total_bayar.Text = ("Rp " & bayar)
            kembalian = Val(TextBox2.Text)
            If TextBox2.Text = "" Then
                MessageBox.Show("Form Uang Anda Tidak Boleh Kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf kembalian < bayar Then
                MessageBox.Show("Uang Yang Anda Berikan Kurang", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf kembalian = bayar Then
                MessageBox.Show("Uang Yang Anda Bayar Pas", "Transaksi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                input()

            Else
                hasil = kembalian - bayar
                MessageBox.Show("Kembalian Anda Sebesar Rp " & hasil, "Transaksi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                input()
            End If
        End If
    End Sub
    Sub reset()
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        JumlahBox.Text = ""
        menu_minuman.Text = ""
        TextBox3.Text = ""
        jumlah_minuman.Text = ""
        TextBox4.Text = ""
        tampil_diskon.Text = ""
        total_bayar.Text = ""

        notif.Text = ""
        Label14.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        total_bayar.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Nasi Goreng" Then
            angka = 10000
        ElseIf ComboBox1.Text = "Soto" Then
            angka = 7000
        ElseIf ComboBox1.Text = "Rames" Then
            angka = 5000
        ElseIf ComboBox1.Text = "Pecel" Then
            angka = 6000
        End If
        If menu_minuman.Text = "Es Teh" Then
            minuman = 2000
        ElseIf menu_minuman.Text = "Es Jeruk" Then
            minuman = 3000
        ElseIf menu_minuman.Text = "Degan" Then
            minuman = 5000
        ElseIf menu_minuman.Text = "Es Jus" Then
            minuman = 4000
        ElseIf menu_minuman.Text = "Teh Angget" Then
            minuman = 1500
        ElseIf menu_minuman.Text = "Kopi" Then
            minuman = 4500
        End If
        If Label14.Text = "" Then
            MsgBox("Anda Belom Memesan")

        Else
            If TextBox4.Text = "MAKANENAK" And total > 100000 Then
                diskon = 50000
                tampil_diskon.Text = ("Rp" & diskon)
                notif.Text = "Selamat Voucher Anda Siap Digunakan"
                total_makan = (angka * Val(JumlahBox.Text))
                total_minum = (minuman * Val(jumlah_minuman.Text))
                total = total_makan + total_minum
                bayar = total - diskon
                total_bayar.Text = ("Rp" & bayar)
            ElseIf TextBox4.Text = "MAKANKENYANG" And total > 70000 Then
                diskon = 30000
                tampil_diskon.Text = ("Rp" & diskon)
                notif.Text = "Selamat Voucher Anda Siap Digunakan"
                total_makan = (angka * Val(JumlahBox.Text))
                total_minum = (minuman * Val(jumlah_minuman.Text))
                total = total_makan + total_minum
                bayar = total - diskon
                total_bayar.Text = ("Rp" & bayar)
            ElseIf TextBox4.Text = "MAKANNIKMAT" And total > 50000 Then
                diskon = 20000
                tampil_diskon.Text = ("Rp" & diskon)
                notif.Text = "Selamat Voucher Anda Siap Digunakan"
                total_makan = (angka * Val(JumlahBox.Text))
                total_minum = (minuman * Val(jumlah_minuman.Text))
                total = total_makan + total_minum
                bayar = total - diskon
                total_bayar.Text = ("Rp" & bayar)
            Else
                total_makan = (angka * Val(JumlahBox.Text))
                total_minum = (minuman * Val(jumlah_minuman.Text))
                total = total_makan + total_minum
                bayar = total - diskon
                total_bayar.Text = ("Rp" & bayar)
            End If
        End If
        MsgBox("Masukan Voucher Anda, Bisa Dilihat Di Kode Voucher")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.usernam.Text = "admin"
        Form3.pass.Text = "admin"
        reset()
        Form3.Show()

    End Sub

    Private Sub Menu_minuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles menu_minuman.SelectedIndexChanged
        If menu_minuman.Text = "Es Teh" Then
            TextBox3.Text = "Rp 2.000"
        ElseIf menu_minuman.Text = "Es Jeruk" Then
            TextBox3.Text = "Rp 3.000"
        ElseIf menu_minuman.Text = "Degan" Then
            TextBox3.Text = "Rp 5.000"
        ElseIf menu_minuman.Text = "Es Jus" Then
            TextBox3.Text = "Rp 4.000"
        ElseIf menu_minuman.Text = "Teh Angget" Then
            TextBox3.Text = "Rp 1.500"
        ElseIf menu_minuman.Text = "Kopi" Then
            TextBox3.Text = "Rp 4.500"
        End If
        If menu_minuman.Text = "Es Teh" Then
            minuman = 2000
        ElseIf menu_minuman.Text = "Es Jeruk" Then
            minuman = 3000
        ElseIf menu_minuman.Text = "Degan" Then
            minuman = 5000
        ElseIf menu_minuman.Text = "Es Jus" Then
            minuman = 4000
        ElseIf menu_minuman.Text = "Teh Angget" Then
            minuman = 1500
        ElseIf menu_minuman.Text = "Kopi" Then
            minuman = 4500
        End If
        total_makan = (angka * Val(JumlahBox.Text))
        total_minum = (minuman * Val(jumlah_minuman.Text))
        total = total_makan + total_minum
        Label14.Text = ("Rp" & total)
        total_bayar.Text = ("Rp" & total)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        reset()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            If TextBox2.Text = "" Then
                MessageBox.Show("Form Uang Anda Tidak Boleh Kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CheckBox2.Checked = False
            Else
                If ComboBox1.Text = "Nasi Goreng" Then
                    angka = 10000
                ElseIf ComboBox1.Text = "Soto" Then
                    angka = 7000
                ElseIf ComboBox1.Text = "Rames" Then
                    angka = 5000
                ElseIf ComboBox1.Text = "Pecel" Then
                    angka = 6000
                End If
                If menu_minuman.Text = "Es Teh" Then
                    minuman = 2000
                ElseIf menu_minuman.Text = "Es Jeruk" Then
                    minuman = 3000
                ElseIf menu_minuman.Text = "Degan" Then
                    minuman = 5000
                ElseIf menu_minuman.Text = "Es Jus" Then
                    minuman = 4000
                ElseIf menu_minuman.Text = "Teh Angget" Then
                    minuman = 1500
                ElseIf menu_minuman.Text = "Kopi" Then
                    minuman = 4500
                End If
                total_makan = (angka * Val(JumlahBox.Text))
                total_minum = (minuman * Val(jumlah_minuman.Text))
                total = total_makan + total_minum
                bayar = total - diskon
                kembalian = Val(TextBox2.Text)
                Form5.Label5.Text = ComboBox1.Text
                Form5.Label6.Text = menu_minuman.Text
                hasil = kembalian - ("Rp " & bayar)
                Form5.Label9.Text = ("Rp " & total_makan)
                Form5.Label10.Text = ("Rp " & total_minum)
                Form5.Label15.Text = Val(jumlah_minuman.Text)
                Form5.Label14.Text = Val(JumlahBox.Text)
                Form5.Label13.Text = ("Rp " & diskon)
                Form5.Label19.Text = ("Rp " & total)
                Form5.Label23.Text = ("Rp " & total)
                Form5.Label24.Text = ("Rp " & diskon)
                Form5.Label27.Text = ("Rp " & bayar)
                Form5.Label30.Text = ("Rp " & kembalian)
                Form5.Label33.Text = ("Rp " & hasil)
                Form5.Show()
                CheckBox2.Checked = False
            End If
        End If
    End Sub

    Private Sub Jumlah_minuman_TextChanged(sender As Object, e As EventArgs) Handles jumlah_minuman.TextChanged
        If ComboBox1.Text = "Nasi Goreng" Then
            angka = 10000
        ElseIf ComboBox1.Text = "Soto" Then
            angka = 7000
        ElseIf ComboBox1.Text = "Rames" Then
            angka = 5000
        ElseIf ComboBox1.Text = "Pecel" Then
            angka = 6000
        End If
        If menu_minuman.Text = "Es Teh" Then
            minuman = 2000
        ElseIf menu_minuman.Text = "Es Jeruk" Then
            minuman = 3000
        ElseIf menu_minuman.Text = "Degan" Then
            minuman = 5000
        ElseIf menu_minuman.Text = "Es Jus" Then
            minuman = 4000
        ElseIf menu_minuman.Text = "Teh Angget" Then
            minuman = 1500
        ElseIf menu_minuman.Text = "Kopi" Then
            minuman = 4500
        End If

        total_makan = (angka * Val(JumlahBox.Text))
            total_minum = (minuman * Val(jumlah_minuman.Text))
            total = total_makan + total_minum
            Label14.Text = ("Rp" & total)
        total_bayar.Text = ("Rp" & total)

    End Sub

    Private Sub JumlahBox_TextChanged(sender As Object, e As EventArgs) Handles JumlahBox.TextChanged
        If ComboBox1.Text = "Nasi Goreng" Then
            angka = 10000
        ElseIf ComboBox1.Text = "Soto" Then
            angka = 7000
        ElseIf ComboBox1.Text = "Rames" Then
            angka = 5000
        ElseIf ComboBox1.Text = "Pecel" Then
            angka = 6000
        End If
        If menu_minuman.Text = "Es Teh" Then
            minuman = 2000
        ElseIf menu_minuman.Text = "Es Jeruk" Then
            minuman = 3000
        ElseIf menu_minuman.Text = "Degan" Then
            minuman = 5000
        ElseIf menu_minuman.Text = "Es Jus" Then
            minuman = 4000
        ElseIf menu_minuman.Text = "Teh Angget" Then
            minuman = 1500
        ElseIf menu_minuman.Text = "Kopi" Then
            minuman = 4500
        End If

        total_makan = (angka * Val(JumlahBox.Text))
        total_minum = (minuman * Val(jumlah_minuman.Text))
        total = total_makan + total_minum
        Label14.Text = ("Rp" & total)
        total_bayar.Text = ("Rp" & total)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If ComboBox1.Text = "Nasi Goreng" Then
            angka = 10000
        ElseIf ComboBox1.Text = "Soto" Then
            angka = 7000
        ElseIf ComboBox1.Text = "Rames" Then
            angka = 5000
        ElseIf ComboBox1.Text = "Pecel" Then
            angka = 6000
        End If
        If menu_minuman.Text = "Es Teh" Then
            minuman = 2000
        ElseIf menu_minuman.Text = "Es Jeruk" Then
            minuman = 3000
        ElseIf menu_minuman.Text = "Degan" Then
            minuman = 5000
        ElseIf menu_minuman.Text = "Es Jus" Then
            minuman = 4000
        ElseIf menu_minuman.Text = "Teh Angget" Then
            minuman = 1500
        ElseIf menu_minuman.Text = "Kopi" Then
            minuman = 4500
        End If
        If TextBox4.Text = "" Then
            total_makan = (angka * Val(JumlahBox.Text))
            total_minum = (minuman * Val(jumlah_minuman.Text))
            total = total_makan + total_minum
            diskon = 0
            bayar = total - diskon
            total_bayar.Text = ("Rp" & bayar)


        End If

    End Sub
End Class
