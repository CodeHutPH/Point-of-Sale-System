Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Linq
Imports Microsoft.Office.Core
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class frm7REPORTS

    Private Sub frm7REPORTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''FUNCTIONS
        opendbTransaction()
        sqlqueryTransaction()

        opendbLogin()
        sqlqueryLogin()

        ''TABLE SOURCE
        dgTransaction.DataSource = dbdstrans.Tables("tblTransaction")
        dgTransaction.Visible = False

        dgLogin.DataSource = dbds.Tables("tblLogin")
        dgLogin.Visible = False

    End Sub



    Private Sub btnReportsAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportsAttendance.Click
        Try
            sfd.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xLWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misvalue As Object = System.Reflection.Missing.Value
                Dim m As Integer
                Dim n As Integer


                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misvalue)
                xLWorkSheet = xlWorkBook.Sheets("Sheet1")

                For m = 0 To dgLogin.RowCount - 2
                    For n = 0 To dgLogin.ColumnCount - 1
                        For o As Integer = 1 To dgLogin.Columns.Count
                            xLWorkSheet.Cells(1, o) = dgLogin.Columns(o - 1).HeaderText
                            xLWorkSheet.Cells(m + 2, n + 1) = dgLogin(n, m).Value.ToString

                        Next

                    Next
                Next

                xLWorkSheet.SaveAs(sfd.FileName)
                xlWorkBook.Close()
                xlApp.Quit()


                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xLWorkSheet)

                MsgBox("Fizz-tacular! Report printing was successfully done." & vbCrLf & "File are saved to: " & sfd.FileName, MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("FAILED TO SAVE/PRINTING", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''RELEASE OBJECT EXTENSION
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing

        Finally
            GC.Collect()
        End Try

    End Sub

    ''TRANSAC
    Private Sub btnReportsCashier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportsCashier.Click
        Try
            sfd2.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If sfd2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xLWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misvalue As Object = System.Reflection.Missing.Value
                Dim m As Integer
                Dim n As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misvalue)
                xLWorkSheet = xlWorkBook.Sheets("Sheet1")

                For m = 0 To dgTransaction.RowCount - 2
                    For n = 0 To dgTransaction.ColumnCount - 1
                        For o As Integer = 1 To dgTransaction.Columns.Count
                            xLWorkSheet.Cells(1, o) = dgTransaction.Columns(o - 1).HeaderText
                            xLWorkSheet.Cells(m + 2, n + 1) = dgTransaction(n, m).Value.ToString
                        Next
                    Next
                Next

                xLWorkSheet.SaveAs(sfd2.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xLWorkSheet)

                MsgBox("Fizz-tacular! Report printing was successfully done." & vbCrLf & "File are saved to: " & sfd2.FileName, MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("FAILED TO SAVE/PRINTING", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnTalUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalUser.Click
        crystalUser.Show()
    End Sub
    Private Sub btnTalTryStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalTryStocks.Click
        crystalTryStocks.Show()
    End Sub
    Private Sub btnTalTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalTrans.Click
        crystalTransactions.Show()
    End Sub
   
    Private Sub btnEXEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXEmployee.Click
        frm3REGISTRATION.Show()
        Me.Hide()
    End Sub
    Private Sub btnAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttendance.Click
        crystalAttendance.Show()
    End Sub
  
    Private Sub btnEXStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXStocks.Click
        frm5STOCKS.Show()
        Me.Hide()
    End Sub

    ''EXIT
    Private Sub btn7Fexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7Fexit.Click
        If MsgBox("Do you want to close this window?", MsgBoxStyle.YesNo, "CLOSING") = MsgBoxResult.Yes Then
            frm4MAIN.Show()
            Me.Close()
        Else
            Me.Focus()
        End If
    End Sub

    ''ESC - LOG OUT
    Private Sub frm7REPORTS_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown



        If e.KeyCode = Keys.Escape Then
            ''Display a MessageBox asking the user if they want to close the window
            If MsgBox("Are you sure you want to close this window?", MsgBoxStyle.Critical + vbYesNo, "Exit") = vbYes Then
                ''Close the form
                frm4MAIN.Show()
                Me.Close()
            Else
                ''Keep focus on the form if "No" is selected
                Me.Focus()
            End If
        End If
    End Sub
    
End Class