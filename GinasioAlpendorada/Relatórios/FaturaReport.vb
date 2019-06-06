Public Class FaturaReport
    Private Sub FaturaReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idfatura As Integer
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Fatura' table. You can move, or remove it, as needed.
        Me.FaturaTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Fatura)
        idfatura = Me.Base_de_Dados_v2DataSet.Fatura.Item(Base_de_Dados_v2DataSet.Fatura.Count - 1).Item("ID_Fatura")
        Me.FaturaTableAdapter.FillByID(Me.Base_de_Dados_v2DataSet.Fatura, idfatura)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class