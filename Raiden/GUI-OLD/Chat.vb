Public Class Chat
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Int16 = Raiden.My.Settings.pisicionfrmChat.X
        Dim y As Int16 = Raiden.My.Settings.pisicionfrmChat.Y
        Me.Location = New System.Drawing.Point(x, y)


    End Sub

    Private Sub Chat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.pisicionfrmChat = New Point(Me.Location.X, Me.Location.Y)
        My.Settings.Save()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class