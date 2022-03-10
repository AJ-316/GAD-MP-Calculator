Public Class Form1
    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        inputDisplay.Text = inputDisplay.Text + "0"
    End Sub

    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
        inputDisplay.Text = inputDisplay.Text + "1"
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        inputDisplay.Text = inputDisplay.Text + "2"
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        inputDisplay.Text = inputDisplay.Text + "3"
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        inputDisplay.Text = inputDisplay.Text + "4"
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        inputDisplay.Text = inputDisplay.Text + "5"
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        inputDisplay.Text = inputDisplay.Text + "6"
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        inputDisplay.Text = inputDisplay.Text + "7"
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        inputDisplay.Text = inputDisplay.Text + "8"
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        inputDisplay.Text = inputDisplay.Text + "9"
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        inputDisplay.Text = inputDisplay.Text + "."
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        inputDisplay.Text = inputDisplay.Text.Remove(inputDisplay.Text.Length - 1)

    End Sub
End Class
