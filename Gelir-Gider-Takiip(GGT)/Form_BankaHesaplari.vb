Imports MetroFramework

Public Class Form_BankaHesaplari
    Dim KNId As Integer
    Sub txtTemizle()
        For Each txt In {txtBanka, txtHesapNo, txtIBAN, txtAciklama, txtKartCCV, txtKartNo, txtKartSifre, txtMusteriNo}
            txt.Clear()
        Next
        txtBanka.Focus()
        cbbHesapTipi.SelectedIndex = -1
        btnGuncelle.Enabled = False
        btnSil.Enabled = False
        dtAcilisTarihi.Value = DateTime.Now()
        dtGecerlilikTarihi.Value = DateTime.Now()
        dtwKayitlar.ClearSelection()
    End Sub
    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
        txtTemizle()
    End Sub

    Private Sub Form_BankaHesaplari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTemizle()
        KayitGetir()
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        txtTemizle()
    End Sub

    Private Sub txtHesapNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHesapNo.KeyPress, txtMusteriNo.KeyPress, txtKartSifre.KeyPress, txtKartCCV.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub chkGizleGoster_CheckedChanged(sender As Object, e As EventArgs) Handles chkGizleGoster.CheckedChanged
        If chkGizleGoster.Checked = True Then
            txtKartSifre.PasswordChar = ""
        Else
            txtKartSifre.PasswordChar = "*"
        End If
    End Sub
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim sql As String
        Dim Banka As String = txtBanka.Text
        Dim HesapNo As String = txtHesapNo.Text
        Dim IBAN As String = txtIBAN.Text
        Dim HesapTipi As String = cbbHesapTipi.Text
        Dim MusteriNo As Integer = txtMusteriNo.Text
        Dim KartNo As Integer = txtKartNo.Text
        Dim KartSifre As Integer = txtKartSifre.Text
        Dim KartCCv As Integer = txtKartCCV.Text
        Dim AcilisTarihi As Date = dtAcilisTarihi.Text
        Dim GecerlilikTarihi As Date = dtGecerlilikTarihi.Text
        Dim Aciklama As String = txtAciklama.Text

        If txtBanka.Text = "" And txtMusteriNo.Text = "" And txtKartNo.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dtwKayitlar.Rows.Add(txtBanka.Text, txtHesapNo.Text, txtIBAN.Text, cbbHesapTipi.Text, txtMusteriNo.Text, txtKartNo.Text, txtKartSifre.Text, txtKartCCV.Text, dtAcilisTarihi.Text, dtGecerlilikTarihi.Text, txtAciklama.Text)
            txtTemizle()
            Baglan()
            sql = "insert into BankaHesaplari (Banka,HesapNo,IBAN,HesapTipi,MusteriNo,KartNo,KartSifre,KartCCV,AcilisTarihi,GecerlilikTarihi,Aciklama,KNId) VALUES ('" & Banka & "','" & HesapNo & "','" & IBAN & "','" & HesapTipi & "','" & MusteriNo & "','" & KartNo & "','" & KartSifre & "','" & KartCCv & "','" & AcilisTarihi & "','" & GecerlilikTarihi & "','" & Aciklama & "','" & KNId & "')"
            sqlCalistir(sql)
            Baglan.Close()
            KayitGetir()

        End If
    End Sub
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If txtKayitId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim result As Integer = MetroMessageBox.Show(Me, "Silmek istediğinize emin misiniz ?.", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Dim kayitId As Integer = Convert.ToInt32(txtKayitId.Text)
            sqlCalistir("delete from BankaHesaplari where id=" & kayitId)
            txtTemizle()
            KayitGetir()
            btnSil.Enabled = False
            btnGuncelle.Enabled = False
        End If

    End Sub
    Private Sub dtwKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwKayitlar.CellClick
        txtBanka.Text = dtwKayitlar.CurrentRow.Cells(0).Value.ToString()
        txtHesapNo.Text = dtwKayitlar.CurrentRow.Cells(1).Value.ToString()
        txtIBAN.Text = dtwKayitlar.CurrentRow.Cells(2).Value.ToString()
        cbbHesapTipi.Text = dtwKayitlar.CurrentRow.Cells(3).Value.ToString()
        txtMusteriNo.Text = dtwKayitlar.CurrentRow.Cells(4).Value.ToString()
        txtKartNo.Text = dtwKayitlar.CurrentRow.Cells(5).Value.ToString()
        txtKartSifre.Text = dtwKayitlar.CurrentRow.Cells(6).Value.ToString()
        txtKartCCV.Text = dtwKayitlar.CurrentRow.Cells(7).Value.ToString()
        dtAcilisTarihi.Text = dtwKayitlar.CurrentRow.Cells(8).Value.ToString()
        dtGecerlilikTarihi.Text = dtwKayitlar.CurrentRow.Cells(9).Value.ToString()
        txtAciklama.Text = dtwKayitlar.CurrentRow.Cells(10).Value.ToString()
        txtKayitId.Text = dtwKayitlar.CurrentRow.Cells(11).Value.ToString()
        btnGuncelle.Enabled = True
        btnSil.Enabled = True
        btnYeni.Enabled = True
    End Sub
    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If txtKayitId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim kayitId As Integer = Convert.ToInt32(txtKayitId.Text)
        Dim AcilisTarihi As Date = dtAcilisTarihi.Text
        Dim GecerlilikTarihi As Date = dtGecerlilikTarihi.Text

        sqlCalistir("update BankaHesaplari set Banka='" & txtBanka.Text & "',HesapNo='" & txtHesapNo.Text & "',IBAN='" & txtIBAN.Text & "',HesapTipi='" & cbbHesapTipi.Text & "',MusteriNo='" & txtMusteriNo.Text & "',KartNo='" & txtKartNo.Text & "',KartSifre='" & txtKartSifre.Text & "',KartCCV='" & txtKartCCV.Text & "',AcilisTarihi='" & AcilisTarihi & "',GecerlilikTarihi='" & GecerlilikTarihi & "',Aciklama='" & txtAciklama.Text & "',KNId='" & KNId & "' where id=" & kayitId)
        MetroMessageBox.Show(Me, "Kaydınız Başarıyla Güncellenmiştir...", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
        KayitGetir()
    End Sub


    Sub KayitGetir()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from BankaHesaplari Where KNId=" & KNId)
        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add(dt.Rows(i)("Banka"), dt.Rows(i)("HesapNo"), dt.Rows(i)("IBAN"), dt.Rows(i)("HesapTipi"), dt.Rows(i)("MusteriNo"), dt.Rows(i)("KartNo"), dt.Rows(i)("KartSifre"), dt.Rows(i)("KartCCV"), dt.Rows(i)("AcilisTarihi"), dt.Rows(i)("GecerlilikTarihi"), dt.Rows(i)("Aciklama"), dt.Rows(i)("id"))
        Next

    End Sub

End Class