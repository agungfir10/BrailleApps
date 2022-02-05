Public Class BrailleApps

    Private Property KeyAscii As Integer

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                Label1.Text = "A"
                My.Computer.Audio.Play(My.Resources.File.A, AudioPlayMode.Background)
            Case Keys.B
                Label1.Text = "B"
                My.Computer.Audio.Play(My.Resources.File.B, AudioPlayMode.Background)
            Case Keys.C
                Label1.Text = "C"
                My.Computer.Audio.Play(My.Resources.File.C, AudioPlayMode.Background)
            Case Keys.D
                Label1.Text = "D"
                My.Computer.Audio.Play(My.Resources.File.D, AudioPlayMode.Background)
            Case Keys.E
                Label1.Text = "E"
                My.Computer.Audio.Play(My.Resources.File.E, AudioPlayMode.Background)
            Case Keys.F
                Label1.Text = "F"
                My.Computer.Audio.Play(My.Resources.File.F, AudioPlayMode.Background)
            Case Keys.G
                Label1.Text = "G"
                My.Computer.Audio.Play(My.Resources.File.G, AudioPlayMode.Background)
            Case Keys.H
                Label1.Text = "H"
                My.Computer.Audio.Play(My.Resources.File.H, AudioPlayMode.Background)
            Case Keys.I
                Label1.Text = "I"
                My.Computer.Audio.Play(My.Resources.File.I, AudioPlayMode.Background)
            Case Keys.J
                Label1.Text = "J"
                My.Computer.Audio.Play(My.Resources.File.J, AudioPlayMode.Background)
            Case Keys.K
                Label1.Text = "K"
                My.Computer.Audio.Play(My.Resources.File.K, AudioPlayMode.Background)
            Case Keys.L
                Label1.Text = "L"
                My.Computer.Audio.Play(My.Resources.File.L, AudioPlayMode.Background)
            Case Keys.M
                Label1.Text = "M"
                My.Computer.Audio.Play(My.Resources.File.N, AudioPlayMode.Background)
            Case Keys.N
                Label1.Text = "N"
                My.Computer.Audio.Play(My.Resources.File.N, AudioPlayMode.Background)
            Case Keys.O
                Label1.Text = "O"
                My.Computer.Audio.Play(My.Resources.File.O, AudioPlayMode.Background)
            Case Keys.P
                Label1.Text = "P"
                My.Computer.Audio.Play(My.Resources.File.P, AudioPlayMode.Background)
            Case Keys.Q
                Label1.Text = "Q"
                My.Computer.Audio.Play(My.Resources.File.Q, AudioPlayMode.Background)
            Case Keys.R
                Label1.Text = "R"
                My.Computer.Audio.Play(My.Resources.File.R, AudioPlayMode.Background)
            Case Keys.S
                Label1.Text = "S"
                My.Computer.Audio.Play(My.Resources.File.S, AudioPlayMode.Background)
            Case Keys.T
                Label1.Text = "T"
                My.Computer.Audio.Play(My.Resources.File.T, AudioPlayMode.Background)
            Case Keys.U
                Label1.Text = "U"
                My.Computer.Audio.Play(My.Resources.File.U, AudioPlayMode.Background)
            Case Keys.V
                Label1.Text = "V"
                My.Computer.Audio.Play(My.Resources.File.V, AudioPlayMode.Background)
            Case Keys.W
                Label1.Text = "W"
                My.Computer.Audio.Play(My.Resources.File.W, AudioPlayMode.Background)
            Case Keys.X
                Label1.Text = "X"
                My.Computer.Audio.Play(My.Resources.File.X, AudioPlayMode.Background)
            Case Keys.Y
                Label1.Text = "Y"
                My.Computer.Audio.Play(My.Resources.File.Y, AudioPlayMode.Background)
            Case Keys.Z
                Label1.Text = "Z"
                My.Computer.Audio.Play(My.Resources.File.Z, AudioPlayMode.Background)
            Case Keys.D0
                Label1.Text = "0"
                My.Computer.Audio.Play(My.Resources.File.angka_0, AudioPlayMode.Background)
            Case Keys.D1
                Label1.Text = "1"
                My.Computer.Audio.Play(My.Resources.File.angka_1, AudioPlayMode.Background)
            Case Keys.D2
                Label1.Text = "2"
                My.Computer.Audio.Play(My.Resources.File.angka_2, AudioPlayMode.Background)
            Case Keys.D3
                Label1.Text = "3"
                My.Computer.Audio.Play(My.Resources.File.angka_3, AudioPlayMode.Background)
            Case Keys.D4
                Label1.Text = "4"
                My.Computer.Audio.Play(My.Resources.File.angka_4, AudioPlayMode.Background)
            Case Keys.D5
                Label1.Text = "5"
                My.Computer.Audio.Play(My.Resources.File.angka_5, AudioPlayMode.Background)
            Case Keys.D6
                Label1.Text = "6"
                My.Computer.Audio.Play(My.Resources.File.angka_6, AudioPlayMode.Background)
            Case Keys.D7
                Label1.Text = "7"
                My.Computer.Audio.Play(My.Resources.File.angka_7, AudioPlayMode.Background)
            Case Keys.D8
                Label1.Text = "8"
                My.Computer.Audio.Play(My.Resources.File.angka_8, AudioPlayMode.Background)
            Case Keys.D9
                Label1.Text = "9"
                My.Computer.Audio.Play(My.Resources.File.angka_9, AudioPlayMode.Background)
            Case Keys.NumPad0
                Label1.Text = "0"
                My.Computer.Audio.Play(My.Resources.File.angka_0, AudioPlayMode.Background)
            Case Keys.NumPad1
                Label1.Text = "1"
                My.Computer.Audio.Play(My.Resources.File.angka_1, AudioPlayMode.Background)
            Case Keys.NumPad2
                Label1.Text = "2"
                My.Computer.Audio.Play(My.Resources.File.angka_2, AudioPlayMode.Background)
            Case Keys.NumPad3
                Label1.Text = "3"
                My.Computer.Audio.Play(My.Resources.File.angka_3, AudioPlayMode.Background)
            Case Keys.NumPad4
                Label1.Text = "4"
                My.Computer.Audio.Play(My.Resources.File.angka_4, AudioPlayMode.Background)
            Case Keys.NumPad5
                Label1.Text = "5"
                My.Computer.Audio.Play(My.Resources.File.angka_5, AudioPlayMode.Background)
            Case Keys.NumPad6
                Label1.Text = "6"
                My.Computer.Audio.Play(My.Resources.File.angka_6, AudioPlayMode.Background)
            Case Keys.NumPad7
                Label1.Text = "7"
                My.Computer.Audio.Play(My.Resources.File.angka_7, AudioPlayMode.Background)
            Case Keys.NumPad8
                Label1.Text = "8"
                My.Computer.Audio.Play(My.Resources.File.angka_8, AudioPlayMode.Background)
            Case Keys.NumPad9
                Label1.Text = "9"
                My.Computer.Audio.Play(My.Resources.File.angka_9, AudioPlayMode.Background)
            Case Keys.Enter
                TextBox1.Text = ""
                Label1.Text = ""
            Case Keys.Space
                If TextBox1.Text = "HEY" Then
                    My.Computer.Audio.Play(My.Resources.File.Hey, AudioPlayMode.Background)
                End If
        End Select
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.Focus()
        Label2.Text = TextBox1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub

    Private Sub BrailleApps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        TextBox1.CharacterCasing = CharacterCasing.Upper
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        My.Computer.Audio.Play(My.Resources.File.Windows_Navigation_Start, AudioPlayMode.Background)
    End Sub
End Class
