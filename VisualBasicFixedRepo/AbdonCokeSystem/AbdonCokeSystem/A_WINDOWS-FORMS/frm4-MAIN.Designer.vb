<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm4MAIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm4MAIN))
        Me.btnMAINuser = New System.Windows.Forms.Button()
        Me.btnMAINstocks = New System.Windows.Forms.Button()
        Me.btnMAINcashier = New System.Windows.Forms.Button()
        Me.btnMAINreports = New System.Windows.Forms.Button()
        Me.pic4Flogout = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMainName = New System.Windows.Forms.Label()
        Me.lblMainPosition = New System.Windows.Forms.Label()
        Me.lblCurrentTimeOUT = New System.Windows.Forms.Label()
        Me.lblCurrentDateOUT = New System.Windows.Forms.Label()
        Me.TimerCashier = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.pic4Flogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMAINuser
        '
        Me.btnMAINuser.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMAINuser.BackgroundImage = CType(resources.GetObject("btnMAINuser.BackgroundImage"), System.Drawing.Image)
        Me.btnMAINuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMAINuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMAINuser.ForeColor = System.Drawing.Color.White
        Me.btnMAINuser.Location = New System.Drawing.Point(302, 335)
        Me.btnMAINuser.Name = "btnMAINuser"
        Me.btnMAINuser.Size = New System.Drawing.Size(305, 326)
        Me.btnMAINuser.TabIndex = 0
        Me.btnMAINuser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMAINuser.UseVisualStyleBackColor = False
        '
        'btnMAINstocks
        '
        Me.btnMAINstocks.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMAINstocks.BackgroundImage = CType(resources.GetObject("btnMAINstocks.BackgroundImage"), System.Drawing.Image)
        Me.btnMAINstocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMAINstocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMAINstocks.Location = New System.Drawing.Point(640, 335)
        Me.btnMAINstocks.Name = "btnMAINstocks"
        Me.btnMAINstocks.Size = New System.Drawing.Size(305, 326)
        Me.btnMAINstocks.TabIndex = 1
        Me.btnMAINstocks.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMAINstocks.UseVisualStyleBackColor = False
        '
        'btnMAINcashier
        '
        Me.btnMAINcashier.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMAINcashier.BackgroundImage = CType(resources.GetObject("btnMAINcashier.BackgroundImage"), System.Drawing.Image)
        Me.btnMAINcashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMAINcashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMAINcashier.Location = New System.Drawing.Point(975, 335)
        Me.btnMAINcashier.Name = "btnMAINcashier"
        Me.btnMAINcashier.Size = New System.Drawing.Size(305, 324)
        Me.btnMAINcashier.TabIndex = 2
        Me.btnMAINcashier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMAINcashier.UseVisualStyleBackColor = False
        '
        'btnMAINreports
        '
        Me.btnMAINreports.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMAINreports.BackgroundImage = CType(resources.GetObject("btnMAINreports.BackgroundImage"), System.Drawing.Image)
        Me.btnMAINreports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMAINreports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMAINreports.Location = New System.Drawing.Point(1308, 335)
        Me.btnMAINreports.Name = "btnMAINreports"
        Me.btnMAINreports.Size = New System.Drawing.Size(305, 326)
        Me.btnMAINreports.TabIndex = 3
        Me.btnMAINreports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMAINreports.UseVisualStyleBackColor = False
        '
        'pic4Flogout
        '
        Me.pic4Flogout.BackColor = System.Drawing.Color.Transparent
        Me.pic4Flogout.ErrorImage = CType(resources.GetObject("pic4Flogout.ErrorImage"), System.Drawing.Image)
        Me.pic4Flogout.Image = CType(resources.GetObject("pic4Flogout.Image"), System.Drawing.Image)
        Me.pic4Flogout.Location = New System.Drawing.Point(1842, 968)
        Me.pic4Flogout.Name = "pic4Flogout"
        Me.pic4Flogout.Size = New System.Drawing.Size(67, 70)
        Me.pic4Flogout.TabIndex = 11
        Me.pic4Flogout.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(274, 664)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 55)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "EMPLOYEES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label2.Location = New System.Drawing.Point(658, 664)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 55)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "STOCKER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label3.Location = New System.Drawing.Point(1001, 662)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 55)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "CASHIER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label4.Location = New System.Drawing.Point(1334, 662)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 55)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "REPORTS"
        '
        'lblMainName
        '
        Me.lblMainName.AutoSize = True
        Me.lblMainName.BackColor = System.Drawing.Color.Transparent
        Me.lblMainName.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainName.ForeColor = System.Drawing.Color.Crimson
        Me.lblMainName.Location = New System.Drawing.Point(597, 9)
        Me.lblMainName.Name = "lblMainName"
        Me.lblMainName.Size = New System.Drawing.Size(239, 74)
        Me.lblMainName.TabIndex = 16
        Me.lblMainName.Text = "NAME"
        '
        'lblMainPosition
        '
        Me.lblMainPosition.AutoSize = True
        Me.lblMainPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblMainPosition.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainPosition.ForeColor = System.Drawing.Color.Crimson
        Me.lblMainPosition.Location = New System.Drawing.Point(409, 91)
        Me.lblMainPosition.Name = "lblMainPosition"
        Me.lblMainPosition.Size = New System.Drawing.Size(367, 74)
        Me.lblMainPosition.TabIndex = 17
        Me.lblMainPosition.Text = "POSITION"
        '
        'lblCurrentTimeOUT
        '
        Me.lblCurrentTimeOUT.AutoSize = True
        Me.lblCurrentTimeOUT.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentTimeOUT.Font = New System.Drawing.Font("Cooper Black", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTimeOUT.ForeColor = System.Drawing.Color.Snow
        Me.lblCurrentTimeOUT.Location = New System.Drawing.Point(1210, -5)
        Me.lblCurrentTimeOUT.Name = "lblCurrentTimeOUT"
        Me.lblCurrentTimeOUT.Size = New System.Drawing.Size(699, 91)
        Me.lblCurrentTimeOUT.TabIndex = 37
        Me.lblCurrentTimeOUT.Text = "CURRENT TIME"
        '
        'lblCurrentDateOUT
        '
        Me.lblCurrentDateOUT.AutoSize = True
        Me.lblCurrentDateOUT.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentDateOUT.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDateOUT.ForeColor = System.Drawing.Color.Crimson
        Me.lblCurrentDateOUT.Location = New System.Drawing.Point(1216, 86)
        Me.lblCurrentDateOUT.Name = "lblCurrentDateOUT"
        Me.lblCurrentDateOUT.Size = New System.Drawing.Size(437, 55)
        Me.lblCurrentDateOUT.TabIndex = 38
        Me.lblCurrentDateOUT.Text = "CURRENT DATE"
        '
        'TimerCashier
        '
        Me.TimerCashier.Interval = 1000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(7, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(595, 74)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "WELCOME BACK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(24, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(398, 74)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "OUR DEAR"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(975, -27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(629, 878)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(416, 74)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "TASTE THE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Candara Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(1036, 874)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(261, 78)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "FEELING"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1292, 780)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 258)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'frm4MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1909, 1041)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCurrentDateOUT)
        Me.Controls.Add(Me.lblCurrentTimeOUT)
        Me.Controls.Add(Me.btnMAINuser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMainPosition)
        Me.Controls.Add(Me.lblMainName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMAINcashier)
        Me.Controls.Add(Me.pic4Flogout)
        Me.Controls.Add(Me.btnMAINreports)
        Me.Controls.Add(Me.btnMAINstocks)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm4MAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pic4Flogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMAINuser As System.Windows.Forms.Button
    Friend WithEvents btnMAINstocks As System.Windows.Forms.Button
    Friend WithEvents btnMAINcashier As System.Windows.Forms.Button
    Friend WithEvents btnMAINreports As System.Windows.Forms.Button
    Friend WithEvents pic4Flogout As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMainName As System.Windows.Forms.Label
    Friend WithEvents lblMainPosition As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTimeOUT As System.Windows.Forms.Label
    Friend WithEvents lblCurrentDateOUT As System.Windows.Forms.Label
    Friend WithEvents TimerCashier As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
