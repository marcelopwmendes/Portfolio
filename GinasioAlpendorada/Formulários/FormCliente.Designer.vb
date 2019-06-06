<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Dim Data_NascLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim AlturaLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim GéneroLabel As System.Windows.Forms.Label
        Dim MoradaLabel As System.Windows.Forms.Label
        Dim EstudanteLabel As System.Windows.Forms.Label
        Dim ID_MensalidadeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCliente))
        Me.AtivoLabel = New System.Windows.Forms.Label()
        Me.MensalidadePagaLabel = New System.Windows.Forms.Label()
        Me.IMCLabel = New System.Windows.Forms.Label()
        Me.DentroGinasioLabel = New System.Windows.Forms.Label()
        Me.ID_PlanoLabel = New System.Windows.Forms.Label()
        Me.Data_MensalidadeLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.Data_NascDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.AtivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.MensalidadePagaCheckBox = New System.Windows.Forms.CheckBox()
        Me.MoradaTextBox = New System.Windows.Forms.TextBox()
        Me.IMCTextBox = New System.Windows.Forms.TextBox()
        Me.EstudanteCheckBox = New System.Windows.Forms.CheckBox()
        Me.DentroGinasioCheckBox = New System.Windows.Forms.CheckBox()
        Me.ID_MensalidadeComboBox = New System.Windows.Forms.ComboBox()
        Me.MensalidadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_MensalidadeTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MensalidadeTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MensalidadeTableAdapter()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GéneroTextBox = New System.Windows.Forms.TextBox()
        Me.ID_PlanoComboBox = New System.Windows.Forms.ComboBox()
        Me.PlanoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanoTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.PlanoTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.AlturaTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Data_NascLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        AlturaLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        GéneroLabel = New System.Windows.Forms.Label()
        MoradaLabel = New System.Windows.Forms.Label()
        EstudanteLabel = New System.Windows.Forms.Label()
        ID_MensalidadeLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.MensalidadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_ClienteLabel.ForeColor = System.Drawing.Color.White
        ID_ClienteLabel.Location = New System.Drawing.Point(34, 53)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(59, 15)
        ID_ClienteLabel.TabIndex = 59
        ID_ClienteLabel.Text = "Nº Cliente:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.ForeColor = System.Drawing.Color.White
        NomeLabel.Location = New System.Drawing.Point(34, 79)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(40, 15)
        NomeLabel.TabIndex = 61
        NomeLabel.Text = "Nome:"
        '
        'Data_NascLabel
        '
        Data_NascLabel.AutoSize = True
        Data_NascLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_NascLabel.ForeColor = System.Drawing.Color.White
        Data_NascLabel.Location = New System.Drawing.Point(34, 106)
        Data_NascLabel.Name = "Data_NascLabel"
        Data_NascLabel.Size = New System.Drawing.Size(60, 15)
        Data_NascLabel.TabIndex = 63
        Data_NascLabel.Text = "Data Nasc:"
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PesoLabel.ForeColor = System.Drawing.Color.White
        PesoLabel.Location = New System.Drawing.Point(34, 131)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(33, 15)
        PesoLabel.TabIndex = 65
        PesoLabel.Text = "Peso:"
        '
        'AlturaLabel
        '
        AlturaLabel.AutoSize = True
        AlturaLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlturaLabel.ForeColor = System.Drawing.Color.White
        AlturaLabel.Location = New System.Drawing.Point(34, 157)
        AlturaLabel.Name = "AlturaLabel"
        AlturaLabel.Size = New System.Drawing.Size(40, 15)
        AlturaLabel.TabIndex = 67
        AlturaLabel.Text = "Altura:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NIFLabel.ForeColor = System.Drawing.Color.White
        NIFLabel.Location = New System.Drawing.Point(34, 183)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(28, 15)
        NIFLabel.TabIndex = 69
        NIFLabel.Text = "NIF:"
        '
        'GéneroLabel
        '
        GéneroLabel.AutoSize = True
        GéneroLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GéneroLabel.ForeColor = System.Drawing.Color.White
        GéneroLabel.Location = New System.Drawing.Point(34, 212)
        GéneroLabel.Name = "GéneroLabel"
        GéneroLabel.Size = New System.Drawing.Size(46, 15)
        GéneroLabel.TabIndex = 71
        GéneroLabel.Text = "Género:"
        '
        'MoradaLabel
        '
        MoradaLabel.AutoSize = True
        MoradaLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MoradaLabel.ForeColor = System.Drawing.Color.White
        MoradaLabel.Location = New System.Drawing.Point(34, 299)
        MoradaLabel.Name = "MoradaLabel"
        MoradaLabel.Size = New System.Drawing.Size(48, 15)
        MoradaLabel.TabIndex = 77
        MoradaLabel.Text = "Morada:"
        '
        'EstudanteLabel
        '
        EstudanteLabel.AutoSize = True
        EstudanteLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstudanteLabel.ForeColor = System.Drawing.Color.White
        EstudanteLabel.Location = New System.Drawing.Point(390, 57)
        EstudanteLabel.Name = "EstudanteLabel"
        EstudanteLabel.Size = New System.Drawing.Size(57, 15)
        EstudanteLabel.TabIndex = 81
        EstudanteLabel.Text = "Estudante:"
        '
        'ID_MensalidadeLabel
        '
        ID_MensalidadeLabel.AutoSize = True
        ID_MensalidadeLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_MensalidadeLabel.ForeColor = System.Drawing.Color.White
        ID_MensalidadeLabel.Location = New System.Drawing.Point(390, 141)
        ID_MensalidadeLabel.Name = "ID_MensalidadeLabel"
        ID_MensalidadeLabel.Size = New System.Drawing.Size(73, 15)
        ID_MensalidadeLabel.TabIndex = 87
        ID_MensalidadeLabel.Text = "Mensalidade:"
        '
        'AtivoLabel
        '
        Me.AtivoLabel.AutoSize = True
        Me.AtivoLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtivoLabel.ForeColor = System.Drawing.Color.White
        Me.AtivoLabel.Location = New System.Drawing.Point(34, 241)
        Me.AtivoLabel.Name = "AtivoLabel"
        Me.AtivoLabel.Size = New System.Drawing.Size(36, 15)
        Me.AtivoLabel.TabIndex = 73
        Me.AtivoLabel.Text = "Ativo:"
        '
        'MensalidadePagaLabel
        '
        Me.MensalidadePagaLabel.AutoSize = True
        Me.MensalidadePagaLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensalidadePagaLabel.ForeColor = System.Drawing.Color.White
        Me.MensalidadePagaLabel.Location = New System.Drawing.Point(34, 271)
        Me.MensalidadePagaLabel.Name = "MensalidadePagaLabel"
        Me.MensalidadePagaLabel.Size = New System.Drawing.Size(100, 15)
        Me.MensalidadePagaLabel.TabIndex = 75
        Me.MensalidadePagaLabel.Text = "Mensalidade Paga:"
        '
        'IMCLabel
        '
        Me.IMCLabel.AutoSize = True
        Me.IMCLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMCLabel.ForeColor = System.Drawing.Color.White
        Me.IMCLabel.Location = New System.Drawing.Point(34, 325)
        Me.IMCLabel.Name = "IMCLabel"
        Me.IMCLabel.Size = New System.Drawing.Size(31, 15)
        Me.IMCLabel.TabIndex = 79
        Me.IMCLabel.Text = "IMC:"
        '
        'DentroGinasioLabel
        '
        Me.DentroGinasioLabel.AutoSize = True
        Me.DentroGinasioLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DentroGinasioLabel.ForeColor = System.Drawing.Color.White
        Me.DentroGinasioLabel.Location = New System.Drawing.Point(390, 87)
        Me.DentroGinasioLabel.Name = "DentroGinasioLabel"
        Me.DentroGinasioLabel.Size = New System.Drawing.Size(83, 15)
        Me.DentroGinasioLabel.TabIndex = 83
        Me.DentroGinasioLabel.Text = "Dentro Ginasio:"
        '
        'ID_PlanoLabel
        '
        Me.ID_PlanoLabel.AutoSize = True
        Me.ID_PlanoLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_PlanoLabel.ForeColor = System.Drawing.Color.White
        Me.ID_PlanoLabel.Location = New System.Drawing.Point(390, 115)
        Me.ID_PlanoLabel.Name = "ID_PlanoLabel"
        Me.ID_PlanoLabel.Size = New System.Drawing.Size(40, 15)
        Me.ID_PlanoLabel.TabIndex = 85
        Me.ID_PlanoLabel.Text = "Saúde:"
        '
        'Data_MensalidadeLabel
        '
        Me.Data_MensalidadeLabel.AutoSize = True
        Me.Data_MensalidadeLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_MensalidadeLabel.ForeColor = System.Drawing.Color.White
        Me.Data_MensalidadeLabel.Location = New System.Drawing.Point(390, 168)
        Me.Data_MensalidadeLabel.Name = "Data_MensalidadeLabel"
        Me.Data_MensalidadeLabel.Size = New System.Drawing.Size(99, 15)
        Me.Data_MensalidadeLabel.TabIndex = 89
        Me.Data_MensalidadeLabel.Text = "Data Mensalidade:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(727, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 64)
        Me.Button1.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.Button1, "Voltar")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(393, 224)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 190)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
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
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(838, 25)
        Me.ClienteBindingNavigator.TabIndex = 59
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
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
        'ID_ClienteTextBox
        '
        Me.ID_ClienteTextBox.CausesValidation = False
        Me.ID_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ID_Cliente", True))
        Me.ID_ClienteTextBox.Enabled = False
        Me.ID_ClienteTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_ClienteTextBox.Location = New System.Drawing.Point(138, 50)
        Me.ID_ClienteTextBox.Name = "ID_ClienteTextBox"
        Me.ID_ClienteTextBox.Size = New System.Drawing.Size(200, 21)
        Me.ID_ClienteTextBox.TabIndex = 60
        '
        'NomeTextBox
        '
        Me.NomeTextBox.CausesValidation = False
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(138, 76)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NomeTextBox.TabIndex = 62
        '
        'Data_NascDateTimePicker
        '
        Me.Data_NascDateTimePicker.CausesValidation = False
        Me.Data_NascDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClienteBindingSource, "Data_Nasc", True))
        Me.Data_NascDateTimePicker.Enabled = False
        Me.Data_NascDateTimePicker.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_NascDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Data_NascDateTimePicker.Location = New System.Drawing.Point(138, 102)
        Me.Data_NascDateTimePicker.Name = "Data_NascDateTimePicker"
        Me.Data_NascDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.Data_NascDateTimePicker.TabIndex = 64
        '
        'PesoTextBox
        '
        Me.PesoTextBox.CausesValidation = False
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Peso", True))
        Me.PesoTextBox.Enabled = False
        Me.PesoTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PesoTextBox.Location = New System.Drawing.Point(138, 128)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(200, 21)
        Me.PesoTextBox.TabIndex = 66
        '
        'NIFTextBox
        '
        Me.NIFTextBox.CausesValidation = False
        Me.NIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "NIF", True))
        Me.NIFTextBox.Enabled = False
        Me.NIFTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIFTextBox.Location = New System.Drawing.Point(138, 180)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NIFTextBox.TabIndex = 70
        '
        'AtivoCheckBox
        '
        Me.AtivoCheckBox.CausesValidation = False
        Me.AtivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClienteBindingSource, "Ativo", True))
        Me.AtivoCheckBox.Enabled = False
        Me.AtivoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AtivoCheckBox.ForeColor = System.Drawing.Color.White
        Me.AtivoCheckBox.Location = New System.Drawing.Point(138, 236)
        Me.AtivoCheckBox.Name = "AtivoCheckBox"
        Me.AtivoCheckBox.Size = New System.Drawing.Size(90, 24)
        Me.AtivoCheckBox.TabIndex = 74
        Me.AtivoCheckBox.UseVisualStyleBackColor = True
        '
        'MensalidadePagaCheckBox
        '
        Me.MensalidadePagaCheckBox.CausesValidation = False
        Me.MensalidadePagaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClienteBindingSource, "MensalidadePaga", True))
        Me.MensalidadePagaCheckBox.Enabled = False
        Me.MensalidadePagaCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MensalidadePagaCheckBox.ForeColor = System.Drawing.Color.White
        Me.MensalidadePagaCheckBox.Location = New System.Drawing.Point(138, 266)
        Me.MensalidadePagaCheckBox.Name = "MensalidadePagaCheckBox"
        Me.MensalidadePagaCheckBox.Size = New System.Drawing.Size(90, 24)
        Me.MensalidadePagaCheckBox.TabIndex = 76
        Me.MensalidadePagaCheckBox.UseVisualStyleBackColor = True
        '
        'MoradaTextBox
        '
        Me.MoradaTextBox.CausesValidation = False
        Me.MoradaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Morada", True))
        Me.MoradaTextBox.Enabled = False
        Me.MoradaTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoradaTextBox.Location = New System.Drawing.Point(138, 296)
        Me.MoradaTextBox.Name = "MoradaTextBox"
        Me.MoradaTextBox.Size = New System.Drawing.Size(200, 21)
        Me.MoradaTextBox.TabIndex = 78
        '
        'IMCTextBox
        '
        Me.IMCTextBox.CausesValidation = False
        Me.IMCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "IMC", True))
        Me.IMCTextBox.Enabled = False
        Me.IMCTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMCTextBox.Location = New System.Drawing.Point(138, 322)
        Me.IMCTextBox.Name = "IMCTextBox"
        Me.IMCTextBox.Size = New System.Drawing.Size(200, 21)
        Me.IMCTextBox.TabIndex = 80
        '
        'EstudanteCheckBox
        '
        Me.EstudanteCheckBox.CausesValidation = False
        Me.EstudanteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClienteBindingSource, "Estudante", True))
        Me.EstudanteCheckBox.Enabled = False
        Me.EstudanteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstudanteCheckBox.ForeColor = System.Drawing.Color.White
        Me.EstudanteCheckBox.Location = New System.Drawing.Point(494, 52)
        Me.EstudanteCheckBox.Name = "EstudanteCheckBox"
        Me.EstudanteCheckBox.Size = New System.Drawing.Size(90, 24)
        Me.EstudanteCheckBox.TabIndex = 82
        Me.EstudanteCheckBox.UseVisualStyleBackColor = True
        '
        'DentroGinasioCheckBox
        '
        Me.DentroGinasioCheckBox.CausesValidation = False
        Me.DentroGinasioCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClienteBindingSource, "DentroGinasio", True))
        Me.DentroGinasioCheckBox.Enabled = False
        Me.DentroGinasioCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DentroGinasioCheckBox.ForeColor = System.Drawing.Color.White
        Me.DentroGinasioCheckBox.Location = New System.Drawing.Point(494, 82)
        Me.DentroGinasioCheckBox.Name = "DentroGinasioCheckBox"
        Me.DentroGinasioCheckBox.Size = New System.Drawing.Size(90, 24)
        Me.DentroGinasioCheckBox.TabIndex = 84
        Me.DentroGinasioCheckBox.UseVisualStyleBackColor = True
        '
        'ID_MensalidadeComboBox
        '
        Me.ID_MensalidadeComboBox.CausesValidation = False
        Me.ID_MensalidadeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteBindingSource, "ID_Mensalidade", True))
        Me.ID_MensalidadeComboBox.DataSource = Me.MensalidadeBindingSource
        Me.ID_MensalidadeComboBox.DisplayMember = "Nome"
        Me.ID_MensalidadeComboBox.Enabled = False
        Me.ID_MensalidadeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ID_MensalidadeComboBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_MensalidadeComboBox.FormattingEnabled = True
        Me.ID_MensalidadeComboBox.Location = New System.Drawing.Point(494, 138)
        Me.ID_MensalidadeComboBox.Name = "ID_MensalidadeComboBox"
        Me.ID_MensalidadeComboBox.Size = New System.Drawing.Size(200, 23)
        Me.ID_MensalidadeComboBox.TabIndex = 88
        Me.ID_MensalidadeComboBox.ValueMember = "ID"
        '
        'MensalidadeBindingSource
        '
        Me.MensalidadeBindingSource.DataMember = "Mensalidade"
        Me.MensalidadeBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'Data_MensalidadeTextBox
        '
        Me.Data_MensalidadeTextBox.CausesValidation = False
        Me.Data_MensalidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Data_Mensalidade", True))
        Me.Data_MensalidadeTextBox.Enabled = False
        Me.Data_MensalidadeTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_MensalidadeTextBox.Location = New System.Drawing.Point(494, 165)
        Me.Data_MensalidadeTextBox.Name = "Data_MensalidadeTextBox"
        Me.Data_MensalidadeTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Data_MensalidadeTextBox.TabIndex = 90
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(248, 359)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 48)
        Me.Button5.TabIndex = 94
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
        Me.Button4.Location = New System.Drawing.Point(194, 359)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 48)
        Me.Button4.TabIndex = 93
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
        Me.Button3.Location = New System.Drawing.Point(140, 359)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 48)
        Me.Button3.TabIndex = 92
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
        Me.Button2.Location = New System.Drawing.Point(86, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 91
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ToolTip1.SetToolTip(Me.Button2, "Novo")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MensalidadeTableAdapter
        '
        Me.MensalidadeTableAdapter.ClearBeforeFill = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(686, 195)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(105, 48)
        Me.Button6.TabIndex = 95
        Me.Button6.Text = "Inscrever em Atividade"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GéneroTextBox
        '
        Me.GéneroTextBox.CausesValidation = False
        Me.GéneroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Género", True))
        Me.GéneroTextBox.Enabled = False
        Me.GéneroTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GéneroTextBox.Location = New System.Drawing.Point(138, 212)
        Me.GéneroTextBox.Name = "GéneroTextBox"
        Me.GéneroTextBox.Size = New System.Drawing.Size(200, 21)
        Me.GéneroTextBox.TabIndex = 96
        '
        'ID_PlanoComboBox
        '
        Me.ID_PlanoComboBox.CausesValidation = False
        Me.ID_PlanoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteBindingSource, "ID_Plano", True))
        Me.ID_PlanoComboBox.DataSource = Me.PlanoBindingSource
        Me.ID_PlanoComboBox.DisplayMember = "Descrição"
        Me.ID_PlanoComboBox.Enabled = False
        Me.ID_PlanoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ID_PlanoComboBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_PlanoComboBox.FormattingEnabled = True
        Me.ID_PlanoComboBox.Location = New System.Drawing.Point(494, 113)
        Me.ID_PlanoComboBox.Name = "ID_PlanoComboBox"
        Me.ID_PlanoComboBox.Size = New System.Drawing.Size(200, 23)
        Me.ID_PlanoComboBox.TabIndex = 97
        Me.ID_PlanoComboBox.ValueMember = "ID_Plano"
        '
        'PlanoBindingSource
        '
        Me.PlanoBindingSource.DataMember = "Plano"
        Me.PlanoBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'PlanoTableAdapter
        '
        Me.PlanoTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(666, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 31)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Área Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(344, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "kg"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(344, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "cm"
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(686, 249)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(105, 48)
        Me.Button7.TabIndex = 101
        Me.Button7.Text = "Inscrições"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Tw Cen MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(686, 303)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(105, 53)
        Me.Button8.TabIndex = 102
        Me.Button8.Text = "Mensalidade Atrasada ou Inativos"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'AlturaTextBox
        '
        Me.AlturaTextBox.CausesValidation = False
        Me.AlturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Altura", True))
        Me.AlturaTextBox.Enabled = False
        Me.AlturaTextBox.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlturaTextBox.Location = New System.Drawing.Point(138, 155)
        Me.AlturaTextBox.Name = "AlturaTextBox"
        Me.AlturaTextBox.Size = New System.Drawing.Size(200, 21)
        Me.AlturaTextBox.TabIndex = 103
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(547, 57)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(105, 48)
        Me.Button9.TabIndex = 104
        Me.Button9.Text = "Ver Todos os Clientes Ativos"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(838, 448)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.AlturaTextBox)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ID_PlanoComboBox)
        Me.Controls.Add(Me.GéneroTextBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(ID_ClienteLabel)
        Me.Controls.Add(Me.ID_ClienteTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Data_NascLabel)
        Me.Controls.Add(Me.Data_NascDateTimePicker)
        Me.Controls.Add(PesoLabel)
        Me.Controls.Add(Me.PesoTextBox)
        Me.Controls.Add(AlturaLabel)
        Me.Controls.Add(NIFLabel)
        Me.Controls.Add(Me.NIFTextBox)
        Me.Controls.Add(GéneroLabel)
        Me.Controls.Add(Me.AtivoLabel)
        Me.Controls.Add(Me.AtivoCheckBox)
        Me.Controls.Add(Me.MensalidadePagaLabel)
        Me.Controls.Add(Me.MensalidadePagaCheckBox)
        Me.Controls.Add(MoradaLabel)
        Me.Controls.Add(Me.MoradaTextBox)
        Me.Controls.Add(Me.IMCLabel)
        Me.Controls.Add(Me.IMCTextBox)
        Me.Controls.Add(EstudanteLabel)
        Me.Controls.Add(Me.EstudanteCheckBox)
        Me.Controls.Add(Me.DentroGinasioLabel)
        Me.Controls.Add(Me.DentroGinasioCheckBox)
        Me.Controls.Add(Me.ID_PlanoLabel)
        Me.Controls.Add(ID_MensalidadeLabel)
        Me.Controls.Add(Me.ID_MensalidadeComboBox)
        Me.Controls.Add(Me.Data_MensalidadeLabel)
        Me.Controls.Add(Me.Data_MensalidadeTextBox)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.MensalidadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents ID_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_NascDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NIFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AtivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MensalidadePagaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MoradaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IMCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstudanteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DentroGinasioCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ID_MensalidadeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Data_MensalidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MensalidadeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MensalidadeTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MensalidadeTableAdapter
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GéneroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_PlanoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PlanoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanoTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.PlanoTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents ID_PlanoLabel As System.Windows.Forms.Label
    Public WithEvents AtivoLabel As System.Windows.Forms.Label
    Public WithEvents MensalidadePagaLabel As System.Windows.Forms.Label
    Public WithEvents IMCLabel As System.Windows.Forms.Label
    Public WithEvents DentroGinasioLabel As System.Windows.Forms.Label
    Public WithEvents Data_MensalidadeLabel As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents AlturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
