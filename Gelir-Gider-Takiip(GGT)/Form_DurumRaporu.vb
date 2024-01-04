
Imports System.Data.OleDb

Public Class Form_DurumRaporu
    Dim KNId As Integer
    Private Sub Form_DurumRaporu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridBankalar.ClearSelection()

        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        TotalGelir()
        TotalGider()
        KalanTaksit()
        BankaHesaplari()
        KayitGetir()
    End Sub

    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
    End Sub

    Sub TotalGelir()
        Dim GelirTotal As Integer
        Dim dt As DataTable = dtGetir("SELECT SUM(Miktar) AS total FROM Gelirlerim Where KNId=" & KNId)
        GelirTotal = dt.Rows(0)("total").ToString()
        lblGuncelBakiye.Text = GelirTotal.ToString("C")
    End Sub

    Sub TotalGider()
        Dim GiderTotal As Integer
        Dim dt As DataTable = dtGetir("SELECT SUM(Miktar) AS total FROM Giderlerim Where KNId=" & KNId)
        GiderTotal = dt.Rows(0)("total").ToString()
        lblBorc.Text = GiderTotal.ToString("C")
    End Sub
    Sub KalanTaksit()
        Dim KalanTaksit As Integer
        Dim dt As DataTable = dtGetir("Select Count(*) As Toplam From Taksitler where KNId=" & KNId)
        KalanTaksit = dt.Rows(0)("Toplam").ToString()
        lblKalanTaksit.Text = KalanTaksit.ToString()
    End Sub

    Sub BankaHesaplari()
        Dim BankaHesaplari As Integer
        Dim dt As DataTable = dtGetir("Select Count(*) As Toplam From BankaHesaplari where KNId =" & KNId)
        BankaHesaplari = dt.Rows(0)("Toplam").ToString()
        lblBankaHesapları.Text = BankaHesaplari.ToString()
    End Sub

    Private Sub btnBankaEkle_Click(sender As Object, e As EventArgs) Handles btnBankaEkle.Click
        Form_BankaEkle.Show()
        Form_BankaEkle.btnKaydet.Visible = True
    End Sub
    Sub KayitGetir()
        Dim dt As DataTable = dtGetir("select * from Bankalar Where KNId=" & KNId)
        gridBankalar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            gridBankalar.Rows.Add(dt.Rows(i)("Bankalar"), dt.Rows(i)("DovizCinsi"), dt.Rows(i)("DovizCnsBakiye"), dt.Rows(i)("GuncelTlBakiye"), dt.Rows(i)("Yuzde"), dt.Rows(i)("id"))
        Next
    End Sub

    Private Sub gridBankalar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridBankalar.CellClick
        Dim frm As New Form_BankaEkle
        frm.cbbBankalar.Text = gridBankalar.CurrentRow.Cells(0).Value.ToString()
        frm.cbbDovizCinsi.Text = gridBankalar.CurrentRow.Cells(1).Value.ToString()
        frm.txtDovizBakiye.Text = gridBankalar.CurrentRow.Cells(2).Value.ToString()
        frm.txtTlBakiye.Text = gridBankalar.CurrentRow.Cells(3).Value.ToString()
        frm.txtYuzde.Text = gridBankalar.CurrentRow.Cells(4).Value.ToString()
        frm.lblId.Text = gridBankalar.CurrentRow.Cells(5).Value.ToString()
        frm.btnGuncelle.Visible = True
        frm.Show()

    End Sub
End Class