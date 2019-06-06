Public Class FormFuncionario
    Dim f As New Funcionario()
    Dim acao As Integer = 0

    Private Sub FuncionarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FuncionarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_de_Dados_v2DataSet)

    End Sub

    Public Sub FormFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Funcionario' table. You can move, or remove it, as needed.
        Me.FuncionarioTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Funcionario)
        FormUtils.form_center(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            SalárioTextBox.Visible = True
        Else
            SalárioTextBox.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        acao = 1
        CheckBox1.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        IDTextBox.Enabled = False
        IDTextBox.Text = Base_de_Dados_v2DataSet.Funcionario.Rows.Count + 1
        NomeTextBox.Enabled = True
        NomeTextBox.Text = ""
        SalárioTextBox.Visible = True
        SalárioTextBox.Enabled = True
        SalárioTextBox.Text = 0
        Data_NascDateTimePicker.Enabled = True
        Data_NascDateTimePicker.Value = "25-1-1974"
        PassWordTextBox.Enabled = True
        PassWordTextBox.Visible = True
        PassWordTextBox.Text = " "
        PassWordLabel.Visible = True
        PassWordLabel.Text = "Password: "
        FuncionarioBindingNavigator.Enabled = False
        'TextBox1.Visible = True
        'TextBox2.Visible = True
        'Label1.Visible = True
        'Label2.Visible = True
        'BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        acao = 2
        Button2.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        Button6.Visible = True
        NomeTextBox.Enabled = True
        SalárioTextBox.Visible = True
        SalárioTextBox.Enabled = True
        Data_NascDateTimePicker.Enabled = True
        PassWordLabel.Visible = True
        PassWordTextBox.Enabled = False
        PassWordTextBox.Visible = True
        CheckBox2.Visible = True
        CheckBox1.Visible = False
        FuncionarioBindingNavigator.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        acao = 3
        Select Case MsgBox("Tem certeza que quer apagar este Funcionário ?", MsgBoxStyle.YesNo, "Apagar Funcionário")
            Case MsgBoxResult.Yes
                If f.Apagar(IDTextBox.Text) > 0 Then
                    MsgBox("Funcionário eliminado com sucesso", MsgBoxStyle.Information, "Sucesso")
                    FormFuncionario_Load(sender, e)
                Else
                    MsgBox("Funcionário não foi eliminado", MsgBoxStyle.Critical, "Falha")
                End If
        End Select

        'Button2.Visible = False
        'Button3.Visible = False
        'Button5.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If acao = 1 Then
            Dim res As Integer
            res = f.Adicionar(NomeTextBox.Text, SalárioTextBox.Text, Data_NascDateTimePicker.Value, PassWordTextBox.Text)
            If res > 0 Then
                MsgBox("Funcionário adicionado com sucesso", MsgBoxStyle.Information, "Sucesso")
            Else
                MsgBox("Funcionário não foi adicionado", MsgBoxStyle.Critical, "Falha")
            End If
            Try
                Me.FuncionarioTableAdapter.Update(Base_de_Dados_v2DataSet.Funcionario)
            Catch ex As Exception
                MsgBox("Algo deu errado", MsgBoxStyle.Critical, "Erro")
            End Try

        ElseIf acao = 2 Then

            If TextBox1.Text = "" Then
                f.Editar(IDTextBox.Text, NomeTextBox.Text, SalárioTextBox.Text, Data_NascDateTimePicker.Value, PassWordTextBox.Text)
            ElseIf TextBox1.Text <> "" And TextBox1.Text = TextBox2.Text Then
                f.AlterarPW(IDTextBox.Text, TextBox1.Text)
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If
            End If

        FormFuncionario_Load(sender, e)
        CheckBox1.Visible = True
        CheckBox2.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = False
        Button6.Visible = False
        IDTextBox.Enabled = False
        NomeTextBox.Enabled = False
        SalárioTextBox.Enabled = False
        SalárioTextBox.Visible = False
        Data_NascDateTimePicker.Enabled = False
        PassWordTextBox.Enabled = False
        PassWordTextBox.Visible = False
        PassWordLabel.Visible = False
        PassWordLabel.Text = "Password Atual: "
        Label1.Visible = False
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        FuncionarioBindingNavigator.Enabled = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            PassWordTextBox.UseSystemPasswordChar = True
        ElseIf CheckBox2.Checked = True Then
            PassWordTextBox.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Alterar PW
        Label1.Visible = True
        Label2.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
    End Sub
End Class