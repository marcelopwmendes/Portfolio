Public Class FormClientesAtrasadosOuInativos

    Private Sub FormClientesAtrasadosOuInativos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Mensalidade' table. You can move, or remove it, as needed.
        Me.MensalidadeTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Mensalidade)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Cliente)
        FormUtils.formatDataGrid(ClienteDataGridView)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ClienteBindingSource.Filter = "MensalidadePaga = False AND Ativo = TRUE"
        Label1.Text = "Mensalidades Atrasadas"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ClienteBindingSource.Filter = "Ativo = False"
        Label1.Text = "Clientes Inativos"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ClienteDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ClienteDataGridView.CellFormatting
        FormUtils.formatDataGrid(ClienteDataGridView)
    End Sub
End Class