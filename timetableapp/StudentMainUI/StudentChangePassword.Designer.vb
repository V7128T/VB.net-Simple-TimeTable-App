﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentChangePassword
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentChangePassword))
        Me.txtUserMail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtConPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNewPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnReset = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnBack = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblcheckpass = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.iconShowPass = New FontAwesome.Sharp.IconButton()
        Me.iconHidePass = New FontAwesome.Sharp.IconButton()
        Me.lblChangePassTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUserMail
        '
        Me.txtUserMail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUserMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUserMail.HintForeColor = System.Drawing.Color.Empty
        Me.txtUserMail.HintText = "Registered Email Address"
        Me.txtUserMail.isPassword = False
        Me.txtUserMail.LineFocusedColor = System.Drawing.Color.DarkOrchid
        Me.txtUserMail.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtUserMail.LineMouseHoverColor = System.Drawing.Color.DarkOrchid
        Me.txtUserMail.LineThickness = 2
        Me.txtUserMail.Location = New System.Drawing.Point(46, 184)
        Me.txtUserMail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserMail.Name = "txtUserMail"
        Me.txtUserMail.Size = New System.Drawing.Size(574, 41)
        Me.txtUserMail.TabIndex = 1
        Me.txtUserMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtPassword.HintText = "Old Password"
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.DarkOrchid
        Me.txtPassword.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.DarkOrchid
        Me.txtPassword.LineThickness = 2
        Me.txtPassword.Location = New System.Drawing.Point(46, 256)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(574, 41)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtConPass
        '
        Me.txtConPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtConPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtConPass.HintForeColor = System.Drawing.Color.Empty
        Me.txtConPass.HintText = "Confirm Password"
        Me.txtConPass.isPassword = False
        Me.txtConPass.LineFocusedColor = System.Drawing.Color.DarkOrchid
        Me.txtConPass.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtConPass.LineMouseHoverColor = System.Drawing.Color.DarkOrchid
        Me.txtConPass.LineThickness = 2
        Me.txtConPass.Location = New System.Drawing.Point(46, 399)
        Me.txtConPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConPass.Name = "txtConPass"
        Me.txtConPass.Size = New System.Drawing.Size(574, 41)
        Me.txtConPass.TabIndex = 3
        Me.txtConPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewPass.HintForeColor = System.Drawing.Color.Empty
        Me.txtNewPass.HintText = "New Password"
        Me.txtNewPass.isPassword = False
        Me.txtNewPass.LineFocusedColor = System.Drawing.Color.DarkOrchid
        Me.txtNewPass.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtNewPass.LineMouseHoverColor = System.Drawing.Color.DarkOrchid
        Me.txtNewPass.LineThickness = 2
        Me.txtNewPass.Location = New System.Drawing.Point(46, 330)
        Me.txtNewPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(574, 41)
        Me.txtNewPass.TabIndex = 4
        Me.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnReset
        '
        Me.btnReset.ActiveBorderThickness = 1
        Me.btnReset.ActiveCornerRadius = 40
        Me.btnReset.ActiveFillColor = System.Drawing.Color.SlateBlue
        Me.btnReset.ActiveForecolor = System.Drawing.Color.Black
        Me.btnReset.ActiveLineColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.ButtonText = "Submit"
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.IdleBorderThickness = 1
        Me.btnReset.IdleCornerRadius = 40
        Me.btnReset.IdleFillColor = System.Drawing.Color.WhiteSmoke
        Me.btnReset.IdleForecolor = System.Drawing.Color.Black
        Me.btnReset.IdleLineColor = System.Drawing.Color.DarkGray
        Me.btnReset.Location = New System.Drawing.Point(686, 266)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(199, 53)
        Me.btnReset.TabIndex = 5
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.ActiveBorderThickness = 1
        Me.btnBack.ActiveCornerRadius = 42
        Me.btnBack.ActiveFillColor = System.Drawing.Color.Red
        Me.btnBack.ActiveForecolor = System.Drawing.Color.White
        Me.btnBack.ActiveLineColor = System.Drawing.Color.Red
        Me.btnBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.ButtonText = "Back"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.IdleBorderThickness = 1
        Me.btnBack.IdleCornerRadius = 40
        Me.btnBack.IdleFillColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.IdleForecolor = System.Drawing.Color.Black
        Me.btnBack.IdleLineColor = System.Drawing.Color.DarkGray
        Me.btnBack.Location = New System.Drawing.Point(686, 343)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(199, 53)
        Me.btnBack.TabIndex = 6
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcheckpass
        '
        Me.lblcheckpass.AutoSize = True
        Me.lblcheckpass.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcheckpass.ForeColor = System.Drawing.Color.Red
        Me.lblcheckpass.Location = New System.Drawing.Point(43, 404)
        Me.lblcheckpass.Name = "lblcheckpass"
        Me.lblcheckpass.Size = New System.Drawing.Size(0, 14)
        Me.lblcheckpass.TabIndex = 7
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelTitle.Controls.Add(Me.btnClose)
        Me.PanelTitle.Controls.Add(Me.btnMinimize)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(926, 37)
        Me.PanelTitle.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Gray
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.Location = New System.Drawing.Point(884, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 33)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.Gray
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnMinimize.IconColor = System.Drawing.Color.Black
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.Location = New System.Drawing.Point(858, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(23, 32)
        Me.btnMinimize.TabIndex = 19
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'iconShowPass
        '
        Me.iconShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconShowPass.FlatAppearance.BorderSize = 0
        Me.iconShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.iconShowPass.IconColor = System.Drawing.Color.Black
        Me.iconShowPass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconShowPass.IconSize = 30
        Me.iconShowPass.Location = New System.Drawing.Point(627, 343)
        Me.iconShowPass.Name = "iconShowPass"
        Me.iconShowPass.Size = New System.Drawing.Size(35, 22)
        Me.iconShowPass.TabIndex = 32
        Me.iconShowPass.UseVisualStyleBackColor = True
        '
        'iconHidePass
        '
        Me.iconHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconHidePass.FlatAppearance.BorderSize = 0
        Me.iconHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconHidePass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.iconHidePass.IconColor = System.Drawing.Color.Black
        Me.iconHidePass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconHidePass.IconSize = 30
        Me.iconHidePass.Location = New System.Drawing.Point(627, 343)
        Me.iconHidePass.Name = "iconHidePass"
        Me.iconHidePass.Size = New System.Drawing.Size(35, 22)
        Me.iconHidePass.TabIndex = 33
        Me.iconHidePass.UseVisualStyleBackColor = True
        Me.iconHidePass.Visible = False
        '
        'lblChangePassTitle
        '
        Me.lblChangePassTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblChangePassTitle.Font = New System.Drawing.Font("Lucida Fax", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePassTitle.ForeColor = System.Drawing.Color.SlateBlue
        Me.lblChangePassTitle.Location = New System.Drawing.Point(0, 37)
        Me.lblChangePassTitle.Name = "lblChangePassTitle"
        Me.lblChangePassTitle.Size = New System.Drawing.Size(926, 103)
        Me.lblChangePassTitle.TabIndex = 34
        Me.lblChangePassTitle.Text = "CHANGE PASSWORD"
        Me.lblChangePassTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(926, 523)
        Me.Controls.Add(Me.lblChangePassTitle)
        Me.Controls.Add(Me.iconShowPass)
        Me.Controls.Add(Me.iconHidePass)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.lblcheckpass)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtConPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserMail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "StudentChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResetUserPassword"
        Me.PanelTitle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserMail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtConPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtNewPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnReset As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblcheckpass As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents iconShowPass As FontAwesome.Sharp.IconButton
    Friend WithEvents iconHidePass As FontAwesome.Sharp.IconButton
    Friend WithEvents lblChangePassTitle As Bunifu.Framework.UI.BunifuCustomLabel
End Class
