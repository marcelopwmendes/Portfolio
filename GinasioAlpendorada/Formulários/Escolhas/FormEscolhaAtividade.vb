Public Class FormEscolhaAtividade
    Public val As Integer

    Private Sub FormEscolhaAtividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.DiaSemana' table. You can move, or remove it, as needed.
        Me.DiaSemanaTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.DiaSemana)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Monitor' table. You can move, or remove it, as needed.
        Me.MonitorTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Monitor)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Atividade' table. You can move, or remove it, as needed.
        Me.AtividadeTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Atividade)
        FormUtils.formatDataGrid(AtividadeDataGridView)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("Tem certeza que deseja inscrever este cliente nesta atividade ?", MsgBoxStyle.YesNo, "Validação")) = vbYes Then
            Dim at As New Atividade
            If at.lotacaodisponivel(ID_AtividadeTextBox.Text) = True Then
                Me.Close()
                val = 1
            Else
                MsgBox("Atividade Lotada", MsgBoxStyle.Information, "Lotada")
            End If
        Else
            val = 0
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        val = 0
        Me.Close()
    End Sub

    Private Sub AtividadeDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles AtividadeDataGridView.CellFormatting
        FormUtils.formatDataGrid(AtividadeDataGridView)
    End Sub
End Class