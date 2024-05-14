<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton6 = New FontAwesome.Sharp.IconButton()
        IconButton5 = New FontAwesome.Sharp.IconButton()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.White
        IconButton2.FlatAppearance.BorderColor = Color.Black
        IconButton2.FlatAppearance.MouseDownBackColor = Color.White
        IconButton2.FlatAppearance.MouseOverBackColor = Color.Gray
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 30
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(21, 230)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(171, 70)
        IconButton2.TabIndex = 1
        IconButton2.Text = "Scheduled Trip"
        IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton3
        ' 
        IconButton3.BackColor = Color.White
        IconButton3.FlatAppearance.BorderColor = Color.Black
        IconButton3.FlatAppearance.MouseDownBackColor = Color.White
        IconButton3.FlatAppearance.MouseOverBackColor = Color.Gray
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.Cancel
        IconButton3.IconColor = Color.Black
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.IconSize = 30
        IconButton3.ImageAlign = ContentAlignment.MiddleLeft
        IconButton3.Location = New Point(21, 324)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(171, 70)
        IconButton3.TabIndex = 2
        IconButton3.Text = "Cancelled Trip"
        IconButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton3.UseVisualStyleBackColor = False
        ' 
        ' IconButton6
        ' 
        IconButton6.BackColor = Color.White
        IconButton6.FlatAppearance.BorderColor = Color.Black
        IconButton6.FlatAppearance.MouseDownBackColor = Color.White
        IconButton6.FlatAppearance.MouseOverBackColor = Color.Gray
        IconButton6.FlatStyle = FlatStyle.Flat
        IconButton6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        IconButton6.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek
        IconButton6.IconColor = Color.Black
        IconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton6.IconSize = 30
        IconButton6.ImageAlign = ContentAlignment.MiddleLeft
        IconButton6.Location = New Point(21, 606)
        IconButton6.Name = "IconButton6"
        IconButton6.Size = New Size(171, 70)
        IconButton6.TabIndex = 5
        IconButton6.Text = "Monthly Consumption Report"
        IconButton6.TextAlign = ContentAlignment.MiddleLeft
        IconButton6.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton6.UseVisualStyleBackColor = False
        ' 
        ' IconButton5
        ' 
        IconButton5.BackColor = Color.White
        IconButton5.FlatAppearance.BorderColor = Color.Black
        IconButton5.FlatAppearance.MouseDownBackColor = Color.White
        IconButton5.FlatAppearance.MouseOverBackColor = Color.Gray
        IconButton5.FlatStyle = FlatStyle.Flat
        IconButton5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        IconButton5.IconChar = FontAwesome.Sharp.IconChar.Bus
        IconButton5.IconColor = Color.Black
        IconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton5.IconSize = 30
        IconButton5.ImageAlign = ContentAlignment.MiddleLeft
        IconButton5.Location = New Point(21, 512)
        IconButton5.Name = "IconButton5"
        IconButton5.Size = New Size(171, 70)
        IconButton5.TabIndex = 4
        IconButton5.Text = "Dispatch"
        IconButton5.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton5.UseVisualStyleBackColor = False
        ' 
        ' IconButton4
        ' 
        IconButton4.BackColor = Color.White
        IconButton4.FlatAppearance.BorderColor = Color.Black
        IconButton4.FlatAppearance.MouseDownBackColor = Color.White
        IconButton4.FlatAppearance.MouseOverBackColor = Color.Gray
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.Ticket
        IconButton4.IconColor = Color.Black
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.IconSize = 30
        IconButton4.ImageAlign = ContentAlignment.MiddleLeft
        IconButton4.Location = New Point(21, 418)
        IconButton4.Name = "IconButton4"
        IconButton4.Size = New Size(171, 70)
        IconButton4.TabIndex = 3
        IconButton4.Text = "Trip Ticket"
        IconButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.White
        IconButton1.FlatAppearance.BorderColor = Color.Black
        IconButton1.FlatAppearance.MouseDownBackColor = Color.White
        IconButton1.FlatAppearance.MouseOverBackColor = Color.Gray
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.File
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 30
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(21, 135)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(171, 70)
        IconButton1.TabIndex = 0
        IconButton1.Text = "Request for Vehicle"
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Lime
        Label2.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(444, 434)
        Label2.Name = "Label2"
        Label2.Size = New Size(872, 37)
        Label2.TabIndex = 1
        Label2.Text = "ISABELA STATE UNIVERSITY CAUAYAN CITY CAMPUS"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(538, 366)
        Label1.Name = "Label1"
        Label1.Size = New Size(624, 55)
        Label1.TabIndex = 0
        Label1.Text = "TRIP TICKETING SYSTEM"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(PictureBox2)
        Panel2.Dock = DockStyle.Top
        Panel2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Panel2.Location = New Point(200, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1618, 100)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.LOGO_new_2
        PictureBox2.Location = New Point(-2, 1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(800, 97)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(206, 106)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1612, 690)
        Panel1.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__1_
        PictureBox1.Location = New Point(679, 124)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(274, 287)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 808)
        Panel3.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1818, 808)
        Controls.Add(Panel1)
        Controls.Add(IconButton1)
        Controls.Add(IconButton6)
        Controls.Add(Panel2)
        Controls.Add(IconButton4)
        Controls.Add(IconButton5)
        Controls.Add(IconButton2)
        Controls.Add(IconButton3)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
