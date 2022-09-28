<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumno
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
        Me.TabAlumnos = New System.Windows.Forms.TabControl()
        Me.PageAlumno = New System.Windows.Forms.TabPage()
        Me.PageGenerales = New System.Windows.Forms.TabPage()
        Me.PageFamiliares = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExaminarFoto = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabAlumnos.SuspendLayout()
        Me.PageAlumno.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabAlumnos
        '
        Me.TabAlumnos.Controls.Add(Me.PageAlumno)
        Me.TabAlumnos.Controls.Add(Me.PageGenerales)
        Me.TabAlumnos.Controls.Add(Me.PageFamiliares)
        Me.TabAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabAlumnos.ItemSize = New System.Drawing.Size(350, 30)
        Me.TabAlumnos.Location = New System.Drawing.Point(12, 12)
        Me.TabAlumnos.MinimumSize = New System.Drawing.Size(776, 426)
        Me.TabAlumnos.Name = "TabAlumnos"
        Me.TabAlumnos.SelectedIndex = 0
        Me.TabAlumnos.Size = New System.Drawing.Size(776, 426)
        Me.TabAlumnos.TabIndex = 0
        '
        'PageAlumno
        '
        Me.PageAlumno.Controls.Add(Me.ComboBox4)
        Me.PageAlumno.Controls.Add(Me.Label13)
        Me.PageAlumno.Controls.Add(Me.btnLimpiar)
        Me.PageAlumno.Controls.Add(Me.btnSalir)
        Me.PageAlumno.Controls.Add(Me.btnImprimir)
        Me.PageAlumno.Controls.Add(Me.btnBuscar)
        Me.PageAlumno.Controls.Add(Me.btnEditar)
        Me.PageAlumno.Controls.Add(Me.btnEliminar)
        Me.PageAlumno.Controls.Add(Me.TextBox7)
        Me.PageAlumno.Controls.Add(Me.Label12)
        Me.PageAlumno.Controls.Add(Me.ComboBox3)
        Me.PageAlumno.Controls.Add(Me.ComboBox2)
        Me.PageAlumno.Controls.Add(Me.Label11)
        Me.PageAlumno.Controls.Add(Me.Label10)
        Me.PageAlumno.Controls.Add(Me.btnExaminarFoto)
        Me.PageAlumno.Controls.Add(Me.PictureBox1)
        Me.PageAlumno.Controls.Add(Me.Label9)
        Me.PageAlumno.Controls.Add(Me.Label8)
        Me.PageAlumno.Controls.Add(Me.DateTimePicker1)
        Me.PageAlumno.Controls.Add(Me.ComboBox1)
        Me.PageAlumno.Controls.Add(Me.Label7)
        Me.PageAlumno.Controls.Add(Me.TextBox6)
        Me.PageAlumno.Controls.Add(Me.Label6)
        Me.PageAlumno.Controls.Add(Me.TextBox5)
        Me.PageAlumno.Controls.Add(Me.Label5)
        Me.PageAlumno.Controls.Add(Me.TextBox3)
        Me.PageAlumno.Controls.Add(Me.TextBox4)
        Me.PageAlumno.Controls.Add(Me.TextBox2)
        Me.PageAlumno.Controls.Add(Me.TextBox1)
        Me.PageAlumno.Controls.Add(Me.Label4)
        Me.PageAlumno.Controls.Add(Me.Label3)
        Me.PageAlumno.Controls.Add(Me.Label2)
        Me.PageAlumno.Controls.Add(Me.Label1)
        Me.PageAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageAlumno.Location = New System.Drawing.Point(4, 34)
        Me.PageAlumno.Name = "PageAlumno"
        Me.PageAlumno.Padding = New System.Windows.Forms.Padding(3)
        Me.PageAlumno.Size = New System.Drawing.Size(768, 388)
        Me.PageAlumno.TabIndex = 0
        Me.PageAlumno.Text = "Datos del Alumno"
        Me.PageAlumno.UseVisualStyleBackColor = True
        '
        'PageGenerales
        '
        Me.PageGenerales.Location = New System.Drawing.Point(4, 29)
        Me.PageGenerales.Name = "PageGenerales"
        Me.PageGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.PageGenerales.Size = New System.Drawing.Size(768, 393)
        Me.PageGenerales.TabIndex = 1
        Me.PageGenerales.Text = "Datos Generales"
        Me.PageGenerales.UseVisualStyleBackColor = True
        '
        'PageFamiliares
        '
        Me.PageFamiliares.Location = New System.Drawing.Point(4, 29)
        Me.PageFamiliares.Name = "PageFamiliares"
        Me.PageFamiliares.Size = New System.Drawing.Size(768, 393)
        Me.PageFamiliares.TabIndex = 2
        Me.PageFamiliares.Text = "Datos de la Familia"
        Me.PageFamiliares.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono Movil"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(128, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(238, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(372, 114)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(238, 20)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(372, 23)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(238, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Direccion"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 75)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(360, 102)
        Me.TextBox5.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Correo"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(372, 75)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(238, 20)
        Me.TextBox6.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(376, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Sexo"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(379, 204)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(510, 205)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(502, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fecha de Nacimiento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(615, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fotografia"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(618, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 154)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btnExaminarFoto
        '
        Me.btnExaminarFoto.Location = New System.Drawing.Point(687, 6)
        Me.btnExaminarFoto.Name = "btnExaminarFoto"
        Me.btnExaminarFoto.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminarFoto.TabIndex = 19
        Me.btnExaminarFoto.Text = "Examinar"
        Me.btnExaminarFoto.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Municipio"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(186, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Departamento"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(189, 204)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox2.TabIndex = 22
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(10, 204)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(173, 21)
        Me.ComboBox3.TabIndex = 23
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(372, 157)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(238, 20)
        Me.TextBox7.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(369, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Telefono Fijo"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Raiden.My.Resources.Resources.exit32x
        Me.btnSalir.Location = New System.Drawing.Point(414, 318)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 42)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Raiden.My.Resources.Resources.printer32x
        Me.btnImprimir.Location = New System.Drawing.Point(253, 317)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 45)
        Me.btnImprimir.TabIndex = 29
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Raiden.My.Resources.Resources.search32x
        Me.btnBuscar.Location = New System.Drawing.Point(172, 317)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 45)
        Me.btnBuscar.TabIndex = 28
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.Raiden.My.Resources.Resources.edit32x
        Me.btnEditar.Location = New System.Drawing.Point(91, 317)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 45)
        Me.btnEditar.TabIndex = 27
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Raiden.My.Resources.Resources.delete32x
        Me.btnEliminar.Location = New System.Drawing.Point(10, 317)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 43)
        Me.btnEliminar.TabIndex = 26
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.Raiden.My.Resources.Resources.escoba
        Me.btnLimpiar.Location = New System.Drawing.Point(333, 318)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 44)
        Me.btnLimpiar.TabIndex = 43
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(628, 204)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox4.TabIndex = 45
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(625, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Clase"
        '
        'frmAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabAlumnos)
        Me.Name = "frmAlumno"
        Me.Text = "frmAlumno"
        Me.TabAlumnos.ResumeLayout(False)
        Me.PageAlumno.ResumeLayout(False)
        Me.PageAlumno.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabAlumnos As TabControl
    Friend WithEvents PageAlumno As TabPage
    Friend WithEvents PageGenerales As TabPage
    Friend WithEvents PageFamiliares As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnExaminarFoto As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnLimpiar As Button
End Class
