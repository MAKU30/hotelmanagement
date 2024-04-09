Public Class mainPage
    Private Sub mainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        MsgBox("Connected")
        con.Close()
        childform(checkIn)
    End Sub

    Sub childform(ByVal panel As Form)
        pnlChildForm.Controls.Clear()
        panel.TopLevel = False
        pnlChildForm.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        childform(guest)
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        childform(rooms)
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        childform(checkIn)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        childform(checkOut)
    End Sub

    Private Sub btnHotel_Click(sender As Object, e As EventArgs) Handles btnHotel.Click

    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        childform(billing)
    End Sub
End Class