Public Class Practicas
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frm As frmbMateria = New frmbMateria

        frm.ShowDialog()
        txtMateria.Text = frm.materia_
    End Sub
End Class