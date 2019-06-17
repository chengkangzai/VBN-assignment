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
#Region "Windows Control"
Public Class Home
    'Maximize and Minimize or close
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picWinCtrlMaximize.Click, pnlWinCtrl.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else Me.WindowState = FormWindowState.Normal
        End If

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picWinCtrlMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picWinCtrlExit.Click, btnpnlExit.Click
        Dim result As Integer = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

#End Region
#Region "Windows Drag"
    Dim drag As Boolean = False
    Dim mousex As Integer
    Dim mousey As Integer
    ' REF: https://www.dreamincode.net/forums/topic/135768-moving-a-borderless-form/
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlWinCtrl.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlWinCtrl.MouseMove
        If drag = True Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlWinCtrl.MouseUp
        drag = False
    End Sub
#End Region


    Dim con As SqlConnection
    Dim scrollval As Integer
    Dim pageadapter As SqlDataAdapter
    Dim pagingds As DataSet


#Region "Panel Button (mostly visibility) "

    'Form Load Event
    Private Sub New_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSearch.Visible = False
        pnlMovie.Visible = False
        pnlWelcome.Visible = True
        pnlAbout.Visible = False
        pnlAfterSearch.Visible = False
        cboSearchMGenre.Items.Add("")
        cboSearchMGenre.Items.Add("Action")
        cboSearchMGenre.Items.Add("Adventurer")
        cboSearchMGenre.Items.Add("Animation")
        cboSearchMGenre.Items.Add("Biography")
        cboSearchMGenre.Items.Add("Comedy")
        cboSearchMGenre.Items.Add("Crime")
        cboSearchMGenre.Items.Add("Documentary")
        cboSearchMGenre.Items.Add("Drama")
        cboSearchMGenre.Items.Add("Family")
        cboSearchMGenre.Items.Add("Fantasy")
        cboSearchMGenre.Items.Add("Film Noir")
        cboSearchMGenre.Items.Add("History")
        cboSearchMGenre.Items.Add("Horror")
        cboSearchMGenre.Items.Add("Musical")
        cboSearchMGenre.Items.Add("Mystery")
        cboSearchMGenre.Items.Add("Romance")
        cboSearchMGenre.Items.Add("Sci-Fi")
        cboSearchMGenre.Items.Add("Short")
        cboSearchMGenre.Items.Add("Sport")
        cboSearchMGenre.Items.Add("Superhero")
        cboSearchMGenre.Items.Add("Thriller")
        cboSearchMGenre.Items.Add("War")
        cboSearchMGenre.Items.Add("Western")
        cboSearchMRTMMod.Items.Add(">")
        cboSearchMRTMMod.Items.Add(">=")
        cboSearchMRTMMod.Items.Add("<")
        cboSearchMRTMMod.Items.Add("<=")
        cboSearchMRTMMod.Items.Add("=")
        cboSearchMRatingMod.Items.Add(">")
        cboSearchMRatingMod.Items.Add(">=")
        cboSearchMRatingMod.Items.Add("<")
        cboSearchMRatingMod.Items.Add("<=")
        cboSearchMRatingMod.Items.Add("=")
        cboSearchMRYearMod.Items.Add(">")
        cboSearchMRYearMod.Items.Add(">=")
        cboSearchMRYearMod.Items.Add("<")
        cboSearchMRYearMod.Items.Add("<=")
        cboSearchMRYearMod.Items.Add("=")
        cboSearchCBYearMod.Items.Add(">")
        cboSearchCBYearMod.Items.Add(">=")
        cboSearchCBYearMod.Items.Add("<")
        cboSearchCBYearMod.Items.Add("<=")
        cboSearchCBYearMod.Items.Add("=")
        cboSearchMRTMMod.SelectedIndex = 0
        cboSearchMRatingMod.SelectedIndex = 0
        cboSearchMRYearMod.SelectedIndex = 0
        cboSearchCBYearMod.SelectedIndex = 0
        radPreSearchByMovie.Checked = 1
    End Sub

    Private Sub Search_button(sender As Object, e As EventArgs) Handles btnpnlSearch.Click
        pnlWelcome.Visible = False
        pnlMovie.Visible = False
        pnlAbout.Visible = False
        pnlSearch.Visible = True
        pnlPreSearch.Visible = True
        pnlAfterSearch.Visible = False
        pnlSearchMovie.Visible = True
        pnlSearchCrew.Visible = False
    End Sub

    Private Sub btnpnlLogout_Click(sender As Object, e As EventArgs) Handles btnpnlLogout.Click
        Dim login As New LoginRegister
        Dim ans As Integer = MessageBox.Show("You will be logged out" & vbNewLine & "Are You Sure?", "Log out Comfirmation", MessageBoxButtons.YesNo)
        If ans = DialogResult.Yes Then
            Me.Close()
            login.Show()
        End If

    End Sub

    Private Sub btnpnlMovie_Click(sender As Object, e As EventArgs) Handles btnpnlMovie.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = False
        pnlMovie.Visible = True
        pnlAbout.Visible = False
        pnlAfterSearch.Visible = False

    End Sub
    Private Sub btnpnlAbout_Click(sender As Object, e As EventArgs) Handles btnpnlAbout.Click
        pnlWelcome.Visible = False
        pnlSearch.Visible = False
        pnlMovie.Visible = False
        pnlAbout.Visible = True
        pnlAfterSearch.Visible = False

    End Sub

