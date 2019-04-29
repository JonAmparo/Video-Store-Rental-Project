<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientCreate
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
        Me.GB_new = New System.Windows.Forms.GroupBox()
        Me.CB_province = New System.Windows.Forms.ComboBox()
        Me.MTB_postalCode = New System.Windows.Forms.MaskedTextBox()
        Me.MTB_phone = New System.Windows.Forms.MaskedTextBox()
        Me.LBL_day = New System.Windows.Forms.Label()
        Me.LBL_month = New System.Windows.Forms.Label()
        Me.LBL_year = New System.Windows.Forms.Label()
        Me.CB_year = New System.Windows.Forms.ComboBox()
        Me.CB_day = New System.Windows.Forms.ComboBox()
        Me.CB_month = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_postalCode = New System.Windows.Forms.Label()
        Me.LBL_province = New System.Windows.Forms.Label()
        Me.LBL_city = New System.Windows.Forms.Label()
        Me.LBL_address = New System.Windows.Forms.Label()
        Me.LBL_age = New System.Windows.Forms.Label()
        Me.LBL_dob = New System.Windows.Forms.Label()
        Me.LBL_telephone = New System.Windows.Forms.Label()
        Me.LBL_email = New System.Windows.Forms.Label()
        Me.LBL_lastname = New System.Windows.Forms.Label()
        Me.TB_city = New System.Windows.Forms.TextBox()
        Me.TB_address = New System.Windows.Forms.TextBox()
        Me.TB_age = New System.Windows.Forms.TextBox()
        Me.TB_email = New System.Windows.Forms.TextBox()
        Me.TB_lastname = New System.Windows.Forms.TextBox()
        Me.TB_firstname = New System.Windows.Forms.TextBox()
        Me.LBL_firstname = New System.Windows.Forms.Label()
        Me.BTN_create = New System.Windows.Forms.Button()
        Me.BTN_cancel = New System.Windows.Forms.Button()
        Me.LBL_createClient = New System.Windows.Forms.Label()
        Me.GB_creditInformation = New System.Windows.Forms.GroupBox()
        Me.CB_dayExp = New System.Windows.Forms.ComboBox()
        Me.MTB_cardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.CB_typeOfCard = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LBL_star3 = New System.Windows.Forms.Label()
        Me.LBL_star2 = New System.Windows.Forms.Label()
        Me.LBL_star1 = New System.Windows.Forms.Label()
        Me.LBL_expirationDate = New System.Windows.Forms.Label()
        Me.CB_yearExp = New System.Windows.Forms.ComboBox()
        Me.CB_monthExp = New System.Windows.Forms.ComboBox()
        Me.LBL_cardNumber = New System.Windows.Forms.Label()
        Me.LBL_typeOfCard = New System.Windows.Forms.Label()
        Me.GB_systemsInformation = New System.Windows.Forms.GroupBox()
        Me.LBL_clientNumberInformation = New System.Windows.Forms.Label()
        Me.TB_activeAccount = New System.Windows.Forms.TextBox()
        Me.CBOX_activeAccount = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LV_videosRented = New System.Windows.Forms.ListView()
        Me.LBL_videosRented = New System.Windows.Forms.Label()
        Me.LBL_clientNumber = New System.Windows.Forms.Label()
        Me.TB_clientNumber = New System.Windows.Forms.TextBox()
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
        Me.GB_new.SuspendLayout()
        Me.GB_creditInformation.SuspendLayout()
        Me.GB_systemsInformation.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_new
        '
        Me.GB_new.Controls.Add(Me.CB_province)
        Me.GB_new.Controls.Add(Me.MTB_postalCode)
        Me.GB_new.Controls.Add(Me.MTB_phone)
        Me.GB_new.Controls.Add(Me.LBL_day)
        Me.GB_new.Controls.Add(Me.LBL_month)
        Me.GB_new.Controls.Add(Me.LBL_year)
        Me.GB_new.Controls.Add(Me.CB_year)
        Me.GB_new.Controls.Add(Me.CB_day)
        Me.GB_new.Controls.Add(Me.CB_month)
        Me.GB_new.Controls.Add(Me.Label9)
        Me.GB_new.Controls.Add(Me.Label8)
        Me.GB_new.Controls.Add(Me.Label7)
        Me.GB_new.Controls.Add(Me.Label6)
        Me.GB_new.Controls.Add(Me.Label5)
        Me.GB_new.Controls.Add(Me.Label4)
        Me.GB_new.Controls.Add(Me.Label3)
        Me.GB_new.Controls.Add(Me.Label2)
        Me.GB_new.Controls.Add(Me.Label1)
        Me.GB_new.Controls.Add(Me.LBL_postalCode)
        Me.GB_new.Controls.Add(Me.LBL_province)
        Me.GB_new.Controls.Add(Me.LBL_city)
        Me.GB_new.Controls.Add(Me.LBL_address)
        Me.GB_new.Controls.Add(Me.LBL_age)
        Me.GB_new.Controls.Add(Me.LBL_dob)
        Me.GB_new.Controls.Add(Me.LBL_telephone)
        Me.GB_new.Controls.Add(Me.LBL_email)
        Me.GB_new.Controls.Add(Me.LBL_lastname)
        Me.GB_new.Controls.Add(Me.TB_city)
        Me.GB_new.Controls.Add(Me.TB_address)
        Me.GB_new.Controls.Add(Me.TB_age)
        Me.GB_new.Controls.Add(Me.TB_email)
        Me.GB_new.Controls.Add(Me.TB_lastname)
        Me.GB_new.Controls.Add(Me.TB_firstname)
        Me.GB_new.Controls.Add(Me.LBL_firstname)
        Me.GB_new.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_new.Location = New System.Drawing.Point(13, 96)
        Me.GB_new.Name = "GB_new"
        Me.GB_new.Size = New System.Drawing.Size(374, 399)
        Me.GB_new.TabIndex = 1
        Me.GB_new.TabStop = False
        Me.GB_new.Text = "Primary Information"
        '
        'CB_province
        '
        Me.CB_province.FormattingEnabled = True
        Me.CB_province.Items.AddRange(New Object() {"Please choose a province...", "Ontario", "Quebec", "Nova Scotia", "New Brunswick", "Manitoba", "British Columbia", "Prince Edward Island", "Saskatchewan", "Alberta", "Newfoundland and Labrador"})
        Me.CB_province.Location = New System.Drawing.Point(115, 326)
        Me.CB_province.Name = "CB_province"
        Me.CB_province.Size = New System.Drawing.Size(231, 27)
        Me.CB_province.TabIndex = 11
        '
        'MTB_postalCode
        '
        Me.MTB_postalCode.Culture = New System.Globalization.CultureInfo("ca-AD")
        Me.MTB_postalCode.Location = New System.Drawing.Point(115, 359)
        Me.MTB_postalCode.Mask = "A0A 0A0"
        Me.MTB_postalCode.Name = "MTB_postalCode"
        Me.MTB_postalCode.Size = New System.Drawing.Size(232, 27)
        Me.MTB_postalCode.TabIndex = 12
        '
        'MTB_phone
        '
        Me.MTB_phone.Culture = New System.Globalization.CultureInfo("ca-ES")
        Me.MTB_phone.Location = New System.Drawing.Point(115, 138)
        Me.MTB_phone.Mask = "999-000-0000"
        Me.MTB_phone.Name = "MTB_phone"
        Me.MTB_phone.Size = New System.Drawing.Size(232, 27)
        Me.MTB_phone.TabIndex = 4
        '
        'LBL_day
        '
        Me.LBL_day.AutoSize = True
        Me.LBL_day.BackColor = System.Drawing.Color.Transparent
        Me.LBL_day.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_day.Location = New System.Drawing.Point(283, 209)
        Me.LBL_day.Name = "LBL_day"
        Me.LBL_day.Size = New System.Drawing.Size(25, 13)
        Me.LBL_day.TabIndex = 40
        Me.LBL_day.Text = "Day"
        '
        'LBL_month
        '
        Me.LBL_month.AutoSize = True
        Me.LBL_month.BackColor = System.Drawing.Color.Transparent
        Me.LBL_month.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_month.Location = New System.Drawing.Point(216, 207)
        Me.LBL_month.Name = "LBL_month"
        Me.LBL_month.Size = New System.Drawing.Size(37, 13)
        Me.LBL_month.TabIndex = 39
        Me.LBL_month.Text = "Month"
        '
        'LBL_year
        '
        Me.LBL_year.AutoSize = True
        Me.LBL_year.BackColor = System.Drawing.Color.Transparent
        Me.LBL_year.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_year.Location = New System.Drawing.Point(112, 207)
        Me.LBL_year.Name = "LBL_year"
        Me.LBL_year.Size = New System.Drawing.Size(28, 13)
        Me.LBL_year.TabIndex = 38
        Me.LBL_year.Text = "Year"
        '
        'CB_year
        '
        Me.CB_year.FormattingEnabled = True
        Me.CB_year.Items.AddRange(New Object() {"", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.CB_year.Location = New System.Drawing.Point(115, 177)
        Me.CB_year.Name = "CB_year"
        Me.CB_year.Size = New System.Drawing.Size(98, 27)
        Me.CB_year.TabIndex = 5
        '
        'CB_day
        '
        Me.CB_day.FormattingEnabled = True
        Me.CB_day.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CB_day.Location = New System.Drawing.Point(286, 177)
        Me.CB_day.Name = "CB_day"
        Me.CB_day.Size = New System.Drawing.Size(61, 27)
        Me.CB_day.TabIndex = 7
        '
        'CB_month
        '
        Me.CB_month.FormattingEnabled = True
        Me.CB_month.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CB_month.Location = New System.Drawing.Point(219, 177)
        Me.CB_month.Name = "CB_month"
        Me.CB_month.Size = New System.Drawing.Size(61, 27)
        Me.CB_month.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Firebrick
        Me.Label9.Location = New System.Drawing.Point(350, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 19)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(350, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Firebrick
        Me.Label7.Location = New System.Drawing.Point(350, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(350, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(351, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(350, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(350, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(350, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(350, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "*"
        '
        'LBL_postalCode
        '
        Me.LBL_postalCode.AutoSize = True
        Me.LBL_postalCode.Location = New System.Drawing.Point(6, 362)
        Me.LBL_postalCode.Name = "LBL_postalCode"
        Me.LBL_postalCode.Size = New System.Drawing.Size(93, 19)
        Me.LBL_postalCode.TabIndex = 20
        Me.LBL_postalCode.Text = "Postal code: "
        '
        'LBL_province
        '
        Me.LBL_province.AutoSize = True
        Me.LBL_province.Location = New System.Drawing.Point(6, 329)
        Me.LBL_province.Name = "LBL_province"
        Me.LBL_province.Size = New System.Drawing.Size(73, 19)
        Me.LBL_province.TabIndex = 19
        Me.LBL_province.Text = "Province: "
        '
        'LBL_city
        '
        Me.LBL_city.AutoSize = True
        Me.LBL_city.Location = New System.Drawing.Point(6, 296)
        Me.LBL_city.Name = "LBL_city"
        Me.LBL_city.Size = New System.Drawing.Size(40, 19)
        Me.LBL_city.TabIndex = 18
        Me.LBL_city.Text = "City:"
        '
        'LBL_address
        '
        Me.LBL_address.AutoSize = True
        Me.LBL_address.Location = New System.Drawing.Point(6, 262)
        Me.LBL_address.Name = "LBL_address"
        Me.LBL_address.Size = New System.Drawing.Size(69, 19)
        Me.LBL_address.TabIndex = 17
        Me.LBL_address.Text = "Address: "
        '
        'LBL_age
        '
        Me.LBL_age.AutoSize = True
        Me.LBL_age.Location = New System.Drawing.Point(6, 229)
        Me.LBL_age.Name = "LBL_age"
        Me.LBL_age.Size = New System.Drawing.Size(40, 19)
        Me.LBL_age.TabIndex = 16
        Me.LBL_age.Text = "Age:"
        '
        'LBL_dob
        '
        Me.LBL_dob.AutoSize = True
        Me.LBL_dob.Location = New System.Drawing.Point(6, 182)
        Me.LBL_dob.Name = "LBL_dob"
        Me.LBL_dob.Size = New System.Drawing.Size(99, 19)
        Me.LBL_dob.TabIndex = 15
        Me.LBL_dob.Text = "Date of birth:"
        '
        'LBL_telephone
        '
        Me.LBL_telephone.AutoSize = True
        Me.LBL_telephone.Location = New System.Drawing.Point(6, 141)
        Me.LBL_telephone.Name = "LBL_telephone"
        Me.LBL_telephone.Size = New System.Drawing.Size(84, 19)
        Me.LBL_telephone.TabIndex = 14
        Me.LBL_telephone.Text = "Telephone:"
        '
        'LBL_email
        '
        Me.LBL_email.AutoSize = True
        Me.LBL_email.Location = New System.Drawing.Point(6, 108)
        Me.LBL_email.Name = "LBL_email"
        Me.LBL_email.Size = New System.Drawing.Size(54, 19)
        Me.LBL_email.TabIndex = 13
        Me.LBL_email.Text = "Email: "
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
        Me.TB_city.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_city.Location = New System.Drawing.Point(115, 293)
        Me.TB_city.Name = "TB_city"
        Me.TB_city.Size = New System.Drawing.Size(231, 27)
        Me.TB_city.TabIndex = 10
        '
        'TB_address
        '
        Me.TB_address.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_address.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_address.Location = New System.Drawing.Point(115, 259)
        Me.TB_address.Name = "TB_address"
        Me.TB_address.Size = New System.Drawing.Size(231, 27)
        Me.TB_address.TabIndex = 9
        '
        'TB_age
        '
        Me.TB_age.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_age.Enabled = False
        Me.TB_age.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_age.Location = New System.Drawing.Point(115, 226)
        Me.TB_age.Name = "TB_age"
        Me.TB_age.Size = New System.Drawing.Size(68, 27)
        Me.TB_age.TabIndex = 8
        '
        'TB_email
        '
        Me.TB_email.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_email.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_email.Location = New System.Drawing.Point(115, 105)
        Me.TB_email.Name = "TB_email"
        Me.TB_email.Size = New System.Drawing.Size(231, 27)
        Me.TB_email.TabIndex = 3
        '
        'TB_lastname
        '
        Me.TB_lastname.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_lastname.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_lastname.Location = New System.Drawing.Point(115, 72)
        Me.TB_lastname.Name = "TB_lastname"
        Me.TB_lastname.Size = New System.Drawing.Size(231, 27)
        Me.TB_lastname.TabIndex = 2
        '
        'TB_firstname
        '
        Me.TB_firstname.Cursor = System.Windows.Forms.Cursors.Default
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
        'BTN_create
        '
        Me.BTN_create.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_create.Location = New System.Drawing.Point(404, 501)
        Me.BTN_create.Name = "BTN_create"
        Me.BTN_create.Size = New System.Drawing.Size(155, 40)
        Me.BTN_create.TabIndex = 19
        Me.BTN_create.Text = "Create"
        Me.BTN_create.UseVisualStyleBackColor = True
        '
        'BTN_cancel
        '
        Me.BTN_cancel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_cancel.Location = New System.Drawing.Point(227, 501)
        Me.BTN_cancel.Name = "BTN_cancel"
        Me.BTN_cancel.Size = New System.Drawing.Size(155, 40)
        Me.BTN_cancel.TabIndex = 17
        Me.BTN_cancel.Text = "Cancel"
        Me.BTN_cancel.UseVisualStyleBackColor = True
        '
        'LBL_createClient
        '
        Me.LBL_createClient.AutoSize = True
        Me.LBL_createClient.Font = New System.Drawing.Font("Corbel", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_createClient.Location = New System.Drawing.Point(247, 34)
        Me.LBL_createClient.Name = "LBL_createClient"
        Me.LBL_createClient.Size = New System.Drawing.Size(282, 59)
        Me.LBL_createClient.TabIndex = 2
        Me.LBL_createClient.Text = "Create Client"
        '
        'GB_creditInformation
        '
        Me.GB_creditInformation.Controls.Add(Me.CB_dayExp)
        Me.GB_creditInformation.Controls.Add(Me.MTB_cardNumber)
        Me.GB_creditInformation.Controls.Add(Me.CB_typeOfCard)
        Me.GB_creditInformation.Controls.Add(Me.Label13)
        Me.GB_creditInformation.Controls.Add(Me.Label12)
        Me.GB_creditInformation.Controls.Add(Me.LBL_star3)
        Me.GB_creditInformation.Controls.Add(Me.LBL_star2)
        Me.GB_creditInformation.Controls.Add(Me.LBL_star1)
        Me.GB_creditInformation.Controls.Add(Me.LBL_expirationDate)
        Me.GB_creditInformation.Controls.Add(Me.CB_yearExp)
        Me.GB_creditInformation.Controls.Add(Me.CB_monthExp)
        Me.GB_creditInformation.Controls.Add(Me.LBL_cardNumber)
        Me.GB_creditInformation.Controls.Add(Me.LBL_typeOfCard)
        Me.GB_creditInformation.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_creditInformation.Location = New System.Drawing.Point(404, 125)
        Me.GB_creditInformation.Name = "GB_creditInformation"
        Me.GB_creditInformation.Size = New System.Drawing.Size(367, 157)
        Me.GB_creditInformation.TabIndex = 3
        Me.GB_creditInformation.TabStop = False
        Me.GB_creditInformation.Text = "Credit Information"
        '
        'CB_dayExp
        '
        Me.CB_dayExp.Enabled = False
        Me.CB_dayExp.FormattingEnabled = True
        Me.CB_dayExp.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CB_dayExp.Location = New System.Drawing.Point(302, 111)
        Me.CB_dayExp.Name = "CB_dayExp"
        Me.CB_dayExp.Size = New System.Drawing.Size(59, 27)
        Me.CB_dayExp.TabIndex = 46
        Me.CB_dayExp.Visible = False
        '
        'MTB_cardNumber
        '
        Me.MTB_cardNumber.Culture = New System.Globalization.CultureInfo("ca-AD")
        Me.MTB_cardNumber.Location = New System.Drawing.Point(111, 75)
        Me.MTB_cardNumber.Mask = "0000-0000-0000-0000"
        Me.MTB_cardNumber.Name = "MTB_cardNumber"
        Me.MTB_cardNumber.Size = New System.Drawing.Size(232, 27)
        Me.MTB_cardNumber.TabIndex = 14
        '
        'CB_typeOfCard
        '
        Me.CB_typeOfCard.FormattingEnabled = True
        Me.CB_typeOfCard.Items.AddRange(New Object() {"Please choose a your card...", "Mastercard", "Visa"})
        Me.CB_typeOfCard.Location = New System.Drawing.Point(111, 39)
        Me.CB_typeOfCard.Name = "CB_typeOfCard"
        Me.CB_typeOfCard.Size = New System.Drawing.Size(231, 27)
        Me.CB_typeOfCard.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(127, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Year"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(214, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Month"
        '
        'LBL_star3
        '
        Me.LBL_star3.AutoSize = True
        Me.LBL_star3.BackColor = System.Drawing.Color.Transparent
        Me.LBL_star3.ForeColor = System.Drawing.Color.Firebrick
        Me.LBL_star3.Location = New System.Drawing.Point(282, 111)
        Me.LBL_star3.Name = "LBL_star3"
        Me.LBL_star3.Size = New System.Drawing.Size(18, 19)
        Me.LBL_star3.TabIndex = 29
        Me.LBL_star3.Text = "*"
        Me.LBL_star3.Visible = False
        '
        'LBL_star2
        '
        Me.LBL_star2.AutoSize = True
        Me.LBL_star2.BackColor = System.Drawing.Color.Transparent
        Me.LBL_star2.ForeColor = System.Drawing.Color.Firebrick
        Me.LBL_star2.Location = New System.Drawing.Point(343, 75)
        Me.LBL_star2.Name = "LBL_star2"
        Me.LBL_star2.Size = New System.Drawing.Size(18, 19)
        Me.LBL_star2.TabIndex = 28
        Me.LBL_star2.Text = "*"
        Me.LBL_star2.Visible = False
        '
        'LBL_star1
        '
        Me.LBL_star1.AutoSize = True
        Me.LBL_star1.BackColor = System.Drawing.Color.Transparent
        Me.LBL_star1.ForeColor = System.Drawing.Color.Firebrick
        Me.LBL_star1.Location = New System.Drawing.Point(343, 39)
        Me.LBL_star1.Name = "LBL_star1"
        Me.LBL_star1.Size = New System.Drawing.Size(18, 19)
        Me.LBL_star1.TabIndex = 27
        Me.LBL_star1.Text = "*"
        Me.LBL_star1.Visible = False
        '
        'LBL_expirationDate
        '
        Me.LBL_expirationDate.AutoSize = True
        Me.LBL_expirationDate.Location = New System.Drawing.Point(6, 111)
        Me.LBL_expirationDate.Name = "LBL_expirationDate"
        Me.LBL_expirationDate.Size = New System.Drawing.Size(116, 19)
        Me.LBL_expirationDate.TabIndex = 8
        Me.LBL_expirationDate.Text = "Expiration date:"
        '
        'CB_yearExp
        '
        Me.CB_yearExp.FormattingEnabled = True
        Me.CB_yearExp.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.CB_yearExp.Location = New System.Drawing.Point(128, 111)
        Me.CB_yearExp.Name = "CB_yearExp"
        Me.CB_yearExp.Size = New System.Drawing.Size(83, 27)
        Me.CB_yearExp.TabIndex = 15
        '
        'CB_monthExp
        '
        Me.CB_monthExp.FormattingEnabled = True
        Me.CB_monthExp.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CB_monthExp.Location = New System.Drawing.Point(217, 111)
        Me.CB_monthExp.Name = "CB_monthExp"
        Me.CB_monthExp.Size = New System.Drawing.Size(59, 27)
        Me.CB_monthExp.TabIndex = 16
        '
        'LBL_cardNumber
        '
        Me.LBL_cardNumber.AutoSize = True
        Me.LBL_cardNumber.Location = New System.Drawing.Point(6, 78)
        Me.LBL_cardNumber.Name = "LBL_cardNumber"
        Me.LBL_cardNumber.Size = New System.Drawing.Size(98, 19)
        Me.LBL_cardNumber.TabIndex = 5
        Me.LBL_cardNumber.Text = "Card number:"
        '
        'LBL_typeOfCard
        '
        Me.LBL_typeOfCard.AutoSize = True
        Me.LBL_typeOfCard.Location = New System.Drawing.Point(6, 42)
        Me.LBL_typeOfCard.Name = "LBL_typeOfCard"
        Me.LBL_typeOfCard.Size = New System.Drawing.Size(95, 19)
        Me.LBL_typeOfCard.TabIndex = 3
        Me.LBL_typeOfCard.Text = "Type of card:"
        '
        'GB_systemsInformation
        '
        Me.GB_systemsInformation.Controls.Add(Me.LBL_clientNumberInformation)
        Me.GB_systemsInformation.Controls.Add(Me.TB_activeAccount)
        Me.GB_systemsInformation.Controls.Add(Me.CBOX_activeAccount)
        Me.GB_systemsInformation.Controls.Add(Me.Label11)
        Me.GB_systemsInformation.Controls.Add(Me.LV_videosRented)
        Me.GB_systemsInformation.Controls.Add(Me.LBL_videosRented)
        Me.GB_systemsInformation.Controls.Add(Me.LBL_clientNumber)
        Me.GB_systemsInformation.Controls.Add(Me.TB_clientNumber)
        Me.GB_systemsInformation.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_systemsInformation.Location = New System.Drawing.Point(404, 325)
        Me.GB_systemsInformation.Name = "GB_systemsInformation"
        Me.GB_systemsInformation.Size = New System.Drawing.Size(367, 170)
        Me.GB_systemsInformation.TabIndex = 4
        Me.GB_systemsInformation.TabStop = False
        Me.GB_systemsInformation.Text = "System Information"
        '
        'LBL_clientNumberInformation
        '
        Me.LBL_clientNumberInformation.AutoSize = True
        Me.LBL_clientNumberInformation.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_clientNumberInformation.Location = New System.Drawing.Point(6, 86)
        Me.LBL_clientNumberInformation.Name = "LBL_clientNumberInformation"
        Me.LBL_clientNumberInformation.Size = New System.Drawing.Size(318, 30)
        Me.LBL_clientNumberInformation.TabIndex = 30
        Me.LBL_clientNumberInformation.Text = "Note: Client number will be auto generated as soon as you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " succesfully created y" &
    "our client account."
        '
        'TB_activeAccount
        '
        Me.TB_activeAccount.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_activeAccount.Enabled = False
        Me.TB_activeAccount.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_activeAccount.Location = New System.Drawing.Point(136, 138)
        Me.TB_activeAccount.Name = "TB_activeAccount"
        Me.TB_activeAccount.Size = New System.Drawing.Size(231, 27)
        Me.TB_activeAccount.TabIndex = 29
        Me.TB_activeAccount.TabStop = False
        Me.TB_activeAccount.Visible = False
        '
        'CBOX_activeAccount
        '
        Me.CBOX_activeAccount.AutoSize = True
        Me.CBOX_activeAccount.Location = New System.Drawing.Point(10, 140)
        Me.CBOX_activeAccount.Name = "CBOX_activeAccount"
        Me.CBOX_activeAccount.Size = New System.Drawing.Size(127, 23)
        Me.CBOX_activeAccount.TabIndex = 18
        Me.CBOX_activeAccount.Text = "Active Account"
        Me.CBOX_activeAccount.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Firebrick
        Me.Label11.Location = New System.Drawing.Point(348, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 19)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "*"
        '
        'LV_videosRented
        '
        Me.LV_videosRented.Location = New System.Drawing.Point(10, 112)
        Me.LV_videosRented.Name = "LV_videosRented"
        Me.LV_videosRented.Size = New System.Drawing.Size(341, 22)
        Me.LV_videosRented.TabIndex = 16
        Me.LV_videosRented.UseCompatibleStateImageBehavior = False
        Me.LV_videosRented.Visible = False
        '
        'LBL_videosRented
        '
        Me.LBL_videosRented.AutoSize = True
        Me.LBL_videosRented.BackColor = System.Drawing.Color.Transparent
        Me.LBL_videosRented.Location = New System.Drawing.Point(6, 90)
        Me.LBL_videosRented.Name = "LBL_videosRented"
        Me.LBL_videosRented.Size = New System.Drawing.Size(106, 19)
        Me.LBL_videosRented.TabIndex = 5
        Me.LBL_videosRented.Text = "Videos rented:"
        Me.LBL_videosRented.Visible = False
        '
        'LBL_clientNumber
        '
        Me.LBL_clientNumber.AutoSize = True
        Me.LBL_clientNumber.BackColor = System.Drawing.Color.Transparent
        Me.LBL_clientNumber.Location = New System.Drawing.Point(-1, 52)
        Me.LBL_clientNumber.Name = "LBL_clientNumber"
        Me.LBL_clientNumber.Size = New System.Drawing.Size(106, 19)
        Me.LBL_clientNumber.TabIndex = 4
        Me.LBL_clientNumber.Text = "Client number:"
        '
        'TB_clientNumber
        '
        Me.TB_clientNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_clientNumber.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_clientNumber.Location = New System.Drawing.Point(111, 49)
        Me.TB_clientNumber.Name = "TB_clientNumber"
        Me.TB_clientNumber.Size = New System.Drawing.Size(231, 27)
        Me.TB_clientNumber.TabIndex = 17
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_employees, Me.TS_client, Me.TS_video, Me.TS_search, Me.TS_rent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 24)
        Me.MenuStrip1.TabIndex = 19
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
        'ClientCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(788, 553)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GB_systemsInformation)
        Me.Controls.Add(Me.GB_creditInformation)
        Me.Controls.Add(Me.LBL_createClient)
        Me.Controls.Add(Me.GB_new)
        Me.Controls.Add(Me.BTN_create)
        Me.Controls.Add(Me.BTN_cancel)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ClientCreate"
        Me.Text = "CreateClient"
        Me.GB_new.ResumeLayout(False)
        Me.GB_new.PerformLayout()
        Me.GB_creditInformation.ResumeLayout(False)
        Me.GB_creditInformation.PerformLayout()
        Me.GB_systemsInformation.ResumeLayout(False)
        Me.GB_systemsInformation.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_new As GroupBox
    Friend WithEvents BTN_create As Button
    Friend WithEvents BTN_cancel As Button
    Friend WithEvents LBL_postalCode As Label
    Friend WithEvents LBL_province As Label
    Friend WithEvents LBL_city As Label
    Friend WithEvents LBL_address As Label
    Friend WithEvents LBL_age As Label
    Friend WithEvents LBL_dob As Label
    Friend WithEvents LBL_telephone As Label
    Friend WithEvents LBL_email As Label
    Friend WithEvents LBL_lastname As Label
    Friend WithEvents TB_city As TextBox
    Friend WithEvents TB_address As TextBox
    Friend WithEvents TB_age As TextBox
    Friend WithEvents TB_email As TextBox
    Friend WithEvents TB_lastname As TextBox
    Friend WithEvents TB_firstname As TextBox
    Friend WithEvents LBL_firstname As Label
    Friend WithEvents LBL_createClient As Label
    Friend WithEvents GB_creditInformation As GroupBox
    Friend WithEvents LBL_expirationDate As Label
    Friend WithEvents CB_yearExp As ComboBox
    Friend WithEvents CB_monthExp As ComboBox
    Friend WithEvents LBL_cardNumber As Label
    Friend WithEvents LBL_typeOfCard As Label
    Friend WithEvents GB_systemsInformation As GroupBox
    Friend WithEvents LBL_clientNumber As Label
    Friend WithEvents TB_clientNumber As TextBox
    Friend WithEvents LV_videosRented As ListView
    Friend WithEvents LBL_videosRented As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBL_star3 As Label
    Friend WithEvents LBL_star2 As Label
    Friend WithEvents LBL_star1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LBL_day As Label
    Friend WithEvents LBL_month As Label
    Friend WithEvents LBL_year As Label
    Friend WithEvents CB_year As ComboBox
    Friend WithEvents CB_day As ComboBox
    Friend WithEvents CB_month As ComboBox
    Friend WithEvents MTB_phone As MaskedTextBox
    Friend WithEvents MTB_postalCode As MaskedTextBox
    Friend WithEvents CB_province As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CBOX_activeAccount As CheckBox
    Friend WithEvents TB_activeAccount As TextBox
    Friend WithEvents CB_typeOfCard As ComboBox
    Friend WithEvents MTB_cardNumber As MaskedTextBox
    Friend WithEvents CB_dayExp As ComboBox
    Friend WithEvents LBL_clientNumberInformation As Label
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
