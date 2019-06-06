Public Class FormCliente
    Dim acao As Integer

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Plano' table. You can move, or remove it, as needed.
        Me.PlanoTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Plano)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Mensalidade' table. You can move, or remove it, as needed.
        Me.MensalidadeTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Mensalidade)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Cliente)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If AtivoCheckBox.Checked = False Then
            MsgBox("O Cliente não se pode inscrever em nenhuma atividade porque se encontra inativo", MsgBoxStyle.Critical, "Erro")
        Else
            Dim ins As New Inscricao
            Dim mens As New Mensalidade
            If ins.NAtividades(ID_ClienteTextBox.Text) >= mens.obterNAtividades(ID_MensalidadeComboBox.SelectedValue) Then
                MsgBox("A mensalidade do Cliente não o permite se inscrever em mais atividades", MsgBoxStyle.Critical, "Erro")
            Else
                Dim a As New FormEscolhaAtividade
                a.ShowDialog()
                If a.val = 1 Then
                    Dim i As New Inscricao
                    Dim at As New Atividade
                    If i.adicionar(ID_ClienteTextBox.Text, a.ID_AtividadeTextBox.Text) > 0 Then
                        MsgBox("Inscrição feita com sucesso", MsgBoxStyle.Information, "Sucesso")
                        at.atualizarlotação(a.ID_AtividadeTextBox.Text, True)
                        at.AtualizarAtiva(a.ID_AtividadeTextBox.Text)
                    Else
                        MsgBox("Inscrição não foi realizada", MsgBoxStyle.Critical, "Falha")
                    End If
                Else
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        acao = 1
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = True

        ID_ClienteTextBox.Enabled = False
        ID_ClienteTextBox.Text = Base_de_Dados_v2DataSet.Cliente.Rows.Count + 1
        NomeTextBox.Enabled = True
        NomeTextBox.Text = ""
        Data_NascDateTimePicker.Enabled = True
        Data_NascDateTimePicker.Value = "14-11-1999"
        PesoTextBox.Enabled = True
        PesoTextBox.Text = ""
        AlturaTextBox.Enabled = True
        AlturaTextBox.Text = ""
        NIFTextBox.Enabled = True
        NIFTextBox.Text = ""
        GéneroTextBox.Enabled = True
        GéneroTextBox.Text = ""
        MoradaTextBox.Enabled = True
        MoradaTextBox.Text = ""
        EstudanteCheckBox.Enabled = True
        EstudanteCheckBox.Checked = False
        ID_MensalidadeComboBox.Enabled = True
        ID_MensalidadeComboBox.Text = ""

        ID_PlanoComboBox.Visible = False
        ID_PlanoLabel.Visible = False
        DentroGinasioCheckBox.Visible = False
        DentroGinasioLabel.Visible = False
        Data_MensalidadeTextBox.Visible = False
        Data_MensalidadeLabel.Visible = False
        IMCTextBox.Visible = False
        IMCLabel.Visible = False
        MensalidadePagaCheckBox.Visible = False
        MensalidadePagaLabel.Visible = False
        AtivoCheckBox.Visible = False
        AtivoLabel.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        acao = 2
        Button2.Visible = False
        Button4.Visible = False
        Button5.Visible = True

        NomeTextBox.Enabled = True
        Data_NascDateTimePicker.Enabled = True
        PesoTextBox.Enabled = True
        AlturaTextBox.Enabled = True
        NIFTextBox.Enabled = True
        GéneroTextBox.Enabled = True
        MoradaTextBox.Enabled = True
        EstudanteCheckBox.Enabled = True
        ID_MensalidadeComboBox.Enabled = True

        ID_PlanoComboBox.Visible = False
        ID_PlanoLabel.Visible = False
        DentroGinasioCheckBox.Visible = False
        DentroGinasioLabel.Visible = False
        Data_MensalidadeTextBox.Visible = False
        Data_MensalidadeLabel.Visible = False
        IMCTextBox.Visible = False
        IMCLabel.Visible = False
        MensalidadePagaCheckBox.Visible = False
        MensalidadePagaLabel.Visible = False
        AtivoCheckBox.Visible = False
        AtivoLabel.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim c As New Cliente
        Select Case MsgBox("Tem certeza que quer apagar este Cliente ?", MsgBoxStyle.YesNo, "Apagar Cliente")
            Case MsgBoxResult.Yes
                If c.Apagar(ID_ClienteTextBox.Text) > 0 Then
                    MsgBox("Cliente eliminado com sucesso", MsgBoxStyle.Information, "Sucesso")
                    FormCliente_Load(sender, e)
                Else
                    MsgBox("Cliente não foi eliminado", MsgBoxStyle.Critical, "Falha")
                End If
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim c As New Cliente
        Dim x As Integer
        If acao = 1 Then
            x = c.Adicionar(NomeTextBox.Text, Data_NascDateTimePicker.Value, PesoTextBox.Text, AlturaTextBox.Text, NIFTextBox.Text, GéneroTextBox.Text, MoradaTextBox.Text, EstudanteCheckBox.Checked, ID_MensalidadeComboBox.SelectedValue)
            If x > 0 Then
                MsgBox("Cliente adicionado com sucesso", MsgBoxStyle.Information, "Sucesso")
            Else
                MsgBox("Cliente não foi adicionado", MsgBoxStyle.Critical, "Falha")
            End If
        ElseIf acao = 2 Then
            x = c.Editar(ID_ClienteTextBox.Text, NomeTextBox.Text, Data_NascDateTimePicker.Value, PesoTextBox.Text, AlturaTextBox.Text, NIFTextBox.Text, GéneroTextBox.Text, MoradaTextBox.Text, EstudanteCheckBox.Checked, ID_PlanoComboBox.SelectedValue, ID_MensalidadeComboBox.SelectedValue)
            If x > 0 Then
                MsgBox("Cliente editado com sucesso", MsgBoxStyle.Information, "Sucesso")
            Else
                MsgBox("Cliente não foi editado", MsgBoxStyle.Critical, "Falha")
            End If
        End If
        FormCliente_Load(sender, e)
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = False
        NomeTextBox.Enabled = False
        Data_NascDateTimePicker.Enabled = False
        PesoTextBox.Enabled = False
        AlturaTextBox.Enabled = False
        NIFTextBox.Enabled = False
        GéneroTextBox.Enabled = False
        MoradaTextBox.Enabled = False
        EstudanteCheckBox.Enabled = False
        ID_MensalidadeComboBox.Enabled = False

        ID_PlanoComboBox.Visible = True
        ID_PlanoLabel.Visible = True
        DentroGinasioCheckBox.Visible = True
        DentroGinasioLabel.Visible = True
        Data_MensalidadeTextBox.Visible = True
        Data_MensalidadeLabel.Visible = True
        IMCTextBox.Visible = True
        IMCLabel.Visible = True
        MensalidadePagaCheckBox.Visible = True
        MensalidadePagaLabel.Visible = True
        AtivoCheckBox.Visible = True
        AtivoLabel.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim i As New FormInscrições
        i.InscriçãoBindingSource.Filter = "ID_Cliente =" & ID_ClienteTextBox.Text
        i.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim f As New FormClientesAtrasadosOuInativos
        f.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim f As New ListarClientesReport
        f.ShowDialog()
    End Sub
End Class