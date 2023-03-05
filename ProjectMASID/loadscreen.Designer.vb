<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loadscreen
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(loadscreen))
        pb_load = New ProgressBar()
        pic_splash = New PictureBox()
        tmr_loading = New Timer(components)
        CType(pic_splash, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pb_load
        ' 
        pb_load.Dock = DockStyle.Bottom
        pb_load.Location = New Point(0, 456)
        pb_load.Name = "pb_load"
        pb_load.Size = New Size(680, 23)
        pb_load.TabIndex = 0
        ' 
        ' pic_splash
        ' 
        pic_splash.Image = CType(resources.GetObject("pic_splash.Image"), Image)
        pic_splash.Location = New Point(0, 0)
        pic_splash.Name = "pic_splash"
        pic_splash.Size = New Size(680, 479)
        pic_splash.SizeMode = PictureBoxSizeMode.StretchImage
        pic_splash.TabIndex = 1
        pic_splash.TabStop = False
        ' 
        ' loadscreen
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(122), CByte(29))
        ClientSize = New Size(680, 479)
        Controls.Add(pb_load)
        Controls.Add(pic_splash)
        Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "loadscreen"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "loadscreen"
        CType(pic_splash, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pb_load As ProgressBar
    Friend WithEvents pic_splash As PictureBox
    Friend WithEvents tmr_loading As Timer
End Class
