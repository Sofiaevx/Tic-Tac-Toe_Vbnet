Public Class TicTacToe
    Dim turn As Boolean = True


    Private Sub btn1to9(sender As Object, e As EventArgs) Handles BottomLeftBtn.Click, MiddleBottomBtn.Click, BottomRightBtn.Click, MiddleRightBtn.Click, MiddleCenterBtn.Click, MiddleLeftBtn.Click, TopRightBtn.Click, MiddleTopBtn.Click, TopLeftBtn.Click
        Dim allninebuttons As Button = CType(sender, Button)

        If turn Then
            allninebuttons.Text = "X"
            Playersturnlabel.Text = "Player 2 Turns"
            turn = False
        Else
            allninebuttons.Text = "O"
            Playersturnlabel.Text = "Player 1 Turns"
            turn = True
        End If
        allninebuttons.Enabled = False
        checker()
    End Sub
    Sub checker()
        If TopLeftBtn.Text.Equals(MiddleTopBtn.Text) And MiddleTopBtn.Text = TopRightBtn.Text And TopLeftBtn.Enabled = False Then
            MessageBox.Show("Winner")

        End If
    End Sub


End Class
