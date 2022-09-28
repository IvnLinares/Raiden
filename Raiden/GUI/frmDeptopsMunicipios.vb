Imports DATA.CLS
Public Class frmDeptopsMunicipios
    Dim deptoChange As String

    Private Sub cargarDepartamentos()
        Funciones.FillGridView(dgvDeptos, "Departamento")
    End Sub

    Private Sub cargarMunicipios()
        Dim tabla As QUERY = New QUERY
        Dim DT As DataTable = New DataTable
        DT = tabla.GetRecordsFilters("Municipio", "idDepto", dgvDeptos.CurrentRow.Cells("idDepto").Value.ToString())
        Funciones.FillGridView(dgvMunicipios, DT)
    End Sub

    Private Sub frmDeptopsMunicipios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDepartamentos()
        cargarMunicipios()
    End Sub

    Private Sub btnAddDepto_Click(sender As Object, e As EventArgs) Handles btnAddDepto.Click
        If txtDepartamento.TextLength > 0 Then
            Dim TblDepto As CRUD = New CRUD
            Dim campos As List(Of String) = New List(Of String)
            Dim valores As List(Of String) = New List(Of String)
            campos.Add("Departamento")
            valores.Add(txtDepartamento.Text)

            If TblDepto.Insert("Departamento", campos, valores) > 0 Then
                MessageBox.Show("Registro agregado exitosamente", ProductName)
                txtDepartamento.Clear()
            End If
            cargarDepartamentos()

        End If
    End Sub

    Private Sub btnAddMunicipio_Click(sender As Object, e As EventArgs) Handles btnAddMunicipio.Click
        If txtMunicipio.TextLength > 0 Then
            Dim TblMunicipio As CRUD = New CRUD
            Dim campos As List(Of String) = New List(Of String)
            Dim valores As List(Of String) = New List(Of String)
            campos.Add("idDepto")
            campos.Add("Municipio")
            valores.Add(dgvDeptos.CurrentRow.Cells("idDepto").Value.ToString())
            valores.Add(txtMunicipio.Text)

            If TblMunicipio.Insert("Municipio", campos, valores) > 0 Then
                'MessageBox.Show("Registro agregado exitosamente", ProductName)
                txtMunicipio.Clear()
            End If
            cargarMunicipios()
            txtMunicipio.Select()
        End If
    End Sub

    Private Sub filtrarDeptos()
        Dim tblDeptos As QUERY = New QUERY
        Dim DT As New DataTable
        DT = tblDeptos.GetRecordsFiltersLike("Departamento", "Departamento", txtDepartamento.Text)
        Funciones.FillGridView(dgvDeptos, DT)
    End Sub

    Private Sub filtrarMunicipios()
        Dim tblMunicipio As QUERY = New QUERY
        Dim DT As New DataTable
        DT = tblMunicipio.GetRecordsFiltersLike("Municipio", "Municipio", txtMunicipio.Text, "idDepto", dgvDeptos.CurrentRow.Cells("idDepto").Value.ToString)
        Funciones.FillGridView(dgvMunicipios, DT)
    End Sub

    Private Sub dgvDeptos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDeptos.SelectionChanged
        filtrarMunicipios()
        deptoChange = dgvDeptos.CurrentRow.Cells("departamento").Value.ToString()
    End Sub

    Private Sub txtDepartamento_TextChanged(sender As Object, e As EventArgs) Handles txtDepartamento.TextChanged
        filtrarDeptos()
    End Sub

    Private Sub dgvDeptos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDeptos.CellEndEdit
        If dgvDeptos.CurrentRow.Cells("Departamento").Value.ToString().Length > 0 And dgvDeptos.CurrentRow.Cells("Departamento").Value.ToString().Trim() <> deptoChange.Trim() Then
            Dim tblDepto = New CRUD
            Dim campos As List(Of String) = New List(Of String)
            Dim valores As List(Of String) = New List(Of String)
            campos.Add("Departamento")
            valores.Add(dgvDeptos.CurrentRow.Cells("Departamento").Value.ToString())
            tblDepto.Update("Departamento", campos, valores, "idDepto", dgvDeptos.CurrentRow.Cells("idDepto").Value.ToString())
            cargarDepartamentos()
        End If
    End Sub

    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged
        filtrarMunicipios()
    End Sub

    Private Sub dgvMunicipios_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMunicipios.CellEndEdit
        If dgvMunicipios.CurrentRow.Cells("Municipio").Value.ToString().Length > 0 Then
            Dim tblMunicipio = New CRUD
            Dim campos As List(Of String) = New List(Of String)
            Dim valores As List(Of String) = New List(Of String)
            campos.Add("Municipio")
            valores.Add(dgvMunicipios.CurrentRow.Cells("Municipio").Value.ToString())
            tblMunicipio.Update("Municipio", campos, valores, "idMunicipio", dgvMunicipios.CurrentRow.Cells("idMunicipio").Value.ToString())
            cargarMunicipios()
        End If
    End Sub
End Class