Public Class Form1

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If grapes.Checked = True Then
            TextBox2.Text = Val(TextBox1.Text) * 10
            Label3.Text = "the total price is:" + TextBox2.Text
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Val(TextBox1.Text) * 12
            Label3.Text = "the total price is:" + TextBox2.Text
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Text = Val(TextBox1.Text) * 16
            Label3.Text = "the total price is:" + TextBox2.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
