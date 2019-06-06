Public Class FormMarcarAulas
    Dim id As Integer
    Dim idmonitor As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FormMarcarAulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Cliente)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Monitor' table. You can move, or remove it, as needed.
        ' Me.MonitorTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Monitor)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Aula' table. You can move, or remove it, as needed.
        Me.AulaTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Aula)
        DataDateTimePicker.MinDate = Today
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim intervalo As Integer
        intervalo = ComboBox1.Text
        Hora_FimDateTimePicker.Value = DateAdd(DateInterval.Hour, intervalo, Hora_InicioDateTimePicker.Value)
        PrecoTextBox.Text = 2 * intervalo
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New FormEscolhaCliente
        f.ShowDialog()
        TextBox1.Text = f.NomeTextBox.Text
        id = f.ID_ClienteTextBox.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim va As New VerAulas
        Dim data As Date
        data = DataDateTimePicker.Value.Date
        va.AulaBindingSource.Filter = "Data = '" & data & "'"

        va.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As New Aula

        a.adicionar(FormatDateTime(Hora_InicioDateTimePicker.Value, DateFormat.ShortTime), FormatDateTime(Hora_FimDateTimePicker.Value, DateFormat.ShortTime), PrecoTextBox.Text, id, idmonitor, FormatDateTime(DataDateTimePicker.Value, DateFormat.ShortDate))
    End Sub

    Private Sub ID_MonitorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' MsgBox(ID_MonitorComboBox.SelectedValue)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim m As New FormMonitor
        m.Button6.Visible = True
        m.ShowDialog()
        TextBox2.Text = m.NomeTextBox.Text
        idmonitor = m.ID_MonitorTextBox.Text
    End Sub
End Class