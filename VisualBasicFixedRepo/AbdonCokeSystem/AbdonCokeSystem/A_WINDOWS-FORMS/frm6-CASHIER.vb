Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class frm6CASHIER

    ''FORMLOAD CASHIER
    Private Sub frm6CASHIER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendbStocks()
        sqlqueryStocks()
        opendbCashier()
        sqlqueryCashier()
        Try
            gbtrans.Focus()

            db.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE * FROM tblCashier", db)
            dbcmd.ExecuteNonQuery()
            dgCashier.DataSource = dbdstemp.Tables("tblCashier")
            dgCashier.Enabled = False
            gbPay.Visible = False
            lblCashier.Text = Xname

            TimerCashier.Enabled = True
            TimerCashier.Interval = 1000 ' Set the timer interval to 1 second (1000 milliseconds)
            lblCurrentTime.Text = Date.Now.ToString("hh : mm : ss tt")
            AddHandler TimerCashier.Tick, AddressOf TimerCashier_Tick ' Assign the event handler
            lblCurrentDate.Text = Date.Now.ToString("dddd - dd - MMMM - yyyy")
            xGTotal = 0

            Dim random As New Random
            Dim str As String = "00000"
            txtTransactionNumber.Text = str + random.Next(1, 100000)
            txtBarcodeNumber.Focus()


            db.Close()

        Catch err As Exception
            ''MsgBox(err.ToString)
        End Try

        ''FOR DATAGRIDVIEW HEADER
        dgCashier.ColumnHeadersDefaultCellStyle.Font = New Font("Cooper", 12, FontStyle.Bold)
    End Sub

    ''TIMER
    Private Sub TimerCashier_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TimerCashier.Enabled = True
        lblCurrentTime.Text = DateTime.Now.ToString("hh : mm : ss tt")
        lblCurrentDate.Text = Date.Now.ToString("dddd - dd - MMMM - yyyy")
    End Sub

    ''QUANTITY
    Private Sub txtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBarcodeNumber.Focus()
            dgCashier.DataSource = dbdstemp.Tables("tblCashier")

            If txtQuantity.Text = "" Then
                MsgBox("Please provide a quantity.", MsgBoxStyle.Information, "WARNING")
                txtQuantity.Focus()
                Exit Sub
            End If

            If e.KeyCode = Keys.Enter Then
                xGTotal = CSng(xGTotal) + CSng(txtSubTotal.Text)
                txtTotal.Text = Format(xGTotal, "Standard")
                db.Open()

                ''NOTE ADD ITEM HERE
                If sw = True Then
                    dbcmd = New OleDb.OleDbCommand("INSERT INTO tblCashier([BARCODE], [DESCRIPTION], [QUANTITY], [UNIT PRICE], [TOTAL]) VALUES ('" & txtBarcodeNumber.Text.Trim & "','" & xDesc & "','" & txtQuantity.Text.Trim & "','" & xUP & "','" & txtSubTotal.Text.Trim & "')", db)
                    dbcmd.ExecuteNonQuery()
                Else
                    xtempq = xtempq + CInt(txtQuantity.Text)
                    xGTotal = CSng(xGTotal) + CSng(txtSubTotal.Text)

                    dbcmd = New OleDb.OleDbCommand("UPDATE tblCashier set [QUANTITY]='" & xtempq & "',[TOTAL]='" & txtTotal.Text & "' where [BARCODE] like '" & txtBarcodeNumber.Text & "'", db)
                    dbcmd.ExecuteNonQuery()
                End If

                sqlqueryCashier()
                dgCashier.DataSource = dbdstemp.Tables("tblCashier")

                txtQuantity.Clear()
                txtBarcodeNumber.Clear()

                tblCashier = New OleDb.OleDbDataAdapter("SELECT sum([TOTAL]) as xt  FROM tblCashier", db)
                dbdstemp = New DataSet()
                tblCashier.Fill(dbdstemp, "tblCashier")

                If dbdstemp.Tables("tblCashier").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbdstemp.Tables("tblCashier").Rows.Count) - 1
                End If

                txtTotal.Text = dbdstemp.Tables("tblCashier").Rows(0).Item("xt")
                txtSubTotal.Clear()
                txtTotal.Text = Format(txtTotal.Text, "Standard")
                txtBarcodeNumber.Focus()
            End If
        End If
    End Sub

    ''QUANTITY
    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        Try
            txtSubTotal.Text = CInt(txtQuantity.Text) * CInt(xUP)
            txtSubTotal.Text = Format(txtSubTotal.Text, "Standard")
        Catch err As Exception
            'MsgBox(err.ToString)
        End Try
    End Sub

    ''BARCODE NUMBER
    Private Sub txtBarcodeNumber_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcodeNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                db.Open()
                tblStocks = New OleDb.OleDbDataAdapter("SELECT * FROM tblStocks WHERE [BARCODE] like '" & txtBarcodeNumber.Text.Trim & "' ", db)
                dbds = New DataSet()
                tblStocks.Fill(dbds, "tblStocks")

                If dbds.Tables("tblStocks").Rows.Count > 0 Then
                    xUP = dbds.Tables("tblStocks").Rows(0).Item("SELLING PRICE")
                    txtTotal.Text = Format(xUP, "Standard")
                    xDesc = dbds.Tables("tblStocks").Rows(0).Item("DESCRIPTION")
                    tblCashier = New OleDb.OleDbDataAdapter("SELECT * FROM tblCashier WHERE [BARCODE] like '" & txtBarcodeNumber.Text.Trim & "'", db)
                    dbdstemp = New DataSet()
                    tblCashier.Fill(dbdstemp, "tblCashier")

                    If dbdstemp.Tables("tblCashier").Rows.Count > 0 Then
                        If MsgBox("You have already selected this item. Would you like to add more to your cart?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            xtempq = dbdstemp.Tables("tblCashier").Rows(0).Item("QUANTITY")
                            xGTotal = dbdstemp.Tables("tblCashier").Rows(0).Item("TOTAL")
                            txtQuantity.Focus()
                            sw = False
                        Else
                            txtBarcodeNumber.Clear()
                            txtTotal.Text = ""
                            Exit Sub
                        End If
                    Else
                        sw = True
                        txtQuantity.Focus()
                    End If

                    If dbds.Tables("tblStocks").Rows(0).Item("QUANTITY") <= 10 And dbds.Tables("tblStocks").Rows(0).Item("QUANTITY") > 0 Then
                        MsgBox("Warning: The inventory is running out, and we have limited quantities left in stock!", MsgBoxStyle.Critical, "WARNING")
                    ElseIf dbds.Tables("tblStocks").Rows(0).Item("QUANTITY") <= 0 Then
                        MsgBox("Warning: We apologize, but the item is currently unavailable for order.", MsgBoxStyle.Critical, "WARNING")
                        txtBarcodeNumber.Clear()
                        txtQuantity.Clear()
                        txtTotal.Clear()
                        txtBarcodeNumber.Focus()
                    End If

                Else
                    MsgBox("We couldn't find any items matching the given stock number. Please ensure it is correct and try again", MsgBoxStyle.Information, "WARNING")
                    txtBarcodeNumber.Clear()
                    txtBarcodeNumber.Focus()
                End If
            Catch err As Exception
                ''MsgBox(err.ToString)
            Finally
                db.Close()
            End Try
        End If

        ''F12 - LOG OUT
        If e.KeyCode = Keys.F12 Then
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

        ''F1 - PAY
        If e.KeyCode = Keys.F1 Then
            gbPay.Visible = True
            txtAmount.Focus()
        End If

        ''ESC - EXIT
        If e.KeyCode = Keys.Escape Then
            gbPay.Visible = False
            gbtrans.Visible = True
            txtBarcodeNumber.Focus()
            opendbCashier()
            sqlqueryCashier()
            db.Open()
            dbcmd = New OleDb.OleDbCommand("delete * from tblCashier", db)
            dbcmd.ExecuteNonQuery()
            dgCashier.DataSource = dbdstemp.Tables("tblCashier")
            xGTotal = 0
            txtTotal.Text = ""
            txtSubTotal.Text = ""
            txtAmount.Clear()
            txtChange.Text = ""
            db.Close()
            Exit Sub
        End If
    End Sub

  
        ''NEW
    Private Sub txtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyDown

        If e.KeyCode = Keys.Enter Then

            If CSng(txtAmount.Text) < CSng(txtTotal.Text) Then
                MsgBox("Oh no, you don't have enough money to complete this purchase!", MsgBoxStyle.Information, "Warning")
                txtAmount.Text = ""
                Exit Sub
            End If

            txtChange.Text = CSng(txtAmount.Text) - CSng(txtTotal.Text)
            txtAmount.Text = Format(txtAmount.Text, "Standard")
            txtChange.Text = Format(txtChange.Text, "Standard")


            tblCashier = New OleDb.OleDbDataAdapter("SELECT * FROM tblCashier", db)
            dbdstemp = New DataSet()
            tblCashier.Fill(dbdstemp, "tblCashier")
            trec = dbdstemp.Tables("tblCashier").Rows.Count - 1
            recpointer = 0

            'db.Open()

            For recpointer = 0 To trec
                xDesc = dbdstemp.Tables("tblCashier").Rows(recpointer).Item("DESCRIPTION")
                xUP = dbdstemp.Tables("tblCashier").Rows(recpointer).Item("UNIT PRICE")
                xqty = dbdstemp.Tables("tblCashier").Rows(recpointer).Item("QUANTITY")
                xsn = dbdstemp.Tables("tblCashier").Rows(recpointer).Item("BARCODE")
                xtotal = dbdstemp.Tables("tblCashier").Rows(recpointer).Item("TOTAL")
                xtime = Format(Now, "hh:mm")

                'opendbstocks()
                db.Open()
                xsn2 = dbdstemp.Tables("tblCashier").Rows(recpointer).Item("BARCODE")
                tblStocks = New OleDb.OleDbDataAdapter("SELECT * FROM tblStocks WHERE [BARCODE] like '" & xsn2 & "'", db)
                dbds2 = New DataSet()
                tblStocks.Fill(dbds2, "tblStocks")

                stocksqty = dbds2.Tables("tblStocks").Rows(0).Item("QUANTITY")
                stocksqty2 = stocksqty - xqty
                ' db.Open()
                dbcmd = New OleDb.OleDbCommand("UPDATE tblStocks set [QUANTITY] = '" & stocksqty2 & "' WHERE [BARCODE] like '" & xsn2 & "'", db)
                dbcmd.ExecuteNonQuery()

                'sqlquerystocks()
                db.Close()

            Next
            ''EDITED
            For Each row As DataGridViewRow In dgCashier.Rows
                opendbCashier()
                Try

                    dbcmd = New OleDb.OleDbCommand("INSERT INTO tblTransaction VALUES ([INVOICE],[BARCODE],[DESCRIPTION],[QUANTITY],[UNIT PRICE],[TOTAL],[DATE TRANSACTION],[TIME TRANSACTION], [CASHIER NAME])", db)

                    dbcmd.Parameters.AddWithValue("[INVOICE]", txtTransactionNumber.Text)
                    dbcmd.Parameters.AddWithValue("[BARCODE]", row.Cells("BARCODE").Value)
                    dbcmd.Parameters.AddWithValue("[DESCRIPTION]", row.Cells("DESCRIPTION").Value)
                    dbcmd.Parameters.AddWithValue("[QUANTITY]", row.Cells("QUANTITY").Value)
                    dbcmd.Parameters.AddWithValue("[UNIT PRICE]", row.Cells("UNIT PRICE").Value)
                    dbcmd.Parameters.AddWithValue("[TOTAL]", row.Cells("TOTAL").Value)
                    dbcmd.Parameters.AddWithValue("[DATE TRANSACTION]", lblCurrentDate.Text)
                    dbcmd.Parameters.AddWithValue("[TIME TRANSACTION]", lblCurrentTime.Text)
                    dbcmd.Parameters.AddWithValue("[CASHIER NAME]", lblCashier.Text)

                    db.Open()
                    dbcmd.ExecuteNonQuery()
                    sqlqueryCashier()
                    'GenerateReceipt()

                Catch err As Exception
                    'MsgBox(err.ToString)
                End Try

                db.Close()
            Next
            MsgBox("Fizz-tastic transaction! Press ESC to begin a new transaction.", MsgBoxStyle.Information, "Transaction")
        End If

        ''ESCAPE
        If e.KeyCode = Keys.Escape Then
            gbPay.Visible = False
            gbtrans.Visible = True
            txtBarcodeNumber.Focus()
            opendbCashier()
            sqlqueryCashier()
            db.Open()
            dbcmd = New OleDb.OleDbCommand("delete * from tblCashier", db)
            dbcmd.ExecuteNonQuery()
            dgCashier.DataSource = dbdstemp.Tables("tblCashier")
            xGTotal = 0
            txtTotal.Text = ""
            txtSubTotal.Text = ""
            txtAmount.Clear()
            txtChange.Text = ""
            Exit Sub
        End If
    End Sub

End Class