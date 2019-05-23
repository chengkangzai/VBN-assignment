<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Function
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Function))
        Me.radakas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radactor = New System.Windows.Forms.RadioButton()
        Me.radratings = New System.Windows.Forms.RadioButton()
        Me.radprincipals = New System.Windows.Forms.RadioButton()
        Me.radepisode = New System.Windows.Forms.RadioButton()
        Me.radcrew = New System.Windows.Forms.RadioButton()
        Me.radbasic = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.DataSet1 = New System.Data.DataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radakas
        '
        Me.radakas.AutoSize = True
        Me.radakas.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.radakas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radakas.Location = New System.Drawing.Point(8, 23)
        Me.radakas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radakas.Name = "radakas"
        Me.radakas.Size = New System.Drawing.Size(78, 29)
        Me.radakas.TabIndex = 0
        Me.radakas.TabStop = True
        Me.radakas.Text = "Akas"
        Me.radakas.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.radactor)
        Me.GroupBox1.Controls.Add(Me.radratings)
        Me.GroupBox1.Controls.Add(Me.radprincipals)
        Me.GroupBox1.Controls.Add(Me.radepisode)
        Me.GroupBox1.Controls.Add(Me.radcrew)
        Me.GroupBox1.Controls.Add(Me.radbasic)
        Me.GroupBox1.Controls.Add(Me.radakas)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1252, 68)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Categoty (database)"
        '
        'radactor
        '
        Me.radactor.AutoSize = True
        Me.radactor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.radactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radactor.Location = New System.Drawing.Point(1061, 23)
        Me.radactor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radactor.Name = "radactor"
        Me.radactor.Size = New System.Drawing.Size(79, 29)
        Me.radactor.TabIndex = 0
        Me.radactor.TabStop = True
        Me.radactor.Text = "Actor"
        Me.radactor.UseVisualStyleBackColor = False
        '
        'radratings
        '
        Me.radratings.AutoSize = True
        Me.radratings.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.radratings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radratings.Location = New System.Drawing.Point(885, 23)
        Me.radratings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radratings.Name = "radratings"
        Me.radratings.Size = New System.Drawing.Size(98, 29)
        Me.radratings.TabIndex = 0
        Me.radratings.TabStop = True
        Me.radratings.Text = "Ratings"
        Me.radratings.UseVisualStyleBackColor = False
        '
        'radprincipals
        '
        Me.radprincipals.AutoSize = True
        Me.radprincipals.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.radprincipals.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radprincipals.Location = New System.Drawing.Point(712, 23)
        Me.radprincipals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radprincipals.Name = "radprincipals"
        Me.radprincipals.Size = New System.Drawing.Size(117, 29)
        Me.radprincipals.TabIndex = 0
        Me.radprincipals.TabStop = True
        Me.radprincipals.Text = "Principals"
        Me.radprincipals.UseVisualStyleBackColor = False
        '
        'radepisode
        '
        Me.radepisode.AutoSize = True
        Me.radepisode.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.radepisode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radepisode.Location = New System.Drawing.Point(536, 23)
        Me.radepisode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radepisode.Name = "radepisode"
        Me.radepisode.Size = New System.Drawing.Size(114, 29)
        Me.radepisode.TabIndex = 0
        Me.radepisode.TabStop = True
        Me.radepisode.Text = "Episodes"
        Me.radepisode.UseVisualStyleBackColor = False
        '
        'radcrew
        '
        Me.radcrew.AutoSize = True
        Me.radcrew.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.radcrew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radcrew.Location = New System.Drawing.Point(360, 23)
        Me.radcrew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radcrew.Name = "radcrew"
        Me.radcrew.Size = New System.Drawing.Size(79, 29)
        Me.radcrew.TabIndex = 0
        Me.radcrew.TabStop = True
        Me.radcrew.Text = "Crew"
        Me.radcrew.UseVisualStyleBackColor = False
        '
        'radbasic
        '
        Me.radbasic.AutoSize = True
        Me.radbasic.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.radbasic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbasic.Location = New System.Drawing.Point(184, 23)
        Me.radbasic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radbasic.Name = "radbasic"
        Me.radbasic.Size = New System.Drawing.Size(81, 29)
        Me.radbasic.TabIndex = 0
        Me.radbasic.TabStop = True
        Me.radbasic.Text = "Basic"
        Me.radbasic.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 90)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(899, 150)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose variable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by Name : "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(268, 91)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 37)
        Me.TextBox1.TabIndex = 1
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton10.Location = New System.Drawing.Point(712, 42)
        Me.RadioButton10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(150, 29)
        Me.RadioButton10.TabIndex = 0
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "RadioButton1"
        Me.RadioButton10.UseVisualStyleBackColor = False
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton9.Location = New System.Drawing.Point(536, 42)
        Me.RadioButton9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(150, 29)
        Me.RadioButton9.TabIndex = 0
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "RadioButton1"
        Me.RadioButton9.UseVisualStyleBackColor = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(8, 42)
        Me.RadioButton6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(150, 29)
        Me.RadioButton6.TabIndex = 0
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "RadioButton1"
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.Location = New System.Drawing.Point(360, 42)
        Me.RadioButton8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(150, 29)
        Me.RadioButton8.TabIndex = 0
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "RadioButton1"
        Me.RadioButton8.UseVisualStyleBackColor = False
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(184, 42)
        Me.RadioButton7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(150, 29)
        Me.RadioButton7.TabIndex = 0
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "RadioButton1"
        Me.RadioButton7.UseVisualStyleBackColor = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-31, -57)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 62)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(77, 308)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(707, 245)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Search_Function
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 554)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Search_Function"
        Me.Text = "Search_Function"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radakas As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radprincipals As RadioButton
    Friend WithEvents radepisode As RadioButton
    Friend WithEvents radcrew As RadioButton
    Friend WithEvents radbasic As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents radactor As RadioButton
    Friend WithEvents radratings As RadioButton
End Class
