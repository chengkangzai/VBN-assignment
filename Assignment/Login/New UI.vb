Imports System.Data.SqlClient

Public Class New_UI
    'Maximize and Minimize or close

    'Data Source Below
    'Data Source = (LocalDB) \ MSSQLLocalDB;AttachDbFilename="D:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXP2016\MSSQL\DATA\vb.net imdb.mdf";Integrated Security = True;Connect Timeout=30

    Dim Con As SqlConnection
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
        Dim result As Integer = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo)
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
        pnlAfterSearch.Visible = False
        cboSearchGenre.Items.Add("Action")
        cboSearchGenre.Items.Add("Adventurer")
        cboSearchGenre.Items.Add("Animation")
        cboSearchGenre.Items.Add("Biography")
        cboSearchGenre.Items.Add("Comedy")
        cboSearchGenre.Items.Add("Crime")
        cboSearchGenre.Items.Add("Documentary")
        cboSearchGenre.Items.Add("Drama")
        cboSearchGenre.Items.Add("Family")
        cboSearchGenre.Items.Add("Fantasy")
        cboSearchGenre.Items.Add("Film Noir")
        cboSearchGenre.Items.Add("History")
        cboSearchGenre.Items.Add("Horror")
        cboSearchGenre.Items.Add("Musical")
        cboSearchGenre.Items.Add("Mystery")
        cboSearchGenre.Items.Add("Romance")
        cboSearchGenre.Items.Add("Sci-Fi")
        cboSearchGenre.Items.Add("Short")
        cboSearchGenre.Items.Add("Sport")
        cboSearchGenre.Items.Add("Superhero")
        cboSearchGenre.Items.Add("Thriller")
        cboSearchGenre.Items.Add("War")
        cboSearchGenre.Items.Add("Western")
        cboRTMMod.Items.Add(">")
        cboRTMMod.Items.Add(">=")
        cboRTMMod.Items.Add("<")
        cboRTMMod.Items.Add("<=")
        cboRTMMod.Items.Add("=")
    End Sub

    Private Sub Search_button(sender As Object, e As EventArgs) Handles btnpnlSearch.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = True
        pnlMovie.Visible = False
        pnlLogin.Visible = False
        pnlAbout.Visible = False
        pnlAfterSearch.Visible = False
        pnlMovieSearch.Visible = True
        pnlPreSearch.Visible = True

    End Sub

    Private Sub btnpnlLogin_Click(sender As Object, e As EventArgs) Handles btnpnlLogin.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = False
        pnlMovie.Visible = False
        pnlLogin.Visible = True
        pnlAbout.Visible = False
        pnlAfterSearch.Visible = False

    End Sub

    Private Sub btnpnlMovie_Click(sender As Object, e As EventArgs) Handles btnpnlMovie.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = False
        pnlMovie.Visible = True
        pnlLogin.Visible = False
        pnlAbout.Visible = False
        pnlAfterSearch.Visible = False

    End Sub
    Private Sub btnpnlAbout_Click(sender As Object, e As EventArgs) Handles btnpnlAbout.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = False
        pnlMovie.Visible = False
        pnlLogin.Visible = False
        pnlAbout.Visible = True
        pnlAfterSearch.Visible = False

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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Connected 
        ''Con = New SqlConnection
        Dim rowcount As Integer
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryuko\Desktop\VB.Net\vb.net imdb.mdf;Integrated Security=True;Connect Timeout=30")
        rowcount = 100
        Dim cmd As New SqlCommand(" SELECT TOP 200 primaryTitle as 'Movie Title', startYear as 'Start Year', endYear as 'End Year', runtimeMinutes as 'Runtime Minute', genres as Genres
                                    FROM [title.basics]
                                    WHERE primaryTitle LIKE'%" & txtMSearchName.Text & "%'
                                    AND startYear ='" & txtMSearchSYear.Text & "'
    
                                    AND genres LIKE'%" & cboSearchGenre.Text & "%'
         
                                    ", con)
        Dim DBDA As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        DBDA.Fill(table)
        dgvSearchResult.DataSource = table


        'Test Connection

        'Try
        '    con.Open()
        '    MessageBox.Show("Connected!")
        '    con.Close()
        '    MessageBox.Show("Closed")
        'Catch ex As SqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    con.Dispose()
        'End Try
        pnlMovieSearch.Visible = False
        pnlAfterSearch.Visible = True
        pnlPreSearch.Visible = False
        Temp.Visible = False
    End Sub

    Private Sub dgvSearchResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchResult.CellContentClick

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlAfterSearch.Visible = False
        pnlMovieSearch.Visible = True
        pnlPreSearch.Visible = True
    End Sub

    Private Sub cbxSearchGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchGenre.SelectedIndexChanged

    End Sub

    Private Sub lblSearchTitle_Click(sender As Object, e As EventArgs)

    End Sub
End Class