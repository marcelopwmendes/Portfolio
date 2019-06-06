Public Class ListarClientesReport

    Private Sub ListarClientesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Cliente' table. You can move, or remove it, as needed.
        'Me.ClienteTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Cliente)
        Me.ClienteTableAdapter.FillByAtivo(Me.Base_de_Dados_v2DataSet.Cliente, True)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class