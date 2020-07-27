<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.total_bayar = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.JumlahBox = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.notif = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.menu_minuman = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.jumlah_minuman = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tampil_diskon = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Harga"
        '
        'TextBox1
        '
        Me.TextBox1.HideSelection = False
        Me.TextBox1.Location = New System.Drawing.Point(336, 260)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(140, 22)
        Me.TextBox1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nasi Goreng", "Soto", "Rames", "Pecel"})
        Me.ComboBox1.Location = New System.Drawing.Point(41, 258)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(360, 653)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Bayar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'total_bayar
        '
        Me.total_bayar.Location = New System.Drawing.Point(170, 621)
        Me.total_bayar.Name = "total_bayar"
        Me.total_bayar.ReadOnly = True
        Me.total_bayar.Size = New System.Drawing.Size(208, 22)
        Me.total_bayar.TabIndex = 5
        Me.total_bayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(336, 360)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(140, 22)
        Me.TextBox3.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pesanan Anda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tekton Pro", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 589)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total Yang Harus Anda Bayar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 694)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Terimakash Atas Kunjungannya"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Jumlah"
        '
        'JumlahBox
        '
        Me.JumlahBox.Location = New System.Drawing.Point(41, 310)
        Me.JumlahBox.Name = "JumlahBox"
        Me.JumlahBox.Size = New System.Drawing.Size(158, 22)
        Me.JumlahBox.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(205, 518)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(140, 22)
        Me.TextBox4.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(375, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Masukan Kode Voucher Untuk Mendapat Potongan Harga"
        '
        'notif
        '
        Me.notif.AutoSize = True
        Me.notif.Location = New System.Drawing.Point(175, 546)
        Me.notif.Name = "notif"
        Me.notif.Size = New System.Drawing.Size(0, 17)
        Me.notif.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(360, 517)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 26)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Gunakan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(219, 490)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "NB : Huruf Kapital"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Makanan"
        '
        'menu_minuman
        '
        Me.menu_minuman.FormattingEnabled = True
        Me.menu_minuman.Items.AddRange(New Object() {"Es Teh", "Es Jeruk", "Degan", "Es Jus", "Teh Angget", "Kopi"})
        Me.menu_minuman.Location = New System.Drawing.Point(41, 360)
        Me.menu_minuman.Name = "menu_minuman"
        Me.menu_minuman.Size = New System.Drawing.Size(158, 24)
        Me.menu_minuman.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(44, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Minuman"
        '
        'jumlah_minuman
        '
        Me.jumlah_minuman.Location = New System.Drawing.Point(41, 412)
        Me.jumlah_minuman.Name = "jumlah_minuman"
        Me.jumlah_minuman.Size = New System.Drawing.Size(158, 22)
        Me.jumlah_minuman.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(44, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Jumlah"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(507, 729)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 26)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Admin"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tampil_diskon
        '
        Me.tampil_diskon.AutoSize = True
        Me.tampil_diskon.Location = New System.Drawing.Point(254, 572)
        Me.tampil_diskon.Name = "tampil_diskon"
        Me.tampil_diskon.Size = New System.Drawing.Size(0, 17)
        Me.tampil_diskon.TabIndex = 23
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(374, 729)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 26)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Kode Voucher"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(210, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(367, 87)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "SELAMAT DATANG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DI APLIKASI PEMBAYARAN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KANTIN OKE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(91, 662)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Uang Anda"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(196, 659)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 22)
        Me.TextBox2.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(355, 441)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 17)
        Me.Label14.TabIndex = 31
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(30, 730)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(63, 26)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(148, 729)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(180, 21)
        Me.CheckBox2.TabIndex = 33
        Me.CheckBox2.Text = "Lihat Detail Pemesanan"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cobaVB.My.Resources.Resources.ktin_png_2
        Me.PictureBox1.Location = New System.Drawing.Point(23, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(122, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Total Harga :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(379, 765)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(210, 17)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Powered By Anjar Anas Abdillah"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(601, 791)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.tampil_diskon)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.jumlah_minuman)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.menu_minuman)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.notif)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.JumlahBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.total_bayar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Pembayaran"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents total_bayar As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents JumlahBox As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents notif As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents menu_minuman As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents jumlah_minuman As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents tampil_diskon As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
End Class
