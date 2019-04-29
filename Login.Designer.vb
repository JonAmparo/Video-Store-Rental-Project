<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LBL_login = New System.Windows.Forms.Label()
        Me.LBL_username = New System.Windows.Forms.Label()
        Me.LBL_password = New System.Windows.Forms.Label()
        Me.TB_username = New System.Windows.Forms.TextBox()
        Me.TB_password = New System.Windows.Forms.TextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.TS_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_login = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_login
        '
        Me.LBL_login.AutoSize = True
        Me.LBL_login.Font = New System.Drawing.Font("Corbel", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_login.Location = New System.Drawing.Point(140, 24)
        Me.LBL_login.Name = "LBL_login"
        Me.LBL_login.Size = New System.Drawing.Size(137, 59)
        Me.LBL_login.TabIndex = 0
        Me.LBL_login.Text = "Login"
        '
        'LBL_username
        '
        Me.LBL_username.AutoSize = True
        Me.LBL_username.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_username.Location = New System.Drawing.Point(35, 100)
        Me.LBL_username.Name = "LBL_username"
        Me.LBL_username.Size = New System.Drawing.Size(83, 19)
        Me.LBL_username.TabIndex = 7
        Me.LBL_username.Text = "Username: "
        '
        'LBL_password
        '
        Me.LBL_password.AutoSize = True
        Me.LBL_password.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_password.Location = New System.Drawing.Point(35, 133)
        Me.LBL_password.Name = "LBL_password"
        Me.LBL_password.Size = New System.Drawing.Size(79, 19)
        Me.LBL_password.TabIndex = 2
        Me.LBL_password.Text = "Password: "
        '
        'TB_username
        '
        Me.TB_username.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_username.Location = New System.Drawing.Point(150, 97)
        Me.TB_username.Name = "TB_username"
        Me.TB_username.Size = New System.Drawing.Size(231, 27)
        Me.TB_username.TabIndex = 1
        Me.TB_username.Text = "Jamparo"
        '
        'TB_password
        '
        Me.TB_password.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_password.Location = New System.Drawing.Point(150, 130)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_password.Size = New System.Drawing.Size(231, 27)
        Me.TB_password.TabIndex = 2
        Me.TB_password.Text = "123"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip.TabIndex = 8
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'TS_file
        '
        Me.TS_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_exit})
        Me.TS_file.Name = "TS_file"
        Me.TS_file.Size = New System.Drawing.Size(37, 20)
        Me.TS_file.Text = "File"
        '
        'TS_exit
        '
        Me.TS_exit.Name = "TS_exit"
        Me.TS_exit.Size = New System.Drawing.Size(92, 22)
        Me.TS_exit.Text = "Exit"
        '
        'BTN_login
        '
        Me.BTN_login.BackColor = System.Drawing.SystemColors.Control
        Me.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_login.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_login.Location = New System.Drawing.Point(139, 176)
        Me.BTN_login.Name = "BTN_login"
        Me.BTN_login.Size = New System.Drawing.Size(155, 40)
        Me.BTN_login.TabIndex = 3
        Me.BTN_login.Text = "Login"
        Me.BTN_login.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 240)
        Me.Controls.Add(Me.BTN_login)
        Me.Controls.Add(Me.TB_password)
        Me.Controls.Add(Me.TB_username)
        Me.Controls.Add(Me.LBL_password)
        Me.Controls.Add(Me.LBL_username)
        Me.Controls.Add(Me.LBL_login)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Login"
        Me.Text = "VideoStore"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_login As Label
    Friend WithEvents LBL_username As Label
    Friend WithEvents LBL_password As Label
    Friend WithEvents TB_username As TextBox
    Friend WithEvents TB_password As TextBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents TS_file As ToolStripMenuItem
    Friend WithEvents TS_exit As ToolStripMenuItem
    Friend WithEvents BTN_login As Button
End Class
