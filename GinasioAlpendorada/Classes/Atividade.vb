Public Class Atividade
    Public id, monitor, lotacaomax, lotacaoatual, diasemana As Integer
    Public hora As Date
    Public nome As String
    Public ativa, adecorrer As Boolean
    Public ds As New Base_de_Dados_v2DataSet
    Public dt As New Base_de_Dados_v2DataSet.AtividadeDataTable
    Public ta As New Base_de_Dados_v2DataSetTableAdapters.AtividadeTableAdapter

    Public Sub New()
        ta.Fill(dt)
    End Sub

    Public Sub New(id As Integer)
        ta.FillByID(dt, id)
        Me.id = id
        Me.monitor = dt.Item(0).Item("ID_Monitor")
        Me.lotacaomax = dt.Item(0).Item("LotaçãoMáxima")
        Me.hora = dt.Item(0).Item("Hora")
        Me.nome = dt.Item(0).Item("Nome")
        Me.lotacaoatual = dt.Item(0).Item("LotaçãoAtual")
        Me.diasemana = dt.Item(0).Item("DiaDaSemana")
        Me.ativa = dt.Item(0).Item("Ativa")
        Me.adecorrer = dt.Item(0).Item("ADecorrer")
    End Sub

    Public Function adicionar(monitor As Integer, lotacaomax As Integer, nome As String, diasemana As Integer, hora As Date)
        ta.Fill(dt)
        Me.id = id
        Me.monitor = monitor
        Me.lotacaomax = lotacaomax
        Me.lotacaoatual = 0
        Me.hora = hora
        Me.nome = nome
        Me.diasemana = diasemana
        Me.ativa = False
        Me.adecorrer = False
        adicionar = ta.Insert(monitor, lotacaomax, nome, diasemana, hora, 0, Me.ativa, Me.adecorrer)
    End Function

    Public Function editar(id As Integer, monitor As Integer, nome As String, lotacaomax As Integer, hora As Date, diasemana As Integer) As Integer
        ta.FillByID(dt, id)
        Me.id = id
        Me.monitor = dt.Item(0).Item("ID_Monitor")
        Me.lotacaomax = dt.Item(0).Item("LotaçãoMáxima")
        Me.hora = dt.Item(0).Item("Hora")
        Me.nome = dt.Item(0).Item("Nome")
        Me.lotacaoatual = dt.Item(0).Item("LotaçãoAtual")
        Me.diasemana = dt.Item(0).Item("DiaDaSemana")
        Me.ativa = dt.Item(0).Item("Ativa")
        Me.adecorrer = dt.Item(0).Item("ADecorrer")
        editar = ta.Update(monitor, lotacaomax, nome, diasemana, hora, Me.lotacaoatual, Me.ativa, Me.adecorrer, Me.id, Me.monitor, Me.lotacaomax, Me.nome, Me.diasemana, Me.hora, Me.lotacaoatual, Me.ativa, Me.adecorrer)
    End Function

    Public Function eliminar(id As Integer) As Integer
        ta.FillByID(dt, id)
        Me.id = id
        Me.monitor = dt.Item(0).Item("ID_Monitor")
        Me.lotacaomax = dt.Item(0).Item("LotaçãoMáxima")
        Me.hora = dt.Item(0).Item("Hora")
        Me.nome = dt.Item(0).Item("Nome")
        Me.lotacaoatual = dt.Item(0).Item("LotaçãoAtual")
        Me.diasemana = dt.Item(0).Item("DiaDaSemana")
        Me.ativa = dt.Item(0).Item("Ativa")
        Me.adecorrer = dt.Item(0).Item("ADecorrer")
        eliminar = ta.Delete(Me.id, Me.monitor, Me.lotacaomax, Me.nome, Me.diasemana, Me.hora, Me.lotacaoatual, Me.ativa, Me.adecorrer)
    End Function

    Public Sub atualizarlotação(id As Integer, soma As Boolean)
        Dim n As Integer
        ta.FillByID(dt, id)
        If soma = True Then
            n = dt.Item(0).Item("LotaçãoAtual") + 1
        Else
            If dt.Item(0).Item("LotaçãoAtual") > 0 Then
                n = dt.Item(0).Item("LotaçãoAtual") - 1
            Else
                n = 0
            End If
            End If
            ta.AtualizarLotaçãoAtual(n, id)
    End Sub

    Public Function lotacaodisponivel(id As Integer) As Boolean
        ta.FillByID(dt, id)
        If dt.Item(0).Item("LotaçãoMáxima") > dt.Item(0).Item("LotaçãoAtual") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub AtividadeAtiva()
        Dim datalimite As Date 'Cada atividade tem 1h de duração
        For i = 1 To dt.Rows.Count
            ta.Fill(dt)
            datalimite = Me.hora
            Me.id = dt.Item(i - 1).Item("ID_Atividade")
            Me.hora = dt.Item(i - 1).Item("Hora")
            Me.diasemana = dt.Item(i - 1).Item("DiaDaSemana")
            Me.ativa = dt.Item(i - 1).Item("Ativa")
            If Me.ativa = False Then
                ta.AtualizarADecorrer(False, Me.id)
            Else
                If Me.diasemana = Now.DayOfWeek Then
                    datalimite = DateAdd(DateInterval.Hour, 1, Me.hora)
                    If (Now.TimeOfDay >= Me.hora.TimeOfDay And Me.hora.TimeOfDay <= datalimite.TimeOfDay) Then
                        ta.AtualizarADecorrer(True, Me.id)
                    Else
                        ta.AtualizarADecorrer(False, Me.id)
                    End If
                Else
                    ta.AtualizarADecorrer(False, Me.id)
                End If
            End If
        Next
    End Sub

    Public Sub AtualizarAtiva(id As Integer)
        Dim setentadalotacao As Double
        ta.FillByID(dt, id)
        Me.lotacaomax = dt.Item(0).Item("LotaçãoMáxima")
        setentadalotacao = (lotacaomax * 70) / 100
        If dt.Item(0).Item("LotaçãoAtual") >= setentadalotacao Then
            ta.AtualizarAtiva(True, id)
        Else
            ta.AtualizarAtiva(False, id)
        End If
    End Sub

End Class

