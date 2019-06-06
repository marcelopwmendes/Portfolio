Public Class FormMensalidade

    Dim m As New Mensalidade
    Dim acao As Integer

    Private Sub MensalidadeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MensalidadeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_de_Dados_v2DataSet)
    End Sub


    Private Sub MensalidadeBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MensalidadeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_de_Dados_v2DataSet)

    End Sub

    Private Sub FormMensalidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Mensalidade' table. You can move, or remove it, as needed.
        Me.MensalidadeTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Mensalidade)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        acao = 1
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        IDTextBox.Text = Base_de_Dados_v2DataSet.Mensalidade.Rows.Count + 1
        NomeTextBox.Text = ""
        DescriçãoTextBox.Text = ""
        PreçoTextBox.Text = 0
        NomeTextBox.Enabled = True
        DescriçãoTextBox.Enabled = True
        PreçoTextBox.Enabled = True
        MensalidadeBindingNavigator.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        acao = 2
        Button2.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        NomeTextBox.Enabled = True
        DescriçãoTextBox.Enabled = True
        PreçoTextBox.Enabled = True
        MensalidadeBindingNavigator.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case MsgBox("Tem certeza que quer apagar esta Mensalidade ?", MsgBoxStyle.YesNo, "Apagar Mensalidade")
            Case MsgBoxResult.Yes
                If m.eliminar(IDTextBox.Text) > 0 Then
                    MsgBox("Mensalidade eliminada com sucesso", MsgBoxStyle.Information, "Sucesso")
                    FormMensalidade_Load(sender, e)
                Else
                    MsgBox("Mensalidade não foi eliminada", MsgBoxStyle.Critical, "Falha")
                End If
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As Integer
        If acao = 1 Then
            res = m.adicionar(NomeTextBox.Text, DescriçãoTextBox.Text, PreçoTextBox.Text, AtividadesComboBox.Text)
            If res > 0 Then
                MsgBox("Mensalidade inserida com sucesso", MsgBoxStyle.Information, "Sucesso")
            Else
                MsgBox("Mensalidade não foi inserida", MsgBoxStyle.Critical, "Falha")
            End If

        ElseIf acao = 2 Then
            res = m.editar(IDTextBox.Text, NomeTextBox.Text, DescriçãoTextBox.Text, PreçoTextBox.Text, AtividadesComboBox.Text)
            If res > 0 Then
                MsgBox("Mensalidade editada com sucesso", MsgBoxStyle.Information, "Sucesso")
                m.nome = NomeTextBox.Text
                m.descicao = DescriçãoTextBox.Text
                m.preco = PreçoTextBox.Text
            Else
                MsgBox("Mensalidade não foi editada", MsgBoxStyle.Critical, "Falha")
            End If
        End If
        FormMensalidade_Load(sender, e)
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = False
        NomeTextBox.Enabled = False
        DescriçãoTextBox.Enabled = False
        PreçoTextBox.Enabled = False
        MensalidadeBindingNavigator.Enabled = True
    End Sub
End Class