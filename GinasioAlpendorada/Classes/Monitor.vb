Public Class Monitor
    Public id, nif As Integer
    Public nome, morada, genero As String
    Public data_nasc As Date
    Public salario As Decimal
    Public ds As New Base_de_Dados_v2DataSet
    Public dt As New Base_de_Dados_v2DataSet.MonitorDataTable
    Public ta As New Base_de_Dados_v2DataSetTableAdapters.MonitorTableAdapter

    Public Sub New()

    End Sub

    Public Function adicionar(nome As String, data_nasc As Date, salario As Decimal, nif As Integer, morada As String, genero As String) As Integer
        ta.Fill(dt)
        Me.id = dt.Rows.Count + 1
        Me.nome = nome
        Me.data_nasc = data_nasc
        Me.salario = salario
        Me.nif = nif
        Me.morada = morada
        Me.genero = genero
        adicionar = ta.Insert(nome, data_nasc, salario, nif, morada, genero)


    End Function

    Public Function editar(id As Integer, nome As String, data_nasc As Date, salario As Decimal, nif As Integer, morada As String, genero As String)
        ta.FillByID(dt, id)
        Me.id = id
        Me.nome = dt.Item(0).Item("Nome")
        Me.data_nasc = dt.Item(0).Item("Data_Nasc")
        Me.salario = dt.Item(0).Item("Salário")
        Me.nif = dt.Item(0).Item("NIF")
        Me.morada = dt.Item(0).Item("Morada")
        Me.genero = dt.Item(0).Item("Género")
        editar = ta.Update(nome, data_nasc, salario, nif, morada, genero, id, Me.nome, Me.data_nasc, Me.salario, Me.nif, Me.morada, Me.genero)
        
    End Function

    Public Function eliminar(id As Integer) As Integer
        ta.FillByID(dt, id)
        Me.nome = dt.Item(0).Item("Nome")
        Me.data_nasc = dt.Item(0).Item("Data_Nasc")
        Me.salario = dt.Item(0).Item("Salário")
        Me.nif = dt.Item(0).Item("NIF")
        Me.morada = dt.Item(0).Item("Morada")
        Me.genero = dt.Item(0).Item("Género")
        eliminar = ta.Delete(id, nome, data_nasc, salario, nif, morada, genero)
    End Function

End Class
