Module ExceleAktar


    Public Function excelTablo(ByVal dgv As DataGridView)
        Dim excel As New Microsoft.Office.Interop.Excel.Application()
        excel.Visible = True
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(System.Reflection.Missing.Value)
        Dim sheet1 As Microsoft.Office.Interop.Excel.Worksheet = DirectCast(workbook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
        Dim StartCol As Integer = 1
        Dim StartRow As Integer = 1

        For j As Integer = 0 To dgv.Columns.Count - 1
            Dim myRange As Microsoft.Office.Interop.Excel.Range = DirectCast(sheet1.Cells(StartRow, StartCol + j), Microsoft.Office.Interop.Excel.Range)
            myRange.Value2 = dgv.Columns(j).HeaderText
        Next
        StartRow += 1
        For i As Integer = 0 To dgv.Rows.Count - 1
            For j As Integer = 0 To dgv.Columns.Count - 1
                Try
                    Dim myRange As Microsoft.Office.Interop.Excel.Range = DirectCast(sheet1.Cells(StartRow + i, StartCol + j), Microsoft.Office.Interop.Excel.Range)
                    myRange.Value2 = If(dgv(j, i).Value Is Nothing, "", dgv(j, i).Value)
                    With myRange
                        .Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble
                        If j = 3 Then
                            .NumberFormat = "dd/MM/yyyy"
                        ElseIf j = 4 Then
                            .NumberFormat = "dd/MM/yyyy"
                        End If
                    End With
                Catch

                End Try
            Next
        Next
        Return dgv
    End Function


End Module
