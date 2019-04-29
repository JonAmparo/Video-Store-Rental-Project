<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoRent
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GB_clientsInformation = New System.Windows.Forms.GroupBox()
        Me.GB_videoInfo = New System.Windows.Forms.GroupBox()
        Me.LBL_clientNumber = New System.Windows.Forms.Label()
        Me.TB_clientNumber = New System.Windows.Forms.TextBox()
        Me.TB_name = New System.Windows.Forms.TextBox()
        Me.TB_address = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LBL_name = New System.Windows.Forms.Label()
        Me.LBL_address = New System.Windows.Forms.Label()
        Me.LBL_telephone = New System.Windows.Forms.Label()
        Me.LBL_director = New System.Windows.Forms.Label()
        Me.LBL_language = New System.Windows.Forms.Label()
        Me.LBL_title = New System.Windows.Forms.Label()
        Me.TB_director = New System.Windows.Forms.TextBox()
        Me.TB_language = New System.Windows.Forms.TextBox()
        Me.TB_title = New System.Windows.Forms.TextBox()
        Me.TB_videoID = New System.Windows.Forms.TextBox()
        Me.LBL_videoID = New System.Windows.Forms.Label()
        Me.LBL_description = New System.Windows.Forms.Label()
        Me.TB_description = New System.Windows.Forms.TextBox()
        Me.GB_videoPhoto = New System.Windows.Forms.GroupBox()
        Me.PB_photoCover = New System.Windows.Forms.PictureBox()
        Me.BTN_rent = New System.Windows.Forms.Button()
        Me.BTN_cancel = New System.Windows.Forms.Button()
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
        Me.LBL_rentVideo = New System.Windows.Forms.Label()
        Me.GB_clientsInformation.SuspendLayout()
        Me.GB_videoInfo.SuspendLayout()
        Me.GB_videoPhoto.SuspendLayout()
        CType(Me.PB_photoCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_clientsInformation
        '
        Me.GB_clientsInformation.Controls.Add(Me.LBL_telephone)
        Me.GB_clientsInformation.Controls.Add(Me.LBL_address)
        Me.GB_clientsInformation.Controls.Add(Me.LBL_name)
        Me.GB_clientsInformation.Controls.Add(Me.TextBox3)
        Me.GB_clientsInformation.Controls.Add(Me.TB_address)
        Me.GB_clientsInformation.Controls.Add(Me.TB_name)
        Me.GB_clientsInformation.Controls.Add(Me.TB_clientNumber)
        Me.GB_clientsInformation.Controls.Add(Me.LBL_clientNumber)
        Me.GB_clientsInformation.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_clientsInformation.Location = New System.Drawing.Point(12, 102)
        Me.GB_clientsInformation.Name = "GB_clientsInformation"
        Me.GB_clientsInformation.Size = New System.Drawing.Size(424, 300)
        Me.GB_clientsInformation.TabIndex = 0
        Me.GB_clientsInformation.TabStop = False
        Me.GB_clientsInformation.Text = "Client's information"
        '
        'GB_videoInfo
        '
        Me.GB_videoInfo.Controls.Add(Me.GB_videoPhoto)
        Me.GB_videoInfo.Controls.Add(Me.TB_description)
        Me.GB_videoInfo.Controls.Add(Me.LBL_description)
        Me.GB_videoInfo.Controls.Add(Me.LBL_director)
        Me.GB_videoInfo.Controls.Add(Me.LBL_language)
        Me.GB_videoInfo.Controls.Add(Me.LBL_title)
        Me.GB_videoInfo.Controls.Add(Me.TB_director)
        Me.GB_videoInfo.Controls.Add(Me.TB_language)
        Me.GB_videoInfo.Controls.Add(Me.TB_title)
        Me.GB_videoInfo.Controls.Add(Me.TB_videoID)
        Me.GB_videoInfo.Controls.Add(Me.LBL_videoID)
        Me.GB_videoInfo.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_videoInfo.Location = New System.Drawing.Point(459, 102)
        Me.GB_videoInfo.Name = "GB_videoInfo"
        Me.GB_videoInfo.Size = New System.Drawing.Size(695, 300)
        Me.GB_videoInfo.TabIndex = 1
        Me.GB_videoInfo.TabStop = False
        Me.GB_videoInfo.Text = "Video's Information"
        '
        'LBL_clientNumber
        '
        Me.LBL_clientNumber.AutoSize = True
        Me.LBL_clientNumber.Location = New System.Drawing.Point(6, 53)
        Me.LBL_clientNumber.Name = "LBL_clientNumber"
        Me.LBL_clientNumber.Size = New System.Drawing.Size(106, 19)
        Me.LBL_clientNumber.TabIndex = 4
        Me.LBL_clientNumber.Text = "Client number:"
        '
        'TB_clientNumber
        '
        Me.TB_clientNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_clientNumber.Enabled = False
        Me.TB_clientNumber.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_clientNumber.Location = New System.Drawing.Point(118, 50)
        Me.TB_clientNumber.Name = "TB_clientNumber"
        Me.TB_clientNumber.Size = New System.Drawing.Size(288, 27)
        Me.TB_clientNumber.TabIndex = 5
        '
        'TB_name
        '
        Me.TB_name.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_name.Enabled = False
        Me.TB_name.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_name.Location = New System.Drawing.Point(118, 83)
        Me.TB_name.Name = "TB_name"
        Me.TB_name.Size = New System.Drawing.Size(288, 27)
        Me.TB_name.TabIndex = 6
        '
        'TB_address
        '
        Me.TB_address.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_address.Enabled = False
        Me.TB_address.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_address.Location = New System.Drawing.Point(118, 116)
        Me.TB_address.Name = "TB_address"
        Me.TB_address.Size = New System.Drawing.Size(288, 27)
        Me.TB_address.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(118, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(288, 27)
        Me.TextBox3.TabIndex = 8
        '
        'LBL_name
        '
        Me.LBL_name.AutoSize = True
        Me.LBL_name.Location = New System.Drawing.Point(6, 86)
        Me.LBL_name.Name = "LBL_name"
        Me.LBL_name.Size = New System.Drawing.Size(53, 19)
        Me.LBL_name.TabIndex = 9
        Me.LBL_name.Text = "Name:"
        '
        'LBL_address
        '
        Me.LBL_address.AutoSize = True
        Me.LBL_address.Location = New System.Drawing.Point(6, 119)
        Me.LBL_address.Name = "LBL_address"
        Me.LBL_address.Size = New System.Drawing.Size(66, 19)
        Me.LBL_address.TabIndex = 10
        Me.LBL_address.Text = "Address:"
        '
        'LBL_telephone
        '
        Me.LBL_telephone.AutoSize = True
        Me.LBL_telephone.Location = New System.Drawing.Point(6, 152)
        Me.LBL_telephone.Name = "LBL_telephone"
        Me.LBL_telephone.Size = New System.Drawing.Size(84, 19)
        Me.LBL_telephone.TabIndex = 11
        Me.LBL_telephone.Text = "Telephone:"
        '
        'LBL_director
        '
        Me.LBL_director.AutoSize = True
        Me.LBL_director.Location = New System.Drawing.Point(6, 152)
        Me.LBL_director.Name = "LBL_director"
        Me.LBL_director.Size = New System.Drawing.Size(68, 19)
        Me.LBL_director.TabIndex = 19
        Me.LBL_director.Text = "Director:"
        '
        'LBL_language
        '
        Me.LBL_language.AutoSize = True
        Me.LBL_language.Location = New System.Drawing.Point(6, 119)
        Me.LBL_language.Name = "LBL_language"
        Me.LBL_language.Size = New System.Drawing.Size(82, 19)
        Me.LBL_language.TabIndex = 18
        Me.LBL_language.Text = "Language: "
        '
        'LBL_title
        '
        Me.LBL_title.AutoSize = True
        Me.LBL_title.Location = New System.Drawing.Point(6, 86)
        Me.LBL_title.Name = "LBL_title"
        Me.LBL_title.Size = New System.Drawing.Size(44, 19)
        Me.LBL_title.TabIndex = 17
        Me.LBL_title.Text = "Title:"
        '
        'TB_director
        '
        Me.TB_director.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_director.Enabled = False
        Me.TB_director.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_director.Location = New System.Drawing.Point(118, 149)
        Me.TB_director.Name = "TB_director"
        Me.TB_director.Size = New System.Drawing.Size(288, 27)
        Me.TB_director.TabIndex = 16
        '
        'TB_language
        '
        Me.TB_language.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_language.Enabled = False
        Me.TB_language.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_language.Location = New System.Drawing.Point(118, 116)
        Me.TB_language.Name = "TB_language"
        Me.TB_language.Size = New System.Drawing.Size(288, 27)
        Me.TB_language.TabIndex = 15
        '
        'TB_title
        '
        Me.TB_title.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_title.Enabled = False
        Me.TB_title.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_title.Location = New System.Drawing.Point(118, 83)
        Me.TB_title.Name = "TB_title"
        Me.TB_title.Size = New System.Drawing.Size(288, 27)
        Me.TB_title.TabIndex = 14
        '
        'TB_videoID
        '
        Me.TB_videoID.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_videoID.Enabled = False
        Me.TB_videoID.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_videoID.Location = New System.Drawing.Point(118, 50)
        Me.TB_videoID.Name = "TB_videoID"
        Me.TB_videoID.Size = New System.Drawing.Size(288, 27)
        Me.TB_videoID.TabIndex = 13
        '
        'LBL_videoID
        '
        Me.LBL_videoID.AutoSize = True
        Me.LBL_videoID.Location = New System.Drawing.Point(6, 53)
        Me.LBL_videoID.Name = "LBL_videoID"
        Me.LBL_videoID.Size = New System.Drawing.Size(71, 19)
        Me.LBL_videoID.TabIndex = 12
        Me.LBL_videoID.Text = "Video ID:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LBL_description
        '
        Me.LBL_description.AutoSize = True
        Me.LBL_description.Location = New System.Drawing.Point(6, 188)
        Me.LBL_description.Name = "LBL_description"
        Me.LBL_description.Size = New System.Drawing.Size(90, 19)
        Me.LBL_description.TabIndex = 20
        Me.LBL_description.Text = "Description:"
        '
        'TB_description
        '
        Me.TB_description.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_description.Enabled = False
        Me.TB_description.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_description.Location = New System.Drawing.Point(118, 185)
        Me.TB_description.Multiline = True
        Me.TB_description.Name = "TB_description"
        Me.TB_description.Size = New System.Drawing.Size(288, 91)
        Me.TB_description.TabIndex = 21
        '
        'GB_videoPhoto
        '
        Me.GB_videoPhoto.Controls.Add(Me.PB_photoCover)
        Me.GB_videoPhoto.Location = New System.Drawing.Point(439, 13)
        Me.GB_videoPhoto.Name = "GB_videoPhoto"
        Me.GB_videoPhoto.Size = New System.Drawing.Size(245, 272)
        Me.GB_videoPhoto.TabIndex = 22
        Me.GB_videoPhoto.TabStop = False
        Me.GB_videoPhoto.Text = "Video poster"
        '
        'PB_photoCover
        '
        Me.PB_photoCover.Location = New System.Drawing.Point(18, 37)
        Me.PB_photoCover.Name = "PB_photoCover"
        Me.PB_photoCover.Size = New System.Drawing.Size(211, 214)
        Me.PB_photoCover.TabIndex = 0
        Me.PB_photoCover.TabStop = False
        '
        'BTN_rent
        '
        Me.BTN_rent.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_rent.Location = New System.Drawing.Point(594, 422)
        Me.BTN_rent.Name = "BTN_rent"
        Me.BTN_rent.Size = New System.Drawing.Size(155, 40)
        Me.BTN_rent.TabIndex = 34
        Me.BTN_rent.Text = "Rent"
        Me.BTN_rent.UseVisualStyleBackColor = True
        '
        'BTN_cancel
        '
        Me.BTN_cancel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_cancel.Location = New System.Drawing.Point(422, 422)
        Me.BTN_cancel.Name = "BTN_cancel"
        Me.BTN_cancel.Size = New System.Drawing.Size(155, 40)
        Me.BTN_cancel.TabIndex = 33
        Me.BTN_cancel.Text = "Cancel"
        Me.BTN_cancel.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_employees, Me.TS_video, Me.TS_search, Me.TS_rent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1168, 24)
        Me.MenuStrip1.TabIndex = 35
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
        Me.TS_rentVideo.Size = New System.Drawing.Size(152, 22)
        Me.TS_rentVideo.Text = "Rent video"
        '
        'LBL_rentVideo
        '
        Me.LBL_rentVideo.AutoSize = True
        Me.LBL_rentVideo.Font = New System.Drawing.Font("Corbel", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_rentVideo.Location = New System.Drawing.Point(449, 40)
        Me.LBL_rentVideo.Name = "LBL_rentVideo"
        Me.LBL_rentVideo.Size = New System.Drawing.Size(237, 59)
        Me.LBL_rentVideo.TabIndex = 36
        Me.LBL_rentVideo.Text = "Rent video"
        '
        'VideoRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 484)
        Me.Controls.Add(Me.LBL_rentVideo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BTN_rent)
        Me.Controls.Add(Me.BTN_cancel)
        Me.Controls.Add(Me.GB_videoInfo)
        Me.Controls.Add(Me.GB_clientsInformation)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "VideoRent"
        Me.Text = "VideoRent"
        Me.GB_clientsInformation.ResumeLayout(False)
        Me.GB_clientsInformation.PerformLayout()
        Me.GB_videoInfo.ResumeLayout(False)
        Me.GB_videoInfo.PerformLayout()
        Me.GB_videoPhoto.ResumeLayout(False)
        CType(Me.PB_photoCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GB_clientsInformation As GroupBox
    Friend WithEvents GB_videoInfo As GroupBox
    Friend WithEvents LBL_clientNumber As Label
    Friend WithEvents TB_clientNumber As TextBox
    Friend WithEvents LBL_telephone As Label
    Friend WithEvents LBL_address As Label
    Friend WithEvents LBL_name As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TB_address As TextBox
    Friend WithEvents TB_name As TextBox
    Friend WithEvents GB_videoPhoto As GroupBox
    Friend WithEvents PB_photoCover As PictureBox
    Friend WithEvents TB_description As TextBox
    Friend WithEvents LBL_description As Label
    Friend WithEvents LBL_director As Label
    Friend WithEvents LBL_language As Label
    Friend WithEvents LBL_title As Label
    Friend WithEvents TB_director As TextBox
    Friend WithEvents TB_language As TextBox
    Friend WithEvents TB_title As TextBox
    Friend WithEvents TB_videoID As TextBox
    Friend WithEvents LBL_videoID As Label
    Friend WithEvents BTN_rent As Button
    Friend WithEvents BTN_cancel As Button
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
    Friend WithEvents LBL_rentVideo As Label
End Class
