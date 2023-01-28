Imports System.Data.OleDb
Module Module1
    Public CONN As OleDbConnection 'membuat koneksi dengan db access
    Public CMD As OleDbCommand 'membuat printah SQL untuk memanggil data
    Public DS As New DataSet 'dataset merupakan reprensentasi data
    Public DA As OleDbDataAdapter ' mengisi object dataset dengan hasil dari sumber data
    Public RD As OleDbDataReader 'pengambilan hasil query dari sumber data (database)
    Public LokasiData As String

    Public Sub koneksi()
        LokasiData = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Aplikasi_Penjualan.accdb"
        CONN = New OleDbConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub

End Module
