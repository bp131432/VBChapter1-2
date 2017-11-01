Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        MessageBox.Show("deux")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        MessageBox.Show("trois")
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        MessageBox.Show("quatre")
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        MessageBox.Show("cinq")
    End Sub

    Private Sub btnOne_Click_1(sender As Object, e As EventArgs) Handles btnOne.Click
        MessageBox.Show("un")
    End Sub
End Class
