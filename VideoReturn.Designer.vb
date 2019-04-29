<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoReturn
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
        Me.GB_videosInformation = New System.Windows.Forms.GroupBox()
        Me.LBL_clientName = New System.Windows.Forms.Label()
        Me.TB_clientName = New System.Windows.Forms.TextBox()
        Me.TB_clientNumber = New System.Windows.Forms.TextBox()
        Me.LBL_clientNumber = New System.Windows.Forms.Label()
        Me.TB_videoID = New System.Windows.Forms.TextBox()
        Me.LBL_videoID = New System.Windows.Forms.Label()
        Me.TB_rentedOn = New System.Windows.Forms.TextBox()
        Me.LBL_rentedOn = New System.Windows.Forms.Label()
        Me.GB_videoPhoto = New System.Windows.Forms.GroupBox()
        Me.PB_photoCover = New System.Windows.Forms.PictureBox()
        Me.BTN_return = New System.Windows.Forms.Button()
        Me.BTN_cancel = New System.Windows.Forms.Button()
        Me.LBL_returnVideo = New System.Windows.Forms.Label()
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
        Me.GB_videosInformation.SuspendLayout()
        Me.GB_videoPhoto.SuspendLayout()
        CType(Me.PB_photoCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_videosInformation
        '
        Me.GB_videosInformation.Controls.Add(Me.BTN_return)
        Me.GB_videosInformation.Controls.Add(Me.GB_videoPhoto)
        Me.GB_videosInformation.Controls.Add(Me.BTN_cancel)
        Me.GB_videosInformation.Controls.Add(Me.TB_rentedOn)
        Me.GB_videosInformation.Controls.Add(Me.LBL_rentedOn)
        Me.GB_videosInformation.Controls.Add(Me.TB_videoID)
        Me.GB_videosInformation.Controls.Add(Me.LBL_videoID)
        Me.GB_videosInformation.Controls.Add(Me.LBL_clientName)
        Me.GB_videosInformation.Controls.Add(Me.TB_clientName)
        Me.GB_videosInformation.Controls.Add(Me.TB_clientNumber)
        Me.GB_videosInformation.Controls.Add(Me.LBL_clientNumber)
        Me.GB_videosInformation.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_videosInformation.Location = New System.Drawing.Point(12, 112)
        Me.GB_videosInformation.Name = "GB_videosInformation"
        Me.GB_videosInformation.Size = New System.Drawing.Size(697, 308)
        Me.GB_videosInformation.TabIndex = 1
        Me.GB_videosInformation.TabStop = False
        Me.GB_videosInformation.Text = "Video's information"
        '
        'LBL_clientName
        '
        Me.LBL_clientName.AutoSize = True
        Me.LBL_clientName.Location = New System.Drawing.Point(6, 104)
        Me.LBL_clientName.Name = "LBL_clientName"
        Me.LBL_clientName.Size = New System.Drawing.Size(92, 19)
        Me.LBL_clientName.TabIndex = 9
        Me.LBL_clientName.Text = "Client name:"
        '
        'TB_clientName
        '
        Me.TB_clientName.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_clientName.Enabled = False
        Me.TB_clientName.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_clientName.Location = New System.Drawing.Point(118, 101)
        Me.TB_clientName.Name = "TB_clientName"
        Me.TB_clientName.Size = New System.Drawing.Size(288, 27)
        Me.TB_clientName.TabIndex = 6
        '
        'TB_clientNumber
        '
        Me.TB_clientNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_clientNumber.Enabled = False
        Me.TB_clientNumber.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_clientNumber.Location = New System.Drawing.Point(118, 134)
        Me.TB_clientNumber.Name = "TB_clientNumber"
        Me.TB_clientNumber.Size = New System.Drawing.Size(288, 27)
        Me.TB_clientNumber.TabIndex = 5
        '
        'LBL_clientNumber
        '
        Me.LBL_clientNumber.AutoSize = True
        Me.LBL_clientNumber.Location = New System.Drawing.Point(6, 137)
        Me.LBL_clientNumber.Name = "LBL_clientNumber"
        Me.LBL_clientNumber.Size = New System.Drawing.Size(106, 19)
        Me.LBL_clientNumber.TabIndex = 4
        Me.LBL_clientNumber.Text = "Client number:"
        '
        'TB_videoID
        '
        Me.TB_videoID.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_videoID.Enabled = False
        Me.TB_videoID.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_videoID.Location = New System.Drawing.Point(118, 68)
        Me.TB_videoID.Name = "TB_videoID"
        Me.TB_videoID.Size = New System.Drawing.Size(288, 27)
        Me.TB_videoID.TabIndex = 15
        '
        'LBL_videoID
        '
        Me.LBL_videoID.AutoSize = True
        Me.LBL_videoID.Location = New System.Drawing.Point(6, 71)
        Me.LBL_videoID.Name = "LBL_videoID"
        Me.LBL_videoID.Size = New System.Drawing.Size(71, 19)
        Me.LBL_videoID.TabIndex = 14
        Me.LBL_videoID.Text = "Video ID:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TB_rentedOn
        '
        Me.TB_rentedOn.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_rentedOn.Enabled = False
        Me.TB_rentedOn.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_rentedOn.Location = New System.Drawing.Point(118, 167)
        Me.TB_rentedOn.Name = "TB_rentedOn"
        Me.TB_rentedOn.Size = New System.Drawing.Size(288, 27)
        Me.TB_rentedOn.TabIndex = 17
        '
        'LBL_rentedOn
        '
        Me.LBL_rentedOn.AutoSize = True
        Me.LBL_rentedOn.Location = New System.Drawing.Point(6, 170)
        Me.LBL_rentedOn.Name = "LBL_rentedOn"
        Me.LBL_rentedOn.Size = New System.Drawing.Size(81, 19)
        Me.LBL_rentedOn.TabIndex = 16
        Me.LBL_rentedOn.Text = "Rented on:"
        '
        'GB_videoPhoto
        '
        Me.GB_videoPhoto.Controls.Add(Me.PB_photoCover)
        Me.GB_videoPhoto.Location = New System.Drawing.Point(440, 22)
        Me.GB_videoPhoto.Name = "GB_videoPhoto"
        Me.GB_videoPhoto.Size = New System.Drawing.Size(245, 272)
        Me.GB_videoPhoto.TabIndex = 23
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
        'BTN_return
        '
        Me.BTN_return.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_return.Location = New System.Drawing.Point(222, 254)
        Me.BTN_return.Name = "BTN_return"
        Me.BTN_return.Size = New System.Drawing.Size(155, 40)
        Me.BTN_return.TabIndex = 36
        Me.BTN_return.Text = "Return"
        Me.BTN_return.UseVisualStyleBackColor = True
        '
        'BTN_cancel
        '
        Me.BTN_cancel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_cancel.Location = New System.Drawing.Point(50, 254)
        Me.BTN_cancel.Name = "BTN_cancel"
        Me.BTN_cancel.Size = New System.Drawing.Size(155, 40)
        Me.BTN_cancel.TabIndex = 35
        Me.BTN_cancel.Text = "Cancel"
        Me.BTN_cancel.UseVisualStyleBackColor = True
        '
        'LBL_returnVideo
        '
        Me.LBL_returnVideo.AutoSize = True
        Me.LBL_returnVideo.Font = New System.Drawing.Font("Corbel", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_returnVideo.Location = New System.Drawing.Point(224, 50)
        Me.LBL_returnVideo.Name = "LBL_returnVideo"
        Me.LBL_returnVideo.Size = New System.Drawing.Size(278, 59)
        Me.LBL_returnVideo.TabIndex = 37
        Me.LBL_returnVideo.Text = "Return video"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_employees, Me.TS_video, Me.TS_search, Me.TS_rent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(724, 24)
        Me.MenuStrip1.TabIndex = 38
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
        'VideoReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 441)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LBL_returnVideo)
        Me.Controls.Add(Me.GB_videosInformation)
        Me.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "VideoReturn"
        Me.Text = "VideoReturn"
        Me.GB_videosInformation.ResumeLayout(False)
        Me.GB_videosInformation.PerformLayout()
        Me.GB_videoPhoto.ResumeLayout(False)
        CType(Me.PB_photoCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_videosInformation As GroupBox
    Friend WithEvents LBL_clientName As Label
    Friend WithEvents TB_clientName As TextBox
    Friend WithEvents TB_clientNumber As TextBox
    Friend WithEvents LBL_clientNumber As Label
    Friend WithEvents TB_rentedOn As TextBox
    Friend WithEvents LBL_rentedOn As Label
    Friend WithEvents TB_videoID As TextBox
    Friend WithEvents LBL_videoID As Label
    Friend WithEvents GB_videoPhoto As GroupBox
    Friend WithEvents PB_photoCover As PictureBox
    Friend WithEvents BTN_return As Button
    Friend WithEvents BTN_cancel As Button
    Friend WithEvents LBL_returnVideo As Label
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
