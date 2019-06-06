Public Class FormPrincipal

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        'ListarClientesReport.ShowDialog()
        Dim f As New FormCliente
        f.ShowDialog()
    End Sub

    Private Sub BSair_Click(sender As Object, e As EventArgs) Handles BSair.Click
        Application.Exit()
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim log_in As New LogIn
        log_in.ShowDialog()
        If log_in.i = 2 Then
            Me.Close()
        Else
            LNomeFuncionario.Text = My.Settings.Nome_funcionario
            FormUtils.form_center(Me)
            Dim c As New Cliente
            c.MensalidadeAtrasada()
            Label2.Text = c.contarclientes
        End If
    End Sub

    Private Sub BFuncionarios_Click(sender As Object, e As EventArgs) Handles BFuncionarios.Click
        Dim f As New FormFuncionario
        f.ShowDialog()
    End Sub

    Private Sub BFaturas_Click(sender As Object, e As EventArgs) Handles BFaturas.Click
        Dim f As New FormFaturas
        f.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DataHora.Text = Now
    End Sub

    Private Sub BDar_Entrada_Click(sender As Object, e As EventArgs) Handles BDar_Entrada.Click
        'Try
        '    Dim id As String
        '    id = InputBox("Qual o ID do Cliente", "Entrada")
        '    If id <> "" Then
        '        Dim c As New Cliente
        '        c.DentroFora(id, True)
        '        Label2.Text = Label2.Text + 1
        '    Else

        '    End If
        'Catch ex As InvalidCastException
        '    MsgBox("O ID deve ser um número inteiro", MsgBoxStyle.Critical, "Erro")
        'Catch ex As Exception
        '    MsgBox("O Cliente não existe", MsgBoxStyle.Critical, "Erro")
        'End Try
        Dim entrar As New FormEntrarSair
        entrar.qtd = Label2.Text
        entrar.BDar_Saida.Visible = False
        entrar.filtro = "Ativo = TRUE AND DentroGinasio = FALSE"
        entrar.ClienteBindingSource.Filter = entrar.filtro
        entrar.ShowDialog()
        Label2.Text = entrar.qtd
    End Sub

    Private Sub BDar_Saida_Click(sender As Object, e As EventArgs) Handles BDar_Saida.Click
        'Try
        '    Dim id As String
        '    id = InputBox("Qual o ID do Cliente", "Saída")
        '    If id <> "" Then
        '        Dim c As New Cliente
        '        c.DentroFora(id, False)
        '        Label2.Text = Label2.Text - 1
        '    Else

        '    End If
        'Catch ex As InvalidCastException
        '    MsgBox("O ID deve ser um número inteiro", MsgBoxStyle.Critical, "Erro")
        'Catch ex As Exception
        '    MsgBox("O Cliente não existe", MsgBoxStyle.Critical, "Erro")
        'End Try
        Dim entrar As New FormEntrarSair
        entrar.qtd = Label2.Text
        entrar.BDar_Entrada.Visible = False
        entrar.filtro = "Ativo = TRUE AND DentroGinasio = TRUE"
        entrar.ClienteBindingSource.Filter = entrar.filtro
        entrar.ShowDialog()
        Label2.Text = entrar.qtd
    End Sub

    Private Sub BMonitores_Click(sender As Object, e As EventArgs) Handles BMonitores.Click
        Dim m As New FormMonitor
        m.ShowDialog()
    End Sub

    Private Sub BOfertas_Click(sender As Object, e As EventArgs) Handles BOfertas.Click
        Dim m As New FormMensalidade
        m.ShowDialog()
    End Sub

    Private Sub BAtividades_Click(sender As Object, e As EventArgs) Handles BAtividades.Click
        Dim a As New FormAtividades
        a.ShowDialog()
    End Sub

    Private Sub BAulas_Click(sender As Object, e As EventArgs) Handles BAulas.Click
        Dim i As New FormMarcarAulas
        i.ShowDialog()
    End Sub

    Private Sub BAtividadesDecorrer_Click(sender As Object, e As EventArgs) Handles BAtividadesDecorrer.Click
        Dim x As New Atividade
        x.AtividadeAtiva()
        Dim vatv As New FormVerAtividades
        'vatv.GroupBox1.Enabled = False
        vatv.CheckBox1.Checked = True
        vatv.CheckBox2.Checked = True
        vatv.AtividadeBindingSource.Filter = "Ativa=TRUE AND ADecorrer=TRUE"
        vatv.ShowDialog()
    End Sub
End Class