Public Class frmGrado
    Private _imgBtnNuevo As Image = My.Resources.add_64x
    Private Sub btnNuevoGuardar_Click(sender As Object, e As EventArgs) Handles btnNuevoGuardar.Click

        If (DATA.CLS.Funciones.CompareImages(btnNuevoGuardar.Image, My.Resources.add_64x)) Then

            btnNuevoGuardar.Image = My.Resources.floppy_64x 'Guardar
            btnEditar.Image = My.Resources.cancel_64x ' Cancelar
            txtGrado.ReadOnly = False
        Else
            If (txtGrado.TextLength > 0 And cboOrden.Text.Length > 0) Then
                If (txtId.TextLength > 0) Then
                    Dim tblGrado As Grado = New Grado()
                    tblGrado.idGrado = Integer.Parse(txtId.Text)
                    tblGrado.grado = txtGrado.Text
                    tblGrado.orden = Integer.Parse(cboOrden.Text)
                    If (tblGrado.Update() > 0) Then
                        MessageBox.Show("Registro actualizado", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    Dim tblGrado As Grado = New Grado()
                    tblGrado.grado = txtGrado.Text
                    tblGrado.orden = Integer.Parse(cboOrden.Text)
                    If (tblGrado.Insert() > 0) Then
                        MessageBox.Show("Registro agregado", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                btnNuevoGuardar.Image = My.Resources.add_64x 'Nuevo
                btnEditar.Image = My.Resources.edit_64x
                txtGrado.ReadOnly = True
                txtId.ResetText()
                txtGrado.ResetText()
                cboOrden.ResetText()
            End If
        End If

        cargarGrado()
    End Sub

    Private Sub cargarGrado()
        DATA.CLS.Funciones.FillGridView(dgvGrado, "grado")
    End Sub

    Private Sub frmGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrado()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (DATA.CLS.Funciones.CompareImages(btnEditar.Image, My.Resources.edit_64x)) Then
            If dgvGrado.RowCount > 0 Then
                btnNuevoGuardar.Image = My.Resources.floppy_64x
                btnEditar.Image = My.Resources.cancel_64x

                txtId.Text = dgvGrado.CurrentRow.Cells("idGrado").Value.ToString
                txtGrado.Text = dgvGrado.CurrentRow.Cells("Grado").Value.ToString
                cboOrden.Text = dgvGrado.CurrentRow.Cells("Orden").Value.ToString
                txtGrado.ReadOnly = False
            End If
        Else
            btnNuevoGuardar.Image = My.Resources.add_64x
            btnEditar.Image = My.Resources.edit_64x
            txtId.Text = ""
            txtGrado.Text = ""
            cboOrden.Text = ""
            txtGrado.ReadOnly = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim tblGrado As Grado = New Grado
        tblGrado.idGrado = dgvGrado.CurrentRow.Cells("idGrado").Value.ToString
        If (tblGrado.Delete() > 0) Then
            MessageBox.Show("Registro eliminado", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        cargarGrado()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvGrado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrado.CellContentClick

    End Sub
End Class
