Imports System.Data.OleDb
Imports System.Runtime.ExceptionServices

Public Class UC_Customerdetails
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Public Sub Display()
        ds.Clear()
        adp = New OleDbDataAdapter("select * from Employeedata", cn)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub UC_Customerdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\BCA\2-year\4-sem\vb.net\Employee.accdb"
        cn.Open()
        Display()
        cn.Close()
    End Sub

    Private Sub Btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Try
            cn.Open()
            cmd = New OleDbCommand("insert into Employeedata values (" & txtRid.Text & ",'" & txtcid.Text & "','" & txtfn.Text & "',
                '" & txtln.Text & "','" & txtdb.Text & "','" & txtcny.Text & "'," & txtmno.Text & ")", cn)
            cmd.ExecuteNonQuery()
            Display()
            MsgBox("Record Inserted")
        Catch ex As Exception
            MsgBox("Fill all field")
        End Try
        cn.Close()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            cn.Open()
            cmd = New OleDbCommand("update Employeedata set Eid=" & txtcid.Text & ",Firstname='" & txtfn.Text & "',Lastname='" & txtln.Text & "'
                ,Dob='" & txtdb.Text & "',Country='" & txtcny.Text & "',phone=" & txtmno.Text & " where Id=" & txtRid.Text & "", cn)
            cmd.ExecuteNonQuery()
            Display()
            MsgBox("Record Updated")
        Catch ex As Exception
            MsgBox("Updeted details")
        End Try
        cn.Close()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            cn.Open()
            cmd = New OleDbCommand("delete from Employeedata where Id=" & txtRid.Text & "", cn)
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
            cmd = New OleDbCommand("select * from Employeedata where Id=" & txtRid.Text & "", cn)
            dr = cmd.ExecuteReader
            While dr.Read
                txtcid.Text = dr.Item(1)
                txtfn.Text = dr.Item(2)
                txtln.Text = dr.Item(3)
                txtdb.Text = dr.Item(4)
                txtcny.Text = dr.Item(5)
                txtmno.Text = dr.Item(6)
            End While
            MsgBox("Record searched")
        Catch ex As Exception
            MsgBox(ex.ToString,, "Record not found")
        End Try
        cn.Close()
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcid.Clear()
        txtRid.Clear()
        txtfn.Clear()
        txtln.Clear()
        txtcny.Clear()
        txtmno.Clear()
        MsgBox(" Record cleared")
    End Sub
End Class
