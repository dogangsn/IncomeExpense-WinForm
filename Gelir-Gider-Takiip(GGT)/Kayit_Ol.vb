Imports System.Data.OleDb
Imports MetroFramework


Public Class Kayit_Ol
    Private Sub btnVazgec_Click(sender As Object, e As EventArgs) Handles btnVazgec.Click
        Me.Hide()
        For Each txt In {txtAdSoyad, txtDogrulamaKodu, txtKullaniciAdi, txtMail, txtParola, txtParolaDogrulama}
            txt.Clear()
        Next
    End Sub
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click

        Dim ResimYolu As String = Application.StartupPath & "\image\profil.jpg"
        Dim KullaniciAdi As String = txtKullaniciAdi.Text
        Dim AdSoyad As String = txtAdSoyad.Text
        Dim mail As String = txtMail.Text
        Dim Parola As String = txtParola.Text
        Dim sql As String

        If txtKullaniciAdi.Text = "" And txtAdSoyad.Text = "" And txtMail.Text = "" And txtParola.Text = "" And txtParola.Text = "" And txtParolaDogrulama.Text = "" And txtDogrulamaKodu.Text = "" Then
            MetroMessageBox.Show(Me, "Girmiş olduğunuz bilgilerde eksiklik gozüküyor. Lütfen Kontrol ediniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtParola.Text <> txtParolaDogrulama.Text Then
            MetroMessageBox.Show(Me, "Girdiğiniz Parola birbiri İle doğrulanamıyor...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtParola.Text = ""
            txtParolaDogrulama.Text = ""
        ElseIf lblRandomSayi.Text <> txtDogrulamaKodu.Text Then
            MetroMessageBox.Show(Me, "Doğrulama Kodunu Yanlış Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Yenile()
        ElseIf chbSozlesmeOnayi.Checked <> True Then
            MetroMessageBox.Show(Me, "Kullanım Koşullarını Kabul etmediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            sql = "insert into Kullanici (KullaniciAdi,AdSoyad,Mail,Parola) VALUES ('" & KullaniciAdi & "','" & AdSoyad & "','" & mail & "','" & Parola & "','" & ResimYolu & "')"
            Dim komut As New OleDbCommand("select * from Kullanici", Baglan)
            Dim dr As OleDbDataReader
            dr = komut.ExecuteReader
            Do While dr.Read
                If dr("KullaniciAdi") = KullaniciAdi Then
                    MetroMessageBox.Show(Me, "Aynı Kullanıcı Adından Daha Once Alınmıştır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtKullaniciAdi.Text = ""
                    dr.Close()
                    Return
                ElseIf dr("Mail") = mail Then
                    MetroMessageBox.Show(Me, "Aynı Mail Adresinden Daha Once Kayıt Edilmiştir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtMail.Text = ""
                    dr.Close()
                    Return
                    End
                End If
            Loop
            dr.Close()
            komut.CommandText = sql
            komut.ExecuteNonQuery()
            komut.CommandText = "Select @@Identity"
            Dim ID As Integer = komut.ExecuteScalar()

            sqlCalistir("insert into Kayit (KNId) VALUES ('" & ID & "')")
            Baglan.Close()

            Dim result As Integer = MetroMessageBox.Show(Me, "Kullanıcı Kaydınız Onaylandı...", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        Yenile()
    End Sub

    Sub Yenile()
        Dim k As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        lblRandomSayi.Text = ""
        For i As Integer = 0 To 3
            Randomize()
            lblRandomSayi.Text += k(Rnd() * 32)
        Next
    End Sub

    Private Sub Kayit_Ol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Yenile()
    End Sub
End Class