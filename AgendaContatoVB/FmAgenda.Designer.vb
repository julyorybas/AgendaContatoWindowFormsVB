<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmAgenda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LbId = New System.Windows.Forms.Label()
        Me.LbNome = New System.Windows.Forms.Label()
        Me.LbTelefone = New System.Windows.Forms.Label()
        Me.Lbemail = New System.Windows.Forms.Label()
        Me.TxId = New System.Windows.Forms.TextBox()
        Me.TxNome = New System.Windows.Forms.TextBox()
        Me.TxFone = New System.Windows.Forms.TextBox()
        Me.TxEmail = New System.Windows.Forms.TextBox()
        Me.BtSalvar = New System.Windows.Forms.Button()
        Me.BtEditar = New System.Windows.Forms.Button()
        Me.BtDeletar = New System.Windows.Forms.Button()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.DgContatos = New System.Windows.Forms.DataGridView()
        Me.BtLimpar = New System.Windows.Forms.Button()
        CType(Me.DgContatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbId
        '
        Me.LbId.AutoSize = True
        Me.LbId.Location = New System.Drawing.Point(45, 9)
        Me.LbId.Name = "LbId"
        Me.LbId.Size = New System.Drawing.Size(21, 15)
        Me.LbId.TabIndex = 0
        Me.LbId.Text = "ID:"
        '
        'LbNome
        '
        Me.LbNome.AutoSize = True
        Me.LbNome.Location = New System.Drawing.Point(23, 38)
        Me.LbNome.Name = "LbNome"
        Me.LbNome.Size = New System.Drawing.Size(43, 15)
        Me.LbNome.TabIndex = 1
        Me.LbNome.Text = "Nome:"
        '
        'LbTelefone
        '
        Me.LbTelefone.AutoSize = True
        Me.LbTelefone.Location = New System.Drawing.Point(12, 67)
        Me.LbTelefone.Name = "LbTelefone"
        Me.LbTelefone.Size = New System.Drawing.Size(54, 15)
        Me.LbTelefone.TabIndex = 2
        Me.LbTelefone.Text = "Telefone:"
        '
        'Lbemail
        '
        Me.Lbemail.AutoSize = True
        Me.Lbemail.Location = New System.Drawing.Point(211, 67)
        Me.Lbemail.Name = "Lbemail"
        Me.Lbemail.Size = New System.Drawing.Size(44, 15)
        Me.Lbemail.TabIndex = 3
        Me.Lbemail.Text = "E-mail:"
        '
        'TxId
        '
        Me.TxId.Location = New System.Drawing.Point(72, 6)
        Me.TxId.Name = "TxId"
        Me.TxId.Size = New System.Drawing.Size(62, 23)
        Me.TxId.TabIndex = 8
        '
        'TxNome
        '
        Me.TxNome.Location = New System.Drawing.Point(72, 35)
        Me.TxNome.Name = "TxNome"
        Me.TxNome.Size = New System.Drawing.Size(454, 23)
        Me.TxNome.TabIndex = 5
        '
        'TxFone
        '
        Me.TxFone.Location = New System.Drawing.Point(72, 64)
        Me.TxFone.Name = "TxFone"
        Me.TxFone.Size = New System.Drawing.Size(130, 23)
        Me.TxFone.TabIndex = 6
        '
        'TxEmail
        '
        Me.TxEmail.Location = New System.Drawing.Point(261, 64)
        Me.TxEmail.Name = "TxEmail"
        Me.TxEmail.Size = New System.Drawing.Size(265, 23)
        Me.TxEmail.TabIndex = 7
        '
        'BtSalvar
        '
        Me.BtSalvar.Location = New System.Drawing.Point(12, 278)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(101, 23)
        Me.BtSalvar.TabIndex = 8
        Me.BtSalvar.Text = "Salvar"
        Me.BtSalvar.UseVisualStyleBackColor = True
        '
        'BtEditar
        '
        Me.BtEditar.Enabled = False
        Me.BtEditar.Location = New System.Drawing.Point(119, 278)
        Me.BtEditar.Name = "BtEditar"
        Me.BtEditar.Size = New System.Drawing.Size(101, 23)
        Me.BtEditar.TabIndex = 9
        Me.BtEditar.Text = "Editar"
        Me.BtEditar.UseVisualStyleBackColor = True
        '
        'BtDeletar
        '
        Me.BtDeletar.Enabled = False
        Me.BtDeletar.Location = New System.Drawing.Point(226, 278)
        Me.BtDeletar.Name = "BtDeletar"
        Me.BtDeletar.Size = New System.Drawing.Size(101, 23)
        Me.BtDeletar.TabIndex = 10
        Me.BtDeletar.Text = "Deletar"
        Me.BtDeletar.UseVisualStyleBackColor = True
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(333, 278)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(101, 23)
        Me.BtConsultar.TabIndex = 11
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'DgContatos
        '
        Me.DgContatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgContatos.Location = New System.Drawing.Point(12, 93)
        Me.DgContatos.MultiSelect = False
        Me.DgContatos.Name = "DgContatos"
        Me.DgContatos.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgContatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgContatos.RowTemplate.Height = 25
        Me.DgContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgContatos.Size = New System.Drawing.Size(555, 179)
        Me.DgContatos.TabIndex = 12
        '
        'BtLimpar
        '
        Me.BtLimpar.Location = New System.Drawing.Point(440, 278)
        Me.BtLimpar.Name = "BtLimpar"
        Me.BtLimpar.Size = New System.Drawing.Size(101, 23)
        Me.BtLimpar.TabIndex = 13
        Me.BtLimpar.Text = "Limpar Campos"
        Me.BtLimpar.UseVisualStyleBackColor = True
        '
        'FmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 318)
        Me.Controls.Add(Me.BtLimpar)
        Me.Controls.Add(Me.DgContatos)
        Me.Controls.Add(Me.BtConsultar)
        Me.Controls.Add(Me.BtDeletar)
        Me.Controls.Add(Me.BtEditar)
        Me.Controls.Add(Me.BtSalvar)
        Me.Controls.Add(Me.TxEmail)
        Me.Controls.Add(Me.TxFone)
        Me.Controls.Add(Me.TxNome)
        Me.Controls.Add(Me.TxId)
        Me.Controls.Add(Me.Lbemail)
        Me.Controls.Add(Me.LbTelefone)
        Me.Controls.Add(Me.LbNome)
        Me.Controls.Add(Me.LbId)
        Me.MaximizeBox = False
        Me.Name = "FmAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda Contato"
        CType(Me.DgContatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbId As Label
    Friend WithEvents LbNome As Label
    Friend WithEvents LbTelefone As Label
    Friend WithEvents Lbemail As Label
    Friend WithEvents TxId As TextBox
    Friend WithEvents TxNome As TextBox
    Friend WithEvents TxFone As TextBox
    Friend WithEvents TxEmail As TextBox
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtDeletar As Button
    Friend WithEvents BtConsultar As Button
    Friend WithEvents DgContatos As DataGridView
    Friend WithEvents BtLimpar As Button
End Class
