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

Public Class frm5STOCKS

    Private Sub frm5STOCKS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''FUNCTIONS
        opendbStocks()
        sqlqueryStocks()
        lock()
        ''TABLE SOURCE
        dgStocks.DataSource = dbds.Tables("tblStocks")
        dgStocks.Columns("DESCRIPTION").MinimumWidth = 180
        dgStocks.ColumnHeadersDefaultCellStyle.Font = New Font("Cooper", 14, FontStyle.Bold)

        ' Subscribe to the TextChanged event of the search TextBox
        AddHandler txtSearch.TextChanged, AddressOf txtSearch_TextChanged
        txtSearch.Visible = False

    End Sub

    ' Event handler for the TextChanged event of the search TextBox
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Get the search keyword from the TextBox
        Dim keyword As String = txtSearch.Text.Trim()

        ' Perform the search based on the keyword
        SearchItems(keyword)
    End Sub

    ' Method to perform the search and update the DataGridView
    Private Sub SearchItems(ByVal keyword As String)
        If String.IsNullOrEmpty(keyword) Then
            ' If the keyword is empty, show all items in the DataGridView
            dgStocks.DataSource = dbds.Tables("tblStocks")
        Else
            ' Filter the items based on the keyword
            Dim filteredItems As DataRow() = dbds.Tables("tblStocks").Select("BARCODE LIKE '%" & keyword & "%'")

            ' Create a new DataTable to hold the filtered items
            Dim filteredTable As DataTable = dbds.Tables("tblStocks").Clone()

            ' Add the filtered rows to the new DataTable
            For Each row As DataRow In filteredItems
                filteredTable.ImportRow(row)
            Next

            ' Display the filtered items in the DataGridView
            dgStocks.DataSource = filteredTable
        End If
    End Sub

    ''LOCK FUNC
    Sub lock()
        txtBARCODE.ReadOnly = True
        txtIN.ReadOnly = True
        txtDESCRIPTION.ReadOnly = True
        txtQUANTITY.ReadOnly = True
        txtBUY.ReadOnly = True
        txtSELL.ReadOnly = True
        txtCRIT.ReadOnly = True
    End Sub

    ''UNLOCK FUNC
    Sub unlock()
        txtBARCODE.ReadOnly = False
        txtIN.ReadOnly = False
        txtDESCRIPTION.ReadOnly = False
        txtQUANTITY.ReadOnly = False
        txtBUY.ReadOnly = False
        txtSELL.ReadOnly = False
        txtCRIT.ReadOnly = False
    End Sub

    ''NAVLOCK FUNC
    Sub navlock()
        cmdFirst.Enabled = False
        cmdNext.Enabled = False
        cmdPrev.Enabled = False
        cmdLast.Enabled = False
    End Sub

    ''NAVUNLOCK FUNC
    Sub navunlock()
        cmdFirst.Enabled = True
        cmdNext.Enabled = True
        cmdPrev.Enabled = True
        cmdLast.Enabled = True
    End Sub

    ''CLEAR FUNC
    Sub itemsclear()
        txtBARCODE.Text = ""
        txtIN.Text = ""
        txtDESCRIPTION.Text = ""
        txtQUANTITY.Text = ""
        txtBUY.Text = ""
        txtSELL.Text = ""
        txtCRIT.Text = ""
    End Sub

    ''DISPLAY
    Sub display()
        Try
            txtBARCODE.Text = dbds.Tables("tblStocks").Rows(recpointer).Item("BARCODE")
            txtIN.Text = dbds.Tables("tblStocks").Rows(recpointer).Item("ITEM NAME")
            txtDESCRIPTION.Text = dbds.Tables("tblStocks").Rows(recpointer).Item("DESCRIPTION")
            txtQUANTITY.Text = dbds.Tables("tblStocks").Rows(recpointer).Item("QUANTITY")
            txtBUY.Text = dbds.Tables("tblStocks").Rows(recpointer).Item("BUYING PRICE")
            txtSELL.Text = dbds.Tables("tblStocks").Rows(recpointer).Item("SELLING PRICE")
            txtCRIT.Text = dbds.Tables("tblStocks").Rows(recpointer).Item("CRITICAL")
        Catch ex As Exception
        End Try
    End Sub

    ''MENU EXIT
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        ''Display a MessageBox asking the user if they want to close the window
        If MsgBox("Are you sure you want to close this window?", MsgBoxStyle.Critical + vbYesNo, "Exit") = vbYes Then



            ''Close the form
            frm4MAIN.Show()
            Me.Close()

        Else
            ''Keep focus on the form if "No" is selected
            Me.Focus()
        End If
    End Sub

    ''NAVIGATION-----------------------------------------------------------------------------------------------------
    ''NAV-FIRST
    Private Sub cmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        dgStocks.Rows(recpointer).Selected = False
        recpointer = 0
        dgStocks.Rows(recpointer).Selected = True
        display()
    End Sub

    ''NAV-NEXT
    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If recpointer < trec Then
            dgStocks.Rows(recpointer).Selected = False
            recpointer = recpointer + 1
            dgStocks.Rows(recpointer).Selected = True
            display()
        End If
    End Sub

    ''NAV-PREVIOUS
    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        If recpointer > 0 Then
            dgStocks.Rows(recpointer).Selected = False
            recpointer = recpointer - 1
            dgStocks.Rows(recpointer).Selected = True
            display()
        End If
    End Sub

    ''NAV-LAST
    Private Sub cmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        dgStocks.Rows(recpointer).Selected = False
        recpointer = trec
        dgStocks.Rows(recpointer).Selected = True
        display()
    End Sub
    ''NAVIGATION-----------------------------------------------------------------------------------------------------

    ''CRUD-----------------------------------------------------------------------------------------------------------

    ''ADD
    Private Sub mnuNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewUser.Click
        sw = True
        unlock()
        ''txtprivilege.Visible = False
        ''cboprivilege.Visible = True
        txtBARCODE.Focus()
        dgStocks.Enabled = False
        navlock()
        itemsclear()
    End Sub

    ''DELETE
    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        If MsgBox("Do you want to delete this data?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "DELETING") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE FROM tblStocks WHERE [BARCODE] like '" & txtBARCODE.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlqueryStocks()
            dgStocks.DataSource = dbds.Tables("tblStocks")
            itemsclear()
        End If
    End Sub

    ''SEARCH
    Private Sub mnuSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSearch.Click
        txtSearch.Show()
    End Sub

    ''SAVE
    Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        ''If txtpw.Text.Trim = txtrpw.Text.Trim Then

        ''IF TRUE
        If sw = True Then
            If MsgBox("Proceed transferring these data into the database?", MsgBoxStyle.DefaultButton1 + vbYesNo, "SAVING") = MsgBoxResult.Yes Then
                db.Open()
                dbcmd = New OleDb.OleDbCommand("INSERT INTO tblStocks([BARCODE],[ITEM NAME],[DESCRIPTION],[QUANTITY],[BUYING PRICE],[SELLING PRICE], [CRITICAL]) VALUES ('" & txtBARCODE.Text.Trim & "','" & txtIN.Text.Trim & "','" & txtDESCRIPTION.Text.Trim & "','" & txtQUANTITY.Text.Trim & "','" & txtBUY.Text.Trim & "','" & txtSELL.Text.Trim & "','" & txtCRIT.Text.Trim & "')", db)
                dbcmd.ExecuteNonQuery()
                sqlqueryStocks()
                lock()
                '' cbPRIV.Visible = False
                ''txtPRIV.Visible = True
                dgStocks.Enabled = True
                dgStocks.DataSource = dbds.Tables("tblStocks")
            Else
                txtBARCODE.Focus()
            End If
        End If
        ''IF FALSE
        ''If sw = False Then
        ''If MsgBox("Do you want to save this changes?", MsgBoxStyle.DefaultButton1 + vbYesNo, "UPDATING") = MsgBoxResult.Yes Then
        ''db.Open()
        ''dbcmd = New OleDb.OleDbCommand("UPDATE tblStocks SET [Password]= '" & txtPASS.Text.Trim & "' WHERE [Employee ID]like '" & txtID.Text.Trim & "'", db)
        ''dbcmd.ExecuteNonQuery()
        '' sqlquery()
        ''lock()

        '' dgCoke.Enabled = True
        '' dgCoke.DataSource = dbds.Tables("tblStocks")
        ''Else
        '' Me.Focus()
        '' End If
        '' End If

        '' Else
        '' MsgBox("Passwords doesn't match! Kindly try again.", , "REMINDER")
        ''txtPASS.Focus()
        '' txtPASS.Clear()
        ''txtPASS2.Clear()
        ''End If
    End Sub

    ''CANCEL
    Private Sub mnuCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCancel.Click
        lock()
        ''cbPRIV.Visible = False
        txtBARCODE.Focus()
        dgStocks.Enabled = True
        navunlock()
        dgStocks.Enabled = True
        itemsclear()
    End Sub

    ''EDIT

    Private Sub UpdateItemQuantity(ByVal barcode As String, ByVal quantity As Integer)
        Try
            ' Open the database connection
            db.Open()

            ' Update the quantity in the database
            dbcmd = New OleDbCommand("UPDATE tblStocks SET [QUANTITY] = @Quantity WHERE [BARCODE] = @Barcode", db)
            dbcmd.Parameters.AddWithValue("@Quantity", quantity)
            dbcmd.Parameters.AddWithValue("@Barcode", barcode)
            dbcmd.ExecuteNonQuery()

            ' Refresh the data in the DataGridView
            sqlqueryStocks()
            dgStocks.DataSource = dbds.Tables("tblStocks")

            ' Display success message
            MsgBox("Item quantity updated successfully.", MsgBoxStyle.Information)
        Catch ex As Exception
            ' Display error message
            MsgBox("An error occurred while updating the item quantity.", MsgBoxStyle.Critical)
        Finally
            ' Close the database connection
            db.Close()
        End Try
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        ' Check if an item is selected in the DataGridView
        If dgStocks.SelectedRows.Count > 0 Then
            ' Get the selected item's barcode and current quantity
            Dim barcode As String = dgStocks.SelectedRows(0).Cells("BARCODE").Value.ToString()
            Dim currentQuantity As Integer = CInt(dgStocks.SelectedRows(0).Cells("QUANTITY").Value)

            ' Prompt the user for the new quantity
            Dim newQuantity As String = InputBox("Enter the new quantity for the item:", "Edit Quantity", currentQuantity.ToString())

            ' Check if the user entered a new quantity
            If Not String.IsNullOrEmpty(newQuantity) Then
                ' Convert the new quantity to an integer
                Dim updatedQuantity As Integer
                If Integer.TryParse(newQuantity, updatedQuantity) Then
                    ' Call the function to update the item quantity
                    UpdateItemQuantity(barcode, updatedQuantity)
                Else
                    ' Display an error message if the entered quantity is invalid
                    MsgBox("Invalid quantity. Please enter a valid number.", MsgBoxStyle.Critical)
                End If
            End If
        Else
            ' Display a message if no item is selected in the DataGridView
            MsgBox("Please select an item to edit.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    ''CRUD-----------------------------------------------------------------------------------------------------------

    ''DISPLAY DATAGRIDVIEW
    Private Sub dgStocks_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStocks.CellClick
        recpointer = e.RowIndex
        display()
    End Sub

    ''QUICK EXIT (CAN CAUSE BUG BECAUSE OF SHORTCUT CODE!!!)
    Private Sub mnuQuickExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuickExit.Click
        If MsgBox("Do you want to close this window?", MsgBoxStyle.YesNo, "CLOSING") = MsgBoxResult.Yes Then
            frm4MAIN.Show()
            Me.Close()

        Else
            Me.Focus()
        End If
    End Sub

    ''PRINT
    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
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

                For m = 0 To dgStocks.RowCount - 2
                    For n = 0 To dgStocks.ColumnCount - 1
                        For o As Integer = 1 To dgStocks.Columns.Count
                            xLWorkSheet.Cells(1, o) = dgStocks.Columns(o - 1).HeaderText
                            xLWorkSheet.Cells(m + 2, n + 1) = dgStocks(n, m).Value.ToString

                        Next

                    Next
                Next

                xLWorkSheet.SaveAs(sfd.FileName)
                xlWorkBook.Close()
                xlApp.Quit()


                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xLWorkSheet)

                MsgBox(" SUCESSFUL PRINTING EXCEL DOCIMENT" & vbCrLf & "File are saved as : " & sfd.FileName, MsgBoxStyle.Information)
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

    Private Sub pbToolSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbToolSearch.Click
        txtSearch.Show()
    End Sub

End Class