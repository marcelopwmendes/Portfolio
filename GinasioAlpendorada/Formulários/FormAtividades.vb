Public Class FormAtividades
    Dim a As New Atividade
    Dim acao As Integer
    Private Sub AtividadeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AtividadeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_de_Dados_v2DataSet)

    End Sub

    Private Sub FormAtividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Monitor' table. You can move, or remove it, as needed.
        Me.MonitorTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Monitor)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.DiaSemana' table. You can move, or remove it, as needed.
        Me.DiaSemanaTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.DiaSemana)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Atividade' table. You can move, or remove it, as needed.
        Me.AtividadeTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Atividade)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        acao = 1
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        ID_AtividadeTextBox.Text = Base_de_Dados_v2DataSet.Atividade.Rows.Count + 1
        ID_MonitorComboBox.Enabled = True
        NomeTextBox.Enabled = True
        LotaçãoMáximaTextBox.Enabled = True
        HoraDateTimePicker.Enabled = True
        DiaDaSemanaComboBox.Enabled = True
        AtividadeBindingNavigator.Enabled = False
        ID_MonitorComboBox.Text = ""
        NomeTextBox.Text = ""
        LotaçãoMáximaTextBox.Text = ""
        HoraDateTimePicker.Text = "00:00"
        DiaDaSemanaComboBox.Text = ""
        LotaçãoAtualTextBox.Text = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        acao = 2
        Button2.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        ID_MonitorComboBox.Enabled = True
        NomeTextBox.Enabled = True
        LotaçãoMáximaTextBox.Enabled = True
        HoraDateTimePicker.Enabled = True
        DiaDaSemanaComboBox.Enabled = True
        AtividadeBindingNavigator.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case MsgBox("Tem certeza que quer apagar esta Atividade ?", MsgBoxStyle.YesNo, "Apagar Atividade")
            Case MsgBoxResult.Yes
                If a.eliminar(ID_AtividadeTextBox.Text) > 0 Then
                    MsgBox("Atividade eliminada com sucesso", MsgBoxStyle.Information, "Sucesso")
                    FormAtividades_Load(sender, e)
                Else
                    MsgBox("Atividade não foi eliminada", MsgBoxStyle.Critical, "Falha")
                End If
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As Integer

        If acao = 1 Then
            res = a.adicionar(ID_MonitorComboBox.SelectedValue, LotaçãoMáximaTextBox.Text, NomeTextBox.Text, DiaDaSemanaComboBox.SelectedValue, FormatDateTime(HoraDateTimePicker.Value, DateFormat.ShortTime))
            If res > 0 Then
                MsgBox("Atividade adicionada com sucesso", MsgBoxStyle.Information, "Sucesso")
            Else
                MsgBox("Atividade não foi adicionada", MsgBoxStyle.Critical, "Falha")
            End If

        ElseIf acao = 2 Then
            res = a.editar(ID_AtividadeTextBox.Text, ID_MonitorComboBox.SelectedValue, NomeTextBox.Text, LotaçãoMáximaTextBox.Text, FormatDateTime(HoraDateTimePicker.Value, DateFormat.ShortTime), DiaDaSemanaComboBox.SelectedValue)
            If res > 0 Then
                MsgBox("Atividade editada com sucesso", MsgBoxStyle.Information, "Sucesso")
                a.monitor = ID_MonitorComboBox.SelectedValue
                a.lotacaomax = LotaçãoMáximaTextBox.Text
                a.hora = FormatDateTime(HoraDateTimePicker.Value, DateFormat.ShortTime)
                a.nome = NomeTextBox.Text
                a.diasemana = DiaDaSemanaComboBox.SelectedValue
            Else
                MsgBox("Atividade não foi editada", MsgBoxStyle.Critical, "Falha")
            End If
        End If
        Button2.Visible = True
        Button4.Visible = True
        Button5.Visible = False
        ID_MonitorComboBox.Enabled = False
        NomeTextBox.Enabled = False
        LotaçãoMáximaTextBox.Enabled = False
        HoraDateTimePicker.Enabled = False
        DiaDaSemanaComboBox.Enabled = False
        AtividadeBindingNavigator.Enabled = True
        FormAtividades_Load(sender, e)
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class