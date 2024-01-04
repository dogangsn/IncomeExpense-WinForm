Imports MetroFramework
Imports System.Data.OleDb
Public Class Form_SifreDegistir
    Dim KNId As Integer
    Dim password As String
    Private Sub Form_SifreDegistir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEskiParola.Focus()
        KayitGetir()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Kullanici] Where KNId=" & KNId, Baglan)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            password = dr("Parola").ToString
        End While
    End Sub

    Private Sub btnVazgec_Click(sender As Object, e As EventArgs) Handles btnVazgec.Click
        Me.Hide()
        txtEskiParola.Text = ""
        txtTekrarYeniParola.Text = ""
        txtYeniParola.Text = ""
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click


        If txtEskiParola.Text = "" And txtYeniParola.Text = "" And txtTekrarYeniParola.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Zorunlu Alanları Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtTekrarYeniParola.Text <> txtYeniParola.Text Then
                MetroMessageBox.Show(Me, "Parolalar birbiri ile uyusmamaktadır...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtEskiParola.Text <> password Then
                MetroMessageBox.Show(Me, "Parolalar Sistemdeki Parolanızla uyusmamaktadır...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If MetroMessageBox.Show(Me, "Parolanuz Guncellenmiştir...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question) = MsgBoxResult.Ok Then
                    sqlCalistir("update Kullanici set Parola='" & txtYeniParola.Text & "' where KNId=" & KNId)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub chcGizleGoster_CheckedChanged(sender As Object, e As EventArgs) Handles chcGizleGoster.CheckedChanged
        If chcGizleGoster.Checked = True Then
            txtEskiParola.PasswordChar = ""
            txtTekrarYeniParola.PasswordChar = ""
            txtYeniParola.PasswordChar = ""
        Else
            txtEskiParola.PasswordChar = "*"
            txtTekrarYeniParola.PasswordChar = "*"
            txtYeniParola.PasswordChar = "*"
        End If
    End Sub
    Sub KayitGetir()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Notlarim Where KNId=" & KNId)
    End Sub
End Class