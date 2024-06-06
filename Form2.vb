Imports System.Data.OleDb
Imports System.Data
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CNN = New OleDbConnection(koneksi)
        If CNN.State <> ConnectionState.Closed Then CNN.Close()
        CNN.Open()
        OLECMD = New OleDbCommand("Select * From login where username='" & Txtuser.Text &
            "' and password='" & Txtpasword.Text & "'", CNN)
        OLERDR = OLECMD.ExecuteReader
        If (OLERDR.Read()) Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Username dan Password Tidak Ditemukan, Silahkan Coba Lagi", MsgBoxStyle.OkOnly, "Login Gagal Total")
            Txtuser.Text = ""
            Txtpasword.Text = ""
            Txtuser.Focus()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class