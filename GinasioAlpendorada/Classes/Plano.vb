Public Class Plano
    Public id As Integer
    Public descricao As String
    Public ds As New Base_de_Dados_v2DataSet
    Public dt As New Base_de_Dados_v2DataSet.PlanoDataTable
    Public ta As New Base_de_Dados_v2DataSetTableAdapters.PlanoTableAdapter

    Public Sub New()

    End Sub

    Public Sub adicionar(id As Integer, descricao As String)
        Dim a As Integer
        ta.Fill(dt)
        Me.id = dt.Rows.Count + 1
        Me.descricao = descricao
        a = ta.Insert(descricao)
        If a > 0 Then
            MsgBox("Plano adicionado com sucesso", MsgBoxStyle.Information, "Sucesso")
        Else
            MsgBox("Plano não foi adicionado", MsgBoxStyle.Critical, "Falha")
        End If
    End Sub

    Public Sub editar(id As Integer, descricao As String)
        Dim a As Integer
        ta.FillByID(dt, id)
        Me.id = id
        Me.descricao = dt.Item(0).Item("Descrição")
        a = ta.Update(descricao, id, Me.descricao)
        If a > 0 Then
            MsgBox("Plano editado com sucesso", MsgBoxStyle.Information, "Sucesso")
        Else
            MsgBox("Plano não foi editado", MsgBoxStyle.Critical, "Falha")
        End If
        Me.descricao = descricao
    End Sub

    Public Function eliminar(id As Integer) As Integer
        ta.FillByID(dt, id)
        Me.id = id
        Me.descricao = dt.Item(0).Item("Descrição")
        eliminar = ta.Delete(Me.id, Me.descricao)
    End Function

End Class
