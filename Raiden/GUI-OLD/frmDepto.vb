Imports DATA
Public Class frmDepto


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        Dim campos, valores As List(Of String)

        campos = New List(Of String)
        valores = New List(Of String)

        campos.Add("departamento")
        valores.Add(txtDepto.Text)

        If (Tabla.Insert("departamento", campos, valores) > 0) Then
            MessageBox.Show("Registro agregado, se agrego el departamento: " + txtDepto.Text, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtDepto.ResetText()
    End Sub

    Private Sub frmDepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridDeptos()
    End Sub

    Private Sub cargarGridDeptos()
        CLS.Funciones.FillGridView(dgvDepto, "Departamento", True)
    End Sub

    Private Sub filtrarDepto()
        Dim Tabla As CLS.QUERY = New CLS.QUERY
        Dim DT As DataTable
        DT = Tabla.GetRecordsFiltersLike("Departamento", "Departamento", txtDepto.Text)
        CLS.Funciones.FillGridView(dgvDepto, DT, True)
    End Sub

    Private Sub txtDepto_TextChanged(sender As Object, e As EventArgs) Handles txtDepto.TextChanged
        filtrarDepto()
    End Sub

    Private Sub dgvDepto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepto.CellClick
        txtIdDepto.Text = dgvDepto.CurrentRow.Cells("idDepto").Value.ToString
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDepto.ResetText()
        txtIdDepto.ResetText()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        If (Tabla.Delete("Departamento", "idDepto", dgvDepto.CurrentRow.Cells("idDepto").Value.ToString)) Then
            MessageBox.Show("Registro eliminado, se elimino el departamento: " + dgvDepto.CurrentRow.Cells("departamento").Value.ToString, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        cargarGridDeptos()

        txtIdDepto.ResetText()
    End Sub


End Class



