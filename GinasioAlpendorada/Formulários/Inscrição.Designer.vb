<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscrição
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
        Dim ID_MensalidadeLabel1 As System.Windows.Forms.Label
        Dim EstudanteLabel As System.Windows.Forms.Label
        Dim NIFLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim ID_ClienteLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inscrição))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ID_MensalidadeComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EstudanteCheckBox = New System.Windows.Forms.CheckBox()
        Me.NIFTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.IDAtividade = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        ID_MensalidadeLabel1 = New System.Windows.Forms.Label()
        EstudanteLabel = New System.Windows.Forms.Label()
        NIFLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_MensalidadeLabel1
        '
        ID_MensalidadeLabel1.AutoSize = True
        ID_MensalidadeLabel1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_MensalidadeLabel1.ForeColor = System.Drawing.SystemColors.Control
        ID_MensalidadeLabel1.Location = New System.Drawing.Point(4, 71)
        ID_MensalidadeLabel1.Name = "ID_MensalidadeLabel1"
        ID_MensalidadeLabel1.Size = New System.Drawing.Size(79, 15)
        ID_MensalidadeLabel1.TabIndex = 43
        ID_MensalidadeLabel1.Text = "Mensalidade:"
        '
        'EstudanteLabel
        '
        EstudanteLabel.AutoSize = True
        EstudanteLabel.Enabled = False
        EstudanteLabel.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstudanteLabel.ForeColor = System.Drawing.SystemColors.Control
        EstudanteLabel.Location = New System.Drawing.Point(202, 46)
        EstudanteLabel.Name = "EstudanteLabel"
        EstudanteLabel.Size = New System.Drawing.Size(62, 15)
        EstudanteLabel.TabIndex = 47
        EstudanteLabel.Text = "Estudante:"
        '
        'NIFLabel
        '
        NIFLabel.AutoSize = True
        NIFLabel.Enabled = False
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
        NomeLabel.Location = New System.Drawing.Point(4, 46)
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
        ID_ClienteLabel.Size = New System.Drawing.Size(61, 15)
        ID_ClienteLabel.TabIndex = 41
        ID_ClienteLabel.Text = "ID Cliente:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.Control
        Label1.Location = New System.Drawing.Point(4, 71)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 15)
        Label1.TabIndex = 43
        Label1.Text = "Monitor:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.Control
        Label4.Location = New System.Drawing.Point(4, 46)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(42, 15)
        Label4.TabIndex = 42
        Label4.Text = "Nome:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.Control
        Label5.Location = New System.Drawing.Point(4, 20)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(77, 15)
        Label5.TabIndex = 41
        Label5.Text = "ID Atividade:"
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
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 114)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'ID_MensalidadeComboBox
        '
        Me.ID_MensalidadeComboBox.DisplayMember = "Nome"
        Me.ID_MensalidadeComboBox.Enabled = False
        Me.ID_MensalidadeComboBox.FormattingEnabled = True
        Me.ID_MensalidadeComboBox.Location = New System.Drawing.Point(89, 68)
        Me.ID_MensalidadeComboBox.Name = "ID_MensalidadeComboBox"
        Me.ID_MensalidadeComboBox.Size = New System.Drawing.Size(100, 23)
        Me.ID_MensalidadeComboBox.TabIndex = 44
        Me.ID_MensalidadeComboBox.ValueMember = "ID"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(409, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 39)
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
        Me.NomeTextBox.Location = New System.Drawing.Point(89, 43)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Me.IDAtividade)
        Me.GroupBox2.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 114)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Atividade"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(89, 68)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 50
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(409, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 39)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Selecionar Atividade"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(89, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 45
        '
        'IDAtividade
        '
        Me.IDAtividade.Enabled = False
        Me.IDAtividade.Location = New System.Drawing.Point(89, 17)
        Me.IDAtividade.Name = "IDAtividade"
        Me.IDAtividade.Size = New System.Drawing.Size(100, 22)
        Me.IDAtividade.TabIndex = 43
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
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(70, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 39)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "Inscrever"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Inscrição
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(830, 440)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.SteelBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inscrição"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscrição"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ID_MensalidadeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EstudanteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NIFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents IDAtividade As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
