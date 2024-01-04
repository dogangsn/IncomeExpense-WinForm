Imports System.Data.OleDb
Imports MetroFramework

Public Class Form_BankaEkle
    Dim KNId As Integer
    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
    End Sub

    Private Sub Form_BankaEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        BankalariListele()
    End Sub
    Sub BankalariListele()
        Try
            Dim sql As String
            sql = "Select id,Banka From BankaHesaplari where KNId =" & KNId
            Dim da As New OleDbDataAdapter(sql, Baglan)
            Dim ds As New DataSet
            da.Fill(ds)
            Dim datatable As DataTable = ds.Tables(0)
            cbbBankalar.DataSource = ds.Tables(0)
            cbbBankalar.DisplayMember = "Banka"
            cbbBankalar.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If txtTlBakiye.Text = "" And txtDovizBakiye.Text = "" And txtYuzde.Text = "" And cbbBankalar.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sqlCalistir("insert into Bankalar (Bankalar,DovizCinsi,DovizCnsBakiye,GuncelTlBakiye,Yuzde,KNId) VALUES ('" & cbbBankalar.Text & "','" & cbbDovizCinsi.Text & "','" & txtDovizBakiye.Text & "','" & txtTlBakiye.Text & "','" & txtYuzde.Text & "','" & KNId & "')")
            btnKaydet.Visible = False
            Me.Hide()
        End If
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        If lblId.Text = "" Then
            MsgBox("Bir Kayıt Seçiniz!", vbCritical, "Hata")
            Return
        End If
        Dim kayitId As Integer = Convert.ToInt32(lblId.Text)
        Try
            sqlCalistir("update Bankalar set Bankalar='" & cbbBankalar.Text & "',DovizCinsi='" & cbbDovizCinsi.Text & "',DovizCnsBakiye='" & txtDovizBakiye.Text & "',GuncelTlBakiye='" & txtTlBakiye.Text & "',Yuzde='" & txtYuzde.Text & "',KNId='" & KNId & "' where id=" & kayitId)
            MetroMessageBox.Show(Me, "Kaydınız Başarıyla Güncellenmiştir...", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            btnGuncelle.Visible = False
            Me.Hide()
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Sistemede Bir Sorun Olustu...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class