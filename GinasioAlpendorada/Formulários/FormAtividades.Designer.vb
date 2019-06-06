<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAtividades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ID_AtividadeLabel As System.Windows.Forms.Label
        Dim ID_MonitorLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim LotaçãoMáximaLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim LotaçãoAtualLabel As System.Windows.Forms.Label
        Dim DiaDaSemanaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAtividades))
        Me.AtividadeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AtividadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_Dados_v2DataSet = New GinasioAlpendorada.Base_de_Dados_v2DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AtividadeTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.AtividadeTableAdapter()
        Me.TableAdapterManager = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager()
        Me.ID_AtividadeTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.LotaçãoMáximaTextBox = New System.Windows.Forms.TextBox()
        Me.LotaçãoAtualTextBox = New System.Windows.Forms.TextBox()
        Me.DiaDaSemanaComboBox = New System.Windows.Forms.ComboBox()
        Me.DiaSemanaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiaSemanaTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.DiaSemanaTableAdapter()
        Me.HoraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ID_MonitorComboBox = New System.Windows.Forms.ComboBox()
        Me.MonitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonitorTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MonitorTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        ID_AtividadeLabel = New System.Windows.Forms.Label()
        ID_MonitorLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        LotaçãoMáximaLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        LotaçãoAtualLabel = New System.Windows.Forms.Label()
        DiaDaSemanaLabel = New System.Windows.Forms.Label()
        CType(Me.AtividadeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AtividadeBindingNavigator.SuspendLayout()
        CType(Me.AtividadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaSemanaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_AtividadeLabel
        '
        ID_AtividadeLabel.AutoSize = True
        ID_AtividadeLabel.Location = New System.Drawing.Point(32, 61)
        ID_AtividadeLabel.Name = "ID_AtividadeLabel"
        ID_AtividadeLabel.Size = New System.Drawing.Size(72, 15)
        ID_AtividadeLabel.TabIndex = 74
        ID_AtividadeLabel.Text = "ID Atividade:"
        '
        'ID_MonitorLabel
        '
        ID_MonitorLabel.AutoSize = True
        ID_MonitorLabel.Location = New System.Drawing.Point(32, 88)
        ID_MonitorLabel.Name = "ID_MonitorLabel"
        ID_MonitorLabel.Size = New System.Drawing.Size(48, 15)
        ID_MonitorLabel.TabIndex = 76
        ID_MonitorLabel.Text = "Monitor:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(32, 115)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(40, 15)
        NomeLabel.TabIndex = 78
        NomeLabel.Text = "Nome:"
        '
        'LotaçãoMáximaLabel
        '
        LotaçãoMáximaLabel.AutoSize = True
        LotaçãoMáximaLabel.Location = New System.Drawing.Point(32, 142)
        LotaçãoMáximaLabel.Name = "LotaçãoMáximaLabel"
        LotaçãoMáximaLabel.Size = New System.Drawing.Size(91, 15)
        LotaçãoMáximaLabel.TabIndex = 80
        LotaçãoMáximaLabel.Text = "Lotação Máxima:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Location = New System.Drawing.Point(32, 170)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(34, 15)
        HoraLabel.TabIndex = 82
        HoraLabel.Text = "Hora:"
        '
        'LotaçãoAtualLabel
        '
        LotaçãoAtualLabel.AutoSize = True
        LotaçãoAtualLabel.Location = New System.Drawing.Point(32, 196)
        LotaçãoAtualLabel.Name = "LotaçãoAtualLabel"
        LotaçãoAtualLabel.Size = New System.Drawing.Size(76, 15)
        LotaçãoAtualLabel.TabIndex = 84
        LotaçãoAtualLabel.Text = "Lotação Atual:"
        '
        'DiaDaSemanaLabel
        '
        DiaDaSemanaLabel.AutoSize = True
        DiaDaSemanaLabel.Location = New System.Drawing.Point(32, 231)
        DiaDaSemanaLabel.Name = "DiaDaSemanaLabel"
        DiaDaSemanaLabel.Size = New System.Drawing.Size(87, 15)
        DiaDaSemanaLabel.TabIndex = 85
        DiaDaSemanaLabel.Text = "Dia Da Semana:"
        '
        'AtividadeBindingNavigator
        '
        Me.AtividadeBindingNavigator.AddNewItem = Nothing
        Me.AtividadeBindingNavigator.BindingSource = Me.AtividadeBindingSource
        Me.AtividadeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AtividadeBindingNavigator.DeleteItem = Nothing
        Me.AtividadeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.AtividadeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AtividadeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AtividadeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AtividadeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AtividadeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AtividadeBindingNavigator.Name = "AtividadeBindingNavigator"
        Me.AtividadeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AtividadeBindingNavigator.Size = New System.Drawing.Size(830, 25)
        Me.AtividadeBindingNavigator.TabIndex = 0
        Me.AtividadeBindingNavigator.Text = "BindingNavigator1"
        '
        'AtividadeBindingSource
        '
        Me.AtividadeBindingSource.DataMember = "Atividade"
        Me.AtividadeBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'Base_de_Dados_v2DataSet
        '
        Me.Base_de_Dados_v2DataSet.DataSetName = "Base_de_Dados_v2DataSet"
        Me.Base_de_Dados_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(266, 270)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 48)
        Me.Button5.TabIndex = 73
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ToolTip1.SetToolTip(Me.Button5, "Guardar")
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(212, 270)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 48)
        Me.Button4.TabIndex = 72
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ToolTip1.SetToolTip(Me.Button4, "Eliminar")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(158, 270)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 48)
        Me.Button3.TabIndex = 71
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ToolTip1.SetToolTip(Me.Button3, "Editar")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(104, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 70
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ToolTip1.SetToolTip(Me.Button2, "Novo")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(745, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 64)
        Me.Button1.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.Button1, "Voltar")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(411, 221)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 190)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'AtividadeTableAdapter
        '
        Me.AtividadeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AtividadeTableAdapter = Me.AtividadeTableAdapter
        Me.TableAdapterManager.AulaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.DiaSemanaTableAdapter = Nothing
        Me.TableAdapterManager.ExercicioTableAdapter = Nothing
        Me.TableAdapterManager.FaturaTableAdapter = Nothing
        Me.TableAdapterManager.FuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.InscriçãoTableAdapter = Nothing
        Me.TableAdapterManager.MensalidadeTableAdapter = Nothing
        Me.TableAdapterManager.MonitorTableAdapter = Nothing
        Me.TableAdapterManager.Plano_ExercicioTableAdapter = Nothing
        Me.TableAdapterManager.PlanoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ID_AtividadeTextBox
        '
        Me.ID_AtividadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "ID_Atividade", True))
        Me.ID_AtividadeTextBox.Enabled = False
        Me.ID_AtividadeTextBox.Location = New System.Drawing.Point(129, 58)
        Me.ID_AtividadeTextBox.Name = "ID_AtividadeTextBox"
        Me.ID_AtividadeTextBox.Size = New System.Drawing.Size(200, 21)
        Me.ID_AtividadeTextBox.TabIndex = 75
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(129, 112)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NomeTextBox.TabIndex = 79
        '
        'LotaçãoMáximaTextBox
        '
        Me.LotaçãoMáximaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "LotaçãoMáxima", True))
        Me.LotaçãoMáximaTextBox.Enabled = False
        Me.LotaçãoMáximaTextBox.Location = New System.Drawing.Point(129, 139)
        Me.LotaçãoMáximaTextBox.Name = "LotaçãoMáximaTextBox"
        Me.LotaçãoMáximaTextBox.Size = New System.Drawing.Size(200, 21)
        Me.LotaçãoMáximaTextBox.TabIndex = 81
        '
        'LotaçãoAtualTextBox
        '
        Me.LotaçãoAtualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "LotaçãoAtual", True))
        Me.LotaçãoAtualTextBox.Enabled = False
        Me.LotaçãoAtualTextBox.Location = New System.Drawing.Point(129, 193)
        Me.LotaçãoAtualTextBox.Name = "LotaçãoAtualTextBox"
        Me.LotaçãoAtualTextBox.Size = New System.Drawing.Size(200, 21)
        Me.LotaçãoAtualTextBox.TabIndex = 85
        '
        'DiaDaSemanaComboBox
        '
        Me.DiaDaSemanaComboBox.CausesValidation = False
        Me.DiaDaSemanaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AtividadeBindingSource, "DiaDaSemana", True))
        Me.DiaDaSemanaComboBox.DataSource = Me.DiaSemanaBindingSource
        Me.DiaDaSemanaComboBox.DisplayMember = "Descrição"
        Me.DiaDaSemanaComboBox.Enabled = False
        Me.DiaDaSemanaComboBox.FormattingEnabled = True
        Me.DiaDaSemanaComboBox.Location = New System.Drawing.Point(129, 223)
        Me.DiaDaSemanaComboBox.Name = "DiaDaSemanaComboBox"
        Me.DiaDaSemanaComboBox.Size = New System.Drawing.Size(200, 23)
        Me.DiaDaSemanaComboBox.TabIndex = 86
        Me.DiaDaSemanaComboBox.ValueMember = "ID"
        '
        'DiaSemanaBindingSource
        '
        Me.DiaSemanaBindingSource.DataMember = "DiaSemana"
        Me.DiaSemanaBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'DiaSemanaTableAdapter
        '
        Me.DiaSemanaTableAdapter.ClearBeforeFill = True
        '
        'HoraDateTimePicker
        '
        Me.HoraDateTimePicker.CustomFormat = "HH:mm"
        Me.HoraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AtividadeBindingSource, "Hora", True))
        Me.HoraDateTimePicker.Enabled = False
        Me.HoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HoraDateTimePicker.Location = New System.Drawing.Point(129, 166)
        Me.HoraDateTimePicker.Name = "HoraDateTimePicker"
        Me.HoraDateTimePicker.ShowUpDown = True
        Me.HoraDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.HoraDateTimePicker.TabIndex = 83
        '
        'ID_MonitorComboBox
        '
        Me.ID_MonitorComboBox.CausesValidation = False
        Me.ID_MonitorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AtividadeBindingSource, "ID_Monitor", True))
        Me.ID_MonitorComboBox.DataSource = Me.MonitorBindingSource
        Me.ID_MonitorComboBox.DisplayMember = "Nome"
        Me.ID_MonitorComboBox.Enabled = False
        Me.ID_MonitorComboBox.FormattingEnabled = True
        Me.ID_MonitorComboBox.Location = New System.Drawing.Point(129, 85)
        Me.ID_MonitorComboBox.Name = "ID_MonitorComboBox"
        Me.ID_MonitorComboBox.Size = New System.Drawing.Size(200, 23)
        Me.ID_MonitorComboBox.TabIndex = 88
        Me.ID_MonitorComboBox.ValueMember = "ID_Monitor"
        '
        'MonitorBindingSource
        '
        Me.MonitorBindingSource.DataMember = "Monitor"
        Me.MonitorBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'MonitorTableAdapter
        '
        Me.MonitorTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(613, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 31)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Área Atividade"
        '
        'ToolTip1
        '
        '
        'FormAtividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(830, 445)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ID_MonitorComboBox)
        Me.Controls.Add(DiaDaSemanaLabel)
        Me.Controls.Add(Me.DiaDaSemanaComboBox)
        Me.Controls.Add(ID_AtividadeLabel)
        Me.Controls.Add(Me.ID_AtividadeTextBox)
        Me.Controls.Add(ID_MonitorLabel)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(LotaçãoMáximaLabel)
        Me.Controls.Add(Me.LotaçãoMáximaTextBox)
        Me.Controls.Add(HoraLabel)
        Me.Controls.Add(Me.HoraDateTimePicker)
        Me.Controls.Add(LotaçãoAtualLabel)
        Me.Controls.Add(Me.LotaçãoAtualTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AtividadeBindingNavigator)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAtividades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAtividades"
        CType(Me.AtividadeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AtividadeBindingNavigator.ResumeLayout(False)
        Me.AtividadeBindingNavigator.PerformLayout()
        CType(Me.AtividadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaSemanaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Base_de_Dados_v2DataSet As GinasioAlpendorada.Base_de_Dados_v2DataSet
    Friend WithEvents AtividadeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AtividadeTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.AtividadeTableAdapter
    Friend WithEvents TableAdapterManager As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AtividadeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ID_AtividadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LotaçãoMáximaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LotaçãoAtualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiaDaSemanaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DiaSemanaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DiaSemanaTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.DiaSemanaTableAdapter
    Friend WithEvents HoraDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ID_MonitorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MonitorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonitorTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MonitorTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
