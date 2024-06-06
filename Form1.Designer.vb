<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Txtnik = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Cmbagama = New System.Windows.Forms.ComboBox()
        Me.DTglhr = New System.Windows.Forms.DateTimePicker()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rbper = New System.Windows.Forms.RadioButton()
        Me.RBlklk = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Binput = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bdelete = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.JenisKelamin = New System.Windows.Forms.Label()
        Me.BCari = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTempatLhr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAsalSekolah = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtnik
        '
        Me.Txtnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnik.Location = New System.Drawing.Point(221, 54)
        Me.Txtnik.Name = "Txtnik"
        Me.Txtnik.Size = New System.Drawing.Size(284, 26)
        Me.Txtnik.TabIndex = 0
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(221, 97)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(284, 26)
        Me.txtnama.TabIndex = 0
        '
        'Cmbagama
        '
        Me.Cmbagama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbagama.FormattingEnabled = True
        Me.Cmbagama.Location = New System.Drawing.Point(221, 143)
        Me.Cmbagama.Name = "Cmbagama"
        Me.Cmbagama.Size = New System.Drawing.Size(284, 28)
        Me.Cmbagama.TabIndex = 1
        '
        'DTglhr
        '
        Me.DTglhr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTglhr.Location = New System.Drawing.Point(221, 197)
        Me.DTglhr.Name = "DTglhr"
        Me.DTglhr.Size = New System.Drawing.Size(284, 26)
        Me.DTglhr.TabIndex = 2
        '
        'txtalamat
        '
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(221, 275)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(284, 60)
        Me.txtalamat.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rbper)
        Me.GroupBox2.Controls.Add(Me.RBlklk)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(221, 495)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 54)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Rbper
        '
        Me.Rbper.AutoSize = True
        Me.Rbper.Location = New System.Drawing.Point(173, 17)
        Me.Rbper.Name = "Rbper"
        Me.Rbper.Size = New System.Drawing.Size(118, 24)
        Me.Rbper.TabIndex = 1
        Me.Rbper.TabStop = True
        Me.Rbper.Text = "Perempuan"
        Me.Rbper.UseVisualStyleBackColor = True
        '
        'RBlklk
        '
        Me.RBlklk.AutoSize = True
        Me.RBlklk.Location = New System.Drawing.Point(6, 17)
        Me.RBlklk.Name = "RBlklk"
        Me.RBlklk.Size = New System.Drawing.Size(93, 24)
        Me.RBlklk.TabIndex = 0
        Me.RBlklk.TabStop = True
        Me.RBlklk.Text = "Laki-laki"
        Me.RBlklk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Binput)
        Me.GroupBox1.Controls.Add(Me.Bexit)
        Me.GroupBox1.Controls.Add(Me.Bcancel)
        Me.GroupBox1.Controls.Add(Me.Bdelete)
        Me.GroupBox1.Controls.Add(Me.Bedit)
        Me.GroupBox1.Controls.Add(Me.Bsave)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(645, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 426)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Binput
        '
        Me.Binput.Location = New System.Drawing.Point(36, 51)
        Me.Binput.Name = "Binput"
        Me.Binput.Size = New System.Drawing.Size(102, 44)
        Me.Binput.TabIndex = 1
        Me.Binput.Text = "New Input "
        Me.Binput.UseVisualStyleBackColor = True
        '
        'Bexit
        '
        Me.Bexit.Location = New System.Drawing.Point(45, 353)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(93, 36)
        Me.Bexit.TabIndex = 0
        Me.Bexit.Text = "Exit"
        Me.Bexit.UseVisualStyleBackColor = True
        '
        'Bcancel
        '
        Me.Bcancel.Location = New System.Drawing.Point(45, 268)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(86, 39)
        Me.Bcancel.TabIndex = 0
        Me.Bcancel.Text = "Cancel"
        Me.Bcancel.UseVisualStyleBackColor = True
        '
        'Bdelete
        '
        Me.Bdelete.Enabled = False
        Me.Bdelete.Location = New System.Drawing.Point(45, 212)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(86, 42)
        Me.Bdelete.TabIndex = 0
        Me.Bdelete.Text = "Delete"
        Me.Bdelete.UseVisualStyleBackColor = True
        '
        'Bedit
        '
        Me.Bedit.Enabled = False
        Me.Bedit.Location = New System.Drawing.Point(45, 160)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(86, 35)
        Me.Bedit.TabIndex = 0
        Me.Bedit.Text = "Edit"
        Me.Bedit.UseVisualStyleBackColor = True
        '
        'Bsave
        '
        Me.Bsave.Location = New System.Drawing.Point(45, 106)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(86, 38)
        Me.Bsave.TabIndex = 0
        Me.Bsave.Text = "Save"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama lengkap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tgl Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Asal Sekolah"
        '
        'JenisKelamin
        '
        Me.JenisKelamin.AutoSize = True
        Me.JenisKelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisKelamin.Location = New System.Drawing.Point(55, 514)
        Me.JenisKelamin.Name = "JenisKelamin"
        Me.JenisKelamin.Size = New System.Drawing.Size(119, 20)
        Me.JenisKelamin.TabIndex = 7
        Me.JenisKelamin.Text = "Jenis Kelamin"
        '
        'BCari
        '
        Me.BCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCari.Location = New System.Drawing.Point(520, 54)
        Me.BCari.Name = "BCari"
        Me.BCari.Size = New System.Drawing.Size(97, 26)
        Me.BCari.TabIndex = 8
        Me.BCari.Text = "Cari"
        Me.BCari.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "No Hp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 452)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Email"
        '
        'txtNoHp
        '
        Me.txtNoHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoHp.Location = New System.Drawing.Point(221, 410)
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(284, 26)
        Me.txtNoHp.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(221, 452)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(284, 26)
        Me.txtEmail.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(122, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(517, 31)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "FORM PENDAFTARAN SISWA BARU "
        '
        'txtTempatLhr
        '
        Me.txtTempatLhr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempatLhr.Location = New System.Drawing.Point(221, 240)
        Me.txtTempatLhr.Multiline = True
        Me.txtTempatLhr.Name = "txtTempatLhr"
        Me.txtTempatLhr.Size = New System.Drawing.Size(284, 26)
        Me.txtTempatLhr.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(60, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Tempat Lahir"
        '
        'txtAsalSekolah
        '
        Me.txtAsalSekolah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsalSekolah.Location = New System.Drawing.Point(220, 350)
        Me.txtAsalSekolah.Multiline = True
        Me.txtAsalSekolah.Name = "txtAsalSekolah"
        Me.txtAsalSekolah.Size = New System.Drawing.Size(285, 30)
        Me.txtAsalSekolah.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(908, 614)
        Me.Controls.Add(Me.txtAsalSekolah)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNoHp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BCari)
        Me.Controls.Add(Me.JenisKelamin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.DTglhr)
        Me.Controls.Add(Me.Cmbagama)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Txtnik)
        Me.Controls.Add(Me.txtTempatLhr)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "FORM UTAMA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtnik As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Cmbagama As System.Windows.Forms.ComboBox
    Friend WithEvents DTglhr As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rbper As System.Windows.Forms.RadioButton
    Friend WithEvents RBlklk As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Bcancel As System.Windows.Forms.Button
    Friend WithEvents Bdelete As System.Windows.Forms.Button
    Friend WithEvents Bedit As System.Windows.Forms.Button
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents JenisKelamin As System.Windows.Forms.Label
    Friend WithEvents BCari As Button
    Friend WithEvents Binput As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTempatLhr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAsalSekolah As TextBox
End Class
