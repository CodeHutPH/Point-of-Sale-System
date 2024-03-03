<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crystalUser
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
        Me.crvUser = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.zUser1 = New AbdonCokeSystem.zUser()
        Me.SuspendLayout()
        '
        'crvUser
        '
        Me.crvUser.ActiveViewIndex = 0
        Me.crvUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvUser.DisplayStatusBar = False
        Me.crvUser.DisplayToolbar = False
        Me.crvUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvUser.Location = New System.Drawing.Point(0, 0)
        Me.crvUser.Name = "crvUser"
        Me.crvUser.ReportSource = Me.zUser1
        Me.crvUser.Size = New System.Drawing.Size(1026, 662)
        Me.crvUser.TabIndex = 0
        '
        'crystalUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 662)
        Me.Controls.Add(Me.crvUser)
        Me.Name = "crystalUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "crystalUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvUser As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents zUser1 As AbdonCokeSystem.zUser
End Class
