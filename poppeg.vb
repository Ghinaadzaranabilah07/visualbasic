Imports System.Data.OleDb
Imports System.Data
Imports System.Reflection
Public Class poppeg
    Public colnik, colagama, colnama, coltglhr, coltempatlahir, colalamat, colasalsekolah, colnohp, colemail, coljeniskelamin As String

    Private Sub poppeg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call list_data()
        Kounter.Enabled = False

    End Sub

    Private Sub BTNOK_Click(sender As Object, e As EventArgs) Handles BTNOK.Click
        Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ' Call pilih()
    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged
        Call list_data()
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Close()
    End Sub

    Dim cnn As OleDbConnection
    Dim cmmd As OleDbCommand
    Dim dreader As OleDbDataReader
    Private Sub clear_list()
        While Val(Kounter.Text) > 0
            ListView1.Items(0).Remove()
            Kounter.Text = Val(Kounter.Text) - 1
        End While
    End Sub

    Private Sub pilih()
        Try
            colnik = ListView1.SelectedItems(0).SubItems(0).Text.ToString
            colnama = ListView1.SelectedItems(0).SubItems(1).Text.ToString
            colagama = ListView1.SelectedItems(0).SubItems(2).Text.ToString
            coltglhr = ListView1.SelectedItems(0).SubItems(3).Text.ToString
            coltempatlahir = ListView1.SelectedItems(0).SubItems(4).Text.ToString
            colalamat = ListView1.SelectedItems(0).SubItems(5).Text.ToString
            colasalsekolah = ListView1.SelectedItems(0).SubItems(6).Text.ToString
            colnohp = ListView1.SelectedItems(0).SubItems(7).Text.ToString
            colemail = ListView1.SelectedItems(0).SubItems(8).Text.ToString
            coljeniskelamin = ListView1.SelectedItems(0).SubItems(9).Text.ToString
        Catch ex As Exception
            MsgBox("pilih salah satu data", MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub list_data()
        Call clear_list()
        Dim sqlx As String
        Dim x As Integer
        sqlx = "select NIK, NamaLengkap, Agama, TglLhr,TempatLhr, Alamat, AsalSekolah, NoHp, Email, JenisKelamin from pendaftaran where NamaLengkap like '%" &
            Trim(txtnama.Text) & "%' order by NamaLengkap asc"
        cnn = New OleDbConnection(koneksi)
        If cnn.State <> ConnectionState.Closed Then cnn.Close()
        cnn.Open()
        cmmd = New OleDbCommand(sqlx, cnn)
        dreader = cmmd.ExecuteReader
        Try
            While dreader.Read = True
                x = Val(Kounter.Text)
                Kounter.Text = Str(Val(Kounter.Text) + 1) & " Record"

                With ListView1
                    .Items.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(ListView1.Items.Count - 1).SubItems.Add("")
                    .Items(x).SubItems(0).Text = dreader.GetString(0)
                    .Items(x).SubItems(1).Text = dreader.GetString(1)
                    .Items(x).SubItems(2).Text = dreader.GetString(2)
                    .Items(x).SubItems(3).Text = dreader.GetDateTime(3)
                    .Items(x).SubItems(4).Text = dreader.GetString(4)
                    .Items(x).SubItems(5).Text = dreader.GetString(5)
                    .Items(x).SubItems(6).Text = dreader.GetString(6)
                    .Items(x).SubItems(7).Text = dreader.GetString(7)
                    .Items(x).SubItems(8).Text = dreader.GetString(8)
                End With
            End While
        Finally
            dreader.Close()
        End Try
        cnn.Close()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Call pilih()
    End Sub
End Class