<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(loginform))
        pnl_top = New Panel()
        pic_c3 = New PictureBox()
        pic_mdr = New PictureBox()
        lbl_title = New Label()
        pnl_bot = New Panel()
        lbl_copyright = New Label()
        btn_login = New Button()
        txt_pass = New TextBox()
        lbl_password = New Label()
        txt_user = New TextBox()
        lbl_user = New Label()
        pnl_top.SuspendLayout()
        CType(pic_c3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_mdr, ComponentModel.ISupportInitialize).BeginInit()
        pnl_bot.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnl_top
        ' 
        pnl_top.BackColor = Color.FromArgb(CByte(31), CByte(50), CByte(86))
        pnl_top.Controls.Add(pic_c3)
        pnl_top.Controls.Add(pic_mdr)
        pnl_top.Controls.Add(lbl_title)
        pnl_top.Dock = DockStyle.Top
        pnl_top.Location = New Point(0, 0)
        pnl_top.Name = "pnl_top"
        pnl_top.Size = New Size(800, 103)
        pnl_top.TabIndex = 7
        ' 
        ' pic_c3
        ' 
        pic_c3.Image = CType(resources.GetObject("pic_c3.Image"), Image)
        pic_c3.Location = New Point(620, 0)
        pic_c3.Name = "pic_c3"
        pic_c3.Size = New Size(78, 103)
        pic_c3.SizeMode = PictureBoxSizeMode.StretchImage
        pic_c3.TabIndex = 3
        pic_c3.TabStop = False
        ' 
        ' pic_mdr
        ' 
        pic_mdr.Image = CType(resources.GetObject("pic_mdr.Image"), Image)
        pic_mdr.Location = New Point(85, 3)
        pic_mdr.Name = "pic_mdr"
        pic_mdr.Size = New Size(102, 97)
        pic_mdr.SizeMode = PictureBoxSizeMode.StretchImage
        pic_mdr.TabIndex = 2
        pic_mdr.TabStop = False
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.ForeColor = SystemColors.Control
        lbl_title.Location = New Point(387, 35)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(27, 21)
        lbl_title.TabIndex = 0
        lbl_title.Text = "sd"
        lbl_title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnl_bot
        ' 
        pnl_bot.BackColor = Color.FromArgb(CByte(31), CByte(50), CByte(86))
        pnl_bot.Controls.Add(lbl_copyright)
        pnl_bot.Dock = DockStyle.Bottom
        pnl_bot.Location = New Point(0, 404)
        pnl_bot.Name = "pnl_bot"
        pnl_bot.Size = New Size(800, 46)
        pnl_bot.TabIndex = 8
        ' 
        ' lbl_copyright
        ' 
        lbl_copyright.AutoSize = True
        lbl_copyright.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_copyright.ForeColor = SystemColors.Control
        lbl_copyright.Location = New Point(223, 17)
        lbl_copyright.Name = "lbl_copyright"
        lbl_copyright.Size = New Size(355, 13)
        lbl_copyright.TabIndex = 5
        lbl_copyright.Text = "© 2000  C3 - Project MASID - 1.0.0.0 - SkyeTech - All Rights Reserved."
        lbl_copyright.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_login.Location = New Point(367, 282)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(75, 23)
        btn_login.TabIndex = 13
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' txt_pass
        ' 
        txt_pass.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txt_pass.Location = New Point(219, 254)
        txt_pass.Name = "txt_pass"
        txt_pass.PlaceholderText = "Password"
        txt_pass.Size = New Size(371, 22)
        txt_pass.TabIndex = 12
        txt_pass.TextAlign = HorizontalAlignment.Center
        txt_pass.UseSystemPasswordChar = True
        ' 
        ' lbl_password
        ' 
        lbl_password.AutoSize = True
        lbl_password.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_password.ForeColor = SystemColors.Control
        lbl_password.Location = New Point(374, 238)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(59, 13)
        lbl_password.TabIndex = 11
        lbl_password.Text = "Password:"' 
        ' txt_user
        ' 
        txt_user.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txt_user.Location = New Point(219, 213)
        txt_user.Name = "txt_user"
        txt_user.PlaceholderText = "User Name"
        txt_user.Size = New Size(371, 22)
        txt_user.TabIndex = 10
        txt_user.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl_user
        ' 
        lbl_user.AutoSize = True
        lbl_user.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_user.ForeColor = SystemColors.Control
        lbl_user.Location = New Point(374, 197)
        lbl_user.Name = "lbl_user"
        lbl_user.Size = New Size(61, 13)
        lbl_user.TabIndex = 9
        lbl_user.Text = "Username:"' 
        ' loginform
        ' 
        AcceptButton = btn_login
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(122), CByte(29))
        ClientSize = New Size(800, 450)
        Controls.Add(pnl_top)
        Controls.Add(pnl_bot)
        Controls.Add(btn_login)
        Controls.Add(txt_pass)
        Controls.Add(lbl_password)
        Controls.Add(txt_user)
        Controls.Add(lbl_user)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "loginform"
        pnl_top.ResumeLayout(False)
        pnl_top.PerformLayout()
        CType(pic_c3, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_mdr, ComponentModel.ISupportInitialize).EndInit()
        pnl_bot.ResumeLayout(False)
        pnl_bot.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnl_top As Panel
    Friend WithEvents pic_c3 As PictureBox
    Friend WithEvents pic_mdr As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents pnl_bot As Panel
    Friend WithEvents lbl_copyright As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_user As Label
End Class
