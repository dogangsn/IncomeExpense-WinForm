Imports MetroFramework
Public Class Form_Rehberim
    Dim KNId As Integer
    Sub txtTemizle()
        For Each txt In {txtAdSoyad, txtBaslik, txtMail, txtMail2, txtRumuz}
            txt.Clear()
        Next
        mtxtCepTel.Text = ""
        MtxtCepTel2.Text = ""
        MtxtEvTel.Text = ""
        btnGuncelle.Enabled = False
        btnSil.Enabled = False
        dtwKayitlar.ClearSelection()
        dtKayitTarihi.Text = DateTime.Now()
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
        Dim AdSoyad As String = txtAdSoyad.Text
        Dim CepTel As String = mtxtCepTel.Text
        Dim CepTel2 As String = MtxtCepTel2.Text
        Dim EvTel As String = MtxtEvTel.Text
        Dim Mail As String = txtMail.Text
        Dim Mail2 As String = txtMail2.Text
        Dim Rumuz As String = txtRumuz.Text
        Dim KayitTarihi As Date = dtKayitTarihi.Text

        If txtBaslik.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtAdSoyad.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dtwKayitlar.ClearSelection()
            Baglan()
            sql = "insert into Rehber (Baslik,AdSoyad,CepTel,CepTel2,EvTel,Mail,Mail2,Rumuz,KayitTarihi,KNId) VALUES ('" & Baslik & "','" & AdSoyad & "','" & CepTel & "','" & CepTel2 & "','" & EvTel & "','" & Mail & "','" & Mail2 & "','" & Rumuz & "','" & KayitTarihi & "','" & KNId & "')"
            sqlCalistir(Sql)
            Baglan.Close()
            KayitGetir()
            txtTemizle()
        End If
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If txtKayitId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim kayitId As Integer = Convert.ToInt32(txtKayitId.Text)
        Dim KayitTarihi As Date = Now().ToString

        sqlCalistir("update Rehber set Baslik='" & txtBaslik.Text & "',AdSoyad='" & txtAdSoyad.Text & "',CepTel='" & mtxtCepTel.Text & "',CepTel2='" & MtxtCepTel2.Text & "',EvTel='" & MtxtEvTel.Text & "',Mail='" & txtMail.Text & "',Mail2='" & txtMail2.Text & "',Rumuz='" & txtRumuz.Text & "',KayitTarihi='" & KayitTarihi & "',KNId='" & KNId & "' where id=" & kayitId)
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
            sqlCalistir("delete from Rehber where id=" & kayitId)
            txtTemizle()
            KayitGetir()
            btnSil.Enabled = False
            btnGuncelle.Enabled = False
        End If
    End Sub

    Private Sub txtAdSoyad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdSoyad.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
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

    Private Sub dtwKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwKayitlar.CellClick
        txtBaslik.Text = dtwKayitlar.CurrentRow.Cells(0).Value.ToString()
        txtAdSoyad.Text = dtwKayitlar.CurrentRow.Cells(1).Value.ToString()
        mtxtCepTel.Text = dtwKayitlar.CurrentRow.Cells(2).Value.ToString()
        MtxtCepTel2.Text = dtwKayitlar.CurrentRow.Cells(3).Value.ToString()
        MtxtEvTel.Text = dtwKayitlar.CurrentRow.Cells(4).Value.ToString()
        txtMail.Text = dtwKayitlar.CurrentRow.Cells(5).Value.ToString()
        txtMail2.Text = dtwKayitlar.CurrentRow.Cells(6).Value.ToString()
        txtRumuz.Text = dtwKayitlar.CurrentRow.Cells(7).Value.ToString()
        dtKayitTarihi.Text = dtwKayitlar.CurrentRow.Cells(8).Value.ToString()
        txtKayitId.Text = dtwKayitlar.CurrentRow.Cells(9).Value.ToString()
        btnGuncelle.Enabled = True
        btnSil.Enabled = True
        btnYeni.Enabled = True
    End Sub


    Private Sub mtxtCepTel_Leave(sender As Object, e As EventArgs) Handles mtxtCepTel.Leave
        If mtxtCepTel.MaskCompleted = False Then
            MetroMessageBox.Show(Me, "Eksik Bir numara Girdiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mtxtCepTel.Text = ""
        End If
    End Sub

    Private Sub MtxtCepTel2_Leave(sender As Object, e As EventArgs) Handles MtxtCepTel2.Leave
        If MtxtCepTel2.MaskCompleted = False Then
            MetroMessageBox.Show(Me, "Eksik Bir numara Girdiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MtxtCepTel2.Text = ""
        End If
    End Sub

    Private Sub MtxtEvTel_Leave(sender As Object, e As EventArgs) Handles MtxtEvTel.Leave
        If MtxtEvTel.MaskCompleted = False Then
            MetroMessageBox.Show(Me, "Eksik Bir numara Girdiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MtxtEvTel.Text = ""
        End If
    End Sub
    Sub KayitGetir()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Rehber Where KNId=" & KNId)
        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add(dt.Rows(i)("Baslik"), dt.Rows(i)("AdSoyad"), dt.Rows(i)("CepTel"), dt.Rows(i)("CepTel2"), dt.Rows(i)("EvTel"), dt.Rows(i)("Mail"), dt.Rows(i)("Mail2"), dt.Rows(i)("Rumuz"), dt.Rows(i)("KayitTarihi"), dt.Rows(i)("id"))
        Next

    End Sub

    Private Sub Form_Rehberim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KayitGetir()
        txtTemizle()
    End Sub

    Private Sub btnExceleAktar_Click(sender As Object, e As EventArgs) Handles btnExceleAktar.Click
        excelTablo(dtwKayitlar)
    End Sub
End Class