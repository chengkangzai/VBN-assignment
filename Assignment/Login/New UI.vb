Public Class New_UI
    'Maximize and Minimize or close
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, btnpnlExit.Click
        Dim result As Integer = MessageBox.Show("Are you sure ?", "Comfirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' Panel Visibility 

    Private Sub New_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSearch.Visible = False
        pnlLogin.Visible = False
        pnlMovie.Visible = False
        pnlWelcome.Visible = True
        pnlAbout.Visible = False
    End Sub

    Private Sub Search_button(sender As Object, e As EventArgs) Handles btnpnlSearch.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = True
        pnlMovie.Visible = False
        pnlLogin.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub btnpnlLogin_Click(sender As Object, e As EventArgs) Handles btnpnlLogin.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = False
        pnlMovie.Visible = False
        pnlLogin.Visible = True
        pnlAbout.Visible = False
    End Sub

    Private Sub btnpnlMovie_Click(sender As Object, e As EventArgs) Handles btnpnlMovie.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = False
        pnlMovie.Visible = True
        pnlLogin.Visible = False
        pnlAbout.Visible = False
    End Sub
    Private Sub btnpnlAbout_Click(sender As Object, e As EventArgs) Handles btnpnlAbout.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = False
        pnlMovie.Visible = False
        pnlLogin.Visible = False
        pnlAbout.Visible = True
    End Sub


    ' Panel Button Hover Effect 
    ' Search
    Private Sub btnpnlSearch_MouseHover(sender As Object, e As EventArgs) Handles btnpnlSearch.MouseHover
        Button1.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnpnlSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnpnlSearch.MouseLeave
        Button1.BackColor = Color.MediumAquamarine
    End Sub
    ' Login
    Private Sub btnpnlLogin_MouseHover(sender As Object, e As EventArgs) Handles btnpnlLogin.MouseHover
        Button1.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnpnlLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnpnlLogin.MouseLeave
        Button1.BackColor = Color.MediumAquamarine
    End Sub
    'Movie
    Private Sub btnpnlMovie_MouseHover(sender As Object, e As EventArgs) Handles btnpnlMovie.MouseHover
        Button1.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnpnlMovie_MouseLeave(sender As Object, e As EventArgs) Handles btnpnlMovie.MouseLeave
        Button1.BackColor = Color.MediumAquamarine
    End Sub
    'About 
    Private Sub btnpnlAbout_MouseHover(sender As Object, e As EventArgs) Handles btnpnlAbout.MouseHover
        Button1.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnpnlAbout_MouseLeave(sender As Object, e As EventArgs) Handles btnpnlAbout.MouseLeave
        Button1.BackColor = Color.MediumAquamarine
    End Sub
    'Exit
    Private Sub btnpnlExit_MouseHover(sender As Object, e As EventArgs) Handles btnpnlExit.MouseHover
        Button1.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnpnlExit_MouseLeave(sender As Object, e As EventArgs) Handles btnpnlExit.MouseLeave
        Button1.BackColor = Color.MediumAquamarine
    End Sub
End Class