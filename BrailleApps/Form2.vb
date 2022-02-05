Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BrailleApps.TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        My.Computer.Audio.Play(My.Resources.File.Windows_Navigation_Start, AudioPlayMode.Background)
    End Sub


End Class