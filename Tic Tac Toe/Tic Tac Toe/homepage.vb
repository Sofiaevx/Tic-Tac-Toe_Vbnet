Public Class homepage
    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click

        Dim Jumptictactoe As New TicTacToe
        Jumptictactoe.Show()
        Me.Hide()

    End Sub
End Class