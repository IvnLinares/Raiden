Imports DATA.CLS
Imports MySql.Data.MySqlClient

Public Class General
    Inherits Connection
    Private Comando As MySqlCommand = New MySqlCommand()
    Private Adaptador As MySqlDataAdapter = New MySqlDataAdapter()

    Public NIE As String

    Public distanciaCentro As Decimal
    Public medioTransporte As String
    Public partida As String
    Public certificacionNotas As String
    Public enfermedad As String
    Public tratamiento As String
    Public Function Insert() As Integer 'CREATE OF CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                query = "INSERT INTO general(NIE,distanciaCentro,medioTransporte,partida,certificacionNotas,enfermedad,tratamiento)
                values(?NIE_,?distanciaCentro_,?medioTransporte_,?partida_,?certificacionNotas_,?enfermedad_,?tratamiento_)"
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE_", NIE)
                Comando.Parameters.AddWithValue("?distanciaCentro_", distanciaCentro)
                Comando.Parameters.AddWithValue("?medioTransporte_", medioTransporte)
                Comando.Parameters.AddWithValue("?partida_", partida)
                Comando.Parameters.AddWithValue("?certificacionNotas_", certificacionNotas)
                Comando.Parameters.AddWithValue("?enfermedad_", enfermedad)
                Comando.Parameters.AddWithValue("?tratamiento_", tratamiento)
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
    End Function
    Public Function GetRecord(NIE_ As String) As DataTable  'READ OF CRUD
        Dim Resultado As DataTable = New DataTable()
        MyBase.Conectar()
        Dim query As String = "SELECT * FROM general WHERE NIE = " & NIE_
        Try
            Using MyBase.Conexion
                'Dim query As String = "SELECT * FROM general WHERE NIE = " & NIE_
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("NIE", NIE_)
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(Resultado)

            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message & " mira esto: " & query)
            Resultado = New DataTable()
        Finally
            MyBase.Desconectar()
        End Try
        Return Resultado
    End Function

    Public Function GetGeneral(NIE_ As String) As DataRow 'READ OF CRUD
        Dim DT As DataTable = New DataTable()
        Dim Resultado As DataRow = DT.NewRow()
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                Dim query As String = "SELECT * FROM general WHERE NIE = " & NIE_
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("NIE", NIE)
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
    Public Function Update() As Integer 'UPDATE OF CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                query = "UPDATE general SET distanciaCentro=?distanciaCentro_,medioTransporte=?medioTransporte_,
                partida=?partida_,certificacionNotas=?certificacionNotas_,enfermedad=?enfermedad_,tratamiento=?tratamiento_ 
                WHERE NIE =" & NIE
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE_", NIE)
                Comando.Parameters.AddWithValue("?distanciaCentro_", distanciaCentro)
                Comando.Parameters.AddWithValue("?medioTransporte_", medioTransporte)
                Comando.Parameters.AddWithValue("?partida_", partida)
                Comando.Parameters.AddWithValue("?certificacionNotas_", certificacionNotas)
                Comando.Parameters.AddWithValue("?enfermedad_", enfermedad)
                Comando.Parameters.AddWithValue("?tratamiento_", tratamiento)
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
    End Function
    Public Function Delete() As Integer 'DELETE OF CRUD
        If MessageBox.Show("Desea eliminar el registro seleccionado (" & NIE & ") de la tabla  general ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            MyBase.Conectar()
            Dim NumFilasAfectadas As Int32 = 0
            Try
                Using MyBase.Conexion
                    Dim query As String = "DELETE FROM general WHERE NIE = " & NIE
                    Comando = New MySqlCommand(query, MyBase.Conexion)
                    NumFilasAfectadas = Comando.ExecuteNonQuery()
                    MyBase.Desconectar()
                End Using
            Catch e As MySqlException
                MessageBox.Show("¡Error en la  SQL! : " & e.Message)
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
