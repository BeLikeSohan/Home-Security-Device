Public Class start

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.SerialPort1.Open()
        Form1.Timer2.Enabled = True
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class