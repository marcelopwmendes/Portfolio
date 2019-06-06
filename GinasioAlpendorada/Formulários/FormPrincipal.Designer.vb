<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.BSair = New System.Windows.Forms.Button()
        Me.BDar_Entrada = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BDar_Saida = New System.Windows.Forms.Button()
        Me.BAtividadesDecorrer = New System.Windows.Forms.Button()
        Me.BFuncionarios = New System.Windows.Forms.Button()
        Me.BMonitores = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.BAulas = New System.Windows.Forms.Button()
        Me.BFaturas = New System.Windows.Forms.Button()
        Me.BOfertas = New System.Windows.Forms.Button()
        Me.BAtividades = New System.Windows.Forms.Button()
        Me.LNomeFuncionario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BSair
        '
        Me.BSair.BackColor = System.Drawing.Color.SteelBlue
        Me.BSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSair.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSair.ForeColor = System.Drawing.Color.White
        Me.BSair.Image = CType(resources.GetObject("BSair.Image"), System.Drawing.Image)
        Me.BSair.Location = New System.Drawing.Point(720, 346)
        Me.BSair.Name = "BSair"
        Me.BSair.Size = New System.Drawing.Size(82, 85)
        Me.BSair.TabIndex = 8
        Me.BSair.Text = "Sair"
        Me.BSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BSair.UseVisualStyleBackColor = False
        '
        'BDar_Entrada
        '
        Me.BDar_Entrada.BackColor = System.Drawing.Color.Transparent
        Me.BDar_Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BDar_Entrada.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDar_Entrada.ForeColor = System.Drawing.Color.White
        Me.BDar_Entrada.Image = CType(resources.GetObject("BDar_Entrada.Image"), System.Drawing.Image)
        Me.BDar_Entrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BDar_Entrada.Location = New System.Drawing.Point(6, 20)
        Me.BDar_Entrada.Name = "BDar_Entrada"
        Me.BDar_Entrada.Size = New System.Drawing.Size(82, 85)
        Me.BDar_Entrada.TabIndex = 0
        Me.BDar_Entrada.Text = "Dar Entrada"
        Me.BDar_Entrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BDar_Entrada.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BDar_Saida)
        Me.GroupBox1.Controls.Add(Me.BDar_Entrada)
        Me.GroupBox1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(573, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 139)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Área Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(194, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contagem de Clientes no Ginásio:"
        '
        'BDar_Saida
        '
        Me.BDar_Saida.BackColor = System.Drawing.Color.Transparent
        Me.BDar_Saida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BDar_Saida.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDar_Saida.ForeColor = System.Drawing.Color.White
        Me.BDar_Saida.Image = CType(resources.GetObject("BDar_Saida.Image"), System.Drawing.Image)
        Me.BDar_Saida.Location = New System.Drawing.Point(133, 20)
        Me.BDar_Saida.Name = "BDar_Saida"
        Me.BDar_Saida.Size = New System.Drawing.Size(75, 85)
        Me.BDar_Saida.TabIndex = 1
        Me.BDar_Saida.Text = "Dar Saída"
        Me.BDar_Saida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BDar_Saida.UseVisualStyleBackColor = False
        '
        'BAtividadesDecorrer
        '
        Me.BAtividadesDecorrer.BackColor = System.Drawing.Color.SteelBlue
        Me.BAtividadesDecorrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAtividadesDecorrer.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAtividadesDecorrer.ForeColor = System.Drawing.Color.White
        Me.BAtividadesDecorrer.Location = New System.Drawing.Point(573, 192)
        Me.BAtividadesDecorrer.Name = "BAtividadesDecorrer"
        Me.BAtividadesDecorrer.Size = New System.Drawing.Size(214, 26)
        Me.BAtividadesDecorrer.TabIndex = 10
        Me.BAtividadesDecorrer.Text = "Atividades a Decorrer"
        Me.BAtividadesDecorrer.UseVisualStyleBackColor = False
        '
        'BFuncionarios
        '
        Me.BFuncionarios.BackColor = System.Drawing.Color.Transparent
        Me.BFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BFuncionarios.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BFuncionarios.ForeColor = System.Drawing.Color.Transparent
        Me.BFuncionarios.Image = CType(resources.GetObject("BFuncionarios.Image"), System.Drawing.Image)
        Me.BFuncionarios.Location = New System.Drawing.Point(288, 32)
        Me.BFuncionarios.Name = "BFuncionarios"
        Me.BFuncionarios.Size = New System.Drawing.Size(132, 129)
        Me.BFuncionarios.TabIndex = 14
        Me.BFuncionarios.Text = "Funcionários"
        Me.BFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BFuncionarios.UseVisualStyleBackColor = False
        '
        'BMonitores
        '
        Me.BMonitores.BackColor = System.Drawing.Color.Transparent
        Me.BMonitores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMonitores.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMonitores.ForeColor = System.Drawing.Color.Transparent
        Me.BMonitores.Image = CType(resources.GetObject("BMonitores.Image"), System.Drawing.Image)
        Me.BMonitores.Location = New System.Drawing.Point(150, 32)
        Me.BMonitores.Name = "BMonitores"
        Me.BMonitores.Size = New System.Drawing.Size(132, 129)
        Me.BMonitores.TabIndex = 13
        Me.BMonitores.Text = "Monitores"
        Me.BMonitores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BMonitores.UseVisualStyleBackColor = False
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.Transparent
        Me.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BClientes.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClientes.ForeColor = System.Drawing.Color.Transparent
        Me.BClientes.Image = CType(resources.GetObject("BClientes.Image"), System.Drawing.Image)
        Me.BClientes.Location = New System.Drawing.Point(12, 32)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(132, 129)
        Me.BClientes.TabIndex = 12
        Me.BClientes.Text = "Clientes"
        Me.BClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'BAulas
        '
        Me.BAulas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BAulas.BackColor = System.Drawing.Color.Transparent
        Me.BAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAulas.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAulas.ForeColor = System.Drawing.Color.Transparent
        Me.BAulas.Image = CType(resources.GetObject("BAulas.Image"), System.Drawing.Image)
        Me.BAulas.Location = New System.Drawing.Point(12, 302)
        Me.BAulas.Name = "BAulas"
        Me.BAulas.Size = New System.Drawing.Size(132, 129)
        Me.BAulas.TabIndex = 19
        Me.BAulas.Text = "Marcar Aulas"
        Me.BAulas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BAulas.UseVisualStyleBackColor = False
        '
        'BFaturas
        '
        Me.BFaturas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BFaturas.BackColor = System.Drawing.Color.Transparent
        Me.BFaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BFaturas.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BFaturas.ForeColor = System.Drawing.Color.Transparent
        Me.BFaturas.Image = CType(resources.GetObject("BFaturas.Image"), System.Drawing.Image)
        Me.BFaturas.Location = New System.Drawing.Point(150, 302)
        Me.BFaturas.Name = "BFaturas"
        Me.BFaturas.Size = New System.Drawing.Size(132, 129)
        Me.BFaturas.TabIndex = 18
        Me.BFaturas.Text = "Faturas"
        Me.BFaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BFaturas.UseVisualStyleBackColor = False
        '
        'BOfertas
        '
        Me.BOfertas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BOfertas.BackColor = System.Drawing.Color.Transparent
        Me.BOfertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOfertas.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOfertas.ForeColor = System.Drawing.Color.Transparent
        Me.BOfertas.Image = CType(resources.GetObject("BOfertas.Image"), System.Drawing.Image)
        Me.BOfertas.Location = New System.Drawing.Point(150, 167)
        Me.BOfertas.Name = "BOfertas"
        Me.BOfertas.Size = New System.Drawing.Size(132, 129)
        Me.BOfertas.TabIndex = 16
        Me.BOfertas.Text = "Ofertas"
        Me.BOfertas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BOfertas.UseVisualStyleBackColor = False
        '
        'BAtividades
        '
        Me.BAtividades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BAtividades.BackColor = System.Drawing.Color.Transparent
        Me.BAtividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAtividades.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAtividades.ForeColor = System.Drawing.Color.Transparent
        Me.BAtividades.Image = CType(resources.GetObject("BAtividades.Image"), System.Drawing.Image)
        Me.BAtividades.Location = New System.Drawing.Point(12, 167)
        Me.BAtividades.Name = "BAtividades"
        Me.BAtividades.Size = New System.Drawing.Size(132, 129)
        Me.BAtividades.TabIndex = 15
        Me.BAtividades.Text = "Atividades"
        Me.BAtividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BAtividades.UseVisualStyleBackColor = False
        '
        'LNomeFuncionario
        '
        Me.LNomeFuncionario.AutoSize = True
        Me.LNomeFuncionario.BackColor = System.Drawing.Color.Transparent
        Me.LNomeFuncionario.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNomeFuncionario.ForeColor = System.Drawing.Color.White
        Me.LNomeFuncionario.Location = New System.Drawing.Point(660, 22)
        Me.LNomeFuncionario.Name = "LNomeFuncionario"
        Me.LNomeFuncionario.Size = New System.Drawing.Size(39, 15)
        Me.LNomeFuncionario.TabIndex = 22
        Me.LNomeFuncionario.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(587, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Funcionário: "
        '
        'DataHora
        '
        Me.DataHora.AutoSize = True
        Me.DataHora.BackColor = System.Drawing.Color.Transparent
        Me.DataHora.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataHora.ForeColor = System.Drawing.Color.White
        Me.DataHora.Location = New System.Drawing.Point(587, 9)
        Me.DataHora.Name = "DataHora"
        Me.DataHora.Size = New System.Drawing.Size(63, 15)
        Me.DataHora.TabIndex = 20
        Me.DataHora.Text = "Data/Hora"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(393, 224)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 207)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(830, 440)
        Me.Controls.Add(Me.LNomeFuncionario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataHora)
        Me.Controls.Add(Me.BAulas)
        Me.Controls.Add(Me.BFaturas)
        Me.Controls.Add(Me.BOfertas)
        Me.Controls.Add(Me.BAtividades)
        Me.Controls.Add(Me.BFuncionarios)
        Me.Controls.Add(Me.BMonitores)
        Me.Controls.Add(Me.BClientes)
        Me.Controls.Add(Me.BSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BAtividadesDecorrer)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BSair As System.Windows.Forms.Button
    Friend WithEvents BDar_Entrada As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BDar_Saida As System.Windows.Forms.Button
    Friend WithEvents BAtividadesDecorrer As System.Windows.Forms.Button
    Friend WithEvents BFuncionarios As System.Windows.Forms.Button
    Friend WithEvents BMonitores As System.Windows.Forms.Button
    Friend WithEvents BClientes As System.Windows.Forms.Button
    Friend WithEvents BAulas As System.Windows.Forms.Button
    Friend WithEvents BFaturas As System.Windows.Forms.Button
    Friend WithEvents BOfertas As System.Windows.Forms.Button
    Friend WithEvents BAtividades As System.Windows.Forms.Button
    Friend WithEvents LNomeFuncionario As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataHora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
