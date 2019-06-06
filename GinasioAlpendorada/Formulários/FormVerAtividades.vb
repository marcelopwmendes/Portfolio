Public Class FormVerAtividades

    Private Sub FormVerAtividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.DiaSemana' table. You can move, or remove it, as needed.
        Me.DiaSemanaTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.DiaSemana)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Monitor' table. You can move, or remove it, as needed.
        Me.MonitorTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Monitor)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Atividade' table. You can move, or remove it, as needed.
        Me.AtividadeTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Atividade)
        FormUtils.formatDataGrid(AtividadeDataGridView)

        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "ID_Monitor =" & ComboBox2.SelectedValue & "AND Ativa=TRUE AND ADecorrer=TRUE"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then
            AtividadeBindingSource.Filter = "ID_Monitor =" & ComboBox2.SelectedValue & "AND Ativa=TRUE AND ADecorrer=FALSE"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "ID_Monitor =" & ComboBox2.SelectedValue & "AND Ativa=FALSE AND ADecorrer=TRUE"
        Else
            AtividadeBindingSource.Filter = "ID_Monitor =" & ComboBox2.SelectedValue
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "Nome LIKE'" & TextBox3.Text & "%' AND Ativa=TRUE AND ADecorrer=TRUE"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then
            AtividadeBindingSource.Filter = "Nome LIKE'" & TextBox3.Text & "%' AND Ativa=TRUE AND ADecorrer=FALSE"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "Nome LIKE'" & TextBox3.Text & "%' AND Ativa=FALSE AND ADecorrer=TRUE"
        Else
            AtividadeBindingSource.Filter = "Nome LIKE'" & TextBox3.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AtividadeBindingSource.Filter = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        FormUtils.formatDataGrid(AtividadeDataGridView)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "DiaDaSemana =" & ComboBox1.SelectedValue & "AND Ativa=TRUE AND ADecorrer=TRUE"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then
            AtividadeBindingSource.Filter = "DiaDaSemana =" & ComboBox1.SelectedValue & "AND Ativa=TRUE AND ADecorrer=FALSE"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "DiaDaSemana =" & ComboBox1.SelectedValue & "AND Ativa=FALSE AND ADecorrer=TRUE"
        Else
            AtividadeBindingSource.Filter = "DiaDaSemana =" & ComboBox1.SelectedValue
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "LotaçãoAtual = " & TextBox4.Text & "AND Ativa=TRUE AND ADecorrer=TRUE"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then
            AtividadeBindingSource.Filter = "LotaçãoAtual = " & TextBox4.Text & "AND Ativa=TRUE AND ADecorrer=FALSE"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "LotaçãoAtual = " & TextBox4.Text & "AND Ativa=FALSE AND ADecorrer=TRUE"
        Else
            AtividadeBindingSource.Filter = "LotaçãoAtual = " & TextBox4.Text
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "LotaçãoMáxima = " & TextBox6.Text & "AND Ativa=TRUE AND ADecorrer=TRUE"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then
            AtividadeBindingSource.Filter = "LotaçãoMáxima = " & TextBox6.Text & "AND Ativa=TRUE AND ADecorrer=FALSE"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "LotaçãoMáxima = " & TextBox6.Text & "AND Ativa=FALSE AND ADecorrer=TRUE"
        Else
            AtividadeBindingSource.Filter = "LotaçãoMáxima = " & TextBox6.Text
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "Ativa = TRUE AND ADecorrer=TRUE"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then
            AtividadeBindingSource.Filter = "Ativa = FALSE AND ADecorrer=TRUE"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then
            AtividadeBindingSource.Filter = "Ativa = TRUE AND ADecorrer=FALSE"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            AtividadeBindingSource.Filter = "Ativa = FALSE AND ADecorrer=FALSE"
        ElseIf CheckBox1.Checked = False Then
            AtividadeBindingSource.Filter = "Ativa=FALSE"
        Else
            AtividadeBindingSource.Filter = "Ativa=TRUE"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub AtividadeDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles AtividadeDataGridView.CellFormatting
        FormUtils.formatDataGrid(AtividadeDataGridView)
    End Sub

    Private Sub AtividadeDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles AtividadeDataGridView.CellValueChanged
        FormUtils.formatDataGrid(AtividadeDataGridView)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = True
            AtividadeBindingSource.Filter = "ADecorrer = TRUE AND Ativa=TRUE"
        Else
            CheckBox1.Checked = False
            AtividadeBindingSource.Filter = "ADecorrer = FALSE"
        End If

    End Sub
End Class