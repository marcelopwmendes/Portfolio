Public Class FormFaturas
    Dim preco As Double
    Dim mdt As New Base_de_Dados_v2DataSet.MensalidadeDataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New FormEscolhaCliente
        c.ShowDialog()
        ID_ClienteTextBox.Text = c.ID_ClienteTextBox.Text
        NomeTextBox.Text = c.NomeTextBox.Text
        NIFTextBox.Text = c.NIFTextBox.Text
        EstudanteCheckBox.Checked = c.EstudanteCheckBox.Checked
        MensalidadeTableAdapter.FillByID(mdt, c.ID_MensalidadeComboBox.SelectedValue)
        ID_MensalidadeComboBox.Text = mdt.Item(0).Item("Nome")
        PreçoTextBox.Text = mdt.Item(0).Item("Preço")
        preco = PreçoTextBox.Text
        'preco = PreçoTextBox.Text
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub FormFaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Mensalidade' table. You can move, or remove it, as needed.
        Me.MensalidadeTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Mensalidade)
        FormUtils.form_center(Me)
        FormUtils.form_Resize(Me)
        '  MensalidadeBindingSource.Filter = "ID=-1"

        ID_MensalidadeComboBox.Text = ""
        PreçoTextBox.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As Integer
        Dim x As Integer
        Try
            p = InputBox("Insira o desconto", "Desconto", 0)
        Catch ex As Exception
            x = 0
        End Try
        If x <> 0 Then
            TextBox1.Visible = True
            TextBox1.Text = PreçoTextBox.Text - PreçoTextBox.Text * (p / 100)
            Label1.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fat As New Fatura
        Dim res As Integer
        fat.clienteId = ID_ClienteTextBox.Text
        fat.outrosdetalhes = ComboBox1.Text
        If TextBox1.Text = "" Then
            fat.montante = PreçoTextBox.Text
        Else
            fat.montante = TextBox1.Text
        End If
        res = fat.adicionar()

        If res = 1 Then
            MsgBox("Fatura inserida com sucesso", MsgBoxStyle.Information, "Sucesso")
            Dim c As New Cliente
            c.AtualizarMensalidade(ID_ClienteTextBox.Text, True, ComboBox1.Text)
            Dim f As New FaturaReport
            f.ShowDialog()
        Else
            MsgBox("Fatura não foi inserida", MsgBoxStyle.Critical, "Erro")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        PreçoTextBox.Text = preco * CDbl(ComboBox1.Text)
    End Sub
End Class