Public Class Form1
    Private Sub CheckBoxX7_CheckedChanged(sender As Object, e As EventArgs) Handles security.CheckedChanged
        If security.Checked = True Then
            SerialPort1.Write("70")
        Else
            SerialPort1.Write("71")
        End If
    End Sub

    Private Sub cpanel_CheckedChanged(sender As Object, e As EventArgs) Handles cpanel.CheckedChanged
        If cpanel.Checked = True Then
            SerialPort1.Write("50")
        Else
            SerialPort1.Write("51")
        End If
    End Sub

    Private Sub RadialMenu1_ItemClick(sender As Object, e As EventArgs) Handles RadialMenu1.ItemClick
        If restart.IsMouseOver Then
            Application.Restart()
        End If
        If about.IsMouseOver Then
            about_contacts.Show()
        End If
        If contacts.IsMouseOver Then
            about_contacts.Show()
        End If
        If exit_btn.IsMouseOver Then
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comport As String
        comport = start.ComboBox1.SelectedItem
        SerialPort1.PortName = comport
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub room1_CheckedChanged(sender As Object, e As EventArgs) Handles room1.CheckedChanged
        If room1.Checked = True Then

            SerialPort1.Write("10")

        Else

            SerialPort1.Write("11")

        End If
    End Sub

    Private Sub room2_CheckedChanged(sender As Object, e As EventArgs) Handles room2.CheckedChanged
        If room2.Checked = True Then

            SerialPort1.Write("20")

        Else

            SerialPort1.Write("21")

        End If
    End Sub

    Private Sub room3_CheckedChanged(sender As Object, e As EventArgs) Handles room3.CheckedChanged
        If room3.Checked = True Then

            SerialPort1.Write("30")

        Else

            SerialPort1.Write("31")

        End If
    End Sub

    Private Sub room4_CheckedChanged(sender As Object, e As EventArgs) Handles room4.CheckedChanged
        If room4.Checked = True Then

            SerialPort1.Write("40")

        Else

            SerialPort1.Write("41")

        End If
    End Sub

    Private Sub CheckBoxX6_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If room1.Checked = True Then
            glow1.Visible = True
        Else
            glow1.Visible = False
        End If

        If room2.Checked = True Then
            glow2.Visible = True
        Else
            glow2.Visible = False
        End If

        If room3.Checked = True Then
            glow3.Visible = True
        Else
            glow3.Visible = False
        End If

        If room4.Checked = True Then
            glow4.Visible = True
        Else
            glow4.Visible = False
        End If

        If cpanel.Checked = True Then
            glow_cp.Visible = True
        Else
            glow_cp.Visible = False
        End If
        If security.Checked = True Then
            status.Text = "Safe"
            status.ForeColor = Color.Green
            GroupBox4.Text = "Status"
        Else
            GroupBox4.Text = "Status (Please Enable Leser Protection)"
            status.Text = "Not Safe"
            status.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.Text &= ReceiveSerialData()
        If RichTextBox1.Text.Contains("ALART") Then
            status.Text = "Warning!"
            status.ForeColor = Color.Red
            alart.Show()
            Timer2.Enabled = False
        End If
    End Sub

    Function ReceiveSerialData() As String
        Dim incoming As String
        Try
            incoming = SerialPort1.ReadExisting()

            If incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return incoming
            End If
        Catch ex As TimeoutException
            Return "ERROR: TIME OUT"
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBoxX1_CheckedChanged(sender As Object, e As EventArgs)
    End Sub
End Class
