Imports MetroFramework
Public Class Form_WebAdresim
    Dim KNId As Integer
    Sub txtTemizle()
        For Each txt In {txtBaslik, txtAciklama, txtGizliCevap, txtGizliSoru, txtKMail, txtKod, txtKullaniciAdi, txtSifre, txtWebAdresim}
            txt.Clear()
        Next
        dtAcilisTarihi.Value = DateTime.Now()
        dtGecerlilikTarihi.Value = DateTime.Now()
        dtwKayitlar.ClearSelection()
        btnGuncelle.Enabled = False
        btnSil.Enabled = False
    End Sub
    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
        txtTemizle()
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        txtTemizle()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim sql As String
        Dim Baslik As String = txtBaslik.Text
        Dim WebAdresi As String = txtWebAdresim.Text
        Dim KAdi As String = txtKullaniciAdi.Text
        Dim Sifre As String = txtSifre.Text
        Dim GizliSoru As String = txtGizliSoru.Text
        Dim GizliCevap As String = txtGizliCevap.Text
        Dim KMail As String = txtKMail.Text
        Dim Kod As String = txtKod.Text
        Dim AcilisTarihi As String = dtAcilisTarihi.Text
        Dim GecerlilikTarihi As String = dtGecerlilikTarihi.Text
        Dim Aciklama As String = txtAciklama.Text

        If txtBaslik.Text = "" And txtKullaniciAdi.Text = "" And txtSifre.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Baglan()
            sql = "insert into WebAdresleri (Baslik,WebAdresi,KAdi,Sifre,GizliSoru,GizliCevap,KulMail,Kod,AcilisTarihi,GecerlilikTarihi,Aciklama,KNId) VALUES ('" & Baslik & "','" & WebAdresi & "','" & KAdi & "','" & Sifre & "','" & GizliSoru & "','" & GizliCevap & "','" & KMail & "','" & Kod & "','" & AcilisTarihi & "','" & GecerlilikTarihi & "','" & Aciklama & "','" & KNId & "')"
            sqlCalistir(sql)
            Baglan.Close()
            KayitGetir()
            dtwKayitlar.ClearSelection()
            txtTemizle()
        End If
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If txtKayitId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim kayitId As Integer = Convert.ToInt32(txtKayitId.Text)
        Dim AcilisTarihi As Date = dtAcilisTarihi.Text
        Dim GecerlilikTarihi As Date = dtGecerlilikTarihi.Text

        sqlCalistir("update WebAdresleri set Baslik='" & txtBaslik.Text & "',WebAdresi='" & txtWebAdresim.Text & "',KAdi='" & txtKullaniciAdi.Text & "',Sifre='" & txtSifre.Text & "',GizliSoru='" & txtGizliSoru.Text & "',GizliCevap='" & txtGizliCevap.Text & "',KulMail='" & txtKMail.Text & "',Kod='" & txtKod.Text & "',AcilisTarihi='" & AcilisTarihi & "',GecerlilikTarihi='" & GecerlilikTarihi & "',Aciklama='" & txtAciklama.Text & "',KNId='" & KNId & "' where id=" & kayitId)
        MetroMessageBox.Show(Me, "Kaydınız Başarıyla Güncellenmiştir...", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
        KayitGetir()


    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If txtKayitId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim result As Integer = MetroMessageBox.Show(Me, "Silmek istediğinize emin misiniz ?.", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Dim kayitId As Integer = Convert.ToInt32(txtKayitId.Text)
            sqlCalistir("Delete from WebAdresleri where id=" & kayitId)
            txtTemizle()
            KayitGetir()
            btnSil.Enabled = False
            btnGuncelle.Enabled = False
        End If
    End Sub

    Private Sub dtwKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwKayitlar.CellClick
        txtBaslik.Text = dtwKayitlar.CurrentRow.Cells(0).Value.ToString()
        txtWebAdresim.Text = dtwKayitlar.CurrentRow.Cells(1).Value.ToString()
        txtKullaniciAdi.Text = dtwKayitlar.CurrentRow.Cells(2).Value.ToString()
        txtSifre.Text = dtwKayitlar.CurrentRow.Cells(3).Value.ToString()
        txtGizliSoru.Text = dtwKayitlar.CurrentRow.Cells(4).Value.ToString()
        txtGizliCevap.Text = dtwKayitlar.CurrentRow.Cells(5).Value.ToString()
        txtKMail.Text = dtwKayitlar.CurrentRow.Cells(6).Value.ToString()
        txtKod.Text = dtwKayitlar.CurrentRow.Cells(7).Value.ToString()
        dtAcilisTarihi.Text = dtwKayitlar.CurrentRow.Cells(8).Value.ToString()
        dtGecerlilikTarihi.Text = dtwKayitlar.CurrentRow.Cells(9).Value.ToString()
        txtAciklama.Text = dtwKayitlar.CurrentRow.Cells(10).Value.ToString()
        txtKayitId.Text = dtwKayitlar.CurrentRow.Cells(11).Value.ToString()
        btnGuncelle.Enabled = True
        btnSil.Enabled = True
        btnYeni.Enabled = True
    End Sub

    Private Sub toggleAktif_Click(sender As Object, e As EventArgs) Handles toggleAktif.Click
        If toggleAktif.Text = "On" Then
            btnExceleAktar.Enabled = True
            btnYazdir.Enabled = True
        Else
            btnYazdir.Enabled = False
            btnExceleAktar.Enabled = False
        End If
    End Sub
    Sub KayitGetir()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from WebAdresleri Where KNId=" & KNId)
        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add(dt.Rows(i)("Baslik"), dt.Rows(i)("WebAdresi"), dt.Rows(i)("KAdi"), dt.Rows(i)("Sifre"), dt.Rows(i)("GizliSoru"), dt.Rows(i)("GizliCevap"), dt.Rows(i)("KulMail"), dt.Rows(i)("Kod"), dt.Rows(i)("AcilisTarihi"), dt.Rows(i)("GecerlilikTarihi"), dt.Rows(i)("Aciklama"), dt.Rows(i)("id"))
        Next
    End Sub

    Private Sub Form_WebAdresim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KayitGetir()
    End Sub

    Private Sub btnExceleAktar_Click(sender As Object, e As EventArgs) Handles btnExceleAktar.Click
        excelTablo(dtwKayitlar)
    End Sub
End Class