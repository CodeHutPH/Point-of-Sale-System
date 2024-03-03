<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm6CASHIER
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm6CASHIER))
        Me.dgCashier = New System.Windows.Forms.DataGridView()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.gbPay = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.txtBarcodeNumber = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.gbtrans = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.TimerCashier = New System.Windows.Forms.Timer(Me.components)
        Me.txtTransactionNumber = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picCashierNow = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPay.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbtrans.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCashierNow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCashier
        '
        Me.dgCashier.AllowUserToResizeColumns = False
        Me.dgCashier.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgCashier.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCashier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgCashier.BackgroundColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCashier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCashier.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgCashier.Location = New System.Drawing.Point(901, 77)
        Me.dgCashier.Name = "dgCashier"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCashier.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgCashier.RowHeadersVisible = False
        Me.dgCashier.Size = New System.Drawing.Size(1001, 788)
        Me.dgCashier.TabIndex = 26
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.ForeColor = System.Drawing.Color.Black
        Me.lblCashier.Location = New System.Drawing.Point(274, 54)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(225, 42)
        Me.lblCashier.TabIndex = 27
        Me.lblCashier.Text = "JOHN DOE"
        '
        'gbPay
        '
        Me.gbPay.BackColor = System.Drawing.Color.Cornsilk
        Me.gbPay.Controls.Add(Me.PictureBox2)
        Me.gbPay.Controls.Add(Me.Label4)
        Me.gbPay.Controls.Add(Me.txtChange)
        Me.gbPay.Controls.Add(Me.txtAmount)
        Me.gbPay.Controls.Add(Me.lblchange)
        Me.gbPay.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPay.ForeColor = System.Drawing.Color.Maroon
        Me.gbPay.Location = New System.Drawing.Point(12, 628)
        Me.gbPay.Name = "gbPay"
        Me.gbPay.Size = New System.Drawing.Size(765, 356)
        Me.gbPay.TabIndex = 28
        Me.gbPay.TabStop = False
        Me.gbPay.Text = "PAYMENT WINDOW"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(541, 65)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(179, 204)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(24, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 34)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "PAYMENT AMOUNT"
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(29, 240)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(458, 38)
        Me.txtChange.TabIndex = 40
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(29, 148)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(458, 38)
        Me.txtAmount.TabIndex = 32
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.Maroon
        Me.lblchange.Location = New System.Drawing.Point(24, 208)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(298, 34)
        Me.lblchange.TabIndex = 35
        Me.lblchange.Text = "CHANGE AMOUNT"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(1363, 942)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(338, 42)
        Me.lblCurrentDate.TabIndex = 29
        Me.lblCurrentDate.Text = "CURRENT DATE"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.Maroon
        Me.lblDisplay.Location = New System.Drawing.Point(888, 3)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(540, 74)
        Me.lblDisplay.TabIndex = 30
        Me.lblDisplay.Text = "GRAND TOTAL"
        '
        'txtBarcodeNumber
        '
        Me.txtBarcodeNumber.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeNumber.Location = New System.Drawing.Point(29, 99)
        Me.txtBarcodeNumber.Name = "txtBarcodeNumber"
        Me.txtBarcodeNumber.Size = New System.Drawing.Size(458, 29)
        Me.txtBarcodeNumber.TabIndex = 31
        Me.txtBarcodeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(29, 177)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(458, 29)
        Me.txtQuantity.TabIndex = 33
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Black
        Me.lbltotal.Location = New System.Drawing.Point(29, 227)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(149, 29)
        Me.lbltotal.TabIndex = 34
        Me.lbltotal.Text = "SUBTOTAL"
        '
        'gbtrans
        '
        Me.gbtrans.BackColor = System.Drawing.Color.Linen
        Me.gbtrans.Controls.Add(Me.PictureBox1)
        Me.gbtrans.Controls.Add(Me.Label3)
        Me.gbtrans.Controls.Add(Me.Label2)
        Me.gbtrans.Controls.Add(Me.txtBarcodeNumber)
        Me.gbtrans.Controls.Add(Me.txtSubTotal)
        Me.gbtrans.Controls.Add(Me.txtQuantity)
        Me.gbtrans.Controls.Add(Me.lbltotal)
        Me.gbtrans.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtrans.ForeColor = System.Drawing.Color.Maroon
        Me.gbtrans.Location = New System.Drawing.Point(12, 272)
        Me.gbtrans.Name = "gbtrans"
        Me.gbtrans.Size = New System.Drawing.Size(765, 334)
        Me.gbtrans.TabIndex = 29
        Me.gbtrans.TabStop = False
        Me.gbtrans.Text = "TRANSACTION WINDOW"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(541, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(29, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 29)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "QUANTITY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 29)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "BARCODE"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(29, 259)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(458, 29)
        Me.txtSubTotal.TabIndex = 39
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(1427, 868)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(560, 74)
        Me.lblCurrentTime.TabIndex = 36
        Me.lblCurrentTime.Text = "CURRENT TIME"
        '
        'TimerCashier
        '
        Me.TimerCashier.Interval = 1000
        '
        'txtTransactionNumber
        '
        Me.txtTransactionNumber.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionNumber.Location = New System.Drawing.Point(274, 195)
        Me.txtTransactionNumber.Name = "txtTransactionNumber"
        Me.txtTransactionNumber.ReadOnly = True
        Me.txtTransactionNumber.Size = New System.Drawing.Size(494, 44)
        Me.txtTransactionNumber.TabIndex = 37
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(1420, 8)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(482, 63)
        Me.txtTotal.TabIndex = 38
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(274, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 42)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "TRANSACTION NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(274, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(341, 42)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "CASHIER NAME:"
        '
        'picCashierNow
        '
        Me.picCashierNow.ErrorImage = CType(resources.GetObject("picCashierNow.ErrorImage"), System.Drawing.Image)
        Me.picCashierNow.Image = CType(resources.GetObject("picCashierNow.Image"), System.Drawing.Image)
        Me.picCashierNow.Location = New System.Drawing.Point(12, 12)
        Me.picCashierNow.Name = "picCashierNow"
        Me.picCashierNow.Size = New System.Drawing.Size(256, 235)
        Me.picCashierNow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCashierNow.TabIndex = 41
        Me.picCashierNow.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(901, 868)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(262, 23)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "[F1] - OPEN PAYMENT WINDOW"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1169, 868)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "[F12] - CLOSE CASHIER WINDOW"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Candara Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1169, 900)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 23)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "[ESC] -  GO BACK"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Candara Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(901, 900)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(203, 23)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "[ENTER] - ENTER VALUE"
        '
        'frm6CASHIER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1927, 1027)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.picCashierNow)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTransactionNumber)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.gbtrans)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.gbPay)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.dgCashier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm6CASHIER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CASHIER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCashier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPay.ResumeLayout(False)
        Me.gbPay.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbtrans.ResumeLayout(False)
        Me.gbtrans.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCashierNow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgCashier As System.Windows.Forms.DataGridView
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents gbPay As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurrentDate As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents txtBarcodeNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblchange As System.Windows.Forms.Label
    Friend WithEvents gbtrans As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents TimerCashier As System.Windows.Forms.Timer
    Friend WithEvents txtTransactionNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picCashierNow As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
