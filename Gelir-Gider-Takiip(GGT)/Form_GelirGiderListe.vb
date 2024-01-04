Imports System.Data.OleDb

Public Class Form_GelirGiderListe
    Dim KNId As Integer
    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
    End Sub
    Dim Tarih As Date = Date.Now.AddDays(-30)
    Dim format As String = "dd'/'MM'/'yyyy"
    Dim ilkTarih As DateTime = Tarih.ToString(format)
    Dim sonTarih As DateTime = Now()
    Dim GiderData As DataTable

    Private Sub Form_GelirGiderListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtIlkTarih.Value = Tarih.ToString(format)
        dtSonTarih.Value = sonTarih.ToShortDateString()
        If chbTumKayitlar.Checked = True Then
            GiderKayit()
            GelirKayit()
            dtIlkTarih.Enabled = False
            dtSonTarih.Enabled = False
        Else
            dtSonTarih.Enabled = True
            dtIlkTarih.Enabled = True
        End If
        dtwKayitlar.ClearSelection()
        TotalHesaplama()
    End Sub
    Sub GiderKayit()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Giderlerim Where KNId=" & KNId)
        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add("GİDER", dt.Rows(i)("OBaslik").ToString(), dt.Rows(i)("Miktar").ToString(), dt.Rows(i)("OdemeTarihi").ToString(), dt.Rows(i)("OdenenYer").ToString(), dt.Rows(i)("OdemeTipi").ToString(), dt.Rows(i)("Aciklama").ToString())
        Next
        GelirGiderRenk()
    End Sub
    Sub GelirKayit()
        Dim ds As DataSet = dsGetir("select KNId from Kullanici where KullaniciAdi='" & Form_AnaSayfa.lblKullaniciAdi.Text & "'")
        KNId = ds.Tables("Kullanici").Rows(0).Item(0)
        Dim dt As DataTable = dtGetir("select * from Gelirlerim Where KNId=" & KNId)
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add("GELİR", dt.Rows(i)("Baslik").ToString(), dt.Rows(i)("Miktar").ToString(), dt.Rows(i)("Tarih").ToString(), dt.Rows(i)("Baslik").ToString(), dt.Rows(i)("GelirTipi").ToString(), dt.Rows(i)("Aciklama").ToString())
        Next
        GelirGiderRenk()
    End Sub

    Private Sub btnYazdir_Click(sender As Object, e As EventArgs) Handles btnRapor.Click
        ' Dim ds As DataSet = dsGelir("select * from Gelirlerim")
        Report1.Load(Application.StartupPath & "/GelirGiderListe.frx")
        Report1.RegisterData(DatagridviewToDataset(dtwKayitlar))
        Report1.GetDataSource("Main").Enabled = True
        Dim txtGelir As FastReport.TextObject = Report1.FindObject("txtTotalGelir")
        txtGelir.Text = txtTotalGelirim.Text
        Dim txtGider As FastReport.TextObject = Report1.FindObject("txtTotalGider")
        txtGider.Text = txtTotalGider.Text
        Dim bnt As FastReport.DataBand = Report1.FindObject("Data1")
        bnt.DataSource = Report1.GetDataSource("Main")
        Report1.Prepare()
        Report1.ShowPrepared()
    End Sub
    Sub TotalHesaplama()
        Dim totalGelir As Integer
        Dim totalGider As Integer
        For Each gelirTopla As DataGridViewRow In dtwKayitlar.Rows
            If gelirTopla.Cells(0).Value = "GELİR" Then
                totalGelir += CDbl(gelirTopla.Cells(2).Value)
                txtTotalGelirim.Text = totalGelir.ToString("C")
            End If
            If gelirTopla.Cells(0).Value = "GİDER" Then
                totalGider += CDbl(gelirTopla.Cells(2).Value)
                txtTotalGider.Text = totalGider.ToString("C")
                txtTotalGider.ForeColor = Color.White
            End If
        Next
    End Sub
    Private Sub chbTumKayitlar_CheckedChanged(sender As Object, e As EventArgs) Handles chbTumKayitlar.CheckedChanged
        dtSonTarih.Enabled = True
        dtIlkTarih.Enabled = True
        If chbTumKayitlar.Checked = False Then
            TariheGoreFiltrele()
        Else
            dtwKayitlar.Rows.Clear()
            dtIlkTarih.Enabled = False
            dtSonTarih.Enabled = False
            GiderKayit()
            GelirKayit()
        End If

    End Sub
    Sub GelirGiderRenk()
        For Each gider As DataGridViewRow In dtwKayitlar.Rows
            If gider.Cells(0).Value = "GİDER" Then
                gider.DefaultCellStyle.BackColor = Color.IndianRed
                gider.DefaultCellStyle.ForeColor = Color.White
            End If
            If gider.Cells(0).Value = "GELİR" Then
                gider.DefaultCellStyle.BackColor = Color.PaleGreen
                gider.DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub
    Sub TariheGoreFiltrele()
        Dim xs1 As String
        Dim xs2 As String
        xs1 = Date.Parse(dtIlkTarih.Text).ToString("MM'/'dd'/'yyyy")
        xs2 = Date.Parse(dtSonTarih.Text).ToString("MM'/'dd'/'yyyy")


        Dim dt As DataTable = dtGetir("SELECT * from Giderlerim where OdemeTarihi Between #" & xs1 & "# And #" & xs2 & "#")
        Dim ds As DataTable = dtGetir("SELECT * from Gelirlerim where Tarih Between #" & xs1 & "# And #" & xs2 & "#")
        dtwKayitlar.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dtwKayitlar.Rows.Add("GİDER", dt.Rows(i)("OBaslik").ToString(), dt.Rows(i)("Miktar").ToString(), dt.Rows(i)("OdemeTarihi").ToString(), dt.Rows(i)("OdenenYer").ToString(), dt.Rows(i)("OdemeTipi").ToString(), dt.Rows(i)("Aciklama").ToString())
        Next
        For i = 0 To ds.Rows.Count - 1
            dtwKayitlar.Rows.Add("GELİR", ds.Rows(i)("Baslik").ToString(), ds.Rows(i)("Miktar").ToString(), ds.Rows(i)("Tarih").ToString(), ds.Rows(i)("Baslik").ToString(), ds.Rows(i)("GelirTipi").ToString(), ds.Rows(i)("Aciklama").ToString())
        Next
        GelirGiderRenk()
    End Sub


    Public Function DatagridviewToDataset(ByVal dgv As DataGridView) As System.Data.DataSet
        Dim ds As New System.Data.DataSet
        Try
            ds.Tables.Add("Main")
            Dim col As System.Data.DataColumn
            For Each dgvCol As DataGridViewColumn In dgv.Columns
                col = New System.Data.DataColumn(dgvCol.Name)
                ds.Tables("Main").Columns.Add(col)
            Next
            Dim row As System.Data.DataRow
            Dim colcount As Integer = dgv.Columns.Count - 1
            For j As Integer = 0 To dgv.Rows.Count - 1
                row = ds.Tables("Main").Rows.Add
                For Each column As DataGridViewColumn In dgv.Columns
                    row.Item(column.Index) = dgv.Rows.Item(j).Cells(column.Index).Value
                Next
            Next

            Return ds
        Catch ex As Exception
            MessageBox.Show("DataGridView Hata Donüşümü" & ex.InnerException.ToString,
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Sub dtIlkTarih_ValueChanged(sender As Object, e As EventArgs) Handles dtIlkTarih.ValueChanged
        TariheGoreFiltrele()
        TotalHesaplama()
    End Sub

    Private Sub dtSonTarih_ValueChanged(sender As Object, e As EventArgs) Handles dtSonTarih.ValueChanged
        TariheGoreFiltrele()
        TotalHesaplama()
    End Sub
End Class