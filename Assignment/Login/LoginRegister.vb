'References
'Login Windows Form=https://www.youtube.com/watch?v=1TqHEsK9ncI&t=320s
'Register Windows Form=https://www.youtube.com/watch?v=zlUA458CGUU&t=720s

Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class LoginRegister
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFormClose.Click
        Me.Close()
    End Sub

    'Login
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chin Wei\Desktop\VBimdb.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        Dim stm As String = "select * from [User] where U_Username='" & txtLusername.Text & "' And U_Password='" & txtLpassword.Text & "' "
        cmd = New SqlCommand(stm, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Login Successfully")
            Me.Hide()
            home.Show()
        Else
            MessageBox.Show("Invalid Account/exist")
            txtLusername.Clear()
            txtLpassword.Clear()
        End If
    End Sub

    'Register
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chin Wei\Desktop\VBimdb.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        MsgBox("Connection Open")
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from [User] where U_Username='" & txtRUserName.Text & "' "
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Username Already Exist")
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("insert into [User] (U_Fname, U_Lname, U_Age, U_Username, U_Password, U_ICnumber) values ('" & txtRFName.Text & "', '" & txtRLName.Text & "', '" & txtRAge.Text & "', '" & txtRUserName.Text & "', '" & txtRpassword.Text & "', '" & txtRIC.Text & "')", con)
                If Not IsNumeric(txtRAge.Text) Or Not IsNumeric(txtRIC.Text) Then
                    MsgBox("Please Enter Value Only")
                End If
                If (txtRFName.Text = "" And txtRLName.Text = "" And txtRAge.Text = "" And txtRUserName.Text = "" And txtRpassword.Text = "" And txtRIC.Text = "") Then
                    MsgBox("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfully Registered")
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Unsuccessful Register")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btncheckconnect.Click
        If txtRpassword.Text.Length <= 6 Then
            MsgBox("Weak Password")
        Else
            MsgBox("Strong Password")
        End If
    End Sub

    'Recovery
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnconchanges.Click
        If txtPRNewPass.Text <> txtPRConPass.Text Then
            MsgBox("Password does not match")
        End If

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chin Wei\Desktop\VBimdb.mdf;Integrated Security=True;Connect Timeout=30")
        If txtRFName.Text = txtRLName.Text Then
            Try
                con.Open()
                cmd = New SqlCommand("update [User] set U_Password = '" & txtPRNewPass.Text & "' where U_Username= '" & txtPRUsername.Text & "' And U_ICnumber='" & txtPRIC.Text & "'", con)
                If (txtPRUsername.Text = "" And txtPRIC.Text = "" And txtPRNewPass.Text = "" And txtPRConPass.Text = "") Then
                    MsgBox("Please enter every info in the textbox")
                Else
                    If Not IsNumeric(txtPRIC.Text) Then
                        MsgBox("Please Enter Value Only")
                    End If
                    If (cmd.ExecuteNonQuery() > 0) Then
                        MessageBox.Show("Password Successfully Recover")
                        con.Close()
                    Else
                        MsgBox("Wrong Username or IC number")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Recovery Unsuccessful")
            End Try
        End If
    End Sub

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

    Private Sub LoginRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRTipsAge.Visible = False
        lblRTipsIC.Visible = False
        lblPRTipsIC.Visible = False
    End Sub

    'Data Validation label show(password recovery)

    Private Sub txtPRIC_Validating(sender As Object, e As CancelEventArgs) Handles txtPRIC.Validating
        If IsNumeric(txtPRIC.Text) Then
            lblPRTipsIC.Visible = False
        Else
            lblPRTipsIC.Visible = True
        End If
    End Sub
End Class