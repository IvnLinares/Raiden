<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeptopsMunicipios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.btnAddDepto = New System.Windows.Forms.Button()
        Me.btnAddMunicipio = New System.Windows.Forms.Button()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDeptos = New System.Windows.Forms.DataGridView()
        Me.dgvMunicipios = New System.Windows.Forms.DataGridView()
        Me.idMunicipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idDepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDeptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMunicipios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(15, 39)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(224, 20)
        Me.txtDepartamento.TabIndex = 1
        '
        'btnAddDepto
        '
        Me.btnAddDepto.Location = New System.Drawing.Point(245, 37)
        Me.btnAddDepto.Name = "btnAddDepto"
        Me.btnAddDepto.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDepto.TabIndex = 2
        Me.btnAddDepto.Text = "Agregar"
        Me.btnAddDepto.UseVisualStyleBackColor = True
        '
        'btnAddMunicipio
        '
        Me.btnAddMunicipio.Location = New System.Drawing.Point(598, 36)
        Me.btnAddMunicipio.Name = "btnAddMunicipio"
        Me.btnAddMunicipio.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMunicipio.TabIndex = 5
        Me.btnAddMunicipio.Text = "Agregar"
        Me.btnAddMunicipio.UseVisualStyleBackColor = True
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(339, 39)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(253, 20)
        Me.txtMunicipio.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Municipio"
        '
        'dgvDeptos
        '
        Me.dgvDeptos.AllowDrop = True
        Me.dgvDeptos.AllowUserToAddRows = False
        Me.dgvDeptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idDepto, Me.Departamento})
        Me.dgvDeptos.Location = New System.Drawing.Point(15, 66)
        Me.dgvDeptos.Name = "dgvDeptos"
        Me.dgvDeptos.RowHeadersVisible = False
        Me.dgvDeptos.Size = New System.Drawing.Size(305, 324)
        Me.dgvDeptos.TabIndex = 6
        '
        'dgvMunicipios
        '
        Me.dgvMunicipios.AllowUserToAddRows = False
        Me.dgvMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMunicipios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMunicipio, Me.Municipio})
        Me.dgvMunicipios.Location = New System.Drawing.Point(339, 66)
        Me.dgvMunicipios.Name = "dgvMunicipios"
        Me.dgvMunicipios.RowHeadersVisible = False
        Me.dgvMunicipios.Size = New System.Drawing.Size(334, 324)
        Me.dgvMunicipios.TabIndex = 7
        '
        'idMunicipio
        '
        Me.idMunicipio.DataPropertyName = "idMunicipio"
        Me.idMunicipio.HeaderText = "ID"
        Me.idMunicipio.Name = "idMunicipio"
        Me.idMunicipio.Width = 50
        '
        'Municipio
        '
        Me.Municipio.DataPropertyName = "Municipio"
        Me.Municipio.HeaderText = "Municipio"
        Me.Municipio.Name = "Municipio"
        Me.Municipio.Width = 300
        '
        'idDepto
        '
        Me.idDepto.DataPropertyName = "idDepto"
        Me.idDepto.HeaderText = "ID"
        Me.idDepto.Name = "idDepto"
        Me.idDepto.Width = 50
        '
        'Departamento
        '
        Me.Departamento.DataPropertyName = "Departamento"
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Width = 250
        '
        'frmDeptopsMunicipios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 450)
        Me.Controls.Add(Me.dgvMunicipios)
        Me.Controls.Add(Me.dgvDeptos)
        Me.Controls.Add(Me.btnAddMunicipio)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddDepto)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDeptopsMunicipios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de departamentos y municipios"
        CType(Me.dgvDeptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMunicipios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents btnAddDepto As Button
    Friend WithEvents btnAddMunicipio As Button
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDeptos As DataGridView
    Friend WithEvents dgvMunicipios As DataGridView
    Friend WithEvents idMunicipio As DataGridViewTextBoxColumn
    Friend WithEvents Municipio As DataGridViewTextBoxColumn
    Friend WithEvents idDepto As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
End Class
