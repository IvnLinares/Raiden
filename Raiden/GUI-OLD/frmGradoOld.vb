Imports DATA
Public Class frmGradoOld
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        Dim campos, valores As List(Of String)

        campos = New List(Of String)
        valores = New List(Of String)

        campos.Add("grado")
        valores.Add(txtGrado.Text)
        campos.Add("orden")
        valores.Add(txtOrden.Text)

        If (Tabla.Insert("grado", campos, valores) > 0) Then
            MessageBox.Show("Registro agregado, se agrego el grado: " + txtGrado.Text + ", y orden: " + txtOrden.Text, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtGrado.ResetText()
        txtOrden.ResetText()
    End Sub

    Private Sub txtOrden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrden.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cargarGridGrados()
        CLS.Funciones.FillGridView(dgvGrado, "Grado", True)
    End Sub

    Private Sub frmGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridGrados()
    End Sub

    Private Sub filtrarGrado()
        Dim Tabla As CLS.QUERY = New CLS.QUERY
        Dim DT As DataTable
        DT = Tabla.GetRecordsFiltersLike("Grado", "Grado", txtGrado.Text)
        CLS.Funciones.FillGridView(dgvGrado, DT, True)
    End Sub

    Private Sub filtrarOrden()
        Dim Tabla As CLS.QUERY = New CLS.QUERY
        Dim DT As DataTable
        DT = Tabla.GetRecordsFiltersLike("Grado", "Orden", txtGrado.Text)
        CLS.Funciones.FillGridView(dgvGrado, DT, True)
    End Sub

    Private Sub txtGrado_TextChanged(sender As Object, e As EventArgs) Handles txtGrado.TextChanged
        filtrarGrado()
    End Sub

    Private Sub txtOrden_TextChanged(sender As Object, e As EventArgs) Handles txtOrden.TextChanged
        filtrarOrden()
    End Sub

    Private Sub dgvGrado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrado.CellClick
        txtIdGrado.Text = dgvGrado.CurrentRow.Cells("idGrado").Value.ToString
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtGrado.ResetText()
        txtIdGrado.ResetText()
        txtOrden.ResetText()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        If (Tabla.Delete("Grado", "idGrado", dgvGrado.CurrentRow.Cells("IdGrado").Value.ToString)) Then
            MessageBox.Show("Registro eliminado, se elimino el Grado: " + dgvGrado.CurrentRow.Cells("grado").Value.ToString + " con orden: " + dgvGrado.CurrentRow.Cells("orden").Value.ToString, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        cargarGridGrados()

        txtIdGrado.ResetText()
    End Sub

    Private Sub dgvGrado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrado.CellContentClick

    End Sub
End Class