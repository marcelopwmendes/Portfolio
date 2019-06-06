Public Class Cliente
    Public ID, nif, mensalidade, plano As Integer
    Public peso, altura As Integer
    Public imc As Double
    Public nome, genero, morada As String
    Public dataNasc, dataMensal As Date
    Public ativo, paga, estudante, dentro As Boolean

    Public ds As New Base_de_Dados_v2DataSet
    Public dt As New Base_de_Dados_v2DataSet.ClienteDataTable
    Public ta As New Base_de_Dados_v2DataSetTableAdapters.ClienteTableAdapter

    Public Sub New()
        ta.Fill(dt)
    End Sub

    Public Function Adicionar(nome As String, datanasc As Date, peso As Integer, altura As Integer, nif As Integer, genero As String, morada As String, estudante As Boolean, mensalidade As Integer) As Integer
        Dim a As Integer
        Me.ID = dt.Rows.Count + 1
        Me.nome = nome
        Me.dataNasc = datanasc
        Me.peso = peso
        Me.altura = altura
        Me.nif = nif
        Me.genero = genero
        Me.ativo = True
        Me.paga = False
        Me.morada = morada
        Me.imc = (peso / (altura * altura)) * 10000
        Me.estudante = estudante
        Me.mensalidade = mensalidade
        Me.dataMensal = Now.Date
        Me.dentro = False
        If imc < 16 Then
            'Magreza Grave
            Me.plano = 1
        ElseIf imc >= 16 And imc < 17 Then
            'Magreza Moderada
            Me.plano = 2
        ElseIf imc >= 17 And imc < 18.5 Then
            'Magreza Leve
            Me.plano = 3
        ElseIf imc >= 18.5 And imc < 25 Then
            'Saudável
            Me.plano = 4
        ElseIf imc >= 25 And imc < 30 Then
            'Sobrepeso
            Me.plano = 5
        ElseIf imc >= 30 And imc < 35 Then
            'Obesidade Grau I
            Me.plano = 6
        ElseIf imc >= 35 And imc < 40 Then
            'Obesidade Grau II (Severa)
            Me.plano = 7
        ElseIf imc >= 40 Then
            'Obesidade Grau III (Mórbida)
            Me.plano = 8
        End If
        a = ta.Insert(Me.nome, Me.dataNasc, Me.peso, Me.altura, Me.nif, Me.genero, Me.ativo, Me.paga, Me.morada, Me.imc, Me.estudante, Me.dentro, Me.plano, Me.mensalidade, Me.dataMensal.Date)
        Return a
    End Function

    Public Function Editar(id As Integer, nome As String, datanasc As Date, peso As Integer, altura As Integer, nif As Integer, genero As String, morada As String, estudante As Boolean, plano As Integer, mensalidade As Integer) As Integer
        Dim a As Integer
        ta.FillByID(dt, id)
        Me.ID = id
        Me.imc = (peso / (altura * altura)) * 10000
        a = ta.Update(nome, datanasc, peso, altura, nif, genero, dt.Item(0).Item("Ativo"), dt.Item(0).Item("MensalidadePaga"), morada, Me.imc, estudante, dt.Item(0).Item("DentroGinasio"), plano, mensalidade, dt.Item(0).Item("Data_Mensalidade"), id, dt.Item(0).Item("Nome"), dt.Item(0).Item("Data_Nasc"), dt.Item(0).Item("Peso"), dt.Item(0).Item("altura"), dt.Item(0).Item("NIF"), dt.Item(0).Item("Género"), dt.Item(0).Item("Ativo"), dt.Item(0).Item("MensalidadePaga"), dt.Item(0).Item("Morada"), dt.Item(0).Item("IMC"), dt.Item(0).Item("Estudante"), dt.Item(0).Item("DentroGinasio"), dt.Item(0).Item("ID_Plano"), dt.Item(0).Item("ID_Mensalidade"), dt.Item(0).Item("Data_Mensalidade"))
        Return a
    End Function

    Public Function Apagar(id As Integer) As Integer
        ta.FillByID(dt, id)
        Apagar = ta.Delete(id, dt.Item(0).Item("Nome"), dt.Item(0).Item("Data_Nasc"), dt.Item(0).Item("Peso"), dt.Item(0).Item("Altura"), dt.Item(0).Item("NIF"), dt.Item(0).Item("Género"), dt.Item(0).Item("Ativo"), dt.Item(0).Item("MensalidadePaga"), dt.Item(0).Item("Morada"), dt.Item(0).Item("IMC"), dt.Item(0).Item("Estudante"), dt.Item(0).Item("DentroGinasio"), dt.Item(0).Item("ID_Plano"), dt.Item(0).Item("ID_Mensalidade"), dt.Item(0).Item("Data_Mensalidade"))
    End Function

    Public Function AtualizarMensalidade(id As Integer, t As Boolean, quantmeses As Integer) As Integer
        Dim tan As New Base_de_Dados_v2DataSetTableAdapters.ClienteTableAdapter
        ta.FillByID(dt, id)
        If t = True Then
            Dim novaData As Date
            novaData = Now
            novaData = DateAdd(DateInterval.Month, quantmeses, novaData)
            ta.AtivoInativo(True, id)
            AtualizarMensalidade = ta.AtualizarMensalidadePeloID(t, novaData, id)
        Else
            AtualizarMensalidade = ta.AtualizarMensalidadePeloID(t, dt.Item(0).Item("Data_Mensalidade"), id)
        End If

    End Function

    Public Function DentroFora(id As Integer, b As Boolean)
        DentroFora = ta.DentroFora(b, id)
    End Function

    Public Sub MensalidadeAtrasada()
        Dim datalimite As Date
        Dim item As Integer
        Dim ins As New Inscricao
        For i = 1 To dt.Rows.Count
            ta.Fill(dt)
            item = i - 1
            Me.ID = dt.Rows.Item(item).Item(0)
            Me.nome = dt.Rows.Item(item).Item("Nome")
            Me.dataMensal = dt.Rows.Item(item).Item("Data_Mensalidade")
            Me.ativo = dt.Rows.Item(item).Item("Ativo")
            datalimite = DateAdd(DateInterval.Day, 7, dataMensal.Date)
            If ativo = False Then
                For j = 1 To ins.dt.Rows.Count
                    If ins.dt.Rows.Item(j - 1).Item("ID_Cliente") = ID Then
                        ins.eliminar(ID)
                    End If
                        Next 
            End If
            If Now.Date > dataMensal.Date Then
                AtualizarMensalidade(ID, False, 0)
            End If
            If Now.Date > datalimite Then
                ta.AtivoInativo(False, ID)

                For j = 1 To ins.dt.Rows.Count
                    If ins.dt.Rows.Item(j - 1).Item("ID_Cliente") = ID Then
                        ins.eliminar(ID)
                    End If
                Next
            End If
        Next

        'For i = 1 To dt.Rows.Count
        '    datalimite = DateAdd(DateInterval.Day, 7, dt.Rows.Item(i - 1).Item("Data_Mensalidade"))
        '    If Now.Date > dt.Rows.Item(i - 1).Item("Data_Mensalidade") Then
        '        AtualizarMensalidade(dt.Rows.Item(i - 1).Item("ID_Cliente"), False, 0)
        '    End If
        '    MsgBox(dt.Rows.Item(i - 1).Item("Data_Mensalidade"))
        '    If Now.Date > datalimite Then
        '        'Passaram 7 dias do dia de Pagamento - ClienteAtivo=False
        '        ta.AtivoInativo(False, dt.Rows.Item(i - 1).Item("ID_Cliente"))
        '        Dim ins As New Inscricao
        '        For j = 1 To ins.dt.Rows.Count
        '            If ins.dt.Rows.Item(j - 1).Item("ID_Cliente") = dt.Rows.Item(i - 1).Item("ID_Cliente") Then
        '                ins.eliminar(ins.dt.Rows.Item(j - 1).Item("ID_Cliente"))
        '            End If
        '        Next
        '    End If
        'Next
    End Sub

    Public Function contarclientes() As Integer
        ta.FillByDentroGinasio(dt, True)
        contarclientes = dt.Rows.Count
    End Function
End Class