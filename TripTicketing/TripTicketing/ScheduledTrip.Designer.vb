<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduledTrip
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
        MonthYearContainer = New Panel()
        DaysOfWeekContainer = New Panel()
        DaysRow1Container = New Panel()
        DaysRow0Container = New Panel()
        DaysRow3Container = New Panel()
        DaysRow2Container = New Panel()
        DaysRow5Container = New Panel()
        DaysRow4Container = New Panel()
        SuspendLayout()
        ' 
        ' MonthYearContainer
        ' 
        MonthYearContainer.BackColor = Color.LightGoldenrodYellow
        MonthYearContainer.BackgroundImageLayout = ImageLayout.None
        MonthYearContainer.BorderStyle = BorderStyle.FixedSingle
        MonthYearContainer.Font = New Font("Segoe UI", 12F)
        MonthYearContainer.Location = New Point(12, 12)
        MonthYearContainer.Name = "MonthYearContainer"
        MonthYearContainer.Size = New Size(1270, 68)
        MonthYearContainer.TabIndex = 173
        ' 
        ' DaysOfWeekContainer
        ' 
        DaysOfWeekContainer.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DaysOfWeekContainer.BorderStyle = BorderStyle.FixedSingle
        DaysOfWeekContainer.Font = New Font("Segoe UI", 12F)
        DaysOfWeekContainer.Location = New Point(12, 97)
        DaysOfWeekContainer.Name = "DaysOfWeekContainer"
        DaysOfWeekContainer.Size = New Size(1270, 54)
        DaysOfWeekContainer.TabIndex = 174
        ' 
        ' DaysRow1Container
        ' 
        DaysRow1Container.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DaysRow1Container.BorderStyle = BorderStyle.FixedSingle
        DaysRow1Container.Font = New Font("Segoe UI", 12F)
        DaysRow1Container.Location = New Point(12, 247)
        DaysRow1Container.Name = "DaysRow1Container"
        DaysRow1Container.Size = New Size(1270, 68)
        DaysRow1Container.TabIndex = 176
        ' 
        ' DaysRow0Container
        ' 
        DaysRow0Container.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DaysRow0Container.BorderStyle = BorderStyle.FixedSingle
        DaysRow0Container.Font = New Font("Segoe UI", 12F)
        DaysRow0Container.Location = New Point(12, 157)
        DaysRow0Container.Name = "DaysRow0Container"
        DaysRow0Container.Size = New Size(1270, 70)
        DaysRow0Container.TabIndex = 175
        ' 
        ' DaysRow3Container
        ' 
        DaysRow3Container.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DaysRow3Container.BorderStyle = BorderStyle.FixedSingle
        DaysRow3Container.Font = New Font("Segoe UI", 12F)
        DaysRow3Container.Location = New Point(12, 419)
        DaysRow3Container.Name = "DaysRow3Container"
        DaysRow3Container.Size = New Size(1270, 59)
        DaysRow3Container.TabIndex = 178
        ' 
        ' DaysRow2Container
        ' 
        DaysRow2Container.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        DaysRow2Container.BorderStyle = BorderStyle.FixedSingle
        DaysRow2Container.Font = New Font("Segoe UI", 12F)
        DaysRow2Container.Location = New Point(12, 333)
        DaysRow2Container.Name = "DaysRow2Container"
        DaysRow2Container.Size = New Size(1270, 69)
        DaysRow2Container.TabIndex = 177
        ' 
        ' DaysRow5Container
        ' 
        DaysRow5Container.BackColor = Color.Thistle
        DaysRow5Container.BorderStyle = BorderStyle.FixedSingle
        DaysRow5Container.Font = New Font("Segoe UI", 12F)
        DaysRow5Container.Location = New Point(12, 577)
        DaysRow5Container.Name = "DaysRow5Container"
        DaysRow5Container.Size = New Size(1270, 66)
        DaysRow5Container.TabIndex = 180
        ' 
        ' DaysRow4Container
        ' 
        DaysRow4Container.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DaysRow4Container.BorderStyle = BorderStyle.FixedSingle
        DaysRow4Container.Font = New Font("Segoe UI", 12F)
        DaysRow4Container.Location = New Point(12, 493)
        DaysRow4Container.Name = "DaysRow4Container"
        DaysRow4Container.Size = New Size(1270, 59)
        DaysRow4Container.TabIndex = 179
        ' 
        ' ScheduledTrip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1297, 701)
        Controls.Add(DaysRow5Container)
        Controls.Add(DaysRow4Container)
        Controls.Add(DaysRow3Container)
        Controls.Add(DaysRow2Container)
        Controls.Add(DaysRow1Container)
        Controls.Add(DaysRow0Container)
        Controls.Add(DaysOfWeekContainer)
        Controls.Add(MonthYearContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "ScheduledTrip"
        SizeGripStyle = SizeGripStyle.Show
        ResumeLayout(False)
    End Sub
    Friend WithEvents MonthYearContainer As Panel
    Friend WithEvents DaysOfWeekContainer As Panel
    Friend WithEvents DaysRow1Container As Panel
    Friend WithEvents DaysRow0Container As Panel
    Friend WithEvents DaysRow3Container As Panel
    Friend WithEvents DaysRow2Container As Panel
    Friend WithEvents DaysRow5Container As Panel
    Friend WithEvents DaysRow4Container As Panel
End Class
