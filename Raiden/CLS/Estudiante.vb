Imports DATA.CLS
Imports MySql.Data.MySqlClient
Public Class Estudiante
    Inherits Connection
    Private Comando As MySqlCommand = New MySqlCommand()
    Private Adaptador As MySqlDataAdapter = New MySqlDataAdapter()

    Private transaccion_ As MySqlTransaction

    Public NIE As String
    Public idEstado As Int16
    Public idMunicipio As Int16
    Public idClase As Int16

    Public dui As String
    Public carnet As String
    Public nombres As String
    Public apellidos As String
    Public telefono As String
    Public celular As String
    Public direccion As String
    Public correo As String
    Public foto As String
    Public genero As String
    Public fecha_nacimiento As Date
    Public fecha_ingreso As Date

    Public Function Insert() As Integer 'CREATE OF CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        transaccion_ = MyBase.Conexion.BeginTransaction(System.Data.IsolationLevel.ReadCommitted)

        Try
            Using MyBase.Conexion
                query = "INSERT INTO estudiante(NIE, idEstado,idMunicipio,idClase, DUI, carnet,nombres, apellidos, telefono, celular, direccion, correo, foto, genero, fecha_nacimiento, fecha_ingreso)values( ?NIE_, ?idEstado_,?idMunicipio_,?idClase_,?DUI_ ,?carnet_,?nombres_, ?apellidos_, ?telefono_, ?celular_, ?direccion_, ?correo_, ?foto_, ?genero_, ?fecha_nacimiento_, ?fecha_ingreso_ )"
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE_", NIE)
                Comando.Parameters.AddWithValue("?idClase_", idClase)
                Comando.Parameters.AddWithValue("?idEstado_", idEstado)
                Comando.Parameters.AddWithValue("?idMunicipio_", idMunicipio)
                Comando.Parameters.AddWithValue("?DUI_", dui)
                Comando.Parameters.AddWithValue("?carnet_", carnet)
                Comando.Parameters.AddWithValue("?nombres_", nombres)
                Comando.Parameters.AddWithValue("?apellidos_", apellidos)
                Comando.Parameters.AddWithValue("?telefono_", telefono)
                Comando.Parameters.AddWithValue("?celular_", celular)
                Comando.Parameters.AddWithValue("?direccion_", direccion)
                Comando.Parameters.AddWithValue("?correo_", correo)
                Comando.Parameters.AddWithValue("?foto_", foto)
                Comando.Parameters.AddWithValue("?genero_", genero)
                Comando.Parameters.AddWithValue("?fecha_nacimiento_", fecha_nacimiento)
                Comando.Parameters.AddWithValue("?fecha_ingreso_", fecha_ingreso)

                NumFilasAfectadas = Comando.ExecuteNonQuery()

                'Insertar los datos generales

                'Crear una instancia de la clase general
                Dim gral As General = New General()


                MyBase.Desconectar()
            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Error en la SQL! : " & e.Message & "Query:" & query)
            NumFilasAfectadas = 0
        Finally
            MyBase.Desconectar()
        End Try
        Return NumFilasAfectadas
    End Function
    Public Function GetRecord(NIE_ As String) As DataTable 'READ OF CRUD
        Dim Resultado As DataTable = New DataTable()
        Dim query As String = "SELECT * FROM estudiante WHERE NIE = ?NIE__ "
        MyBase.Conectar()
        Try
            Using MyBase.Conexion

                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE__", NIE_)
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(Resultado)
                ''    If DT.Rows.Count > 0 Then Resultado = DT.Rows(0)
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
                query = "UPDATE estudiante SET NIE = ?NIE_, idEstado = ?idEstado_, idMunicipio = ?idMunicipio_, idClase = ?idClase_ , DUI = ?DUI_, carnet = ?carnet_, nombres = ?nombres_ , apellidos = ?apellidos_, telefono = ?telefono_, celular = ?celular_, direccion = ?direccion_, correo = ?correo_, foto = ?foto_, genero = ?genero_, fecha_nacimiento = ?fecha_nacimiento_, fecha_ingreso = ?fecha_ingreso_ WHERE ?NIE_ =" & NIE
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE_", NIE)
                Comando.Parameters.AddWithValue("?idEstado_", idEstado)
                Comando.Parameters.AddWithValue("?idMunicipio_", idMunicipio)
                Comando.Parameters.AddWithValue("?idClase_", idClase)
                Comando.Parameters.AddWithValue("?DUI_", dui)
                Comando.Parameters.AddWithValue("?carnet_", carnet)
                Comando.Parameters.AddWithValue("?nombres_", nombres)
                Comando.Parameters.AddWithValue("?apellidos_", apellidos)
                Comando.Parameters.AddWithValue("?telefono_", telefono)
                Comando.Parameters.AddWithValue("?celular_", celular)
                Comando.Parameters.AddWithValue("?direccion_", direccion)
                Comando.Parameters.AddWithValue("?correo_", correo)
                Comando.Parameters.AddWithValue("?foto_", foto)
                Comando.Parameters.AddWithValue("?genero_", genero)
                Comando.Parameters.AddWithValue("?fecha_nacimiento_", fecha_nacimiento)
                Comando.Parameters.AddWithValue("?fecha_ingreso_", fecha_ingreso)

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
        If MessageBox.Show("Desea eliminar el registro seleccionado (" & NIE & ") de la tabla  estudiante ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
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

    Public Function GetGenerales(NIE_ As String) As DataTable 'READ OF CRUD
        Dim Resultado As DataTable = New DataTable()
        '' Dim Resultado As DataRow = DT.NewRow()
        Dim query As String = "SELECT * FROM estudiante WHERE NIE = ?NIE__ "
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE__", NIE_)
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(Resultado)
                ''  If DT.Rows.Count > 0 Then Resultado = DT.Rows(0)
                MyBase.Desconectar()
            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Error en la SQL!: " & e.Message)
        Finally
            MyBase.Desconectar()
        End Try
        Return Resultado
    End Function

    Public Function GetFamilia(NIE_ As String) As DataTable 'READ OF CRUD
        Dim Resultado As DataTable = New DataTable()

        Dim query As String = "SELECT * FROM estudiante WHERE NIE = ?NIE__ "
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE__", NIE_)
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(Resultado)
                '' If DT.Rows.Count > 0 Then Resultado = DT.Rows(0)
                MyBase.Desconectar()
            End Using
        Catch e As MySqlException
            MessageBox.Show("¡Error en la SQL!: " & e.Message)
        Finally
            MyBase.Desconectar()
        End Try
        Return Resultado
    End Function
End Class