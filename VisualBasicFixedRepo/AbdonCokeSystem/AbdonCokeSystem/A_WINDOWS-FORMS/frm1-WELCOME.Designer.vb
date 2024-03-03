<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1WELCOME
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1WELCOME))
        Me.lbl1001 = New System.Windows.Forms.Label()
        Me.lbl1002 = New System.Windows.Forms.Label()
        Me.lbl1003 = New System.Windows.Forms.Label()
        Me.link1Fregister = New System.Windows.Forms.LinkLabel()
        Me.txtUN = New System.Windows.Forms.TextBox()
        Me.txtPASS = New System.Windows.Forms.TextBox()
        Me.btn1Flogin = New System.Windows.Forms.Button()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.picPass = New System.Windows.Forms.PictureBox()
        Me.pic1FMain = New System.Windows.Forms.PictureBox()
        Me.pic1Flogout = New System.Windows.Forms.PictureBox()
        Me.linkFORGOTPASS = New System.Windows.Forms.LinkLabel()
        Me.lblCurrentDateIN = New System.Windows.Forms.Label()
        Me.lblCurrentTimeIN = New System.Windows.Forms.Label()
        Me.TimerCashier = New System.Windows.Forms.Timer(Me.components)
        Me.picHidePass = New System.Windows.Forms.PictureBox()
        Me.picShowPass = New System.Windows.Forms.PictureBox()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1FMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1Flogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHidePass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShowPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1001
        '
        Me.lbl1001.AutoSize = True
        Me.lbl1001.BackColor = System.Drawing.Color.Transparent
        Me.lbl1001.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1001.Location = New System.Drawing.Point(401, 504)
        Me.lbl1001.Name = "lbl1001"
        Me.lbl1001.Size = New System.Drawing.Size(176, 31)
        Me.lbl1001.TabIndex = 0
        Me.lbl1001.Text = "USERNAME"
        '
        'lbl1002
        '
        Me.lbl1002.AutoSize = True
        Me.lbl1002.BackColor = System.Drawing.Color.Transparent
        Me.lbl1002.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1002.Location = New System.Drawing.Point(401, 577)
        Me.lbl1002.Name = "lbl1002"
        Me.lbl1002.Size = New System.Drawing.Size(180, 31)
        Me.lbl1002.TabIndex = 1
        Me.lbl1002.Text = "PASSWORD"
        '
        'lbl1003
        '
        Me.lbl1003.AutoSize = True
        Me.lbl1003.BackColor = System.Drawing.Color.Transparent
        Me.lbl1003.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1003.Location = New System.Drawing.Point(372, 645)
        Me.lbl1003.Name = "lbl1003"
        Me.lbl1003.Size = New System.Drawing.Size(243, 20)
        Me.lbl1003.TabIndex = 2
        Me.lbl1003.Text = "DON'T HAVE AN ACCOUNT?"
        '
        'link1Fregister
        '
        Me.link1Fregister.AutoSize = True
        Me.link1Fregister.BackColor = System.Drawing.Color.Transparent
        Me.link1Fregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link1Fregister.LinkColor = System.Drawing.Color.Maroon
        Me.link1Fregister.Location = New System.Drawing.Point(612, 648)
        Me.link1Fregister.Name = "link1Fregister"
        Me.link1Fregister.Size = New System.Drawing.Size(112, 15)
        Me.link1Fregister.TabIndex = 4
        Me.link1Fregister.TabStop = True
        Me.link1Fregister.Text = "REGISTER NOW"
        '
        'txtUN
        '
        Me.txtUN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUN.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUN.ForeColor = System.Drawing.Color.Maroon
        Me.txtUN.Location = New System.Drawing.Point(375, 538)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(349, 32)
        Me.txtUN.TabIndex = 1
        '
        'txtPASS
        '
        Me.txtPASS.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPASS.ForeColor = System.Drawing.Color.Maroon
        Me.txtPASS.Location = New System.Drawing.Point(375, 611)
        Me.txtPASS.Name = "txtPASS"
        Me.txtPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPASS.Size = New System.Drawing.Size(349, 32)
        Me.txtPASS.TabIndex = 2
        '
        'btn1Flogin
        '
        Me.btn1Flogin.Font = New System.Drawing.Font("Jokerman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1Flogin.ForeColor = System.Drawing.Color.White
        Me.btn1Flogin.Image = CType(resources.GetObject("btn1Flogin.Image"), System.Drawing.Image)
        Me.btn1Flogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn1Flogin.Location = New System.Drawing.Point(375, 670)
        Me.btn1Flogin.Name = "btn1Flogin"
        Me.btn1Flogin.Size = New System.Drawing.Size(349, 62)
        Me.btn1Flogin.TabIndex = 3
        Me.btn1Flogin.Text = "LOGIN"
        Me.btn1Flogin.UseVisualStyleBackColor = True
        '
        'picUser
        '
        Me.picUser.BackColor = System.Drawing.Color.Transparent
        Me.picUser.ErrorImage = CType(resources.GetObject("picUser.ErrorImage"), System.Drawing.Image)
        Me.picUser.Image = CType(resources.GetObject("picUser.Image"), System.Drawing.Image)
        Me.picUser.Location = New System.Drawing.Point(375, 500)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(31, 35)
        Me.picUser.TabIndex = 7
        Me.picUser.TabStop = False
        '
        'picPass
        '
        Me.picPass.BackColor = System.Drawing.Color.Transparent
        Me.picPass.ErrorImage = CType(resources.GetObject("picPass.ErrorImage"), System.Drawing.Image)
        Me.picPass.Image = CType(resources.GetObject("picPass.Image"), System.Drawing.Image)
        Me.picPass.Location = New System.Drawing.Point(375, 576)
        Me.picPass.Name = "picPass"
        Me.picPass.Size = New System.Drawing.Size(31, 35)
        Me.picPass.TabIndex = 8
        Me.picPass.TabStop = False
        '
        'pic1FMain
        '
        Me.pic1FMain.BackColor = System.Drawing.Color.Transparent
        Me.pic1FMain.ErrorImage = CType(resources.GetObject("pic1FMain.ErrorImage"), System.Drawing.Image)
        Me.pic1FMain.Image = CType(resources.GetObject("pic1FMain.Image"), System.Drawing.Image)
        Me.pic1FMain.Location = New System.Drawing.Point(-44, 218)
        Me.pic1FMain.Name = "pic1FMain"
        Me.pic1FMain.Size = New System.Drawing.Size(431, 514)
        Me.pic1FMain.TabIndex = 9
        Me.pic1FMain.TabStop = False
        '
        'pic1Flogout
        '
        Me.pic1Flogout.BackColor = System.Drawing.Color.Transparent
        Me.pic1Flogout.ErrorImage = CType(resources.GetObject("pic1Flogout.ErrorImage"), System.Drawing.Image)
        Me.pic1Flogout.Image = CType(resources.GetObject("pic1Flogout.Image"), System.Drawing.Image)
        Me.pic1Flogout.Location = New System.Drawing.Point(1022, 694)
        Me.pic1Flogout.Name = "pic1Flogout"
        Me.pic1Flogout.Size = New System.Drawing.Size(136, 158)
        Me.pic1Flogout.TabIndex = 10
        Me.pic1Flogout.TabStop = False
        '
        'linkFORGOTPASS
        '
        Me.linkFORGOTPASS.AutoSize = True
        Me.linkFORGOTPASS.BackColor = System.Drawing.Color.Transparent
        Me.linkFORGOTPASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkFORGOTPASS.LinkColor = System.Drawing.Color.Maroon
        Me.linkFORGOTPASS.Location = New System.Drawing.Point(430, 736)
        Me.linkFORGOTPASS.Name = "linkFORGOTPASS"
        Me.linkFORGOTPASS.Size = New System.Drawing.Size(242, 15)
        Me.linkFORGOTPASS.TabIndex = 5
        Me.linkFORGOTPASS.TabStop = True
        Me.linkFORGOTPASS.Text = "I HAVE FORGOTTEN MY PASSWORD"
        '
        'lblCurrentDateIN
        '
        Me.lblCurrentDateIN.AutoSize = True
        Me.lblCurrentDateIN.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentDateIN.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDateIN.ForeColor = System.Drawing.Color.Orange
        Me.lblCurrentDateIN.Location = New System.Drawing.Point(23, 94)
        Me.lblCurrentDateIN.Name = "lblCurrentDateIN"
        Me.lblCurrentDateIN.Size = New System.Drawing.Size(338, 42)
        Me.lblCurrentDateIN.TabIndex = 40
        Me.lblCurrentDateIN.Text = "CURRENT DATE"
        '
        'lblCurrentTimeIN
        '
        Me.lblCurrentTimeIN.AutoSize = True
        Me.lblCurrentTimeIN.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentTimeIN.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTimeIN.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblCurrentTimeIN.Location = New System.Drawing.Point(12, 9)
        Me.lblCurrentTimeIN.Name = "lblCurrentTimeIN"
        Me.lblCurrentTimeIN.Size = New System.Drawing.Size(560, 74)
        Me.lblCurrentTimeIN.TabIndex = 39
        Me.lblCurrentTimeIN.Text = "CURRENT TIME"
        '
        'TimerCashier
        '
        Me.TimerCashier.Interval = 1000
        '
        'picHidePass
        '
        Me.picHidePass.BackColor = System.Drawing.Color.Transparent
        Me.picHidePass.ErrorImage = CType(resources.GetObject("picHidePass.ErrorImage"), System.Drawing.Image)
        Me.picHidePass.Image = CType(resources.GetObject("picHidePass.Image"), System.Drawing.Image)
        Me.picHidePass.Location = New System.Drawing.Point(688, 616)
        Me.picHidePass.Name = "picHidePass"
        Me.picHidePass.Size = New System.Drawing.Size(30, 22)
        Me.picHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHidePass.TabIndex = 41
        Me.picHidePass.TabStop = False
        '
        'picShowPass
        '
        Me.picShowPass.BackColor = System.Drawing.Color.Transparent
        Me.picShowPass.ErrorImage = CType(resources.GetObject("picShowPass.ErrorImage"), System.Drawing.Image)
        Me.picShowPass.Image = CType(resources.GetObject("picShowPass.Image"), System.Drawing.Image)
        Me.picShowPass.Location = New System.Drawing.Point(688, 616)
        Me.picShowPass.Name = "picShowPass"
        Me.picShowPass.Size = New System.Drawing.Size(30, 22)
        Me.picShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShowPass.TabIndex = 42
        Me.picShowPass.TabStop = False
        '
        'frm1WELCOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1088, 760)
        Me.Controls.Add(Me.picShowPass)
        Me.Controls.Add(Me.picHidePass)
        Me.Controls.Add(Me.lblCurrentDateIN)
        Me.Controls.Add(Me.lblCurrentTimeIN)
        Me.Controls.Add(Me.linkFORGOTPASS)
        Me.Controls.Add(Me.picPass)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.btn1Flogin)
        Me.Controls.Add(Me.txtPASS)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.link1Fregister)
        Me.Controls.Add(Me.lbl1003)
        Me.Controls.Add(Me.lbl1002)
        Me.Controls.Add(Me.lbl1001)
        Me.Controls.Add(Me.pic1FMain)
        Me.Controls.Add(Me.pic1Flogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm1WELCOME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WELCOME"
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1FMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1Flogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHidePass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShowPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1001 As System.Windows.Forms.Label
    Friend WithEvents lbl1002 As System.Windows.Forms.Label
    Friend WithEvents lbl1003 As System.Windows.Forms.Label
    Friend WithEvents link1Fregister As System.Windows.Forms.LinkLabel
    Friend WithEvents txtUN As System.Windows.Forms.TextBox
    Friend WithEvents txtPASS As System.Windows.Forms.TextBox
    Friend WithEvents btn1Flogin As System.Windows.Forms.Button
    Friend WithEvents picUser As System.Windows.Forms.PictureBox
    Friend WithEvents picPass As System.Windows.Forms.PictureBox
    Friend WithEvents pic1FMain As System.Windows.Forms.PictureBox
    Friend WithEvents pic1Flogout As System.Windows.Forms.PictureBox
    Friend WithEvents linkFORGOTPASS As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCurrentDateIN As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTimeIN As System.Windows.Forms.Label
    Friend WithEvents TimerCashier As System.Windows.Forms.Timer
    Friend WithEvents picHidePass As System.Windows.Forms.PictureBox
    Friend WithEvents picShowPass As System.Windows.Forms.PictureBox

End Class
