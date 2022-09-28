Imports MySql.Data.MySqlClient
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CLS
    Public Class CRUD
        Inherits Connection

        Private Comando As MySqlCommand = New MySqlCommand()
        Private Adaptador As MySqlDataAdapter = New MySqlDataAdapter()

        Private Function EjecutarSentencia(ByVal pSentencia As String) As Integer
            Dim NumFilasAfectadas As Int32 = 0
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Comando.CommandText = pSentencia
                    Comando.Connection = MyBase.Conexion
                    NumFilasAfectadas = Comando.ExecuteNonQuery()
                End Using

            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message)
                NumFilasAfectadas = 0
            Finally
                MyBase.Desconectar()
            End Try

            Return NumFilasAfectadas
        End Function

        Public Function Insert(ByVal tablaName As String, ByVal campos As List(Of String), ByVal valores As List(Of String)) As Integer
            Dim query As String = ""
            Dim NumFilasAfectadas As Int32 = 0
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Dim listaCampos As String = String.Join(",", campos.ToArray())
                    Dim listaValores As List(Of String) = New List(Of String)()

                    If campos.Count() = valores.Count() Then

                        For i As Integer = 0 To valores.Count() - 1
                            listaValores.Add("?Valor" & i.ToString())
                        Next

                        Dim listaValores_ As String = String.Join(",", listaValores.ToArray())
                        query = "INSERT INTO " & tablaName & "(" & listaCampos & ")values(" & listaValores_.ToString() & ")"
                        Comando.CommandText = query
                        Comando.Connection = MyBase.Conexion

                        For i As Integer = 0 To valores.Count() - 1
                            Comando.Parameters.AddWithValue("?Valor" & i.ToString(), valores(i))
                        Next

                        NumFilasAfectadas = Comando.ExecuteNonQuery()
                        MyBase.Desconectar()
                    End If
                End Using

            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message & " CADENA COMPLETA: " & query.ToString())
                NumFilasAfectadas = 0
            Finally
                MyBase.Desconectar()
            End Try

            Return NumFilasAfectadas
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

        Public Function Update(ByVal tablaName As String, ByVal campos As List(Of String), ByVal valores As List(Of String), ByVal fielCondition As String, ByVal fieldConditionValue As String) As Integer
            Dim query As String = ""
            Dim NumFilasAfectadas As Int32 = 0
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Dim listaCampos As String = String.Join(",", campos.ToArray())
                    Dim listaCamposValores As List(Of String) = New List(Of String)()

                    If campos.Count() = valores.Count() Then

                        For i As Integer = 0 To valores.Count() - 1
                            listaCamposValores.Add(campos(i).ToString() & " = " & "?Valor" & i.ToString())
                        Next

                        Dim campoValor As String = String.Join(",", listaCamposValores.ToArray())
                        query = "UPDATE " & tablaName & " SET " & campoValor.ToString() & " WHERE " & fielCondition & " = ?Condition"
                        Comando.CommandText = query
                        Comando.Connection = MyBase.Conexion

                        For i As Integer = 0 To valores.Count() - 1
                            Comando.Parameters.AddWithValue("?Valor" & i.ToString(), valores(i))
                        Next

                        Comando.Parameters.AddWithValue("?Condition", fieldConditionValue)
                        NumFilasAfectadas = Comando.ExecuteNonQuery()
                        MyBase.Desconectar()
                    Else
                        MessageBox.Show("El número de campos (" & campos.Count().ToString() & ")" & " no coincide con el número de valores recibidos (" & valores.Count().ToString() & ") ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End If
                End Using

            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message & " CADENA COMPLETA: " & query.ToString())
                NumFilasAfectadas = 0
            Finally
                MyBase.Desconectar()
            End Try

            Return NumFilasAfectadas
        End Function

        Public Function Update(ByVal tablaName As String, ByVal campos As List(Of String), ByVal valores As List(Of String), ByVal fielCondition As String, ByVal operador As String, ByVal fieldConditionValue As String) As Integer
            Dim query As String = ""
            Dim NumFilasAfectadas As Int32 = 0
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Dim listaCampos As String = String.Join(",", campos.ToArray())
                    Dim listaCamposValores As List(Of String) = New List(Of String)()

                    If campos.Count() = valores.Count() Then

                        For i As Integer = 0 To valores.Count() - 1
                            listaCamposValores.Add(campos(i).ToString() & " = " & "?Valor" & i.ToString())
                        Next

                        Dim campoValor As String = String.Join(",", listaCamposValores.ToArray())
                        query = "UPDATE " & tablaName & " SET " & campoValor.ToString() & " WHERE " & fielCondition & operador & " ?Condition"
                        Comando.CommandText = query
                        Comando.Connection = MyBase.Conexion

                        For i As Integer = 0 To valores.Count() - 1
                            Comando.Parameters.AddWithValue("?Valor" & i.ToString(), valores(i))
                        Next

                        Comando.Parameters.AddWithValue("?Condition", fieldConditionValue)
                        NumFilasAfectadas = Comando.ExecuteNonQuery()
                        MyBase.Desconectar()
                    Else
                        MessageBox.Show("El número de campos (" & campos.Count().ToString() & ")" & " no coincide con el número de valores recibidos (" & valores.Count().ToString() & ") ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End If
                End Using

            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message & " CADENA COMPLETA: " & query.ToString())
                NumFilasAfectadas = 0
            Finally
                MyBase.Desconectar()
            End Try

            Return NumFilasAfectadas
        End Function

        Public Function Update(ByVal tablaName As String, ByVal campos As List(Of String), ByVal valores As List(Of String), ByVal fielCondition1 As String, ByVal fieldConditionValue1 As String, ByVal fielCondition2 As String, ByVal fieldConditionValue2 As String) As Integer
            Dim query As String = ""
            Dim NumFilasAfectadas As Int32 = 0
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Dim listaCampos As String = String.Join(",", campos.ToArray())
                    Dim listaCamposValores As List(Of String) = New List(Of String)()

                    If campos.Count() = valores.Count() Then

                        For i As Integer = 0 To valores.Count() - 1
                            listaCamposValores.Add(campos(i).ToString() & " = " & "?Valor" & i.ToString())
                        Next

                        Dim campoValor As String = String.Join(",", listaCamposValores.ToArray())
                        query = "UPDATE " & tablaName & " SET " & campoValor.ToString() & " WHERE " & fielCondition1 & " = ?Condition1 AND " & fielCondition2 & " = ?Condition2"
                        Comando.CommandText = query
                        Comando.Connection = MyBase.Conexion

                        For i As Integer = 0 To valores.Count() - 1
                            Comando.Parameters.AddWithValue("?Valor" & i.ToString(), valores(i))
                        Next

                        Comando.Parameters.AddWithValue("?Condition1", fieldConditionValue1)
                        Comando.Parameters.AddWithValue("?Condition2", fieldConditionValue2)
                        NumFilasAfectadas = Comando.ExecuteNonQuery()
                        MyBase.Desconectar()
                    Else
                        MessageBox.Show("El número de campos (" & campos.Count().ToString() & ")" & " no coincide con el número de valores recibidos (" & valores.Count().ToString() & ") ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End If
                End Using

            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message & " CADENA COMPLETA: " & query.ToString())
                NumFilasAfectadas = 0
            Finally
                MyBase.Desconectar()
            End Try

            Return NumFilasAfectadas
        End Function

        Public Function Update(ByVal tablaName As String, ByVal campos As List(Of String), ByVal valores As List(Of String), ByVal fielCondition1 As String, ByVal operador1 As String, ByVal fieldConditionValue1 As String, ByVal fielCondition2 As String, ByVal operador2 As String, ByVal fieldConditionValue2 As String) As Integer
            Dim query As String = ""
            Dim NumFilasAfectadas As Int32 = 0
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Dim listaCampos As String = String.Join(",", campos.ToArray())
                    Dim listaCamposValores As List(Of String) = New List(Of String)()

                    If campos.Count() = valores.Count() Then

                        For i As Integer = 0 To valores.Count() - 1
                            listaCamposValores.Add(campos(i).ToString() & " = " & "?Valor" & i.ToString())
                        Next

                        Dim campoValor As String = String.Join(",", listaCamposValores.ToArray())
                        query = "UPDATE " & tablaName & " SET " & campoValor.ToString() & " WHERE " & fielCondition1 & operador1 & " ?Condition1 AND " & fielCondition2 & operador2 & " ?Condition2"
                        Comando.CommandText = query
                        Comando.Connection = MyBase.Conexion

                        For i As Integer = 0 To valores.Count() - 1
                            Comando.Parameters.AddWithValue("?Valor" & i.ToString(), valores(i))
                        Next

                        Comando.Parameters.AddWithValue("?Condition1", fieldConditionValue1)
                        Comando.Parameters.AddWithValue("?Condition2", fieldConditionValue2)
                        NumFilasAfectadas = Comando.ExecuteNonQuery()
                        MyBase.Desconectar()
                    Else
                        MessageBox.Show("El número de campos (" & campos.Count().ToString() & ")" & " no coincide con el número de valores recibidos (" & valores.Count().ToString() & ") ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End If
                End Using

            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message & " CADENA COMPLETA: " & query.ToString())
                NumFilasAfectadas = 0
            Finally
                MyBase.Desconectar()
            End Try

            Return NumFilasAfectadas
        End Function

        Public Function Delete(ByVal tableName As String, ByVal field As String, ByVal fieldValue As String) As Integer
            If MessageBox.Show("Desea eliminar el regsitro seleccionado (" & fieldValue.ToUpper() & ") de la tabla  " & tableName.ToUpper() & " ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                MyBase.Conectar()
                Dim NumFilasAfectadas As Int32 = 0

                Try

                    Using MyBase.Conexion
                        Dim query As String = "DELETE FROM " & tableName & " WHERE " & field & "= " & fieldValue
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

        Public Function TrucarTablaSinTrigger(ByVal tableName As String) As Integer
            MyBase.Conectar()
            Dim NumFilasAfectadas As Int32 = 0

            Try

                Using MyBase.Conexion
                    Dim query As String = "TRUNCATE TABLE " & tableName & ";"
                    Comando.CommandText = query
                    Comando.Connection = MyBase.Conexion
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

        Public Sub TruncarTablaConTrigger(ByVal tableName As String)
            Dim sentencia As StringBuilder = New StringBuilder()
            sentencia.Append("DELETE FROM " & tableName & ";")
            sentencia.Append("ALTER TABLE " & tableName & " AUTO_INCREMENT = 1;")
            EjecutarSentencia(sentencia.ToString())
        End Sub

        Public Function GetNewId(ByVal tableName As String, ByVal idField As String) As Integer
            Dim DT As DataTable = New DataTable()
            Dim Resultado As DataRow = DT.NewRow()
            Dim ID As Integer = 0
            MyBase.Conectar()

            Try

                Using MyBase.Conexion
                    Dim query As String = "SELECT MAX(" & idField & ") + 1 AS ProximoId FROM " & tableName & ";"
                    Comando.CommandText = query
                    Comando.Connection = MyBase.Conexion
                    Adaptador.SelectCommand = Comando
                    Adaptador.Fill(DT)

                    Try

                        If DT.Rows.Count > 0 Then
                            Resultado = DT.Rows(0)
                            ID = Convert.ToInt16(Resultado("ProximoId").ToString())

                        End If

                    Catch ex As Exception
                        ID = 1
                    End Try

                    MyBase.Desconectar()
                End Using

            Catch e As MySqlException
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " & e.Message)
                ID = 0
            Finally
                MyBase.Desconectar()
            End Try

            Return ID
        End Function
    End Class
End Namespace
