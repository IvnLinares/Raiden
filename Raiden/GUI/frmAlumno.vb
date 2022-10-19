Imports DATA.CLS

Public Class frmAlumno

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (DATA.CLS.Funciones.CompareImages(btnAdd.Image, My.Resources.add32x)) Then
            'Comportar como boton nuevo
            btnAdd.Image = My.Resources.save32x
            DATA.CLS.Funciones.enabledTextBox(PageAlumno, True)
            DATA.CLS.Funciones.enabledComboBox(PageAlumno, True)
        Else
            'Comportar como boton guardar

            'validar que no existan datos vacios
            Dim tblEstudiante As Estudiante = New Estudiante

            tblEstudiante.NIE = txtNIE.Text
            tblEstudiante.nombres = txtNombre.Text
            tblEstudiante.apellidos = txtApellido.Text
            tblEstudiante.idClase = cboClase.SelectedValue.ToString
            tblEstudiante.idEstado = 3
            tblEstudiante.idMunicipio = cboMunicipio.SelectedValue.ToString
            tblEstudiante.direccion = txtDireccion.Text
            tblEstudiante.correo = txtEmail.Text
            tblEstudiante.telefono = txtTelFijo.Text
            tblEstudiante.celular = txtCelular.Text
            tblEstudiante.fecha_nacimiento = Format(dtpNacimiento.Value, "yyy/MM/dd")
            tblEstudiante.genero = cboSexo.Text
            tblEstudiante.fecha_ingreso = Format(Date.Today, "yyyy/MM/dd")
            tblEstudiante.foto = ""
            tblEstudiante.DUI = txtDUI.Text
            tblEstudiante.carnet = txtCarnet.Text

            If tblEstudiante.Insert() > 0 Then

                MessageBox.Show("Registro Agregado", ProductVersion, MessageBoxButtons.OK)
                btnAdd.Image = My.Resources.add32x
                DATA.CLS.Funciones.enabledTextBox(PageAlumno, False)
                DATA.CLS.Funciones.enabledComboBox(PageAlumno, False)
            End If


        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarClase()
        cargarDeptos()
    End Sub

    Private Sub cargarDeptos()
        Funciones.FillCombobox(cboDepto, "departamento", "idDepto", "departamento")
    End Sub

    Private Sub cargarClase()
        Funciones.FillCombobox(cboClase, "clase", "idClase", "clase")
    End Sub

    Private Sub filtrarMunicipio()

        If cboDepto.Enabled Then
            Dim tabla As QUERY = New QUERY
            Dim DT As DataTable = New DataTable

            DT = tabla.GetRecords("departamento")

            If DT.Rows.Count > 0 Then
                cboMunicipio.DataSource = tabla.GetRecordsFilters("Municipio", "idDepto", cboDepto.SelectedValue.ToString())
                cboMunicipio.DisplayMember = "Municipio"
                cboMunicipio.ValueMember = "idMunicipio"

            End If
        End If

    End Sub


    Private Sub cboDepto_TextChanged(sender As Object, e As EventArgs) Handles cboDepto.TextChanged
        filtrarMunicipio()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Funciones.clearTextBox(PageAlumno)
    End Sub

End Class