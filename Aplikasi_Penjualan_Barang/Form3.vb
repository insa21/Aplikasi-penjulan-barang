Imports System.Data.OleDb
Public Class Form3

    Sub baca()
        Call koneksi()
        DA = New OleDbDataAdapter("Select no_trans,id_barang,barang_sup,kategori_sup,tgl_trans,harga_sup from tbl_admin,tbl_suplay where tbl_admin.id_barang = tbl_suplay.id_sup ", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_admin")
        DataGridView1.DataSource = (DS.Tables("tbl_admin"))
    End Sub

    Sub kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        simpan.Enabled = True
        edit.Enabled = True
    End Sub

    Private Sub TabPage2_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        DA = New OleDbDataAdapter("select id_sup,barang_sup,harga_sup from tbl_suplay ", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_suplay")
        DataGridView2.DataSource = (DS.Tables("tbl_suplay"))
    End Sub

    Private Sub TabPage1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        DA = New OleDbDataAdapter("Select no_trans,id_barang,barang_sup,kategori_sup,tgl_trans,harga_sup from tbl_admin,tbl_suplay where tbl_admin.id_barang = tbl_suplay.id_sup ", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_admin")
        DataGridView1.DataSource = (DS.Tables("tbl_admin"))
    End Sub


    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        Dim hapus As String
        hapus = "delete from tbl_admin where no_trans='" & TextBox2.Text & "'"
        CMD = New OleDbCommand(hapus, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Sudah Terhapus", MsgBoxStyle.Information, "INFORMASI")
        TextBox2.Enabled = True
        Call baca()
        Call kosong()
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
    End Sub

   Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click, edit.Click
        Dim update As String
        update = "update tbl_admin set " &
            "id_barang='" & TextBox1.Text & "'," &
            "tgl_trans ='" & TextBox3.Text & "' where no_trans='" & TextBox2.Text & "'"
        CMD = New OleDbCommand(update, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Sudah Terupdate", MsgBoxStyle.Information, "INFORMASI")
        TextBox2.Enabled = True
        Call baca()
        Call kosong()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data Belum Lengkap, Pastikan Semua From Terisi")
            Exit Sub
        Else
            Call koneksi()
            Dim simpan As String = "insert into tbl_admin values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "')"
            CMD = New OleDbCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil di input!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call baca()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class