Imports DATA.CLS
Imports MySql.Data.MySqlClient

Public Class Grado
    Inherits Connection
    Private Comando As MySqlCommand = New MySqlCommand()
    Private Adaptador As MySqlDataAdapter = New MySqlDataAdapter()

    Public idGrado As Int16
    Public grado As String
    Public orden As Integer

    Public Sub New()
    End Sub

    Public Sub New(_idGrado As Integer, _grado As String, _orden As Integer)
        idGrado = _idGrado
        grado = _grado
        orden = _orden
    End Sub

    Public Function Insert() As Integer 'Create of CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                query = "INSERT INTO grado(grado, orden)values(?grado_,?orden_)"
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?grado_", grado)
                Comando.Parameters.AddWithValue("?orden_", orden)
                NumFilasAfectadas = Comando.ExecuteNonQuery()
                MyBase.Desconectar()
            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message & " CADENA COMPLETA: " & query.ToString())
            NumFilasAfectadas = 0
        Finally
            MyBase.Desconectar()
        End Try
        Return NumFilasAfectadas
    End Function

    Public Function GetRecord() As DataRow ' Read Of CRUD
        Dim DT As DataTable = New DataTable()
        Dim Resultado As DataRow = DT.NewRow()
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                Dim query As String = "SELECT * FROM grado WHERE idGrado = ?idGrado_"
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?idGrado_", idGrado)
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(DT)
                If DT.Rows.Count > 0 Then Resultado = DT.Rows(0)
                MyBase.Desconectar()
            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message)
        Finally
            MyBase.Desconectar()
        End Try
        Return Resultado
    End Function

    Public Function Update() As Integer 'Update of CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                query = "UPDATE grado SET grado = ?grado_, orden = ?orden_ WHERE idGrado =" & idGrado
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?grado_", grado)
                Comando.Parameters.AddWithValue("?orden_", orden)
                NumFilasAfectadas = Comando.ExecuteNonQuery()
                MyBase.Desconectar()
            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message & " CADENA COMPLETA: " & query.ToString())
            NumFilasAfectadas = 0
        Finally
            MyBase.Desconectar()
        End Try
        Return NumFilasAfectadas
    End Function

    Public Function Delete() As Integer
        If MessageBox.Show("Desea eliminar el regsitro seleccionado (" & idGrado & ") de la tabla GRADO ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            MyBase.Conectar()
            Dim NumFilasAfectadas As Int32 = 0
            Try
                Using MyBase.Conexion
                    Dim query As String = "DELETE FROM grado WHERE idGrado = " & idGrado
                    Comando = New MySqlCommand(query, MyBase.Conexion)
                    NumFilasAfectadas = Comando.ExecuteNonQuery()
                    MyBase.Desconectar()
                End Using
            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message)
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
