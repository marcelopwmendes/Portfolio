Public Class Aula
    Public h_inicio, h_fim, data As Date
    Public cliente, monitor As Integer
    Public preco As Decimal
    Public ds As New Base_de_Dados_v2DataSet
    Public dt As New Base_de_Dados_v2DataSet.AulaDataTable
    Public ta As New Base_de_Dados_v2DataSetTableAdapters.AulaTableAdapter

    Public Sub New()

    End Sub

    Public Sub adicionar(hinicio As Date, hfim As Date, preco As Decimal, cliente As Integer, monitor As Integer, data As Date)
        Dim a As Integer
        If verificar(hinicio, hfim, monitor, data) = 1 Then
            ta.Fill(dt)
            Me.h_inicio = hinicio
            Me.h_fim = hfim
            Me.cliente = cliente
            Me.preco = preco
            Me.monitor = monitor
            Me.data = data
            a = ta.Insert(hinicio, hfim, preco, cliente, monitor, data)
            If a > 0 Then
                MsgBox("Aula marcada com sucesso", MsgBoxStyle.Information, "Sucesso")
            Else
                MsgBox("Aula não foi marcada", MsgBoxStyle.Critical, "Falha")
            End If
        Else
            MsgBox("Tem outra aula a decorrer nesse espaço de tempo", MsgBoxStyle.Information, "Erro")
        End If
    End Sub

    Public Function eliminar(hinicio As Date, hfim As Date, cliente As Integer, monitor As Integer, data As Date) As Integer
        ta.FillByCP(dt, hinicio, cliente, monitor, data)
        h_inicio = hinicio
        h_fim = dt.Item(0).Item("Hora_Fim")
        Me.cliente = cliente
        Me.monitor = monitor
        Me.preco = dt.Item(0).Item("Preco")
        Me.data = data
        eliminar = ta.Delete(hinicio, hfim, preco, cliente, monitor, data)
    End Function

    Public Function verificar(hi As Date, hf As Date, m As Integer, d As Date) As Integer
        Dim item As Integer
        ta.FillByDataMonitor(dt, d, m)
        For i = 1 To dt.Rows.Count
            item = i - 1
            Me.h_inicio = dt.Rows.Item(item).Item("Hora_Inicio")
            Me.h_fim = dt.Rows.Item(item).Item("Hora_Fim")

            If (hi >= FormatDateTime(h_inicio, DateFormat.ShortTime) And hi <= FormatDateTime(h_fim, DateFormat.ShortTime)) Or (hf >= FormatDateTime(h_inicio, DateFormat.ShortTime) And hf <= FormatDateTime(h_fim, DateFormat.ShortTime)) Then
                verificar = 0
                Exit For
            Else
                verificar = 1
            End If
        Next
        If dt.Rows.Count = 0 Then
            Return 1
        End If
    End Function

End Class
