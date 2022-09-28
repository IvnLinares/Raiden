Imports DATA
Public Class MenuPrincipal
    Private Sub CadenaDeConexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadenaDeConexionToolStripMenuItem.Click
        Dim frm As ConnectionManager = New ConnectionManager
        frm.ShowDialog()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub ClaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClaseToolStripMenuItem.Click

    End Sub

    Private Sub DepartamentosYMunicipiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosYMunicipiosToolStripMenuItem.Click
        Dim frm As frmDeptopsMunicipios = New frmDeptopsMunicipios
        frm.ShowDialog()
    End Sub

    Private Sub EstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoToolStripMenuItem.Click
        Dim frm As frmEstado = New frmEstado
        frm.ShowDialog()
    End Sub

    Private Sub GradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradoToolStripMenuItem.Click
        Dim frm As frmGrado = New frmGrado
        frm.ShowDialog()
    End Sub

    Private Sub PracticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PracticaToolStripMenuItem.Click
        Dim frm As Practicas = New Practicas
        frm.ShowDialog()
    End Sub

    Private Sub MateriaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MateriaToolStripMenuItem1.Click
        Dim frm As frmMateria = New frmMateria
        frm.ShowDialog()
    End Sub

    Private Sub EstadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstadoToolStripMenuItem1.Click
        Dim frm As frmEstado = New frmEstado
        frm.ShowDialog()
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click
        Dim frm As frmAlumno = New frmAlumno
        frm.ShowDialog()
    End Sub
End Class