#End Region
#Region "Search Function "
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnPreSearch.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Assignments\Semester 3\VB.Net\vbimdb.mdf;Integrated Security=True;Connect Timeout=30")
        Dim sql As String
        If radPreSearchByMovie.Checked Then
            sql = "SELECT * FROM [MovieFilter] WHERE "
            If Not String.IsNullOrWhiteSpace(txtSearchMName.Text) Then
                sql = sql & "[movie title] Like '%" & txtSearchMName.Text & "%' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtSearchMRYear.Text) Then
                sql = sql & "[release year] " & cboSearchMRYearMod.Text & " '" & txtSearchMRYear.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtSearchMEYear.Text) Then
                sql = sql & "[ending year] ='" & txtSearchMEYear.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtSearchMRTM.Text) Then
                sql = sql & "[runtime min(s)] " & cboSearchMRTMMod.Text & " '" & txtSearchMRTM.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(cboSearchMGenre.Text) Then
                sql = sql & "[genre] LIKE '%" & cboSearchMGenre.Text & "%' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtSearchMRating.Text) Then
                sql = sql & "[rating] " & cboSearchMRatingMod.Text & " '" & txtSearchMRating.Text & "' AND "
            End If
            If sql.EndsWith(" AND ") Then
                sql = sql.Substring(0, sql.Length - 5)
            End If
            If sql.EndsWith(" WHERE ") Then
                sql = sql.Substring(0, sql.Length - 7)
            End If
            If Not IsNumeric(txtSearchMRYear.Text) And Not String.IsNullOrWhiteSpace(txtSearchMRYear.Text) Or Not IsNumeric(txtSearchMEYear.Text) And Not String.IsNullOrWhiteSpace(txtSearchMEYear.Text) Or Not IsNumeric(txtSearchMRTM.Text) And Not String.IsNullOrWhiteSpace(txtSearchMRTM.Text) Or Not IsNumeric(txtSearchMRating.Text) And Not String.IsNullOrWhiteSpace(txtSearchMRating.Text) Then
                If Not IsNumeric(txtSearchMRYear.Text) And Not String.IsNullOrWhiteSpace(txtSearchMRYear.Text) Or Not IsNumeric(txtSearchMEYear.Text) And Not String.IsNullOrWhiteSpace(txtSearchMEYear.Text) Then
                    MsgBox("Please Insert a Year.")
                End If
                If Not IsNumeric(txtSearchMRTM.Text) And Not String.IsNullOrWhiteSpace(txtSearchMRTM.Text) Or Not IsNumeric(txtSearchMRating.Text) And Not String.IsNullOrWhiteSpace(txtSearchMRating.Text) Then
                    MsgBox("Please Insert a Value.")
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

        If radPreSearchByCrew.Checked Then
            sql = "SELECT * FROM [FilterView] WHERE "
            If Not String.IsNullOrWhiteSpace(txtSearchCName.Text) Then
                sql = sql & "[crew's name] LIKE '%" & txtSearchCName.Text & "%' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtSearchCPos.Text) Then
                sql = sql & "[crew's position] LIKE '%" & txtSearchCPos.Text & "%' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtSearchCBYear.Text) Then
                sql = sql & "[Crew's Birth Year] " & cboSearchCBYearMod.Text & " '" & txtSearchCBYear.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtSearchCDYear.Text) Then
                sql = sql & "[Crew's Death Year] = '" & txtSearchCDYear.Text & "' AND "
            End If
            If Not String.IsNullOrWhiteSpace(txtSearchCProf.Text) Then
                sql = sql & "[crew's profession] LIKE '%" & txtSearchCProf.Text & "%' AND "
            End If
            If sql.EndsWith(" AND ") Then
                sql = sql.Substring(0, sql.Length - 5)
            End If
            If sql.EndsWith(" WHERE ") Then
                sql = sql.Substring(0, sql.Length - 7)
            End If

            If Not IsNumeric(txtSearchCBYear.Text) And Not String.IsNullOrWhiteSpace(txtSearchCBYear.Text) Or Not IsNumeric(txtSearchCDYear.Text) And Not String.IsNullOrWhiteSpace(txtSearchCDYear.Text) Then
                MsgBox("Please Insert a Year.")
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnAfterSearchBack.Click
        pnlAfterSearch.Visible = False
        pnlPreSearch.Visible = True

    End Sub


    Private Sub DgvSearchResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchResult.CellContentClick
        Dim website As String
        Dim website2 As String
        Dim url As String
        Dim url2 As String

        website = dgvSearchResult.CurrentRow.Cells(0).Value.ToString()
        website2 = dgvMovieList.CurrentRow.Cells(0).Value.ToString()
        url = "https://www.imdb.com/title/" + website
        url2 = "https://www.imdb.com/title/" + website2
        Process.Start(url)
        Process.Start(url2)
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnAfterSearchPrevious.Click
        scrollval = scrollval - 100
        If scrollval <= 0 Then
            scrollval = 0
        End If
        pagingds.Clear()
        If radPreSearchByMovie.Checked Then
            pageadapter.Fill(pagingds, scrollval, 100, "[MovieFilter]")
        End If
        If radPreSearchByCrew.Checked Then
            pageadapter.Fill(pagingds, scrollval, 100, "[FilterView]")
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnAfterSearchNext.Click
        scrollval = scrollval + 100
        If scrollval > 501 Then
            scrollval = 500
        End If
        pagingds.Clear()
        If radPreSearchByMovie.Checked Then
            pageadapter.Fill(pagingds, scrollval, 100, "[MovieFilter]")
        End If
        If radPreSearchByCrew.Checked Then
            pageadapter.Fill(pagingds, scrollval, 100, "[FilterView]")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnLoadMovie.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Assignments\Semester 3\VB.Net\vbimdb.mdf;Integrated Security=True;Connect Timeout=30")
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

    Private Sub radMovie_CheckedChanged(sender As Object, e As EventArgs) Handles radPreSearchByMovie.CheckedChanged
        If radPreSearchByMovie.Checked Then
            pnlSearchMovie.Visible = True
            txtSearchCName.Clear()
            txtSearchCBYear.Clear()
            txtSearchCDYear.Clear()
            txtSearchCPos.Clear()
            txtSearchCProf.Clear()
        Else
            pnlSearchMovie.Visible = False
        End If
    End Sub

    Private Sub radCrew_CheckedChanged(sender As Object, e As EventArgs) Handles radPreSearchByCrew.CheckedChanged
        If radPreSearchByCrew.Checked Then
            pnlSearchCrew.Visible = True
            txtSearchMName.Clear()
            txtSearchMRYear.Clear()
            txtSearchMEYear.Clear()
            txtSearchMRating.Clear()
            txtSearchMRTM.Clear()
            cboSearchMGenre.SelectedIndex = 0
        Else
            pnlSearchCrew.Visible = False
        End If
    End Sub
#End Region

End Class