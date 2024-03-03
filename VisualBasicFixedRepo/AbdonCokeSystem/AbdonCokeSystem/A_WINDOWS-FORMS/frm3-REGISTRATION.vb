Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Linq
Imports Microsoft.Office.core
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports System.Data.OleDb

Public Class frm3REGISTRATION


    ''------------------------------------------------------------------------------------------------------------------------
    ''FORMLOAD
    ''------------------------------------------------------------------------------------------------------------------------
    Private Sub frm3REGISTRATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''FUNCTIONS
        opendb()
        sqlquery()
        lock()

        ''TABLE SOURCE
        dgCoke.DataSource = dbds.Tables("tblUser")
        display()

        ''Sort Employee ID column in ascending order
        SortEmployeeIDAscending()

        ''Default Image - NEEDS ADJUSTMENT - ONLY TARGETS D:
        ''NOTE
        ''picPersonal.Image = Image.FromFile("E:\VisualBasicFixedRepo\AbdonCokeSystem\AbdonCokeSystem\img\4F-USER.png")

        ''FOR DATAGRIDVIEW HEADER
        dgCoke.ColumnHeadersDefaultCellStyle.Font = New Font("Cooper", 12, FontStyle.Bold)

        mnuSave.Enabled = False
        mnuCancel.Enabled = False
        ''SEARCH
        tbSearch.Hide()
    End Sub
    ''------------------------------------------------------------------------------------------------------------------------
    ''FORMLOAD
    ''------------------------------------------------------------------------------------------------------------------------


    ''--------------------------------------------------------------------------------------------------------------------------------------------
    ''CRUD FUNCTIONALITIES
    ''--------------------------------------------------------------------------------------------------------------------------------------------
    ''1 FOR MENU-NEWUSER(CREATE)(ORIGINAL)
    Private Sub mnuNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewUser.Click
        mnuSave.Enabled = True
        mnuCancel.Enabled = True
        mnuNewUser.Enabled = False
        mnuSearch.Enabled = False
        mnuEdit.Enabled = False
        mnuDelete.Enabled = False
        mnuPrint.Enabled = False
        mnuExit.Enabled = False

        sw = True
        unlock()
        txtPRIV.Visible = False
        cbPRIV.Visible = True
        txtID.Focus()
        dgCoke.Enabled = False
        navlock()
        itemsclear()

        ''AUTO ID in ADD
        Dim name As String = "CC-"
        Dim number As Integer = 1
        ' Get the highest existing Employee ID from the database
        Dim maxEmployeeID As Integer = 0
        For Each row As DataRow In dbds.Tables("tblUser").Rows
            Dim employeeID As String = row.Item("Employee ID").ToString()
            Dim employeeNumber As Integer
            If Integer.TryParse(employeeID.Substring(3), employeeNumber) Then
                If employeeNumber > maxEmployeeID Then
                    maxEmployeeID = employeeNumber
                End If
            End If
        Next
        ' Increment the highest existing Employee ID to generate a new Employee ID
        number = maxEmployeeID + 1
        txtID.Text = name & number.ToString("0000")
        txtID.Enabled = False
        txtUN.Focus()
        ''NOTE
        ''picPersonal.Image = Image.FromFile("E:\VisualBasicFixedRepo\AbdonCokeSystem\AbdonCokeSystem\img\4F-USER.png")
    End Sub

    ''1.1 FOR MENU-NEWUSER(CREATE)(FORCE CREATE ID)
    Private Sub mnuForceCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuForceCreate.Click
        mnuSave.Enabled = True
        mnuCancel.Enabled = True
        sw = True
        unlock()
        txtPRIV.Visible = False
        cbPRIV.Visible = True
        txtID.Focus()
        dgCoke.Enabled = False
        navlock()
        itemsclear()

        ''AUTO ID in ADD
        Dim name As String = "CC-"
        Dim number As Integer = 1
        txtID.Enabled = True
        number = dbds.Tables("tblUser").Rows.Count + 1
        txtID.Text = name + number.ToString("0000")
        db.Close()
        txtPRIV.Visible = False
        cbPRIV.Visible = True
        txtID.Focus()

        SortEmployeeIDAscending()
    End Sub

    ''2.1 SEARCH in MsgBox
    Private Sub mnuSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSearch.Click
        tbSearch.Show()
        tbSearch.Focus()
    End Sub
    ''2.2 SEARCH in txtbox
    Private Sub tbSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSearch.TextChanged
        SortEmployeeIDAscending()

        Dim searchQuery As String = tbSearch.Text.Trim()

        Try
            ''tblUser = New OleDb.OleDbDataAdapter("SELECT * FROM tblUser WHERE [Employee ID] LIKE '%" & searchQuery & "%' OR [Username] LIKE '%" & searchQuery & "%' OR [Position] LIKE '%" & searchQuery & "%' OR [Privilege] LIKE '%" & searchQuery & "%'", db)
            tblUser = New OleDb.OleDbDataAdapter("SELECT [Employee ID], [Username], [Position], [Privilege] FROM tblUser WHERE [Employee ID] LIKE '%" & searchQuery & "%' OR [Username] LIKE '%" & searchQuery & "%' OR [Position] LIKE '%" & searchQuery & "%' OR [Privilege] LIKE '%" & searchQuery & "%'", db)
            dbds = New DataSet
            tblUser.Fill(dbds, "tblUser")
            dgCoke.DataSource = dbds.Tables("tblUser")
        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally
            db.Close()
        End Try


    End Sub

    ''3 FOR MENU-SAVE(SAVE)
    Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        mnuNewUser.Enabled = True
        mnuSearch.Enabled = True
        mnuEdit.Enabled = True
        mnuDelete.Enabled = True
        mnuPrint.Enabled = True
        mnuExit.Enabled = True

        mnuSave.Enabled = False
        mnuCancel.Enabled = False

        If txtPASS.Text.Trim = txtPASS2.Text.Trim Then
            ''IF TRUE
            If sw = True Then
                If MsgBox("Proceed transferring these data into the database?", MsgBoxStyle.DefaultButton1 + vbYesNo, "SAVING") = MsgBoxResult.Yes Then
                    db.Open()
                    dbcmd = New OleDb.OleDbCommand("INSERT INTO tblUser([Employee ID],[Username],[Password],[Position],[Privilege]) VALUES ('" & txtID.Text.Trim & "','" & txtUN.Text.Trim & "','" & txtPASS.Text.Trim & "','" & txtPOS.Text.Trim & "','" & cbPRIV.Text.Trim & "')", db)
                    dbcmd.ExecuteNonQuery()
                    sqlquery()
                    lock()
                    cbPRIV.Visible = False
                    txtPRIV.Visible = True
                    dgCoke.Enabled = True
                    dgCoke.DataSource = dbds.Tables("tblUser")
                Else
                    txtID.Focus()
                End If
            End If
            ''IF FALSE
            If sw = False Then
                If MsgBox("Do you want to save this changes?", MsgBoxStyle.DefaultButton1 + vbYesNo, "UPDATING") = MsgBoxResult.Yes Then
                    db.Open()
                    dbcmd = New OleDb.OleDbCommand("UPDATE tblUser SET [Password]= '" & txtPASS.Text.Trim & "' WHERE [Employee ID]like '" & txtID.Text.Trim & "'", db)
                    dbcmd.ExecuteNonQuery()
                    sqlquery()
                    lock()
                    dgCoke.Enabled = True
                    dgCoke.DataSource = dbds.Tables("tblUser")
                Else
                    Me.Focus()
                End If
            End If
        Else
            MsgBox("Passwords doesn't match! Kindly try again.", , "REMINDER")
            txtPASS.Focus()
            txtPASS.Clear()
            txtPASS2.Clear()
        End If
        SortEmployeeIDAscending()
    End Sub

    ''4 FOR MENU-EDIT(UPDATE)
    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        mnuNewUser.Enabled = True
        mnuSearch.Enabled = True
        mnuEdit.Enabled = True
        mnuDelete.Enabled = True
        mnuPrint.Enabled = True
        mnuExit.Enabled = True

        mnuSave.Enabled = True
        mnuCancel.Enabled = True

        sw = False
        txtPASS.ReadOnly = False
        txtPASS2.ReadOnly = False
        txtPASS.Clear()
        txtPASS2.Clear()
        dgCoke.Enabled = False
        txtPASS.Focus()

        SortEmployeeIDAscending()
    End Sub

    ''5 FOR MENU-DELETE(DELETE)
    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        mnuNewUser.Enabled = True
        mnuSearch.Enabled = True
        mnuEdit.Enabled = True
        mnuDelete.Enabled = True
        mnuPrint.Enabled = True
        mnuExit.Enabled = True

        mnuSave.Enabled = False
        mnuCancel.Enabled = True

        If MsgBox("Do you want to delete this data?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "DELETING") = MsgBoxResult.Yes Then
            db.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE FROM tblUser WHERE [Employee ID] like '" & txtID.Text.Trim & "'", db)
            dbcmd.ExecuteNonQuery()
            sqlquery()
            dgCoke.DataSource = dbds.Tables("tblUser")
            itemsclear()
        End If

        SortEmployeeIDAscending()
    End Sub

    ''6 FOR MENU-CANCEL(CANCEL)
    Private Sub mnuCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCancel.Click
        mnuNewUser.Enabled = True
        mnuSearch.Enabled = True
        mnuEdit.Enabled = True
        mnuDelete.Enabled = True
        mnuPrint.Enabled = True
        mnuExit.Enabled = True

        mnuSave.Enabled = False
        mnuCancel.Enabled = False

        lock()
        cbPRIV.Visible = False
        txtID.Focus()
        dgCoke.Enabled = True
        navunlock()
        dgCoke.Enabled = True
        itemsclear()

        SortEmployeeIDAscending()
    End Sub

    ''7 FOR MENU-EXIT
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
        If Not frm2VERIFICATION Is Nothing AndAlso frm2VERIFICATION.Visible = True Then 'Checking if frm2VERIFICATION is still open
            frm2VERIFICATION.Close()
            frm1WELCOME.Show() 'Redirecting to frm1WELCOME
        End If
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
    ''--------------------------------------------------------------------------------------------------------------------------------------------
    ''CRUD FUNCTIONALITIES
    ''--------------------------------------------------------------------------------------------------------------------------------------------


    ''--------------------------------------------------------------------------------------------------------------------------------------------
    ''FOR DISPLAY DATA GRID
    ''--------------------------------------------------------------------------------------------------------------------------------------------
    ''DISPLAY DATA GRID
    Private Sub dgCoke_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCoke.CellClick
        recpointer = e.RowIndex
        display()
    End Sub

    ''--------------------------------------------------------------------------------------------------------------------------
    ''FOR PICTURE BOX DISPLAY
    ''--------------------------------------------------------------------------------------------------------------------------
    ''PICTURE BOX
    Private Sub btnPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonal.Click
        If txtID.Text.Trim.Length > 0 Then
            ofdPersonal.FileName = ""
            ofdPersonal.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg"
            ofdPersonal.ShowDialog()
            If ofdPersonal.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    My.Computer.FileSystem.CopyFile(ofdPersonal.FileName, Application.StartupPath & "\images\" & Trim(txtID.Text) & ".jpg", True)
                    picPersonal.ImageLocation = Application.StartupPath & "\images\" & txtID.Text.Trim & ".jpg"
                    picPersonal.Load()

                Catch err As Exception
                    MsgBox(err.ToString)
                End Try

            End If
        Else
            MsgBox("Enter your employee ID!", MsgBoxStyle.Information, "WARNING!")
        End If
    End Sub

    ''FOR DATAGRID PICTURE
    Private Sub dgCoke_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCoke.RowEnter
        recpointer = (e.RowIndex)
        display()
        Try
            picPersonal.ImageLocation = ""
            picPersonal.Refresh()
            picPersonal.ImageLocation = Application.StartupPath & "\images\" & txtID.Text.Trim & ".jpg"
            picPersonal.Load()
        Catch ex As Exception
        End Try
    End Sub
    ''--------------------------------------------------------------------------------------------------------------------------

    ''---------------------------------------------------------------------------------------------------------------------------------------
    ''FOR FORM3 FUNCTIONS
    ''---------------------------------------------------------------------------------------------------------------------------------------
    ''FOR SORTING FUNC
    Private Sub SortEmployeeIDAscending()
        dgCoke.DataSource = dbds.Tables("tblUser")
        dgCoke.Sort(dgCoke.Columns("Employee ID"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    ''---------------------------------------------------------------------------------------------
    ''FOR LOCK AND UNLOCK FUNC
    ''FOR LOCK FUNC
    Sub lock()
        txtID.ReadOnly = True
        txtUN.ReadOnly = True
        txtPASS.ReadOnly = True
        txtPASS2.ReadOnly = True
        txtPOS.ReadOnly = True
        txtPRIV.ReadOnly = True
        cbPRIV.Visible = False
    End Sub
    ''FOR UNLOCK FUNC
    Sub unlock()
        txtID.ReadOnly = False
        txtUN.ReadOnly = False
        txtPASS.ReadOnly = False
        txtPASS2.ReadOnly = False
        txtPOS.ReadOnly = False
        txtPRIV.ReadOnly = False
        cbPRIV.Visible = True
    End Sub
    ''---------------------------------------------------------------------------------------------

    ''---------------------------------------------------------------------------------------------
    ''FOR LOCK AND UNLOCK FUNC
    ''FOR NAVLOCK FUNC
    Sub navlock()
        cmdFirst.Enabled = False
        cmdNext.Enabled = False
        cmdPrev.Enabled = False
        cmdLast.Enabled = False
    End Sub
    ''FOR NAVUNLOCK FUNC
    Sub navunlock()
        cmdFirst.Enabled = True
        cmdNext.Enabled = True
        cmdPrev.Enabled = True
        cmdLast.Enabled = True
    End Sub
    ''---------------------------------------------------------------------------------------------

    ''FOR CLEAR FUNC
    Sub itemsclear()
        txtID.Text = ""
        txtUN.Text = ""
        txtPASS.Text = ""
        txtPASS2.Text = ""
        txtPOS.Text = ""
        txtPRIV.Text = ""
        cbPRIV.Text = ""
    End Sub

    ''DISPLAY FUNC
    Sub display()
        Try
            txtID.Text = dbds.Tables("tblUser").Rows(recpointer).Item("Employee ID")
            txtUN.Text = dbds.Tables("tblUser").Rows(recpointer).Item("Username")
            txtPOS.Text = dbds.Tables("tblUser").Rows(recpointer).Item("Position")
            txtPRIV.Text = dbds.Tables("tblUser").Rows(recpointer).Item("Privilege")
        Catch ex As Exception
        End Try
    End Sub
    ''---------------------------------------------------------------------------------------------------------------------------------------

    ''----------------------------------------------------------------------------------------------------------------
    ''FOR NAVIGATION
    ''----------------------------------------------------------------------------------------------------------------
    ''NAV-FIRST
    Private Sub cmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        dgCoke.Rows(recpointer).Selected = False
        recpointer = 0
        dgCoke.Rows(recpointer).Selected = True
        display()
    End Sub
    ''NAV-NEXT
    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If recpointer < trec Then
            dgCoke.Rows(recpointer).Selected = False
            recpointer = recpointer + 1
            dgCoke.Rows(recpointer).Selected = True
            display()
        End If
    End Sub
    ''NAV-PREVIOUS
    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        If recpointer > 0 Then
            dgCoke.Rows(recpointer).Selected = False
            recpointer = recpointer - 1
            dgCoke.Rows(recpointer).Selected = True
            display()
        End If
    End Sub
    ''NAV-LAST
    Private Sub cmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        dgCoke.Rows(recpointer).Selected = False
        recpointer = trec
        dgCoke.Rows(recpointer).Selected = True
        display()
    End Sub
    ''----------------------------------------------------------------------------------------------------------------
    ''PRINT IN EXCEL
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

                For m = 0 To dgCoke.RowCount - 2
                    For n = 0 To dgCoke.ColumnCount - 1
                        For o As Integer = 1 To dgCoke.Columns.Count
                            xLWorkSheet.Cells(1, o) = dgCoke.Columns(o - 1).HeaderText
                            xLWorkSheet.Cells(m + 2, n + 1) = dgCoke(n, m).Value.ToString

                        Next

                    Next
                Next

                xLWorkSheet.SaveAs(sfd.FileName)
                xlWorkBook.Close()
                xlApp.Quit()


                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xLWorkSheet)

                MsgBox(" SUCESSFUL PRINTING EXCEL DOCUMENT" & vbCrLf & "File are saved as : " & sfd.FileName, MsgBoxStyle.Information)
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
        tbSearch.Show()
        tbSearch.Focus()
    End Sub

    Private Sub dgCoke_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCoke.CellContentClick

    End Sub
End Class