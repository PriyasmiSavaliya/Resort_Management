Public Class UC_Aboutus
    Private Sub UC_Aboutus_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btndetail_Click(sender As Object, e As EventArgs) Handles btndetail.Click
        MsgBox("More room Details")
        Room_Detail.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("More dinning Details")
        dinning.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("More resort experiences Details")
        Experiances.Show()
        Me.Hide()
    End Sub
End Class
