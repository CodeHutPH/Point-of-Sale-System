Public Class frm1WELCOME


    ''FORMLOAD
    Private Sub frm1WELCOME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUN.Focus()
        opendbLogin()
        sqlqueryLogin()

        ''TIMER
        TimerCashier.Enabled = True
        TimerCashier.Interval = 1000 ' Set the timer interval to 1 second (1000 milliseconds)
        lblCurrentTimeIN.Text = Date.Now.ToString("hh:mm:ss tt")
        AddHandler TimerCashier.Tick, AddressOf TimerCashier_Tick ' Assign the event handler
        lblCurrentDateIN.Text = Date.Now.ToString("dddd - dd - MMMM - yyyy")
        xGTotal = 0

        ''HOVER
        btn1Flogin.Cursor = Cursors.Hand
        pic1Flogout.Cursor = Cursors.Hand
        picShowPass.Cursor = Cursors.Hand
        picHidePass.Cursor = Cursors.Hand

        picShowPass.Visible = False
    End Sub

    ''TIMER
    Private Sub TimerCashier_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TimerCashier.Enabled = True
        lblCurrentTimeIN.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblCurrentDateIN.Text = Date.Now.ToString("dddd - dd - MMMM - yyyy")
    End Sub

    ''FOR LOGIN
    Private Sub btn1Flogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1Flogin.Click


        opendb()
        tblUser = New OleDb.OleDbDataAdapter("SELECT * FROM tblUser WHERE [Username] like '" & txtUN.Text & "' and [Password] like '" & txtPASS.Text & "'", db)
        dbds = New DataSet()
        tblUser.Fill(dbds, "tblUser")
        trec = dbds.Tables("tblUser").Rows.Count

        If trec > 0 Then
            Xname = txtUN.Text
            xpost = dbds.Tables("tblUser").Rows(0).Item("Position")
            xpriv = dbds.Tables("tblUser").Rows(0).Item("Privilege")
            Me.Visible = False

            txtUN.Clear()
            txtPASS.Clear()
            frm4MAIN.Show()

            ' Insert login information into tblLogin
            db.Open()
            dbcmd = New OleDb.OleDbCommand("INSERT INTO tblLogin([Username IN], [Position IN], [Privilege IN], [Time Login], [Date Login]) VALUES ('" & Xname & "', '" & xpost & "', '" & xpriv & "', '" & lblCurrentTimeIN.Text.Trim & "', '" & lblCurrentDateIN.Text.Trim & "')", db)
            dbcmd.ExecuteNonQuery()
            db.Close()

        Else
            MsgBox("ALERT: The system will close after 3 unsuccessful login attempts. Please ensure that your login credentials are correct before attempting to log in again.", MsgBoxStyle.Critical)

            xtry = xtry + 1

            If xtry = 3 Then
                Me.Hide()
            End If

            txtUN.Clear()
            txtPASS.Clear()
            txtUN.Focus()
        End If
    End Sub

    ''FOR DIRECT ENTER-LOGIN
    Private Sub txtPASS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPASS.KeyDown
       
        If e.KeyCode = Keys.Enter Then
            opendb()
            tblUser = New OleDb.OleDbDataAdapter("SELECT * FROM tblUser WHERE [Username] like '" & txtUN.Text & "' and [Password] like '" & txtPASS.Text & "'", db)
            dbds = New DataSet()
            tblUser.Fill(dbds, "tblUser")
            trec = dbds.Tables("tblUser").Rows.Count

            If trec > 0 Then
                Xname = txtUN.Text
                xpost = dbds.Tables("tblUser").Rows(0).Item("Position")
                xpriv = dbds.Tables("tblUser").Rows(0).Item("Privilege")
                Me.Visible = False

                txtUN.Clear()
                txtPASS.Clear()
                frm4MAIN.Show()

                ' Insert login information into tblLogin
                db.Open()
                dbcmd = New OleDb.OleDbCommand("INSERT INTO tblLogin([Username IN], [Position IN], [Privilege IN], [Time Login], [Date Login]) VALUES ('" & Xname & "', '" & xpost & "', '" & xpriv & "', '" & lblCurrentTimeIN.Text.Trim & "', '" & lblCurrentDateIN.Text.Trim & "')", db)
                dbcmd.ExecuteNonQuery()
                db.Close()
            Else
                MsgBox("Password doesn't match your username. After three incorrect attempts, the system will shut down.", MsgBoxStyle.Critical)

                xtry = xtry + 1

                If xtry = 3 Then
                    Me.Close()
                End If

                txtUN.Clear()
                txtPASS.Clear()
                txtUN.Focus()
            End If
        End If
    End Sub

    ''FOR REGISTER NOW (VERIFICATION)
    Private Sub link1Fregister_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link1Fregister.LinkClicked
        frm2VERIFICATION.Show()
        Me.Hide()
    End Sub

    ''FOR FORGOT PASSWORD (VERIFICATION)
    Private Sub linkFORGOTPASS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFORGOTPASS.LinkClicked
        frm2VERIFICATION.Show()
        Me.Hide()
    End Sub

    ''FOR LOGOUT
    Private Sub pic1Flogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic1Flogout.Click
        ''Display a MessageBox asking the user if they want to close the window
        If MsgBox("Are you sure you want to close this window? This action will result in closing the Coca-Cola POS System, ending your refreshing experience. Stay bubbly and continue serving happiness!", MsgBoxStyle.Critical + vbYesNo, "Exit") = vbYes Then

            ''PASTE HERE
            ' Fade out the form gradually
            Dim counter As Integer
            For counter = 90 To 10 Step -20
                Me.Opacity = counter / 100
                Me.Refresh()
                Threading.Thread.Sleep(5)
            Next counter

            ''Close the form
            Me.Close()
        Else
            ''Keep focus on the form if "No" is selected
            Me.Focus()
        End If
    End Sub

    ''ESC-LOGOUT
    Private Sub frm1WELCOME_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure you want to close this window? This action will result in closing the Coca-Cola POS System, ending your refreshing experience. Stay bubbly and continue serving happiness!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
                Dim counter As Integer
                For counter = 90 To 10 Step -20
                    Me.Opacity = counter / 100
                    Me.Refresh()
                    Threading.Thread.Sleep(5)
                Next counter

                ' Close the form
                Me.Close()
            Else
                ' Keep focus on the form if "No" is selected
                Me.Focus()
            End If
        End If
    End Sub

    Private Sub picHidePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHidePass.Click
        If txtPASS.PasswordChar = "*" Then
            ' Show the password
            txtPASS.PasswordChar = Char.MinValue
            picHidePass.Visible = False
            picShowPass.Visible = True
        Else
            ' Hide the password
            txtPASS.PasswordChar = "*" ' You can choose any character to represent the password
            ''  picShowPass.Visible = True
        End If
    End Sub

    Private Sub picShowPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShowPass.Click

        If txtPASS.PasswordChar = "*" Then
            '' picHidePass.Visible = True
            ' Show the password
            txtPASS.PasswordChar = Char.MinValue
        Else
            ' Hide the password
            txtPASS.PasswordChar = "*" ' You can choose any character to represent the password
            '' picShowPass.Visible = True
            picHidePass.Visible = True
            picShowPass.Visible = False
        End If
    End Sub
End Class
