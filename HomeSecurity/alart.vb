Public Class alart

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.ForeColor = Color.Red
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.Orange
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.White
    End Sub

    Private Sub alart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("alart_sound.wav")
    End Sub
End Class