Imports DATA.CLS
Public Class frmbMateria

    Public id_ As Integer
    Public materia_ As String

    Private Sub frmbMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMateria()
    End Sub

    Private Sub cargarMateria()
        Funciones.FillGridView(dgvMateria, "materia")
    End Sub

    Private Sub filtrarMateria()
        Dim query As QUERY = New QUERY
        Dim DT As DataTable = New DataTable
        If rbtnIdMateria.Checked Then
            DT = query.GetRecordsFiltersLike("materia", "idMateria", txtBuscar.Text)
        Else
            DT = query.GetRecordsFiltersLike("materia", "materia", txtBuscar.Text)
        End If
        Funciones.FillGridView(dgvMateria, DT)

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        filtrarMateria()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmbMateria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        id_ = Integer.Parse(dgvMateria.CurrentRow.Cells("idMateria").Value.ToString)
        materia_ = dgvMateria.CurrentRow.Cells("Materia").Value.ToString
    End Sub
End Class