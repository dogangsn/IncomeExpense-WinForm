Imports MetroFramework
Imports System.Net.Mail
Imports System.Data.OleDb
Public Class Form_ParolamıUnuttum
    Dim randomParola As String
    Private Sub btnSifirla_Click(sender As Object, e As EventArgs) Handles btnSifirla.Click


        If txtEmail.Text = "" And txtAdi.Text = "" Then
            MetroMessageBox.Show(Me, "Lütfen Bilgilerinizi Eksiksiz doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Rastgale()


            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Kullanici] WHERE [Mail] = '" & txtEmail.Text & "'", Baglan)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            Dim MailDogruMu As Boolean = False
            While dr.Read
                MailDogruMu = True
            End While

            If MailDogruMu = True Then
                'Net.NetworkCredential("info.gelir.gider@gmail.com", "c4e128b141aFb")
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("dgn.guness.98@hotmail.com", "06dogan061998")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.live.com"

                e_mail = New MailMessage()
                e_mail.From = New MailAddress("dgn.guness.98@hotmail.com")
                e_mail.To.Add(txtEmail.Text)
                e_mail.Subject = "Parola Sıfırlama"
                e_mail.IsBodyHtml = False
                e_mail.Body = randomParola & " " & ":Yeni Parolanız."
                Smtp_Server.Send(e_mail)



                Dim ds As DataSet = dsGetir("select KNId from Kullanici where Mail='" & txtEmail.Text & "'")
                Dim KNId As Integer = ds.Tables("Kullanici").Rows(0).Item(0)

                sqlCalistir("update Kullanici set Parola='" & randomParola & "' where KNId=" & KNId)

                '------------YedekYol-----------------------
                'Dim ds As DataTable = dtGetir("select KNId from Kullanıici where Mail='" & txtEmail.Text & "'")
                'DataGridView1.DataSource = ds
                'Dim deger As Integer = Convert.ToInt32(DataGridView1.Item(0, 0).Value)

                'MsgBox(deger.ToString())
                '-----------------------------------------







                Dim result As Integer = MetroMessageBox.Show(Me, "Parola sıfırlama işlemi onaylandı. Mailinizi Kontrol ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    Login_Girisi.Show()
                    Me.Close()
                End If
            Else
                MetroMessageBox.Show(Me, "Sistemde Kayıtlı Olmayan Bir Adres Kullandınız ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmail.Text = ""
            End If


        End If
    End Sub


    Private Sub btnVazgec_Click(sender As Object, e As EventArgs) Handles btnVazgec.Click
        txtAdi.Text = ""
        txtEmail.Text = ""
        Me.Hide()
    End Sub

    Sub Rastgale()
        Dim k As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M"}
        For i As Integer = 0 To 7
            Randomize()
            randomParola += k(Rnd() * 32)
        Next
    End Sub
End Class