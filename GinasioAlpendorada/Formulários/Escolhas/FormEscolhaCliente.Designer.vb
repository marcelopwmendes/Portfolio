<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEscolhaCliente
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
        Dim ID_ClienteLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim MensalidadePagaLabel As System.Windows.Forms.Label
        Dim EstudanteLabel As System.Windows.Forms.Label
        Dim AtivoLabel As System.Windows.Forms.Label
        Dim ID_MensalidadeLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEscolhaCliente))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Base_de_Dados_v2DataSet = New GinasioAlpendorada.Base_de_Dados_v2DataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager()
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MensalidadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.MensalidadePagaCheckBox = New System.Windows.Forms.CheckBox()
        Me.EstudanteCheckBox = New System.Windows.Forms.CheckBox()
        Me.AtivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ID_MensalidadeComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MensalidadeTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MensalidadeTableAdapter()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        MensalidadePagaLabel = New System.Windows.Forms.Label()
        EstudanteLabel = New System.Windows.Forms.Label()
        AtivoLabel = New System.Windows.Forms.Label()
        ID_MensalidadeLabel1 = New System.Windows.Forms.Label()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MensalidadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_ClienteLabel.ForeColor = System.Drawing.Color.White
        ID_ClienteLabel.Location = New System.Drawing.Point(49, 60)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(62, 15)
        ID_ClienteLabel.TabIndex = 33
        ID_ClienteLabel.Text = "Nº Cliente:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.ForeColor = System.Drawing.Color.White
        NomeLabel.Location = New System.Drawing.Point(49, 92)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(42, 15)
        NomeLabel.TabIndex = 34
        NomeLabel.Text = "Nome:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NIFLabel.ForeColor = System.Drawing.Color.White
        NIFLabel.Location = New System.Drawing.Point(49, 122)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(29, 15)
        NIFLabel.TabIndex = 35
        NIFLabel.Text = "NIF:"
        '
        'MensalidadePagaLabel
        '
        MensalidadePagaLabel.AutoSize = True
        MensalidadePagaLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MensalidadePagaLabel.ForeColor = System.Drawing.Color.White
        MensalidadePagaLabel.Location = New System.Drawing.Point(49, 177)
        MensalidadePagaLabel.Name = "MensalidadePagaLabel"
        MensalidadePagaLabel.Size = New System.Drawing.Size(38, 15)
        MensalidadePagaLabel.TabIndex = 38
        MensalidadePagaLabel.Text = "Pago:"
        '
        'EstudanteLabel
        '
        EstudanteLabel.AutoSize = True
        EstudanteLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstudanteLabel.ForeColor = System.Drawing.Color.White
        EstudanteLabel.Location = New System.Drawing.Point(49, 204)
        EstudanteLabel.Name = "EstudanteLabel"
        EstudanteLabel.Size = New System.Drawing.Size(62, 15)
        EstudanteLabel.TabIndex = 39
        EstudanteLabel.Text = "Estudante:"
        '
        'AtivoLabel
        '
        AtivoLabel.AutoSize = True
        AtivoLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AtivoLabel.ForeColor = System.Drawing.Color.White
        AtivoLabel.Location = New System.Drawing.Point(49, 152)
        AtivoLabel.Name = "AtivoLabel"
        AtivoLabel.Size = New System.Drawing.Size(39, 15)
        AtivoLabel.TabIndex = 40
        AtivoLabel.Text = "Ativo:"
        '
        'ID_MensalidadeLabel1
        '
        ID_MensalidadeLabel1.AutoSize = True
        ID_MensalidadeLabel1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_MensalidadeLabel1.ForeColor = System.Drawing.Color.White
        ID_MensalidadeLabel1.Location = New System.Drawing.Point(49, 233)
        ID_MensalidadeLabel1.Name = "ID_MensalidadeLabel1"
        ID_MensalidadeLabel1.Size = New System.Drawing.Size(79, 15)
        ID_MensalidadeLabel1.TabIndex = 41
        ID_MensalidadeLabel1.Text = "Mensalidade:"
        '
        'Base_de_Dados_v2DataSet
        '
        Me.Base_de_Dados_v2DataSet.DataSetName = "Base_de_Dados_v2DataSet"
        Me.Base_de_Dados_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AtividadeTableAdapter = Nothing
        Me.TableAdapterManager.AulaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
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
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Nothing
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Nothing
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(830, 25)
        Me.ClienteBindingNavigator.TabIndex = 0
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
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
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(31, 258)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(759, 142)
        Me.ClienteDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Cliente"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NIF"
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn6.HeaderText = "NIF"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Ativo"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.NullValue = False
        Me.DataGridViewCheckBoxColumn1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewCheckBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Ativo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "MensalidadePaga"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle13.NullValue = False
        Me.DataGridViewCheckBoxColumn2.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewCheckBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewCheckBoxColumn2.HeaderText = "MensalidadePaga"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Estudante"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle14.NullValue = False
        Me.DataGridViewCheckBoxColumn3.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewCheckBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Estudante"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID_Mensalidade"
        Me.DataGridViewTextBoxColumn11.DataSource = Me.MensalidadeBindingSource
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn11.DisplayMember = "Nome"
        Me.DataGridViewTextBoxColumn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn11.HeaderText = "Mensalidade"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn11.ValueMember = "ID"
        '
        'MensalidadeBindingSource
        '
        Me.MensalidadeBindingSource.DataMember = "Mensalidade"
        Me.MensalidadeBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Data_Mensalidade"
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn12.HeaderText = "Data da Mensalidade"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'ID_ClienteTextBox
        '
        Me.ID_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ID_Cliente", True))
        Me.ID_ClienteTextBox.Location = New System.Drawing.Point(137, 56)
        Me.ID_ClienteTextBox.Name = "ID_ClienteTextBox"
        Me.ID_ClienteTextBox.Size = New System.Drawing.Size(116, 22)
        Me.ID_ClienteTextBox.TabIndex = 34
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(137, 89)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(116, 22)
        Me.NomeTextBox.TabIndex = 35
        '
        'NIFTextBox
        '
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "NIF", True))
        Me.NIFTextBox.Location = New System.Drawing.Point(137, 119)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(116, 22)
        Me.NIFTextBox.TabIndex = 36
        '
        'MensalidadePagaCheckBox
        '
        Me.MensalidadePagaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClienteBindingSource, "MensalidadePaga", True))
        Me.MensalidadePagaCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MensalidadePagaCheckBox.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensalidadePagaCheckBox.ForeColor = System.Drawing.Color.White
        Me.MensalidadePagaCheckBox.Location = New System.Drawing.Point(139, 171)
        Me.MensalidadePagaCheckBox.Name = "MensalidadePagaCheckBox"
        Me.MensalidadePagaCheckBox.Size = New System.Drawing.Size(121, 28)
        Me.MensalidadePagaCheckBox.TabIndex = 39
        Me.MensalidadePagaCheckBox.UseVisualStyleBackColor = True
        '
        'EstudanteCheckBox
        '
        Me.EstudanteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClienteBindingSource, "Estudante", True))
        Me.EstudanteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstudanteCheckBox.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstudanteCheckBox.ForeColor = System.Drawing.Color.White
        Me.EstudanteCheckBox.Location = New System.Drawing.Point(139, 198)
        Me.EstudanteCheckBox.Name = "EstudanteCheckBox"
        Me.EstudanteCheckBox.Size = New System.Drawing.Size(121, 28)
        Me.EstudanteCheckBox.TabIndex = 40
        Me.EstudanteCheckBox.UseVisualStyleBackColor = True
        '
        'AtivoCheckBox
        '
        Me.AtivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClienteBindingSource, "Ativo", True))
        Me.AtivoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AtivoCheckBox.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtivoCheckBox.ForeColor = System.Drawing.Color.White
        Me.AtivoCheckBox.Location = New System.Drawing.Point(139, 146)
        Me.AtivoCheckBox.Name = "AtivoCheckBox"
        Me.AtivoCheckBox.Size = New System.Drawing.Size(121, 28)
        Me.AtivoCheckBox.TabIndex = 41
        Me.AtivoCheckBox.UseVisualStyleBackColor = True
        '
        'ID_MensalidadeComboBox
        '
        Me.ID_MensalidadeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteBindingSource, "ID_Mensalidade", True))
        Me.ID_MensalidadeComboBox.DataSource = Me.MensalidadeBindingSource
        Me.ID_MensalidadeComboBox.DisplayMember = "Nome"
        Me.ID_MensalidadeComboBox.FormattingEnabled = True
        Me.ID_MensalidadeComboBox.Location = New System.Drawing.Point(137, 229)
        Me.ID_MensalidadeComboBox.Name = "ID_MensalidadeComboBox"
        Me.ID_MensalidadeComboBox.Size = New System.Drawing.Size(140, 23)
        Me.ID_MensalidadeComboBox.TabIndex = 42
        Me.ID_MensalidadeComboBox.ValueMember = "ID"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(286, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 66)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Escolher Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(131, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 28)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Procurar por ID"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(488, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 159)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(6, 118)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(288, 28)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "Mostrar todos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(7, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(116, 22)
        Me.TextBox4.TabIndex = 50
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(131, 84)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 28)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Procurar por NIF"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(7, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 22)
        Me.TextBox2.TabIndex = 48
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(131, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 28)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Procurar por Nome"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 22)
        Me.TextBox1.TabIndex = 45
        '
        'MensalidadeTableAdapter
        '
        Me.MensalidadeTableAdapter.ClearBeforeFill = True
        '
        'FormEscolhaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(830, 440)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ID_MensalidadeLabel1)
        Me.Controls.Add(Me.ID_MensalidadeComboBox)
        Me.Controls.Add(AtivoLabel)
        Me.Controls.Add(Me.AtivoCheckBox)
        Me.Controls.Add(EstudanteLabel)
        Me.Controls.Add(Me.EstudanteCheckBox)
        Me.Controls.Add(MensalidadePagaLabel)
        Me.Controls.Add(Me.MensalidadePagaCheckBox)
        Me.Controls.Add(NIFLabel)
        Me.Controls.Add(Me.NIFTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(ID_ClienteLabel)
        Me.Controls.Add(Me.ID_ClienteTextBox)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEscolhaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MensalidadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Base_de_Dados_v2DataSet As GinasioAlpendorada.Base_de_Dados_v2DataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClienteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ID_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NIFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MensalidadePagaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EstudanteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AtivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ID_MensalidadeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MensalidadeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MensalidadeTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MensalidadeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
