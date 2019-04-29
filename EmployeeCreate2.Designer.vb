<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeCreate2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GB_humanResources = New System.Windows.Forms.GroupBox()
        Me.LBL_dateStarted = New System.Windows.Forms.Label()
        Me.TB_dateStarted = New System.Windows.Forms.TextBox()
        Me.LBL_education = New System.Windows.Forms.Label()
        Me.CB_education = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_salary = New System.Windows.Forms.TextBox()
        Me.LBL_sin = New System.Windows.Forms.Label()
        Me.TB_sin = New System.Windows.Forms.TextBox()
        Me.LBL_employeenumber = New System.Windows.Forms.Label()
        Me.TB_employeeNumber = New System.Windows.Forms.TextBox()
        Me.LBL_newemployee = New System.Windows.Forms.Label()
        Me.GB_systemInformation = New System.Windows.Forms.GroupBox()
        Me.BTN_create = New System.Windows.Forms.Button()
        Me.BTN_back = New System.Windows.Forms.Button()
        Me.LBL_note = New System.Windows.Forms.Label()
        Me.CBOX_activeAccount = New System.Windows.Forms.CheckBox()
        Me.LBL_password = New System.Windows.Forms.Label()
        Me.LBL_username = New System.Windows.Forms.Label()
        Me.LBL_accessLevel = New System.Windows.Forms.Label()
        Me.TB_password = New System.Windows.Forms.TextBox()
        Me.TB_username = New System.Windows.Forms.TextBox()
        Me.CB_accessLevel = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TS_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_changePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_employees = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_listEmployees = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_createEmployees = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_editEmployees = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_deleteEmployees = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_video = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_listVideos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_createVideos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_editVideos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_deleteVideos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_search = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_quickSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_advancedSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_rent = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_rentVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.GB_humanResources.SuspendLayout()
        Me.GB_systemInformation.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_humanResources
        '
        Me.GB_humanResources.Controls.Add(Me.LBL_dateStarted)
        Me.GB_humanResources.Controls.Add(Me.TB_dateStarted)
        Me.GB_humanResources.Controls.Add(Me.LBL_education)
        Me.GB_humanResources.Controls.Add(Me.CB_education)
        Me.GB_humanResources.Controls.Add(Me.Label2)
        Me.GB_humanResources.Controls.Add(Me.TB_salary)
        Me.GB_humanResources.Controls.Add(Me.LBL_sin)
        Me.GB_humanResources.Controls.Add(Me.TB_sin)
        Me.GB_humanResources.Controls.Add(Me.LBL_employeenumber)
        Me.GB_humanResources.Controls.Add(Me.TB_employeeNumber)
        Me.GB_humanResources.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_humanResources.Location = New System.Drawing.Point(13, 107)
        Me.GB_humanResources.Name = "GB_humanResources"
        Me.GB_humanResources.Size = New System.Drawing.Size(408, 196)
        Me.GB_humanResources.TabIndex = 0
        Me.GB_humanResources.TabStop = False
        Me.GB_humanResources.Text = "2/3 - Human Resources"
        '
        'LBL_dateStarted
        '
        Me.LBL_dateStarted.AutoSize = True
        Me.LBL_dateStarted.Location = New System.Drawing.Point(6, 128)
        Me.LBL_dateStarted.Name = "LBL_dateStarted"
        Me.LBL_dateStarted.Size = New System.Drawing.Size(103, 19)
        Me.LBL_dateStarted.TabIndex = 25
        Me.LBL_dateStarted.Text = "Date Started: "
        '
        'TB_dateStarted
        '
        Me.TB_dateStarted.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_dateStarted.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_dateStarted.Location = New System.Drawing.Point(161, 125)
        Me.TB_dateStarted.Name = "TB_dateStarted"
        Me.TB_dateStarted.Size = New System.Drawing.Size(231, 27)
        Me.TB_dateStarted.TabIndex = 24
        '
        'LBL_education
        '
        Me.LBL_education.AutoSize = True
        Me.LBL_education.Location = New System.Drawing.Point(8, 162)
        Me.LBL_education.Name = "LBL_education"
        Me.LBL_education.Size = New System.Drawing.Size(81, 19)
        Me.LBL_education.TabIndex = 23
        Me.LBL_education.Text = "Education:"
        '
        'CB_education
        '
        Me.CB_education.BackColor = System.Drawing.SystemColors.Window
        Me.CB_education.FormattingEnabled = True
        Me.CB_education.Location = New System.Drawing.Point(161, 159)
        Me.CB_education.Name = "CB_education"
        Me.CB_education.Size = New System.Drawing.Size(231, 27)
        Me.CB_education.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Salary: "
        '
        'TB_salary
        '
        Me.TB_salary.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_salary.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_salary.Location = New System.Drawing.Point(161, 92)
        Me.TB_salary.Name = "TB_salary"
        Me.TB_salary.Size = New System.Drawing.Size(231, 27)
        Me.TB_salary.TabIndex = 3
        '
        'LBL_sin
        '
        Me.LBL_sin.AutoSize = True
        Me.LBL_sin.Location = New System.Drawing.Point(6, 62)
        Me.LBL_sin.Name = "LBL_sin"
        Me.LBL_sin.Size = New System.Drawing.Size(37, 19)
        Me.LBL_sin.TabIndex = 20
        Me.LBL_sin.Text = "SIN:"
        '
        'TB_sin
        '
        Me.TB_sin.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_sin.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_sin.Location = New System.Drawing.Point(161, 59)
        Me.TB_sin.Name = "TB_sin"
        Me.TB_sin.Size = New System.Drawing.Size(231, 27)
        Me.TB_sin.TabIndex = 2
        '
        'LBL_employeenumber
        '
        Me.LBL_employeenumber.AutoSize = True
        Me.LBL_employeenumber.Location = New System.Drawing.Point(6, 29)
        Me.LBL_employeenumber.Name = "LBL_employeenumber"
        Me.LBL_employeenumber.Size = New System.Drawing.Size(138, 19)
        Me.LBL_employeenumber.TabIndex = 18
        Me.LBL_employeenumber.Text = "Employee Number:"
        '
        'TB_employeeNumber
        '
        Me.TB_employeeNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_employeeNumber.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_employeeNumber.Location = New System.Drawing.Point(161, 26)
        Me.TB_employeeNumber.Name = "TB_employeeNumber"
        Me.TB_employeeNumber.Size = New System.Drawing.Size(231, 27)
        Me.TB_employeeNumber.TabIndex = 1
        '
        'LBL_newemployee
        '
        Me.LBL_newemployee.AutoSize = True
        Me.LBL_newemployee.Font = New System.Drawing.Font("Corbel", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_newemployee.Location = New System.Drawing.Point(54, 45)
        Me.LBL_newemployee.Name = "LBL_newemployee"
        Me.LBL_newemployee.Size = New System.Drawing.Size(367, 59)
        Me.LBL_newemployee.TabIndex = 2
        Me.LBL_newemployee.Text = "Create Employee"
        '
        'GB_systemInformation
        '
        Me.GB_systemInformation.Controls.Add(Me.BTN_create)
        Me.GB_systemInformation.Controls.Add(Me.BTN_back)
        Me.GB_systemInformation.Controls.Add(Me.LBL_note)
        Me.GB_systemInformation.Controls.Add(Me.CBOX_activeAccount)
        Me.GB_systemInformation.Controls.Add(Me.LBL_password)
        Me.GB_systemInformation.Controls.Add(Me.LBL_username)
        Me.GB_systemInformation.Controls.Add(Me.LBL_accessLevel)
        Me.GB_systemInformation.Controls.Add(Me.TB_password)
        Me.GB_systemInformation.Controls.Add(Me.TB_username)
        Me.GB_systemInformation.Controls.Add(Me.CB_accessLevel)
        Me.GB_systemInformation.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_systemInformation.Location = New System.Drawing.Point(13, 309)
        Me.GB_systemInformation.Name = "GB_systemInformation"
        Me.GB_systemInformation.Size = New System.Drawing.Size(408, 263)
        Me.GB_systemInformation.TabIndex = 3
        Me.GB_systemInformation.TabStop = False
        Me.GB_systemInformation.Text = "3/3 - Systems Information"
        '
        'BTN_create
        '
        Me.BTN_create.Location = New System.Drawing.Point(212, 204)
        Me.BTN_create.Name = "BTN_create"
        Me.BTN_create.Size = New System.Drawing.Size(155, 40)
        Me.BTN_create.TabIndex = 25
        Me.BTN_create.Text = "Create"
        Me.BTN_create.UseVisualStyleBackColor = True
        '
        'BTN_back
        '
        Me.BTN_back.Location = New System.Drawing.Point(51, 204)
        Me.BTN_back.Name = "BTN_back"
        Me.BTN_back.Size = New System.Drawing.Size(155, 40)
        Me.BTN_back.TabIndex = 24
        Me.BTN_back.Text = "Back"
        Me.BTN_back.UseVisualStyleBackColor = True
        '
        'LBL_note
        '
        Me.LBL_note.AutoSize = True
        Me.LBL_note.BackColor = System.Drawing.Color.Transparent
        Me.LBL_note.Location = New System.Drawing.Point(6, 132)
        Me.LBL_note.Name = "LBL_note"
        Me.LBL_note.Size = New System.Drawing.Size(402, 19)
        Me.LBL_note.TabIndex = 23
        Me.LBL_note.Text = "Note: Password for all employess by default will be ""admin""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CBOX_activeAccount
        '
        Me.CBOX_activeAccount.AutoSize = True
        Me.CBOX_activeAccount.Location = New System.Drawing.Point(6, 175)
        Me.CBOX_activeAccount.Name = "CBOX_activeAccount"
        Me.CBOX_activeAccount.Size = New System.Drawing.Size(127, 23)
        Me.CBOX_activeAccount.TabIndex = 22
        Me.CBOX_activeAccount.Text = "Active Account"
        Me.CBOX_activeAccount.UseVisualStyleBackColor = True
        '
        'LBL_password
        '
        Me.LBL_password.AutoSize = True
        Me.LBL_password.Location = New System.Drawing.Point(6, 105)
        Me.LBL_password.Name = "LBL_password"
        Me.LBL_password.Size = New System.Drawing.Size(76, 19)
        Me.LBL_password.TabIndex = 21
        Me.LBL_password.Text = "Password:"
        '
        'LBL_username
        '
        Me.LBL_username.AutoSize = True
        Me.LBL_username.Location = New System.Drawing.Point(6, 72)
        Me.LBL_username.Name = "LBL_username"
        Me.LBL_username.Size = New System.Drawing.Size(83, 19)
        Me.LBL_username.TabIndex = 20
        Me.LBL_username.Text = "Username: "
        '
        'LBL_accessLevel
        '
        Me.LBL_accessLevel.AutoSize = True
        Me.LBL_accessLevel.Location = New System.Drawing.Point(6, 39)
        Me.LBL_accessLevel.Name = "LBL_accessLevel"
        Me.LBL_accessLevel.Size = New System.Drawing.Size(95, 19)
        Me.LBL_accessLevel.TabIndex = 19
        Me.LBL_accessLevel.Text = "Access Level:"
        '
        'TB_password
        '
        Me.TB_password.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_password.Enabled = False
        Me.TB_password.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_password.Location = New System.Drawing.Point(161, 102)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.Size = New System.Drawing.Size(231, 27)
        Me.TB_password.TabIndex = 7
        Me.TB_password.Text = "admin"
        '
        'TB_username
        '
        Me.TB_username.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_username.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_username.Location = New System.Drawing.Point(161, 69)
        Me.TB_username.Name = "TB_username"
        Me.TB_username.Size = New System.Drawing.Size(231, 27)
        Me.TB_username.TabIndex = 6
        '
        'CB_accessLevel
        '
        Me.CB_accessLevel.BackColor = System.Drawing.SystemColors.Window
        Me.CB_accessLevel.FormattingEnabled = True
        Me.CB_accessLevel.Location = New System.Drawing.Point(161, 36)
        Me.CB_accessLevel.Name = "CB_accessLevel"
        Me.CB_accessLevel.Size = New System.Drawing.Size(231, 27)
        Me.CB_accessLevel.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_employees, Me.TS_video, Me.TS_search, Me.TS_rent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(439, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TS_file
        '
        Me.TS_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_changePassword, Me.TS_logout, Me.TS_exit})
        Me.TS_file.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_file.Name = "TS_file"
        Me.TS_file.Size = New System.Drawing.Size(37, 20)
        Me.TS_file.Text = "File"
        '
        'TS_changePassword
        '
        Me.TS_changePassword.Name = "TS_changePassword"
        Me.TS_changePassword.Size = New System.Drawing.Size(160, 22)
        Me.TS_changePassword.Text = "Change password"
        '
        'TS_logout
        '
        Me.TS_logout.Name = "TS_logout"
        Me.TS_logout.Size = New System.Drawing.Size(160, 22)
        Me.TS_logout.Text = "Logout"
        '
        'TS_exit
        '
        Me.TS_exit.Name = "TS_exit"
        Me.TS_exit.Size = New System.Drawing.Size(160, 22)
        Me.TS_exit.Text = "Exit"
        '
        'TS_employees
        '
        Me.TS_employees.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_listEmployees, Me.TS_createEmployees, Me.TS_editEmployees, Me.TS_deleteEmployees})
        Me.TS_employees.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_employees.Name = "TS_employees"
        Me.TS_employees.Size = New System.Drawing.Size(69, 20)
        Me.TS_employees.Text = "Employee"
        '
        'TS_listEmployees
        '
        Me.TS_listEmployees.Name = "TS_listEmployees"
        Me.TS_listEmployees.Size = New System.Drawing.Size(107, 22)
        Me.TS_listEmployees.Text = "List"
        '
        'TS_createEmployees
        '
        Me.TS_createEmployees.Name = "TS_createEmployees"
        Me.TS_createEmployees.Size = New System.Drawing.Size(107, 22)
        Me.TS_createEmployees.Text = "Create"
        '
        'TS_editEmployees
        '
        Me.TS_editEmployees.Name = "TS_editEmployees"
        Me.TS_editEmployees.Size = New System.Drawing.Size(107, 22)
        Me.TS_editEmployees.Text = "Edit"
        '
        'TS_deleteEmployees
        '
        Me.TS_deleteEmployees.Name = "TS_deleteEmployees"
        Me.TS_deleteEmployees.Size = New System.Drawing.Size(107, 22)
        Me.TS_deleteEmployees.Text = "Delete"
        '
        'TS_video
        '
        Me.TS_video.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_listVideos, Me.TS_createVideos, Me.TS_editVideos, Me.TS_deleteVideos})
        Me.TS_video.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_video.Name = "TS_video"
        Me.TS_video.Size = New System.Drawing.Size(47, 20)
        Me.TS_video.Text = "Video"
        '
        'TS_listVideos
        '
        Me.TS_listVideos.Name = "TS_listVideos"
        Me.TS_listVideos.Size = New System.Drawing.Size(107, 22)
        Me.TS_listVideos.Text = "List"
        '
        'TS_createVideos
        '
        Me.TS_createVideos.Name = "TS_createVideos"
        Me.TS_createVideos.Size = New System.Drawing.Size(107, 22)
        Me.TS_createVideos.Text = "Create"
        '
        'TS_editVideos
        '
        Me.TS_editVideos.Name = "TS_editVideos"
        Me.TS_editVideos.Size = New System.Drawing.Size(107, 22)
        Me.TS_editVideos.Text = "Edit"
        '
        'TS_deleteVideos
        '
        Me.TS_deleteVideos.Name = "TS_deleteVideos"
        Me.TS_deleteVideos.Size = New System.Drawing.Size(107, 22)
        Me.TS_deleteVideos.Text = "Delete"
        '
        'TS_search
        '
        Me.TS_search.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_quickSearch, Me.TS_advancedSearch})
        Me.TS_search.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_search.Name = "TS_search"
        Me.TS_search.Size = New System.Drawing.Size(53, 20)
        Me.TS_search.Text = "Search"
        '
        'TS_quickSearch
        '
        Me.TS_quickSearch.Name = "TS_quickSearch"
        Me.TS_quickSearch.Size = New System.Drawing.Size(117, 22)
        Me.TS_quickSearch.Text = "Quick"
        '
        'TS_advancedSearch
        '
        Me.TS_advancedSearch.Name = "TS_advancedSearch"
        Me.TS_advancedSearch.Size = New System.Drawing.Size(117, 22)
        Me.TS_advancedSearch.Text = "Advance"
        '
        'TS_rent
        '
        Me.TS_rent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_rentVideo})
        Me.TS_rent.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_rent.Name = "TS_rent"
        Me.TS_rent.Size = New System.Drawing.Size(42, 20)
        Me.TS_rent.Text = "Rent"
        '
        'TS_rentVideo
        '
        Me.TS_rentVideo.Name = "TS_rentVideo"
        Me.TS_rentVideo.Size = New System.Drawing.Size(126, 22)
        Me.TS_rentVideo.Text = "Rent video"
        '
        'EmployeeCreate2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 584)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GB_systemInformation)
        Me.Controls.Add(Me.LBL_newemployee)
        Me.Controls.Add(Me.GB_humanResources)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "EmployeeCreate2"
        Me.Text = "CreateEmployee2"
        Me.GB_humanResources.ResumeLayout(False)
        Me.GB_humanResources.PerformLayout()
        Me.GB_systemInformation.ResumeLayout(False)
        Me.GB_systemInformation.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_humanResources As GroupBox
    Friend WithEvents LBL_employeenumber As Label
    Friend WithEvents TB_employeeNumber As TextBox
    Friend WithEvents LBL_education As Label
    Friend WithEvents CB_education As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_salary As TextBox
    Friend WithEvents LBL_sin As Label
    Friend WithEvents TB_sin As TextBox
    Friend WithEvents LBL_newemployee As Label
    Friend WithEvents GB_systemInformation As GroupBox
    Friend WithEvents LBL_password As Label
    Friend WithEvents LBL_username As Label
    Friend WithEvents LBL_accessLevel As Label
    Friend WithEvents TB_password As TextBox
    Friend WithEvents TB_username As TextBox
    Friend WithEvents CB_accessLevel As ComboBox
    Friend WithEvents LBL_dateStarted As Label
    Friend WithEvents TB_dateStarted As TextBox
    Friend WithEvents LBL_note As Label
    Friend WithEvents CBOX_activeAccount As CheckBox
    Friend WithEvents BTN_back As Button
    Friend WithEvents BTN_create As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TS_file As ToolStripMenuItem
    Friend WithEvents TS_changePassword As ToolStripMenuItem
    Friend WithEvents TS_logout As ToolStripMenuItem
    Friend WithEvents TS_exit As ToolStripMenuItem
    Friend WithEvents TS_employees As ToolStripMenuItem
    Friend WithEvents TS_listEmployees As ToolStripMenuItem
    Friend WithEvents TS_createEmployees As ToolStripMenuItem
    Friend WithEvents TS_editEmployees As ToolStripMenuItem
    Friend WithEvents TS_deleteEmployees As ToolStripMenuItem
    Friend WithEvents TS_video As ToolStripMenuItem
    Friend WithEvents TS_listVideos As ToolStripMenuItem
    Friend WithEvents TS_createVideos As ToolStripMenuItem
    Friend WithEvents TS_editVideos As ToolStripMenuItem
    Friend WithEvents TS_deleteVideos As ToolStripMenuItem
    Friend WithEvents TS_search As ToolStripMenuItem
    Friend WithEvents TS_quickSearch As ToolStripMenuItem
    Friend WithEvents TS_advancedSearch As ToolStripMenuItem
    Friend WithEvents TS_rent As ToolStripMenuItem
    Friend WithEvents TS_rentVideo As ToolStripMenuItem
End Class
