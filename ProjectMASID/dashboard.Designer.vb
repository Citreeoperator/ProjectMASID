<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        components = New ComponentModel.Container()
        pnl_top = New Panel()
        lbl_timeanddate = New Label()
        pnl_bot = New Panel()
        lbl_status = New Label()
        pnl_main = New Panel()
        menu_menustrip = New MenuStrip()
        MainMenuToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        tmr_timeanddate = New Timer(components)
        pnl_top.SuspendLayout()
        pnl_bot.SuspendLayout()
        pnl_main.SuspendLayout()
        menu_menustrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnl_top
        ' 
        pnl_top.BackColor = Color.FromArgb(CByte(31), CByte(50), CByte(86))
        pnl_top.Controls.Add(lbl_timeanddate)
        pnl_top.Dock = DockStyle.Top
        pnl_top.Location = New Point(0, 0)
        pnl_top.Name = "pnl_top"
        pnl_top.Size = New Size(1904, 53)
        pnl_top.TabIndex = 0
        ' 
        ' lbl_timeanddate
        ' 
        lbl_timeanddate.AutoSize = True
        lbl_timeanddate.Dock = DockStyle.Right
        lbl_timeanddate.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_timeanddate.ForeColor = SystemColors.Control
        lbl_timeanddate.Location = New Point(1864, 0)
        lbl_timeanddate.Name = "lbl_timeanddate"
        lbl_timeanddate.Size = New Size(40, 25)
        lbl_timeanddate.TabIndex = 0
        lbl_timeanddate.Text = "dfg"' 
        ' pnl_bot
        ' 
        pnl_bot.BackColor = Color.FromArgb(CByte(31), CByte(50), CByte(86))
        pnl_bot.Controls.Add(lbl_status)
        pnl_bot.Dock = DockStyle.Bottom
        pnl_bot.Location = New Point(0, 1013)
        pnl_bot.Name = "pnl_bot"
        pnl_bot.Size = New Size(1904, 28)
        pnl_bot.TabIndex = 1
        ' 
        ' lbl_status
        ' 
        lbl_status.AutoSize = True
        lbl_status.Dock = DockStyle.Left
        lbl_status.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_status.ForeColor = SystemColors.Control
        lbl_status.Location = New Point(0, 0)
        lbl_status.Name = "lbl_status"
        lbl_status.Size = New Size(149, 25)
        lbl_status.TabIndex = 0
        lbl_status.Text = "Database Status:"' 
        ' pnl_main
        ' 
        pnl_main.BackColor = Color.LightGray
        pnl_main.Controls.Add(menu_menustrip)
        pnl_main.Dock = DockStyle.Fill
        pnl_main.Location = New Point(0, 53)
        pnl_main.Name = "pnl_main"
        pnl_main.Size = New Size(1904, 960)
        pnl_main.TabIndex = 2
        ' 
        ' menu_menustrip
        ' 
        menu_menustrip.BackColor = SystemColors.GradientInactiveCaption
        menu_menustrip.Items.AddRange(New ToolStripItem() {MainMenuToolStripMenuItem})
        menu_menustrip.Location = New Point(0, 0)
        menu_menustrip.Name = "menu_menustrip"
        menu_menustrip.Size = New Size(1904, 24)
        menu_menustrip.TabIndex = 0
        menu_menustrip.Text = "MenuStrip1"' 
        ' MainMenuToolStripMenuItem
        ' 
        MainMenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem})
        MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        MainMenuToolStripMenuItem.Size = New Size(80, 20)
        MainMenuToolStripMenuItem.Text = "Main Menu"' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(112, 22)
        LogoutToolStripMenuItem.Text = "Logout"' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(122), CByte(29))
        ClientSize = New Size(1904, 1041)
        Controls.Add(pnl_main)
        Controls.Add(pnl_top)
        Controls.Add(pnl_bot)
        Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Project MASID - User"
        pnl_top.ResumeLayout(False)
        pnl_top.PerformLayout()
        pnl_bot.ResumeLayout(False)
        pnl_bot.PerformLayout()
        pnl_main.ResumeLayout(False)
        pnl_main.PerformLayout()
        menu_menustrip.ResumeLayout(False)
        menu_menustrip.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnl_top As Panel
    Friend WithEvents pnl_bot As Panel
    Friend WithEvents pnl_main As Panel
    Friend WithEvents menu_menustrip As MenuStrip
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_timeanddate As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents tmr_timeanddate As Timer
End Class
