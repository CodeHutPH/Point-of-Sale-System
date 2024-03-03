''IMPORTS
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Module connection


    Public db As New OleDbConnection

    ''TABLE CONNECTIONS
    Public tblUser As New OleDbDataAdapter
    Public tblStocks As New OleDbDataAdapter
    Public tblCashier As New OleDbDataAdapter
    Public tblLogin As New OleDbDataAdapter
    Public tblTransaction As New OleDbDataAdapter

    Public dbcmd As New OleDbCommand
    Public dbds As New DataSet
    Public dbds2 As New DataSet
    Public dbdstemp As New DataSet
    Public dbdstrans As New DataSet

    ''DECLARATIONS
    Public recpointer As Integer
    Public trec As Integer
    Public sw As Boolean

    Public uniqueID As String
    Public xpost As String
    Public xpriv As String
    Public xtry As Object
    Public Xname As String
    Public xGTotal As String
    Public xUP As String
    Public xDesc As String
    ''Public xIN As String
    Public xtempq As Integer
    Public xqty As Integer
    Public xsn As Integer
    Public xtotal As Single
    Public xtime As String
    Public xsn2 As Integer
    Public stocksqty As String
    Public stocksqty2 As String



    ''FOR USER REGISTRATION
    Sub opendb()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\dBase\secured.mdb")
            tblUser = New OleDb.OleDbDataAdapter("SELECT * FROM tblUser", db)
            dbds = New DataSet()
            tblUser.Fill(dbds, "tblUser")

            If dbds.Tables("tblUser").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblUser").Rows.Count) - 1
            End If

        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    ''FOR sqlQuery
    Sub sqlquery()
        Try
            tblUser = New OleDb.OleDbDataAdapter("SELECT [Employee ID], [Username], [Position], [Privilege] FROM tblUser", db)
            dbds = New DataSet()
            tblUser.Fill(dbds, "tblUser")

            If dbds.Tables("tblUser").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblUser").Rows.Count) - 1
            End If

        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub



    ''STOCKS REGISTRATION
    Sub opendbStocks()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\dBase\secured.mdb")
            tblStocks = New OleDb.OleDbDataAdapter("SELECT [BARCODE], [ITEM NAME],[DESCRIPTION],[QUANTITY], [BUYING PRICE], [SELLING PRICE], [CRITICAL] FROM tblStocks", db)
            dbds = New DataSet()
            tblStocks.Fill(dbds, "tblStocks")

            If dbds.Tables("tblStocks").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblStocks").Rows.Count) - 1
            End If

        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    ''FOR sqlQuery
    Sub sqlqueryStocks()
        Try
            tblStocks = New OleDb.OleDbDataAdapter("SELECT * FROM tblStocks", db)
            dbds = New DataSet()
            tblStocks.Fill(dbds, "tblStocks")

            If dbds.Tables("tblStocks").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblStocks").Rows.Count) - 1
            End If

        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub


    ''Cashier REGISTRATION
    Sub opendbCashier()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\dBase\secured.mdb")
            tblCashier = New OleDb.OleDbDataAdapter("SELECT * FROM tblCashier", db)
            dbdstemp = New DataSet()
            tblCashier.Fill(dbdstemp, "tblCashier")

            If dbdstemp.Tables("tblCashier").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbdstemp.Tables("tblCashier").Rows.Count) - 1
            End If

        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    ''FOR sqlQuery
    Sub sqlqueryCashier()
        Try
            tblCashier = New OleDb.OleDbDataAdapter("SELECT * FROM tblCashier", db)
            dbdstemp = New DataSet()
            tblCashier.Fill(dbdstemp, "tblCashier")

            If dbdstemp.Tables("tblCashier").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbdstemp.Tables("tblCashier").Rows.Count) - 1
            End If

        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub




    ''LOGIN RECORD
    Sub opendbLogin()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\dBase\secured.mdb")
            tblLogin = New OleDb.OleDbDataAdapter("SELECT * FROM tblLogin", db)
            dbds = New DataSet()
            tblLogin.Fill(dbds, "tblLogin")

            If dbds.Tables("tblLogin").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblLogin").Rows.Count) - 1
            End If

        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    ''FOR sqlQuery
    Sub sqlqueryLogin()
        Try
            tblLogin = New OleDb.OleDbDataAdapter("SELECT * FROM tblLogin", db)
            dbds = New DataSet()
            tblLogin.Fill(dbds, "tblLogin")

            If dbds.Tables("tblLogin").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblLogin").Rows.Count) - 1
            End If

        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    ''TRANSACTION HISTORY
    Sub opendbTransaction()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\dBase\secured.mdb")
            tblTransaction = New OleDb.OleDbDataAdapter("SELECT * FROM tblTransaction", db)
            dbdstrans = New DataSet()
            tblTransaction.Fill(dbdstrans, "tblTransaction")

            If dbdstrans.Tables("tblTransaction").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbdstrans.Tables("tblTransaction").Rows.Count) - 1
            End If

        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    ''FOR sqlQuery
    Sub sqlqueryTransaction()
        Try
            tblTransaction = New OleDb.OleDbDataAdapter("SELECT * FROM tblTransaction", db)
            dbdstrans = New DataSet()
            tblTransaction.Fill(dbdstrans, "tblTransaction")

            If dbdstrans.Tables("tblTransaction").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbdstrans.Tables("tblTransaction").Rows.Count) - 1
            End If

        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub
End Module