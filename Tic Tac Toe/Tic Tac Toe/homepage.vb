Public Class homepage
    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click

        Dim Jumptictoctoe As New TicTacToe
        Jumptictoctoe.Show()
        Me.Hide()

    End Sub
End Class