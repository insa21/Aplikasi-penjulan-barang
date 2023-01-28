Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Aplikasi_PenjualanDataSet.tbl_suplay' table. You can move, or remove it, as needed.
        Me.tbl_suplayTableAdapter.Fill(Me.Aplikasi_PenjualanDataSet.tbl_suplay)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class