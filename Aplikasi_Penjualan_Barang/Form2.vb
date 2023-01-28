Imports System.Data.OleDb
Public Class Form2

    Sub baca()
        Call koneksi()
        DA = New OleDbDataAdapter("Select * from tbl_suplay", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_suplay")
        DataGridView1.DataSource = (DS.Tables("tbl_suplay"))
    End Sub

    Sub kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        simpan.Enabled = True
        edit.Enabled = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        DA = New OleDbDataAdapter("select * from tbl_suplay", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_suplay")
        DataGridView1.DataSource = (DS.Tables("tbl_suplay"))
    End Sub


    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        Dim hapus As String
        hapus = "delete from tbl_suplay where id_sup='" & TextBox1.Text & "'"
        CMD = New OleDbCommand(hapus, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Sudah Terhapus", MsgBoxStyle.Information, "INFORMASI")
        TextBox1.Enabled = True
        Call baca()
        Call kosong()
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
Me.Close()
    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click, edit.Click
        Dim update As String
        update = "update tbl_suplay set " &
            " barang_sup='" & TextBox2.Text & "'," &
            "kategori_sup='" & TextBox3.Text & "'," &
            "harga_sup ='" & TextBox4.Text & "' where id_sup='" & TextBox1.Text & "'"
        CMD = New OleDbCommand(update, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Sudah Terupdate", MsgBoxStyle.Information, "INFORMASI")
        TextBox1.Enabled = True
        Call baca()
        Call kosong()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data Belum Lengkap, Pastikan Semua From Terisi")
            Exit Sub
        Else
            Call koneksi()
            Dim simpan As String = "insert into tbl_suplay values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
            CMD = New OleDbCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di input", MsgBoxStyle.Information, "information")
            Call baca()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.kosong()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
