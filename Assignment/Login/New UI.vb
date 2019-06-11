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
        pnlMovie.Visible = False
        pnlLogin.Visible = False
        pnlAbout.Visible = False

        pnlSearch.Visible = True
        pnlPreSearch.Visible = True
        pnlMovieSearch.Visible = False
        pnlAfterSearch.Visible = False
        pnlFilterMovieTV.Visible = False
        pnlFilterTV.Visible = False
        lblFilterOptions.Visible = False
        btnPreSearchNext.Visible = False
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
        'Dim rowcount As Integer
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\OneDrive - Asia Pacific University\SynologyDrive\APU SEM 3\VBN - Visual Basic.NET\04 Assignment\DB\VBN Imdb.mdf;Integrated Security=True;Connect Timeout=30")
        'rowcount = 100

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
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlAfterSearch.Visible = False
        pnlMovieSearch.Visible = True
        pnlPreSearch.Visible = True

    End Sub
    'Filter Types
    Private Sub CbFilterMovie_CheckedChanged(sender As Object, e As EventArgs) Handles cbFilterMovie.CheckedChanged
        If cbFilterMovie.CheckState = 1 Then
            cbFilterActors.Enabled = False
            cbFilterTV.Enabled = False
            cbSeasonNum.Enabled = False
            cbEpisodeNum.Enabled = False
            cbTotalVotes.Enabled = False
            cbFEYear.Enabled = False
            lblSearchTips.Visible = False
            lblFilterOptions.Visible = True
            pnlFilterMovieTV.Visible = True
            btnPreSearchNext.Visible = True

        Else
            cbFilterTV.Enabled = True
            cbFilterActors.Enabled = True
            cbSeasonNum.Enabled = True
            cbEpisodeNum.Enabled = True
            cbTotalVotes.Enabled = False
            cbFEYear.Enabled = False
            lblSearchTips.Visible = True
            lblFilterOptions.Visible = False
            pnlFilterMovieTV.Visible = False
            btnPreSearchNext.Visible = False
        End If
    End Sub
    Private Sub CbFilterTV_CheckedChanged(sender As Object, e As EventArgs) Handles cbFilterTV.CheckedChanged
        If cbFilterTV.CheckState = 1 Then
            cbFilterActors.Enabled = False
            cbFilterMovie.Enabled = False
            lblSearchTips.Visible = False
            lblFilterOptions.Visible = True
            cbTotalVotes.Enabled = False
            cbFEYear.Enabled = False
            cbEpisodeNum.Enabled = False
            pnlFilterMovieTV.Visible = True
            pnlFilterTV.Visible = True
            btnPreSearchNext.Visible = True
        Else
            cbFilterActors.Enabled = True
            cbFilterMovie.Enabled = True
            lblSearchTips.Visible = True
            cbTotalVotes.Enabled = False
            cbFEYear.Enabled = False
            cbEpisodeNum.Enabled = False
            lblFilterOptions.Visible = False
            pnlFilterMovieTV.Visible = False
            pnlFilterTV.Visible = False
            btnPreSearchNext.Visible = False
        End If
    End Sub
    Private Sub CbFilterActors_CheckedChanged(sender As Object, e As EventArgs) Handles cbFilterActors.CheckedChanged
        If cbFilterActors.CheckState = 1 Then
            cbFilterMovie.Enabled = False
            cbFilterTV.Enabled = False
            btnPreSearchNext.Visible = True
        Else
            cbFilterTV.Enabled = True
            cbFilterMovie.Enabled = True
            btnPreSearchNext.Visible = False
        End If
    End Sub
    'Filter Options Settings
    Private Sub CbAdult_CheckedChanged(sender As Object, e As EventArgs) Handles cbAdult.CheckedChanged
        If cbAdult.CheckState = 1 Then
            cbEveryone.Enabled = False
        Else
            cbEveryone.Enabled = True
        End If
    End Sub
    Private Sub CbEveryone_CheckedChanged(sender As Object, e As EventArgs) Handles cbEveryone.CheckedChanged
        If cbEveryone.CheckState = 1 Then
            cbAdult.Enabled = False
        Else
            cbAdult.Enabled = True
        End If
    End Sub
    Private Sub CbRating_CheckedChanged(sender As Object, e As EventArgs) Handles cbRating.CheckedChanged
        If cbRating.Checked Then
            cbTotalVotes.Enabled = True
        Else
            cbTotalVotes.Enabled = False
            cbTotalVotes.CheckState = 0
        End If
    End Sub
    Private Sub CbFSYear_CheckedChanged(sender As Object, e As EventArgs) Handles cbFSYear.CheckedChanged
        If cbFSYear.Checked Then
            cbFEYear.Enabled = True
        Else
            cbFEYear.Enabled = False
            cbFEYear.CheckState = 0
        End If
    End Sub
    Private Sub CbSeasonNum_CheckedChanged(sender As Object, e As EventArgs) Handles cbSeasonNum.CheckedChanged
        If cbSeasonNum.Checked Then
            cbEpisodeNum.Enabled = True
        Else
            cbEpisodeNum.Enabled = False
            cbEpisodeNum.Checked = 0
        End If
    End Sub

    'Ignore below until further notice
    Private Sub BtnPreSearchNext_Click(sender As Object, e As EventArgs) Handles btnPreSearchNext.Click
        If cbFilterMovie.Checked Then
            pnlPreSearch.Visible = False
            pnlMovieSearch.Visible = True
            'None Selected
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            '6 Basic
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            '4 Mixed w SYear
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            '4 Mixed w SYear2
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            '3 Mixed w RTM
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 1 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            '2 Mixed w Genre
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            'Triple
        End If

        If cbFilterActors.Checked Then
            pnlPreSearch.Visible = False
            'pnlActorSearch.Visible = True - To Be Implemented
            'None Selected
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            '6 Basic
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            '4 Mixed w SYear
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            '4 Mixed w SYear2
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 1 And cbFEYear.CheckState = 1 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            '3 Mixed w RTM
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 1 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 1 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            '2 Mixed w Genre
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 0 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 1 And cbFRtM.CheckState = 0 And cbRating.CheckState = 1 And cbTotalVotes.CheckState = 1 Then

            End If
            If cbSeasonNum.CheckState = 0 And cbEpisodeNum.CheckState = 0 And cbFSYear.CheckState = 0 And cbFEYear.CheckState = 0 And cbFGenre.CheckState = 0 And cbFRtM.CheckState = 0 And cbRating.CheckState = 0 And cbTotalVotes.CheckState = 0 Then

            End If
        End If

        If cbFilterTV.Checked Then
            pnlPreSearch.Visible = False
            'pnlTVSearch.Visible = True - To Be Implemented
        End If

    End Sub

    'Make Panel 2 dragable
    'REf: https://www.dreamincode.net/forums/topic/135768-moving-a-borderless-form/
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub New_UI_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub New_UI_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag = True Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub New_UI_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub
End Class