﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.lblProgramName = New System.Windows.Forms.Label()
        Me.btnpnlSearch = New System.Windows.Forms.Button()
        Me.btnpnlAbout = New System.Windows.Forms.Button()
        Me.btnpnlLogout = New System.Windows.Forms.Button()
        Me.btnpnlExit = New System.Windows.Forms.Button()
        Me.btnpnlMovie = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.pnlPreSearch = New System.Windows.Forms.Panel()
        Me.lblPreSearchBy = New System.Windows.Forms.Label()
        Me.radPreSearchByMovie = New System.Windows.Forms.RadioButton()
        Me.radPreSearchByCrew = New System.Windows.Forms.RadioButton()
        Me.pnlSearchMovie = New System.Windows.Forms.Panel()
        Me.lblSearchMTitle = New System.Windows.Forms.Label()
        Me.lblSearchMName = New System.Windows.Forms.Label()
        Me.txtSearchMName = New System.Windows.Forms.TextBox()
        Me.lblSearchMRYear = New System.Windows.Forms.Label()
        Me.cboSearchMRYearMod = New System.Windows.Forms.ComboBox()
        Me.txtSearchMRYear = New System.Windows.Forms.TextBox()
        Me.lblSearchMEYear = New System.Windows.Forms.Label()
        Me.txtSearchMEYear = New System.Windows.Forms.TextBox()
        Me.lblSearchMRTM = New System.Windows.Forms.Label()
        Me.cboSearchMRTMMod = New System.Windows.Forms.ComboBox()
        Me.txtSearchMRTM = New System.Windows.Forms.TextBox()
        Me.lblSearchMGenre = New System.Windows.Forms.Label()
        Me.cboSearchMGenre = New System.Windows.Forms.ComboBox()
        Me.lblSearchMRating = New System.Windows.Forms.Label()
        Me.cboSearchMRatingMod = New System.Windows.Forms.ComboBox()
        Me.txtSearchMRating = New System.Windows.Forms.TextBox()
        Me.pnlSearchCrew = New System.Windows.Forms.Panel()
        Me.lblSearchCTitle = New System.Windows.Forms.Label()
        Me.lblSearchCName = New System.Windows.Forms.Label()
        Me.txtSearchCName = New System.Windows.Forms.TextBox()
        Me.lblSearchCPos = New System.Windows.Forms.Label()
        Me.txtSearchCPos = New System.Windows.Forms.TextBox()
        Me.lblSearchCBYear = New System.Windows.Forms.Label()
        Me.cboSearchCBYearMod = New System.Windows.Forms.ComboBox()
        Me.txtSearchCBYear = New System.Windows.Forms.TextBox()
        Me.lblSearchCDYear = New System.Windows.Forms.Label()
        Me.txtSearchCDYear = New System.Windows.Forms.TextBox()
        Me.lblSearchCProf = New System.Windows.Forms.Label()
        Me.txtSearchCProf = New System.Windows.Forms.TextBox()
        Me.btnPreSearch = New System.Windows.Forms.Button()
        Me.pnlAfterSearch = New System.Windows.Forms.Panel()
        Me.btnAfterSearchBack = New System.Windows.Forms.Button()
        Me.btnAfterSearchPrevious = New System.Windows.Forms.Button()
        Me.btnAfterSearchNext = New System.Windows.Forms.Button()
        Me.dgvSearchResult = New System.Windows.Forms.DataGridView()
        Me.pnlWelcome = New System.Windows.Forms.Panel()
        Me.picWelcome = New System.Windows.Forms.PictureBox()
        Me.pnlWinCtrlBox = New System.Windows.Forms.Panel()
        Me.picWinCtrlMinimize = New System.Windows.Forms.PictureBox()
        Me.picWinCtrlMaximize = New System.Windows.Forms.PictureBox()
        Me.picWinCtrlExit = New System.Windows.Forms.PictureBox()
        Me.pnlWinCtrl = New System.Windows.Forms.Panel()
        Me.pnlMovie = New System.Windows.Forms.Panel()
        Me.btnNextMovie = New System.Windows.Forms.Button()
        Me.btnPreviousMovie = New System.Windows.Forms.Button()
        Me.btnLoadMovie = New System.Windows.Forms.Button()
        Me.dgvMovieList = New System.Windows.Forms.DataGridView()
        Me.pnlAbout = New System.Windows.Forms.Panel()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.pnlAbout1 = New System.Windows.Forms.Panel()
        Me.picAbout1 = New System.Windows.Forms.PictureBox()
        Me.lblAbout1Name = New System.Windows.Forms.Label()
        Me.lblAbout1NameAns = New System.Windows.Forms.Label()
        Me.lblAbout1Age = New System.Windows.Forms.Label()
        Me.lblAbout1AgeAns = New System.Windows.Forms.Label()
        Me.lblAbout1TP = New System.Windows.Forms.Label()
        Me.lblAbout1TPAns = New System.Windows.Forms.Label()
        Me.pnlAbout2 = New System.Windows.Forms.Panel()
        Me.picAbout2 = New System.Windows.Forms.PictureBox()
        Me.lblAbout2Name = New System.Windows.Forms.Label()
        Me.lblAbout2NameAns = New System.Windows.Forms.Label()
        Me.lblAbout2Age = New System.Windows.Forms.Label()
        Me.lblAbout2AgeAns = New System.Windows.Forms.Label()
        Me.lblAbout2TP = New System.Windows.Forms.Label()
        Me.lblAbout2TPAns = New System.Windows.Forms.Label()
        Me.pnlAbout3 = New System.Windows.Forms.Panel()
        Me.picAbout3 = New System.Windows.Forms.PictureBox()
        Me.lblAbout3Name = New System.Windows.Forms.Label()
        Me.lblAbout3NameAns = New System.Windows.Forms.Label()
        Me.lblAbout3Age = New System.Windows.Forms.Label()
        Me.lblAbout3AgeAns = New System.Windows.Forms.Label()
        Me.lblAbout3AgeTP = New System.Windows.Forms.Label()
        Me.lblAbout3AgeTPAns = New System.Windows.Forms.Label()
        Me.VbnetimdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlNavigation.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlPreSearch.SuspendLayout()
        Me.pnlSearchMovie.SuspendLayout()
        Me.pnlSearchCrew.SuspendLayout()
        Me.pnlAfterSearch.SuspendLayout()
        CType(Me.dgvSearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWelcome.SuspendLayout()
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWinCtrlBox.SuspendLayout()
        CType(Me.picWinCtrlMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWinCtrlMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWinCtrlExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWinCtrl.SuspendLayout()
        Me.pnlMovie.SuspendLayout()
        CType(Me.dgvMovieList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbout.SuspendLayout()
        Me.pnlAbout1.SuspendLayout()
        CType(Me.picAbout1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbout2.SuspendLayout()
        CType(Me.picAbout2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbout3.SuspendLayout()
        CType(Me.picAbout3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VbnetimdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlNavigation
        '
        Me.pnlNavigation.BackColor = System.Drawing.Color.MediumAquamarine
        Me.pnlNavigation.Controls.Add(Me.lblProgramName)
        Me.pnlNavigation.Controls.Add(Me.btnpnlSearch)
        Me.pnlNavigation.Controls.Add(Me.btnpnlAbout)
        Me.pnlNavigation.Controls.Add(Me.btnpnlLogout)
        Me.pnlNavigation.Controls.Add(Me.btnpnlExit)
        Me.pnlNavigation.Controls.Add(Me.btnpnlMovie)
        Me.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNavigation.Location = New System.Drawing.Point(0, 0)
        Me.pnlNavigation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(268, 711)
        Me.pnlNavigation.TabIndex = 0
        '
        'lblProgramName
        '
        Me.lblProgramName.AutoSize = True
        Me.lblProgramName.BackColor = System.Drawing.Color.Transparent
        Me.lblProgramName.Font = New System.Drawing.Font("Microsoft JhengHei", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblProgramName.ForeColor = System.Drawing.Color.Green
        Me.lblProgramName.Location = New System.Drawing.Point(16, 59)
        Me.lblProgramName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(211, 43)
        Me.lblProgramName.TabIndex = 1
        Me.lblProgramName.Text = "Power Apps"
        '
        'btnpnlSearch
        '
        Me.btnpnlSearch.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpnlSearch.CausesValidation = False
        Me.btnpnlSearch.FlatAppearance.BorderSize = 0
        Me.btnpnlSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpnlSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnpnlSearch.ForeColor = System.Drawing.Color.Black
        Me.btnpnlSearch.Image = CType(resources.GetObject("btnpnlSearch.Image"), System.Drawing.Image)
        Me.btnpnlSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpnlSearch.Location = New System.Drawing.Point(0, 137)
        Me.btnpnlSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.btnpnlSearch.Name = "btnpnlSearch"
        Me.btnpnlSearch.Size = New System.Drawing.Size(268, 65)
        Me.btnpnlSearch.TabIndex = 0
        Me.btnpnlSearch.Text = "Search "
        Me.btnpnlSearch.UseVisualStyleBackColor = False
        '
        'btnpnlAbout
        '
        Me.btnpnlAbout.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpnlAbout.CausesValidation = False
        Me.btnpnlAbout.FlatAppearance.BorderSize = 0
        Me.btnpnlAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpnlAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnpnlAbout.ForeColor = System.Drawing.Color.Black
        Me.btnpnlAbout.Image = CType(resources.GetObject("btnpnlAbout.Image"), System.Drawing.Image)
        Me.btnpnlAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpnlAbout.Location = New System.Drawing.Point(0, 309)
        Me.btnpnlAbout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnpnlAbout.Name = "btnpnlAbout"
        Me.btnpnlAbout.Size = New System.Drawing.Size(268, 65)
        Me.btnpnlAbout.TabIndex = 0
        Me.btnpnlAbout.Text = "About"
        Me.btnpnlAbout.UseVisualStyleBackColor = False
        '
        'btnpnlLogout
        '
        Me.btnpnlLogout.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpnlLogout.FlatAppearance.BorderSize = 0
        Me.btnpnlLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpnlLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnpnlLogout.ForeColor = System.Drawing.Color.Black
        Me.btnpnlLogout.Image = CType(resources.GetObject("btnpnlLogout.Image"), System.Drawing.Image)
        Me.btnpnlLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpnlLogout.Location = New System.Drawing.Point(0, 395)
        Me.btnpnlLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnpnlLogout.Name = "btnpnlLogout"
        Me.btnpnlLogout.Size = New System.Drawing.Size(268, 65)
        Me.btnpnlLogout.TabIndex = 0
        Me.btnpnlLogout.Text = "Logout"
        Me.btnpnlLogout.UseVisualStyleBackColor = False
        '
        'btnpnlExit
        '
        Me.btnpnlExit.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpnlExit.FlatAppearance.BorderSize = 0
        Me.btnpnlExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpnlExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnpnlExit.ForeColor = System.Drawing.Color.Black
        Me.btnpnlExit.Image = CType(resources.GetObject("btnpnlExit.Image"), System.Drawing.Image)
        Me.btnpnlExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpnlExit.Location = New System.Drawing.Point(0, 480)
        Me.btnpnlExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnpnlExit.Name = "btnpnlExit"
        Me.btnpnlExit.Size = New System.Drawing.Size(268, 65)
        Me.btnpnlExit.TabIndex = 0
        Me.btnpnlExit.Text = "Exit"
        Me.btnpnlExit.UseVisualStyleBackColor = False
        '
        'btnpnlMovie
        '
        Me.btnpnlMovie.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpnlMovie.CausesValidation = False
        Me.btnpnlMovie.FlatAppearance.BorderSize = 0
        Me.btnpnlMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpnlMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnpnlMovie.ForeColor = System.Drawing.Color.Black
        Me.btnpnlMovie.Image = CType(resources.GetObject("btnpnlMovie.Image"), System.Drawing.Image)
        Me.btnpnlMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpnlMovie.Location = New System.Drawing.Point(0, 223)
        Me.btnpnlMovie.Margin = New System.Windows.Forms.Padding(0)
        Me.btnpnlMovie.Name = "btnpnlMovie"
        Me.btnpnlMovie.Size = New System.Drawing.Size(268, 65)
        Me.btnpnlMovie.TabIndex = 0
        Me.btnpnlMovie.Text = "Movie"
        Me.btnpnlMovie.UseVisualStyleBackColor = False
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.pnlPreSearch)
        Me.pnlSearch.Controls.Add(Me.pnlAfterSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(268, 52)
        Me.pnlSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1192, 660)
        Me.pnlSearch.TabIndex = 3
        '
        'pnlPreSearch
        '
        Me.pnlPreSearch.Controls.Add(Me.lblPreSearchBy)
        Me.pnlPreSearch.Controls.Add(Me.radPreSearchByMovie)
        Me.pnlPreSearch.Controls.Add(Me.radPreSearchByCrew)
        Me.pnlPreSearch.Controls.Add(Me.pnlSearchMovie)
        Me.pnlPreSearch.Controls.Add(Me.pnlSearchCrew)
        Me.pnlPreSearch.Controls.Add(Me.btnPreSearch)
        Me.pnlPreSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlPreSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPreSearch.Name = "pnlPreSearch"
        Me.pnlPreSearch.Size = New System.Drawing.Size(1192, 660)
        Me.pnlPreSearch.TabIndex = 4
        '
        'lblPreSearchBy
        '
        Me.lblPreSearchBy.AutoSize = True
        Me.lblPreSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreSearchBy.Location = New System.Drawing.Point(51, 31)
        Me.lblPreSearchBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreSearchBy.Name = "lblPreSearchBy"
        Me.lblPreSearchBy.Size = New System.Drawing.Size(128, 29)
        Me.lblPreSearchBy.TabIndex = 28
        Me.lblPreSearchBy.Text = "Search By:"
        '
        'radPreSearchByMovie
        '
        Me.radPreSearchByMovie.AutoSize = True
        Me.radPreSearchByMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPreSearchByMovie.Location = New System.Drawing.Point(223, 31)
        Me.radPreSearchByMovie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radPreSearchByMovie.Name = "radPreSearchByMovie"
        Me.radPreSearchByMovie.Size = New System.Drawing.Size(99, 33)
        Me.radPreSearchByMovie.TabIndex = 24
        Me.radPreSearchByMovie.TabStop = True
        Me.radPreSearchByMovie.Text = "Movie"
        Me.radPreSearchByMovie.UseVisualStyleBackColor = True
        '
        'radPreSearchByCrew
        '
        Me.radPreSearchByCrew.AutoSize = True
        Me.radPreSearchByCrew.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPreSearchByCrew.Location = New System.Drawing.Point(356, 31)
        Me.radPreSearchByCrew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radPreSearchByCrew.Name = "radPreSearchByCrew"
        Me.radPreSearchByCrew.Size = New System.Drawing.Size(91, 33)
        Me.radPreSearchByCrew.TabIndex = 25
        Me.radPreSearchByCrew.TabStop = True
        Me.radPreSearchByCrew.Text = "Crew"
        Me.radPreSearchByCrew.UseVisualStyleBackColor = True
        '
        'pnlSearchMovie
        '
        Me.pnlSearchMovie.Controls.Add(Me.lblSearchMTitle)
        Me.pnlSearchMovie.Controls.Add(Me.lblSearchMName)
        Me.pnlSearchMovie.Controls.Add(Me.txtSearchMName)
        Me.pnlSearchMovie.Controls.Add(Me.lblSearchMRYear)
        Me.pnlSearchMovie.Controls.Add(Me.cboSearchMRYearMod)
        Me.pnlSearchMovie.Controls.Add(Me.txtSearchMRYear)
        Me.pnlSearchMovie.Controls.Add(Me.lblSearchMEYear)
        Me.pnlSearchMovie.Controls.Add(Me.txtSearchMEYear)
        Me.pnlSearchMovie.Controls.Add(Me.lblSearchMRTM)
        Me.pnlSearchMovie.Controls.Add(Me.cboSearchMRTMMod)
        Me.pnlSearchMovie.Controls.Add(Me.txtSearchMRTM)
        Me.pnlSearchMovie.Controls.Add(Me.lblSearchMGenre)
        Me.pnlSearchMovie.Controls.Add(Me.cboSearchMGenre)
        Me.pnlSearchMovie.Controls.Add(Me.lblSearchMRating)
        Me.pnlSearchMovie.Controls.Add(Me.cboSearchMRatingMod)
        Me.pnlSearchMovie.Controls.Add(Me.txtSearchMRating)
        Me.pnlSearchMovie.Location = New System.Drawing.Point(24, 69)
        Me.pnlSearchMovie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSearchMovie.Name = "pnlSearchMovie"
        Me.pnlSearchMovie.Size = New System.Drawing.Size(769, 448)
        Me.pnlSearchMovie.TabIndex = 26
        '
        'lblSearchMTitle
        '
        Me.lblSearchMTitle.AutoSize = True
        Me.lblSearchMTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMTitle.Location = New System.Drawing.Point(23, 17)
        Me.lblSearchMTitle.Name = "lblSearchMTitle"
        Me.lblSearchMTitle.Size = New System.Drawing.Size(122, 44)
        Me.lblSearchMTitle.TabIndex = 13
        Me.lblSearchMTitle.Text = "Movie"
        '
        'lblSearchMName
        '
        Me.lblSearchMName.AutoSize = True
        Me.lblSearchMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMName.Location = New System.Drawing.Point(115, 84)
        Me.lblSearchMName.Name = "lblSearchMName"
        Me.lblSearchMName.Size = New System.Drawing.Size(113, 25)
        Me.lblSearchMName.TabIndex = 4
        Me.lblSearchMName.Text = "Movie Title:"
        '
        'txtSearchMName
        '
        Me.txtSearchMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchMName.Location = New System.Drawing.Point(241, 71)
        Me.txtSearchMName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchMName.Name = "txtSearchMName"
        Me.txtSearchMName.Size = New System.Drawing.Size(407, 46)
        Me.txtSearchMName.TabIndex = 0
        '
        'lblSearchMRYear
        '
        Me.lblSearchMRYear.AutoSize = True
        Me.lblSearchMRYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMRYear.Location = New System.Drawing.Point(84, 145)
        Me.lblSearchMRYear.Name = "lblSearchMRYear"
        Me.lblSearchMRYear.Size = New System.Drawing.Size(135, 25)
        Me.lblSearchMRYear.TabIndex = 5
        Me.lblSearchMRYear.Text = "Release Year:"
        '
        'cboSearchMRYearMod
        '
        Me.cboSearchMRYearMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchMRYearMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchMRYearMod.FormattingEnabled = True
        Me.cboSearchMRYearMod.Location = New System.Drawing.Point(241, 133)
        Me.cboSearchMRYearMod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSearchMRYearMod.Name = "cboSearchMRYearMod"
        Me.cboSearchMRYearMod.Size = New System.Drawing.Size(85, 47)
        Me.cboSearchMRYearMod.TabIndex = 21
        '
        'txtSearchMRYear
        '
        Me.txtSearchMRYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchMRYear.Location = New System.Drawing.Point(340, 133)
        Me.txtSearchMRYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchMRYear.Name = "txtSearchMRYear"
        Me.txtSearchMRYear.Size = New System.Drawing.Size(156, 46)
        Me.txtSearchMRYear.TabIndex = 0
        '
        'lblSearchMEYear
        '
        Me.lblSearchMEYear.AutoSize = True
        Me.lblSearchMEYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMEYear.Location = New System.Drawing.Point(96, 207)
        Me.lblSearchMEYear.Name = "lblSearchMEYear"
        Me.lblSearchMEYear.Size = New System.Drawing.Size(125, 25)
        Me.lblSearchMEYear.TabIndex = 15
        Me.lblSearchMEYear.Text = "Ending Year:"
        '
        'txtSearchMEYear
        '
        Me.txtSearchMEYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchMEYear.Location = New System.Drawing.Point(241, 194)
        Me.txtSearchMEYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchMEYear.Name = "txtSearchMEYear"
        Me.txtSearchMEYear.Size = New System.Drawing.Size(157, 46)
        Me.txtSearchMEYear.TabIndex = 7
        '
        'lblSearchMRTM
        '
        Me.lblSearchMRTM.AutoSize = True
        Me.lblSearchMRTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMRTM.Location = New System.Drawing.Point(53, 268)
        Me.lblSearchMRTM.Name = "lblSearchMRTM"
        Me.lblSearchMRTM.Size = New System.Drawing.Size(163, 25)
        Me.lblSearchMRTM.TabIndex = 9
        Me.lblSearchMRTM.Text = "Runtime Minutes:"
        '
        'cboSearchMRTMMod
        '
        Me.cboSearchMRTMMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchMRTMMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchMRTMMod.FormattingEnabled = True
        Me.cboSearchMRTMMod.Location = New System.Drawing.Point(241, 256)
        Me.cboSearchMRTMMod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSearchMRTMMod.Name = "cboSearchMRTMMod"
        Me.cboSearchMRTMMod.Size = New System.Drawing.Size(85, 47)
        Me.cboSearchMRTMMod.TabIndex = 14
        '
        'txtSearchMRTM
        '
        Me.txtSearchMRTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchMRTM.Location = New System.Drawing.Point(340, 256)
        Me.txtSearchMRTM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchMRTM.Name = "txtSearchMRTM"
        Me.txtSearchMRTM.Size = New System.Drawing.Size(95, 46)
        Me.txtSearchMRTM.TabIndex = 11
        '
        'lblSearchMGenre
        '
        Me.lblSearchMGenre.AutoSize = True
        Me.lblSearchMGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMGenre.Location = New System.Drawing.Point(153, 330)
        Me.lblSearchMGenre.Name = "lblSearchMGenre"
        Me.lblSearchMGenre.Size = New System.Drawing.Size(72, 25)
        Me.lblSearchMGenre.TabIndex = 6
        Me.lblSearchMGenre.Text = "Genre:"
        '
        'cboSearchMGenre
        '
        Me.cboSearchMGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchMGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchMGenre.FormattingEnabled = True
        Me.cboSearchMGenre.Location = New System.Drawing.Point(241, 318)
        Me.cboSearchMGenre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSearchMGenre.Name = "cboSearchMGenre"
        Me.cboSearchMGenre.Size = New System.Drawing.Size(249, 47)
        Me.cboSearchMGenre.TabIndex = 2
        '
        'lblSearchMRating
        '
        Me.lblSearchMRating.AutoSize = True
        Me.lblSearchMRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMRating.Location = New System.Drawing.Point(140, 391)
        Me.lblSearchMRating.Name = "lblSearchMRating"
        Me.lblSearchMRating.Size = New System.Drawing.Size(83, 25)
        Me.lblSearchMRating.TabIndex = 16
        Me.lblSearchMRating.Text = "Ratings:"
        '
        'cboSearchMRatingMod
        '
        Me.cboSearchMRatingMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchMRatingMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchMRatingMod.FormattingEnabled = True
        Me.cboSearchMRatingMod.Location = New System.Drawing.Point(241, 379)
        Me.cboSearchMRatingMod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSearchMRatingMod.Name = "cboSearchMRatingMod"
        Me.cboSearchMRatingMod.Size = New System.Drawing.Size(85, 47)
        Me.cboSearchMRatingMod.TabIndex = 18
        '
        'txtSearchMRating
        '
        Me.txtSearchMRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchMRating.Location = New System.Drawing.Point(340, 379)
        Me.txtSearchMRating.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchMRating.Name = "txtSearchMRating"
        Me.txtSearchMRating.Size = New System.Drawing.Size(95, 46)
        Me.txtSearchMRating.TabIndex = 17
        '
        'pnlSearchCrew
        '
        Me.pnlSearchCrew.Controls.Add(Me.lblSearchCTitle)
        Me.pnlSearchCrew.Controls.Add(Me.lblSearchCName)
        Me.pnlSearchCrew.Controls.Add(Me.txtSearchCName)
        Me.pnlSearchCrew.Controls.Add(Me.lblSearchCPos)
        Me.pnlSearchCrew.Controls.Add(Me.txtSearchCPos)
        Me.pnlSearchCrew.Controls.Add(Me.lblSearchCBYear)
        Me.pnlSearchCrew.Controls.Add(Me.cboSearchCBYearMod)
        Me.pnlSearchCrew.Controls.Add(Me.txtSearchCBYear)
        Me.pnlSearchCrew.Controls.Add(Me.lblSearchCDYear)
        Me.pnlSearchCrew.Controls.Add(Me.txtSearchCDYear)
        Me.pnlSearchCrew.Controls.Add(Me.lblSearchCProf)
        Me.pnlSearchCrew.Controls.Add(Me.txtSearchCProf)
        Me.pnlSearchCrew.Location = New System.Drawing.Point(24, 69)
        Me.pnlSearchCrew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSearchCrew.Name = "pnlSearchCrew"
        Me.pnlSearchCrew.Size = New System.Drawing.Size(769, 448)
        Me.pnlSearchCrew.TabIndex = 27
        '
        'lblSearchCTitle
        '
        Me.lblSearchCTitle.AutoSize = True
        Me.lblSearchCTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchCTitle.Location = New System.Drawing.Point(23, 17)
        Me.lblSearchCTitle.Name = "lblSearchCTitle"
        Me.lblSearchCTitle.Size = New System.Drawing.Size(108, 44)
        Me.lblSearchCTitle.TabIndex = 14
        Me.lblSearchCTitle.Text = "Crew"
        '
        'lblSearchCName
        '
        Me.lblSearchCName.AutoSize = True
        Me.lblSearchCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchCName.Location = New System.Drawing.Point(157, 84)
        Me.lblSearchCName.Name = "lblSearchCName"
        Me.lblSearchCName.Size = New System.Drawing.Size(70, 25)
        Me.lblSearchCName.TabIndex = 22
        Me.lblSearchCName.Text = "Name:"
        '
        'txtSearchCName
        '
        Me.txtSearchCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCName.Location = New System.Drawing.Point(241, 71)
        Me.txtSearchCName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchCName.Name = "txtSearchCName"
        Me.txtSearchCName.Size = New System.Drawing.Size(407, 46)
        Me.txtSearchCName.TabIndex = 21
        '
        'lblSearchCPos
        '
        Me.lblSearchCPos.AutoSize = True
        Me.lblSearchCPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchCPos.Location = New System.Drawing.Point(139, 145)
        Me.lblSearchCPos.Name = "lblSearchCPos"
        Me.lblSearchCPos.Size = New System.Drawing.Size(87, 25)
        Me.lblSearchCPos.TabIndex = 24
        Me.lblSearchCPos.Text = "Position:"
        '
        'txtSearchCPos
        '
        Me.txtSearchCPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCPos.Location = New System.Drawing.Point(241, 133)
        Me.txtSearchCPos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchCPos.Name = "txtSearchCPos"
        Me.txtSearchCPos.Size = New System.Drawing.Size(407, 46)
        Me.txtSearchCPos.TabIndex = 23
        '
        'lblSearchCBYear
        '
        Me.lblSearchCBYear.AutoSize = True
        Me.lblSearchCBYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchCBYear.Location = New System.Drawing.Point(119, 207)
        Me.lblSearchCBYear.Name = "lblSearchCBYear"
        Me.lblSearchCBYear.Size = New System.Drawing.Size(103, 25)
        Me.lblSearchCBYear.TabIndex = 23
        Me.lblSearchCBYear.Text = "Birth Year:"
        '
        'cboSearchCBYearMod
        '
        Me.cboSearchCBYearMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchCBYearMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchCBYearMod.FormattingEnabled = True
        Me.cboSearchCBYearMod.Location = New System.Drawing.Point(241, 194)
        Me.cboSearchCBYearMod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSearchCBYearMod.Name = "cboSearchCBYearMod"
        Me.cboSearchCBYearMod.Size = New System.Drawing.Size(85, 47)
        Me.cboSearchCBYearMod.TabIndex = 24
        '
        'txtSearchCBYear
        '
        Me.txtSearchCBYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCBYear.Location = New System.Drawing.Point(340, 194)
        Me.txtSearchCBYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchCBYear.Name = "txtSearchCBYear"
        Me.txtSearchCBYear.Size = New System.Drawing.Size(156, 46)
        Me.txtSearchCBYear.TabIndex = 22
        '
        'lblSearchCDYear
        '
        Me.lblSearchCDYear.AutoSize = True
        Me.lblSearchCDYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchCDYear.Location = New System.Drawing.Point(104, 268)
        Me.lblSearchCDYear.Name = "lblSearchCDYear"
        Me.lblSearchCDYear.Size = New System.Drawing.Size(116, 25)
        Me.lblSearchCDYear.TabIndex = 25
        Me.lblSearchCDYear.Text = "Death Year:"
        '
        'txtSearchCDYear
        '
        Me.txtSearchCDYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCDYear.Location = New System.Drawing.Point(241, 258)
        Me.txtSearchCDYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchCDYear.Name = "txtSearchCDYear"
        Me.txtSearchCDYear.Size = New System.Drawing.Size(156, 46)
        Me.txtSearchCDYear.TabIndex = 26
        '
        'lblSearchCProf
        '
        Me.lblSearchCProf.AutoSize = True
        Me.lblSearchCProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchCProf.Location = New System.Drawing.Point(113, 330)
        Me.lblSearchCProf.Name = "lblSearchCProf"
        Me.lblSearchCProf.Size = New System.Drawing.Size(110, 25)
        Me.lblSearchCProf.TabIndex = 28
        Me.lblSearchCProf.Text = "Profession:"
        '
        'txtSearchCProf
        '
        Me.txtSearchCProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCProf.Location = New System.Drawing.Point(241, 315)
        Me.txtSearchCProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchCProf.Name = "txtSearchCProf"
        Me.txtSearchCProf.Size = New System.Drawing.Size(407, 46)
        Me.txtSearchCProf.TabIndex = 27
        '
        'btnPreSearch
        '
        Me.btnPreSearch.BackColor = System.Drawing.Color.Aquamarine
        Me.btnPreSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreSearch.Location = New System.Drawing.Point(51, 544)
        Me.btnPreSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPreSearch.Name = "btnPreSearch"
        Me.btnPreSearch.Size = New System.Drawing.Size(211, 80)
        Me.btnPreSearch.TabIndex = 3
        Me.btnPreSearch.Text = "Search"
        Me.btnPreSearch.UseVisualStyleBackColor = False
        '
        'pnlAfterSearch
        '
        Me.pnlAfterSearch.Controls.Add(Me.btnAfterSearchBack)
        Me.pnlAfterSearch.Controls.Add(Me.btnAfterSearchPrevious)
        Me.pnlAfterSearch.Controls.Add(Me.btnAfterSearchNext)
        Me.pnlAfterSearch.Controls.Add(Me.dgvSearchResult)
        Me.pnlAfterSearch.Location = New System.Drawing.Point(1, 0)
        Me.pnlAfterSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlAfterSearch.Name = "pnlAfterSearch"
        Me.pnlAfterSearch.Size = New System.Drawing.Size(1192, 660)
        Me.pnlAfterSearch.TabIndex = 4
        '
        'btnAfterSearchBack
        '
        Me.btnAfterSearchBack.BackColor = System.Drawing.Color.Aquamarine
        Me.btnAfterSearchBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfterSearchBack.Location = New System.Drawing.Point(17, 11)
        Me.btnAfterSearchBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAfterSearchBack.Name = "btnAfterSearchBack"
        Me.btnAfterSearchBack.Size = New System.Drawing.Size(211, 80)
        Me.btnAfterSearchBack.TabIndex = 0
        Me.btnAfterSearchBack.Text = "Back"
        Me.btnAfterSearchBack.UseVisualStyleBackColor = False
        '
        'btnAfterSearchPrevious
        '
        Me.btnAfterSearchPrevious.BackColor = System.Drawing.Color.Aquamarine
        Me.btnAfterSearchPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfterSearchPrevious.Location = New System.Drawing.Point(785, 48)
        Me.btnAfterSearchPrevious.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAfterSearchPrevious.Name = "btnAfterSearchPrevious"
        Me.btnAfterSearchPrevious.Size = New System.Drawing.Size(184, 43)
        Me.btnAfterSearchPrevious.TabIndex = 4
        Me.btnAfterSearchPrevious.Text = "Previous"
        Me.btnAfterSearchPrevious.UseVisualStyleBackColor = False
        '
        'btnAfterSearchNext
        '
        Me.btnAfterSearchNext.BackColor = System.Drawing.Color.Aquamarine
        Me.btnAfterSearchNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfterSearchNext.Location = New System.Drawing.Point(991, 48)
        Me.btnAfterSearchNext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAfterSearchNext.Name = "btnAfterSearchNext"
        Me.btnAfterSearchNext.Size = New System.Drawing.Size(184, 43)
        Me.btnAfterSearchNext.TabIndex = 5
        Me.btnAfterSearchNext.Text = "Next"
        Me.btnAfterSearchNext.UseVisualStyleBackColor = False
        '
        'dgvSearchResult
        '
        Me.dgvSearchResult.AllowUserToAddRows = False
        Me.dgvSearchResult.AllowUserToDeleteRows = False
        Me.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResult.Location = New System.Drawing.Point(17, 97)
        Me.dgvSearchResult.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvSearchResult.Name = "dgvSearchResult"
        Me.dgvSearchResult.ReadOnly = True
        Me.dgvSearchResult.RowTemplate.Height = 24
        Me.dgvSearchResult.Size = New System.Drawing.Size(1159, 549)
        Me.dgvSearchResult.TabIndex = 1
        '
        'pnlWelcome
        '
        Me.pnlWelcome.Controls.Add(Me.picWelcome)
        Me.pnlWelcome.Location = New System.Drawing.Point(268, 52)
        Me.pnlWelcome.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlWelcome.Name = "pnlWelcome"
        Me.pnlWelcome.Size = New System.Drawing.Size(1192, 660)
        Me.pnlWelcome.TabIndex = 5
        '
        'picWelcome
        '
        Me.picWelcome.Image = CType(resources.GetObject("picWelcome.Image"), System.Drawing.Image)
        Me.picWelcome.Location = New System.Drawing.Point(0, 0)
        Me.picWelcome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWelcome.Name = "picWelcome"
        Me.picWelcome.Size = New System.Drawing.Size(1192, 660)
        Me.picWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWelcome.TabIndex = 0
        Me.picWelcome.TabStop = False
        '
        'pnlWinCtrlBox
        '
        Me.pnlWinCtrlBox.Controls.Add(Me.picWinCtrlMinimize)
        Me.pnlWinCtrlBox.Controls.Add(Me.picWinCtrlMaximize)
        Me.pnlWinCtrlBox.Controls.Add(Me.picWinCtrlExit)
        Me.pnlWinCtrlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlWinCtrlBox.Location = New System.Drawing.Point(1021, 0)
        Me.pnlWinCtrlBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlWinCtrlBox.Name = "pnlWinCtrlBox"
        Me.pnlWinCtrlBox.Size = New System.Drawing.Size(171, 52)
        Me.pnlWinCtrlBox.TabIndex = 3
        '
        'picWinCtrlMinimize
        '
        Me.picWinCtrlMinimize.Image = CType(resources.GetObject("picWinCtrlMinimize.Image"), System.Drawing.Image)
        Me.picWinCtrlMinimize.Location = New System.Drawing.Point(5, 5)
        Me.picWinCtrlMinimize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWinCtrlMinimize.Name = "picWinCtrlMinimize"
        Me.picWinCtrlMinimize.Size = New System.Drawing.Size(47, 43)
        Me.picWinCtrlMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWinCtrlMinimize.TabIndex = 2
        Me.picWinCtrlMinimize.TabStop = False
        '
        'picWinCtrlMaximize
        '
        Me.picWinCtrlMaximize.Image = CType(resources.GetObject("picWinCtrlMaximize.Image"), System.Drawing.Image)
        Me.picWinCtrlMaximize.Location = New System.Drawing.Point(60, 5)
        Me.picWinCtrlMaximize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWinCtrlMaximize.Name = "picWinCtrlMaximize"
        Me.picWinCtrlMaximize.Size = New System.Drawing.Size(47, 43)
        Me.picWinCtrlMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWinCtrlMaximize.TabIndex = 2
        Me.picWinCtrlMaximize.TabStop = False
        '
        'picWinCtrlExit
        '
        Me.picWinCtrlExit.Image = CType(resources.GetObject("picWinCtrlExit.Image"), System.Drawing.Image)
        Me.picWinCtrlExit.Location = New System.Drawing.Point(115, 5)
        Me.picWinCtrlExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWinCtrlExit.Name = "picWinCtrlExit"
        Me.picWinCtrlExit.Size = New System.Drawing.Size(47, 43)
        Me.picWinCtrlExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWinCtrlExit.TabIndex = 2
        Me.picWinCtrlExit.TabStop = False
        '
        'pnlWinCtrl
        '
        Me.pnlWinCtrl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlWinCtrl.Controls.Add(Me.pnlWinCtrlBox)
        Me.pnlWinCtrl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlWinCtrl.Location = New System.Drawing.Point(268, 0)
        Me.pnlWinCtrl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlWinCtrl.Name = "pnlWinCtrl"
        Me.pnlWinCtrl.Size = New System.Drawing.Size(1192, 52)
        Me.pnlWinCtrl.TabIndex = 1
        '
        'pnlMovie
        '
        Me.pnlMovie.Controls.Add(Me.btnNextMovie)
        Me.pnlMovie.Controls.Add(Me.btnPreviousMovie)
        Me.pnlMovie.Controls.Add(Me.btnLoadMovie)
        Me.pnlMovie.Controls.Add(Me.dgvMovieList)
        Me.pnlMovie.Location = New System.Drawing.Point(268, 52)
        Me.pnlMovie.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMovie.Name = "pnlMovie"
        Me.pnlMovie.Size = New System.Drawing.Size(1192, 660)
        Me.pnlMovie.TabIndex = 5
        '
        'btnNextMovie
        '
        Me.btnNextMovie.BackColor = System.Drawing.Color.Aquamarine
        Me.btnNextMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextMovie.Location = New System.Drawing.Point(932, 32)
        Me.btnNextMovie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNextMovie.Name = "btnNextMovie"
        Me.btnNextMovie.Size = New System.Drawing.Size(184, 43)
        Me.btnNextMovie.TabIndex = 7
        Me.btnNextMovie.Text = "Next"
        Me.btnNextMovie.UseVisualStyleBackColor = False
        '
        'btnPreviousMovie
        '
        Me.btnPreviousMovie.BackColor = System.Drawing.Color.Aquamarine
        Me.btnPreviousMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousMovie.Location = New System.Drawing.Point(739, 32)
        Me.btnPreviousMovie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPreviousMovie.Name = "btnPreviousMovie"
        Me.btnPreviousMovie.Size = New System.Drawing.Size(184, 43)
        Me.btnPreviousMovie.TabIndex = 6
        Me.btnPreviousMovie.Text = "Previous"
        Me.btnPreviousMovie.UseVisualStyleBackColor = False
        '
        'btnLoadMovie
        '
        Me.btnLoadMovie.BackColor = System.Drawing.Color.Aquamarine
        Me.btnLoadMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadMovie.Location = New System.Drawing.Point(33, 32)
        Me.btnLoadMovie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLoadMovie.Name = "btnLoadMovie"
        Me.btnLoadMovie.Size = New System.Drawing.Size(184, 43)
        Me.btnLoadMovie.TabIndex = 5
        Me.btnLoadMovie.Text = "Load"
        Me.btnLoadMovie.UseVisualStyleBackColor = False
        '
        'dgvMovieList
        '
        Me.dgvMovieList.AllowUserToAddRows = False
        Me.dgvMovieList.AllowUserToDeleteRows = False
        Me.dgvMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovieList.Location = New System.Drawing.Point(33, 82)
        Me.dgvMovieList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvMovieList.Name = "dgvMovieList"
        Me.dgvMovieList.ReadOnly = True
        Me.dgvMovieList.Size = New System.Drawing.Size(1083, 486)
        Me.dgvMovieList.TabIndex = 0
        '
        'pnlAbout
        '
        Me.pnlAbout.Controls.Add(Me.lblAbout)
        Me.pnlAbout.Controls.Add(Me.pnlAbout1)
        Me.pnlAbout.Controls.Add(Me.pnlAbout2)
        Me.pnlAbout.Controls.Add(Me.pnlAbout3)
        Me.pnlAbout.Location = New System.Drawing.Point(268, 52)
        Me.pnlAbout.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlAbout.Name = "pnlAbout"
        Me.pnlAbout.Size = New System.Drawing.Size(1192, 660)
        Me.pnlAbout.TabIndex = 6
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(505, 14)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(149, 37)
        Me.lblAbout.TabIndex = 3
        Me.lblAbout.Text = "About Us"
        '
        'pnlAbout1
        '
        Me.pnlAbout1.Controls.Add(Me.picAbout1)
        Me.pnlAbout1.Controls.Add(Me.lblAbout1Name)
        Me.pnlAbout1.Controls.Add(Me.lblAbout1NameAns)
        Me.pnlAbout1.Controls.Add(Me.lblAbout1Age)
        Me.pnlAbout1.Controls.Add(Me.lblAbout1AgeAns)
        Me.pnlAbout1.Controls.Add(Me.lblAbout1TP)
        Me.pnlAbout1.Controls.Add(Me.lblAbout1TPAns)
        Me.pnlAbout1.Location = New System.Drawing.Point(59, 69)
        Me.pnlAbout1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlAbout1.Name = "pnlAbout1"
        Me.pnlAbout1.Size = New System.Drawing.Size(352, 559)
        Me.pnlAbout1.TabIndex = 0
        '
        'picAbout1
        '
        Me.picAbout1.Dock = System.Windows.Forms.DockStyle.Top
        Me.picAbout1.Image = CType(resources.GetObject("picAbout1.Image"), System.Drawing.Image)
        Me.picAbout1.Location = New System.Drawing.Point(0, 0)
        Me.picAbout1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picAbout1.Name = "picAbout1"
        Me.picAbout1.Size = New System.Drawing.Size(352, 218)
        Me.picAbout1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAbout1.TabIndex = 0
        Me.picAbout1.TabStop = False
        '
        'lblAbout1Name
        '
        Me.lblAbout1Name.AutoSize = True
        Me.lblAbout1Name.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout1Name.Location = New System.Drawing.Point(21, 266)
        Me.lblAbout1Name.Name = "lblAbout1Name"
        Me.lblAbout1Name.Size = New System.Drawing.Size(85, 34)
        Me.lblAbout1Name.TabIndex = 6
        Me.lblAbout1Name.Text = "Name:"
        '
        'lblAbout1NameAns
        '
        Me.lblAbout1NameAns.AutoSize = True
        Me.lblAbout1NameAns.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout1NameAns.Location = New System.Drawing.Point(105, 267)
        Me.lblAbout1NameAns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbout1NameAns.Name = "lblAbout1NameAns"
        Me.lblAbout1NameAns.Size = New System.Drawing.Size(210, 33)
        Me.lblAbout1NameAns.TabIndex = 2
        Me.lblAbout1NameAns.Text = "Ching Cheng Kang"
        '
        'lblAbout1Age
        '
        Me.lblAbout1Age.AutoSize = True
        Me.lblAbout1Age.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout1Age.Location = New System.Drawing.Point(41, 306)
        Me.lblAbout1Age.Name = "lblAbout1Age"
        Me.lblAbout1Age.Size = New System.Drawing.Size(66, 34)
        Me.lblAbout1Age.TabIndex = 4
        Me.lblAbout1Age.Text = "Age:"
        '
        'lblAbout1AgeAns
        '
        Me.lblAbout1AgeAns.AutoSize = True
        Me.lblAbout1AgeAns.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout1AgeAns.Location = New System.Drawing.Point(105, 306)
        Me.lblAbout1AgeAns.Name = "lblAbout1AgeAns"
        Me.lblAbout1AgeAns.Size = New System.Drawing.Size(45, 34)
        Me.lblAbout1AgeAns.TabIndex = 4
        Me.lblAbout1AgeAns.Text = "20"
        '
        'lblAbout1TP
        '
        Me.lblAbout1TP.AutoSize = True
        Me.lblAbout1TP.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout1TP.Location = New System.Drawing.Point(24, 346)
        Me.lblAbout1TP.Name = "lblAbout1TP"
        Me.lblAbout1TP.Size = New System.Drawing.Size(83, 33)
        Me.lblAbout1TP.TabIndex = 5
        Me.lblAbout1TP.Text = "TP.no:"
        '
        'lblAbout1TPAns
        '
        Me.lblAbout1TPAns.AutoSize = True
        Me.lblAbout1TPAns.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout1TPAns.Location = New System.Drawing.Point(105, 346)
        Me.lblAbout1TPAns.Name = "lblAbout1TPAns"
        Me.lblAbout1TPAns.Size = New System.Drawing.Size(130, 34)
        Me.lblAbout1TPAns.TabIndex = 5
        Me.lblAbout1TPAns.Text = "TP051436"
        '
        'pnlAbout2
        '
        Me.pnlAbout2.Controls.Add(Me.picAbout2)
        Me.pnlAbout2.Controls.Add(Me.lblAbout2Name)
        Me.pnlAbout2.Controls.Add(Me.lblAbout2NameAns)
        Me.pnlAbout2.Controls.Add(Me.lblAbout2Age)
        Me.pnlAbout2.Controls.Add(Me.lblAbout2AgeAns)
        Me.pnlAbout2.Controls.Add(Me.lblAbout2TP)
        Me.pnlAbout2.Controls.Add(Me.lblAbout2TPAns)
        Me.pnlAbout2.Location = New System.Drawing.Point(419, 69)
        Me.pnlAbout2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlAbout2.Name = "pnlAbout2"
        Me.pnlAbout2.Size = New System.Drawing.Size(352, 559)
        Me.pnlAbout2.TabIndex = 0
        '
        'picAbout2
        '
        Me.picAbout2.Dock = System.Windows.Forms.DockStyle.Top
        Me.picAbout2.Image = CType(resources.GetObject("picAbout2.Image"), System.Drawing.Image)
        Me.picAbout2.Location = New System.Drawing.Point(0, 0)
        Me.picAbout2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picAbout2.Name = "picAbout2"
        Me.picAbout2.Size = New System.Drawing.Size(352, 218)
        Me.picAbout2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAbout2.TabIndex = 0
        Me.picAbout2.TabStop = False
        '
        'lblAbout2Name
        '
        Me.lblAbout2Name.AutoSize = True
        Me.lblAbout2Name.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout2Name.Location = New System.Drawing.Point(27, 271)
        Me.lblAbout2Name.Name = "lblAbout2Name"
        Me.lblAbout2Name.Size = New System.Drawing.Size(85, 34)
        Me.lblAbout2Name.TabIndex = 6
        Me.lblAbout2Name.Text = "Name:"
        '
        'lblAbout2NameAns
        '
        Me.lblAbout2NameAns.AutoSize = True
        Me.lblAbout2NameAns.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout2NameAns.Location = New System.Drawing.Point(109, 272)
        Me.lblAbout2NameAns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbout2NameAns.Name = "lblAbout2NameAns"
        Me.lblAbout2NameAns.Size = New System.Drawing.Size(175, 33)
        Me.lblAbout2NameAns.TabIndex = 2
        Me.lblAbout2NameAns.Text = "Chan Chin Wei"
        '
        'lblAbout2Age
        '
        Me.lblAbout2Age.AutoSize = True
        Me.lblAbout2Age.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout2Age.Location = New System.Drawing.Point(45, 311)
        Me.lblAbout2Age.Name = "lblAbout2Age"
        Me.lblAbout2Age.Size = New System.Drawing.Size(66, 34)
        Me.lblAbout2Age.TabIndex = 4
        Me.lblAbout2Age.Text = "Age:"
        '
        'lblAbout2AgeAns
        '
        Me.lblAbout2AgeAns.AutoSize = True
        Me.lblAbout2AgeAns.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout2AgeAns.Location = New System.Drawing.Point(109, 311)
        Me.lblAbout2AgeAns.Name = "lblAbout2AgeAns"
        Me.lblAbout2AgeAns.Size = New System.Drawing.Size(41, 34)
        Me.lblAbout2AgeAns.TabIndex = 4
        Me.lblAbout2AgeAns.Text = "19"
        '
        'lblAbout2TP
        '
        Me.lblAbout2TP.AutoSize = True
        Me.lblAbout2TP.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout2TP.Location = New System.Drawing.Point(28, 351)
        Me.lblAbout2TP.Name = "lblAbout2TP"
        Me.lblAbout2TP.Size = New System.Drawing.Size(83, 33)
        Me.lblAbout2TP.TabIndex = 5
        Me.lblAbout2TP.Text = "TP.no:"
        '
        'lblAbout2TPAns
        '
        Me.lblAbout2TPAns.AutoSize = True
        Me.lblAbout2TPAns.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout2TPAns.Location = New System.Drawing.Point(109, 352)
        Me.lblAbout2TPAns.Name = "lblAbout2TPAns"
        Me.lblAbout2TPAns.Size = New System.Drawing.Size(130, 34)
        Me.lblAbout2TPAns.TabIndex = 5
        Me.lblAbout2TPAns.Text = "TP051429"
        '
        'pnlAbout3
        '
        Me.pnlAbout3.Controls.Add(Me.picAbout3)
        Me.pnlAbout3.Controls.Add(Me.lblAbout3Name)
        Me.pnlAbout3.Controls.Add(Me.lblAbout3NameAns)
        Me.pnlAbout3.Controls.Add(Me.lblAbout3Age)
        Me.pnlAbout3.Controls.Add(Me.lblAbout3AgeAns)
        Me.pnlAbout3.Controls.Add(Me.lblAbout3AgeTP)
        Me.pnlAbout3.Controls.Add(Me.lblAbout3AgeTPAns)
        Me.pnlAbout3.Location = New System.Drawing.Point(779, 69)
        Me.pnlAbout3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlAbout3.Name = "pnlAbout3"
        Me.pnlAbout3.Size = New System.Drawing.Size(352, 559)
        Me.pnlAbout3.TabIndex = 0
        '
        'picAbout3
        '
        Me.picAbout3.Dock = System.Windows.Forms.DockStyle.Top
        Me.picAbout3.Image = CType(resources.GetObject("picAbout3.Image"), System.Drawing.Image)
        Me.picAbout3.Location = New System.Drawing.Point(0, 0)
        Me.picAbout3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picAbout3.Name = "picAbout3"
        Me.picAbout3.Size = New System.Drawing.Size(352, 218)
        Me.picAbout3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAbout3.TabIndex = 0
        Me.picAbout3.TabStop = False
        '
        'lblAbout3Name
        '
        Me.lblAbout3Name.AutoSize = True
        Me.lblAbout3Name.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout3Name.Location = New System.Drawing.Point(33, 268)
        Me.lblAbout3Name.Name = "lblAbout3Name"
        Me.lblAbout3Name.Size = New System.Drawing.Size(85, 34)
        Me.lblAbout3Name.TabIndex = 6
        Me.lblAbout3Name.Text = "Name:"
        '
        'lblAbout3NameAns
        '
        Me.lblAbout3NameAns.AutoSize = True
        Me.lblAbout3NameAns.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout3NameAns.Location = New System.Drawing.Point(116, 270)
        Me.lblAbout3NameAns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbout3NameAns.Name = "lblAbout3NameAns"
        Me.lblAbout3NameAns.Size = New System.Drawing.Size(161, 33)
        Me.lblAbout3NameAns.TabIndex = 2
        Me.lblAbout3NameAns.Text = "Kok Hua Chin"
        '
        'lblAbout3Age
        '
        Me.lblAbout3Age.AutoSize = True
        Me.lblAbout3Age.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout3Age.Location = New System.Drawing.Point(52, 308)
        Me.lblAbout3Age.Name = "lblAbout3Age"
        Me.lblAbout3Age.Size = New System.Drawing.Size(66, 34)
        Me.lblAbout3Age.TabIndex = 4
        Me.lblAbout3Age.Text = "Age:"
        '
        'lblAbout3AgeAns
        '
        Me.lblAbout3AgeAns.AutoSize = True
        Me.lblAbout3AgeAns.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout3AgeAns.Location = New System.Drawing.Point(116, 308)
        Me.lblAbout3AgeAns.Name = "lblAbout3AgeAns"
        Me.lblAbout3AgeAns.Size = New System.Drawing.Size(41, 34)
        Me.lblAbout3AgeAns.TabIndex = 4
        Me.lblAbout3AgeAns.Text = "19"
        '
        'lblAbout3AgeTP
        '
        Me.lblAbout3AgeTP.AutoSize = True
        Me.lblAbout3AgeTP.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout3AgeTP.Location = New System.Drawing.Point(35, 348)
        Me.lblAbout3AgeTP.Name = "lblAbout3AgeTP"
        Me.lblAbout3AgeTP.Size = New System.Drawing.Size(83, 33)
        Me.lblAbout3AgeTP.TabIndex = 5
        Me.lblAbout3AgeTP.Text = "TP.no:"
        '
        'lblAbout3AgeTPAns
        '
        Me.lblAbout3AgeTPAns.AutoSize = True
        Me.lblAbout3AgeTPAns.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout3AgeTPAns.Location = New System.Drawing.Point(116, 350)
        Me.lblAbout3AgeTPAns.Name = "lblAbout3AgeTPAns"
        Me.lblAbout3AgeTPAns.Size = New System.Drawing.Size(126, 34)
        Me.lblAbout3AgeTPAns.TabIndex = 5
        Me.lblAbout3AgeTPAns.Text = "TP051210"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1460, 711)
        Me.Controls.Add(Me.pnlWinCtrl)
        Me.Controls.Add(Me.pnlNavigation)
        Me.Controls.Add(Me.pnlWelcome)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlMovie)
        Me.Controls.Add(Me.pnlAbout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home "
        Me.pnlNavigation.ResumeLayout(False)
        Me.pnlNavigation.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlPreSearch.ResumeLayout(False)
        Me.pnlPreSearch.PerformLayout()
        Me.pnlSearchMovie.ResumeLayout(False)
        Me.pnlSearchMovie.PerformLayout()
        Me.pnlSearchCrew.ResumeLayout(False)
        Me.pnlSearchCrew.PerformLayout()
        Me.pnlAfterSearch.ResumeLayout(False)
        CType(Me.dgvSearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWelcome.ResumeLayout(False)
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWinCtrlBox.ResumeLayout(False)
        CType(Me.picWinCtrlMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWinCtrlMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWinCtrlExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWinCtrl.ResumeLayout(False)
        Me.pnlMovie.ResumeLayout(False)
        CType(Me.dgvMovieList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbout.ResumeLayout(False)
        Me.pnlAbout.PerformLayout()
        Me.pnlAbout1.ResumeLayout(False)
        Me.pnlAbout1.PerformLayout()
        CType(Me.picAbout1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbout2.ResumeLayout(False)
        Me.pnlAbout2.PerformLayout()
        CType(Me.picAbout2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbout3.ResumeLayout(False)
        Me.pnlAbout3.PerformLayout()
        CType(Me.picAbout3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VbnetimdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents txtSearchMName As TextBox
    Friend WithEvents txtSearchMRYear As TextBox
    Friend WithEvents btnPreSearch As Button
    Friend WithEvents cboSearchMGenre As ComboBox
    Friend WithEvents pnlWelcome As Panel
    Friend WithEvents picWelcome As PictureBox
    Friend WithEvents btnpnlExit As Button
    Friend WithEvents btnpnlMovie As Button
    Friend WithEvents btnpnlAbout As Button
    Friend WithEvents btnpnlSearch As Button
    Friend WithEvents pnlWinCtrlBox As Panel
    Friend WithEvents picWinCtrlExit As PictureBox
    Friend WithEvents picWinCtrlMinimize As PictureBox
    Friend WithEvents picWinCtrlMaximize As PictureBox
    Friend WithEvents pnlWinCtrl As Panel
    Friend WithEvents pnlMovie As Panel
    Friend WithEvents pnlAbout As Panel
    Friend WithEvents pnlAbout1 As Panel
    Friend WithEvents picAbout1 As PictureBox
    Friend WithEvents pnlAbout3 As Panel
    Friend WithEvents picAbout3 As PictureBox
    Friend WithEvents pnlAbout2 As Panel
    Friend WithEvents picAbout2 As PictureBox
    Friend WithEvents lblAbout1NameAns As Label
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblAbout1Name As Label
    Friend WithEvents lblAbout1TPAns As Label
    Friend WithEvents lblAbout1TP As Label
    Friend WithEvents lblAbout1AgeAns As Label
    Friend WithEvents lblAbout1Age As Label
    Friend WithEvents lblAbout3Name As Label
    Friend WithEvents lblAbout3AgeTPAns As Label
    Friend WithEvents lblAbout3AgeAns As Label
    Friend WithEvents lblAbout3AgeTP As Label
    Friend WithEvents lblAbout3NameAns As Label
    Friend WithEvents lblAbout3Age As Label
    Friend WithEvents lblAbout2Name As Label
    Friend WithEvents lblAbout2TPAns As Label
    Friend WithEvents lblAbout2TP As Label
    Friend WithEvents lblAbout2AgeAns As Label
    Friend WithEvents lblAbout2Age As Label
    Friend WithEvents lblAbout2NameAns As Label
    Friend WithEvents pnlPreSearch As Panel
    Friend WithEvents pnlAfterSearch As Panel
    Friend WithEvents btnAfterSearchBack As Button
    Friend WithEvents VbnetimdbDataSetBindingSource As BindingSource
    Friend WithEvents dgvSearchResult As DataGridView
    Friend WithEvents txtSearchMRTM As TextBox
    Friend WithEvents lblSearchMRTM As Label
    Friend WithEvents txtSearchMEYear As TextBox
    Friend WithEvents lblSearchMGenre As Label
    Friend WithEvents lblSearchMRYear As Label
    Friend WithEvents lblSearchMName As Label
    Friend WithEvents lblSearchMTitle As Label
    Friend WithEvents cboSearchMRTMMod As ComboBox
    Friend WithEvents cboSearchMRatingMod As ComboBox
    Friend WithEvents txtSearchMRating As TextBox
    Friend WithEvents lblSearchMRating As Label
    Friend WithEvents lblSearchMEYear As Label
    Friend WithEvents btnAfterSearchNext As Button
    Friend WithEvents btnAfterSearchPrevious As Button
    Friend WithEvents btnLoadMovie As Button
    Friend WithEvents dgvMovieList As DataGridView
    Friend WithEvents btnNextMovie As Button
    Friend WithEvents btnPreviousMovie As Button
    Friend WithEvents cboSearchMRYearMod As ComboBox
    Friend WithEvents radPreSearchByCrew As RadioButton
    Friend WithEvents radPreSearchByMovie As RadioButton
    Friend WithEvents pnlSearchCrew As Panel
    Friend WithEvents lblSearchCProf As Label
    Friend WithEvents txtSearchCProf As TextBox
    Friend WithEvents txtSearchCDYear As TextBox
    Friend WithEvents lblSearchCDYear As Label
    Friend WithEvents txtSearchCBYear As TextBox
    Friend WithEvents lblSearchCPos As Label
    Friend WithEvents cboSearchCBYearMod As ComboBox
    Friend WithEvents txtSearchCPos As TextBox
    Friend WithEvents lblSearchCBYear As Label
    Friend WithEvents lblSearchCName As Label
    Friend WithEvents txtSearchCName As TextBox
    Friend WithEvents lblSearchCTitle As Label
    Friend WithEvents pnlSearchMovie As Panel
    Friend WithEvents lblPreSearchBy As Label
    Friend WithEvents lblProgramName As Label
    Friend WithEvents btnpnlLogout As Button
End Class
