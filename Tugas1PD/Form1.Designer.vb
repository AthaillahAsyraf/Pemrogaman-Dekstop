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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.MaskedTextBox()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.cbmatkul = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtuas = New System.Windows.Forms.TextBox()
        Me.txtuts = New System.Windows.Forms.TextBox()
        Me.txttugas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.dgnip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgnama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgmatkul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dggrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fakultas"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(145, 71)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(516, 22)
        Me.txtnama.TabIndex = 4
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(145, 41)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(516, 22)
        Me.txtnip.TabIndex = 5
        '
        'cbjurusan
        '
        Me.cbjurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Location = New System.Drawing.Point(117, 116)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(516, 24)
        Me.cbjurusan.TabIndex = 6
        '
        'cbmatkul
        '
        Me.cbmatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmatkul.FormattingEnabled = True
        Me.cbmatkul.Location = New System.Drawing.Point(117, 149)
        Me.cbmatkul.Name = "cbmatkul"
        Me.cbmatkul.Size = New System.Drawing.Size(516, 24)
        Me.cbmatkul.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jenis Kelamin"
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Location = New System.Drawing.Point(158, 114)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(86, 21)
        Me.rbL.TabIndex = 10
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Location = New System.Drawing.Point(269, 114)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(102, 21)
        Me.rbP.TabIndex = 11
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblgrade)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtuas)
        Me.Panel1.Controls.Add(Me.txtuts)
        Me.Panel1.Controls.Add(Me.txttugas)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cbjurusan)
        Me.Panel1.Controls.Add(Me.cbmatkul)
        Me.Panel1.Location = New System.Drawing.Point(28, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 229)
        Me.Panel1.TabIndex = 12
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Location = New System.Drawing.Point(656, 189)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(67, 17)
        Me.lblgrade.TabIndex = 19
        Me.lblgrade.Text = "-GRADE-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(501, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Uas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(322, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Uts"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(133, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tugas"
        '
        'txtuas
        '
        Me.txtuas.Location = New System.Drawing.Point(536, 184)
        Me.txtuas.Name = "txtuas"
        Me.txtuas.Size = New System.Drawing.Size(97, 22)
        Me.txtuas.TabIndex = 15
        '
        'txtuts
        '
        Me.txtuts.Location = New System.Drawing.Point(357, 186)
        Me.txtuts.Name = "txtuts"
        Me.txtuts.Size = New System.Drawing.Size(97, 22)
        Me.txtuts.TabIndex = 14
        '
        'txttugas
        '
        Me.txttugas.Location = New System.Drawing.Point(187, 186)
        Me.txttugas.Name = "txttugas"
        Me.txttugas.Size = New System.Drawing.Size(97, 22)
        Me.txttugas.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Jurusan"
        '
        'dgvdata
        '
        Me.dgvdata.AllowUserToAddRows = False
        Me.dgvdata.AllowUserToDeleteRows = False
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgnip, Me.dgnama, Me.dgjeniskelamin, Me.dgjurusan, Me.dgmatkul, Me.dggrade})
        Me.dgvdata.Location = New System.Drawing.Point(28, 325)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.ReadOnly = True
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(642, 185)
        Me.dgvdata.TabIndex = 13
        '
        'dgnip
        '
        Me.dgnip.HeaderText = "Nip"
        Me.dgnip.Name = "dgnip"
        Me.dgnip.ReadOnly = True
        '
        'dgnama
        '
        Me.dgnama.HeaderText = "Nama"
        Me.dgnama.Name = "dgnama"
        Me.dgnama.ReadOnly = True
        '
        'dgjeniskelamin
        '
        Me.dgjeniskelamin.HeaderText = "Jenis Kelamin"
        Me.dgjeniskelamin.Name = "dgjeniskelamin"
        Me.dgjeniskelamin.ReadOnly = True
        '
        'dgjurusan
        '
        Me.dgjurusan.HeaderText = "Jurusan"
        Me.dgjurusan.Name = "dgjurusan"
        Me.dgjurusan.ReadOnly = True
        '
        'dgmatkul
        '
        Me.dgmatkul.HeaderText = "Mata Kuliah"
        Me.dgmatkul.Name = "dgmatkul"
        Me.dgmatkul.ReadOnly = True
        '
        'dggrade
        '
        Me.dggrade.HeaderText = "GRADE"
        Me.dggrade.Name = "dggrade"
        Me.dggrade.ReadOnly = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(28, 278)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(215, 278)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 15
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(120, 278)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 16
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.Location = New System.Drawing.Point(304, 278)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 17
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 522)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.rbP)
        Me.Controls.Add(Me.rbL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cbmatkul As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtuas As System.Windows.Forms.TextBox
    Friend WithEvents txtuts As System.Windows.Forms.TextBox
    Friend WithEvents txttugas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblgrade As System.Windows.Forms.Label
    Friend WithEvents dgnip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgnama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgmatkul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dggrade As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
