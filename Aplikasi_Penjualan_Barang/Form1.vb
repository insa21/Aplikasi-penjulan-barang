Imports System.Data.OleDb

Public Class login

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MessageBox.Show("Isi username dan password terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                koneksi()
                CMD = New OleDbCommand("select * from tbl_login where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    If RD("user").ToString = "administrator" Then
                        Me.Hide()
                        Form2.Show()
                    Else
                        Me.Hide()
                        Form3.Show()
                    End If
                Else
                    MessageBox.Show("Akun anda belum terdaftar!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class