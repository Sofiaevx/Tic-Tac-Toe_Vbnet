Public Class TicTacToe
    Dim turn As Boolean = True


    Private Sub btn1to9(sender As Object, e As EventArgs) Handles BottomLeftBtn.Click, MiddleBottomBtn.Click, BottomRightBtn.Click, MiddleRightBtn.Click, MiddleCenterBtn.Click, MiddleLeftBtn.Click, TopRightBtn.Click, MiddleTopBtn.Click, TopLeftBtn.Click
        Dim allninebuttons As Button = CType(sender, Button)

        If turn Then
            allninebuttons.Text = "X"
            turn = False
        Else
            allninebuttons.Text = "O"
            turn = True

        End If
    End Sub
End Class
