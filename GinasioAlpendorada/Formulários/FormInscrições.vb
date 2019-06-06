Public Class FormInscrições
    Private Sub FormInscrições_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Cliente)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Atividade' table. You can move, or remove it, as needed.
        Me.AtividadeTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Atividade)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Inscrição' table. You can move, or remove it, as needed.
        Me.InscriçãoTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Inscrição)
        FormUtils.formatDataGrid(InscriçãoDataGridView)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InscriçãoBindingSource.Filter = "ID_Cliente = " & TextBox1.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        InscriçãoBindingSource.Filter = "ID_Atividade = " & TextBox2.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        InscriçãoBindingSource.Filter = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As New Inscricao
        i.eliminar(IDTextBox.Text)
        FormInscrições_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub InscriçãoDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles InscriçãoDataGridView.CellFormatting
        FormUtils.formatDataGrid(InscriçãoDataGridView)
    End Sub
End Class