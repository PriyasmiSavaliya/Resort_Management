Imports System.Data.OleDb
Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UC_Aboutus1.Visible = False
        UC_Addroom1.Visible = False
        UC_Customercheckin1.Visible = False
        UC_Customerdetails1.Visible = False
        BtnAddroom.PerformClick()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnCustomerDetail_Click(sender As Object, e As EventArgs) Handles btnCustomerDetail.Click
        Movingpanal.Left = btnCustomerDetail.Left + 20
        UC_Customerdetails1.Visible = True
        UC_Customerdetails1.BringToFront()
    End Sub

    Private Sub BtnAddroom_Click(sender As Object, e As EventArgs) Handles BtnAddroom.Click
        Movingpanal.Left = BtnAddroom.Left + 20
        UC_Addroom1.Visible = True
        UC_Addroom1.BringToFront()
    End Sub

    Private Sub BtnCheckin_Click(sender As Object, e As EventArgs) Handles btnCheckin.Click
        Movingpanal.Left = btnCheckin.Left + 20
        UC_Customercheckin1.Visible = True
        UC_Customercheckin1.BringToFront()
    End Sub

    Private Sub BtnBilling_Click(sender As Object, e As EventArgs) Handles btnaboutus.Click
        Movingpanal.Left = btnaboutus.Left + 20
        UC_Aboutus1.Visible = True
        UC_Aboutus1.BringToFront()
    End Sub

    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles Btnlogout.Click
        Movingpanal.Left = Btnlogout.Left + 20
        Application.Exit()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub
End Class