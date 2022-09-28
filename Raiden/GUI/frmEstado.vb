Imports DATA
Public Class frmEstado

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        Dim campos, valores As List(Of String)

        campos = New List(Of String)
        valores = New List(Of String)

        campos.Add("estado")
        valores.Add(txtEstado.Text)

        If (Tabla.Insert("estado", campos, valores) > 0) Then
            MessageBox.Show("Registro agregado, se agrego el estado: " + txtEstado.Text, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtEstado.ResetText()
    End Sub

    Private Sub frmEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridEstados()
    End Sub

    Private Sub cargarGridEstados()
        CLS.Funciones.FillGridView(dgvEstado, "Estado", True)
    End Sub

    Private Sub filtrarEstado()
        Dim Tabla As CLS.QUERY = New CLS.QUERY
        Dim DT As DataTable
        DT = Tabla.GetRecordsFiltersLike("Estado", "Estado", txtEstado.Text)
        CLS.Funciones.FillGridView(dgvEstado, DT, True)
    End Sub

    Private Sub txtEstado_TextChanged(sender As Object, e As EventArgs) Handles txtEstado.TextChanged
        filtrarEstado()
    End Sub

    Private Sub dgvEstado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstado.CellClick
        txtIdEstado.Text = dgvEstado.CurrentRow.Cells("idEstado").Value.ToString
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtEstado.ResetText()
        txtIdEstado.ResetText()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        If (Tabla.Delete("Estado", "idEstado", dgvEstado.CurrentRow.Cells("idEstado").Value.ToString)) Then
            MessageBox.Show("Registro eliminado, se elimino el Estado: " + dgvEstado.CurrentRow.Cells("estado").Value.ToString, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        cargarGridEstados()

        txtIdEstado.ResetText()
    End Sub

End Class