Public Class Form1
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub IconButton1_Click(ByVal sender As System.Object, e As System.EventArgs) Handles IconButton1.Click
        switchPanel(RequestforVehicle)

    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub IconButton2_Click(ByVal sender As System.Object, e As System.EventArgs) Handles IconButton2.Click
        switchPanel(ScheduledTrip)
    End Sub

    Private Sub IconButton3_Click(ByVal sender As System.Object, e As System.EventArgs) Handles IconButton3.Click
        switchPanel(CancelledTrip)
    End Sub

    Private Sub IconButton4_Click(ByVal sender As System.Object, e As System.EventArgs) Handles IconButton4.Click
        switchPanel(Tripticket)
    End Sub

    Private Sub IconButton5_Click(ByVal sender As System.Object, e As System.EventArgs) Handles IconButton5.Click
        switchPanel(Dispatch)
    End Sub

    Private Sub IconButton6_Click(ByVal sender As System.Object, e As System.EventArgs) Handles IconButton6.Click
        switchPanel(MonthyConsumption)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint_2(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pnl_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint_3(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
