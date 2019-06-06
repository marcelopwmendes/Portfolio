Public Class VerAulas

    Private Sub AulaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AulaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_de_Dados_v2DataSet)

    End Sub

    Private Sub VerAulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Monitor' table. You can move, or remove it, as needed.
        Me.MonitorTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Monitor)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Cliente)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Aula' table. You can move, or remove it, as needed.
        Me.AulaTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Aula)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim data As Date
        data = DateTimePicker1.Value.Date
        AulaBindingSource.Filter = "Data = '" & data & "'"
        If data >= Today Or AulaBindingSource.Filter = "" Then
            Button4.Visible = True
        Else
            Button4.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AulaBindingSource.Filter = ""
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As New Aula
        Dim hi, hf, d As Date
        Dim c, m As Integer
        Try
            hi = AulaDataGridView.SelectedRows.Item(0).Cells.Item(0).Value
            hf = AulaDataGridView.SelectedRows.Item(0).Cells.Item(1).Value
            d = AulaDataGridView.SelectedRows.Item(0).Cells.Item(5).Value
            c = AulaDataGridView.SelectedRows.Item(0).Cells.Item(3).Value
            m = AulaDataGridView.SelectedRows.Item(0).Cells.Item(4).Value
            If d >= Today Or (d = Today And Now < hi) Then
                If a.eliminar(hi, hf, c, m, d) = 1 Then
                    MsgBox("Aula cancelada com sucesso", MsgBoxStyle.Information, "Sucesso")
                    VerAulas_Load(sender, e)
                Else
                    MsgBox("Aula não foi cancelada", MsgBoxStyle.Critical, "Erro")
                End If
            Else
                MsgBox("Data da aula já foi ultrapassada", MsgBoxStyle.Exclamation, "Erro")

            End If
        Catch ex As Exception
            MsgBox("Selecione uma linha válida da aula que pretende eliminar", MsgBoxStyle.Information, "Informação")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class