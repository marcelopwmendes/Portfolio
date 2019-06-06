Public Class Exercício
    Public id As Integer
    Public Grupo_Muscular, dificuldade As String
    Public ds As New Base_de_Dados_v2DataSet
    Public dt As New Base_de_Dados_v2DataSet.ExercicioDataTable
    Public ta As New Base_de_Dados_v2DataSetTableAdapters.ExercicioTableAdapter

    Public Sub New()

    End Sub

    Public Sub adicionar(gm As String, d As String)
        Dim a As Integer
        ta.Fill(dt)
        Me.id = dt.Rows.Count + 1
        Me.Grupo_Muscular = gm
        Me.dificuldade = d
        a = ta.Insert(Me.Grupo_Muscular, Me.dificuldade)
        If a > 0 Then
            MsgBox("Exercício adicionado com sucesso", MsgBoxStyle.Information, "Sucesso")
        Else
            MsgBox("Exercício não foi adicionado", MsgBoxStyle.Critical, "Falha")
        End If
    End Sub

    Public Sub editar(id As Integer, gm As String, d As String)
        Dim a As Integer
        ta.FillByID(dt, id)
        Me.id = id
        Me.Grupo_Muscular = dt.Item(0).Item("Grupo_Muscular").ToString()
        Me.dificuldade = dt.Item(0).Item("Dificuldade").ToString
        a = ta.Update(gm, d, Me.id, Me.Grupo_Muscular, Me.dificuldade)
        If a > 0 Then
            MsgBox("Exercício editado com sucesso", MsgBoxStyle.Information, "Sucesso")
            Me.Grupo_Muscular = gm
            Me.dificuldade = dificuldade
        Else
            MsgBox("Exercício não foi editado", MsgBoxStyle.Critical, "Falha")
        End If
       
    End Sub


    Public Function apagar(id As Integer) As Integer
        ta.FillByID(dt, id)
        Me.id = id
        Me.Grupo_Muscular = dt.Item(0).Item("Grupo_Muscular").ToString()
        Me.dificuldade = dt.Item(0).Item("Dificuldade").ToString
        apagar = ta.Delete(Me.id, Me.Grupo_Muscular, Me.dificuldade)
    End Function

End Class
