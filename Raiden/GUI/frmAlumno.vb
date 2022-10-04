Imports DATA.CLS

Public Class frmAlumno
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PageAlumno_Click(sender As Object, e As EventArgs) Handles PageAlumno.Click

    End Sub

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
            tblEstudiante.nombre = txtNombre.Text
            tblEstudiante.apellido = txtApellido.Text
            tblEstudiante.idClase = cboClase.SelectedValue.ToString
            tblEstudiante.idEstado = 1
            tblEstudiante.idMunicipio = cboMunicipio.SelectedValue.ToString
            tblEstudiante.direccion = txtDireccion.Text
            tblEstudiante.correo = txtEmail.Text
            tblEstudiante.telefono = txtTelFijo.Text
            tblEstudiante.celular = txtCelular.Text
            tblEstudiante.fecha_nacimiento = dtpNacimiento.Value.ToShortDateString
            tblEstudiante.genero = cboSexo.Text
            tblEstudiante.fecha_ingreso = Date.Today.ToShortDateString
            If tblEstudiante.Insert() > 0 Then

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
End Class