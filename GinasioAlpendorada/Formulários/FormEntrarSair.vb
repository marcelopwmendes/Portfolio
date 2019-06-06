Public Class FormEntrarSair
    Friend filtro As String
    Friend qtd As Integer
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_de_Dados_v2DataSet)

    End Sub

    Private Sub FormEntrarSair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Cliente)
        FormUtils.formatDataGrid(ClienteDataGridView)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClienteBindingSource.Filter = filtro & " AND ID_Cliente = " & TextBox1.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClienteBindingSource.Filter = filtro & " AND Nome LIKE '" & TextBox2.Text & "'"
    End Sub

    Private Sub ClienteDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ClienteDataGridView.CellFormatting
        FormUtils.formatDataGrid(ClienteDataGridView)
    End Sub

    Private Sub BDar_Entrada_Click(sender As Object, e As EventArgs) Handles BDar_Entrada.Click
        Dim c As New Cliente
        If c.DentroFora(ID_ClienteTextBox.Text, True) > 0 Then
            qtd = qtd + 1
            FormEntrarSair_Load(sender, e)
        Else
            MsgBox("Nao foi possivel o cliente dar entrada", MsgBoxStyle.Critical, "Erro")
        End If
    End Sub

    Private Sub BDar_Saida_Click(sender As Object, e As EventArgs) Handles BDar_Saida.Click
        Dim c As New Cliente
        If c.DentroFora(ID_ClienteTextBox.Text, False) > 0 Then
            qtd = qtd - 1
            FormEntrarSair_Load(sender, e)
        Else
            MsgBox("Nao foi possivel o cliente dar saida", MsgBoxStyle.Critical, "Erro")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class