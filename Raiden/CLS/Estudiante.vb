Imports DATA.CLS
Imports MySql.Data.MySqlClient

Public Class Estudiante
    Inherits Connection
    Private Comando As MySqlCommand = New MySqlCommand()
    Private Adaptador As MySqlDataAdapter = New MySqlDataAdapter()

    Public NIE As String
    Public idEstado As Int16
    Public idMunicipio As Int16
    Public idClase As Int16

    Public dui As String
    Public carnet As String
    Public nombre As String
    Public apellido As String
    Public telefono As String
    Public direccion As String
    Public correo As String
    Public foto As String
    Public genero As String
    Public fecha_nacimiento As Date
    Public fecha_ingreso As Date
    Public celular As String

    Public Function Insert() As Integer 'CREATE OF CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                query = "INSERT INTO estudiante(NIE,idEstado,idMunicipio,idClase,DUI,carnet,nombres,apellidos,telefono,direccion,correo,foto,genero,fecha_nacimiento,fecha_ingreso,Celular)
                values(?NIE_,?idEstado_,?idMunicipio_,?idClase_,?DUI_,?carnet_,?nombres_,?apellidos_,?telefono_,?direccion_,?correo_,?foto_,?genero_,?fecha__,?nacimiento_,?fecha_ingreso_,?Celular_)"
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE_", NIE)
                Comando.Parameters.AddWithValue("?idEstado_", idEstado)
                Comando.Parameters.AddWithValue("?idMunicipio_", idMunicipio)
                Comando.Parameters.AddWithValue("?idClase_", idClase)
                Comando.Parameters.AddWithValue("?DUI_", dui)
                Comando.Parameters.AddWithValue("?carnet_", carnet)
                Comando.Parameters.AddWithValue("?nombres_", nombre)
                Comando.Parameters.AddWithValue("?apellidos_", apellido)
                Comando.Parameters.AddWithValue("?telefono_", telefono)
                Comando.Parameters.AddWithValue("?direcion_", direccion)
                Comando.Parameters.AddWithValue("?correo_", correo)
                Comando.Parameters.AddWithValue("?foto_", foto)
                Comando.Parameters.AddWithValue("?genero_", genero)
                Comando.Parameters.AddWithValue("?fecha_nacimineto_", fecha_nacimiento)
                Comando.Parameters.AddWithValue("?fecha_ingreso_", fecha_ingreso)
                Comando.Parameters.AddWithValue("?celular_", celular)
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
    Public Function GetRecord(NIE_ As String) As DataTable 'READ OF CRUD
        Dim Resultado As DataTable = New DataTable()
        MyBase.Conectar()
        Dim query As String = "SELECT * FROM estudiante WHERE NIE = " & NIE_
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
    Public Function Update() As Integer 'UPDATE OF CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                query = "UPDATE estudiante SET idEstudiante=?idEstado_,idMunicipio=?idMunicipio_,idClase=?idClase_,
                DUI=?DUI_,carnet=?carnet_,nombre=?nombres_,apellidos=?apellidos_,telefono=?telefono_,direccion=?direccion_,correo=?correo_,
                foto=?foto_,genero=?genero_,fecha=?fecha__,nacimiento=?nacimiento_,fecha_ingreso=?fecha_ingreso_,celular=?celular_
                WHERE NIE =" & NIE
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE_", NIE)
                Comando.Parameters.AddWithValue("?idEstado_", idEstado)
                Comando.Parameters.AddWithValue("?idMunicipio_", idMunicipio)
                Comando.Parameters.AddWithValue("?idClase_", idClase)
                Comando.Parameters.AddWithValue("?DUI_", dui)
                Comando.Parameters.AddWithValue("?carnet_", carnet)
                Comando.Parameters.AddWithValue("?nombres_", nombre)
                Comando.Parameters.AddWithValue("?apellidos_", apellido)
                Comando.Parameters.AddWithValue("?telefono_", telefono)
                Comando.Parameters.AddWithValue("?direcion_", direccion)
                Comando.Parameters.AddWithValue("?correo_", correo)
                Comando.Parameters.AddWithValue("?foto_", foto)
                Comando.Parameters.AddWithValue("?genero_", genero)
                Comando.Parameters.AddWithValue("?fecha_nacimineto_", fecha_nacimiento)
                Comando.Parameters.AddWithValue("?fecha_ingreso_", fecha_ingreso)
                Comando.Parameters.AddWithValue("?celular_", celular)
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
        If MessageBox.Show("Desea eliminar el regsitro seleccionado (" & NIE & ") de la tabla  estudiante ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            MyBase.Conectar()
            Dim NumFilasAfectadas As Int32 = 0
            Try
                Using MyBase.Conexion
                    Dim query As String = "DELETE FROM estudiante WHERE NIE = " & NIE
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
