<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbMateria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvMateria = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnMateria = New System.Windows.Forms.RadioButton()
        Me.rbtnIdMateria = New System.Windows.Forms.RadioButton()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.idMateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvMateria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(91, 43)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(350, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'dgvMateria
        '
        Me.dgvMateria.AllowUserToAddRows = False
        Me.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMateria, Me.Materia})
        Me.dgvMateria.Location = New System.Drawing.Point(12, 87)
        Me.dgvMateria.Name = "dgvMateria"
        Me.dgvMateria.RowHeadersVisible = False
        Me.dgvMateria.Size = New System.Drawing.Size(447, 229)
        Me.dgvMateria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Texto a Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnMateria)
        Me.GroupBox1.Controls.Add(Me.rbtnIdMateria)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 69)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'rbtnMateria
        '
        Me.rbtnMateria.AutoSize = True
        Me.rbtnMateria.Checked = True
        Me.rbtnMateria.Location = New System.Drawing.Point(176, 19)
        Me.rbtnMateria.Name = "rbtnMateria"
        Me.rbtnMateria.Size = New System.Drawing.Size(60, 17)
        Me.rbtnMateria.TabIndex = 4
        Me.rbtnMateria.TabStop = True
        Me.rbtnMateria.Text = "Materia"
        Me.rbtnMateria.UseVisualStyleBackColor = True
        '
        'rbtnIdMateria
        '
        Me.rbtnIdMateria.AutoSize = True
        Me.rbtnIdMateria.Location = New System.Drawing.Point(91, 19)
        Me.rbtnIdMateria.Name = "rbtnIdMateria"
        Me.rbtnIdMateria.Size = New System.Drawing.Size(68, 17)
        Me.rbtnIdMateria.TabIndex = 3
        Me.rbtnIdMateria.TabStop = True
        Me.rbtnIdMateria.Text = "idMateria"
        Me.rbtnIdMateria.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 322)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(447, 34)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'idMateria
        '
        Me.idMateria.DataPropertyName = "idMateria"
        Me.idMateria.HeaderText = "idMateria"
        Me.idMateria.Name = "idMateria"
        Me.idMateria.Width = 75
        '
        'Materia
        '
        Me.Materia.DataPropertyName = "Materia"
        Me.Materia.HeaderText = "Materia"
        Me.Materia.Name = "Materia"
        Me.Materia.Width = 325
        '
        'frmbMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 367)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvMateria)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmbMateria"
        Me.Text = "frmbMateria"
        CType(Me.dgvMateria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvMateria As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnMateria As RadioButton
    Friend WithEvents rbtnIdMateria As RadioButton
    Friend WithEvents btnSalir As Button
    Friend WithEvents idMateria As DataGridViewTextBoxColumn
    Friend WithEvents Materia As DataGridViewTextBoxColumn
End Class
