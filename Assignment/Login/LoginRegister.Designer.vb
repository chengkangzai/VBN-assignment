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
        Me.navigation = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnavLogin = New System.Windows.Forms.Button()
        Me.btnavRegister = New System.Windows.Forms.Button()
        Me.btnavRecPass = New System.Windows.Forms.Button()
        Me.btnFormClose = New System.Windows.Forms.Button()
        Me.navbutton = New System.Windows.Forms.Panel()
        Me.login = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtLpassword = New System.Windows.Forms.TextBox()
        Me.txtLusername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.register = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncheckconnect = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtRpassword = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRic = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRusername = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRage = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRlname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRfname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Recovery = New System.Windows.Forms.Panel()
        Me.btnconchanges = New System.Windows.Forms.Button()
        Me.txtPRconpass = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPRnewpass = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPRic = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPRusername = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.navigation.SuspendLayout()
        Me.login.SuspendLayout()
        Me.register.SuspendLayout()
        Me.Recovery.SuspendLayout()
        Me.SuspendLayout()
        '
        'navigation
        '
        Me.navigation.Controls.Add(Me.Label1)
        Me.navigation.Controls.Add(Me.btnavLogin)
        Me.navigation.Controls.Add(Me.btnavRegister)
        Me.navigation.Controls.Add(Me.btnavRecPass)
        Me.navigation.Controls.Add(Me.btnFormClose)
        Me.navigation.Location = New System.Drawing.Point(0, 0)
        Me.navigation.Name = "navigation"
        Me.navigation.Size = New System.Drawing.Size(200, 502)
        Me.navigation.TabIndex = 0
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
        'navbutton
        '
        Me.navbutton.Location = New System.Drawing.Point(201, 0)
        Me.navbutton.Name = "navbutton"
        Me.navbutton.Size = New System.Drawing.Size(672, 58)
        Me.navbutton.TabIndex = 0
        '
        'login
        '
        Me.login.Controls.Add(Me.btnLogin)
        Me.login.Controls.Add(Me.txtLpassword)
        Me.login.Controls.Add(Me.txtLusername)
        Me.login.Controls.Add(Me.Label5)
        Me.login.Controls.Add(Me.Label4)
        Me.login.Controls.Add(Me.Label3)
        Me.login.Location = New System.Drawing.Point(201, 55)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(669, 447)
        Me.login.TabIndex = 2
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
        Me.txtLpassword.Name = "txtLpassword"
        Me.txtLpassword.Size = New System.Drawing.Size(151, 22)
        Me.txtLpassword.TabIndex = 3
        '
        'txtLusername
        '
        Me.txtLusername.Location = New System.Drawing.Point(300, 120)
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
        'register
        '
        Me.register.Controls.Add(Me.Label18)
        Me.register.Controls.Add(Me.Label2)
        Me.register.Controls.Add(Me.btncheckconnect)
        Me.register.Controls.Add(Me.btnRegister)
        Me.register.Controls.Add(Me.txtRpassword)
        Me.register.Controls.Add(Me.Label12)
        Me.register.Controls.Add(Me.txtRic)
        Me.register.Controls.Add(Me.Label11)
        Me.register.Controls.Add(Me.txtRusername)
        Me.register.Controls.Add(Me.Label10)
        Me.register.Controls.Add(Me.txtRage)
        Me.register.Controls.Add(Me.Label9)
        Me.register.Controls.Add(Me.txtRlname)
        Me.register.Controls.Add(Me.Label8)
        Me.register.Controls.Add(Me.txtRfname)
        Me.register.Controls.Add(Me.Label7)
        Me.register.Controls.Add(Me.Label6)
        Me.register.Location = New System.Drawing.Point(199, 56)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(669, 447)
        Me.register.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(484, 292)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(165, 17)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Please Put Only Numeric"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(484, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please Put Only Numeric"
        '
        'btncheckconnect
        '
        Me.btncheckconnect.Location = New System.Drawing.Point(465, 351)
        Me.btncheckconnect.Name = "btncheckconnect"
        Me.btncheckconnect.Size = New System.Drawing.Size(136, 45)
        Me.btncheckconnect.TabIndex = 4
        Me.btncheckconnect.Text = "Check Connection"
        Me.btncheckconnect.UseVisualStyleBackColor = True
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
        Me.txtRpassword.Name = "txtRpassword"
        Me.txtRpassword.Size = New System.Drawing.Size(181, 22)
        Me.txtRpassword.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(157, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Password:"
        '
        'txtRic
        '
        Me.txtRic.Location = New System.Drawing.Point(279, 287)
        Me.txtRic.Name = "txtRic"
        Me.txtRic.Size = New System.Drawing.Size(181, 22)
        Me.txtRic.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(186, 292)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "IC.no:"
        '
        'txtRusername
        '
        Me.txtRusername.Location = New System.Drawing.Point(279, 194)
        Me.txtRusername.Name = "txtRusername"
        Me.txtRusername.Size = New System.Drawing.Size(181, 22)
        Me.txtRusername.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(153, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Username:"
        '
        'txtRage
        '
        Me.txtRage.Location = New System.Drawing.Point(279, 152)
        Me.txtRage.Name = "txtRage"
        Me.txtRage.Size = New System.Drawing.Size(181, 22)
        Me.txtRage.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(193, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Age:"
        '
        'txtRlname
        '
        Me.txtRlname.Location = New System.Drawing.Point(279, 110)
        Me.txtRlname.Name = "txtRlname"
        Me.txtRlname.Size = New System.Drawing.Size(181, 22)
        Me.txtRlname.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(175, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Lname:"
        '
        'txtRfname
        '
        Me.txtRfname.Location = New System.Drawing.Point(279, 69)
        Me.txtRfname.Name = "txtRfname"
        Me.txtRfname.Size = New System.Drawing.Size(181, 22)
        Me.txtRfname.TabIndex = 2
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
        'Recovery
        '
        Me.Recovery.Controls.Add(Me.btnconchanges)
        Me.Recovery.Controls.Add(Me.txtPRconpass)
        Me.Recovery.Controls.Add(Me.Label17)
        Me.Recovery.Controls.Add(Me.txtPRnewpass)
        Me.Recovery.Controls.Add(Me.Label16)
        Me.Recovery.Controls.Add(Me.txtPRic)
        Me.Recovery.Controls.Add(Me.Label15)
        Me.Recovery.Controls.Add(Me.txtPRusername)
        Me.Recovery.Controls.Add(Me.Label14)
        Me.Recovery.Controls.Add(Me.Label13)
        Me.Recovery.Location = New System.Drawing.Point(200, 56)
        Me.Recovery.Name = "Recovery"
        Me.Recovery.Size = New System.Drawing.Size(669, 447)
        Me.Recovery.TabIndex = 4
        '
        'btnconchanges
        '
        Me.btnconchanges.Location = New System.Drawing.Point(252, 250)
        Me.btnconchanges.Name = "btnconchanges"
        Me.btnconchanges.Size = New System.Drawing.Size(158, 41)
        Me.btnconchanges.TabIndex = 3
        Me.btnconchanges.Text = "Confirm Changes"
        Me.btnconchanges.UseVisualStyleBackColor = True
        '
        'txtPRconpass
        '
        Me.txtPRconpass.Location = New System.Drawing.Point(256, 196)
        Me.txtPRconpass.Name = "txtPRconpass"
        Me.txtPRconpass.Size = New System.Drawing.Size(203, 22)
        Me.txtPRconpass.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(104, 202)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 17)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Confirm Password:"
        '
        'txtPRnewpass
        '
        Me.txtPRnewpass.Location = New System.Drawing.Point(256, 152)
        Me.txtPRnewpass.Name = "txtPRnewpass"
        Me.txtPRnewpass.Size = New System.Drawing.Size(203, 22)
        Me.txtPRnewpass.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(125, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 17)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "New Password:"
        '
        'txtPRic
        '
        Me.txtPRic.Location = New System.Drawing.Point(256, 110)
        Me.txtPRic.Name = "txtPRic"
        Me.txtPRic.Size = New System.Drawing.Size(203, 22)
        Me.txtPRic.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(185, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "IC.no:"
        '
        'txtPRusername
        '
        Me.txtPRusername.Location = New System.Drawing.Point(256, 66)
        Me.txtPRusername.Name = "txtPRusername"
        Me.txtPRusername.Size = New System.Drawing.Size(203, 22)
        Me.txtPRusername.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(152, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 17)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Username:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(274, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Password Recovery"
        '
        'LoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 501)
        Me.Controls.Add(Me.Recovery)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.register)
        Me.Controls.Add(Me.navigation)
        Me.Controls.Add(Me.navbutton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginRegister"
        Me.Text = "LoginRegister"
        Me.navigation.ResumeLayout(False)
        Me.navigation.PerformLayout()
        Me.login.ResumeLayout(False)
        Me.login.PerformLayout()
        Me.register.ResumeLayout(False)
        Me.register.PerformLayout()
        Me.Recovery.ResumeLayout(False)
        Me.Recovery.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents navigation As Panel
    Friend WithEvents btnavLogin As Button
    Friend WithEvents btnavRegister As Button
    Friend WithEvents btnavRecPass As Button
    Friend WithEvents btnFormClose As Button
    Friend WithEvents navbutton As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents login As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtLpassword As TextBox
    Friend WithEvents txtLusername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents register As Panel
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtRpassword As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRic As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRusername As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRage As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRlname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRfname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Recovery As Panel
    Friend WithEvents btnconchanges As Button
    Friend WithEvents txtPRconpass As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPRnewpass As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPRic As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPRusername As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btncheckconnect As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label2 As Label
End Class
