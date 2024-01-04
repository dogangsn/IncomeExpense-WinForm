Imports DevExpress.XtraScheduler
Imports MetroFramework
Imports System.Data.OleDb
Public Class Form_Gelir
    Dim KNId As Integer
    Dim id As Integer

    Private Sub Form_Gelir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGelirBasligi.Focus()
        dtwKayitlar.ClearSelection()
        KayitGetir()
    End Sub

    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
        txtTemizle()
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

    Private Sub btnYeni_Click(sender As Object, e As EventArgs) Handles btnYeni.Click
        txtTemizle()
        dtwKayitlar.ClearSelection()
    End Sub


    Sub txtTemizle()
        For Each txt In {txtAciklama, txtGelirBasligi, txtMiktar}
            txt.Clear()
        Next
        cbbGelirTipi.SelectedIndex = -1
        txtMiktar.PromptText = "0.00 ₺"
        lblCikanMiktar.Text = "0.00 ₺"
        dtTarih.Value = DateTime.Now()
    End Sub

    Private Sub txtMiktar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiktar.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMiktar_TextChanged(sender As Object, e As EventArgs) Handles txtMiktar.TextChanged
        Dim sayi As Integer
        If txtMiktar.Text = "" Then
            lblCikanMiktar.Text = "0.00 ₺"
        Else
            sayi = CInt(txtMiktar.Text)
            lblCikanMiktar.Text = sayi.ToString("C")
        End If
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim sql As String
        Dim baslik As String = txtGelirBasligi.Text
        Dim GelirTipi As String = cbbGelirTipi.Text
        Dim miktar As Integer = Convert.ToInt32(txtMiktar.Text)
        Dim tarih As Date = dtTarih.Text
        Dim Kaydedilentarih As Date = DateTime.Now().ToString()
        Dim aciklama As String = txtAciklama.Text
        If txtGelirBasligi.Text = "" And txtMiktar.Text = "" And txtAciklama.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dtwKayitlar.Rows.Add(txtGelirBasligi.Text, cbbGelirTipi.Text, txtMiktar.Text, dtTarih.Text, DateTime.Now().ToString(), txtAciklama.Text)
            Baglan()
            sql = "insert into Gelirlerim (Baslik,GelirTipi,Miktar,Tarih,KaydedilenTarih,Aciklama,KNId) VALUES ('" & baslik & "','" & GelirTipi & "','" & miktar & "','" & tarih & "','" & Kaydedilentarih & "','" & aciklama & "','" & KNId & "')"
            sqlCalistir(sql)
            Baglan.Close()
            dtwKayitlar.ClearSelection()
            txtTemizle()
            KayitGetir()
        End If

    End Sub

    Private Sub dtwKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwKayitlar.CellClick
        txtGelirBasligi.Text = dtwKayitlar.CurrentRow.Cells(0).Value.ToString()
        cbbGelirTipi.Text = dtwKayitlar.CurrentRow.Cells(1).Value.ToString()
        txtMiktar.Text = dtwKayitlar.CurrentRow.Cells(2).Value.ToString()
        dtTarih.Text = dtwKayitlar.CurrentRow.Cells(3).Value.ToString()
        txtAciklama.Text = dtwKayitlar.CurrentRow.Cells(5).Value.ToString()
        txtKayitId.Text = dtwKayitlar.CurrentRow.Cells(6).Value.ToString()
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
        Dim tarih As Date = dtTarih.Text

        sqlCalistir("update Gelirlerim set Baslik='" & txtGelirBasligi.Text & "',GelirTipi='" & cbbGelirTipi.Text & "', miktar='" & txtMiktar.Text & "', tarih='" & tarih & "', Kaydedilentarih='" & Now().ToString() & "', aciklama='" & txtAciklama.Text & "', KNId='" & KNId & "' where id=" & kayitId)
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
            sqlCalistir("delete from Gelirlerim where id=" & kayitId)
            txtTemizle()
            KayitGetir()
            btnSil.Enabled = False
            btnGuncelle.Enabled = False
        End If
    End Sub

    Sub KayitGetir()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Gelirlerim Where KNId=" & KNId)
        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add(dt.Rows(i)("Baslik"), dt.Rows(i)("GelirTipi"), dt.Rows(i)("Miktar"), dt.Rows(i)("Tarih"), dt.Rows(i)("KaydedilenTarih"), dt.Rows(i)("Aciklama"), dt.Rows(i)("id"))
        Next

    End Sub

    Private Sub btnExceleAktar_Click(sender As Object, e As EventArgs) Handles btnExceleAktar.Click
        ExceleAktar.excelTablo(dtwKayitlar)
    End Sub
End Class