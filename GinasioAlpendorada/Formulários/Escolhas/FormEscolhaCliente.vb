Public Class FormEscolhaCliente

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_de_Dados_v2DataSet)

    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Mensalidade' table. You can move, or remove it, as needed.
        Me.MensalidadeTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Mensalidade)
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Cliente)
        FormUtils.formatDataGrid(ClienteDataGridView)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClienteBindingSource.Filter = "ID_Cliente = '" & TextBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClienteBindingSource.Filter = "Nome LIKE '%" & TextBox2.Text & "%'"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClienteBindingSource.Filter = "NIF = '" & TextBox4.Text & "'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClienteBindingSource.Filter = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ID_ClienteTextBox.Text <> "" And ID_ClienteTextBox.Text <> 0 Then
            Me.Close()
        Else
            MsgBox("Selecione um cliente", MsgBoxStyle.Critical, "Erro")
        End If
    End Sub
End Class