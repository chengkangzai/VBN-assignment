'References
'Login Windows Form=https://www.youtube.com/watch?v=1TqHEsK9ncI&t=320s
'Register Windows Form=https://www.youtube.com/watch?v=zlUA458CGUU&t=720s

Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class LoginRegister
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

#Region "Login Function"
    'Login
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chin Wei\Desktop\VBimdb.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        Dim stm As String = "select * from [User] where U_Username='" & txtLusername.Text & "' And U_Password='" & txtLpassword.Text & "' "
        cmd = New SqlCommand(stm, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader

        If (txtLusername.Text = "" Or txtLpassword.Text = "") Then
            MessageBox.Show("Please Enter Every Details", "Incomplete Data/Details")
        Else
            If reader.Read Then
                Me.Hide()
                Home.Show()
            Else
                MessageBox.Show("Invalid Username/Password", "Error")
                txtLusername.Clear()
                txtLpassword.Clear()
            End If
        End If
    End Sub

    'Register
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Assignments\Semester 3\VB.Net\vbimdb.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from [User] where U_Username='" & txtRUserName.Text & "' "
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Username Already Exist", "Existed Username")
                con.Close()
                txtRFName.Clear()
                txtRLName.Clear()
                txtRAge.Clear()
                txtRUserName.Clear()
                txtRpassword.Clear()
                txtRIC.Clear()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("insert into [User] (U_Fname, U_Lname, U_Age, U_Username, U_Password, U_ICnumber) values ('" & txtRFName.Text & "', '" & txtRLName.Text & "', '" & txtRAge.Text & "', '" & txtRUserName.Text & "', '" & txtRpassword.Text & "', '" & txtRIC.Text & "')", con)
                If (txtRFName.Text = "" Or txtRLName.Text = "" Or txtRAge.Text = "" Or txtRUserName.Text = "" Or txtRpassword.Text = "" Or txtRIC.Text = "") Then
                    MessageBox.Show("Please Enter Every Details", "Incomplete Data/Details")
                Else
                    If Not IsNumeric(txtRAge.Text) Or Not IsNumeric(txtRIC.Text) Then
                        MessageBox.Show("Please Enter Value Only", "Invalid Alphabetical and Special Case")
                    Else
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Account Has Created", "Successfully Registered")
                    End If
                    con.Close()
                    txtRFName.Clear()
                    txtRLName.Clear()
                    txtRAge.Clear()
                    txtRUserName.Clear()
                    txtRpassword.Clear()
                    txtRIC.Clear()
                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Unsuccessful Register", "Error")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btncheckstrength.Click
        If txtRpassword.Text.Length <= 6 Then
            MessageBox.Show("Weak Password", "Password Strength")
        Else
            MessageBox.Show("Strong Password", "Password Strength")
        End If
    End Sub

    'Recovery
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnconchanges.Click
        If txtPRNewPass.Text <> txtPRConPass.Text Then
            MessageBox.Show("Please Match Your Password", "Password Does Not Match")
        End If

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Assignments\Semester 3\VB.Net\vbimdb.mdf;Integrated Security=True;Connect Timeout=30")
        If txtPRNewPass.Text = txtPRConPass.Text Then
            Try
                con.Open()
                cmd = New SqlCommand("update [User] set U_Password = '" & txtPRNewPass.Text & "' where U_Username= '" & txtPRUsername.Text & "' And U_ICnumber='" & txtPRIC.Text & "'", con)
                If (txtPRUsername.Text = "" Or txtPRIC.Text = "" Or txtPRNewPass.Text = "" Or txtPRConPass.Text = "") Then
                    MessageBox.Show("Please enter every info in the textbox", "Incomplete data")
                Else
                    If Not IsNumeric(txtPRIC.Text) Then
                        MessageBox.Show("Please Enter Value Only", "Invalid Word and Special Cases")
                    End If
                    If (cmd.ExecuteNonQuery() > 0) Then
                        MessageBox.Show("Password Successfully Recover", "Successful")
                        con.Close()
                        txtPRUsername.Clear()
                        txtPRIC.Clear()
                        txtPRNewPass.Clear()
                        txtPRConPass.Clear()
                    Else
                        MessageBox.Show("Wrong Username or IC number", "Wrong Details")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Recovery Unsuccessful", "Error")
            End Try
        End If
    End Sub
#End Region
#Region "Windows Control "
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFormClose.Click, picWinCtrlExit.Click
        Dim result As Integer = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub picWinCtrlMinimize_Click(sender As Object, e As EventArgs) Handles picWinCtrlMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picWinCtrlMaximize_Click(sender As Object, e As EventArgs) Handles picWinCtrlMaximize.Click, picWinCtrlMaximize.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub


#End Region
#Region "Navigation Button Show"
    'btnavigation

    Private Sub btnavLogin_Click(sender As Object, e As EventArgs) Handles btnavLogin.Click
        pnlLogin.Visible = True
        pnlRecovery.Visible = False
        pnlRegister.Visible = False
    End Sub

    Private Sub btnavRegister_Click(sender As Object, e As EventArgs) Handles btnavRegister.Click
        pnlLogin.Visible = False
        pnlRecovery.Visible = False
        pnlRegister.Visible = True
    End Sub

    Private Sub btnavRecPass_Click(sender As Object, e As EventArgs) Handles btnavRecPass.Click
        pnlLogin.Visible = False
        pnlRecovery.Visible = True
        pnlRegister.Visible = False
    End Sub

    Private Sub LoginRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLogin.Visible = True
        pnlRecovery.Visible = False
        pnlRegister.Visible = False
        lblPRTipsIC.Visible = False
        lblRTipsAge.Visible = False
        lblRTipsIC.Visible = False
    End Sub
#End Region
#Region "Data Validation"
    'Data Validation label show(password recovery)

    Private Sub txtPRIC_Validating(sender As Object, e As CancelEventArgs) Handles txtPRIC.Validating
        If IsNumeric(txtPRIC.Text) Then
            lblPRTipsIC.Visible = False
        Else
            lblPRTipsIC.Visible = True
        End If
    End Sub

    'Data Validation label show(register)
    Private Sub txtRage_Validating(sender As Object, e As CancelEventArgs) Handles txtRAge.Validating
        If IsNumeric(txtRAge.Text) Then
            lblRTipsAge.Visible = False
        Else
            lblRTipsAge.Visible = True
        End If
    End Sub

    Private Sub txtRic_Validating(sender As Object, e As CancelEventArgs) Handles txtRIC.Validating
        If IsNumeric(txtRIC.Text) Then
            lblRTipsIC.Visible = False
        Else
            lblRTipsIC.Visible = True
        End If
    End Sub


#End Region
#Region "Windows Drag"
    Dim drag As Boolean = False
    Dim mousex As Integer
    Dim mousey As Integer
    ' REF: https://www.dreamincode.net/forums/topic/135768-moving-a-borderless-form/
    Private Sub pnlNavButton_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlNavButton.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub pnlNavButton_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlNavButton.MouseMove
        If drag = True Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub pnlNavButton_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlNavButton.MouseUp
        drag = False
    End Sub

    Private Sub btnavRecPass_Click_1(sender As Object, e As EventArgs) Handles btnavRecPass.Click

    End Sub
#End Region

End Class