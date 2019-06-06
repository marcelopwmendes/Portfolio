<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMarcarAulas
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
        Dim Hora_InicioLabel As System.Windows.Forms.Label
        Dim Hora_FimLabel As System.Windows.Forms.Label
        Dim PrecoLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim ID_ClienteLabel1 As System.Windows.Forms.Label
        Dim ID_MonitorLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMarcarAulas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AulaTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.AulaTableAdapter()
        Me.TableAdapterManager = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.ClienteTableAdapter()
        Me.MonitorTableAdapter = New GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MonitorTableAdapter()
        Me.MonitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_Dados_v2DataSet = New GinasioAlpendorada.Base_de_Dados_v2DataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hora_InicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Hora_FimDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrecoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MonitorAulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Hora_InicioLabel = New System.Windows.Forms.Label()
        Hora_FimLabel = New System.Windows.Forms.Label()
        PrecoLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        ID_ClienteLabel1 = New System.Windows.Forms.Label()
        ID_MonitorLabel1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonitorAulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hora_InicioLabel
        '
        Hora_InicioLabel.AutoSize = True
        Hora_InicioLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Hora_InicioLabel.ForeColor = System.Drawing.Color.White
        Hora_InicioLabel.Location = New System.Drawing.Point(42, 48)
        Hora_InicioLabel.Name = "Hora_InicioLabel"
        Hora_InicioLabel.Size = New System.Drawing.Size(64, 15)
        Hora_InicioLabel.TabIndex = 83
        Hora_InicioLabel.Text = "Hora Inicio:"
        '
        'Hora_FimLabel
        '
        Hora_FimLabel.AutoSize = True
        Hora_FimLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Hora_FimLabel.ForeColor = System.Drawing.Color.White
        Hora_FimLabel.Location = New System.Drawing.Point(42, 73)
        Hora_FimLabel.Name = "Hora_FimLabel"
        Hora_FimLabel.Size = New System.Drawing.Size(56, 15)
        Hora_FimLabel.TabIndex = 85
        Hora_FimLabel.Text = "Hora Fim:"
        '
        'PrecoLabel
        '
        PrecoLabel.AutoSize = True
        PrecoLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecoLabel.ForeColor = System.Drawing.Color.White
        PrecoLabel.Location = New System.Drawing.Point(42, 97)
        PrecoLabel.Name = "PrecoLabel"
        PrecoLabel.Size = New System.Drawing.Size(37, 15)
        PrecoLabel.TabIndex = 87
        PrecoLabel.Text = "Preco:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataLabel.ForeColor = System.Drawing.Color.White
        DataLabel.Location = New System.Drawing.Point(42, 173)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 15)
        DataLabel.TabIndex = 93
        DataLabel.Text = "Data:"
        '
        'ID_ClienteLabel1
        '
        ID_ClienteLabel1.AutoSize = True
        ID_ClienteLabel1.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_ClienteLabel1.ForeColor = System.Drawing.Color.White
        ID_ClienteLabel1.Location = New System.Drawing.Point(42, 121)
        ID_ClienteLabel1.Name = "ID_ClienteLabel1"
        ID_ClienteLabel1.Size = New System.Drawing.Size(44, 15)
        ID_ClienteLabel1.TabIndex = 94
        ID_ClienteLabel1.Text = "Cliente:"
        '
        'ID_MonitorLabel1
        '
        ID_MonitorLabel1.AutoSize = True
        ID_MonitorLabel1.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_MonitorLabel1.ForeColor = System.Drawing.Color.White
        ID_MonitorLabel1.Location = New System.Drawing.Point(42, 150)
        ID_MonitorLabel1.Name = "ID_MonitorLabel1"
        ID_MonitorLabel1.Size = New System.Drawing.Size(48, 15)
        ID_MonitorLabel1.TabIndex = 98
        ID_MonitorLabel1.Text = "Monitor:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(411, 221)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 207)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(745, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 64)
        Me.Button1.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.Button1, "Voltar")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AulaTableAdapter
        '
        Me.AulaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AtividadeTableAdapter = Nothing
        Me.TableAdapterManager.AulaTableAdapter = Me.AulaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
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
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'MonitorTableAdapter
        '
        Me.MonitorTableAdapter.ClearBeforeFill = True
        '
        'MonitorBindingSource
        '
        Me.MonitorBindingSource.DataMember = "Monitor"
        Me.MonitorBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
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
        'Hora_InicioDateTimePicker
        '
        Me.Hora_InicioDateTimePicker.CustomFormat = "HH:mm"
        Me.Hora_InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Hora_InicioDateTimePicker.Location = New System.Drawing.Point(108, 44)
        Me.Hora_InicioDateTimePicker.Name = "Hora_InicioDateTimePicker"
        Me.Hora_InicioDateTimePicker.ShowUpDown = True
        Me.Hora_InicioDateTimePicker.Size = New System.Drawing.Size(200, 19)
        Me.Hora_InicioDateTimePicker.TabIndex = 84
        '
        'Hora_FimDateTimePicker
        '
        Me.Hora_FimDateTimePicker.CustomFormat = "HH:mm"
        Me.Hora_FimDateTimePicker.Enabled = False
        Me.Hora_FimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Hora_FimDateTimePicker.Location = New System.Drawing.Point(108, 69)
        Me.Hora_FimDateTimePicker.Name = "Hora_FimDateTimePicker"
        Me.Hora_FimDateTimePicker.ShowUpDown = True
        Me.Hora_FimDateTimePicker.Size = New System.Drawing.Size(200, 19)
        Me.Hora_FimDateTimePicker.TabIndex = 86
        '
        'PrecoTextBox
        '
        Me.PrecoTextBox.Enabled = False
        Me.PrecoTextBox.Location = New System.Drawing.Point(108, 94)
        Me.PrecoTextBox.Name = "PrecoTextBox"
        Me.PrecoTextBox.Size = New System.Drawing.Size(200, 19)
        Me.PrecoTextBox.TabIndex = 88
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataDateTimePicker.Location = New System.Drawing.Point(108, 169)
        Me.DataDateTimePicker.MinDate = New Date(2017, 5, 17, 0, 0, 0, 0)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 19)
        Me.DataDateTimePicker.TabIndex = 94
        '
        'AulaBindingSource
        '
        Me.AulaBindingSource.DataMember = "Aula"
        Me.AulaBindingSource.DataSource = Me.Base_de_Dados_v2DataSet
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(314, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 23)
        Me.Button2.TabIndex = 96
        Me.Button2.Text = "Selecionar Cliente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(108, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 19)
        Me.TextBox1.TabIndex = 97
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(45, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 100
        Me.Button3.Text = "Ver Aulas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.ComboBox1.Location = New System.Drawing.Point(434, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(45, 22)
        Me.ComboBox1.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(394, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Horas"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(45, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 103
        Me.Button4.Text = "Marcar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MonitorAulaBindingSource
        '
        Me.MonitorAulaBindingSource.DataMember = "MonitorAula"
        Me.MonitorAulaBindingSource.DataSource = Me.MonitorBindingSource
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(314, 142)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 23)
        Me.Button5.TabIndex = 105
        Me.Button5.Text = "Selecionar Monitor"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(108, 142)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 19)
        Me.TextBox2.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(594, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 31)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Área Marcar Aulas"
        '
        'FormMarcarAulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(830, 448)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(ID_MonitorLabel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(ID_ClienteLabel1)
        Me.Controls.Add(Hora_InicioLabel)
        Me.Controls.Add(Me.Hora_InicioDateTimePicker)
        Me.Controls.Add(Hora_FimLabel)
        Me.Controls.Add(Me.Hora_FimDateTimePicker)
        Me.Controls.Add(PrecoLabel)
        Me.Controls.Add(Me.PrecoTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tw Cen MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMarcarAulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMarcarAulas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_Dados_v2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonitorAulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AulaTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.AulaTableAdapter
    Friend WithEvents TableAdapterManager As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MonitorTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.MonitorTableAdapter
    Friend WithEvents MonitorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As GinasioAlpendorada.Base_de_Dados_v2DataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Base_de_Dados_v2DataSet As GinasioAlpendorada.Base_de_Dados_v2DataSet
    Friend WithEvents Hora_InicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Hora_FimDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AulaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MonitorAulaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
