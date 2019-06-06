<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEscolhaAtividade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEscolhaAtividade))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Base_de_Dados_v2DataSet = New GinasioAlpendorada.Base_de_Dados_v2DataSet()
        Me.AtividadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtividadeTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.AtividadeTableAdapter()
        Me.TableAdapterManager = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager()
        Me.MonitorTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MonitorTableAdapter()
        Me.AtividadeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MonitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AtividadeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DiaSemanaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_AtividadeTextBox = New System.Windows.Forms.TextBox()
        Me.ID_MonitorComboBox = New System.Windows.Forms.ComboBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.LotaçãoMáximaTextBox = New System.Windows.Forms.TextBox()
        Me.LotaçãoAtualTextBox = New System.Windows.Forms.TextBox()
        Me.DiaDaSemanaComboBox = New System.Windows.Forms.ComboBox()
        Me.DiaSemanaTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.DiaSemanaTableAdapter()
        Me.HoraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        ID_AtividadeLabel = New System.Windows.Forms.Label()
        ID_MonitorLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        LotaçãoMáximaLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        LotaçãoAtualLabel = New System.Windows.Forms.Label()
        DiaDaSemanaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtividadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtividadeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AtividadeBindingNavigator.SuspendLayout()
        CType(Me.MonitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtividadeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaSemanaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_AtividadeLabel
        '
        ID_AtividadeLabel.AutoSize = True
        ID_AtividadeLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_AtividadeLabel.ForeColor = System.Drawing.SystemColors.Control
        ID_AtividadeLabel.Location = New System.Drawing.Point(26, 43)
        ID_AtividadeLabel.Name = "ID_AtividadeLabel"
        ID_AtividadeLabel.Size = New System.Drawing.Size(72, 15)
        ID_AtividadeLabel.TabIndex = 67
        ID_AtividadeLabel.Text = "Nº Atividade:"
        '
        'ID_MonitorLabel
        '
        ID_MonitorLabel.AutoSize = True
        ID_MonitorLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_MonitorLabel.ForeColor = System.Drawing.SystemColors.Control
        ID_MonitorLabel.Location = New System.Drawing.Point(26, 69)
        ID_MonitorLabel.Name = "ID_MonitorLabel"
        ID_MonitorLabel.Size = New System.Drawing.Size(48, 15)
        ID_MonitorLabel.TabIndex = 69
        ID_MonitorLabel.Text = "Monitor:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.ForeColor = System.Drawing.SystemColors.Control
        NomeLabel.Location = New System.Drawing.Point(26, 96)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(40, 15)
        NomeLabel.TabIndex = 71
        NomeLabel.Text = "Nome:"
        '
        'LotaçãoMáximaLabel
        '
        LotaçãoMáximaLabel.AutoSize = True
        LotaçãoMáximaLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LotaçãoMáximaLabel.ForeColor = System.Drawing.SystemColors.Control
        LotaçãoMáximaLabel.Location = New System.Drawing.Point(26, 122)
        LotaçãoMáximaLabel.Name = "LotaçãoMáximaLabel"
        LotaçãoMáximaLabel.Size = New System.Drawing.Size(91, 15)
        LotaçãoMáximaLabel.TabIndex = 73
        LotaçãoMáximaLabel.Text = "Lotação Máxima:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HoraLabel.ForeColor = System.Drawing.SystemColors.Control
        HoraLabel.Location = New System.Drawing.Point(26, 148)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(34, 15)
        HoraLabel.TabIndex = 75
        HoraLabel.Text = "Hora:"
        '
        'LotaçãoAtualLabel
        '
        LotaçãoAtualLabel.AutoSize = True
        LotaçãoAtualLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LotaçãoAtualLabel.ForeColor = System.Drawing.SystemColors.Control
        LotaçãoAtualLabel.Location = New System.Drawing.Point(26, 174)
        LotaçãoAtualLabel.Name = "LotaçãoAtualLabel"
        LotaçãoAtualLabel.Size = New System.Drawing.Size(76, 15)
        LotaçãoAtualLabel.TabIndex = 77
        LotaçãoAtualLabel.Text = "Lotação Atual:"
        '
        'DiaDaSemanaLabel
        '
        DiaDaSemanaLabel.AutoSize = True
        DiaDaSemanaLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiaDaSemanaLabel.ForeColor = System.Drawing.SystemColors.Control
        DiaDaSemanaLabel.Location = New System.Drawing.Point(26, 200)
        DiaDaSemanaLabel.Name = "DiaDaSemanaLabel"
        DiaDaSemanaLabel.Size = New System.Drawing.Size(87, 15)
        DiaDaSemanaLabel.TabIndex = 79
        DiaDaSemanaLabel.Text = "Dia Da Semana:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(393, 224)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 190)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Base_de_Dados_v2DataSet
        '
        Me.Base_de_Dados_v2DataSet.DataSetName = "Base_de_Dados_v2DataSet"
        Me.Base_de_Dados_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AtividadeBindingSource
        '
        Me.AtividadeBindingSource.DataMember = "Atividade"
        Me.AtividadeBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
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
        Me.TableAdapterManager.MonitorTableAdapter = Me.MonitorTableAdapter
        Me.TableAdapterManager.Plano_ExercicioTableAdapter = Nothing
        Me.TableAdapterManager.PlanoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MonitorTableAdapter
        '
        Me.MonitorTableAdapter.ClearBeforeFill = True
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
        Me.AtividadeBindingNavigator.TabIndex = 57
        Me.AtividadeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
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
        'MonitorBindingSource
        '
        Me.MonitorBindingSource.DataMember = "Monitor"
        Me.MonitorBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(373, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 33)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Escolher Atividade"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AtividadeDataGridView
        '
        Me.AtividadeDataGridView.AllowUserToAddRows = False
        Me.AtividadeDataGridView.AllowUserToDeleteRows = False
        Me.AtividadeDataGridView.AutoGenerateColumns = False
        Me.AtividadeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AtividadeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4})
        Me.AtividadeDataGridView.DataSource = Me.AtividadeBindingSource
        Me.AtividadeDataGridView.Location = New System.Drawing.Point(12, 251)
        Me.AtividadeDataGridView.Name = "AtividadeDataGridView"
        Me.AtividadeDataGridView.ReadOnly = True
        Me.AtividadeDataGridView.Size = New System.Drawing.Size(744, 220)
        Me.AtividadeDataGridView.TabIndex = 67
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Atividade"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nº Atividade"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Monitor"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.MonitorBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Nome"
        Me.DataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn2.HeaderText = "Monitor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "ID_Monitor"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Hora"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.AtividadeBindingSource
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.DisplayMember = "Hora"
        Me.DataGridViewTextBoxColumn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn6.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "Hora"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DiaDaSemana"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.DiaSemanaBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "Descrição"
        Me.DataGridViewTextBoxColumn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn8.HeaderText = "Dia Da Semana"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "ID"
        '
        'DiaSemanaBindingSource
        '
        Me.DiaSemanaBindingSource.DataMember = "DiaSemana"
        Me.DiaSemanaBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LotaçãoAtual"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Lotação Atual"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LotaçãoMáxima"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lotação Máxima"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'ID_AtividadeTextBox
        '
        Me.ID_AtividadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "ID_Atividade", True))
        Me.ID_AtividadeTextBox.Enabled = False
        Me.ID_AtividadeTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_AtividadeTextBox.Location = New System.Drawing.Point(120, 40)
        Me.ID_AtividadeTextBox.Name = "ID_AtividadeTextBox"
        Me.ID_AtividadeTextBox.Size = New System.Drawing.Size(121, 21)
        Me.ID_AtividadeTextBox.TabIndex = 68
        '
        'ID_MonitorComboBox
        '
        Me.ID_MonitorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AtividadeBindingSource, "ID_Monitor", True))
        Me.ID_MonitorComboBox.DataSource = Me.MonitorBindingSource
        Me.ID_MonitorComboBox.DisplayMember = "Nome"
        Me.ID_MonitorComboBox.Enabled = False
        Me.ID_MonitorComboBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_MonitorComboBox.FormattingEnabled = True
        Me.ID_MonitorComboBox.Location = New System.Drawing.Point(120, 66)
        Me.ID_MonitorComboBox.Name = "ID_MonitorComboBox"
        Me.ID_MonitorComboBox.Size = New System.Drawing.Size(121, 23)
        Me.ID_MonitorComboBox.TabIndex = 70
        Me.ID_MonitorComboBox.ValueMember = "ID_Monitor"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(120, 93)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(121, 21)
        Me.NomeTextBox.TabIndex = 72
        '
        'LotaçãoMáximaTextBox
        '
        Me.LotaçãoMáximaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "LotaçãoMáxima", True))
        Me.LotaçãoMáximaTextBox.Enabled = False
        Me.LotaçãoMáximaTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LotaçãoMáximaTextBox.Location = New System.Drawing.Point(120, 119)
        Me.LotaçãoMáximaTextBox.Name = "LotaçãoMáximaTextBox"
        Me.LotaçãoMáximaTextBox.Size = New System.Drawing.Size(121, 21)
        Me.LotaçãoMáximaTextBox.TabIndex = 74
        '
        'LotaçãoAtualTextBox
        '
        Me.LotaçãoAtualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtividadeBindingSource, "LotaçãoAtual", True))
        Me.LotaçãoAtualTextBox.Enabled = False
        Me.LotaçãoAtualTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LotaçãoAtualTextBox.Location = New System.Drawing.Point(120, 171)
        Me.LotaçãoAtualTextBox.Name = "LotaçãoAtualTextBox"
        Me.LotaçãoAtualTextBox.Size = New System.Drawing.Size(121, 21)
        Me.LotaçãoAtualTextBox.TabIndex = 78
        '
        'DiaDaSemanaComboBox
        '
        Me.DiaDaSemanaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AtividadeBindingSource, "DiaDaSemana", True))
        Me.DiaDaSemanaComboBox.DataSource = Me.DiaSemanaBindingSource
        Me.DiaDaSemanaComboBox.DisplayMember = "Descrição"
        Me.DiaDaSemanaComboBox.Enabled = False
        Me.DiaDaSemanaComboBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiaDaSemanaComboBox.FormattingEnabled = True
        Me.DiaDaSemanaComboBox.Location = New System.Drawing.Point(120, 197)
        Me.DiaDaSemanaComboBox.Name = "DiaDaSemanaComboBox"
        Me.DiaDaSemanaComboBox.Size = New System.Drawing.Size(121, 23)
        Me.DiaDaSemanaComboBox.TabIndex = 80
        Me.DiaDaSemanaComboBox.ValueMember = "ID"
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
        Me.HoraDateTimePicker.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HoraDateTimePicker.Location = New System.Drawing.Point(120, 145)
        Me.HoraDateTimePicker.Name = "HoraDateTimePicker"
        Me.HoraDateTimePicker.ShowUpDown = True
        Me.HoraDateTimePicker.Size = New System.Drawing.Size(121, 21)
        Me.HoraDateTimePicker.TabIndex = 81
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(373, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 33)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(638, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 31)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Fazer Inscrição"
        '
        'FormEscolhaAtividade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(830, 516)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.HoraDateTimePicker)
        Me.Controls.Add(ID_AtividadeLabel)
        Me.Controls.Add(Me.ID_AtividadeTextBox)
        Me.Controls.Add(ID_MonitorLabel)
        Me.Controls.Add(Me.ID_MonitorComboBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(LotaçãoMáximaLabel)
        Me.Controls.Add(Me.LotaçãoMáximaTextBox)
        Me.Controls.Add(HoraLabel)
        Me.Controls.Add(LotaçãoAtualLabel)
        Me.Controls.Add(Me.LotaçãoAtualTextBox)
        Me.Controls.Add(DiaDaSemanaLabel)
        Me.Controls.Add(Me.DiaDaSemanaComboBox)
        Me.Controls.Add(Me.AtividadeDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AtividadeBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEscolhaAtividade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEscolhaAtividade"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtividadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtividadeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AtividadeBindingNavigator.ResumeLayout(False)
        Me.AtividadeBindingNavigator.PerformLayout()
        CType(Me.MonitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtividadeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaSemanaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MonitorTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MonitorTableAdapter
    Friend WithEvents MonitorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AtividadeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ID_AtividadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_MonitorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LotaçãoMáximaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LotaçãoAtualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiaDaSemanaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DiaSemanaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DiaSemanaTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.DiaSemanaTableAdapter
    Friend WithEvents HoraDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
