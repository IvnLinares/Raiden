Public Class ConnectionManager
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerify.CheckedChanged

    End Sub

    Private Sub ConnectionManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnx As CLS.Utilities = New CLS.Utilities()
        txtServer.Text = cnx.GetMySQL_ServerName()
        txtUser.Text = cnx.GetMySQL_UserName()
        txtBD.Text = cnx.GetMySQL_DatabaseName()
        txtPort.Text = cnx.GetMySQL_Port()
        txtPass.Text = cnx.GetMySQL_Password()


    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cnxValidar As CLS.Connection = New CLS.Connection
        Dim cnx As CLS.Utilities = New CLS.Utilities
        Dim newString As String = String.Empty
        newString = cnx.SetConnectionStringComplete(txtServer.Text, Convert.ToInt32(txtPort.Text), txtBD.Text, txtUser.Text, txtPass.Text)

        If (chkVerify.Checked) Then
            If (cnxValidar.ValidarConexion(newString)) Then
                MessageBox.Show("La conexion fue exitosa")
                If (newString IsNot Nothing) Then
                    cnx.SaveConnectionString(newString)
                    cnx.ProtectConnectionString()
                End If
            Else
                MessageBox.Show("No fue posible establecer la conexion con el servidor")
            End If

        Else
            If (newString IsNot Nothing) Then
                cnx.SaveConnectionString(newString)
                cnx.ProtectConnectionString()
            End If
        End If
    End Sub
    Private Sub txtPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPort.KeyPress
        CLS.Funciones.soloDigitos(sender, e)

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class