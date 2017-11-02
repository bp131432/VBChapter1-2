Public Class Form1

    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        MessageBox.Show("Middle Left Alignment")
    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        MessageBox.Show("Middle Right Alignment")
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        MessageBox.Show("Middle Center Alignment")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
