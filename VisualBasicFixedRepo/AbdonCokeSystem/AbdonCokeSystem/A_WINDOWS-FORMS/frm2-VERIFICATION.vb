Public Class frm2VERIFICATION

    ' FORMLOAD
    Private Sub frm2VERIFICATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt2FVerified.Focus()
    End Sub

    ' FOR PROCEED
    Private Sub btn2Fproceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2Fproceed.Click
        If txt2FVerified.Text = "JUMBOHOTDOG" Then
            MsgBox("Welcome to COCA-COLA company! Kindly click LOGIN once you have been given the temporary ADMIN account.")
            ''frm3REGISTRATION.Show()
            frm1WELCOME.Show()
            frm1WELCOME.txtUN.Text = "ADMIN"
            frm1WELCOME.txtPASS.Text = "admin"
            Me.Close()
        Else
            MsgBox("You have entered an incorrect code. Kindly ask the admin again.")
        End If
    End Sub

    ' FOR DIRECT ENTER-PROCEED
    Private Sub txt2FVerified_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt2FVerified.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt2FVerified.Text = "JUMBOHOTDOG" Then
                MsgBox("Welcome to COCA-COLA company! Kindly click LOGIN once you have been given the temporary ADMIN account.")
                ''frm3REGISTRATION.Show()
                frm1WELCOME.Show()
                frm1WELCOME.txtUN.Text = "ADMIN"
                frm1WELCOME.txtPASS.Text = "admin"
                Me.Close()
            Else
                MsgBox("You have entered an incorrect code. Kindly ask the admin again.")
            End If
        End If
    End Sub

    ' FOR RESET
    Private Sub btn2Freset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2Freset.Click
        txt2FVerified.Text = ""
        txt2FVerified.Focus()
    End Sub

    ' FOR EXIT
    Private Sub btn2Fexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2Fexit.Click
        MsgBox("You will be redirected to the log in page.")
        frm1WELCOME.Show()
        Me.Close()
    End Sub

End Class
