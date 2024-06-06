Imports System.Data
Imports System.Data.OleDb
Public Class Form1

    Sub bersih()
        Txtnik.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        DTglhr.Text = ""
        txtTempatLhr.Text = ""
        Cmbagama.Text = ""
        txtAsalSekolah.Text = ""
        txtNoHp.Text = ""
        txtEmail.Text = ""
        RBlklk.Checked = False
        Rbper.Checked = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Bexit.Click
        End
    End Sub
    Private Sub Bsave_Click(sender As Object, e As EventArgs) Handles Bsave.Click
        Dim status As String
        If Txtnik.Text = "" Or txtnama.Text = "" Then
            Exit Sub
        End If
        If RBlklk.Checked = True Then
            status = "Laki-laki"
        Else
            status = "Perempuan"
        End If
        CNN = New OleDbConnection(koneksi)
        If CNN.State <> ConnectionState.Closed Then CNN.Close()
        CNN.Open()
        OLECMD = New OleDbCommand("insert into pendaftaran (NIK, NamaLengkap, Agama, TglLhr,TempatLhr, Alamat, AsalSekolah, NoHp, Email, JenisKelamin )values ('" &
                                  Txtnik.Text & "','" & txtnama.Text & "','" & Cmbagama.Text & "','" & DTglhr.Value &
            "','" & txtTempatLhr.Text & "','" & txtalamat.Text & "','" & txtAsalSekolah.Text & "','" & txtNoHp.Text & "','" & txtEmail.Text & "','" & JenisKelamin.Text & "')", CNN)
        X = OLECMD.ExecuteNonQuery
        If X = 1 Then
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Informasi")
            Call bersih()
            Txtnik.Focus()
        Else
            MsgBox("Gagal Menyimpan Data", MsgBoxStyle.Exclamation, "Ada Kesalahan")
        End If

    End Sub

    Private Sub Bedit_Click(sender As Object, e As EventArgs) Handles Bedit.Click
        Dim status As String
        If Txtnik.Text = "" Or txtnama.Text = "" Then
            Exit Sub
        End If
        If RBlklk.Checked = True Then
            status = "Laki-laki"
        Else
            status = "Perempuan"
        End If
        CNN = New OleDbConnection(koneksi)
        If CNN.State <> ConnectionState.Closed Then CNN.Close()
        CNN.Open()
        OLECMD = New OleDbCommand("Update  pendaftaran set Namalengkap='" & txtnama.Text &
                                  "',Agama='" & Cmbagama.Text &
                                  "',TglLhr='" & DTglhr.Value &
                                   "',TempatLhr='" & txtTempatLhr.Text &
                                  "',Alamat='" & txtalamat.Text &
                                  "',AsalSekolah='" & txtAsalSekolah.Text &
                                  "',NoHp='" & txtNoHp.Text &
                                  "',Email='" & txtEmail.Text &
                                  "',JenisKelamin='" & JenisKelamin.Text & "' where NIK ='" & Txtnik.Text & "'", CNN)
        X = OLECMD.ExecuteNonQuery
        If X = 1 Then
            MsgBox("Data Berhasil Diedit", MsgBoxStyle.Information, "Informasi")
            Call bersih()
            Txtnik.Focus()
        Else
            MsgBox("Gagal Mengedit Data", MsgBoxStyle.Exclamation, "Ada Kesalahan")
        End If

    End Sub

    Private Sub Bdelete_Click(sender As Object, e As EventArgs) Handles Bdelete.Click
        If MsgBox("Ingin Menghapus Data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            CNN = New OleDbConnection(koneksi)
            If CNN.State <> ConnectionState.Closed Then CNN.Close()
            CNN.Open()
            OLECMD = New OleDbCommand("delete from pendaftaran where NIK ='" & Txtnik.Text & "'", CNN)
            X = OLECMD.ExecuteNonQuery
            If X = 1 Then
                Call bersih()
                Bsave.Enabled = True
                Bedit.Enabled = False
                Bdelete.Enabled = False
                Txtnik.Focus()
            Else
                MsgBox("Gagal Menghapus Data", MsgBoxStyle.Exclamation, "Kesalahan")
            End If
        End If
    End Sub

    Private Sub Bcancel_Click(sender As Object, e As EventArgs) Handles Bcancel.Click
        Call bersih()
        Bsave.Enabled = True
        Bedit.Enabled = False
        Bdelete.Enabled = False
        Txtnik.Enabled = True
        Txtnik.Focus()
    End Sub

    Private Sub BCari_Click(sender As Object, e As EventArgs) Handles BCari.Click
        Dim poppendaftaran As New poppeg
        poppendaftaran.ShowDialog()
        If poppendaftaran.colnama <> "" Then
            Txtnik.Text = poppendaftaran.colnik
            txtnama.Text = poppendaftaran.colnama
            Cmbagama.Text = poppendaftaran.colagama
            DTglhr.Text = poppendaftaran.coltglhr
            txtTempatLhr.Text = poppendaftaran.coltempatlahir
            txtalamat.Text = poppendaftaran.colalamat
            txtAsalSekolah.Text = poppendaftaran.colasalsekolah
            txtNoHp.Text = poppendaftaran.colnohp
            txtEmail.Text = poppendaftaran.colemail
            If poppendaftaran.coljeniskelamin = "Laki-laki" Then
                Rbper.Checked = True
            Else
                RBlklk.Checked = True
            End If
            Txtnik.Enabled = False
            txtnama.Focus()
        End If
        Bedit.Enabled = True
        Bdelete.Enabled = True
    End Sub

    Private Sub Txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnik.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnama.Focus()
        End If
    End Sub

    Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmbagama.Focus()
        End If
    End Sub

    Private Sub DTglhr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTglhr.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtalamat.Focus()
        End If
    End Sub

    Private Sub Cmbbagian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmbagama.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DTglhr.Focus()
        End If
    End Sub

    Private Sub txtalamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtalamat.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtAsalSekolah.Focus()
        End If
    End Sub

    Private Sub Binput_Click(sender As Object, e As EventArgs) Handles Binput.Click
        Call bersih()
        Bsave.Enabled = True
        Bedit.Enabled = False
        Bdelete.Enabled = False
        Txtnik.Enabled = True
        Txtnik.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmbagama.Items.Add("Islam")
        Cmbagama.Items.Add("Kristen Protestan")
        Cmbagama.Items.Add("Katholik")
        Cmbagama.Items.Add("Budha")
        Cmbagama.Items.Add("Hindu")
        Cmbagama.Items.Add("Konghuchu")
    End Sub

    Private Sub Txtnik_TextChanged(sender As Object, e As EventArgs) Handles Txtnik.TextChanged

    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged

    End Sub
End Class
