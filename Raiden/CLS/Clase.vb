Imports DATA.CLS
Imports MySql.Data.MySqlClient


Public Class Clase
    Inherits Connection
    Private Comando As MySqlCommand = New MySqlCommand()
    Private Adaptador As MySqlDataAdapter = New MySqlDataAdapter()

    Public idClase As Int16
    Public Clase As String
    Public anioIngreso As Integer
    Public anioEgreso As Integer
    Public Sub New()

    End Sub
    Public Sub New(_idClase As Integer, _Clase As String, _anioIngreso As Integer, _anioEgreso As Integer)
        idClase = _idClase
        Clase = _Clase
        anioIngreso = _anioIngreso
        anioEgreso = _anioEgreso
    End Sub
    Public Function Insert() As Integer 'CREATE OF CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                query = "INSERT INTO clase(clase,anioIngreso,anioEgreso)values(?clase_,?anioIngreso_,?anioEgreso_)"
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?clase_", Clase)
                Comando.Parameters.AddWithValue("anioIngreso_", anioIngreso)
                Comando.Parameters.AddWithValue("anioEgreso_", anioEgreso)
                NumFilasAfectadas = Comando.ExecuteNonQuery()
                MyBase.Desconectar()
            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Error en la SQL! : " & e.Message)
            NumFilasAfectadas = 0
        Finally
            MyBase.Desconectar()
        End Try
        Return NumFilasAfectadas
    End Function
    Public Function GetRecord() As DataRow 'READ OF CRUD
        Dim DT As DataTable = New DataTable()
        Dim Resultado As DataRow = DT.NewRow()
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                Dim query As String = "SELECT * FROM clase WHERE idClase = ?idClase_"
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?idClase_", idClase)
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(DT)
                If DT.Rows.Count > 0 Then Resultado = DT.Rows(0)
                MyBase.Desconectar()
            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Error en la SQL!: " & e.Message)
        Finally
            MyBase.Desconectar()
        End Try
        Return Resultado
    End Function
    Public Function Update() As Integer 'UPDATE OF CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                query = "UPDATE clase SET clase =?clase_, anioIngreso=?anioIngreso_, anioEgreso= ?anioEgreso_ WHERE idClase =" & idClase
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?clase_", Clase)
                Comando.Parameters.AddWithValue("?anioIngreso_", anioIngreso)
                Comando.Parameters.AddWithValue("?anioEgreso_", anioEgreso)
                NumFilasAfectadas = Comando.ExecuteNonQuery()
                MyBase.Desconectar()
            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Error en la SQL! : " & e.Message)
            NumFilasAfectadas = 0
        Finally
            MyBase.Desconectar()
        End Try
        Return NumFilasAfectadas
    End Function
    Public Function Delete() As Integer 'DELETE OF CRUD
        If MessageBox.Show("Desea eliminar el regsitro seleccionado (" & idClase & ") de la tabla  Clase ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            MyBase.Conectar()
            Dim NumFilasAfectadas As Int32 = 0
            Try
                Using MyBase.Conexion
                    Dim query As String = "DELETE FROM clase WHERE idClase= " & idClase
                    Comando = New MySqlCommand(query, MyBase.Conexion)
                    NumFilasAfectadas = Comando.ExecuteNonQuery()
                    MyBase.Desconectar()
                End Using
            Catch e As MySqlException
                MessageBox.Show("¡Error en la SQL! : " & e.Message)
                NumFilasAfectadas = 0
            Finally
                MyBase.Desconectar()
            End Try
            Return NumFilasAfectadas
        Else
            Return 0
        End If
    End Function

End Class

