Public Class Funcionario
    Public id As Integer
    Public nome, password As String
    Public salario As Decimal
    Public data_nasc As Date
    Public existe As Boolean
    Public ds As New Base_de_Dados_v2DataSet
    Public dt As New Base_de_Dados_v2DataSet.FuncionarioDataTable
    Public ta As New Base_de_Dados_v2DataSetTableAdapters.FuncionarioTableAdapter

    Public Sub New()

    End Sub

    Public Sub New(id As Integer)
        Dim x As Integer
        Me.id = id
        x = ta.FillByID(dt, id)
        If x = 1 Then
            existe = True
            Me.nome = dt.Item(0).Item("Nome")
            Me.salario = dt.Item(0).Item("Salário")
            Me.data_nasc = dt.Item(0).Item("Data_Nasc")
            Me.password = dt.Item(0).Item("PassWord")
        End If
    End Sub

    Public Function Adicionar(nome As String, salario As Decimal, data_nasc As Date, password As String) As Integer
        Dim a As Integer
        ta.Fill(dt)
        Me.id = dt.Rows.Count + 1
        Me.nome = nome
        Me.salario = salario
        Me.data_nasc = data_nasc
        Me.password = password
        a = ta.Insert(nome, salario, data_nasc, password)
        Return a
    End Function

    Public Sub Editar(id As Integer, nome As String, salario As Decimal, data_nasc As Date, password As String)
        Dim a As Integer
        ta.FillByID(dt, id)
        Me.id = id
        Me.nome = dt.Item(0).Item("Nome")
        Me.salario = dt.Item(0).Item("Salário")
        Me.data_nasc = dt.Item(0).Item("Data_Nasc")
        Me.password = dt.Item(0).Item("PassWord")
        a = ta.Update(nome, salario, data_nasc, password, id, Me.nome, Me.salario, Me.data_nasc, Me.password)
        If a > 0 Then
            MsgBox("Funcionário editado com sucesso", MsgBoxStyle.Information, "Sucesso")
            Me.nome = nome
            Me.salario = salario
            Me.data_nasc = data_nasc
            Me.password = password
        Else
            MsgBox("Funcionário não foi editado", MsgBoxStyle.Critical, "Falha")
        End If
        
    End Sub

    Public Sub AlterarPW(id As Integer, novapw As String)
        ta.FillByID(dt, id)
        Me.id = id
        Me.nome = dt.Item(0).Item("Nome")
        Me.salario = dt.Item(0).Item("Salário")
        Me.data_nasc = dt.Item(0).Item("Data_Nasc")
        Me.password = dt.Item(0).Item("PassWord")
        ta.Update(nome, salario, data_nasc, novapw, Me.id, nome, salario, data_nasc, password)
        Me.password = password
    End Sub

    Public Function Apagar(id As Integer) As Integer
        ta.FillByID(dt, id)
        Me.id = id
        Me.nome = dt.Item(0).Item("Nome")
        Me.salario = dt.Item(0).Item("Salário")
        Me.data_nasc = dt.Item(0).Item("Data_Nasc")
        Me.password = dt.Item(0).Item("PassWord")
        Apagar = ta.Delete(id, nome, salario, data_nasc, password)
    End Function

End Class
