Public Class Fatura
    Dim ta As New Base_de_Dados_v2DataSetTableAdapters.FaturaTableAdapter
    Dim ds As New Base_de_Dados_v2DataSet
    Dim dt As New Base_de_Dados_v2DataSet.FaturaDataTable
    Public id, clienteId As Integer
    Public data As Date
    Public montante As Decimal
    Public outrosdetalhes As String

    Public Sub New()
        Me.data = Today
    End Sub

    Public Function adicionar() As Integer
        Dim v As Integer
        ta.Fill(dt)
        v = ta.Insert(clienteId, data, montante, outrosdetalhes)

        Return v    
    End Function

End Class
