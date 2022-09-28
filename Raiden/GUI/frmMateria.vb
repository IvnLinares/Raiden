Imports DATA
Public Class frmMateria
    Dim frmBuscar As frmbMateria = New frmbMateria


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        Dim campos, valores As List(Of String)

        campos = New List(Of String)
        valores = New List(Of String)

        campos.Add("Materia")
        valores.Add(txtMateria.Text)

        If (Tabla.Insert("Materia", campos, valores) > 0) Then
            MessageBox.Show("Registro agregado, se agrego la materia: " + txtMateria.Text, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtMateria.ResetText()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Tabla As CLS.CRUD = New CLS.CRUD
        If (Tabla.Delete("Materia", "idMateria", dgvMateria.CurrentRow.Cells("idMateria").Value.ToString)) Then
            MessageBox.Show("Registro eliminado, se elimino la materia: " + dgvMateria.CurrentRow.Cells("materia").Value.ToString, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        cargarGridMateria()

        txtIdMateria.ResetText()
    End Sub

    Private Sub frmMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridMateria()
    End Sub

    Private Sub cargarGridMateria()
        CLS.Funciones.FillGridView(dgvMateria, "Materia", True)
    End Sub

    Private Sub filtrarMateria()
        Dim Tabla As CLS.QUERY = New CLS.QUERY
        Dim DT As DataTable
        DT = Tabla.GetRecordsFiltersLike("Materia", "Materia", txtMateria.Text)
        CLS.Funciones.FillGridView(dgvMateria, DT, True)
    End Sub

    Private Sub txtMateria_TextChanged(sender As Object, e As EventArgs) Handles txtMateria.TextChanged
        filtrarMateria()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvMateria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMateria.CellClick
        txtIdMateria.Text = dgvMateria.CurrentRow.Cells("idMateria").Value.ToString

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscar.ShowDialog()
        txtMateria.Text = frmBuscar.materia_
        txtIdMateria.Text = frmBuscar.id_
    End Sub
End Class