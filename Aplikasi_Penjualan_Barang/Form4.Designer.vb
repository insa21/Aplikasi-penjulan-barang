<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Aplikasi_PenjualanDataSet = New WindowsApplication1.Aplikasi_PenjualanDataSet()
        Me.tbl_suplayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_suplayTableAdapter = New WindowsApplication1.Aplikasi_PenjualanDataSetTableAdapters.tbl_suplayTableAdapter()
        CType(Me.Aplikasi_PenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_suplayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_suplayBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(38, 29)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(655, 299)
        Me.ReportViewer1.TabIndex = 0
        '
        'Aplikasi_PenjualanDataSet
        '
        Me.Aplikasi_PenjualanDataSet.DataSetName = "Aplikasi_PenjualanDataSet"
        Me.Aplikasi_PenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_suplayBindingSource
        '
        Me.tbl_suplayBindingSource.DataMember = "tbl_suplay"
        Me.tbl_suplayBindingSource.DataSource = Me.Aplikasi_PenjualanDataSet
        '
        'tbl_suplayTableAdapter
        '
        Me.tbl_suplayTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 431)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Aplikasi_PenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_suplayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_suplayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Aplikasi_PenjualanDataSet As WindowsApplication1.Aplikasi_PenjualanDataSet
    Friend WithEvents tbl_suplayTableAdapter As WindowsApplication1.Aplikasi_PenjualanDataSetTableAdapters.tbl_suplayTableAdapter
End Class
