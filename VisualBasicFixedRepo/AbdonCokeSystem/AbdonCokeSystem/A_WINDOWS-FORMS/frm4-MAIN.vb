Public Class frm4MAIN


    ''------------------------------------------------------------------------------------------------------------------------
    ''FORM LOAD PRIVILEGE
    ''------------------------------------------------------------------------------------------------------------------------
    Private Sub frm4MAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xpriv As String = dbds.Tables("tblUser").Rows(0).Item("Privilege")
        Dim xpost As String = dbds.Tables("tblUser").Rows(0).Item("Position")

        If xpriv = "ADMIN" Then
            ' Admin has access to all buttons
            btnMAINuser.Enabled = True
            btnMAINstocks.Enabled = True
            btnMAINcashier.Enabled = True
            btnMAINreports.Enabled = True
        ElseIf xpost = "MANAGER" Then
            ' Manager has access to all buttons
            btnMAINuser.Enabled = True
            btnMAINstocks.Enabled = True
            btnMAINcashier.Enabled = True
            btnMAINreports.Enabled = True
        ElseIf xpost = "CASHIER" Then
            ' Cashier only has access to btnMAINcashier
            btnMAINcashier.Enabled = True
            btnMAINuser.Enabled = False
            btnMAINstocks.Enabled = False
            btnMAINreports.Enabled = False
        ElseIf xpost = "STOCKER" Then
            ' Stocks personnel only has access to btnMAINstocks
            btnMAINstocks.Enabled = True
            btnMAINuser.Enabled = False
            btnMAINcashier.Enabled = False
            btnMAINreports.Enabled = False
        ElseIf xpost = "HR MANAGER" Then
            ' HR personnel only has access to btnMAINuser
            btnMAINstocks.Enabled = False
            btnMAINuser.Enabled = True
            btnMAINcashier.Enabled = False
            btnMAINreports.Enabled = False
        End If

        ''LOGGED IN 
        lblMainName.Text = Xname
        lblMainPosition.Text = xpost

        ''TIMER
        TimerCashier.Enabled = True
        TimerCashier.Interval = 1000 ' Set the timer interval to 1 second (1000 milliseconds)
        lblCurrentTimeOUT.Text = Date.Now.ToString("hh : mm : ss tt")
        AddHandler TimerCashier.Tick, AddressOf TimerCashier_Tick ' Assign the event handler
        lblCurrentDateOUT.Text = Date.Now.ToString("dddd - dd - MMMM - yyyy")
        xGTotal = 0

        ''HOVER
        btnMAINuser.Cursor = Cursors.Hand
        btnMAINstocks.Cursor = Cursors.Hand
        btnMAINcashier.Cursor = Cursors.Hand
        btnMAINreports.Cursor = Cursors.Hand
        pic4Flogout.Cursor = Cursors.Hand
    End Sub

    ''TIMER
    Private Sub TimerCashier_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TimerCashier.Enabled = True
        lblCurrentTimeOUT.Text = DateTime.Now.ToString("hh : mm : ss tt")
        lblCurrentDateOUT.Text = Date.Now.ToString("dddd - dd - MMMM - yyyy")
    End Sub

    ''-------------------------------------------------------------------------------------------------------------
    ''SHOW ALL FORMS
    ''-------------------------------------------------------------------------------------------------------------

    ''USER
    Private Sub btnMAINuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMAINuser.Click
        frm3REGISTRATION.Show()
        Me.Hide()
    End Sub

    ''STOCKS
    Private Sub btnMAINstocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMAINstocks.Click
        frm5STOCKS.Show()
        Me.Hide()
    End Sub

    ''CASHIER
    Private Sub btnMAINcashier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMAINcashier.Click
        frm6CASHIER.Show()
        Me.Hide()
    End Sub

    ''REPORTS
    Private Sub btnMAINreports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMAINreports.Click
        frm7REPORTS.Show()
        Me.Hide()
    End Sub

    ''-------------------------------------------------------------------------------------------------------------
    ''SHOW ALL FORMS
    ''-------------------------------------------------------------------------------------------------------------

    ''FOR EXIT
    Private Sub pic4Flogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic4Flogout.Click

        ' Update logout information in tblLogin
        db.Open()
        dbcmd = New OleDb.OleDbCommand("UPDATE tblLogin SET [Time Logout] = '" & lblCurrentTimeOUT.Text.Trim & "', [Date Logout] = '" & lblCurrentDateOUT.Text.Trim & "' WHERE [Username IN] = '" & Xname & "' AND [Time Logout] IS NULL AND [Date Logout] IS NULL", db)
        dbcmd.ExecuteNonQuery()
        db.Close()



        ''Display a MessageBox asking the user if they want to close the window
        If MsgBox("Are you sure you want to close the main window? You will be redirected to the login page. Session will be logged out.", MsgBoxStyle.Critical + vbYesNo, "Exit") = vbYes Then
            ''Close the form
            Me.Close()
            frm1WELCOME.Show()
            ''Focus on username
            frm1WELCOME.txtUN.Focus()
        Else
            ''Keep focus on the form if "No" is selected
            Me.Focus()
        End If
    End Sub

    ''ESC - LOG OUT
    Private Sub frm4MAIN_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown

            If e.KeyCode = Keys.Escape Then
                ' Update logout information in tblLogin
            db.Open()
                dbcmd = New OleDb.OleDbCommand("UPDATE tblLogin SET [Time Logout] = '" & lblCurrentTimeOUT.Text.Trim & "', [Date Logout] = '" & lblCurrentDateOUT.Text.Trim & "' WHERE [Username IN] = '" & Xname & "' AND [Time Logout] IS NULL AND [Date Logout] IS NULL", db)
                dbcmd.ExecuteNonQuery()
            db.Close()

                ''Display a MessageBox asking the user if they want to close the window
                If MsgBox("Are you sure you want to close the main window? You will be redirected to the login page. Session will be logged out.", MsgBoxStyle.Critical + vbYesNo, "Exit") = vbYes Then



                    ''Close the form
                    frm1WELCOME.Show()
                    Me.Close()
                    ''Focus on username
                    frm1WELCOME.txtUN.Focus()

                Else
                    ''Keep focus on the form if "No" is selected
                    Me.Focus()
                End If
            End If
    End Sub

End Class
