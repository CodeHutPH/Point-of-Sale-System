<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2VERIFICATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm2VERIFICATION))
        Me.lbl2002 = New System.Windows.Forms.Label()
        Me.txt2FVerified = New System.Windows.Forms.TextBox()
        Me.lbl2003 = New System.Windows.Forms.Label()
        Me.btn2Fproceed = New System.Windows.Forms.Button()
        Me.btn2Fexit = New System.Windows.Forms.Button()
        Me.lbl2001 = New System.Windows.Forms.GroupBox()
        Me.btn2Freset = New System.Windows.Forms.Button()
        Me.lbl2001.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl2002
        '
        Me.lbl2002.AutoSize = True
        Me.lbl2002.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2002.ForeColor = System.Drawing.Color.Red
        Me.lbl2002.Location = New System.Drawing.Point(65, 60)
        Me.lbl2002.Name = "lbl2002"
        Me.lbl2002.Size = New System.Drawing.Size(216, 24)
        Me.lbl2002.TabIndex = 0
        Me.lbl2002.Text = "VERIFICATION CODE"
        '
        'txt2FVerified
        '
        Me.txt2FVerified.BackColor = System.Drawing.Color.White
        Me.txt2FVerified.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt2FVerified.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2FVerified.ForeColor = System.Drawing.Color.Red
        Me.txt2FVerified.Location = New System.Drawing.Point(14, 88)
        Me.txt2FVerified.Name = "txt2FVerified"
        Me.txt2FVerified.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt2FVerified.Size = New System.Drawing.Size(321, 29)
        Me.txt2FVerified.TabIndex = 1
        '
        'lbl2003
        '
        Me.lbl2003.AutoSize = True
        Me.lbl2003.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2003.Location = New System.Drawing.Point(27, 121)
        Me.lbl2003.Name = "lbl2003"
        Me.lbl2003.Size = New System.Drawing.Size(262, 16)
        Me.lbl2003.TabIndex = 2
        Me.lbl2003.Text = "Get the verification code from ADMIN"
        '
        'btn2Fproceed
        '
        Me.btn2Fproceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2Fproceed.ForeColor = System.Drawing.Color.White
        Me.btn2Fproceed.Image = CType(resources.GetObject("btn2Fproceed.Image"), System.Drawing.Image)
        Me.btn2Fproceed.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn2Fproceed.Location = New System.Drawing.Point(30, 158)
        Me.btn2Fproceed.Name = "btn2Fproceed"
        Me.btn2Fproceed.Size = New System.Drawing.Size(293, 65)
        Me.btn2Fproceed.TabIndex = 2
        Me.btn2Fproceed.Text = "PROCEED"
        Me.btn2Fproceed.UseVisualStyleBackColor = True
        '
        'btn2Fexit
        '
        Me.btn2Fexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2Fexit.ForeColor = System.Drawing.Color.White
        Me.btn2Fexit.Image = CType(resources.GetObject("btn2Fexit.Image"), System.Drawing.Image)
        Me.btn2Fexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn2Fexit.Location = New System.Drawing.Point(176, 229)
        Me.btn2Fexit.Name = "btn2Fexit"
        Me.btn2Fexit.Size = New System.Drawing.Size(147, 44)
        Me.btn2Fexit.TabIndex = 4
        Me.btn2Fexit.Text = "EXIT"
        Me.btn2Fexit.UseVisualStyleBackColor = True
        '
        'lbl2001
        '
        Me.lbl2001.BackColor = System.Drawing.Color.Snow
        Me.lbl2001.Controls.Add(Me.btn2Fexit)
        Me.lbl2001.Controls.Add(Me.btn2Freset)
        Me.lbl2001.Controls.Add(Me.btn2Fproceed)
        Me.lbl2001.Controls.Add(Me.lbl2003)
        Me.lbl2001.Controls.Add(Me.txt2FVerified)
        Me.lbl2001.Controls.Add(Me.lbl2002)
        Me.lbl2001.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2001.ForeColor = System.Drawing.Color.Maroon
        Me.lbl2001.Location = New System.Drawing.Point(373, 250)
        Me.lbl2001.Name = "lbl2001"
        Me.lbl2001.Size = New System.Drawing.Size(349, 305)
        Me.lbl2001.TabIndex = 5
        Me.lbl2001.TabStop = False
        Me.lbl2001.Text = "VERIFICATION FORM"
        '
        'btn2Freset
        '
        Me.btn2Freset.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2Freset.ForeColor = System.Drawing.Color.White
        Me.btn2Freset.Image = CType(resources.GetObject("btn2Freset.Image"), System.Drawing.Image)
        Me.btn2Freset.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn2Freset.Location = New System.Drawing.Point(30, 229)
        Me.btn2Freset.Name = "btn2Freset"
        Me.btn2Freset.Size = New System.Drawing.Size(140, 44)
        Me.btn2Freset.TabIndex = 3
        Me.btn2Freset.Text = "RESET"
        Me.btn2Freset.UseVisualStyleBackColor = True
        '
        'frm2VERIFICATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1092, 602)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl2001)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm2VERIFICATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VERIFICATION"
        Me.lbl2001.ResumeLayout(False)
        Me.lbl2001.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl2002 As System.Windows.Forms.Label
    Friend WithEvents txt2FVerified As System.Windows.Forms.TextBox
    Friend WithEvents lbl2003 As System.Windows.Forms.Label
    Friend WithEvents btn2Fproceed As System.Windows.Forms.Button
    Friend WithEvents btn2Fexit As System.Windows.Forms.Button
    Friend WithEvents lbl2001 As System.Windows.Forms.GroupBox
    Friend WithEvents btn2Freset As System.Windows.Forms.Button
End Class
