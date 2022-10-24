Imports MySql.Data.MySqlClient
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Namespace CLS
    Public Class Transacciones
        Inherits Connection
        Private Comando As MySqlCommand = New MySqlCommand()
        Private transaccion_ As MySqlTransaction
        Public Function Transaccion(ByVal sentences As List(Of String)) As Boolean
            Dim Resultado As Boolean
            MyBase.Conectar()
            transaccion_ = MyBase.Conexion.BeginTransaction(System.Data.IsolationLevel.ReadCommitted)
            Comando.Connection = MyBase.Conexion
            Using MyBase.Conexion
                Try
                    For Each sql As String In sentences
                        Comando.CommandText = sql
                        Comando.ExecuteNonQuery()
                    Next
                    transaccion_.Commit()

                    Resultado = True
                Catch e As MySqlException
                    MessageBox.Show("¡Error en la consulta SQL de la clase TRANSACCIÓN! : " & e.Message)
                    Resultado = False
                    transaccion_.Rollback()
                Finally
                    MyBase.Desconectar()
                End Try
            End Using
            Return Resultado
        End Function
    End Class
End Namespace

