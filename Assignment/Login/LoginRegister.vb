﻿Imports System.Data.SqlClient
Public Class LoginRegister
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFormClose.Click
        Me.Close()
    End Sub

    'Login
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chin Wei\source\repos\testing2\testing2\bin\Debug\dbregistertest.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()
        Dim stmt As String = "select * from [User] where U_Username='" & txtLusername.Text & "' And U_Password='" & txtLpassword.Text & "' "
        cmd = New SqlCommand(stmt, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Login Successfully")
            Me.Hide()
            home.show()
        Else
            MessageBox.Show("Invalid Account/exist")
            txtLusername.Clear()
            txtLpassword.Clear()
        End If
    End Sub

    'Register
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chin Wei\source\repos\testing2\testing2\bin\Debug\dbregistertest.mdf;Integrated Security=True;Connect Timeout=30"
        con.Open()
        MsgBox("Connection Open")
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from [User] where U_Username='" & txtRusername.Text & "' "

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Username Already Exist")
            con.Close()
        Else
            con.Close()
            con.Open()
            cmd = New SqlCommand("insert into [User] (U_Fname, U_Lname, U_Age, U_Username, U_Password, U_ICnumber) values ('" & txtLusername.Text & "', '" & txtLpassword.Text & "', '" & txtRfname.Text & "', '" & txtRlname.Text & "', '" & txtRage.Text & "', '" & txtRusername.Text & "')", con)
            If (txtRfname.Text = "" And txtRlname.Text = "" And txtRage.Text = "" And txtRusername.Text = "" And txtRpassword.Text = "" And txtRic.Text = "") Then
                MsgBox("Please enter the details")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Registered")
            End If
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtRage.TextChanged
        Try
            If txtRage.Text <= 0 Then
                MsgBox("Please input an actual number")
            End If
        Catch ex As Exception
            MsgBox("Must be number and more than 0")
        End Try
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtRic.TextChanged
        Try
            If txtRic.Text < 0 Then
                MsgBox("Please input your Identification number")
            End If
        Catch ex As Exception
            MsgBox("Must be number and does not have special letter")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btncheckconnect.Click
        If txtRage.Text.Length <= 6 Then
            MsgBox("Weak Password")
        Else
            MsgBox("Strong Password")
        End If
    End Sub

    'Recovery
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnconchanges.Click
        If txtPRnewpass.Text <> txtPRconpass.Text Then
            MsgBox("Password does not match")
        End If

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chin Wei\source\repos\testing2\testing2\bin\Debug\dbregistertest.mdf;Integrated Security=True;Connect Timeout=30 "
        If txtRfname.Text = txtRlname.Text Then
            Try
                con.Open()
                cmd = New SqlCommand("update [User] set U_Password = '" & txtPRnewpass.Text & "' where U_Username= '" & txtPRusername.Text & "'", con)
                If (txtPRusername.Text = "" And txtPRic.Text = "" And txtPRnewpass.Text = "" And txtPRconpass.Text = "") Then
                    MsgBox("Please enter every info in the textbox")
                Else
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Password Successfully Recover")
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox("Wrong Username or IC number")
            End Try
        End If
    End Sub

    'btnavigation
    Private Sub btnavLogin_Click(sender As Object, e As EventArgs) Handles btnavLogin.Click
        login.Visible = True
        Recovery.Visible = False
        register.Visible=False
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
End Class