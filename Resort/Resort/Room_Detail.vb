Public Class Room_Detail
    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class