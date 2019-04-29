<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDelete
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
        Me.LBL_deleteEmployee = New System.Windows.Forms.Label()
        Me.BTN_cancel = New System.Windows.Forms.Button()
        Me.BTN_delete = New System.Windows.Forms.Button()
        Me.GB_chooseAnEmployee = New System.Windows.Forms.GroupBox()
        Me.CB_chooseEmployee = New System.Windows.Forms.ComboBox()
        Me.LBL_chooseEmployee = New System.Windows.Forms.Label()
        Me.GB_systemInformation = New System.Windows.Forms.GroupBox()
        Me.TB_activeAccount = New System.Windows.Forms.TextBox()
        Me.CBOX_activeAccount = New System.Windows.Forms.CheckBox()
        Me.LBL_password = New System.Windows.Forms.Label()
        Me.LBL_username = New System.Windows.Forms.Label()
        Me.LBL_accessLevel = New System.Windows.Forms.Label()
        Me.TB_password = New System.Windows.Forms.TextBox()
        Me.TB_username = New System.Windows.Forms.TextBox()
        Me.CB_accessLevel = New System.Windows.Forms.ComboBox()
        Me.GB_humanResources = New System.Windows.Forms.GroupBox()
        Me.MTB_sin = New System.Windows.Forms.MaskedTextBox()
        Me.LBL_dateStarted = New System.Windows.Forms.Label()
        Me.TB_dateStarted = New System.Windows.Forms.TextBox()
        Me.LBL_education = New System.Windows.Forms.Label()
        Me.CB_education = New System.Windows.Forms.ComboBox()
        Me.LBL_hourlyPay = New System.Windows.Forms.Label()
        Me.TB_hourlyPay = New System.Windows.Forms.TextBox()
        Me.LBL_sin = New System.Windows.Forms.Label()
        Me.LBL_employeenumber = New System.Windows.Forms.Label()
        Me.TB_employeeNumber = New System.Windows.Forms.TextBox()
        Me.GB_new = New System.Windows.Forms.GroupBox()
        Me.MTB_cellPhone = New System.Windows.Forms.MaskedTextBox()
        Me.MTB_homePhone = New System.Windows.Forms.MaskedTextBox()
        Me.MTB_postalCode = New System.Windows.Forms.MaskedTextBox()
        Me.CB_province = New System.Windows.Forms.ComboBox()
        Me.LBL_day = New System.Windows.Forms.Label()
        Me.LBL_month = New System.Windows.Forms.Label()
        Me.LBL_year = New System.Windows.Forms.Label()
        Me.CB_year = New System.Windows.Forms.ComboBox()
        Me.CB_day = New System.Windows.Forms.ComboBox()
        Me.CB_month = New System.Windows.Forms.ComboBox()
        Me.LBL_cellphone = New System.Windows.Forms.Label()
        Me.LBL_homephone = New System.Windows.Forms.Label()
        Me.LBL_postalcode = New System.Windows.Forms.Label()
        Me.LBL_province = New System.Windows.Forms.Label()
        Me.LBL_city = New System.Windows.Forms.Label()
        Me.LBL_address = New System.Windows.Forms.Label()
        Me.LBL_age = New System.Windows.Forms.Label()
        Me.LBL_dob = New System.Windows.Forms.Label()
        Me.LBL_lastname = New System.Windows.Forms.Label()
        Me.TB_city = New System.Windows.Forms.TextBox()
        Me.TB_address = New System.Windows.Forms.TextBox()
        Me.TB_age = New System.Windows.Forms.TextBox()
        Me.TB_lastname = New System.Windows.Forms.TextBox()
        Me.TB_firstname = New System.Windows.Forms.TextBox()
        Me.LBL_firstname = New System.Windows.Forms.Label()
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
        Me.TS_client = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_listClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_createClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_editClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_deleteClient = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.TS_returnVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.GB_chooseAnEmployee.SuspendLayout()
        Me.GB_systemInformation.SuspendLayout()
        Me.GB_humanResources.SuspendLayout()
        Me.GB_new.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_deleteEmployee
        '
        Me.LBL_deleteEmployee.AutoSize = True
        Me.LBL_deleteEmployee.Font = New System.Drawing.Font("Corbel", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_deleteEmployee.Location = New System.Drawing.Point(220, 24)
        Me.LBL_deleteEmployee.Name = "LBL_deleteEmployee"
        Me.LBL_deleteEmployee.Size = New System.Drawing.Size(366, 59)
        Me.LBL_deleteEmployee.TabIndex = 30
        Me.LBL_deleteEmployee.Text = "Delete Employee"
        '
        'BTN_cancel
        '
        Me.BTN_cancel.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_cancel.Location = New System.Drawing.Point(231, 558)
        Me.BTN_cancel.Name = "BTN_cancel"
        Me.BTN_cancel.Size = New System.Drawing.Size(155, 40)
        Me.BTN_cancel.TabIndex = 28
        Me.BTN_cancel.Text = "Cancel"
        Me.BTN_cancel.UseVisualStyleBackColor = True
        '
        'BTN_delete
        '
        Me.BTN_delete.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_delete.Location = New System.Drawing.Point(392, 558)
        Me.BTN_delete.Name = "BTN_delete"
        Me.BTN_delete.Size = New System.Drawing.Size(155, 40)
        Me.BTN_delete.TabIndex = 29
        Me.BTN_delete.Text = "Delete"
        Me.BTN_delete.UseVisualStyleBackColor = True
        '
        'GB_chooseAnEmployee
        '
        Me.GB_chooseAnEmployee.Controls.Add(Me.CB_chooseEmployee)
        Me.GB_chooseAnEmployee.Controls.Add(Me.LBL_chooseEmployee)
        Me.GB_chooseAnEmployee.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_chooseAnEmployee.Location = New System.Drawing.Point(12, 86)
        Me.GB_chooseAnEmployee.Name = "GB_chooseAnEmployee"
        Me.GB_chooseAnEmployee.Size = New System.Drawing.Size(788, 75)
        Me.GB_chooseAnEmployee.TabIndex = 35
        Me.GB_chooseAnEmployee.TabStop = False
        Me.GB_chooseAnEmployee.Text = "Choose an employee to delete"
        '
        'CB_chooseEmployee
        '
        Me.CB_chooseEmployee.FormattingEnabled = True
        Me.CB_chooseEmployee.Location = New System.Drawing.Point(115, 31)
        Me.CB_chooseEmployee.Name = "CB_chooseEmployee"
        Me.CB_chooseEmployee.Size = New System.Drawing.Size(599, 27)
        Me.CB_chooseEmployee.TabIndex = 2
        '
        'LBL_chooseEmployee
        '
        Me.LBL_chooseEmployee.AutoSize = True
        Me.LBL_chooseEmployee.Location = New System.Drawing.Point(13, 34)
        Me.LBL_chooseEmployee.Name = "LBL_chooseEmployee"
        Me.LBL_chooseEmployee.Size = New System.Drawing.Size(87, 19)
        Me.LBL_chooseEmployee.TabIndex = 1
        Me.LBL_chooseEmployee.Text = "Employees:"
        '
        'GB_systemInformation
        '
        Me.GB_systemInformation.Controls.Add(Me.TB_activeAccount)
        Me.GB_systemInformation.Controls.Add(Me.CBOX_activeAccount)
        Me.GB_systemInformation.Controls.Add(Me.LBL_password)
        Me.GB_systemInformation.Controls.Add(Me.LBL_username)
        Me.GB_systemInformation.Controls.Add(Me.LBL_accessLevel)
        Me.GB_systemInformation.Controls.Add(Me.TB_password)
        Me.GB_systemInformation.Controls.Add(Me.TB_username)
        Me.GB_systemInformation.Controls.Add(Me.CB_accessLevel)
        Me.GB_systemInformation.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_systemInformation.Location = New System.Drawing.Point(392, 358)
        Me.GB_systemInformation.Name = "GB_systemInformation"
        Me.GB_systemInformation.Size = New System.Drawing.Size(408, 194)
        Me.GB_systemInformation.TabIndex = 34
        Me.GB_systemInformation.TabStop = False
        Me.GB_systemInformation.Text = "3/3 - Systems Information"
        '
        'TB_activeAccount
        '
        Me.TB_activeAccount.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_activeAccount.Enabled = False
        Me.TB_activeAccount.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_activeAccount.Location = New System.Drawing.Point(160, 156)
        Me.TB_activeAccount.Name = "TB_activeAccount"
        Me.TB_activeAccount.Size = New System.Drawing.Size(231, 27)
        Me.TB_activeAccount.TabIndex = 24
        Me.TB_activeAccount.TabStop = False
        Me.TB_activeAccount.Visible = False
        '
        'CBOX_activeAccount
        '
        Me.CBOX_activeAccount.AutoSize = True
        Me.CBOX_activeAccount.Checked = True
        Me.CBOX_activeAccount.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBOX_activeAccount.Enabled = False
        Me.CBOX_activeAccount.Location = New System.Drawing.Point(10, 138)
        Me.CBOX_activeAccount.Name = "CBOX_activeAccount"
        Me.CBOX_activeAccount.Size = New System.Drawing.Size(127, 23)
        Me.CBOX_activeAccount.TabIndex = 20
        Me.CBOX_activeAccount.Text = "Active Account"
        Me.CBOX_activeAccount.UseVisualStyleBackColor = True
        '
        'LBL_password
        '
        Me.LBL_password.AutoSize = True
        Me.LBL_password.Location = New System.Drawing.Point(8, 102)
        Me.LBL_password.Name = "LBL_password"
        Me.LBL_password.Size = New System.Drawing.Size(76, 19)
        Me.LBL_password.TabIndex = 21
        Me.LBL_password.Text = "Password:"
        '
        'LBL_username
        '
        Me.LBL_username.AutoSize = True
        Me.LBL_username.Location = New System.Drawing.Point(8, 69)
        Me.LBL_username.Name = "LBL_username"
        Me.LBL_username.Size = New System.Drawing.Size(83, 19)
        Me.LBL_username.TabIndex = 20
        Me.LBL_username.Text = "Username: "
        '
        'LBL_accessLevel
        '
        Me.LBL_accessLevel.AutoSize = True
        Me.LBL_accessLevel.Location = New System.Drawing.Point(8, 36)
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
        Me.TB_password.Location = New System.Drawing.Point(161, 99)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.Size = New System.Drawing.Size(231, 27)
        Me.TB_password.TabIndex = 23
        '
        'TB_username
        '
        Me.TB_username.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_username.Enabled = False
        Me.TB_username.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_username.Location = New System.Drawing.Point(161, 66)
        Me.TB_username.Name = "TB_username"
        Me.TB_username.Size = New System.Drawing.Size(231, 27)
        Me.TB_username.TabIndex = 19
        '
        'CB_accessLevel
        '
        Me.CB_accessLevel.BackColor = System.Drawing.SystemColors.Window
        Me.CB_accessLevel.Enabled = False
        Me.CB_accessLevel.FormattingEnabled = True
        Me.CB_accessLevel.Items.AddRange(New Object() {"1 (Low)", "2 (Mid)", "3 (High)"})
        Me.CB_accessLevel.Location = New System.Drawing.Point(161, 33)
        Me.CB_accessLevel.Name = "CB_accessLevel"
        Me.CB_accessLevel.Size = New System.Drawing.Size(231, 27)
        Me.CB_accessLevel.TabIndex = 18
        '
        'GB_humanResources
        '
        Me.GB_humanResources.Controls.Add(Me.MTB_sin)
        Me.GB_humanResources.Controls.Add(Me.LBL_dateStarted)
        Me.GB_humanResources.Controls.Add(Me.TB_dateStarted)
        Me.GB_humanResources.Controls.Add(Me.LBL_education)
        Me.GB_humanResources.Controls.Add(Me.CB_education)
        Me.GB_humanResources.Controls.Add(Me.LBL_hourlyPay)
        Me.GB_humanResources.Controls.Add(Me.TB_hourlyPay)
        Me.GB_humanResources.Controls.Add(Me.LBL_sin)
        Me.GB_humanResources.Controls.Add(Me.LBL_employeenumber)
        Me.GB_humanResources.Controls.Add(Me.TB_employeeNumber)
        Me.GB_humanResources.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_humanResources.Location = New System.Drawing.Point(392, 167)
        Me.GB_humanResources.Name = "GB_humanResources"
        Me.GB_humanResources.Size = New System.Drawing.Size(408, 193)
        Me.GB_humanResources.TabIndex = 33
        Me.GB_humanResources.TabStop = False
        Me.GB_humanResources.Text = "2/3 - Human Resources"
        '
        'MTB_sin
        '
        Me.MTB_sin.Enabled = False
        Me.MTB_sin.Location = New System.Drawing.Point(160, 59)
        Me.MTB_sin.Mask = "999-000-000"
        Me.MTB_sin.Name = "MTB_sin"
        Me.MTB_sin.Size = New System.Drawing.Size(232, 27)
        Me.MTB_sin.TabIndex = 14
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
        Me.TB_dateStarted.Enabled = False
        Me.TB_dateStarted.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_dateStarted.Location = New System.Drawing.Point(161, 125)
        Me.TB_dateStarted.Name = "TB_dateStarted"
        Me.TB_dateStarted.Size = New System.Drawing.Size(231, 27)
        Me.TB_dateStarted.TabIndex = 16
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
        Me.CB_education.Enabled = False
        Me.CB_education.FormattingEnabled = True
        Me.CB_education.Items.AddRange(New Object() {"None", "High School", "DES", "AEC", "DEC", "Certificate", "BAC", "Master", "Doc"})
        Me.CB_education.Location = New System.Drawing.Point(161, 159)
        Me.CB_education.Name = "CB_education"
        Me.CB_education.Size = New System.Drawing.Size(231, 27)
        Me.CB_education.TabIndex = 17
        '
        'LBL_hourlyPay
        '
        Me.LBL_hourlyPay.AutoSize = True
        Me.LBL_hourlyPay.Location = New System.Drawing.Point(6, 95)
        Me.LBL_hourlyPay.Name = "LBL_hourlyPay"
        Me.LBL_hourlyPay.Size = New System.Drawing.Size(86, 19)
        Me.LBL_hourlyPay.TabIndex = 22
        Me.LBL_hourlyPay.Text = "Hourly pay:"
        '
        'TB_hourlyPay
        '
        Me.TB_hourlyPay.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_hourlyPay.Enabled = False
        Me.TB_hourlyPay.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_hourlyPay.Location = New System.Drawing.Point(161, 92)
        Me.TB_hourlyPay.Name = "TB_hourlyPay"
        Me.TB_hourlyPay.Size = New System.Drawing.Size(231, 27)
        Me.TB_hourlyPay.TabIndex = 15
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
        Me.TB_employeeNumber.Enabled = False
        Me.TB_employeeNumber.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_employeeNumber.Location = New System.Drawing.Point(161, 26)
        Me.TB_employeeNumber.Name = "TB_employeeNumber"
        Me.TB_employeeNumber.Size = New System.Drawing.Size(231, 27)
        Me.TB_employeeNumber.TabIndex = 13
        '
        'GB_new
        '
        Me.GB_new.Controls.Add(Me.MTB_cellPhone)
        Me.GB_new.Controls.Add(Me.MTB_homePhone)
        Me.GB_new.Controls.Add(Me.MTB_postalCode)
        Me.GB_new.Controls.Add(Me.CB_province)
        Me.GB_new.Controls.Add(Me.LBL_day)
        Me.GB_new.Controls.Add(Me.LBL_month)
        Me.GB_new.Controls.Add(Me.LBL_year)
        Me.GB_new.Controls.Add(Me.CB_year)
        Me.GB_new.Controls.Add(Me.CB_day)
        Me.GB_new.Controls.Add(Me.CB_month)
        Me.GB_new.Controls.Add(Me.LBL_cellphone)
        Me.GB_new.Controls.Add(Me.LBL_homephone)
        Me.GB_new.Controls.Add(Me.LBL_postalcode)
        Me.GB_new.Controls.Add(Me.LBL_province)
        Me.GB_new.Controls.Add(Me.LBL_city)
        Me.GB_new.Controls.Add(Me.LBL_address)
        Me.GB_new.Controls.Add(Me.LBL_age)
        Me.GB_new.Controls.Add(Me.LBL_dob)
        Me.GB_new.Controls.Add(Me.LBL_lastname)
        Me.GB_new.Controls.Add(Me.TB_city)
        Me.GB_new.Controls.Add(Me.TB_address)
        Me.GB_new.Controls.Add(Me.TB_age)
        Me.GB_new.Controls.Add(Me.TB_lastname)
        Me.GB_new.Controls.Add(Me.TB_firstname)
        Me.GB_new.Controls.Add(Me.LBL_firstname)
        Me.GB_new.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_new.Location = New System.Drawing.Point(12, 167)
        Me.GB_new.Name = "GB_new"
        Me.GB_new.Size = New System.Drawing.Size(374, 385)
        Me.GB_new.TabIndex = 32
        Me.GB_new.TabStop = False
        Me.GB_new.Text = "1/3 - Primary Information"
        '
        'MTB_cellPhone
        '
        Me.MTB_cellPhone.Culture = New System.Globalization.CultureInfo("en-CA")
        Me.MTB_cellPhone.Enabled = False
        Me.MTB_cellPhone.Location = New System.Drawing.Point(114, 347)
        Me.MTB_cellPhone.Mask = "999-000-0000"
        Me.MTB_cellPhone.Name = "MTB_cellPhone"
        Me.MTB_cellPhone.Size = New System.Drawing.Size(232, 27)
        Me.MTB_cellPhone.TabIndex = 12
        '
        'MTB_homePhone
        '
        Me.MTB_homePhone.Culture = New System.Globalization.CultureInfo("ca-ES")
        Me.MTB_homePhone.Enabled = False
        Me.MTB_homePhone.Location = New System.Drawing.Point(114, 314)
        Me.MTB_homePhone.Mask = "999-000-0000"
        Me.MTB_homePhone.Name = "MTB_homePhone"
        Me.MTB_homePhone.Size = New System.Drawing.Size(232, 27)
        Me.MTB_homePhone.TabIndex = 11
        '
        'MTB_postalCode
        '
        Me.MTB_postalCode.Culture = New System.Globalization.CultureInfo("ca-AD")
        Me.MTB_postalCode.Enabled = False
        Me.MTB_postalCode.Location = New System.Drawing.Point(114, 281)
        Me.MTB_postalCode.Mask = "A0A 0A0"
        Me.MTB_postalCode.Name = "MTB_postalCode"
        Me.MTB_postalCode.Size = New System.Drawing.Size(232, 27)
        Me.MTB_postalCode.TabIndex = 10
        '
        'CB_province
        '
        Me.CB_province.Enabled = False
        Me.CB_province.FormattingEnabled = True
        Me.CB_province.Items.AddRange(New Object() {"Please choose a province...", "Ontario", "Quebec", "Nova Scotia", "New Brunswick", "Manitoba", "British Columbia", "Prince Edward Island", "Saskatchewan", "Alberta", "Newfoundland and Labrador"})
        Me.CB_province.Location = New System.Drawing.Point(115, 248)
        Me.CB_province.Name = "CB_province"
        Me.CB_province.Size = New System.Drawing.Size(231, 27)
        Me.CB_province.TabIndex = 9
        '
        'LBL_day
        '
        Me.LBL_day.AutoSize = True
        Me.LBL_day.BackColor = System.Drawing.Color.Transparent
        Me.LBL_day.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_day.Location = New System.Drawing.Point(282, 133)
        Me.LBL_day.Name = "LBL_day"
        Me.LBL_day.Size = New System.Drawing.Size(25, 13)
        Me.LBL_day.TabIndex = 25
        Me.LBL_day.Text = "Day"
        '
        'LBL_month
        '
        Me.LBL_month.AutoSize = True
        Me.LBL_month.BackColor = System.Drawing.Color.Transparent
        Me.LBL_month.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_month.Location = New System.Drawing.Point(215, 133)
        Me.LBL_month.Name = "LBL_month"
        Me.LBL_month.Size = New System.Drawing.Size(37, 13)
        Me.LBL_month.TabIndex = 24
        Me.LBL_month.Text = "Month"
        '
        'LBL_year
        '
        Me.LBL_year.AutoSize = True
        Me.LBL_year.BackColor = System.Drawing.Color.Transparent
        Me.LBL_year.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_year.Location = New System.Drawing.Point(112, 133)
        Me.LBL_year.Name = "LBL_year"
        Me.LBL_year.Size = New System.Drawing.Size(28, 13)
        Me.LBL_year.TabIndex = 22
        Me.LBL_year.Text = "Year"
        '
        'CB_year
        '
        Me.CB_year.BackColor = System.Drawing.SystemColors.Window
        Me.CB_year.Enabled = False
        Me.CB_year.FormattingEnabled = True
        Me.CB_year.Items.AddRange(New Object() {"", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.CB_year.Location = New System.Drawing.Point(114, 105)
        Me.CB_year.Name = "CB_year"
        Me.CB_year.Size = New System.Drawing.Size(98, 27)
        Me.CB_year.TabIndex = 3
        '
        'CB_day
        '
        Me.CB_day.Enabled = False
        Me.CB_day.FormattingEnabled = True
        Me.CB_day.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CB_day.Location = New System.Drawing.Point(285, 105)
        Me.CB_day.Name = "CB_day"
        Me.CB_day.Size = New System.Drawing.Size(61, 27)
        Me.CB_day.TabIndex = 5
        '
        'CB_month
        '
        Me.CB_month.Enabled = False
        Me.CB_month.FormattingEnabled = True
        Me.CB_month.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CB_month.Location = New System.Drawing.Point(218, 105)
        Me.CB_month.Name = "CB_month"
        Me.CB_month.Size = New System.Drawing.Size(61, 27)
        Me.CB_month.TabIndex = 4
        '
        'LBL_cellphone
        '
        Me.LBL_cellphone.AutoSize = True
        Me.LBL_cellphone.Location = New System.Drawing.Point(6, 350)
        Me.LBL_cellphone.Name = "LBL_cellphone"
        Me.LBL_cellphone.Size = New System.Drawing.Size(87, 19)
        Me.LBL_cellphone.TabIndex = 20
        Me.LBL_cellphone.Text = "Cell phone: "
        '
        'LBL_homephone
        '
        Me.LBL_homephone.AutoSize = True
        Me.LBL_homephone.Location = New System.Drawing.Point(5, 317)
        Me.LBL_homephone.Name = "LBL_homephone"
        Me.LBL_homephone.Size = New System.Drawing.Size(103, 19)
        Me.LBL_homephone.TabIndex = 19
        Me.LBL_homephone.Text = "Home phone: "
        '
        'LBL_postalcode
        '
        Me.LBL_postalcode.AutoSize = True
        Me.LBL_postalcode.Location = New System.Drawing.Point(5, 284)
        Me.LBL_postalcode.Name = "LBL_postalcode"
        Me.LBL_postalcode.Size = New System.Drawing.Size(93, 19)
        Me.LBL_postalcode.TabIndex = 18
        Me.LBL_postalcode.Text = "Postal code: "
        '
        'LBL_province
        '
        Me.LBL_province.AutoSize = True
        Me.LBL_province.Location = New System.Drawing.Point(6, 251)
        Me.LBL_province.Name = "LBL_province"
        Me.LBL_province.Size = New System.Drawing.Size(73, 19)
        Me.LBL_province.TabIndex = 17
        Me.LBL_province.Text = "Province: "
        '
        'LBL_city
        '
        Me.LBL_city.AutoSize = True
        Me.LBL_city.Location = New System.Drawing.Point(6, 218)
        Me.LBL_city.Name = "LBL_city"
        Me.LBL_city.Size = New System.Drawing.Size(43, 19)
        Me.LBL_city.TabIndex = 16
        Me.LBL_city.Text = "City: "
        '
        'LBL_address
        '
        Me.LBL_address.AutoSize = True
        Me.LBL_address.Location = New System.Drawing.Point(5, 185)
        Me.LBL_address.Name = "LBL_address"
        Me.LBL_address.Size = New System.Drawing.Size(69, 19)
        Me.LBL_address.TabIndex = 15
        Me.LBL_address.Text = "Address: "
        '
        'LBL_age
        '
        Me.LBL_age.AutoSize = True
        Me.LBL_age.Location = New System.Drawing.Point(5, 152)
        Me.LBL_age.Name = "LBL_age"
        Me.LBL_age.Size = New System.Drawing.Size(40, 19)
        Me.LBL_age.TabIndex = 14
        Me.LBL_age.Text = "Age:"
        '
        'LBL_dob
        '
        Me.LBL_dob.AutoSize = True
        Me.LBL_dob.Location = New System.Drawing.Point(6, 108)
        Me.LBL_dob.Name = "LBL_dob"
        Me.LBL_dob.Size = New System.Drawing.Size(102, 19)
        Me.LBL_dob.TabIndex = 13
        Me.LBL_dob.Text = "Date of birth: "
        '
        'LBL_lastname
        '
        Me.LBL_lastname.AutoSize = True
        Me.LBL_lastname.Location = New System.Drawing.Point(6, 75)
        Me.LBL_lastname.Name = "LBL_lastname"
        Me.LBL_lastname.Size = New System.Drawing.Size(84, 19)
        Me.LBL_lastname.TabIndex = 12
        Me.LBL_lastname.Text = "Last name: "
        '
        'TB_city
        '
        Me.TB_city.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_city.Enabled = False
        Me.TB_city.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_city.Location = New System.Drawing.Point(115, 215)
        Me.TB_city.Name = "TB_city"
        Me.TB_city.Size = New System.Drawing.Size(231, 27)
        Me.TB_city.TabIndex = 8
        '
        'TB_address
        '
        Me.TB_address.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_address.Enabled = False
        Me.TB_address.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_address.Location = New System.Drawing.Point(115, 182)
        Me.TB_address.Name = "TB_address"
        Me.TB_address.Size = New System.Drawing.Size(231, 27)
        Me.TB_address.TabIndex = 7
        '
        'TB_age
        '
        Me.TB_age.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_age.Enabled = False
        Me.TB_age.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_age.Location = New System.Drawing.Point(115, 149)
        Me.TB_age.Name = "TB_age"
        Me.TB_age.Size = New System.Drawing.Size(60, 27)
        Me.TB_age.TabIndex = 6
        '
        'TB_lastname
        '
        Me.TB_lastname.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_lastname.Enabled = False
        Me.TB_lastname.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_lastname.Location = New System.Drawing.Point(115, 72)
        Me.TB_lastname.Name = "TB_lastname"
        Me.TB_lastname.Size = New System.Drawing.Size(231, 27)
        Me.TB_lastname.TabIndex = 2
        '
        'TB_firstname
        '
        Me.TB_firstname.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_firstname.Enabled = False
        Me.TB_firstname.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_firstname.Location = New System.Drawing.Point(115, 39)
        Me.TB_firstname.Name = "TB_firstname"
        Me.TB_firstname.Size = New System.Drawing.Size(231, 27)
        Me.TB_firstname.TabIndex = 1
        '
        'LBL_firstname
        '
        Me.LBL_firstname.AutoSize = True
        Me.LBL_firstname.Location = New System.Drawing.Point(6, 42)
        Me.LBL_firstname.Name = "LBL_firstname"
        Me.LBL_firstname.Size = New System.Drawing.Size(85, 19)
        Me.LBL_firstname.TabIndex = 0
        Me.LBL_firstname.Text = "First name: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_employees, Me.TS_client, Me.TS_video, Me.TS_search, Me.TS_rent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(829, 24)
        Me.MenuStrip1.TabIndex = 36
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
        'TS_client
        '
        Me.TS_client.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_listClient, Me.TS_createClient, Me.TS_editClient, Me.TS_deleteClient})
        Me.TS_client.Name = "TS_client"
        Me.TS_client.Size = New System.Drawing.Size(50, 20)
        Me.TS_client.Text = "Client"
        '
        'TS_listClient
        '
        Me.TS_listClient.Name = "TS_listClient"
        Me.TS_listClient.Size = New System.Drawing.Size(108, 22)
        Me.TS_listClient.Text = "List"
        '
        'TS_createClient
        '
        Me.TS_createClient.Name = "TS_createClient"
        Me.TS_createClient.Size = New System.Drawing.Size(108, 22)
        Me.TS_createClient.Text = "Create"
        '
        'TS_editClient
        '
        Me.TS_editClient.Name = "TS_editClient"
        Me.TS_editClient.Size = New System.Drawing.Size(108, 22)
        Me.TS_editClient.Text = "Edit"
        '
        'TS_deleteClient
        '
        Me.TS_deleteClient.Name = "TS_deleteClient"
        Me.TS_deleteClient.Size = New System.Drawing.Size(108, 22)
        Me.TS_deleteClient.Text = "Delete"
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
        Me.TS_quickSearch.Size = New System.Drawing.Size(153, 22)
        Me.TS_quickSearch.Text = "Quick Search"
        '
        'TS_advancedSearch
        '
        Me.TS_advancedSearch.Name = "TS_advancedSearch"
        Me.TS_advancedSearch.Size = New System.Drawing.Size(153, 22)
        Me.TS_advancedSearch.Text = "Advance Search"
        '
        'TS_rent
        '
        Me.TS_rent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_rentVideo, Me.TS_returnVideo})
        Me.TS_rent.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_rent.Name = "TS_rent"
        Me.TS_rent.Size = New System.Drawing.Size(42, 20)
        Me.TS_rent.Text = "Rent"
        '
        'TS_rentVideo
        '
        Me.TS_rentVideo.Name = "TS_rentVideo"
        Me.TS_rentVideo.Size = New System.Drawing.Size(136, 22)
        Me.TS_rentVideo.Text = "Rent video"
        '
        'TS_returnVideo
        '
        Me.TS_returnVideo.Name = "TS_returnVideo"
        Me.TS_returnVideo.Size = New System.Drawing.Size(136, 22)
        Me.TS_returnVideo.Text = "Return video"
        '
        'EmployeeDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 613)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GB_chooseAnEmployee)
        Me.Controls.Add(Me.GB_systemInformation)
        Me.Controls.Add(Me.GB_humanResources)
        Me.Controls.Add(Me.GB_new)
        Me.Controls.Add(Me.LBL_deleteEmployee)
        Me.Controls.Add(Me.BTN_cancel)
        Me.Controls.Add(Me.BTN_delete)
        Me.Name = "EmployeeDelete"
        Me.Text = "DeleteEmployee"
        Me.GB_chooseAnEmployee.ResumeLayout(False)
        Me.GB_chooseAnEmployee.PerformLayout()
        Me.GB_systemInformation.ResumeLayout(False)
        Me.GB_systemInformation.PerformLayout()
        Me.GB_humanResources.ResumeLayout(False)
        Me.GB_humanResources.PerformLayout()
        Me.GB_new.ResumeLayout(False)
        Me.GB_new.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_deleteEmployee As Label
    Friend WithEvents BTN_cancel As Button
    Friend WithEvents BTN_delete As Button
    Friend WithEvents GB_chooseAnEmployee As GroupBox
    Friend WithEvents CB_chooseEmployee As ComboBox
    Friend WithEvents LBL_chooseEmployee As Label
    Friend WithEvents GB_systemInformation As GroupBox
    Friend WithEvents TB_activeAccount As TextBox
    Friend WithEvents CBOX_activeAccount As CheckBox
    Friend WithEvents LBL_password As Label
    Friend WithEvents LBL_username As Label
    Friend WithEvents LBL_accessLevel As Label
    Friend WithEvents TB_password As TextBox
    Friend WithEvents TB_username As TextBox
    Friend WithEvents CB_accessLevel As ComboBox
    Friend WithEvents GB_humanResources As GroupBox
    Friend WithEvents MTB_sin As MaskedTextBox
    Friend WithEvents LBL_dateStarted As Label
    Friend WithEvents TB_dateStarted As TextBox
    Friend WithEvents LBL_education As Label
    Friend WithEvents CB_education As ComboBox
    Friend WithEvents LBL_hourlyPay As Label
    Friend WithEvents TB_hourlyPay As TextBox
    Friend WithEvents LBL_sin As Label
    Friend WithEvents LBL_employeenumber As Label
    Friend WithEvents TB_employeeNumber As TextBox
    Friend WithEvents GB_new As GroupBox
    Friend WithEvents MTB_cellPhone As MaskedTextBox
    Friend WithEvents MTB_homePhone As MaskedTextBox
    Friend WithEvents MTB_postalCode As MaskedTextBox
    Friend WithEvents CB_province As ComboBox
    Friend WithEvents LBL_day As Label
    Friend WithEvents LBL_month As Label
    Friend WithEvents LBL_year As Label
    Friend WithEvents CB_year As ComboBox
    Friend WithEvents CB_day As ComboBox
    Friend WithEvents CB_month As ComboBox
    Friend WithEvents LBL_cellphone As Label
    Friend WithEvents LBL_homephone As Label
    Friend WithEvents LBL_postalcode As Label
    Friend WithEvents LBL_province As Label
    Friend WithEvents LBL_city As Label
    Friend WithEvents LBL_address As Label
    Friend WithEvents LBL_age As Label
    Friend WithEvents LBL_dob As Label
    Friend WithEvents LBL_lastname As Label
    Friend WithEvents TB_city As TextBox
    Friend WithEvents TB_address As TextBox
    Friend WithEvents TB_age As TextBox
    Friend WithEvents TB_lastname As TextBox
    Friend WithEvents TB_firstname As TextBox
    Friend WithEvents LBL_firstname As Label
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
    Friend WithEvents TS_client As ToolStripMenuItem
    Friend WithEvents TS_listClient As ToolStripMenuItem
    Friend WithEvents TS_createClient As ToolStripMenuItem
    Friend WithEvents TS_editClient As ToolStripMenuItem
    Friend WithEvents TS_deleteClient As ToolStripMenuItem
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
    Friend WithEvents TS_returnVideo As ToolStripMenuItem
End Class
