Imports MetroFramework
Public Class Form_Varliklarim
    Dim KNId As Integer
    Sub txtTemizle()
        For Each txt In {txtAciklama, txtBaslik, txtDeger}
            txt.Clear()
        Next
        cbbVarlikTipi.SelectedIndex = -1
        btnGuncelle.Enabled = False
        btnSil.Enabled = False
        txtDeger.PromptText = "0.00 ₺"
        lblCikanMiktar.Text = "0.00 ₺"
        dtwKayitlar.ClearSelection()
    End Sub
    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
        txtTemizle()
    End Sub

    Private Sub txtDeger_TextChanged(sender As Object, e As EventArgs) Handles txtDeger.TextChanged
        Dim sayi As Integer
        If txtDeger.Text = "" Then
            lblCikanMiktar.Text = "0.00 ₺"
        Else
            sayi = CInt(txtDeger.Text)
            lblCikanMiktar.Text = sayi.ToString("C")
        End If
    End Sub

    Private Sub txtDeger_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeger.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
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
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click

        Dim sql As String
        Dim Baslik As String = txtBaslik.Text
        Dim VarlikTipi As String = cbbVarlikTipi.Text
        Dim Degeri As Integer = txtDeger.Text
        Dim Tarih As Date = dtTarih.Text
        Dim Aciklama As String = txtAciklama.Text

        If txtBaslik.Text = "" And txtDeger.Text = "" And cbbVarlikTipi.SelectedIndex = -1 Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dtwKayitlar.ClearSelection()
            Baglan()
            sql = "insert into Varliklarim (Baslik,VarlikTipi,Degeri,Tarih,Aciklama,KNId) VALUES ('" & Baslik & "','" & VarlikTipi & "','" & Degeri & "','" & Tarih & "','" & Aciklama & "','" & KNId & "')"
            sqlCalistir(Sql)
            Baglan.Close()
            txtTemizle()
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
            sqlCalistir("delete from Varliklarim where id=" & kayitId)
            txtTemizle()
            KayitGetir()
            btnSil.Enabled = False
            btnGuncelle.Enabled = False
        End If
    End Sub

    Private Sub dtwKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwKayitlar.CellClick
        txtBaslik.Text = dtwKayitlar.CurrentRow.Cells(0).Value.ToString()
        cbbVarlikTipi.Text = dtwKayitlar.CurrentRow.Cells(1).Value.ToString()
        txtDeger.Text = dtwKayitlar.CurrentRow.Cells(2).Value.ToString()
        dtTarih.Text = dtwKayitlar.CurrentRow.Cells(3).Value.ToString()
        txtAciklama.Text = dtwKayitlar.CurrentRow.Cells(4).Value.ToString()
        txtKayitId.Text = dtwKayitlar.CurrentRow.Cells(5).Value.ToString()
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

        sqlCalistir("update Varliklarim set Baslik='" & txtBaslik.Text & "',VarlikTipi='" & cbbVarlikTipi.Text & "',Degeri='" & txtDeger.Text & "',Tarih='" & tarih & "',Aciklama='" & txtAciklama.Text & "',KNId='" & KNId & "' where id=" & kayitId)
        MetroMessageBox.Show(Me, "Kaydınız Başarıyla Güncellenmiştir...", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
        KayitGetir()
    End Sub


    Sub KayitGetir()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Varliklarim Where KNId=" & KNId)

        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add(dt.Rows(i)("Baslik"), dt.Rows(i)("VarlikTipi"), dt.Rows(i)("Degeri"), dt.Rows(i)("Tarih"), dt.Rows(i)("Aciklama"), dt.Rows(i)("id"))
        Next
    End Sub

    Private Sub Form_Varliklarim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KayitGetir()
        txtTemizle()
    End Sub

    Private Sub btnExceleAktar_Click(sender As Object, e As EventArgs) Handles btnExceleAktar.Click
        excelTablo(dtwKayitlar)
    End Sub
End Class