Public Class homepage
    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click

        Dim Jumptictactoe As New TicTacToe

        Jumptictactoe.p1name = Player1name.Text
        Jumptictactoe.p2name = Player2name.Text
        Jumptictactoe.Show()
        Me.Hide()

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Player1name.Text.Length >= 3 And Player2name.Text.Length >= 3 Then

            PlayBtn.Enabled = True

        Else
            PlayBtn.Enabled = False

        End If
    End Sub
End Class