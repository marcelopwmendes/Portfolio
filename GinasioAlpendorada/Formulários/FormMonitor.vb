Public Class FormMonitor
    Dim m As New Monitor
    Dim acao As Integer

    Private Sub MonitorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MonitorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_de_Dados_v2DataSet)

    End Sub

    Private Sub FormMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Base_de_Dados_v2DataSet.Monitor' table. You can move, or remove it, as needed.
        Me.MonitorTableAdapter.Fill(Me.Base_de_Dados_v2DataSet.Monitor)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        acao = 1
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        ID_MonitorTextBox.Text = Base_de_Dados_v2DataSet.Monitor.Rows.Count + 1
        NomeTextBox.Text = ""
        Data_NascDateTimePicker.Value = "1/1/1999"
        SalárioTextBox.Text = 0
        NIFTextBox.Text = ""
        MoradaTextBox.Text = ""
        GéneroTextBox.Text = "Masculino/Feminino"
        NomeTextBox.Enabled = True
        Data_NascDateTimePicker.Enabled = True
        SalárioTextBox.Enabled = True
        NIFTextBox.Enabled = True
        MoradaTextBox.Enabled = True
        GéneroTextBox.Enabled = True
        MonitorBindingNavigator.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        acao = 2
        Button2.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        NomeTextBox.Enabled = True
        Data_NascDateTimePicker.Enabled = True
        SalárioTextBox.Enabled = True
        NIFTextBox.Enabled = True
        MoradaTextBox.Enabled = True
        GéneroTextBox.Enabled = True
        MonitorBindingNavigator.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case MsgBox("Tem certeza que quer apagar este Monitor ?", MsgBoxStyle.YesNo, "Apagar Monitor")
            Case MsgBoxResult.Yes
                If m.eliminar(ID_MonitorTextBox.Text) > 0 Then
                    MsgBox("Monitor eliminado com sucesso", MsgBoxStyle.Information, "Sucesso")
                    FormMonitor_Load(sender, e)
                Else
                    MsgBox("Monitor não foi eliminado", MsgBoxStyle.Critical, "Falha")
                End If
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As Integer
        If acao = 1 Then
            res = m.adicionar(NomeTextBox.Text, Data_NascDateTimePicker.Value, SalárioTextBox.Text, NIFTextBox.Text, MoradaTextBox.Text, GéneroTextBox.Text)
            If res > 0 Then
                MsgBox("Monitor adicionado com sucesso", MsgBoxStyle.Information, "Sucesso")
            Else
                MsgBox("Monitor não foi adicionado", MsgBoxStyle.Critical, "Falha")
            End If
            Try
                Me.MonitorTableAdapter.Update(Base_de_Dados_v2DataSet)
            Catch ex As Exception
                MsgBox("Algo deu errado", MsgBoxStyle.Critical, "Erro")
            End Try

        ElseIf acao = 2 Then
            res = m.editar(ID_MonitorTextBox.Text, NomeTextBox.Text, Data_NascDateTimePicker.Value, SalárioTextBox.Text, NIFTextBox.Text, MoradaTextBox.Text, GéneroTextBox.Text)
            If res > 0 Then
                MsgBox("Monitor editado com sucesso", MsgBoxStyle.Information, "Sucesso")
                m.nome = NomeTextBox.Text
                m.data_nasc = Data_NascDateTimePicker.Value
                m.salario = SalárioTextBox.Text
                m.nif = NIFTextBox.Text
                m.morada = MoradaTextBox.Text
                m.genero = GéneroTextBox.Text
            Else
                MsgBox("Monitor não foi editado", MsgBoxStyle.Critical, "Falha")
            End If
        End If
        FormMonitor_Load(sender, e)
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = False
        NomeTextBox.Enabled = False
        Data_NascDateTimePicker.Enabled = False
        SalárioTextBox.Enabled = False
        NIFTextBox.Enabled = False
        MoradaTextBox.Enabled = False
        GéneroTextBox.Enabled = False
        MonitorBindingNavigator.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Visible = False
        Me.Close()
    End Sub
End Class