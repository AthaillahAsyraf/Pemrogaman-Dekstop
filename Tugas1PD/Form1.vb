Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim nip As String = txtNIP.Text
        Dim nama As String = txtNama.Text
        Dim jenisKelamin As String = If(RadioButton1.Checked, "Laki - Laki", "Perempuan")
        Dim fakultas As String = cmbFakultas.SelectedItem.ToString()
        Dim jurusan As String = cmbJurusan.SelectedItem.ToString()


        MessageBox.Show("Hai : " & nip & vbCrLf &
                       "Nip : " & nama & vbCrLf &
                       "Fakultas : " & fakultas & vbCrLf &
                       "Jurusan : " & jurusan & vbCrLf &
                       "Jenis Kelamin : " & jenisKelamin,
                       "Informasi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information)

    End Sub

    Private Sub cmbJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJurusan.SelectedIndexChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
