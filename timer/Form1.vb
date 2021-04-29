Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If d.Text > 0 Then
            d.Text = d.Text - 1
        Else
            d.Text = 59
            m.Text = m.Text - 1
        End If
        If m.Text < 0 Then
            m.Text = 59
            j.Text = j.Text - 1
        End If
        If j.Text < 0 Then
            Dim sp As System.Media.SoundPlayer = New System.Media.SoundPlayer(My.Resources.BGM0001)
            sp.Play()
            Timer1.Stop()
            d.Text = 0
            m.Text = 0
            j.Text = 0
            STAPH.TopMost = True
            STAPH.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        d.Text = 0
        m.Text = 0
        j.Text = 0
    End Sub
End Class
