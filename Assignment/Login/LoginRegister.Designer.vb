<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginRegister))
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.lblProgramName = New System.Windows.Forms.Label()
        Me.btnavRecPass = New System.Windows.Forms.Button()
        Me.btnavLogin = New System.Windows.Forms.Button()
        Me.btnavRegister = New System.Windows.Forms.Button()
        Me.btnFormClose = New System.Windows.Forms.Button()
        Me.pnlNavButton = New System.Windows.Forms.Panel()
        Me.pnlWinCtrlBox = New System.Windows.Forms.Panel()
        Me.picWinCtrlMinimize = New System.Windows.Forms.PictureBox()
        Me.picWinCtrlMaximize = New System.Windows.Forms.PictureBox()
        Me.picWinCtrlExit = New System.Windows.Forms.PictureBox()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtLpassword = New System.Windows.Forms.TextBox()
        Me.txtLusername = New System.Windows.Forms.TextBox()
        Me.lblLpassword = New System.Windows.Forms.Label()
        Me.lblLusername = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.lblRTipsIC = New System.Windows.Forms.Label()
        Me.lblRTipsAge = New System.Windows.Forms.Label()
        Me.btncheckstrength = New System.Windows.Forms.Button()
        Me.txtRpassword = New System.Windows.Forms.TextBox()
        Me.lblRPass = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtRIC = New System.Windows.Forms.TextBox()
        Me.lblRIC = New System.Windows.Forms.Label()
        Me.txtRUserName = New System.Windows.Forms.TextBox()
        Me.lblRUserName = New System.Windows.Forms.Label()
        Me.txtRAge = New System.Windows.Forms.TextBox()
        Me.lblRAge = New System.Windows.Forms.Label()
        Me.txtRLName = New System.Windows.Forms.TextBox()
        Me.lblRLName = New System.Windows.Forms.Label()
        Me.txtRFName = New System.Windows.Forms.TextBox()
        Me.lblRFName = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.pnlRecovery = New System.Windows.Forms.Panel()
        Me.lblPRTipsIC = New System.Windows.Forms.Label()
        Me.btnconchanges = New System.Windows.Forms.Button()
        Me.txtPRConPass = New System.Windows.Forms.TextBox()
        Me.lblPRConPass = New System.Windows.Forms.Label()
        Me.txtPRNewPass = New System.Windows.Forms.TextBox()
        Me.lblPRNewPass = New System.Windows.Forms.Label()
        Me.txtPRIC = New System.Windows.Forms.TextBox()
        Me.lblPRIC = New System.Windows.Forms.Label()
        Me.txtPRUsername = New System.Windows.Forms.TextBox()
        Me.lblPRUsername = New System.Windows.Forms.Label()
        Me.lblPRTitle = New System.Windows.Forms.Label()
        Me.pnlNavigation.SuspendLayout()
        Me.pnlNavButton.SuspendLayout()
        Me.pnlWinCtrlBox.SuspendLayout()
        CType(Me.picWinCtrlMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWinCtrlMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWinCtrlExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogin.SuspendLayout()
        Me.pnlRegister.SuspendLayout()
        Me.pnlRecovery.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlNavigation
        '
        Me.pnlNavigation.BackColor = System.Drawing.Color.MediumAquamarine
        Me.pnlNavigation.Controls.Add(Me.lblProgramName)
        Me.pnlNavigation.Controls.Add(Me.btnavRecPass)
        Me.pnlNavigation.Controls.Add(Me.btnavLogin)
        Me.pnlNavigation.Controls.Add(Me.btnavRegister)
        Me.pnlNavigation.Controls.Add(Me.btnFormClose)
        Me.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNavigation.Location = New System.Drawing.Point(0, 0)
        Me.pnlNavigation.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(271, 711)
        Me.pnlNavigation.TabIndex = 0
        '
        'lblProgramName
        '
        Me.lblProgramName.AutoSize = True
        Me.lblProgramName.BackColor = System.Drawing.Color.Transparent
        Me.lblProgramName.Font = New System.Drawing.Font("Microsoft JhengHei", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblProgramName.ForeColor = System.Drawing.Color.Green
        Me.lblProgramName.Location = New System.Drawing.Point(16, 59)
        Me.lblProgramName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(211, 43)
        Me.lblProgramName.TabIndex = 4
        Me.lblProgramName.Text = "Power Apps"
        '
        'btnavRecPass
        '
        Me.btnavRecPass.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnavRecPass.FlatAppearance.BorderSize = 0
        Me.btnavRecPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnavRecPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnavRecPass.Image = CType(resources.GetObject("btnavRecPass.Image"), System.Drawing.Image)
        Me.btnavRecPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnavRecPass.Location = New System.Drawing.Point(0, 309)
        Me.btnavRecPass.Margin = New System.Windows.Forms.Padding(0)
        Me.btnavRecPass.Name = "btnavRecPass"
        Me.btnavRecPass.Size = New System.Drawing.Size(268, 86)
        Me.btnavRecPass.TabIndex = 3
        Me.btnavRecPass.Text = "    Forget        Password"
        Me.btnavRecPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnavRecPass.UseVisualStyleBackColor = False
        '
        'btnavLogin
        '
        Me.btnavLogin.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnavLogin.FlatAppearance.BorderSize = 0
        Me.btnavLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnavLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnavLogin.Image = CType(resources.GetObject("btnavLogin.Image"), System.Drawing.Image)
        Me.btnavLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnavLogin.Location = New System.Drawing.Point(0, 137)
        Me.btnavLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnavLogin.Name = "btnavLogin"
        Me.btnavLogin.Size = New System.Drawing.Size(268, 65)
        Me.btnavLogin.TabIndex = 1
        Me.btnavLogin.Text = "     Login"
        Me.btnavLogin.UseVisualStyleBackColor = False
        '
        'btnavRegister
        '
        Me.btnavRegister.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnavRegister.FlatAppearance.BorderSize = 0
        Me.btnavRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnavRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnavRegister.Image = CType(resources.GetObject("btnavRegister.Image"), System.Drawing.Image)
        Me.btnavRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnavRegister.Location = New System.Drawing.Point(0, 223)
        Me.btnavRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.btnavRegister.Name = "btnavRegister"
        Me.btnavRegister.Size = New System.Drawing.Size(268, 65)
        Me.btnavRegister.TabIndex = 1
        Me.btnavRegister.Text = "     Register"
        Me.btnavRegister.UseVisualStyleBackColor = False
        '
        'btnFormClose
        '
        Me.btnFormClose.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnFormClose.FlatAppearance.BorderSize = 0
        Me.btnFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormClose.Image = CType(resources.GetObject("btnFormClose.Image"), System.Drawing.Image)
        Me.btnFormClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormClose.Location = New System.Drawing.Point(0, 418)
        Me.btnFormClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFormClose.Name = "btnFormClose"
        Me.btnFormClose.Size = New System.Drawing.Size(268, 65)
        Me.btnFormClose.TabIndex = 1
        Me.btnFormClose.Text = "     Exit"
        Me.btnFormClose.UseVisualStyleBackColor = False
        '
        'pnlNavButton
        '
        Me.pnlNavButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlNavButton.Controls.Add(Me.pnlWinCtrlBox)
        Me.pnlNavButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNavButton.Location = New System.Drawing.Point(271, 0)
        Me.pnlNavButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlNavButton.Name = "pnlNavButton"
        Me.pnlNavButton.Size = New System.Drawing.Size(1189, 58)
        Me.pnlNavButton.TabIndex = 0
        '
        'pnlWinCtrlBox
        '
        Me.pnlWinCtrlBox.Controls.Add(Me.picWinCtrlMinimize)
        Me.pnlWinCtrlBox.Controls.Add(Me.picWinCtrlMaximize)
        Me.pnlWinCtrlBox.Controls.Add(Me.picWinCtrlExit)
        Me.pnlWinCtrlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlWinCtrlBox.Location = New System.Drawing.Point(1018, 0)
        Me.pnlWinCtrlBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlWinCtrlBox.Name = "pnlWinCtrlBox"
        Me.pnlWinCtrlBox.Size = New System.Drawing.Size(171, 58)
        Me.pnlWinCtrlBox.TabIndex = 4
        '
        'picWinCtrlMinimize
        '
        Me.picWinCtrlMinimize.Image = CType(resources.GetObject("picWinCtrlMinimize.Image"), System.Drawing.Image)
        Me.picWinCtrlMinimize.Location = New System.Drawing.Point(5, 5)
        Me.picWinCtrlMinimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWinCtrlMinimize.Name = "picWinCtrlMinimize"
        Me.picWinCtrlMinimize.Size = New System.Drawing.Size(47, 43)
        Me.picWinCtrlMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWinCtrlMinimize.TabIndex = 2
        Me.picWinCtrlMinimize.TabStop = False
        '
        'picWinCtrlMaximize
        '
        Me.picWinCtrlMaximize.Image = CType(resources.GetObject("picWinCtrlMaximize.Image"), System.Drawing.Image)
        Me.picWinCtrlMaximize.Location = New System.Drawing.Point(60, 5)
        Me.picWinCtrlMaximize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWinCtrlMaximize.Name = "picWinCtrlMaximize"
        Me.picWinCtrlMaximize.Size = New System.Drawing.Size(47, 43)
        Me.picWinCtrlMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWinCtrlMaximize.TabIndex = 2
        Me.picWinCtrlMaximize.TabStop = False
        '
        'picWinCtrlExit
        '
        Me.picWinCtrlExit.Image = CType(resources.GetObject("picWinCtrlExit.Image"), System.Drawing.Image)
        Me.picWinCtrlExit.Location = New System.Drawing.Point(115, 5)
        Me.picWinCtrlExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWinCtrlExit.Name = "picWinCtrlExit"
        Me.picWinCtrlExit.Size = New System.Drawing.Size(47, 43)
        Me.picWinCtrlExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWinCtrlExit.TabIndex = 2
        Me.picWinCtrlExit.TabStop = False
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.txtLpassword)
        Me.pnlLogin.Controls.Add(Me.txtLusername)
        Me.pnlLogin.Controls.Add(Me.lblLpassword)
        Me.pnlLogin.Controls.Add(Me.lblLusername)
        Me.pnlLogin.Controls.Add(Me.lblLogin)
        Me.pnlLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pnlLogin.Location = New System.Drawing.Point(271, 57)
        Me.pnlLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(1189, 655)
        Me.pnlLogin.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(512, 351)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(157, 73)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtLpassword
        '
        Me.txtLpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLpassword.Location = New System.Drawing.Point(512, 255)
        Me.txtLpassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLpassword.MaxLength = 12
        Me.txtLpassword.Name = "txtLpassword"
        Me.txtLpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLpassword.Size = New System.Drawing.Size(296, 36)
        Me.txtLpassword.TabIndex = 3
        '
        'txtLusername
        '
        Me.txtLusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLusername.Location = New System.Drawing.Point(512, 194)
        Me.txtLusername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLusername.MaxLength = 20
        Me.txtLusername.Name = "txtLusername"
        Me.txtLusername.Size = New System.Drawing.Size(296, 36)
        Me.txtLusername.TabIndex = 2
        '
        'lblLpassword
        '
        Me.lblLpassword.AutoSize = True
        Me.lblLpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLpassword.Location = New System.Drawing.Point(365, 258)
        Me.lblLpassword.Name = "lblLpassword"
        Me.lblLpassword.Size = New System.Drawing.Size(131, 29)
        Me.lblLpassword.TabIndex = 1
        Me.lblLpassword.Text = "Password:"
        Me.lblLpassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLusername
        '
        Me.lblLusername.AutoSize = True
        Me.lblLusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLusername.Location = New System.Drawing.Point(361, 198)
        Me.lblLusername.Name = "lblLusername"
        Me.lblLusername.Size = New System.Drawing.Size(137, 29)
        Me.lblLusername.TabIndex = 1
        Me.lblLusername.Text = "Username:"
        Me.lblLusername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(524, 116)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(75, 29)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Login"
        '
        'pnlRegister
        '
        Me.pnlRegister.Controls.Add(Me.lblRTipsIC)
        Me.pnlRegister.Controls.Add(Me.lblRTipsAge)
        Me.pnlRegister.Controls.Add(Me.btncheckstrength)
        Me.pnlRegister.Controls.Add(Me.txtRpassword)
        Me.pnlRegister.Controls.Add(Me.lblRPass)
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.txtRIC)
        Me.pnlRegister.Controls.Add(Me.lblRIC)
        Me.pnlRegister.Controls.Add(Me.txtRUserName)
        Me.pnlRegister.Controls.Add(Me.lblRUserName)
        Me.pnlRegister.Controls.Add(Me.txtRAge)
        Me.pnlRegister.Controls.Add(Me.lblRAge)
        Me.pnlRegister.Controls.Add(Me.txtRLName)
        Me.pnlRegister.Controls.Add(Me.lblRLName)
        Me.pnlRegister.Controls.Add(Me.txtRFName)
        Me.pnlRegister.Controls.Add(Me.lblRFName)
        Me.pnlRegister.Controls.Add(Me.lblRegister)
        Me.pnlRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRegister.Location = New System.Drawing.Point(271, 57)
        Me.pnlRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(1191, 655)
        Me.pnlRegister.TabIndex = 7
        '
        'lblRTipsIC
        '
        Me.lblRTipsIC.AutoSize = True
        Me.lblRTipsIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRTipsIC.Location = New System.Drawing.Point(595, 460)
        Me.lblRTipsIC.Name = "lblRTipsIC"
        Me.lblRTipsIC.Size = New System.Drawing.Size(322, 29)
        Me.lblRTipsIC.TabIndex = 6
        Me.lblRTipsIC.Text = "Please Input Numbers Only"
        Me.lblRTipsIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRTipsIC.Visible = False
        '
        'lblRTipsAge
        '
        Me.lblRTipsAge.AutoSize = True
        Me.lblRTipsAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRTipsAge.Location = New System.Drawing.Point(595, 277)
        Me.lblRTipsAge.Name = "lblRTipsAge"
        Me.lblRTipsAge.Size = New System.Drawing.Size(322, 29)
        Me.lblRTipsAge.TabIndex = 5
        Me.lblRTipsAge.Text = "Please Input Numbers Only"
        Me.lblRTipsAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRTipsAge.Visible = False
        '
        'btncheckstrength
        '
        Me.btncheckstrength.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheckstrength.Location = New System.Drawing.Point(576, 546)
        Me.btncheckstrength.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncheckstrength.Name = "btncheckstrength"
        Me.btncheckstrength.Size = New System.Drawing.Size(277, 46)
        Me.btncheckstrength.TabIndex = 4
        Me.btncheckstrength.Text = "Password Strength"
        Me.btncheckstrength.UseVisualStyleBackColor = True
        '
        'txtRpassword
        '
        Me.txtRpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRpassword.Location = New System.Drawing.Point(376, 399)
        Me.txtRpassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRpassword.MaxLength = 12
        Me.txtRpassword.Name = "txtRpassword"
        Me.txtRpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRpassword.Size = New System.Drawing.Size(181, 36)
        Me.txtRpassword.TabIndex = 2
        '
        'lblRPass
        '
        Me.lblRPass.AutoSize = True
        Me.lblRPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPass.Location = New System.Drawing.Point(195, 402)
        Me.lblRPass.Name = "lblRPass"
        Me.lblRPass.Size = New System.Drawing.Size(131, 29)
        Me.lblRPass.TabIndex = 1
        Me.lblRPass.Text = "Password:"
        Me.lblRPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(268, 546)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(209, 46)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtRIC
        '
        Me.txtRIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRIC.Location = New System.Drawing.Point(376, 460)
        Me.txtRIC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRIC.MaxLength = 12
        Me.txtRIC.Name = "txtRIC"
        Me.txtRIC.Size = New System.Drawing.Size(181, 36)
        Me.txtRIC.TabIndex = 2
        '
        'lblRIC
        '
        Me.lblRIC.AutoSize = True
        Me.lblRIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRIC.Location = New System.Drawing.Point(247, 464)
        Me.lblRIC.Name = "lblRIC"
        Me.lblRIC.Size = New System.Drawing.Size(79, 29)
        Me.lblRIC.TabIndex = 1
        Me.lblRIC.Text = "IC.no:"
        Me.lblRIC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRUserName
        '
        Me.txtRUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUserName.Location = New System.Drawing.Point(376, 332)
        Me.txtRUserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRUserName.MaxLength = 20
        Me.txtRUserName.Name = "txtRUserName"
        Me.txtRUserName.Size = New System.Drawing.Size(181, 36)
        Me.txtRUserName.TabIndex = 2
        '
        'lblRUserName
        '
        Me.lblRUserName.AutoSize = True
        Me.lblRUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUserName.Location = New System.Drawing.Point(189, 336)
        Me.lblRUserName.Name = "lblRUserName"
        Me.lblRUserName.Size = New System.Drawing.Size(137, 29)
        Me.lblRUserName.TabIndex = 1
        Me.lblRUserName.Text = "Username:"
        Me.lblRUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRAge
        '
        Me.txtRAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRAge.Location = New System.Drawing.Point(376, 273)
        Me.txtRAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRAge.MaxLength = 3
        Me.txtRAge.Name = "txtRAge"
        Me.txtRAge.Size = New System.Drawing.Size(181, 36)
        Me.txtRAge.TabIndex = 2
        '
        'lblRAge
        '
        Me.lblRAge.AutoSize = True
        Me.lblRAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRAge.Location = New System.Drawing.Point(261, 272)
        Me.lblRAge.Name = "lblRAge"
        Me.lblRAge.Size = New System.Drawing.Size(65, 29)
        Me.lblRAge.TabIndex = 1
        Me.lblRAge.Text = "Age:"
        Me.lblRAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRLName
        '
        Me.txtRLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRLName.Location = New System.Drawing.Point(376, 217)
        Me.txtRLName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRLName.MaxLength = 25
        Me.txtRLName.Name = "txtRLName"
        Me.txtRLName.Size = New System.Drawing.Size(181, 36)
        Me.txtRLName.TabIndex = 2
        '
        'lblRLName
        '
        Me.lblRLName.AutoSize = True
        Me.lblRLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRLName.Location = New System.Drawing.Point(184, 220)
        Me.lblRLName.Name = "lblRLName"
        Me.lblRLName.Size = New System.Drawing.Size(143, 29)
        Me.lblRLName.TabIndex = 1
        Me.lblRLName.Text = "Last Name:"
        Me.lblRLName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRFName
        '
        Me.txtRFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFName.Location = New System.Drawing.Point(376, 155)
        Me.txtRFName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRFName.MaxLength = 15
        Me.txtRFName.Name = "txtRFName"
        Me.txtRFName.Size = New System.Drawing.Size(181, 36)
        Me.txtRFName.TabIndex = 2
        '
        'lblRFName
        '
        Me.lblRFName.AutoSize = True
        Me.lblRFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFName.Location = New System.Drawing.Point(184, 156)
        Me.lblRFName.Name = "lblRFName"
        Me.lblRFName.Size = New System.Drawing.Size(144, 29)
        Me.lblRFName.TabIndex = 1
        Me.lblRFName.Text = "First Name:"
        Me.lblRFName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(439, 54)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(148, 29)
        Me.lblRegister.TabIndex = 0
        Me.lblRegister.Text = "Registration"
        '
        'pnlRecovery
        '
        Me.pnlRecovery.Controls.Add(Me.lblPRTipsIC)
        Me.pnlRecovery.Controls.Add(Me.btnconchanges)
        Me.pnlRecovery.Controls.Add(Me.txtPRConPass)
        Me.pnlRecovery.Controls.Add(Me.lblPRConPass)
        Me.pnlRecovery.Controls.Add(Me.txtPRNewPass)
        Me.pnlRecovery.Controls.Add(Me.lblPRNewPass)
        Me.pnlRecovery.Controls.Add(Me.txtPRIC)
        Me.pnlRecovery.Controls.Add(Me.lblPRIC)
        Me.pnlRecovery.Controls.Add(Me.txtPRUsername)
        Me.pnlRecovery.Controls.Add(Me.lblPRUsername)
        Me.pnlRecovery.Controls.Add(Me.lblPRTitle)
        Me.pnlRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRecovery.Location = New System.Drawing.Point(271, 57)
        Me.pnlRecovery.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlRecovery.Name = "pnlRecovery"
        Me.pnlRecovery.Size = New System.Drawing.Size(1189, 655)
        Me.pnlRecovery.TabIndex = 5
        '
        'lblPRTipsIC
        '
        Me.lblPRTipsIC.AutoSize = True
        Me.lblPRTipsIC.Location = New System.Drawing.Point(619, 203)
        Me.lblPRTipsIC.Name = "lblPRTipsIC"
        Me.lblPRTipsIC.Size = New System.Drawing.Size(322, 29)
        Me.lblPRTipsIC.TabIndex = 4
        Me.lblPRTipsIC.Text = "Please Input Numbers Only"
        '
        'btnconchanges
        '
        Me.btnconchanges.Location = New System.Drawing.Point(379, 389)
        Me.btnconchanges.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnconchanges.Name = "btnconchanges"
        Me.btnconchanges.Size = New System.Drawing.Size(157, 41)
        Me.btnconchanges.TabIndex = 3
        Me.btnconchanges.Text = "Reset"
        Me.btnconchanges.UseVisualStyleBackColor = True
        '
        'txtPRConPass
        '
        Me.txtPRConPass.Location = New System.Drawing.Point(379, 299)
        Me.txtPRConPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPRConPass.MaxLength = 12
        Me.txtPRConPass.Name = "txtPRConPass"
        Me.txtPRConPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPRConPass.Size = New System.Drawing.Size(203, 36)
        Me.txtPRConPass.TabIndex = 2
        '
        'lblPRConPass
        '
        Me.lblPRConPass.AutoSize = True
        Me.lblPRConPass.Location = New System.Drawing.Point(117, 309)
        Me.lblPRConPass.Name = "lblPRConPass"
        Me.lblPRConPass.Size = New System.Drawing.Size(227, 29)
        Me.lblPRConPass.TabIndex = 1
        Me.lblPRConPass.Text = "Confirm Password:"
        Me.lblPRConPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPRNewPass
        '
        Me.txtPRNewPass.Location = New System.Drawing.Point(379, 245)
        Me.txtPRNewPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPRNewPass.MaxLength = 12
        Me.txtPRNewPass.Name = "txtPRNewPass"
        Me.txtPRNewPass.Size = New System.Drawing.Size(203, 36)
        Me.txtPRNewPass.TabIndex = 2
        '
        'lblPRNewPass
        '
        Me.lblPRNewPass.AutoSize = True
        Me.lblPRNewPass.Location = New System.Drawing.Point(156, 249)
        Me.lblPRNewPass.Name = "lblPRNewPass"
        Me.lblPRNewPass.Size = New System.Drawing.Size(188, 29)
        Me.lblPRNewPass.TabIndex = 1
        Me.lblPRNewPass.Text = "New Password:"
        Me.lblPRNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPRIC
        '
        Me.txtPRIC.Location = New System.Drawing.Point(379, 199)
        Me.txtPRIC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPRIC.MaxLength = 12
        Me.txtPRIC.Name = "txtPRIC"
        Me.txtPRIC.Size = New System.Drawing.Size(203, 36)
        Me.txtPRIC.TabIndex = 2
        '
        'lblPRIC
        '
        Me.lblPRIC.AutoSize = True
        Me.lblPRIC.Location = New System.Drawing.Point(267, 203)
        Me.lblPRIC.Name = "lblPRIC"
        Me.lblPRIC.Size = New System.Drawing.Size(79, 29)
        Me.lblPRIC.TabIndex = 1
        Me.lblPRIC.Text = "IC.no:"
        Me.lblPRIC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPRUsername
        '
        Me.txtPRUsername.Location = New System.Drawing.Point(379, 150)
        Me.txtPRUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPRUsername.MaxLength = 20
        Me.txtPRUsername.Name = "txtPRUsername"
        Me.txtPRUsername.Size = New System.Drawing.Size(203, 36)
        Me.txtPRUsername.TabIndex = 2
        '
        'lblPRUsername
        '
        Me.lblPRUsername.AutoSize = True
        Me.lblPRUsername.Location = New System.Drawing.Point(209, 154)
        Me.lblPRUsername.Name = "lblPRUsername"
        Me.lblPRUsername.Size = New System.Drawing.Size(137, 29)
        Me.lblPRUsername.TabIndex = 1
        Me.lblPRUsername.Text = "Username:"
        Me.lblPRUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPRTitle
        '
        Me.lblPRTitle.AutoSize = True
        Me.lblPRTitle.Location = New System.Drawing.Point(273, 54)
        Me.lblPRTitle.Name = "lblPRTitle"
        Me.lblPRTitle.Size = New System.Drawing.Size(238, 29)
        Me.lblPRTitle.TabIndex = 0
        Me.lblPRTitle.Text = "Password Recovery"
        '
        'LoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1460, 711)
        Me.Controls.Add(Me.pnlNavButton)
        Me.Controls.Add(Me.pnlNavigation)
        Me.Controls.Add(Me.pnlRecovery)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LoginRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginRegister"
        Me.pnlNavigation.ResumeLayout(False)
        Me.pnlNavigation.PerformLayout()
        Me.pnlNavButton.ResumeLayout(False)
        Me.pnlWinCtrlBox.ResumeLayout(False)
        CType(Me.picWinCtrlMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWinCtrlMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWinCtrlExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.pnlRecovery.ResumeLayout(False)
        Me.pnlRecovery.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents btnavLogin As Button
    Friend WithEvents btnavRegister As Button
    Friend WithEvents btnFormClose As Button
    Friend WithEvents pnlNavButton As Panel
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtLpassword As TextBox
    Friend WithEvents txtLusername As TextBox
    Friend WithEvents lblLpassword As Label
    Friend WithEvents lblLusername As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtRpassword As TextBox
    Friend WithEvents lblRPass As Label
    Friend WithEvents txtRIC As TextBox
    Friend WithEvents lblRIC As Label
    Friend WithEvents txtRUserName As TextBox
    Friend WithEvents lblRUserName As Label
    Friend WithEvents txtRAge As TextBox
    Friend WithEvents lblRAge As Label
    Friend WithEvents txtRLName As TextBox
    Friend WithEvents lblRLName As Label
    Friend WithEvents txtRFName As TextBox
    Friend WithEvents lblRFName As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents btnconchanges As Button
    Friend WithEvents txtPRConPass As TextBox
    Friend WithEvents lblPRConPass As Label
    Friend WithEvents txtPRNewPass As TextBox
    Friend WithEvents lblPRNewPass As Label
    Friend WithEvents txtPRIC As TextBox
    Friend WithEvents lblPRIC As Label
    Friend WithEvents txtPRUsername As TextBox
    Friend WithEvents lblPRUsername As Label
    Friend WithEvents lblPRTitle As Label
    Friend WithEvents btncheckstrength As Button
    Friend WithEvents lblRTipsIC As Label
    Friend WithEvents lblRTipsAge As Label
    Friend WithEvents lblPRTipsIC As Label
    Friend WithEvents pnlWinCtrlBox As Panel
    Friend WithEvents picWinCtrlMinimize As PictureBox
    Friend WithEvents picWinCtrlMaximize As PictureBox
    Friend WithEvents picWinCtrlExit As PictureBox
    Friend WithEvents btnavRecPass As Button
    Friend WithEvents lblProgramName As Label
    Friend WithEvents pnlRegister As Panel
    Friend WithEvents pnlRecovery As Panel
End Class
