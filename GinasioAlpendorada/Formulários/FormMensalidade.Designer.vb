<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMensalidade
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DescriçãoLabel As System.Windows.Forms.Label
        Dim PreçoLabel As System.Windows.Forms.Label
        Dim AtividadesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMensalidade))
        Me.Base_de_Dados_v2DataSet = New GinasioAlpendorada.Base_de_Dados_v2DataSet()
        Me.MensalidadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MensalidadeTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MensalidadeTableAdapter()
        Me.TableAdapterManager = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager()
        Me.MensalidadeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DescriçãoTextBox = New System.Windows.Forms.TextBox()
        Me.PreçoTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AtividadesComboBox = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        IDLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DescriçãoLabel = New System.Windows.Forms.Label()
        PreçoLabel = New System.Windows.Forms.Label()
        AtividadesLabel = New System.Windows.Forms.Label()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MensalidadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MensalidadeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MensalidadeBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(43, 89)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(22, 15)
        IDLabel.TabIndex = 1
        IDLabel.Text = "Nº:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(43, 116)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(40, 15)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'DescriçãoLabel
        '
        DescriçãoLabel.AutoSize = True
        DescriçãoLabel.Location = New System.Drawing.Point(43, 143)
        DescriçãoLabel.Name = "DescriçãoLabel"
        DescriçãoLabel.Size = New System.Drawing.Size(58, 15)
        DescriçãoLabel.TabIndex = 5
        DescriçãoLabel.Text = "Descrição:"
        '
        'PreçoLabel
        '
        PreçoLabel.AutoSize = True
        PreçoLabel.Location = New System.Drawing.Point(43, 170)
        PreçoLabel.Name = "PreçoLabel"
        PreçoLabel.Size = New System.Drawing.Size(37, 15)
        PreçoLabel.TabIndex = 7
        PreçoLabel.Text = "Preço:"
        '
        'AtividadesLabel
        '
        AtividadesLabel.AutoSize = True
        AtividadesLabel.Location = New System.Drawing.Point(43, 196)
        AtividadesLabel.Name = "AtividadesLabel"
        AtividadesLabel.Size = New System.Drawing.Size(62, 15)
        AtividadesLabel.TabIndex = 99
        AtividadesLabel.Text = "Atividades:"
        '
        'Base_de_Dados_v2DataSet
        '
        Me.Base_de_Dados_v2DataSet.DataSetName = "Base_de_Dados_v2DataSet"
        Me.Base_de_Dados_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MensalidadeBindingSource
        '
        Me.MensalidadeBindingSource.DataMember = "Mensalidade"
        Me.MensalidadeBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
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
        'MensalidadeBindingNavigator
        '
        Me.MensalidadeBindingNavigator.AddNewItem = Nothing
        Me.MensalidadeBindingNavigator.BindingSource = Me.MensalidadeBindingSource
        Me.MensalidadeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MensalidadeBindingNavigator.DeleteItem = Nothing
        Me.MensalidadeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.MensalidadeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MensalidadeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MensalidadeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MensalidadeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MensalidadeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MensalidadeBindingNavigator.Name = "MensalidadeBindingNavigator"
        Me.MensalidadeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MensalidadeBindingNavigator.Size = New System.Drawing.Size(830, 25)
        Me.MensalidadeBindingNavigator.TabIndex = 0
        Me.MensalidadeBindingNavigator.Text = "BindingNavigator1"
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
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensalidadeBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(108, 86)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(298, 21)
        Me.IDTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensalidadeBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(108, 113)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(298, 21)
        Me.NomeTextBox.TabIndex = 4
        '
        'DescriçãoTextBox
        '
        Me.DescriçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensalidadeBindingSource, "Descrição", True))
        Me.DescriçãoTextBox.Enabled = False
        Me.DescriçãoTextBox.Location = New System.Drawing.Point(108, 140)
        Me.DescriçãoTextBox.Name = "DescriçãoTextBox"
        Me.DescriçãoTextBox.Size = New System.Drawing.Size(298, 21)
        Me.DescriçãoTextBox.TabIndex = 6
        '
        'PreçoTextBox
        '
        Me.PreçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensalidadeBindingSource, "Preço", True))
        Me.PreçoTextBox.Enabled = False
        Me.PreçoTextBox.Location = New System.Drawing.Point(108, 167)
        Me.PreçoTextBox.Name = "PreçoTextBox"
        Me.PreçoTextBox.Size = New System.Drawing.Size(298, 21)
        Me.PreçoTextBox.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(250, 272)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 48)
        Me.Button5.TabIndex = 67
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
        Me.Button4.Location = New System.Drawing.Point(196, 272)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 48)
        Me.Button4.TabIndex = 66
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
        Me.Button3.Location = New System.Drawing.Point(142, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 48)
        Me.Button3.TabIndex = 65
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
        Me.Button2.Location = New System.Drawing.Point(88, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 64
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
        Me.Button1.Location = New System.Drawing.Point(729, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 64)
        Me.Button1.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.Button1, "Voltar")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(395, 223)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 190)
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(663, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 31)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Área Oferta"
        '
        'AtividadesComboBox
        '
        Me.AtividadesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MensalidadeBindingSource, "Atividades", True))
        Me.AtividadesComboBox.Enabled = False
        Me.AtividadesComboBox.FormattingEnabled = True
        Me.AtividadesComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.AtividadesComboBox.Location = New System.Drawing.Point(108, 193)
        Me.AtividadesComboBox.Name = "AtividadesComboBox"
        Me.AtividadesComboBox.Size = New System.Drawing.Size(298, 23)
        Me.AtividadesComboBox.TabIndex = 100
        '
        'FormMensalidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(830, 447)
        Me.Controls.Add(AtividadesLabel)
        Me.Controls.Add(Me.AtividadesComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(DescriçãoLabel)
        Me.Controls.Add(Me.DescriçãoTextBox)
        Me.Controls.Add(PreçoLabel)
        Me.Controls.Add(Me.PreçoTextBox)
        Me.Controls.Add(Me.MensalidadeBindingNavigator)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMensalidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMensalidade"
        CType(Me.Base_de_Dados_v2DataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MensalidadeBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MensalidadeBindingNavigator,System.ComponentModel.ISupportInitialize).EndInit
        Me.MensalidadeBindingNavigator.ResumeLayout(false)
        Me.MensalidadeBindingNavigator.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Base_de_Dados_v2DataSet As GinasioAlpendorada.Base_de_Dados_v2DataSet
    Friend WithEvents MensalidadeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MensalidadeTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MensalidadeTableAdapter
    Friend WithEvents TableAdapterManager As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MensalidadeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreçoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AtividadesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
