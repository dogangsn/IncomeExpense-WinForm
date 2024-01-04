Imports System.Data.OleDb
Public Class Login_Girisi
    Public Shared Resim As String
    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click


        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Kullanici] WHERE [KullaniciAdi] = '" & txtKullaniciAdi.Text & "' AND [Parola] = '" & txtParola.Text & "'", Baglan)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim kullniciVarMi As Boolean = False
        Dim KullaniciAdi As String = ""

        While dr.Read
            kullniciVarMi = True
            KullaniciAdi = dr("KullaniciAdi").ToString
            Resim = dr("Resim").ToString
        End While

        If kullniciVarMi = True Then
            Form_AnaSayfa.Show()
            Form_AnaSayfa.lblKullaniciAdi.Text = KullaniciAdi
            Me.Hide()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Kullanıcı Adını veya Şifrenizi Kontrol Ediniz.", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)
            For Each c As Control In Controls
                If TypeOf c Is MetroFramework.Controls.MetroTextBox Then
                    c.Text = ""
                    txtKullaniciAdi.Focus()
                End If
            Next
        End If
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Application.Exit()
    End Sub

    Private Sub toggleParolaGoster_Toggled(sender As Object, e As EventArgs) Handles toggleParolaGoster.Toggled
        If toggleParolaGoster.IsOn = True Then
            'toggleBar Aktifse
            txtParola.PasswordChar = ""
        Else
            'toggleBar Pasifse
            txtParola.PasswordChar = "*"
        End If
    End Sub

    Private Sub lnkKayitOl_Click(sender As Object, e As EventArgs) Handles lnkKayitOl.Click
        Kayit_Ol.Show()
    End Sub

    Private Sub lnkParolaUnuttum_Click(sender As Object, e As EventArgs) Handles lnkParolaUnuttum.Click
        Form_ParolamıUnuttum.Show()
    End Sub

    Private Sub Login_Girisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtKullaniciAdi.Focus()
    End Sub
End Class