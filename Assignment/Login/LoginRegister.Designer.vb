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
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnavLogin = New System.Windows.Forms.Button()
        Me.btnavRegister = New System.Windows.Forms.Button()
        Me.btnavRecPass = New System.Windows.Forms.Button()
        Me.btnFormClose = New System.Windows.Forms.Button()
        Me.pnlNavButton = New System.Windows.Forms.Panel()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtLpassword = New System.Windows.Forms.TextBox()
        Me.txtLusername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.lblRTipsIC = New System.Windows.Forms.Label()
        Me.lblRTipsAge = New System.Windows.Forms.Label()
        Me.btncheckstrength = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtRpassword = New System.Windows.Forms.TextBox()
        Me.lblRPass = New System.Windows.Forms.Label()
        Me.txtRIC = New System.Windows.Forms.TextBox()
        Me.lblRIC = New System.Windows.Forms.Label()
        Me.txtRUserName = New System.Windows.Forms.TextBox()
        Me.lblRUserName = New System.Windows.Forms.Label()
        Me.txtRAge = New System.Windows.Forms.TextBox()
        Me.lblRAge = New System.Windows.Forms.Label()
        Me.txtRLName = New System.Windows.Forms.TextBox()
        Me.lblRLName = New System.Windows.Forms.Label()
        Me.txtRFName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.pnlLogin.SuspendLayout()
        Me.pnlRegister.SuspendLayout()
        Me.pnlRecovery.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlNavigation
        '
        Me.pnlNavigation.Controls.Add(Me.Label1)
        Me.pnlNavigation.Controls.Add(Me.btnavLogin)
        Me.pnlNavigation.Controls.Add(Me.btnavRegister)
        Me.pnlNavigation.Controls.Add(Me.btnavRecPass)
        Me.pnlNavigation.Controls.Add(Me.btnFormClose)
        Me.pnlNavigation.Location = New System.Drawing.Point(0, 0)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(200, 502)
        Me.pnlNavigation.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Power App"
        '
        'btnavLogin
        '
        Me.btnavLogin.Location = New System.Drawing.Point(0, 143)
        Me.btnavLogin.Name = "btnavLogin"
        Me.btnavLogin.Size = New System.Drawing.Size(200, 45)
        Me.btnavLogin.TabIndex = 1
        Me.btnavLogin.Text = "Login"
        Me.btnavLogin.UseVisualStyleBackColor = True
        '
        'btnavRegister
        '
        Me.btnavRegister.Location = New System.Drawing.Point(0, 227)
        Me.btnavRegister.Name = "btnavRegister"
        Me.btnavRegister.Size = New System.Drawing.Size(200, 45)
        Me.btnavRegister.TabIndex = 1
        Me.btnavRegister.Text = "Register"
        Me.btnavRegister.UseVisualStyleBackColor = True
        '
        'btnavRecPass
        '
        Me.btnavRecPass.Location = New System.Drawing.Point(0, 302)
        Me.btnavRecPass.Name = "btnavRecPass"
        Me.btnavRecPass.Size = New System.Drawing.Size(200, 45)
        Me.btnavRecPass.TabIndex = 1
        Me.btnavRecPass.Text = "Password Recovery"
        Me.btnavRecPass.UseVisualStyleBackColor = True
        '
        'btnFormClose
        '
        Me.btnFormClose.Location = New System.Drawing.Point(0, 379)
        Me.btnFormClose.Name = "btnFormClose"
        Me.btnFormClose.Size = New System.Drawing.Size(200, 45)
        Me.btnFormClose.TabIndex = 1
        Me.btnFormClose.Text = "Close"
        Me.btnFormClose.UseVisualStyleBackColor = True
        '
        'pnlNavButton
        '
        Me.pnlNavButton.Location = New System.Drawing.Point(201, 0)
        Me.pnlNavButton.Name = "pnlNavButton"
        Me.pnlNavButton.Size = New System.Drawing.Size(672, 58)
        Me.pnlNavButton.TabIndex = 0
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.txtLpassword)
        Me.pnlLogin.Controls.Add(Me.txtLusername)
        Me.pnlLogin.Controls.Add(Me.Label5)
        Me.pnlLogin.Controls.Add(Me.Label4)
        Me.pnlLogin.Controls.Add(Me.Label3)
        Me.pnlLogin.Location = New System.Drawing.Point(201, 55)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(669, 447)
        Me.pnlLogin.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(251, 268)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(158, 42)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtLpassword
        '
        Me.txtLpassword.Location = New System.Drawing.Point(300, 181)
        Me.txtLpassword.MaxLength = 12
        Me.txtLpassword.Name = "txtLpassword"
        Me.txtLpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLpassword.Size = New System.Drawing.Size(151, 22)
        Me.txtLpassword.TabIndex = 3
        '
        'txtLusername
        '
        Me.txtLusername.Location = New System.Drawing.Point(300, 120)
        Me.txtLusername.MaxLength = 20
        Me.txtLusername.Name = "txtLusername"
        Me.txtLusername.Size = New System.Drawing.Size(151, 22)
        Me.txtLusername.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Login"
        '
        'pnlRegister
        '
        Me.pnlRegister.Controls.Add(Me.lblRTipsIC)
        Me.pnlRegister.Controls.Add(Me.lblRTipsAge)
        Me.pnlRegister.Controls.Add(Me.btncheckstrength)
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.txtRpassword)
        Me.pnlRegister.Controls.Add(Me.lblRPass)
        Me.pnlRegister.Controls.Add(Me.txtRIC)
        Me.pnlRegister.Controls.Add(Me.lblRIC)
        Me.pnlRegister.Controls.Add(Me.txtRUserName)
        Me.pnlRegister.Controls.Add(Me.lblRUserName)
        Me.pnlRegister.Controls.Add(Me.txtRAge)
        Me.pnlRegister.Controls.Add(Me.lblRAge)
        Me.pnlRegister.Controls.Add(Me.txtRLName)
        Me.pnlRegister.Controls.Add(Me.lblRLName)
        Me.pnlRegister.Controls.Add(Me.txtRFName)
        Me.pnlRegister.Controls.Add(Me.Label7)
        Me.pnlRegister.Controls.Add(Me.Label6)
        Me.pnlRegister.Location = New System.Drawing.Point(199, 56)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(669, 447)
        Me.pnlRegister.TabIndex = 3
        '
        'lblRTipsIC
        '
        Me.lblRTipsIC.AutoSize = True
        Me.lblRTipsIC.Location = New System.Drawing.Point(484, 292)
        Me.lblRTipsIC.Name = "lblRTipsIC"
        Me.lblRTipsIC.Size = New System.Drawing.Size(165, 17)
        Me.lblRTipsIC.TabIndex = 6
        Me.lblRTipsIC.Text = "Please Put Only Numeric"
        '
        'lblRTipsAge
        '
        Me.lblRTipsAge.AutoSize = True
        Me.lblRTipsAge.Location = New System.Drawing.Point(484, 157)
        Me.lblRTipsAge.Name = "lblRTipsAge"
        Me.lblRTipsAge.Size = New System.Drawing.Size(165, 17)
        Me.lblRTipsAge.TabIndex = 5
        Me.lblRTipsAge.Text = "Please Put Only Numeric"
        '
        'btncheckstrength
        '
        Me.btncheckstrength.Location = New System.Drawing.Point(465, 351)
        Me.btncheckstrength.Name = "btncheckstrength"
        Me.btncheckstrength.Size = New System.Drawing.Size(136, 45)
        Me.btncheckstrength.TabIndex = 4
        Me.btncheckstrength.Text = "Password Strength"
        Me.btncheckstrength.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(257, 351)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(163, 45)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtRpassword
        '
        Me.txtRpassword.Location = New System.Drawing.Point(279, 239)
        Me.txtRpassword.MaxLength = 12
        Me.txtRpassword.Name = "txtRpassword"
        Me.txtRpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRpassword.Size = New System.Drawing.Size(181, 22)
        Me.txtRpassword.TabIndex = 2
        '
        'lblRPass
        '
        Me.lblRPass.AutoSize = True
        Me.lblRPass.Location = New System.Drawing.Point(157, 244)
        Me.lblRPass.Name = "lblRPass"
        Me.lblRPass.Size = New System.Drawing.Size(73, 17)
        Me.lblRPass.TabIndex = 1
        Me.lblRPass.Text = "Password:"
        '
        'txtRIC
        '
        Me.txtRIC.Location = New System.Drawing.Point(279, 287)
        Me.txtRIC.MaxLength = 12
        Me.txtRIC.Name = "txtRIC"
        Me.txtRIC.Size = New System.Drawing.Size(181, 22)
        Me.txtRIC.TabIndex = 2
        '
        'lblRIC
        '
        Me.lblRIC.AutoSize = True
        Me.lblRIC.Location = New System.Drawing.Point(186, 292)
        Me.lblRIC.Name = "lblRIC"
        Me.lblRIC.Size = New System.Drawing.Size(44, 17)
        Me.lblRIC.TabIndex = 1
        Me.lblRIC.Text = "IC.no:"
        '
        'txtRUserName
        '
        Me.txtRUserName.Location = New System.Drawing.Point(279, 194)
        Me.txtRUserName.MaxLength = 20
        Me.txtRUserName.Name = "txtRUserName"
        Me.txtRUserName.Size = New System.Drawing.Size(181, 22)
        Me.txtRUserName.TabIndex = 2
        '
        'lblRUserName
        '
        Me.lblRUserName.AutoSize = True
        Me.lblRUserName.Location = New System.Drawing.Point(153, 199)
        Me.lblRUserName.Name = "lblRUserName"
        Me.lblRUserName.Size = New System.Drawing.Size(77, 17)
        Me.lblRUserName.TabIndex = 1
        Me.lblRUserName.Text = "Username:"
        '
        'txtRAge
        '
        Me.txtRAge.Location = New System.Drawing.Point(279, 152)
        Me.txtRAge.MaxLength = 3
        Me.txtRAge.Name = "txtRAge"
        Me.txtRAge.Size = New System.Drawing.Size(181, 22)
        Me.txtRAge.TabIndex = 2
        '
        'lblRAge
        '
        Me.lblRAge.AutoSize = True
        Me.lblRAge.Location = New System.Drawing.Point(193, 157)
        Me.lblRAge.Name = "lblRAge"
        Me.lblRAge.Size = New System.Drawing.Size(37, 17)
        Me.lblRAge.TabIndex = 1
        Me.lblRAge.Text = "Age:"
        '
        'txtRLName
        '
        Me.txtRLName.Location = New System.Drawing.Point(279, 110)
        Me.txtRLName.MaxLength = 25
        Me.txtRLName.Name = "txtRLName"
        Me.txtRLName.Size = New System.Drawing.Size(181, 22)
        Me.txtRLName.TabIndex = 2
        '
        'lblRLName
        '
        Me.lblRLName.AutoSize = True
        Me.lblRLName.Location = New System.Drawing.Point(175, 115)
        Me.lblRLName.Name = "lblRLName"
        Me.lblRLName.Size = New System.Drawing.Size(55, 17)
        Me.lblRLName.TabIndex = 1
        Me.lblRLName.Text = "Lname:"
        '
        'txtRFName
        '
        Me.txtRFName.Location = New System.Drawing.Point(279, 69)
        Me.txtRFName.MaxLength = 15
        Me.txtRFName.Name = "txtRFName"
        Me.txtRFName.Size = New System.Drawing.Size(181, 22)
        Me.txtRFName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Fname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Register Now!"
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
        Me.pnlRecovery.Location = New System.Drawing.Point(200, 56)
        Me.pnlRecovery.Name = "pnlRecovery"
        Me.pnlRecovery.Size = New System.Drawing.Size(669, 447)
        Me.pnlRecovery.TabIndex = 4
        '
        'lblPRTipsIC
        '
        Me.lblPRTipsIC.AutoSize = True
        Me.lblPRTipsIC.Location = New System.Drawing.Point(483, 115)
        Me.lblPRTipsIC.Name = "lblPRTipsIC"
        Me.lblPRTipsIC.Size = New System.Drawing.Size(165, 17)
        Me.lblPRTipsIC.TabIndex = 4
        Me.lblPRTipsIC.Text = "Please Put Only Numeric"
        '
        'btnconchanges
        '
        Me.btnconchanges.Location = New System.Drawing.Point(252, 250)
        Me.btnconchanges.Name = "btnconchanges"
        Me.btnconchanges.Size = New System.Drawing.Size(158, 41)
        Me.btnconchanges.TabIndex = 3
        Me.btnconchanges.Text = "Recover"
        Me.btnconchanges.UseVisualStyleBackColor = True
        '
        'txtPRConPass
        '
        Me.txtPRConPass.Location = New System.Drawing.Point(256, 196)
        Me.txtPRConPass.MaxLength = 12
        Me.txtPRConPass.Name = "txtPRConPass"
        Me.txtPRConPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPRConPass.Size = New System.Drawing.Size(203, 22)
        Me.txtPRConPass.TabIndex = 2
        '
        'lblPRConPass
        '
        Me.lblPRConPass.AutoSize = True
        Me.lblPRConPass.Location = New System.Drawing.Point(104, 202)
        Me.lblPRConPass.Name = "lblPRConPass"
        Me.lblPRConPass.Size = New System.Drawing.Size(125, 17)
        Me.lblPRConPass.TabIndex = 1
        Me.lblPRConPass.Text = "Confirm Password:"
        '
        'txtPRNewPass
        '
        Me.txtPRNewPass.Location = New System.Drawing.Point(256, 152)
        Me.txtPRNewPass.MaxLength = 12
        Me.txtPRNewPass.Name = "txtPRNewPass"
        Me.txtPRNewPass.Size = New System.Drawing.Size(203, 22)
        Me.txtPRNewPass.TabIndex = 2
        '
        'lblPRNewPass
        '
        Me.lblPRNewPass.AutoSize = True
        Me.lblPRNewPass.Location = New System.Drawing.Point(125, 152)
        Me.lblPRNewPass.Name = "lblPRNewPass"
        Me.lblPRNewPass.Size = New System.Drawing.Size(104, 17)
        Me.lblPRNewPass.TabIndex = 1
        Me.lblPRNewPass.Text = "New Password:"
        '
        'txtPRIC
        '
        Me.txtPRIC.Location = New System.Drawing.Point(256, 110)
        Me.txtPRIC.MaxLength = 12
        Me.txtPRIC.Name = "txtPRIC"
        Me.txtPRIC.Size = New System.Drawing.Size(203, 22)
        Me.txtPRIC.TabIndex = 2
        '
        'lblPRIC
        '
        Me.lblPRIC.AutoSize = True
        Me.lblPRIC.Location = New System.Drawing.Point(185, 115)
        Me.lblPRIC.Name = "lblPRIC"
        Me.lblPRIC.Size = New System.Drawing.Size(44, 17)
        Me.lblPRIC.TabIndex = 1
        Me.lblPRIC.Text = "IC.no:"
        '
        'txtPRUsername
        '
        Me.txtPRUsername.Location = New System.Drawing.Point(256, 66)
        Me.txtPRUsername.MaxLength = 20
        Me.txtPRUsername.Name = "txtPRUsername"
        Me.txtPRUsername.Size = New System.Drawing.Size(203, 22)
        Me.txtPRUsername.TabIndex = 2
        '
        'lblPRUsername
        '
        Me.lblPRUsername.AutoSize = True
        Me.lblPRUsername.Location = New System.Drawing.Point(152, 69)
        Me.lblPRUsername.Name = "lblPRUsername"
        Me.lblPRUsername.Size = New System.Drawing.Size(77, 17)
        Me.lblPRUsername.TabIndex = 1
        Me.lblPRUsername.Text = "Username:"
        '
        'lblPRTitle
        '
        Me.lblPRTitle.AutoSize = True
        Me.lblPRTitle.Location = New System.Drawing.Point(274, 30)
        Me.lblPRTitle.Name = "lblPRTitle"
        Me.lblPRTitle.Size = New System.Drawing.Size(133, 17)
        Me.lblPRTitle.TabIndex = 0
        Me.lblPRTitle.Text = "Password Recovery"
        '
        'LoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 501)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.pnlRecovery)
        Me.Controls.Add(Me.pnlNavigation)
        Me.Controls.Add(Me.pnlNavButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginRegister"
        Me.Text = "LoginRegister"
        Me.pnlNavigation.ResumeLayout(False)
        Me.pnlNavigation.PerformLayout()
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
    Friend WithEvents btnavRecPass As Button
    Friend WithEvents btnFormClose As Button
    Friend WithEvents pnlNavButton As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtLpassword As TextBox
    Friend WithEvents txtLusername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlRegister As Panel
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlRecovery As Panel
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
End Class
