Public Class TicTacToe
    Dim turn As Boolean = True


    Private Sub btn1to9(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
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
