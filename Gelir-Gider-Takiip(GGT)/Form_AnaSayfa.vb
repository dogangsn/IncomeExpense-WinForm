Imports MetroFramework
Imports System.Drawing.Drawing2D

Public Class Form_AnaSayfa

    Dim KNId As Integer
    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Application.Exit()
    End Sub

    Private Sub btnGelir_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnGelir.ItemClick
        Form_Gelir.Show()
    End Sub

    Private Sub btnGiderlerim_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnGiderlerim.ItemClick
        Form_Gider.Show()
    End Sub

    Private Sub btnTaksitlerim_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnTaksitlerim.ItemClick
        Form_Taksitler.Show()
    End Sub

    Private Sub btnAjandam_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnAjandam.ItemClick
        Form_Hatirlatma.Show()
    End Sub

    Private Sub btnGelirGiderListesi_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnGelirGiderListesi.ItemClick
        Form_GelirGiderListe.Show()
    End Sub

    Private Sub btnDurumRaporu_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnDurumRaporu.ItemClick
        Form_DurumRaporu.Show()
    End Sub

    Private Sub btnBankaHesaplari_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnBankaHesaplari.ItemClick
        Form_BankaHesaplari.Show()
    End Sub

    Private Sub btnWebAdresim_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnWebAdresim.ItemClick
        Form_WebAdresim.Show()
    End Sub

    Private Sub btnVarliklarim_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnVarliklarim.ItemClick
        Form_Varliklarim.Show()
    End Sub

    Private Sub btnRehberim_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnRehberim.ItemClick
        Form_Rehberim.Show()
    End Sub

    Private Sub btnNotDefteri_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnNotDefteri.ItemClick
        Form_NotDefterim.Show()
    End Sub

    Private Sub btnProgramHakkinda_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnProgramHakkinda.ItemClick
        Form_ProgramHakkinda.Show()
    End Sub

    Private Sub btnParolaDegistir_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnParolaDegistir.ItemClick
        Form_SifreDegistir.Show()
    End Sub

    Private Sub btnKullaniciBilgileri_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnKullaniciBilgileri.ItemClick
        Form_KullaniciBilgileri.Show()
    End Sub

    Private Sub Form_AnaSayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim path As String = Application.StartupPath & "\image\"
        MakeRoundedImage(Image.FromFile(Login_Girisi.Resim), pcResim)
    End Sub

    Public Sub MakeRoundedImage(ByVal Img As Image, ByVal PicBox As PictureBox)

        Using bm As New Bitmap(Img.Width, Img.Height)
            Using grx2 As Graphics = Graphics.FromImage(bm)
                grx2.SmoothingMode = SmoothingMode.AntiAlias
                Using tb As New TextureBrush(Img)
                    tb.TranslateTransform(0, 0)
                    Using gp As New GraphicsPath
                        gp.AddEllipse(0, 0, Img.Width, Img.Height)
                        grx2.FillPath(tb, gp)
                    End Using
                End Using
            End Using
            If PicBox.Image IsNot Nothing Then PicBox.Image.Dispose()
            PicBox.Image = New Bitmap(bm)
        End Using
    End Sub

    Private Sub btnHesabiSil_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles btnHesabiSil.ItemClick
        Dim result As Integer = MetroMessageBox.Show(Me, "Hesabnızı Silmekte Emin misiniz ? Bütün Verilerimizin Kaybolcagını Hatırlatmak İsteriz ...", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & lblKullaniciAdi.Text & "'")
            KNId = ds.Tables("Kullanici").Rows(0).Item(0)
            sqlCalistir("delete from Kullanici where id=" & KNId)
            sqlCalistir("delete from Giderlerim where id=" & KNId)
            sqlCalistir("delete from BankaHesaplari where id=" & KNId)
            sqlCalistir("delete from Bankalar where id=" & KNId)
            sqlCalistir("delete from Gelirlerim where id=" & KNId)
            sqlCalistir("delete from Giderlerim where id=" & KNId)
            sqlCalistir("delete from Notlarim where id=" & KNId)
            sqlCalistir("delete from Rehber where id=" & KNId)
            sqlCalistir("delete from Taksitler where id=" & KNId)
            sqlCalistir("delete from Varliklarim where id=" & KNId)
            sqlCalistir("delete from Taksitler where id=" & KNId)
            sqlCalistir("delete from WebAdresleri where id=" & KNId)
        End If
    End Sub
End Class