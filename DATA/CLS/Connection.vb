Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Windows.Forms

Namespace CLS
    Public Class Connection
        Protected Conexion As MySqlConnection = New MySqlConnection()
        Protected Function Conectar() As Boolean
            Dim Resultado As Boolean = False
            Dim cnxString As Utilities = New Utilities()
            Try
                Conexion.ConnectionString = cnxString.GetConnectionString()
                Conexion.Open()
                Resultado = True
            Catch
                Resultado = False
            End Try
            Return Resultado
        End Function
        Protected Sub Desconectar()
            Try
                If Conexion.State = System.Data.ConnectionState.Open Then
                    Conexion.Close()
                End If
            Catch
            End Try
        End Sub

        Public Function ValidarConexion(ByVal connString As String) As Boolean
            Try

                Using conn As MySqlConnection = New MySqlConnection(connString)
                    conn.Open()
                    Return True
                End Using

            Catch
                Return False
            End Try
        End Function
    End Class
End Namespace