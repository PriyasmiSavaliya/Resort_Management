Imports System.Data.OleDb
Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String
        Dim password As String
        username = txtusername.Text
        password = txtPassword.Text
        If (username.Equals("piyu") And password.Equals("pass")) Then
            LabelError.Visible = True
            txtPassword.Clear()
            MsgBox("Login sucessfull")
        Else
            MsgBox("login")
        End If
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
