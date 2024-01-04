Imports MetroFramework
Public Class Form_NotDefterim
    Dim KNId As Integer
    Sub txtTemizle()
        txtBaslik.Focus()
        txtBaslik.Text = ""
        txtIcerik.Text = ""
        dtTarih.Value = DateTime.Now()
        btnGuncelle.Enabled = False
        btnSil.Enabled = False
        dtwKayitlar.ClearSelection()
        chbOnemli.Checked = False
        btnWordAktar.Enabled = False
        btnYazdir.Enabled = False
    End Sub
    Private Sub Form_NotDefterim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTemizle()
        KayitGetir()
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
        Dim Tarih As Date = dtTarih.Text
        Dim Icerik As String = txtIcerik.Text
        Dim Onemli As String = chbOnemli.CheckState
        If txtBaslik.Text = "" Or txtIcerik.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dtwKayitlar.Rows.Add(chbOnemli.Checked, txtBaslik.Text, dtTarih.Text, txtIcerik.Text)
            dtwKayitlar.ClearSelection()
            Baglan()
            sql = "insert into Notlarim (Onemli,Baslik,Tarih,Icerik,KNId) VALUES ('" & Onemli & "','" & Baslik & "','" & Tarih & "','" & Icerik & "','" & KNId & "')"
            sqlCalistir(Sql)
            Baglan.Close()
            txtTemizle()
            KayitGetir()
        End If
    End Sub

    Private Sub dtwKayitlar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwKayitlar.CellClick
        chbOnemli.Checked = dtwKayitlar.CurrentRow.Cells(0).Value.ToString()
        txtBaslik.Text = dtwKayitlar.CurrentRow.Cells(1).Value.ToString()
        dtTarih.Text = dtwKayitlar.CurrentRow.Cells(2).Value.ToString()
        txtIcerik.Text = dtwKayitlar.CurrentRow.Cells(3).Value.ToString()
        txtKayitId.Text = dtwKayitlar.CurrentRow.Cells(4).Value.ToString()
        btnGuncelle.Enabled = True
        btnSil.Enabled = True
        btnYeni.Enabled = True
        btnWordAktar.Enabled = True
        btnYazdir.Enabled = True
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim Onemli As String = chbOnemli.CheckState
        Dim tarih As Date = dtTarih.Text
        If txtKayitId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim kayitId As Integer = Convert.ToInt32(txtKayitId.Text)
        Try
            sqlCalistir("update Notlarim set Onemli='" & Onemli & "',Baslik='" & txtBaslik.Text & "',Tarih='" & tarih & "',Icerik='" & txtIcerik.Text & "',KNId='" & KNId & "' where id=" & kayitId)
            MetroMessageBox.Show(Me, "Kaydınız Başarıyla Güncellenmiştir...", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            KayitGetir()
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Sistemede Bir Sorun Olustu...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click


        If txtKayitId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim result As Integer = MetroMessageBox.Show(Me, "Silmek istediğinize emin misiniz ?.", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Dim kayitId As Integer = Convert.ToInt32(txtKayitId.Text)
            Try
                sqlCalistir("delete from Notlarim where id=" & kayitId)
                txtTemizle()
                KayitGetir()
                btnSil.Enabled = False
                btnGuncelle.Enabled = False
            Catch ex As Exception
                MetroMessageBox.Show(Me, "Sistemde Bir Hata Olustu...", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            End Try
        End If
    End Sub

    Private Sub cbbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbKategori.SelectedIndexChanged
        If cbbKategori.SelectedIndex = 0 Then
            Dim dt As DataTable = dtGetir("select * from Notlarim Where Onemli=" & True)
            dtwKayitlar.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                dtwKayitlar.Rows.Add(dt.Rows(i)("Onemli"), dt.Rows(i)("Baslik"), dt.Rows(i)("Tarih"), dt.Rows(i)("Icerik"), dt.Rows(i)("id"))
            Next
        ElseIf cbbKategori.SelectedIndex = 1 Then
            Dim dt As DataTable = dtGetir("select * from Notlarim")
            dtwKayitlar.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                dtwKayitlar.Rows.Add(dt.Rows(i)("Onemli"), dt.Rows(i)("Baslik"), dt.Rows(i)("Tarih"), dt.Rows(i)("Icerik"), dt.Rows(i)("id"))
            Next
        End If
    End Sub

    Sub KayitGetir()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Notlarim Where KNId=" & KNId)
        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add(dt.Rows(i)("Onemli"), dt.Rows(i)("Baslik"), dt.Rows(i)("Tarih"), dt.Rows(i)("Icerik"), dt.Rows(i)("id"))
        Next

    End Sub

    Private Sub btnWordAktar_Click(sender As Object, e As EventArgs) Handles btnWordAktar.Click

    End Sub
End Class