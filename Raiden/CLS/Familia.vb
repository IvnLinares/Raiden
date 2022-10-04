Imports DATA.CLS
Imports MySql.Data.MySqlClient
Public Class Familia
    Inherits Connection
    Private Comando As MySqlCommand = New MySqlCommand()
    Private Adaptador As MySqlDataAdapter = New MySqlDataAdapter()

    Public NIE As String

    Public nMiembros As Int32
    Public nombreMadre As String
    Public profesionMadre As String
    Public trabajoMadre As String
    Public telefonoMadre As String
    Public viveconMadre As String
    Public NombrePadre As String
    Public profesionPadre As String
    Public trabajoPadre As String
    Public telefonoPadre As String
    Public viveconPadre As String
    Public nombreResponsable As String
    Public telefonoResponsable As String

    Public Function Insert() As Integer 'CREATE OF CRUD
        Dim query As String = ""
        Dim NumFilasAfectadas As Int32 = 0
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                query = "INSERT INTO Familia(NIE,nMiembros,nombreMadre, profesionMadre,trabajoMadre,telefonoMadre, viveconMadre,nombrePadre,profesionPadre,trabajoPadre,telefonoPadre,viveconPadre,nombreResponsable,telefonoResponsable)
                values(?NIE_,?nMiembros_,?nombreMadre_,?profesionMadre_?trabajoMadre_,?telefonoMadre_,?viveconMadre_,?nombrePadre_,?profesionPadre_,?trabajoPadre_,?telefonoPadre_,?viveconPadre_,?nombreResponsable_,?telefonoResponsable_)"
                Comando.CommandText = query
                Comando.Connection = MyBase.Conexion
                Comando.Parameters.AddWithValue("?NIE_", NIE)
                Comando.Parameters.AddWithValue("?nMiembro_", nMiembros)
                Comando.Parameters.AddWithValue("?nombreMadre_", nombreMadre)
                Comando.Parameters.AddWithValue("?profesionMadre_", profesionMadre)
                Comando.Parameters.AddWithValue("?trabajoMadre_", trabajoMadre)
                Comando.Parameters.AddWithValue("?telefonoMadre_", telefonoMadre)
                Comando.Parameters.AddWithValue("?viveconMadre_", viveconMadre)
                Comando.Parameters.AddWithValue("?nombrePadre_", NombrePadre)
                Comando.Parameters.AddWithValue("?profesionPadre_", profesionPadre)
                Comando.Parameters.AddWithValue("?trabajoPadre_", trabajoPadre)
                Comando.Parameters.AddWithValue("?telefonoPadre_", telefonoPadre)
                Comando.Parameters.AddWithValue("?viveconPadre_", viveconPadre)
                Comando.Parameters.AddWithValue("?nombreResponsable_", nombreResponsable)
                Comando.Parameters.AddWithValue("?telefonoResponsable_", telefonoResponsable)
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
    Public Function GetRecord(NIE_ As String) As DataRow 'READ OF CRUD
        Dim DT As DataTable = New DataTable()
        Dim Resultado As DataRow = DT.NewRow()
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                Dim query As String = "SELECT * FROM familia WHERE NIE = " & NIE_
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

    Public Function GetFamilia(NIE_ As String) As DataRow 'READ OF CRUD
        Dim DT As DataTable = New DataTable()
        Dim Resultado As DataRow = DT.NewRow()
        MyBase.Conectar()
        Try
            Using MyBase.Conexion
                Dim query As String = "SELECT * FROM familia WHERE NIE = " & NIE_
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
                'query = "UPDATE estudiante SET idEstado =?idEstado_, orden=?orden_ 
                query = "UPDATE familia SET nMiembro =?nMiembro_,nombreMadre =?nombreMadre_,profesionMadre=?profesionMadre_,trabajoMadre=?trabajoMadre_,
                telefonoMadre=?telefonoMadre_,viveconMadre=?viveconMadre_,nombrePadre=?nombrePadre_,profesionPadre=?profesionPadre_,
                trabajoPadre=?trabajoPadre_,telefonoPadre=?telefonoPadre_,
                viveconPadre=?viveconPadre_,nombreResponsable=?nombreResponsable_,telefonoResponsable=?telefonoResponsable_
                WHERE NIE =" & NIE
                Comando.Parameters.AddWithValue("?NIE_", NIE)
                Comando.Parameters.AddWithValue("?nMiembro_", nMiembros)
                Comando.Parameters.AddWithValue("?nombreMadre_", nombreMadre)
                Comando.Parameters.AddWithValue("?profesionMadre_", profesionMadre)
                Comando.Parameters.AddWithValue("?trabajoMadre_", trabajoMadre)
                Comando.Parameters.AddWithValue("?telefonoMadre_", telefonoMadre)
                Comando.Parameters.AddWithValue("?viveconMadre_", viveconMadre)
                Comando.Parameters.AddWithValue("?nombrePadre_", NombrePadre)
                Comando.Parameters.AddWithValue("?profesionPadre_", profesionPadre)
                Comando.Parameters.AddWithValue("?trabajoPadre_", trabajoPadre)
                Comando.Parameters.AddWithValue("?telefonoPadre_", telefonoPadre)
                Comando.Parameters.AddWithValue("?viveconPadre_", viveconPadre)
                Comando.Parameters.AddWithValue("?nombreResponsable_", nombreResponsable)
                Comando.Parameters.AddWithValue("?telefonoResponsable_", telefonoResponsable)
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
        If MessageBox.Show("Desea eliminar el registro seleccionado (" & NIE & ") de la tabla  familia ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            MyBase.Conectar()
            Dim NumFilasAfectadas As Int32 = 0
            Try
                Using MyBase.Conexion
                    Dim query As String = "DELETE FROM familia WHERE NIE = " & NIE
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
