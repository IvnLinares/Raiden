Imports MySql.Data.MySqlClient
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CLS
    Public Class QUERY
        Inherits Connection

        Private Comando As MySqlCommand = New MySqlCommand()
        Private Adaptador As MySqlDataAdapter = New MySqlDataAdapter()

        Private Function EjecutarConsulta(ByVal pConsulta As String) As DataTable
            Dim Resultado As DataTable = New DataTable()
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Comando.CommandText = pConsulta
                    Comando.Connection = MyBase.Conexion
                    Adaptador.SelectCommand = Comando
                    Adaptador.Fill(Resultado)
                End Using

            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la consulta SQL de la clase QUERY! : " & e.Message & " mira esto: " & pConsulta)
                Resultado = New DataTable()
            Finally
                MyBase.Desconectar()
            End Try

            Return Resultado
        End Function

        Public Function Consultar(ByVal pConsulta As String) As DataTable
            Return EjecutarConsulta(pConsulta)
        End Function

        Public Function GetRecordsFiltersLike(ByVal tableName As String, ByVal field As String, ByVal condition As String) As DataTable
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & " where " & field & " like '%" & condition & "%';")
            Return EjecutarConsulta(sentencia.ToString())
        End Function

        Public Function GetRecordsFiltersLike(ByVal tableName As String, ByVal field As String, ByVal condition As String, ByVal field2 As String, ByVal condition2 As String) As DataTable
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & " where " & field & " like '%" & condition & "%' and " & field2 & " = " & condition2 & ";")
            Return EjecutarConsulta(sentencia.ToString())
        End Function

        Public Function GetRecordsFiltersLike(ByVal tableName As String, ByVal field As String, ByVal condition As String, ByVal field2 As String, ByVal operador As String, ByVal condition2 As String) As DataTable
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & " where " & field & " like '%" & condition & "%' and " & field2 & " " & operador & " " & condition2 & ";")
            Return EjecutarConsulta(sentencia.ToString())
        End Function

        Public Function GetRecordsFilters(ByVal tableName As String, ByVal field As String, ByVal condition As String) As DataTable
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & " where " & field & " = " & condition & ";")
            Return EjecutarConsulta(sentencia.ToString())
        End Function

        Public Function GetRecordsFilters(ByVal tableName As String, ByVal field As String, ByVal operador As String, ByVal condition As String) As DataTable
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & " where " & field & " " & operador & " " & condition & ";")
            Return EjecutarConsulta(sentencia.ToString())
        End Function

        Public Function GetRecordsFromTwoTable(ByVal Table1 As String, ByVal Table2 As String, ByVal IndexTable1 As String, ByVal IndexTable2 As String, ByVal conditions As String, ByVal orderBy As String) As DataTable
            Dim sentencia As StringBuilder = New StringBuilder()

            If conditions.Length > 0 Then
                sentencia.Append("Select a.*, b.* from " & Table1 & " a inner join " & Table2 & " b on(a." & IndexTable1 & "= b." & IndexTable2 & ")   where " & conditions & " order by " & orderBy & " ;")
            Else
                sentencia.Append("Select a.*, b.* from " & Table1 & " a inner join " & Table2 & " b on(a." & IndexTable1 & "= b." & IndexTable2 & ") order by " & orderBy & " ;")
            End If

            Return EjecutarConsulta(sentencia.ToString())
        End Function

        Public Function GetRecords(ByVal tableName As String) As DataTable
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & ";")
            Return EjecutarConsulta(sentencia.ToString())
        End Function

        Public Function GetRecords(ByVal tableName As String, ByVal fieldSorted As String) As DataTable
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & " ORDER BY " & fieldSorted & ";")
            Return EjecutarConsulta(sentencia.ToString())
        End Function

        Public Function GetUniqueRecord(ByVal tableName As String, ByVal fieldPrimary As String, ByVal fieldCondition As String) As DataRow
            Dim DT As DataTable = New DataTable()
            Dim Resultado As DataRow = DT.NewRow()
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & " where " & fieldPrimary & " = '" & fieldCondition & "';")

            Try
                Resultado = EjecutarConsulta(sentencia.ToString()).Rows(0)
                Return Resultado
            Catch
                Return Nothing
            End Try
        End Function

        Public Function GetSHA1FromString(ByVal cadena As String) As String
            Dim DT As DataTable = New DataTable()
            Dim resul As String = ""
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Dim query As String = "SELECT SHA1(?Cadena) as NewString"
                    Comando.CommandText = query
                    Comando.Connection = MyBase.Conexion
                    Comando.Parameters.AddWithValue("?Cadena", cadena)
                    Adaptador.SelectCommand = Comando
                    Adaptador.Fill(DT)
                    If DT.Rows.Count > 0 Then resul = DT.Rows(0)("NewString").ToString()
                    MyBase.Desconectar()
                End Using

            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message)
            Finally
                MyBase.Desconectar()
            End Try

            Return resul
        End Function

        Public Function GetRecordTop(ByVal tableName As String) As DataRow
            Dim DT As DataTable = New DataTable()
            Dim Resultado As DataRow = DT.NewRow()
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & " LIMIT 1;")

            Try
                Resultado = EjecutarConsulta(sentencia.ToString()).Rows(0)
                Return Resultado
            Catch
                Return Nothing
            End Try
        End Function
        Public Function GetRecordById(ByVal tableName As String, ByVal id As String) As DataRow
            Dim DT As DataTable = New DataTable()
            Dim Resultado As DataRow = DT.NewRow()
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SELECT * from " & tableName & " Where (SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & tableName & "' and COLUMN_KEY IN('PRI', 'UNI')) = " & id & " ;")
            Try
                Resultado = EjecutarConsulta(sentencia.ToString()).Rows(0)
                Return Resultado
            Catch
                Return Nothing
            End Try
        End Function
        Public Function GetRecordByID(ByVal tableName As String, ByVal idField As String, ByVal idValue As String) As DataRow
            Dim DT As DataTable = New DataTable()
            Dim Resultado As DataRow = DT.NewRow()
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Dim query As String = "SELECT * FROM " & tableName & " WHERE " & idField & "= ?IdValue"
                    Comando.CommandText = query
                    Comando.Connection = MyBase.Conexion
                    Comando.Parameters.AddWithValue("?IdValue", idValue)
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

        Public Function GetColumnsName(ByVal tableName As String) As DataTable
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("SHOW COLUMNS FROM " & tableName & ";")
            Return EjecutarConsulta(sentencia.ToString())
        End Function
        Public Function Autenticar(ByVal tableName As String, ByVal userLogin As String, ByVal valueLogin As String, ByVal userPassword As String, ByVal valuePassword As String) As Integer
            Dim numFilas As Integer
            Dim sql_ As StringBuilder = New StringBuilder()
            sql_.Append("SELECT * from " & tableName & " where " & userLogin & " = ?valueLogin " & " and " & userPassword & "  = SHA1(?valuePassword); ")
            Dim Resultado As DataTable = New DataTable

            MyBase.Conectar()
            Try
                Using MyBase.Conexion
                    Comando.CommandText = sql_.ToString()
                    Comando.Connection = MyBase.Conexion
                    Comando.Parameters.AddWithValue("?valueLogin", valueLogin)
                    Comando.Parameters.AddWithValue("?valuePassword", valuePassword)
                    Comando.ExecuteNonQuery()

                    Adaptador.SelectCommand = Comando
                    Adaptador.Fill(Resultado)

                    If Resultado.Rows.Count > 0 Then
                        numFilas = Resultado.Rows.Count
                    Else
                        numFilas = 0
                    End If


                End Using
            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la consulta SQL de la clase QUERY! : " & e.Message & " mira esto: " & sql_.ToString)
                numFilas = 0
            Finally
                MyBase.Desconectar()
            End Try
            Return numFilas
        End Function
    End Class
End Namespace
