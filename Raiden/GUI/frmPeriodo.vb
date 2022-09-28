Imports DATA
Public Class frmPeriodo
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        Dim campos, valores As List(Of String)

        campos = New List(Of String)
        valores = New List(Of String)

        campos.Add("periodo")
        valores.Add(txtPeriodo.Text)

        If (Tabla.Insert("periodo", campos, valores) > 0) Then
            MessageBox.Show("Registro agregado, se agrego el periodo: " + txtPeriodo.Text, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtPeriodo.ResetText()
    End Sub

    Private Sub cargarGridPeriodos()
        CLS.Funciones.FillGridView(dgvPeriodo, "Periodo", True)
    End Sub

    Private Sub filtrarPeriodo()
        Dim Tabla As CLS.QUERY = New CLS.QUERY
        Dim DT As DataTable
        DT = Tabla.GetRecordsFiltersLike("Periodo", "Periodo", txtPeriodo.Text)
        CLS.Funciones.FillGridView(dgvPeriodo, DT, True)
    End Sub

    Private Sub frmPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridPeriodos()
    End Sub

    Private Sub txtPeriodo_TextChanged(sender As Object, e As EventArgs) Handles txtPeriodo.TextChanged
        filtrarPeriodo()
    End Sub

    Private Sub dgvPeriodo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeriodo.CellClick
        txtIdPeriodo.Text = dgvPeriodo.CurrentRow.Cells("idPeriodo").Value.ToString
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtIdPeriodo.ResetText()
        txtPeriodo.ResetText()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        If (Tabla.Delete("Periodo", "idPeriodo", dgvPeriodo.CurrentRow.Cells("idPeriodo").Value.ToString)) Then
            MessageBox.Show("Registro eliminado, se elimino el periodo: " + dgvPeriodo.CurrentRow.Cells("periodo").Value.ToString, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        cargarGridPeriodos()

        txtIdPeriodo.ResetText()
    End Sub


End Class