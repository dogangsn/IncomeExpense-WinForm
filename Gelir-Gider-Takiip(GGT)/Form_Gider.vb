Imports MetroFramework
Public Class Form_Gider
    Dim KNId As Integer
    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
        texTemizle()
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        texTemizle()
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

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim sql As String
        Dim OBaslik As String = txtOdemeBasligi.Text
        Dim OdemeTipi As String = cbbOdemeSekli.Text
        Dim Miktar As Integer = Convert.ToInt32(txtOdemeMiktari.Text)
        Dim OdemeTarihi As Date = dtOdemeTarih.Text
        Dim OdenenYer As String = txtOdenenYer.Text
        Dim Aciklama As String = txtAciklama.Text
        Dim Kaydedilentarih As Date = DateTime.Now().ToString()


        If txtOdemeBasligi.Text = "" And txtOdemeMiktari.Text = "" And txtOdenenYer.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dtwKayitlar.Rows.Add(txtOdemeBasligi.Text, cbbOdemeSekli.Text, txtOdemeMiktari.Text, dtOdemeTarih.Text, txtOdenenYer.Text, DateTime.Now().ToString(), txtAciklama.Text)
            dtOdemeTarih.Value = DateTime.Today()

            Baglan()
            sql = "insert into Giderlerim (OBaslik,OdemeTipi,Miktar,OdemeTarihi,OdenenYer,KaydedilenTarih,Aciklama,KNId) VALUES ('" & OBaslik & "','" & OdemeTipi & "','" & Miktar & "','" & OdemeTarihi & "','" & OdenenYer & "','" & Kaydedilentarih & "','" & Aciklama & "','" & KNId & "')"
            sqlCalistir(sql)
            Baglan.Close()
            KayitGetir()
            texTemizle()
        End If
    End Sub

    Sub texTemizle()
        For Each txt In {txtAciklama, txtOdemeBasligi, txtOdemeMiktari, txtOdenenYer}
            txt.Clear()
        Next
        cbbOdemeSekli.SelectedIndex = -1
        txtOdemeMiktari.PromptText = "0.00 ₺"
        lblCikanMiktar.Text = "0.00 ₺"
        dtOdemeTarih.Value = DateTime.Now()
        dtwKayitlar.ClearSelection()
    End Sub

    Private Sub dtwKayitlar_Click(sender As Object, e As EventArgs) Handles dtwKayitlar.Click
        txtOdemeBasligi.Text = dtwKayitlar.CurrentRow.Cells(0).Value.ToString()
        cbbOdemeSekli.Text = dtwKayitlar.CurrentRow.Cells(1).Value.ToString()
        txtOdemeMiktari.Text = dtwKayitlar.CurrentRow.Cells(2).Value.ToString()
        dtOdemeTarih.Text = dtwKayitlar.CurrentRow.Cells(3).Value.ToString()
        txtOdenenYer.Text = dtwKayitlar.CurrentRow.Cells(4).Value.ToString()
        txtAciklama.Text = dtwKayitlar.CurrentRow.Cells(6).Value.ToString()
        txtKayitId.Text = dtwKayitlar.CurrentRow.Cells(7).Value.ToString()
        btnGuncelle.Enabled = True
        btnSil.Enabled = True
        btnYeni.Enabled = True
    End Sub

    Private Sub Form_Gider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOdemeBasligi.Focus()
        btnGuncelle.Enabled = False
        btnSil.Enabled = False
        dtwKayitlar.ClearSelection()
        KayitGetir()
    End Sub

    Private Sub txtOdemeMiktari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOdemeMiktari.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtOdemeMiktari_TextChanged(sender As Object, e As EventArgs) Handles txtOdemeMiktari.TextChanged
        Dim sayi As Integer
        If txtOdemeMiktari.Text = "" Then
            lblCikanMiktar.Text = "0.00 ₺"
        Else
            sayi = CInt(txtOdemeMiktari.Text)
            lblCikanMiktar.Text = sayi.ToString("C")
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
            sqlCalistir("delete from Giderlerim where id=" & kayitId)
            texTemizle()
            KayitGetir()
            btnSil.Enabled = False
            btnGuncelle.Enabled = False
        End If
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If txtKayitId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim kayitId As Integer = Convert.ToInt32(txtKayitId.Text)
        Dim tarih As Date = dtOdemeTarih.Text

        sqlCalistir("update Giderlerim set OBaslik='" & txtOdemeBasligi.Text & "',OdemeTipi='" & cbbOdemeSekli.Text & "', Miktar='" & txtOdemeMiktari.Text & "', OdemeTarihi='" & tarih & "', OdenenYer='" & txtOdenenYer.Text & "', KaydedilenTarih='" & Now().ToString() & "', Aciklama='" & txtAciklama.Text & "', KNId='" & KNId & "' where id=" & kayitId)
        MetroMessageBox.Show(Me, "Kaydınız Başarıyla Güncellenmiştir...", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
        KayitGetir()

    End Sub

    Sub KayitGetir()

        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Giderlerim Where KNId=" & KNId)
        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add(dt.Rows(i)("OBaslik"), dt.Rows(i)("OdemeTipi"), dt.Rows(i)("Miktar"), dt.Rows(i)("OdemeTarihi"), dt.Rows(i)("OdenenYer"), dt.Rows(i)("KaydedilenTarih"), dt.Rows(i)("Aciklama"), dt.Rows(i)("id"))
        Next
    End Sub

    Private Sub btnExceleAktar_Click(sender As Object, e As EventArgs) Handles btnExceleAktar.Click
        ExceleAktar.excelTablo(dtwKayitlar)
    End Sub
End Class