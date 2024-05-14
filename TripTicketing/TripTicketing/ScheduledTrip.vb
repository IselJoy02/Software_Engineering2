Public Class ScheduledTrip

    Private _CalendarInfo As MonthLyCalendarInfo
    Private Sub ScheduledTrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SizeContainers()
        CreateMonthYear()
        SizeMonthYear()
        CreateDaysOfWeek()
        SizeDaysOfWeek()
        CreateDays()
        Sizedays()
        _CalendarInfo = New MonthLyCalendarInfo(2024, 5)
        PopulateCalendar()
        CreateTestData()

    End Sub




    Private Sub ScheduledTrip_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        SizeContainers()
        SizeMonthYear()
        SizeDaysOfWeek()
    End Sub

    Private Sub CreateDaysOfWeek()
        Dim lbl As Label
        Dim days As String() = New String(6) {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}

        For i = 0 To 6
            lbl = New Label
            lbl.Name = String.Format("Lbl(0)", days(i))
            lbl.Text = days(i)
            lbl.AutoSize = False
            lbl.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lbl.TextAlign = ContentAlignment.MiddleCenter
            DaysOfWeekContainer.Controls.Add(lbl)
        Next
    End Sub

    Private Sub CreateMonthYear()
        Dim lbl As Label = New Label()

        lbl.Name = "LblMonthYear"
        lbl.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        lbl.AutoSize = True
        lbl.Text = "MONTH YEAR"


        MonthYearContainer.Controls.Add(lbl)

    End Sub
    Private Sub SizeMonthYear()
        Dim x As Integer
        Dim y As Integer
        Dim lbl As Label

        If MonthYearContainer.Controls.Count > 0 Then

            lbl = MonthYearContainer.Controls.Find("LblMonthYear", False).First
            x = (MonthYearContainer.Width - lbl.Width) / 2
            y = (MonthYearContainer.Height - lbl.Height) / 2
            lbl.Location = New Point(x, y)
        End If
    End Sub



    Private Sub SizeContainers()
        Dim daysHeight As Integer
        Dim daysYStart As Integer

        MonthYearContainer.Size = New Size(ClientSize.Width, 50)
        MonthYearContainer.Location = New Point(0, 0)
        DaysOfWeekContainer.Size = New Size(ClientSize.Width, 50)
        DaysOfWeekContainer.Location = New Point(0, MonthYearContainer.Height)

        daysHeight = (ClientSize.Height - MonthYearContainer.Height - DaysOfWeekContainer.Height) / 6
        daysYStart = MonthYearContainer.Height + DaysOfWeekContainer.Height

        DaysRow0Container.Size = New Size(ClientSize.Width, daysHeight)
        DaysRow0Container.Location = New Point(0, daysYStart)
        DaysRow1Container.Size = New Size(ClientSize.Width, daysHeight)
        DaysRow1Container.Location = New Point(0, daysYStart + (daysHeight))
        DaysRow2Container.Size = New Size(ClientSize.Width, daysHeight)
        DaysRow2Container.Location = New Point(0, daysYStart + (daysHeight * 2))
        DaysRow3Container.Size = New Size(ClientSize.Width, daysHeight)
        DaysRow3Container.Location = New Point(0, daysYStart + (daysHeight * 3))
        DaysRow4Container.Size = New Size(ClientSize.Width, daysHeight)
        DaysRow4Container.Location = New Point(0, daysYStart + (daysHeight * 4))
        DaysRow5Container.Size = New Size(ClientSize.Width, daysHeight)
        DaysRow5Container.Location = New Point(0, daysYStart + (daysHeight * 5))
    End Sub
    Private Sub SizeDaysOfWeek()

        SizeWidthEqually(DaysOfWeekContainer)

    End Sub
    Private Sub SizeWidthEqually(ByVal c As Control)
        Dim width As Integer
        Dim x As Integer

        If c.Controls.Count = 0 Then
            Return

        End If
        width = c.Width / c.Controls.Count

        For Each ctrl As Control In c.Controls


            ctrl.Height = c.Height
            ctrl.Width = width
            ctrl.Location = New Point(x, 0)
            x += width
        Next

    End Sub



    Private Sub CreateDays()

        Dim dayPanel As Panel
        Dim dayOfMonthlbl As Label

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                dayPanel = New Panel
                dayPanel.Name = String.Format("PlnDay{0}{1}", rowIndex, colIndex)
                dayOfMonthlbl = New Label
                dayOfMonthlbl.Name = String.Format("LblDayofMonth{0}{1}", rowIndex, colIndex)
                dayOfMonthlbl.Text = dayOfMonthlbl.Name
                dayPanel.Controls.Add(dayOfMonthlbl)

                Select Case rowIndex
                    Case 0
                        DaysRow0Container.Controls.Add(dayPanel)
                    Case 1
                        DaysRow1Container.Controls.Add(dayPanel)
                    Case 2
                        DaysRow2Container.Controls.Add(dayPanel)
                    Case 3
                        DaysRow3Container.Controls.Add(dayPanel)
                    Case 4
                        DaysRow4Container.Controls.Add(dayPanel)
                    Case 5
                        DaysRow5Container.Controls.Add(dayPanel)

                End Select
            Next
        Next
    End Sub

    Private Sub Sizedays()
        SizeWidthEqually(DaysRow0Container)
        SizeWidthEqually(DaysRow1Container)
        SizeWidthEqually(DaysRow2Container)
        SizeWidthEqually(DaysRow3Container)
        SizeWidthEqually(DaysRow4Container)
        SizeWidthEqually(DaysRow5Container)
    End Sub

    Private Sub PopulateCalendar()
        Dim lbl As Control
        Dim lblName As String

        lbl = MonthYearContainer.Controls.Find("LblMonthYear", False).First
        lbl.Text = String.Format("{0}{1}", MonthName(_CalendarInfo.Month), _CalendarInfo.Year)

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                lblName = String.Format("LblDayOfMonth{0}{1}", rowIndex, colIndex)
                lbl = Me.Controls.Find(lblName, True).First
                lbl.Text = _CalendarInfo.DayInMonth(rowIndex, colIndex)

                If _CalendarInfo.IsActiveMonth(rowIndex, colIndex) Then
                    lbl.ForeColor = Color.Black
                Else
                    lbl.ForeColor = Color.Gray
                End If

                If _CalendarInfo.IsToday(rowIndex, colIndex) Then
                    lbl.ForeColor = Color.LightGreen

                End If

            Next
        Next

    End Sub

    Private Sub CreateTestData()

        Dim dates As New List(Of DateTime)
        Dim info As New List(Of String)
        Dim col As New Integer
        Dim row As New Integer
        Dim pnl As Panel
        Dim lbl As Label
        Dim pnlName As String

        dates.Add(New Date(2024, 5, 20))
        dates.Add(New Date(2024, 5, 15))
        dates.Add(New Date(2024, 5, 25))

        info.Add("Available")
        info.Add("Not Available")
        info.Add("Cancelled")

        For i = 0 To dates.Count - 1
            If _CalendarInfo.DateExists(dates(i)) Then
                col = _CalendarInfo.Col(dates(i))
                row = _CalendarInfo.Row(dates(i))
                pnlName = String.Format("PnlDay{0}{1}", row, col)
                pnl = Controls.Find(pnlName, True).First

                lbl = New Label
                lbl.BackColor = Color.LightGreen
                lbl.Text = info(i)
                lbl.TextAlign = ContentAlignment.MiddleLeft
                lbl.Location = New Point(0, 25)
                pnl.Controls.Add(lbl)

            End If
        Next

    End Sub


    Private Sub MonthYearContainer_Click(sender As Object, e As EventArgs) Handles MonthYearContainer.Click
        Dim pointClicked As Point
        Dim midPointX As Integer
        Dim activeMonth As DateTime
        Dim newMonth As DateTime

        midPointX = MonthYearContainer.Width / 2
        pointClicked = MonthYearContainer.PointToClient(Cursor.Position)
        activeMonth = New Date(_CalendarInfo.Year, _CalendarInfo.Month, 1)

        If pointClicked.X < midPointX Then
            newMonth = activeMonth.AddMonths(-1)
        Else
            newMonth = activeMonth.AddMonths(1)
        End If
        _CalendarInfo.GoToMonth(newMonth.Year, newMonth.Month)

        RemoveTestData(Me)
        PopulateCalendar()
        CreateTestData()

    End Sub
    Private Sub RemoveTestData(c As Control)

        For Each ctrl As Control In c.Controls
            RemoveTestData(ctrl)
        Next

        If c.Name.Contains("LblTest") Then
            c.Parent.Controls.Remove(c)
        End If

    End Sub
End Class


