<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFaturas
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
        Dim EstudanteLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim ID_ClienteLabel As System.Windows.Forms.Label
        Dim ID_MensalidadeLabel1 As System.Windows.Forms.Label
        Dim PreçoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFaturas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ID_MensalidadeComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EstudanteCheckBox = New System.Windows.Forms.CheckBox()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.MensalidadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_Dados_v2DataSet = New GinasioAlpendorada.Base_de_Dados_v2DataSet()
        Me.MensalidadeTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MensalidadeTableAdapter()
        Me.TableAdapterManager = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager()
        Me.PreçoTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        EstudanteLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        ID_MensalidadeLabel1 = New System.Windows.Forms.Label()
        PreçoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MensalidadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstudanteLabel
        '
        EstudanteLabel.AutoSize = True
        EstudanteLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstudanteLabel.ForeColor = System.Drawing.SystemColors.Control
        EstudanteLabel.Location = New System.Drawing.Point(202, 42)
        EstudanteLabel.Name = "EstudanteLabel"
        EstudanteLabel.Size = New System.Drawing.Size(62, 15)
        EstudanteLabel.TabIndex = 47
        EstudanteLabel.Text = "Estudante:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NIFLabel.ForeColor = System.Drawing.SystemColors.Control
        NIFLabel.Location = New System.Drawing.Point(202, 20)
        NIFLabel.Name = "NIFLabel"
        NIFLabel.Size = New System.Drawing.Size(29, 15)
        NIFLabel.TabIndex = 44
        NIFLabel.Text = "NIF:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.ForeColor = System.Drawing.SystemColors.Control
        NomeLabel.Location = New System.Drawing.Point(4, 42)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(42, 15)
        NomeLabel.TabIndex = 42
        NomeLabel.Text = "Nome:"
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_ClienteLabel.ForeColor = System.Drawing.SystemColors.Control
        ID_ClienteLabel.Location = New System.Drawing.Point(4, 20)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(62, 15)
        ID_ClienteLabel.TabIndex = 41
        ID_ClienteLabel.Text = "Nº Cliente:"
        '
        'ID_MensalidadeLabel1
        '
        ID_MensalidadeLabel1.AutoSize = True
        ID_MensalidadeLabel1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_MensalidadeLabel1.ForeColor = System.Drawing.SystemColors.Control
        ID_MensalidadeLabel1.Location = New System.Drawing.Point(4, 67)
        ID_MensalidadeLabel1.Name = "ID_MensalidadeLabel1"
        ID_MensalidadeLabel1.Size = New System.Drawing.Size(79, 15)
        ID_MensalidadeLabel1.TabIndex = 43
        ID_MensalidadeLabel1.Text = "Mensalidade:"
        '
        'PreçoLabel
        '
        PreçoLabel.AutoSize = True
        PreçoLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PreçoLabel.ForeColor = System.Drawing.SystemColors.Control
        PreçoLabel.Location = New System.Drawing.Point(16, 167)
        PreçoLabel.Name = "PreçoLabel"
        PreçoLabel.Size = New System.Drawing.Size(39, 15)
        PreçoLabel.TabIndex = 49
        PreçoLabel.Text = "Preço:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ID_MensalidadeLabel1)
        Me.GroupBox1.Controls.Add(Me.ID_MensalidadeComboBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(EstudanteLabel)
        Me.GroupBox1.Controls.Add(Me.EstudanteCheckBox)
        Me.GroupBox1.Controls.Add(NIFLabel)
        Me.GroupBox1.Controls.Add(Me.NIFTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(ID_ClienteLabel)
        Me.GroupBox1.Controls.Add(Me.ID_ClienteTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'ID_MensalidadeComboBox
        '
        Me.ID_MensalidadeComboBox.Enabled = False
        Me.ID_MensalidadeComboBox.FormattingEnabled = True
        Me.ID_MensalidadeComboBox.Location = New System.Drawing.Point(89, 64)
        Me.ID_MensalidadeComboBox.Name = "ID_MensalidadeComboBox"
        Me.ID_MensalidadeComboBox.Size = New System.Drawing.Size(100, 23)
        Me.ID_MensalidadeComboBox.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(409, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 39)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Selecionar Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EstudanteCheckBox
        '
        Me.EstudanteCheckBox.Enabled = False
        Me.EstudanteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstudanteCheckBox.Location = New System.Drawing.Point(279, 37)
        Me.EstudanteCheckBox.Name = "EstudanteCheckBox"
        Me.EstudanteCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EstudanteCheckBox.TabIndex = 48
        Me.EstudanteCheckBox.UseVisualStyleBackColor = True
        '
        'NIFTextBox
        '
        Me.NIFTextBox.Enabled = False
        Me.NIFTextBox.Location = New System.Drawing.Point(279, 17)
        Me.NIFTextBox.Name = "NIFTextBox"
        Me.NIFTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NIFTextBox.TabIndex = 46
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(89, 39)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NomeTextBox.TabIndex = 45
        '
        'ID_ClienteTextBox
        '
        Me.ID_ClienteTextBox.Enabled = False
        Me.ID_ClienteTextBox.Location = New System.Drawing.Point(89, 17)
        Me.ID_ClienteTextBox.Name = "ID_ClienteTextBox"
        Me.ID_ClienteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ID_ClienteTextBox.TabIndex = 43
        '
        'MensalidadeBindingSource
        '
        Me.MensalidadeBindingSource.DataMember = "Mensalidade"
        Me.MensalidadeBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'Base_de_Dados_v2DataSet
        '
        Me.Base_de_Dados_v2DataSet.DataSetName = "Base_de_Dados_v2DataSet"
        Me.Base_de_Dados_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MensalidadeTableAdapter
        '
        Me.MensalidadeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AtividadeTableAdapter = Nothing
        Me.TableAdapterManager.AulaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.DiaSemanaTableAdapter = Nothing
        Me.TableAdapterManager.ExercicioTableAdapter = Nothing
        Me.TableAdapterManager.FaturaTableAdapter = Nothing
        Me.TableAdapterManager.FuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.InscriçãoTableAdapter = Nothing
        Me.TableAdapterManager.MensalidadeTableAdapter = Me.MensalidadeTableAdapter
        Me.TableAdapterManager.MonitorTableAdapter = Nothing
        Me.TableAdapterManager.Plano_ExercicioTableAdapter = Nothing
        Me.TableAdapterManager.PlanoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PreçoTextBox
        '
        Me.PreçoTextBox.Enabled = False
        Me.PreçoTextBox.Location = New System.Drawing.Point(155, 162)
        Me.PreçoTextBox.Name = "PreçoTextBox"
        Me.PreçoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PreçoTextBox.TabIndex = 50
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(19, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Promoção"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(16, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Preço com Promoção:"
        Me.Label1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensalidadeBindingSource, "Preço", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(155, 190)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 52
        Me.TextBox1.Visible = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(650, 378)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Pagar"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(731, 378)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 54
        Me.Button4.Text = "Sair"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(393, 224)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 190)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBox1.Location = New System.Drawing.Point(509, 162)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(299, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 15)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Quantidade de Meses que deseja Pagar:"
        '
        'FormFaturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(830, 440)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(PreçoLabel)
        Me.Controls.Add(Me.PreçoTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormFaturas"
        Me.Text = "Faturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MensalidadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EstudanteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NIFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_MensalidadeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Base_de_Dados_v2DataSet As GinasioAlpendorada.Base_de_Dados_v2DataSet
    Friend WithEvents MensalidadeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MensalidadeTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MensalidadeTableAdapter
    Friend WithEvents PreçoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
