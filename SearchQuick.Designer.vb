<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchQuick
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
        Me.LBL_quickSearch = New System.Windows.Forms.Label()
        Me.LBL_title = New System.Windows.Forms.Label()
        Me.TB_title = New System.Windows.Forms.TextBox()
        Me.TB_videoID = New System.Windows.Forms.TextBox()
        Me.LBL_videoID = New System.Windows.Forms.Label()
        Me.GB_quickSearch = New System.Windows.Forms.GroupBox()
        Me.BTN_search = New System.Windows.Forms.Button()
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
        Me.GB_quickSearch.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_quickSearch
        '
        Me.LBL_quickSearch.AutoSize = True
        Me.LBL_quickSearch.Font = New System.Drawing.Font("Corbel", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_quickSearch.Location = New System.Drawing.Point(75, 35)
        Me.LBL_quickSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_quickSearch.Name = "LBL_quickSearch"
        Me.LBL_quickSearch.Size = New System.Drawing.Size(286, 59)
        Me.LBL_quickSearch.TabIndex = 3
        Me.LBL_quickSearch.Text = "Quick Search"
        '
        'LBL_title
        '
        Me.LBL_title.AutoSize = True
        Me.LBL_title.Location = New System.Drawing.Point(22, 83)
        Me.LBL_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_title.Name = "LBL_title"
        Me.LBL_title.Size = New System.Drawing.Size(44, 19)
        Me.LBL_title.TabIndex = 30
        Me.LBL_title.Text = "Title:"
        '
        'TB_title
        '
        Me.TB_title.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_title.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_title.Location = New System.Drawing.Point(132, 80)
        Me.TB_title.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_title.Name = "TB_title"
        Me.TB_title.Size = New System.Drawing.Size(248, 27)
        Me.TB_title.TabIndex = 2
        '
        'TB_videoID
        '
        Me.TB_videoID.Cursor = System.Windows.Forms.Cursors.Default
        Me.TB_videoID.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_videoID.Location = New System.Drawing.Point(132, 45)
        Me.TB_videoID.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_videoID.Name = "TB_videoID"
        Me.TB_videoID.Size = New System.Drawing.Size(248, 27)
        Me.TB_videoID.TabIndex = 1
        '
        'LBL_videoID
        '
        Me.LBL_videoID.AutoSize = True
        Me.LBL_videoID.Location = New System.Drawing.Point(22, 48)
        Me.LBL_videoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_videoID.Name = "LBL_videoID"
        Me.LBL_videoID.Size = New System.Drawing.Size(71, 19)
        Me.LBL_videoID.TabIndex = 27
        Me.LBL_videoID.Text = "Video ID:"
        '
        'GB_quickSearch
        '
        Me.GB_quickSearch.Controls.Add(Me.BTN_search)
        Me.GB_quickSearch.Controls.Add(Me.BTN_cancel)
        Me.GB_quickSearch.Controls.Add(Me.LBL_title)
        Me.GB_quickSearch.Controls.Add(Me.TB_title)
        Me.GB_quickSearch.Controls.Add(Me.TB_videoID)
        Me.GB_quickSearch.Controls.Add(Me.LBL_videoID)
        Me.GB_quickSearch.Location = New System.Drawing.Point(12, 86)
        Me.GB_quickSearch.Name = "GB_quickSearch"
        Me.GB_quickSearch.Size = New System.Drawing.Size(405, 191)
        Me.GB_quickSearch.TabIndex = 31
        Me.GB_quickSearch.TabStop = False
        '
        'BTN_search
        '
        Me.BTN_search.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_search.Location = New System.Drawing.Point(212, 134)
        Me.BTN_search.Name = "BTN_search"
        Me.BTN_search.Size = New System.Drawing.Size(155, 40)
        Me.BTN_search.TabIndex = 3
        Me.BTN_search.Text = "Search"
        Me.BTN_search.UseVisualStyleBackColor = True
        '
        'BTN_cancel
        '
        Me.BTN_cancel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_cancel.Location = New System.Drawing.Point(40, 134)
        Me.BTN_cancel.Name = "BTN_cancel"
        Me.BTN_cancel.Size = New System.Drawing.Size(155, 40)
        Me.BTN_cancel.TabIndex = 31
        Me.BTN_cancel.Text = "Cancel"
        Me.BTN_cancel.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_file, Me.TS_employees, Me.TS_client, Me.TS_video, Me.TS_search, Me.TS_rent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(431, 24)
        Me.MenuStrip1.TabIndex = 32
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
        'SearchQuick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 290)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GB_quickSearch)
        Me.Controls.Add(Me.LBL_quickSearch)
        Me.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SearchQuick"
        Me.Text = "QuickSearch"
        Me.GB_quickSearch.ResumeLayout(False)
        Me.GB_quickSearch.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_quickSearch As Label
    Friend WithEvents LBL_title As Label
    Friend WithEvents TB_title As TextBox
    Friend WithEvents TB_videoID As TextBox
    Friend WithEvents LBL_videoID As Label
    Friend WithEvents GB_quickSearch As GroupBox
    Friend WithEvents BTN_search As Button
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
