Public Class TicTacToe
    Dim turn As Boolean = True
    Dim playeronescore As Short
    Dim playertwoscore As Short
    Public Property p1name As String
    Public Property p2name As String


    Private Sub btn1to9(sender As Object, e As EventArgs) Handles BottomLeftBtn.Click, MiddleBottomBtn.Click, BottomRightBtn.Click, MiddleRightBtn.Click, MiddleCenterBtn.Click, MiddleLeftBtn.Click, TopRightBtn.Click, MiddleTopBtn.Click, TopLeftBtn.Click
        Dim allninebuttons As Button = CType(sender, Button)

        If turn Then
            allninebuttons.Text = "X"
            Playersturnlabel.Text = p2name + "'s Turn"
            turn = False
        Else
            allninebuttons.Text = "O"
            Playersturnlabel.Text = p1name + "'s Turn"
            turn = True
        End If
        allninebuttons.Enabled = False
        checker()
        p1score.Text = Convert.ToString(playeronescore)
        p2score.Text = Convert.ToString(playertwoscore)
    End Sub
    Sub checker()
        '1st Horizontal Result
        If TopLeftBtn.Text.Equals(MiddleTopBtn.Text) And MiddleTopBtn.Text.Equals(TopRightBtn.Text) And TopLeftBtn.Enabled = False Then
            If TopLeftBtn.Text.Equals("X") Then
                MessageBox.Show("Player 1 Wins!!")
                playeronescore += 1
                ResetBtn.PerformClick()

            Else
                MessageBox.Show("Player 2 Wins!!")
                playertwoscore += 1
                ResetBtn.PerformClick()
            End If

            '2nd Horizontal Result
        ElseIf MiddleLeftBtn.Text.Equals(MiddleCenterBtn.Text) And MiddleCenterBtn.Text.Equals(MiddleRightBtn.Text) And MiddleLeftBtn.Enabled = False Then
            If MiddleLeftBtn.Text.Equals("X") Then
                MessageBox.Show("Player 1 Wins!!")
                playeronescore += 1
                ResetBtn.PerformClick()
            Else
                MessageBox.Show("Player 2 Wins!!")
                playertwoscore += 1
                ResetBtn.PerformClick()
            End If

            '3rdHorizontal Result
        ElseIf BottomLeftBtn.Text.Equals(MiddleBottomBtn.Text) And MiddleBottomBtn.Text.Equals(BottomRightBtn.Text) And BottomLeftBtn.Enabled = False Then
            If BottomLeftBtn.Text.Equals("X") Then
                MessageBox.Show("Player 1 Wins!!")
                playeronescore += 1
                ResetBtn.PerformClick()
            Else
                MessageBox.Show("Player 2 Wins!!")
                playertwoscore += 1
                ResetBtn.PerformClick()
            End If


            '1st Vertical Result
        ElseIf TopLeftBtn.Text.Equals(MiddleLeftBtn.Text) And MiddleLeftBtn.Text.Equals(BottomLeftBtn.text) And TopLeftBtn.Enabled = False Then
            If TopLeftBtn.Text.Equals("X") Then
                MessageBox.Show("Player 1 Wins!!")
                playeronescore += 1
                ResetBtn.PerformClick()
            Else
                MessageBox.Show("Player 2 Wins!!")
                playertwoscore += 1
                ResetBtn.PerformClick()
            End If

            '2nd Vertical Result
        ElseIf MiddleTopBtn.Text.Equals(MiddleCenterBtn.Text) And MiddleCenterBtn.Text.Equals(MiddleBottomBtn.text) And MiddleTopBtn.Enabled = False Then
            If MiddleTopBtn.Text.Equals("X") Then
                MessageBox.Show("Player 1 Wins!!")
                playeronescore += 1
                ResetBtn.PerformClick()
            Else
                MessageBox.Show("Player 2 Wins!!")
                playertwoscore += 1
                ResetBtn.PerformClick()
            End If

            '3rd Vertical Result
        ElseIf TopRightBtn.Text.Equals(MiddleRightBtn.Text) And MiddleRightBtn.Text.Equals(BottomRightBtn.text) And TopRightBtn.Enabled = False Then
            If TopRightBtn.Text.Equals("X") Then
                MessageBox.Show("Player 1 Wins!!")
                playeronescore += 1
                ResetBtn.PerformClick()
            Else
                MessageBox.Show("Player 2 Wins!!")
                playertwoscore += 1
                ResetBtn.PerformClick()
            End If

            '1st Diagonal Result
        ElseIf TopLeftBtn.Text.Equals(MiddleCenterBtn.Text) And MiddleCenterBtn.Text.Equals(BottomRightBtn.Text) And TopLeftBtn.Enabled = False Then
            If TopLeftBtn.Text.Equals("X") Then
                MessageBox.Show("Player 1 Wins!!")
                playeronescore += 1
                ResetBtn.PerformClick()
            Else
                MessageBox.Show("Player 2 Wins!!")
                playertwoscore += 1
                ResetBtn.PerformClick()
            End If

            '2nd Diagonal Result
        ElseIf TopRightBtn.Text.Equals(MiddleCenterBtn.Text) And MiddleCenterBtn.Text.Equals(BottomLeftBtn.Text) And TopRightBtn.Enabled = False Then
            If TopRightBtn.Text.Equals("X") Then
                MessageBox.Show("Player 1 Wins!!")
                playeronescore += 1
                ResetBtn.PerformClick()
            Else
                MessageBox.Show("Player 2 Wins!!")
                playertwoscore += 1
                ResetBtn.PerformClick()
            End If

        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        turn = True

        TopLeftBtn.Text = ""
        MiddleLeftBtn.Text = ""
        BottomLeftBtn.Text = ""
        MiddleTopBtn.Text = ""
        MiddleCenterBtn.Text = ""
        MiddleBottomBtn.Text = ""
        TopRightBtn.Text = ""
        MiddleRightBtn.Text = ""
        BottomRightBtn.Text = ""

        TopLeftBtn.Enabled = True
        MiddleLeftBtn.Enabled = True
        BottomLeftBtn.Enabled = True
        MiddleTopBtn.Enabled = True
        MiddleCenterBtn.Enabled = True
        MiddleBottomBtn.Enabled = True
        TopRightBtn.Enabled = True
        MiddleRightBtn.Enabled = True
        BottomRightBtn.Enabled = True
    End Sub

    Private Sub TicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p1score.Text = playeronescore
        p2score.Text = playertwoscore
        Playersturnlabel.Text = p1name + "'s Turn"
        Player1name.Text = p1name
        Player2name.Text = p2name
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim jumphomepage As New homepage
        jumphomepage.Show()
        Me.Hide()
    End Sub


End Class
