<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriodo
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgvPeriodo = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.txtIdPeriodo = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dgvPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.Raiden.My.Resources.Resources.escoba
        Me.btnLimpiar.Location = New System.Drawing.Point(105, 332)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 39)
        Me.btnLimpiar.TabIndex = 42
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgvPeriodo
        '
        Me.dgvPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeriodo.Location = New System.Drawing.Point(24, 73)
        Me.dgvPeriodo.Name = "dgvPeriodo"
        Me.dgvPeriodo.Size = New System.Drawing.Size(587, 253)
        Me.dgvPeriodo.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "ID Periodo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Periodo"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Raiden.My.Resources.Resources.exit32x
        Me.btnSalir.Location = New System.Drawing.Point(348, 332)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 39)
        Me.btnSalir.TabIndex = 38
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Raiden.My.Resources.Resources.delete32x
        Me.btnEliminar.Location = New System.Drawing.Point(24, 332)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 39)
        Me.btnEliminar.TabIndex = 37
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(536, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 36
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(139, 33)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(391, 20)
        Me.txtPeriodo.TabIndex = 35
        '
        'txtIdPeriodo
        '
        Me.txtIdPeriodo.Enabled = False
        Me.txtIdPeriodo.Location = New System.Drawing.Point(24, 33)
        Me.txtIdPeriodo.Name = "txtIdPeriodo"
        Me.txtIdPeriodo.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPeriodo.TabIndex = 34
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Raiden.My.Resources.Resources.search32x
        Me.btnBuscar.Location = New System.Drawing.Point(186, 332)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Raiden.My.Resources.Resources.printer32x
        Me.btnImprimir.Location = New System.Drawing.Point(267, 332)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 39)
        Me.btnImprimir.TabIndex = 44
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 404)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.dgvPeriodo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.txtIdPeriodo)
        Me.Name = "frmPeriodo"
        Me.Text = "Elaborado por: Oscar Ivan Linares Alvarado"
        CType(Me.dgvPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dgvPeriodo As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtPeriodo As TextBox
    Friend WithEvents txtIdPeriodo As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnImprimir As Button
End Class
