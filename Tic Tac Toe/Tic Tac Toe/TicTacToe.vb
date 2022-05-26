Public Class TicTacToe
    Dim turn As Boolean = True


    Private Sub btn1to9(sender As Object, e As EventArgs) Handles BottomLeftBtn.Click, MiddleBottomBtn.Click, BottomRightBtn.Click, MiddleRightBtn.Click, MiddleCenterBtn.Click, MiddleLeftBtn.Click, TopRightBtn.Click, MiddleTopBtn.Click, TopLeftBtn.Click
        Dim x As Button = CType(sender, Button)

        If turn Then

            x.Image = System.Drawing.Image.FromFile("x.png")
            x.BackColor = System.Drawing.Color.White
            turn = False






        Else
            x.BackColor = System.Drawing.Color.White
            x.Image = System.Drawing.Image.FromFile("o.png")
            turn = True

        End If
    End Sub
End Class
