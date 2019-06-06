Imports System.Data.OleDb
Public Class LogIn
    Public i As Integer
    Private Sub Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entrar.Click
        'Dim x As Integer
        'Try
        '    x = Me.FuncionarioTableAdapter.FillByID(Base_de_Dados_v2DataSet.Funcionario, UsernameTextBox.Text)
        '    If x = 0 Then
        '        MsgBox("Username Inválido", MsgBoxStyle.Critical, "Erro")
        '    Else
        '        'Dim v As Integer
        '        'v = Me.FuncionarioTableAdapter.FillByIDandPW(Base_de_Dados_v2DataSet.Funcionario, UsernameTextBox.Text, PasswordTextBox.Text)
        '        If Base_de_Dados_v2DataSet.Funcionario.Item(0).Item("PassWord").ToString() = PasswordTextBox.Text Then
        '            My.Settings.Nome_funcionario = Base_de_Dados_v2DataSet.Funcionario.Item(0).Item("Nome").ToString
        '            Me.Hide()
        '            MenuPrincipal.Show()
        '        Else
        '            MsgBox("Palavra passe incorreta", MsgBoxStyle.Critical, "Erro")
        '        End If
        '    End If
        'Catch ex As InvalidCastException
        '    MsgBox("O ID são caracteres numéricos", MsgBoxStyle.Critical, "Erro")
        'End Try

        Try
            Dim f As New Funcionario(UsernameTextBox.Text)
            If f.existe = True Then
                If f.password <> PasswordTextBox.Text Then
                    MsgBox("Password incorreta", MsgBoxStyle.Critical, "Erro")
                Else
                    My.Settings.Nome_funcionario = f.nome
                    Me.Close()
                End If
            Else
                MsgBox("Username Inválido", MsgBoxStyle.Critical, "Erro")
            End If
        Catch ex As InvalidCastException
            MsgBox("O ID são caracteres numéricos", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        i = 2
        Me.Close()
    End Sub
End Class
