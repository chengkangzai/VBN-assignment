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

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Assignments\Semester 3\VB.Net\vbimdb.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        Dim stmt As String = "select * from [User] where U_Username='" & txtLusername.Text & "' And U_Password='" & txtLpassword.Text & "' "
        cmd = New SqlCommand(stmt, con)
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

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Assignments\Semester 3\VB.Net\vbimdb.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        MsgBox("Connection Open")
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from [User] where U_Username='" & txtRUserName.Text & "' "
        'Try
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
        'Catch ex As Exception
        '    MsgBox("Unsuccessful Register")
        'End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btncheckconnect.Click
        If txtRAge.Text.Length <= 6 Then
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

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Assignments\Semester 3\VB.Net\vbimdb.mdf;Integrated Security=True;Connect Timeout=30")
        If txtRFName.Text = txtRLName.Text Then
            Try
                con.Open()
                cmd = New SqlCommand("update [User] set U_Password = '" & txtPRNewPass.Text & "' where U_Username= '" & txtPRUsername.Text & "'", con)
                If (txtPRUsername.Text = "" And txtPRIC.Text = "" And txtPRNewPass.Text = "" And txtPRConPass.Text = "") Then
                    MsgBox("Please enter every info in the textbox")
                Else
                    If (cmd.ExecuteNonQuery() > 0) Then
                        MessageBox.Show("Password Successfully Recover")
                        con.Close()
                    Else
                        MsgBox("Wrong Username or IC number")
                    End If
                End If
            Catch ex As Exception
                MsgBox("error")
            End Try
        End If
    End Sub

    'btnavigation
    Private Sub btnavLogin_Click(sender As Object, e As EventArgs) Handles btnavLogin.Click
        login.Visible = True
        Recovery.Visible = False
        register.Visible = False
    End Sub

    Private Sub btnavRegister_Click(sender As Object, e As EventArgs) Handles btnavRegister.Click
        login.Visible = False
        Recovery.Visible = False
        register.Visible = True
    End Sub

    Private Sub btnavRecPass_Click(sender As Object, e As EventArgs) Handles btnavRecPass.Click
        login.Visible = False
        Recovery.Visible = True
        register.Visible = False
    End Sub

    'Data Validation(register)
    Private Sub txtRage_Validating(sender As Object, e As CancelEventArgs) Handles txtRAge.Validating
        If IsNumeric(txtRAge.Text) Then
            lblRTipsAge.Visible = False
        Else
            lblRTipsAge.Visible = True
        End If
    End Sub

    Private Sub txtRic_Validating(sender As Object, e As CancelEventArgs) Handles txtRIC.Validating
        If IsNumeric(txtRIC) Then
            lblRTipsIC.Visible = False
        Else
            lblRTipsIC.Visible = True
        End If
    End Sub

    Private Sub LoginRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRTipsAge.Visible = False
        lblRTipsIC.Visible = False
    End Sub

    Private Sub txtPRic_TextChanged(sender As Object, e As EventArgs) Handles txtPRIC.TextChanged
        Try
            If txtPRIC.Text < 0 Then
                MsgBox("Please input your Identification Number")
            End If
        Catch ex As Exception
            MsgBox("Must be number")
        End Try
    End Sub
End Class