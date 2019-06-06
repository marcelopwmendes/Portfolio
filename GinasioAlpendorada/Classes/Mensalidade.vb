Public Class Mensalidade
    Public id, atividades As Integer
    Public nome, descicao As String
    Public preco As Decimal
    Public ds As New Base_de_Dados_v2DataSet
    Public dt As New Base_de_Dados_v2DataSet.MensalidadeDataTable
    Public ta As New Base_de_Dados_v2DataSetTableAdapters.MensalidadeTableAdapter

    Public Sub New()

    End Sub

    Public Function adicionar(nome As String, descricao As String, preco As Decimal, atividades As Integer) As Integer
        ta.Fill(dt)
        Me.nome = nome
        Me.descicao = descricao
        Me.preco = preco
        Me.atividades =
        adicionar = ta.Insert(nome, descricao, preco, atividades)
    End Function

    Public Function editar(id As Integer, nome As String, descricao As String, preco As Decimal, atividades As Integer) As Integer
        ta.FillByID(dt, id)
        Me.id = id
        Me.nome = dt.Item(0).Item("Nome")
        Me.descicao = dt.Item(0).Item("Descrição")
        Me.preco = dt.Item(0).Item("Preço")
        Me.atividades = dt.Item(0).Item("Atividades")
        editar = ta.Update(nome, descricao, preco, atividades, id, Me.nome, Me.descicao, Me.preco, Me.atividades)
    End Function

    Public Function eliminar(id As Integer) As Integer
        ta.FillByID(dt, id)
        Me.nome = dt.Item(0).Item("Nome")
        Me.descicao = dt.Item(0).Item("Descrição")
        Me.preco = dt.Item(0).Item("Preço")
        Me.atividades = dt.Item(0).Item("Atividades")
        eliminar = ta.Delete(id, nome, descicao, preco, atividades)
    End Function

    Public Function obterNAtividades(id As Integer) As Integer
        ta.FillByID(dt, id)
        Return dt.Item(0).Item("Atividades")
    End Function

End Class
