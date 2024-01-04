Imports MetroFramework
Public Class Form_Taksitler
    Dim KNId As Integer
    Sub txtTemizle()
        For Each txt In {txtAciklama, txtOdemeBasligi, txtOdemeMiktari, txtTaksitSayisi}
            txt.Clear()
        Next
        cbbOdemeTipi.SelectedIndex = -1
        cbbTaksitPeriyodu.SelectedIndex = -1
        dtIlkOdemeTarihi.Value = DateTime.Now()
        txtOdemeMiktari.PromptText = "0.00 ₺"
        lblCikanMiktar.Text = "0.00 ₺"
        dtwKayitlar.ClearSelection()
        btnGuncelle.Enabled = False
        btnSil.Enabled = False
    End Sub

    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
        txtTemizle()
    End Sub

    Private Sub toogleAktif_Click(sender As Object, e As EventArgs) Handles toggleAktif.Click
        If toggleAktif.Text = "On" Then
            btnExceleAktar.Enabled = True
            btnYazdir.Enabled = True
        Else
            btnYazdir.Enabled = False
            btnExceleAktar.Enabled = False
        End If
    End Sub

    Private Sub Form_Taksitler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOdemeBasligi.Focus()
        txtTemizle()
        KayitGetir()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim sql As String
        Dim OBasligi As String = txtOdemeBasligi.Text
        Dim OdemeTipi As String = cbbOdemeTipi.Text
        Dim Miktar As Integer = txtOdemeMiktari.Text
        Dim TaksitSayisi As Integer = Convert.ToInt32(txtTaksitSayisi.Text)
        Dim TakistPeriyodu As Integer = cbbTaksitPeriyodu.Text
        Dim IlkOdemeTarihi As Date = dtIlkOdemeTarihi.Text
        Dim Aciklama As String = txtAciklama.Text

        If txtOdemeBasligi.Text = "" And txtOdemeMiktari.Text = "" And txtAciklama.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dtwKayitlar.Rows.Add(txtOdemeBasligi.Text, cbbOdemeTipi.Text, txtOdemeMiktari.Text, txtTaksitSayisi.Text, cbbTaksitPeriyodu.Text, dtIlkOdemeTarihi.Text, txtAciklama.Text)
            dtwKayitlar.ClearSelection()
            txtTemizle()
            Baglan()
            sql = "insert into Taksitler (OBasligi,OdemeTipi,Miktar,TaksitSayisi,TaksitPeriyodu,İlkOdemeTarihi,Aciklama,KNId) VALUES ('" & OBasligi & "','" & OdemeTipi & "','" & Miktar & "','" & TaksitSayisi & "','" & TakistPeriyodu & "','" & IlkOdemeTarihi & "','" & Aciklama & "','" & KNId & "')"
            sqlCalistir(sql)
            Baglan.Close()
            KayitGetir()
        End If
    End Sub

    Private Sub dtwKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwKayitlar.CellClick
        txtOdemeBasligi.Text = dtwKayitlar.CurrentRow.Cells(0).Value.ToString()
        cbbOdemeTipi.Text = dtwKayitlar.CurrentRow.Cells(1).Value.ToString()
        txtOdemeMiktari.Text = dtwKayitlar.CurrentRow.Cells(2).Value.ToString()
        txtTaksitSayisi.Text = dtwKayitlar.CurrentRow.Cells(3).Value.ToString()
        cbbTaksitPeriyodu.Text = dtwKayitlar.CurrentRow.Cells(4).Value.ToString()
        dtIlkOdemeTarihi.Text = dtwKayitlar.CurrentRow.Cells(5).Value.ToString()
        txtAciklama.Text = dtwKayitlar.CurrentRow.Cells(6).Value.ToString()
        txtKayitId.Text = dtwKayitlar.CurrentRow.Cells(7).Value.ToString()
        btnGuncelle.Enabled = True
        btnSil.Enabled = True
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

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If txtKayitId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim kayitId As Integer = Convert.ToInt32(txtKayitId.Text)
        Dim ilkOdemeTarihi As Date = dtIlkOdemeTarihi.Text

        sqlCalistir("update Taksitler set OBasligi='" & txtOdemeBasligi.Text & "',OdemeTipi='" & cbbOdemeTipi.Text & "', Miktar='" & txtOdemeMiktari.Text & "', TaksitSayisi='" & txtTaksitSayisi.Text & "', TaksitPeriyodu='" & cbbTaksitPeriyodu.Text & "', İlkOdemeTarihi='" & ilkOdemeTarihi & "', Aciklama='" & txtAciklama.Text & "', KNId='" & KNId & "' where id=" & kayitId)
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
            sqlCalistir("delete from Taksitler where id=" & kayitId)
            txtTemizle()
            KayitGetir()
            btnSil.Enabled = False
            btnGuncelle.Enabled = False
        End If
    End Sub

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        txtTemizle()
    End Sub

    Private Sub txtOdemeMiktari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOdemeMiktari.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Sub KayitGetir()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Taksitler Where KNId=" & KNId)
        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add(dt.Rows(i)("OBasligi"), dt.Rows(i)("OdemeTipi"), dt.Rows(i)("Miktar"), dt.Rows(i)("TaksitSayisi"), dt.Rows(i)("TaksitPeriyodu"), dt.Rows(i)("İlkOdemeTarihi"), dt.Rows(i)("Aciklama"), dt.Rows(i)("id"))
        Next

    End Sub

    Private Sub txtTaksitSayisi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaksitSayisi.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExceleAktar_Click(sender As Object, e As EventArgs) Handles btnExceleAktar.Click
        excelTablo(dtwKayitlar)
    End Sub
End Class