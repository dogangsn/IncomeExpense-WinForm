Imports System.Data.OleDb
Imports MetroFramework
Public Class Form_KullaniciBilgileri
    Dim KNId As Integer
    Dim ResimYolu As String = ""
    Dim Parola As String = ""
    Sub txtTemizle()
        txtAdSoyad.Text = ""
        txtKullaniciAdi.Text = ""
        txtMail.Text = ""
        pcResim.Image = Nothing
    End Sub
    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
        txtTemizle()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Kullanici]", Baglan)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim kullniciVarMi As Boolean = False
        Dim KullaniciAdi As String = ""
        While dr.Read
            kullniciVarMi = True
            KullaniciAdi = dr("KullaniciAdi").ToString()
            Parola = dr("Parola").ToString()

        End While


        If txtKullaniciAdi.Text = "" And txtAdSoyad.Text = "" And txtMail.Text = "" Then
            MetroMessageBox.Show(Me, "Girmiş olduğunuz bilgilerde eksiklik gozüküyor. Lütfen Kontrol ediniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            sqlCalistir("update Kullanici set AdSoyad='" & txtAdSoyad.Text & "',Mail='" & txtMail.Text & "',Parola='" & Parola & "',Resim='" & ResimYolu & "' where KNId=" & KNId)
            MetroMessageBox.Show(Me, "Kaydınız Başarıyla Güncellenmiştir...", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            While dr.Read
                Form_AnaSayfa.lblKullaniciAdi.Text = dr("KullaniciAdi").ToString()
                Refresh()
            End While
            Me.Close()
            Form_AnaSayfa.MakeRoundedImage(Image.FromFile(ResimYolu), Form_AnaSayfa.pcResim)
            txtTemizle()
        End If
    End Sub

    Private Sub btnResimSec_Click(sender As Object, e As EventArgs) Handles btnResimSec.Click
        OpenFileDialog1.Filter = "All Files|*.*|Image Files|*.jpg;*.png;"
        OpenFileDialog1.ShowDialog()
        pcResim.Image = Image.FromFile(OpenFileDialog1.FileName)
        ResimYolu = OpenFileDialog1.FileName
    End Sub

    Private Sub Form_KullaniciBilgileri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KayitGetir()
        pcResim.Image = Image.FromFile(Login_Girisi.Resim)
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Kullanici] Where KNId=" & KNId, Baglan)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            txtKullaniciAdi.Text = dr("KullaniciAdi").ToString
            txtMail.Text = dr("Mail").ToString
            txtAdSoyad.Text = dr("AdSoyad").ToString()
        End While
    End Sub

    Sub KayitGetir()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Notlarim Where KNId=" & KNId)
    End Sub
End Class