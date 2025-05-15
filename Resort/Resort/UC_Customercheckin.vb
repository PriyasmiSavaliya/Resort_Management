Imports System.Data.OleDb
Public Class UC_Customercheckin
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Public Sub Display()
        ds.Clear()
        adp = New OleDbDataAdapter("select * from Customer_Detail", cn)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub UC_Customercheckin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\BCA\2-year\4-sem\vb.net\project\Customer_Details.accdb"
        cn.Open()
        Display()
        cn.Close()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            cn.Open()
            cmd = New OleDbCommand("insert into Customer_Detail values('" & txtn.Text & "'," & txtm.Text & ",'" & txtna.Text & "','" & txtg.Text & "',
            '" & txtd.Text & "','" & txtid.Text & "','" & txta.Text & "','" & txtcin.Text & "','" & txtcout.Text & "'," & txtRn.Text & ")", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Detail inserted")
            Display()
        Catch ex As Exception
            MsgBox("Fill all field")
        End Try
        cn.Close()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            cn.Open()
            cmd = New OleDbCommand("update Customer_Detail set Mobile=" & txtm.Text & ",Nationality='" & txtna.Text & "',Gender='" & txtg.Text & "'
                ,Dob='" & txtd.Text & "',Idproof='" & txtid.Text & "',Address='" & txta.Text & "',Checkin='" & txtcin.Text & "'
                        ,Checkout='" & txtcout.Text & "',Roomid=" & txtRn.Text & " where Cname='" & txtn.Text & "'", cn)
            cmd.ExecuteNonQuery()
            Display()
            MsgBox("Record Updated")
        Catch ex As Exception
            MsgBox("Updated details")
        End Try
        cn.Close()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            cn.Open()
            cmd = New OleDbCommand("delete from Customer_Detail where Cname='" & txtn.Text & "'", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record deleted")
        Catch ex As Exception
            MsgBox("Delete details")
        End Try
        cn.Close()
    End Sub

    Private Sub Btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            cn.Open()
            cmd = New OleDbCommand("select * from Customer_Detail where Cname='" & txtn.Text & "'", cn)
            dr = cmd.ExecuteReader
            While dr.Read
                txtm.Text = dr.Item(1)
                txtna.Text = dr.Item(2)
                txtg.Text = dr.Item(3)
                txtd.Text = dr.Item(4)
                txtid.Text = dr.Item(5)
                txta.Text = dr.Item(6)
                txtcin.Text = dr.Item(7)
                txtcout.Text = dr.Item(8)
                txtRn.Text = dr.Item(9)
            End While
            MsgBox("Record searched")
        Catch ex As Exception
            MsgBox(ex.ToString,, "Record not found")
        End Try
        cn.Close()
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtn.Clear()
        txtm.Clear()
        txtna.Clear()
        txtid.Clear()
        txta.Clear()
        txtRn.Clear()
        MsgBox("REcord cleared")
    End Sub
End Class