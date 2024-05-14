<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelledTrip
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
        Label1 = New Label()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        IconButton9 = New FontAwesome.Sharp.IconButton()
        IconButton8 = New FontAwesome.Sharp.IconButton()
        IconButton7 = New FontAwesome.Sharp.IconButton()
        DateTimePicker1 = New DateTimePicker()
        Label8 = New Label()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label9 = New Label()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(611, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 40)
        Label1.TabIndex = 49
        Label1.Text = "LIST OF TRIPS"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9})
        ListView1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.GridLines = True
        ListView1.Location = New Point(522, 71)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(926, 420)
        ListView1.TabIndex = 131
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Date of Request"
        ColumnHeader1.Width = 125
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Date of Travel"
        ColumnHeader2.Width = 125
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Place of Travel"
        ColumnHeader3.Width = 125
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Time"
        ColumnHeader4.Width = 80
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Office"
        ColumnHeader5.Width = 80
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Purpose"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Plate Number"
        ColumnHeader7.Width = 125
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Driver"
        ColumnHeader8.Width = 80
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Dispatcher"
        ColumnHeader9.Width = 100
        ' 
        ' IconButton9
        ' 
        IconButton9.BackColor = Color.Silver
        IconButton9.FlatStyle = FlatStyle.Flat
        IconButton9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        IconButton9.IconChar = FontAwesome.Sharp.IconChar.Save
        IconButton9.IconColor = Color.Black
        IconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton9.IconSize = 30
        IconButton9.ImageAlign = ContentAlignment.MiddleLeft
        IconButton9.Location = New Point(1252, 602)
        IconButton9.Name = "IconButton9"
        IconButton9.Size = New Size(100, 50)
        IconButton9.TabIndex = 139
        IconButton9.Text = "Save"
        IconButton9.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton9.UseVisualStyleBackColor = False
        ' 
        ' IconButton8
        ' 
        IconButton8.BackColor = Color.Silver
        IconButton8.FlatStyle = FlatStyle.Flat
        IconButton8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        IconButton8.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton8.IconColor = Color.Black
        IconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton8.IconSize = 30
        IconButton8.Location = New Point(1123, 602)
        IconButton8.Name = "IconButton8"
        IconButton8.Size = New Size(100, 50)
        IconButton8.TabIndex = 138
        IconButton8.Text = "Save As"
        IconButton8.UseVisualStyleBackColor = False
        ' 
        ' IconButton7
        ' 
        IconButton7.BackColor = Color.Silver
        IconButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        IconButton7.FlatStyle = FlatStyle.Flat
        IconButton7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        IconButton7.IconChar = FontAwesome.Sharp.IconChar.Print
        IconButton7.IconColor = Color.Black
        IconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton7.IconSize = 30
        IconButton7.ImageAlign = ContentAlignment.MiddleLeft
        IconButton7.Location = New Point(993, 602)
        IconButton7.Name = "IconButton7"
        IconButton7.Size = New Size(100, 50)
        IconButton7.TabIndex = 137
        IconButton7.Text = "Print"
        IconButton7.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton7.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 12F)
        DateTimePicker1.Location = New Point(173, 131)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(245, 26)
        DateTimePicker1.TabIndex = 153
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F)
        Label8.Location = New Point(32, 392)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 20)
        Label8.TabIndex = 152
        Label8.Text = "Driver:"
        ' 
        ' TextBox8
        ' 
        TextBox8.BorderStyle = BorderStyle.FixedSingle
        TextBox8.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox8.Location = New Point(173, 390)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(245, 26)
        TextBox8.TabIndex = 151
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox7.Location = New Point(173, 342)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(245, 26)
        TextBox7.TabIndex = 150
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F)
        Label7.Location = New Point(32, 342)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 20)
        Label7.TabIndex = 149
        Label7.Text = "Purpose:"
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox6.Location = New Point(173, 288)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(245, 26)
        TextBox6.TabIndex = 148
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox4.Location = New Point(173, 244)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(245, 26)
        TextBox4.TabIndex = 147
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox3.Location = New Point(173, 188)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(245, 26)
        TextBox3.TabIndex = 146
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox1.Location = New Point(173, 71)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(245, 26)
        TextBox1.TabIndex = 145
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F)
        Label5.Location = New Point(33, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 144
        Label5.Text = "Office:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.Location = New Point(32, 250)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 20)
        Label4.TabIndex = 143
        Label4.Text = "Time:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.Location = New Point(32, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 20)
        Label3.TabIndex = 142
        Label3.Text = "Place of Travel:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.Location = New Point(33, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 141
        Label2.Text = "Date of Travel:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F)
        Label6.Location = New Point(32, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 20)
        Label6.TabIndex = 140
        Label6.Text = "Date of Request:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F)
        Label9.Location = New Point(32, 442)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 20)
        Label9.TabIndex = 155
        Label9.Text = "Dispatcher:"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Microsoft Sans Serif", 12F)
        TextBox2.Location = New Point(173, 436)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(245, 26)
        TextBox2.TabIndex = 154
        ' 
        ' CancelledTrip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1523, 664)
        Controls.Add(Label9)
        Controls.Add(TextBox2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label8)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(Label7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(IconButton9)
        Controls.Add(IconButton8)
        Controls.Add(IconButton7)
        Controls.Add(ListView1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CancelledTrip"
        Text = "CancelledTrip"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents IconButton9 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
