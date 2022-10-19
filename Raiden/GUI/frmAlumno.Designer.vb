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
        Me.txtCarnet = New System.Windows.Forms.TextBox()
        Me.txtDUI = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.cboClase = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtTelFijo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboMunicipio = New System.Windows.Forms.ComboBox()
        Me.cboDepto = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnExaminarFoto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNIE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PageGenerales = New System.Windows.Forms.TabPage()
        Me.PageFamiliares = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboMedioTransporte = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkPartida = New System.Windows.Forms.CheckBox()
        Me.chkNotas = New System.Windows.Forms.CheckBox()
        Me.chkDUI = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEnfermedad = New System.Windows.Forms.TextBox()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabAlumnos.SuspendLayout()
        Me.PageAlumno.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageGenerales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.PageAlumno.Controls.Add(Me.txtCarnet)
        Me.PageAlumno.Controls.Add(Me.txtDUI)
        Me.PageAlumno.Controls.Add(Me.Label14)
        Me.PageAlumno.Controls.Add(Me.Label15)
        Me.PageAlumno.Controls.Add(Me.btnNext)
        Me.PageAlumno.Controls.Add(Me.cboClase)
        Me.PageAlumno.Controls.Add(Me.Label13)
        Me.PageAlumno.Controls.Add(Me.btnLimpiar)
        Me.PageAlumno.Controls.Add(Me.btnSalir)
        Me.PageAlumno.Controls.Add(Me.btnImprimir)
        Me.PageAlumno.Controls.Add(Me.btnAdd)
        Me.PageAlumno.Controls.Add(Me.btnEditar)
        Me.PageAlumno.Controls.Add(Me.btnEliminar)
        Me.PageAlumno.Controls.Add(Me.txtTelFijo)
        Me.PageAlumno.Controls.Add(Me.Label12)
        Me.PageAlumno.Controls.Add(Me.cboMunicipio)
        Me.PageAlumno.Controls.Add(Me.cboDepto)
        Me.PageAlumno.Controls.Add(Me.Label11)
        Me.PageAlumno.Controls.Add(Me.Label10)
        Me.PageAlumno.Controls.Add(Me.btnExaminarFoto)
        Me.PageAlumno.Controls.Add(Me.PictureBox1)
        Me.PageAlumno.Controls.Add(Me.Label9)
        Me.PageAlumno.Controls.Add(Me.Label8)
        Me.PageAlumno.Controls.Add(Me.dtpNacimiento)
        Me.PageAlumno.Controls.Add(Me.cboSexo)
        Me.PageAlumno.Controls.Add(Me.Label7)
        Me.PageAlumno.Controls.Add(Me.txtEmail)
        Me.PageAlumno.Controls.Add(Me.Label6)
        Me.PageAlumno.Controls.Add(Me.txtDireccion)
        Me.PageAlumno.Controls.Add(Me.Label5)
        Me.PageAlumno.Controls.Add(Me.txtApellido)
        Me.PageAlumno.Controls.Add(Me.txtCelular)
        Me.PageAlumno.Controls.Add(Me.txtNombre)
        Me.PageAlumno.Controls.Add(Me.txtNIE)
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
        'txtCarnet
        '
        Me.txtCarnet.Enabled = False
        Me.txtCarnet.Location = New System.Drawing.Point(254, 244)
        Me.txtCarnet.Name = "txtCarnet"
        Me.txtCarnet.Size = New System.Drawing.Size(238, 20)
        Me.txtCarnet.TabIndex = 13
        '
        'txtDUI
        '
        Me.txtDUI.Enabled = False
        Me.txtDUI.Location = New System.Drawing.Point(10, 244)
        Me.txtDUI.Name = "txtDUI"
        Me.txtDUI.Size = New System.Drawing.Size(238, 20)
        Me.txtDUI.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(254, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Carnet"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 228)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "DUI"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(521, 328)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(241, 54)
        Me.btnNext.TabIndex = 20
        Me.btnNext.Text = "->"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'cboClase
        '
        Me.cboClase.Enabled = False
        Me.cboClase.FormattingEnabled = True
        Me.cboClase.Location = New System.Drawing.Point(628, 204)
        Me.cboClase.Name = "cboClase"
        Me.cboClase.Size = New System.Drawing.Size(134, 21)
        Me.cboClase.TabIndex = 11
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
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.Raiden.My.Resources.Resources.escoba
        Me.btnLimpiar.Location = New System.Drawing.Point(346, 327)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(78, 55)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Raiden.My.Resources.Resources.exit32x
        Me.btnSalir.Location = New System.Drawing.Point(430, 327)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 53)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Raiden.My.Resources.Resources.printer32x
        Me.btnImprimir.Location = New System.Drawing.Point(262, 326)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(78, 56)
        Me.btnImprimir.TabIndex = 17
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Raiden.My.Resources.Resources.add32x
        Me.btnAdd.Location = New System.Drawing.Point(10, 326)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 56)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.Raiden.My.Resources.Resources.edit32x
        Me.btnEditar.Location = New System.Drawing.Point(94, 326)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(78, 56)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Raiden.My.Resources.Resources.delete32x
        Me.btnEliminar.Location = New System.Drawing.Point(178, 327)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(78, 54)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtTelFijo
        '
        Me.txtTelFijo.Enabled = False
        Me.txtTelFijo.Location = New System.Drawing.Point(372, 157)
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.Size = New System.Drawing.Size(238, 20)
        Me.txtTelFijo.TabIndex = 6
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
        'cboMunicipio
        '
        Me.cboMunicipio.Enabled = False
        Me.cboMunicipio.FormattingEnabled = True
        Me.cboMunicipio.Location = New System.Drawing.Point(200, 205)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Size = New System.Drawing.Size(173, 21)
        Me.cboMunicipio.TabIndex = 8
        '
        'cboDepto
        '
        Me.cboDepto.Enabled = False
        Me.cboDepto.FormattingEnabled = True
        Me.cboDepto.Location = New System.Drawing.Point(10, 204)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Size = New System.Drawing.Size(184, 21)
        Me.cboDepto.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Departamento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(197, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Municipio"
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
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(618, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 154)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(502, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fecha de Nacimiento"
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(510, 205)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(112, 20)
        Me.dtpNacimiento.TabIndex = 10
        '
        'cboSexo
        '
        Me.cboSexo.Enabled = False
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cboSexo.Location = New System.Drawing.Point(379, 204)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(125, 21)
        Me.cboSexo.TabIndex = 9
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
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(372, 75)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(238, 20)
        Me.txtEmail.TabIndex = 4
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
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(6, 75)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(360, 102)
        Me.txtDireccion.TabIndex = 3
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
        'txtApellido
        '
        Me.txtApellido.Enabled = False
        Me.txtApellido.Location = New System.Drawing.Point(372, 23)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(238, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtCelular
        '
        Me.txtCelular.Enabled = False
        Me.txtCelular.Location = New System.Drawing.Point(372, 114)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(238, 20)
        Me.txtCelular.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(128, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(238, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtNIE
        '
        Me.txtNIE.Enabled = False
        Me.txtNIE.Location = New System.Drawing.Point(10, 24)
        Me.txtNIE.Name = "txtNIE"
        Me.txtNIE.Size = New System.Drawing.Size(112, 20)
        Me.txtNIE.TabIndex = 0
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIE"
        '
        'PageGenerales
        '
        Me.PageGenerales.Controls.Add(Me.txtTratamiento)
        Me.PageGenerales.Controls.Add(Me.Label18)
        Me.PageGenerales.Controls.Add(Me.txtEnfermedad)
        Me.PageGenerales.Controls.Add(Me.Label17)
        Me.PageGenerales.Controls.Add(Me.GroupBox1)
        Me.PageGenerales.Controls.Add(Me.cboMedioTransporte)
        Me.PageGenerales.Controls.Add(Me.Label16)
        Me.PageGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PageGenerales.Location = New System.Drawing.Point(4, 34)
        Me.PageGenerales.Name = "PageGenerales"
        Me.PageGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.PageGenerales.Size = New System.Drawing.Size(768, 388)
        Me.PageGenerales.TabIndex = 1
        Me.PageGenerales.Text = "Datos Generales"
        Me.PageGenerales.UseVisualStyleBackColor = True
        '
        'PageFamiliares
        '
        Me.PageFamiliares.Location = New System.Drawing.Point(4, 34)
        Me.PageFamiliares.Name = "PageFamiliares"
        Me.PageFamiliares.Size = New System.Drawing.Size(768, 388)
        Me.PageFamiliares.TabIndex = 2
        Me.PageFamiliares.Text = "Datos de la Familia"
        Me.PageFamiliares.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Medio de Transporte"
        '
        'cboMedioTransporte
        '
        Me.cboMedioTransporte.FormattingEnabled = True
        Me.cboMedioTransporte.Location = New System.Drawing.Point(22, 44)
        Me.cboMedioTransporte.Name = "cboMedioTransporte"
        Me.cboMedioTransporte.Size = New System.Drawing.Size(209, 21)
        Me.cboMedioTransporte.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDUI)
        Me.GroupBox1.Controls.Add(Me.chkNotas)
        Me.GroupBox1.Controls.Add(Me.chkPartida)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 70)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documentos Presentados"
        '
        'chkPartida
        '
        Me.chkPartida.AutoSize = True
        Me.chkPartida.Location = New System.Drawing.Point(16, 32)
        Me.chkPartida.Name = "chkPartida"
        Me.chkPartida.Size = New System.Drawing.Size(130, 17)
        Me.chkPartida.TabIndex = 0
        Me.chkPartida.Text = "Partida de Nacimiento"
        Me.chkPartida.UseVisualStyleBackColor = True
        '
        'chkNotas
        '
        Me.chkNotas.AutoSize = True
        Me.chkNotas.Location = New System.Drawing.Point(152, 32)
        Me.chkNotas.Name = "chkNotas"
        Me.chkNotas.Size = New System.Drawing.Size(102, 17)
        Me.chkNotas.TabIndex = 1
        Me.chkNotas.Text = "Boleta de Notas"
        Me.chkNotas.UseVisualStyleBackColor = True
        '
        'chkDUI
        '
        Me.chkDUI.AutoSize = True
        Me.chkDUI.Location = New System.Drawing.Point(260, 32)
        Me.chkDUI.Name = "chkDUI"
        Me.chkDUI.Size = New System.Drawing.Size(45, 17)
        Me.chkDUI.TabIndex = 2
        Me.chkDUI.Text = "DUI"
        Me.chkDUI.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 217)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(257, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Si padece de alguna enfermedad, por favor explique:"
        '
        'txtEnfermedad
        '
        Me.txtEnfermedad.Location = New System.Drawing.Point(25, 233)
        Me.txtEnfermedad.Name = "txtEnfermedad"
        Me.txtEnfermedad.Size = New System.Drawing.Size(715, 20)
        Me.txtEnfermedad.TabIndex = 4
        '
        'txtTratamiento
        '
        Me.txtTratamiento.Location = New System.Drawing.Point(25, 284)
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(715, 74)
        Me.txtTratamiento.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 268)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(272, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Si padece de alguna enfermedad: Detalle el tratameinto."
        '
        'frmAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabAlumnos)
        Me.Name = "frmAlumno"
        Me.Text = "frmAlumno"
        Me.TabAlumnos.ResumeLayout(False)
        Me.PageAlumno.ResumeLayout(False)
        Me.PageAlumno.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageGenerales.ResumeLayout(False)
        Me.PageGenerales.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabAlumnos As TabControl
    Friend WithEvents PageAlumno As TabPage
    Friend WithEvents PageGenerales As TabPage
    Friend WithEvents PageFamiliares As TabPage
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNIE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents btnExaminarFoto As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents cboSexo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelFijo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboMunicipio As ComboBox
    Friend WithEvents cboDepto As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents cboClase As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtCarnet As TextBox
    Friend WithEvents txtDUI As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cboMedioTransporte As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkDUI As CheckBox
    Friend WithEvents chkNotas As CheckBox
    Friend WithEvents chkPartida As CheckBox
    Friend WithEvents txtEnfermedad As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTratamiento As TextBox
    Friend WithEvents Label18 As Label
End Class
