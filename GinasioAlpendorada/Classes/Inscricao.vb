Public Class Inscricao
    Public id, cliente, atividade As Integer
    Public ds As New Base_de_Dados_v2DataSet
    Public dt As New Base_de_Dados_v2DataSet.InscriçãoDataTable
    Public ta As New Base_de_Dados_v2DataSetTableAdapters.InscriçãoTableAdapter

    Public Sub New()
        ta.Fill(dt)
    End Sub

    Public Function adicionar(cliente As Integer, atividade As Integer) As Integer
            ta.Fill(dt)
            Me.cliente = cliente
            Me.atividade = atividade
            adicionar = ta.Insert(cliente, atividade)
    End Function

    Public Function eliminar(id As Integer) As Integer
        ta.FillByID(dt, id)
        Me.cliente = dt.Item(0).Item("ID_Cliente")
        Me.atividade = dt.Item(0).Item("ID_Atividade")
        Dim a As New Atividade
        a.atualizarlotação(Me.atividade, False)
        a.AtualizarAtiva(Me.atividade)
        eliminar = ta.Delete(id, cliente, atividade)
    End Function

    Public Function NAtividades(Cliente As Integer) As Integer
        ta.FillByCliente(dt, Cliente)
        Return dt.Rows.Count
    End Function
End Class
