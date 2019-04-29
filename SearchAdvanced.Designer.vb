<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchAdvanced
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
        Me.GB_advancedSearch = New System.Windows.Forms.GroupBox()
        Me.LBL_minutes = New System.Windows.Forms.Label()
        Me.NUD_length2 = New System.Windows.Forms.NumericUpDown()
        Me.LBL_to = New System.Windows.Forms.Label()
        Me.NUD_length1 = New System.Windows.Forms.NumericUpDown()
        Me.CB_year = New System.Windows.Forms.ComboBox()
        Me.LBL_description = New System.Windows.Forms.Label()
        Me.LBL_actors = New System.Windows.Forms.Label()
        Me.LBL_director = New System.Windows.Forms.Label()
        Me.LBL_length = New System.Windows.Forms.Label()
        Me.LBL_country = New System.Windows.Forms.Label()
        Me.LBL_language = New System.Windows.Forms.Label()
        Me.LBL_year = New System.Windows.Forms.Label()
        Me.TB_description = New System.Windows.Forms.TextBox()
        Me.TB_actors = New System.Windows.Forms.TextBox()
        Me.TB_director = New System.Windows.Forms.TextBox()
        Me.TB_country = New System.Windows.Forms.TextBox()
        Me.TB_language = New System.Windows.Forms.TextBox()
        Me.BTN_search = New System.Windows.Forms.Button()
        Me.BTN_cancel = New System.Windows.Forms.Button()
        Me.LBL_genre = New System.Windows.Forms.Label()
        Me.TB_genre = New System.Windows.Forms.TextBox()
        Me.TB_title = New System.Windows.Forms.TextBox()
        Me.LBL_title = New System.Windows.Forms.Label()
        Me.LBL_advancedSearch = New System.Windows.Forms.Label()
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
        Me.GB_advancedSearch.SuspendLayout()
        CType(Me.NUD_length2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_length1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_advancedSearch
        '
        Me.GB_advancedSearch.Controls.Add(Me.LBL_minutes)
        Me.GB_advancedSearch.Controls.Add(Me.NUD_length2)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_to)
        Me.GB_advancedSearch.Controls.Add(Me.NUD_length1)
        Me.GB_advancedSearch.Controls.Add(Me.CB_year)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_description)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_actors)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_director)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_length)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_country)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_language)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_year)
        Me.GB_advancedSearch.Controls.Add(Me.TB_description)
        Me.GB_advancedSearch.Controls.Add(Me.TB_actors)
        Me.GB_advancedSearch.Controls.Add(Me.TB_director)
        Me.GB_advancedSearch.Controls.Add(Me.TB_country)
        Me.GB_advancedSearch.Controls.Add(Me.TB_language)
        Me.GB_advancedSearch.Controls.Add(Me.BTN_search)
        Me.GB_advancedSearch.Controls.Add(Me.BTN_cancel)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_genre)
        Me.GB_advancedSearch.Controls.Add(Me.TB_genre)
        Me.GB_advancedSearch.Controls.Add(Me.TB_title)
        Me.GB_advancedSearch.Controls.Add(Me.LBL_title)
        Me.GB_advancedSearch.Location = New System.Drawing.Point(14, 86)
        Me.GB_advancedSearch.Name = "GB_advancedSearch"
        Me.GB_advancedSearch.Size = New System.Drawing.Size(405, 473)
        Me.GB_advancedSearch.TabIndex = 33
        Me.GB_advancedSearch.TabStop = False
        '
        'LBL_minutes
        '
        Me.LBL_minutes.AutoSize = True
        Me.LBL_minutes.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_minutes.Location = New System.Drawing.Point(311, 220)
        Me.LBL_minutes.Name = "LBL_minutes"
        Me.LBL_minutes.Size = New System.Drawing.Size(51, 15)
        Me.LBL_minutes.TabIndex = 51
        Me.LBL_minutes.Text = "minutes"
        '
        'NUD_length2
        '
        Me.NUD_length2.Location = New System.Drawing.Point(234, 214)
        Me.NUD_length2.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NUD_length2.Name = "NUD_length2"
        Me.NUD_length2.Size = New System.Drawing.Size(71, 21)
        Me.NUD_length2.TabIndex = 7
        '
        'LBL_to
        '
        Me.LBL_to.AutoSize = True
        Me.LBL_to.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_to.Location = New System.Drawing.Point(209, 216)
        Me.LBL_to.Name = "LBL_to"
        Me.LBL_to.Size = New System.Drawing.Size(19, 15)
        Me.LBL_to.TabIndex = 49
        Me.LBL_to.Text = "to"
        '
        'NUD_length1
        '
        Me.NUD_length1.Location = New System.Drawing.Point(132, 214)
        Me.NUD_length1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NUD_length1.Name = "NUD_length1"
        Me.NUD_length1.Size = New System.Drawing.Size(71, 21)
        Me.NUD_length1.TabIndex = 6
        '
        'CB_year
        '
        Me.CB_year.FormattingEnabled = True
        Me.CB_year.Items.AddRange(New Object() {"", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.CB_year.Location = New System.Drawing.Point(132, 108)
        Me.CB_year.Name = "CB_year"
        Me.CB_year.Size = New System.Drawing.Size(248, 21)
        Me.CB_year.TabIndex = 3
        '
        'LBL_description
        '
        Me.LBL_description.AutoSize = True
        Me.LBL_description.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_description.Location = New System.Drawing.Point(7, 316)
        Me.LBL_description.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_description.Name = "LBL_description"
        Me.LBL_description.Size = New System.Drawing.Size(90, 19)
        Me.LBL_description.TabIndex = 46
        Me.LBL_description.Text = "Description:"
        '
        'LBL_actors
        '
        Me.LBL_actors.AutoSize = True
        Me.LBL_actors.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_actors.Location = New System.Drawing.Point(7, 281)
        Me.LBL_actors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_actors.Name = "LBL_actors"
        Me.LBL_actors.Size = New System.Drawing.Size(56, 19)
        Me.LBL_actors.TabIndex = 45
        Me.LBL_actors.Text = "Actors:"
        '
        'LBL_director
        '
        Me.LBL_director.AutoSize = True
        Me.LBL_director.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_director.Location = New System.Drawing.Point(7, 246)
        Me.LBL_director.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_director.Name = "LBL_director"
        Me.LBL_director.Size = New System.Drawing.Size(71, 19)
        Me.LBL_director.TabIndex = 44
        Me.LBL_director.Text = "Director: "
        '
        'LBL_length
        '
        Me.LBL_length.AutoSize = True
        Me.LBL_length.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_length.Location = New System.Drawing.Point(7, 211)
        Me.LBL_length.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_length.Name = "LBL_length"
        Me.LBL_length.Size = New System.Drawing.Size(61, 19)
        Me.LBL_length.TabIndex = 43
        Me.LBL_length.Text = "Length:"
        '
        'LBL_country
        '
        Me.LBL_country.AutoSize = True
        Me.LBL_country.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_country.Location = New System.Drawing.Point(7, 176)
        Me.LBL_country.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_country.Name = "LBL_country"
        Me.LBL_country.Size = New System.Drawing.Size(66, 19)
        Me.LBL_country.TabIndex = 42
        Me.LBL_country.Text = "Country:"
        '
        'LBL_language
        '
        Me.LBL_language.AutoSize = True
        Me.LBL_language.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_language.Location = New System.Drawing.Point(7, 141)
        Me.LBL_language.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_language.Name = "LBL_language"
        Me.LBL_language.Size = New System.Drawing.Size(79, 19)
        Me.LBL_language.TabIndex = 41
        Me.LBL_language.Text = "Language:"
        '
        'LBL_year
        '
        Me.LBL_year.AutoSize = True
        Me.LBL_year.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_year.Location = New System.Drawing.Point(7, 106)
        Me.LBL_year.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_year.Name = "LBL_year"
        Me.LBL_year.Size = New System.Drawing.Size(43, 19)
        Me.LBL_year.TabIndex = 40
        Me.LBL_year.Text = "Year:"
        '
        'TB_description
        '
        Me.TB_description.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_description.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_description.Location = New System.Drawing.Point(129, 313)
        Me.TB_description.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_description.Multiline = True
        Me.TB_description.Name = "TB_description"
        Me.TB_description.Size = New System.Drawing.Size(248, 92)
        Me.TB_description.TabIndex = 10
        '
        'TB_actors
        '
        Me.TB_actors.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_actors.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_actors.Location = New System.Drawing.Point(132, 278)
        Me.TB_actors.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_actors.Name = "TB_actors"
        Me.TB_actors.Size = New System.Drawing.Size(248, 27)
        Me.TB_actors.TabIndex = 9
        '
        'TB_director
        '
        Me.TB_director.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_director.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_director.Location = New System.Drawing.Point(132, 243)
        Me.TB_director.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_director.Name = "TB_director"
        Me.TB_director.Size = New System.Drawing.Size(248, 27)
        Me.TB_director.TabIndex = 8
        '
        'TB_country
        '
        Me.TB_country.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_country.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_country.Location = New System.Drawing.Point(132, 173)
        Me.TB_country.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_country.Name = "TB_country"
        Me.TB_country.Size = New System.Drawing.Size(248, 27)
        Me.TB_country.TabIndex = 5
        '
        'TB_language
        '
        Me.TB_language.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_language.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_language.Location = New System.Drawing.Point(132, 138)
        Me.TB_language.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_language.Name = "TB_language"
        Me.TB_language.Size = New System.Drawing.Size(248, 27)
        Me.TB_language.TabIndex = 4
        '
        'BTN_search
        '
        Me.BTN_search.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_search.Location = New System.Drawing.Point(201, 427)
        Me.BTN_search.Name = "BTN_search"
        Me.BTN_search.Size = New System.Drawing.Size(155, 40)
        Me.BTN_search.TabIndex = 11
        Me.BTN_search.Text = "Search"
        Me.BTN_search.UseVisualStyleBackColor = True
        '
        'BTN_cancel
        '
        Me.BTN_cancel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_cancel.Location = New System.Drawing.Point(26, 427)
        Me.BTN_cancel.Name = "BTN_cancel"
        Me.BTN_cancel.Size = New System.Drawing.Size(155, 40)
        Me.BTN_cancel.TabIndex = 31
        Me.BTN_cancel.Text = "Cancel"
        Me.BTN_cancel.UseVisualStyleBackColor = True
        '
        'LBL_genre
        '
        Me.LBL_genre.AutoSize = True
        Me.LBL_genre.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_genre.Location = New System.Drawing.Point(7, 71)
        Me.LBL_genre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_genre.Name = "LBL_genre"
        Me.LBL_genre.Size = New System.Drawing.Size(53, 19)
        Me.LBL_genre.TabIndex = 30
        Me.LBL_genre.Text = "Genre:"
        '
        'TB_genre
        '
        Me.TB_genre.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_genre.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_genre.Location = New System.Drawing.Point(132, 68)
        Me.TB_genre.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_genre.Name = "TB_genre"
        Me.TB_genre.Size = New System.Drawing.Size(248, 27)
        Me.TB_genre.TabIndex = 2
        '
        'TB_title
        '
        Me.TB_title.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_title.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_title.Location = New System.Drawing.Point(132, 33)
        Me.TB_title.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_title.Name = "TB_title"
        Me.TB_title.Size = New System.Drawing.Size(248, 27)
        Me.TB_title.TabIndex = 1
        '
        'LBL_title
        '
        Me.LBL_title.AutoSize = True
        Me.LBL_title.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_title.Location = New System.Drawing.Point(7, 36)
        Me.LBL_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_title.Name = "LBL_title"
        Me.LBL_title.Size = New System.Drawing.Size(44, 19)
        Me.LBL_title.TabIndex = 27
        Me.LBL_title.Text = "Title:"
        '
        'LBL_advancedSearch
        '
        Me.LBL_advancedSearch.AutoSize = True
        Me.LBL_advancedSearch.Font = New System.Drawing.Font("Corbel", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_advancedSearch.Location = New System.Drawing.Point(30, 24)
        Me.LBL_advancedSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_advancedSearch.Name = "LBL_advancedSearch"
        Me.LBL_advancedSearch.Size = New System.Drawing.Size(370, 59)
        Me.LBL_advancedSearch.TabIndex = 32
        Me.LBL_advancedSearch.Text = "Advanced Search"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_employees, Me.TS_client, Me.TS_video, Me.TS_search, Me.TS_rent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(431, 24)
        Me.MenuStrip1.TabIndex = 34
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
        'SearchAdvanced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 571)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GB_advancedSearch)
        Me.Controls.Add(Me.LBL_advancedSearch)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SearchAdvanced"
        Me.Text = "SearchAdvanced"
        Me.GB_advancedSearch.ResumeLayout(False)
        Me.GB_advancedSearch.PerformLayout()
        CType(Me.NUD_length2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_length1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_advancedSearch As GroupBox
    Friend WithEvents BTN_search As Button
    Friend WithEvents BTN_cancel As Button
    Friend WithEvents LBL_genre As Label
    Friend WithEvents TB_genre As TextBox
    Friend WithEvents TB_title As TextBox
    Friend WithEvents LBL_title As Label
    Friend WithEvents LBL_advancedSearch As Label
    Friend WithEvents TB_description As TextBox
    Friend WithEvents TB_actors As TextBox
    Friend WithEvents TB_director As TextBox
    Friend WithEvents TB_country As TextBox
    Friend WithEvents TB_language As TextBox
    Friend WithEvents LBL_description As Label
    Friend WithEvents LBL_actors As Label
    Friend WithEvents LBL_director As Label
    Friend WithEvents LBL_length As Label
    Friend WithEvents LBL_country As Label
    Friend WithEvents LBL_language As Label
    Friend WithEvents LBL_year As Label
    Friend WithEvents CB_year As ComboBox
    Friend WithEvents LBL_minutes As Label
    Friend WithEvents NUD_length2 As NumericUpDown
    Friend WithEvents LBL_to As Label
    Friend WithEvents NUD_length1 As NumericUpDown
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
