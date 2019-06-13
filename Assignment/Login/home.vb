'References
'SQL Replacing All '\N' to NULL: https://www.essentialsql.com/sql-update-statement/
'Creating View (SQL): https://www.w3schools.com/sql/sql_view.asp
'Null Value Filter: https://stackoverflow.com/questions/26719598/sql-vb-net-search-function-looking-for-at-least-one-correct-input
'Data Grid View Page Function: http://vb.net-informations.com/datagridview/vb.net_datagridview_paging.htm
'SQL Ending Existing Connection to Detach: https://stackoverflow.com/questions/7197574/script-to-kill-all-connections-to-a-database-more-than-restricted-user-rollback
'Invalid Object Fix: https://support.microsoft.com/en-my/help/238750/fix-invalid-object-name-error-when-updating-by-stored-procedure-in-dif
'Importing Guideline: https://support.discountasp.net/kb/a1179/how-to-import-a-csv-file-into-a-database-using-sql-server-management-studio.aspx
'Importing Guideline 2: https://docs.microsoft.com/en-us/sql/relational-databases/import-export/import-flat-file-wizard?view=sql-server-2017

Imports System.Data.SqlClient

Public Class home
    'Maximize and Minimize or close

    'Data Source Below
    'Data Source = (LocalDB) \ MSSQLLocalDB;AttachDbFilename="D:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXP2016\MSSQL\DATA\vb.net imdb.mdf";Integrated Security = True;Connect Timeout=30
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else Me.WindowState = FormWindowState.Normal
        End If

    End Sub
    Dim con As SqlConnection
    Dim scrollval As Integer
    Dim pageadapter As SqlDataAdapter
    Dim pagingds As DataSet
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
        cboSearchGenre.Items.Add("")
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
        cboRatingsMod.Items.Add(">")
        cboRatingsMod.Items.Add(">=")
        cboRatingsMod.Items.Add("<")
        cboRatingsMod.Items.Add("<=")
        cboRatingsMod.Items.Add("=")
        cboYearMod.Items.Add(">")
        cboYearMod.Items.Add(">=")
        cboYearMod.Items.Add("<")
        cboYearMod.Items.Add("<=")
        cboYearMod.Items.Add("=")
        cboCrewBYearMOD.Items.Add(">")
        cboCrewBYearMOD.Items.Add(">=")
        cboCrewBYearMOD.Items.Add("<")
        cboCrewBYearMOD.Items.Add("<=")
        cboCrewBYearMOD.Items.Add("=")
        cboRTMMod.SelectedIndex = 0
        cboRatingsMod.SelectedIndex = 0
        cboYearMod.SelectedIndex = 0
        cboCrewBYearMOD.SelectedIndex = 0
        radMovie.Checked = 1
    End Sub

    Private Sub Search_button(sender As Object, e As EventArgs) Handles btnpnlSearch.Click
        pnlWelcome.Visible = False
        pnlMovie.Visible = False
        pnlLogin.Visible = False
        pnlAbout.Visible = False
        pnlSearch.Visible = True
        pnlPreSearch.Visible = True
        pnlAfterSearch.Visible = False
        pnlMovieSearch.Visible = True
        pnlCrewSearch.Visible = False
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
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Games\vbimdb.mdf;Integrated Security=True;Connect Timeout=30")
        Dim sql As String
        If radMovie.Checked Then
            sql = "SELECT * FROM [MovieFilter] WHERE "
            If Not String.IsNullOrWhiteSpace(txtMSearchName.Text) Then
                sql = sql & "[movie title] LIKE '%" & txtMSearchName.Text & "%' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtMSearchSYear.Text) Then
                sql = sql & "[release year] " & cboYearMod.Text & " '" & txtMSearchSYear.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtMSearchEYear.Text) Then
                sql = sql & "[ending year] ='" & txtMSearchEYear.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtRTM.Text) Then
                sql = sql & "[runtime min(s)] " & cboRTMMod.Text & " '" & txtRTM.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(cboSearchGenre.Text) Then
                sql = sql & "[genre] LIKE '%" & cboSearchGenre.Text & "%' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtRatings.Text) Then
                sql = sql & "[rating] " & cboRatingsMod.Text & " '" & txtRatings.Text & "' AND "
            End If
            If sql.EndsWith(" AND ") Then
                sql = sql.Substring(0, sql.Length - 5)
            End If
            If sql.EndsWith(" WHERE ") Then
                sql = sql.Substring(0, sql.Length - 7)
            End If
            If Not IsNumeric(txtMSearchSYear.Text) And Not String.IsNullOrWhiteSpace(txtMSearchSYear.Text) Or Not IsNumeric(txtMSearchEYear.Text) And Not String.IsNullOrWhiteSpace(txtMSearchEYear.Text) Or Not IsNumeric(txtRTM.Text) And Not String.IsNullOrWhiteSpace(txtRTM.Text) Or Not IsNumeric(txtRatings.Text) And Not String.IsNullOrWhiteSpace(txtRatings.Text) Then
                If Not IsNumeric(txtMSearchSYear.Text) And Not String.IsNullOrWhiteSpace(txtMSearchSYear.Text) Or Not IsNumeric(txtMSearchEYear.Text) And Not String.IsNullOrWhiteSpace(txtMSearchEYear.Text) Then
                    MsgBox("Please enter year only.")
                End If
                If Not IsNumeric(txtRTM.Text) And Not String.IsNullOrWhiteSpace(txtRTM.Text) Or Not IsNumeric(txtRatings.Text) And Not String.IsNullOrWhiteSpace(txtRatings.Text) Then
                    MsgBox("Please enter a value.")
                Else
                End If
            Else
                pageadapter = New SqlDataAdapter(sql, con)
                pagingds = New DataSet()
                pageadapter.SelectCommand.CommandTimeout = 0
                pageadapter.Fill(pagingds, scrollval, 100, "[MovieFilter]")
                dgvSearchResult.DataSource = pagingds
                dgvSearchResult.DataMember = "[MovieFilter]"
                pnlPreSearch.Visible = False
                pnlAfterSearch.Visible = True
            End If
        End If

        If radCrew.Checked Then
            sql = "SELECT * FROM [FilterView] WHERE "
            If Not String.IsNullOrWhiteSpace(txtCrewName.Text) Then
                sql = sql & "[crew's name] LIKE '%" & txtCrewName.Text & "%' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtCrewPos.Text) Then
                sql = sql & "[crew's position] LIKE '%" & txtCrewPos.Text & "%' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtCrewBYear.Text) Then
                sql = sql & "[Crew's Birth Year] " & cboCrewBYearMOD.Text & " '" & txtCrewBYear.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtCrewDYear.Text) Then
                sql = sql & "[Crew's Death Year] = '" & txtCrewDYear.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtCrewProf.Text) Then
                sql = sql & "[crew's profession] LIKE '%" & txtCrewProf.Text & "%' AND "
            End If
            If sql.EndsWith(" AND ") Then
                sql = sql.Substring(0, sql.Length - 5)
            End If
            If sql.EndsWith(" WHERE ") Then
                sql = sql.Substring(0, sql.Length - 7)
            End If

            If Not IsNumeric(txtCrewBYear.Text) And Not String.IsNullOrWhiteSpace(txtCrewBYear.Text) Or Not IsNumeric(txtCrewDYear.Text) And Not String.IsNullOrWhiteSpace(txtCrewDYear.Text) Then
                MsgBox("Please enter year only.")
            Else
                pageadapter = New SqlDataAdapter(sql, con)
                pagingds = New DataSet()
                pageadapter.SelectCommand.CommandTimeout = 0
                pageadapter.Fill(pagingds, scrollval, 100, "[FilterView]")
                dgvSearchResult.DataSource = pagingds
                dgvSearchResult.DataMember = "[FilterView]"
                pnlPreSearch.Visible = False
                pnlAfterSearch.Visible = True
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlAfterSearch.Visible = False
        pnlPreSearch.Visible = True

    End Sub

    Dim drag As Boolean = False
    Dim mousex As Integer
    Dim mousey As Integer
    ' REF: https://www.dreamincode.net/forums/topic/135768-moving-a-borderless-form/
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag = True Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub


    Private Sub Panel2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub DgvSearchResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchResult.CellContentClick
        Dim website As String
        Dim url As String

        website = dgvSearchResult.CurrentRow.Cells(0).Value.ToString()
        url = "https://www.imdb.com/title/" + website
        Process.Start(url)
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        scrollval = scrollval - 100
        If scrollVal <= 0 Then
            scrollVal = 0
        End If
        pagingds.Clear()
        If radMovie.Checked Then
            pageadapter.Fill(pagingds, scrollval, 100, "[MovieFilter]")
        End If
        If radCrew.Checked Then
            pageadapter.Fill(pagingds, scrollval, 100, "[FilterView]")
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        scrollval = scrollval + 100
        If scrollval > 501 Then
            scrollval = 500
        End If
        pagingds.Clear()
        If radMovie.Checked Then
            pageadapter.Fill(pagingds, scrollval, 100, "[MovieFilter]")
        End If
        If radCrew.Checked Then
            pageadapter.Fill(pagingds, scrollval, 100, "[FilterView]")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnLoadMovie.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryuko\Desktop\vb\vbimdb.mdf;Integrated Security=True;Connect Timeout=30")
        Dim sql As String = "SELECT * FROM [FilterView]"
        pageadapter = New SqlDataAdapter(sql, con)
        pagingds = New DataSet()
        pageadapter.SelectCommand.CommandTimeout = 0
        pageadapter.Fill(pagingds, scrollval, 100, "[FilterView]")
        dgvMovieList.DataSource = pagingds
        dgvMovieList.DataMember = "[FilterView]"
    End Sub

    Private Sub BtnPreviousMovie_Click(sender As Object, e As EventArgs) Handles btnPreviousMovie.Click
        scrollval = scrollval - 100
        If scrollval <= 0 Then
            scrollval = 0
        End If
        pagingds.Clear()
        pageadapter.Fill(pagingds, scrollval, 100, "[FilterView]")
    End Sub

    Private Sub BtnNextMovie_Click(sender As Object, e As EventArgs) Handles btnNextMovie.Click
        scrollval = scrollval + 100
        pagingds.Clear()
        pageadapter.Fill(pagingds, scrollval, 100, "[FilterView]")
    End Sub

    Private Sub radMovie_CheckedChanged(sender As Object, e As EventArgs) Handles radMovie.CheckedChanged
        If radMovie.Checked Then
            pnlMovieSearch.Visible = True
            txtCrewName.Clear()
            txtCrewBYear.Clear()
            txtCrewDYear.Clear()
            txtCrewPos.Clear()
            txtCrewProf.Clear()
        Else
            pnlMovieSearch.Visible = False
        End If
    End Sub

    Private Sub radCrew_CheckedChanged(sender As Object, e As EventArgs) Handles radCrew.CheckedChanged
        If radCrew.Checked Then
            pnlCrewSearch.Visible = True
            txtMSearchName.Clear()
            txtMSearchSYear.Clear()
            txtMSearchEYear.Clear()
            txtRatings.Clear()
            txtRTM.Clear()
            cboSearchGenre.SelectedIndex = 0
        Else
            pnlCrewSearch.Visible = False
        End If
    End Sub
End Class