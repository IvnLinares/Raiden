Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Imports MySql.Data.MySqlClient

Namespace CLS
    Public Class Utilities
        Private Shared MyApp_StrConnName As String = "Raiden.My.MySettings.CnxString"
        'Private Shared MyApp_StrConnName As String = "DATA.My.MySettings.CnxString"

        Public Function GetConnectionStringName() As String
            Return MyApp_StrConnName
        End Function

        Public Function GetConnectionString() As String
            Try
                Dim appconfig As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
                Dim connStringSettings As ConnectionStringSettings = appconfig.ConnectionStrings.ConnectionStrings(MyApp_StrConnName)
                Return connStringSettings.ConnectionString
            Catch e As Exception
                Return e.Message
            End Try
        End Function

        Public Sub SaveConnectionString(ByVal connectionString As String)
            Dim MiAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
            Dim miSeccion As ConnectionStringsSection = CType(MiAppConfig.GetSection("connectionStrings"), ConnectionStringsSection)
            MiAppConfig.ConnectionStrings.ConnectionStrings(MyApp_StrConnName).ConnectionString = connectionString
            MiAppConfig.Save()
            MessageBox.Show("Se guardó la cadena de conexión. la Aplicación se reiniciará", "ConnectionSettings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Restart()
        End Sub

        Public Sub ProtectConnectionString()
            ConnectionStringProtection(System.Windows.Forms.Application.ExecutablePath, True)
        End Sub

        Public Sub UnprotectConnectionString()
            ConnectionStringProtection(System.Windows.Forms.Application.ExecutablePath, False)
        End Sub

        Private Sub ConnectionStringProtection(ByVal pathName As String, ByVal protect As Boolean)
            Dim strProvider As String = "DataProtectionConfigurationProvider"
            Dim oConfiguration As System.Configuration.Configuration = Nothing
            Dim oSection As System.Configuration.ConnectionStringsSection = Nothing

            Try
                oConfiguration = System.Configuration.ConfigurationManager.OpenExeConfiguration(pathName)

                If oConfiguration IsNot Nothing Then
                    Dim blnChanged As Boolean = False
                    oSection = TryCast(oConfiguration.GetSection("connectionStrings"), System.Configuration.ConnectionStringsSection)

                    If oSection IsNot Nothing Then

                        If (Not (oSection.ElementInformation.IsLocked)) AndAlso (Not (oSection.SectionInformation.IsLocked)) Then

                            If protect Then

                                If Not (oSection.SectionInformation.IsProtected) Then
                                    blnChanged = True
                                    oSection.SectionInformation.ProtectSection(strProvider)
                                    MessageBox.Show("Protección aplicada satisfactoriamente", "ConnectionSettings", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Else

                                If oSection.SectionInformation.IsProtected Then
                                    blnChanged = True
                                    oSection.SectionInformation.UnprotectSection()
                                    MessageBox.Show("Se ha desprotegido la cadena de conexión", "ConnectionSettings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            End If
                        End If

                        If blnChanged Then
                            oSection.SectionInformation.ForceSave = True
                            oConfiguration.Save()
                        End If
                    End If
                End If

            Catch ex As System.Exception
                Throw (ex)
            Finally
            End Try
        End Sub

        Public Shared Function GetConnectionStringNames() As List(Of String)
            Dim cns As List(Of String) = New List(Of String)()
            Dim appconfig As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            For Each cn As ConnectionStringSettings In appconfig.ConnectionStrings.ConnectionStrings
                cns.Add(cn.Name)
            Next

            Return cns
        End Function

        Public Function GetMySQL_ServerName() As String
            Try
                Dim cs As String = GetConnectionString()

                If cs IsNot Nothing Then
                    Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(cs)
                    Return builder.Server
                Else
                    Return Nothing
                End If

            Catch e As Exception
                Return e.Message
            End Try
        End Function

        Public Function GetMySQL_Port() As UInteger
            Try
                Dim cs As String = GetConnectionString()

                If cs IsNot Nothing Then
                    Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(cs)
                    Return builder.Port
                Else
                    Return 0
                End If

            Catch e As Exception
                MessageBox.Show(e.Message)
                Return 0
            End Try
        End Function

        Public Function GetMySQL_DatabaseName() As String
            Try
                Dim cs As String = GetConnectionString()

                If cs IsNot Nothing Then
                    Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(cs)
                    Return builder.Database
                Else
                    Return Nothing
                End If

            Catch e As Exception
                Return e.Message
            End Try
        End Function

        Public Function GetMySQL_UserName() As String
            Try
                Dim cs As String = GetConnectionString()

                If cs IsNot Nothing Then
                    Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(cs)
                    Return builder.UserID
                Else
                    Return Nothing
                End If

            Catch e As Exception
                Return e.Message
            End Try
        End Function

        Public Function GetMySQL_Password() As String
            Try
                Dim cs As String = GetConnectionString()

                If cs IsNot Nothing Then
                    Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(cs)
                    Return builder.Password
                Else
                    Return Nothing
                End If

            Catch e As Exception
                Return e.Message
            End Try
        End Function

        Public Function GetMySQL_IntegratedSecurity() As Boolean?
            Try
                Dim cs As String = GetConnectionString()

                If cs IsNot Nothing Then
                    Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(cs)
                    Return builder.IntegratedSecurity
                Else
                    Return Nothing
                End If

            Catch __unusedException1__ As Exception
                Return Nothing
            End Try
        End Function

        Public Function SetConnectionStringComplete(ByVal serverName As String, ByVal port As UInteger, ByVal databaseName As String, ByVal username As String, ByVal password As String) As String
            Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(GetConnectionString())
            builder.Server = serverName
            builder.Database = databaseName
            builder.UserID = username
            builder.Password = password
            builder.Port = port
            Return builder.ConnectionString
        End Function

        Public Function SetConnectionStringServerName(ByVal serverName As String) As String
            Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(GetConnectionString())
            builder.Server = serverName
            Return builder.ConnectionString
        End Function

        Public Function SetConnectionStringPort(ByVal port As UInteger) As String
            Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(GetConnectionString())
            builder.Port = port
            Return builder.ConnectionString
        End Function

        Public Function SetConnectionStringDatabaseName(ByVal databaseName As String) As String
            Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(GetConnectionString())
            builder.Database = databaseName
            Return builder.ConnectionString
        End Function

        Public Function SetConnectionStringAutenticationMySQL(ByVal username As String, ByVal password As String) As String
            Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(GetConnectionString())
            builder.UserID = username
            builder.Password = password
            Return builder.ConnectionString
        End Function

        Public Function SetConnectionStringAutenticationIntegrated(ByVal connectionString As String) As String
            Dim builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder(connectionString)
            builder.IntegratedSecurity = True
            Return builder.ConnectionString
        End Function
    End Class
End Namespace
