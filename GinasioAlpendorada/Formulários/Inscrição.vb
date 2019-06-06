Public Class Inscrição
    Private Sub Inscrição_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New FormEscolhaCliente
        c.ShowDialog()
        ID_ClienteTextBox.Text = c.ID_ClienteTextBox.Text
        NomeTextBox.Text = c.NomeTextBox.Text
        NIFTextBox.Text = c.NIFTextBox.Text
        EstudanteCheckBox.Checked = c.EstudanteCheckBox.Checked
        ID_MensalidadeComboBox.SelectedValue = c.ID_MensalidadeComboBox.SelectedValue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As New FormEscolhaAtividade
        a.ShowDialog()
        IDAtividade.Text = a.ID_AtividadeTextBox.Text
        TextBox2.Text = a.NomeTextBox.Text
        TextBox3.Text = a.ID_MonitorComboBox.SelectedValue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       
    End Sub
End Class