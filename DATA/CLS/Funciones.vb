Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Data

Namespace CLS
    Public Class Funciones
        Public Shared Sub FillCombobox(ByVal cbo As ComboBox, ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String)
            Dim Tabla As QUERY = New QUERY()
            cbo.DataSource = Tabla.GetRecords(TableName)
            cbo.DisplayMember = DisplayMember
            cbo.ValueMember = ValueMember
        End Sub

        Public Shared Sub FillCombobox(ByVal cbo As DataGridViewComboBoxColumn, ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String)
            Dim Tabla As QUERY = New QUERY()
            cbo.DataSource = Tabla.GetRecords(TableName)
            cbo.DisplayMember = DisplayMember
            cbo.ValueMember = ValueMember
            cbo.DataPropertyName = ValueMember
        End Sub

        Public Shared Sub FillCombobox(ByVal cbo As DataGridViewComboBoxCell, ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String)
            Dim Tabla As QUERY = New QUERY()
            cbo.DataSource = Tabla.GetRecords(TableName)
            cbo.DisplayMember = DisplayMember
            cbo.ValueMember = ValueMember
        End Sub

        Public Shared Sub FillGridView(ByVal gv As DataGridView, ByVal TableName As String)
            Dim Tabla As QUERY = New QUERY()
            gv.AutoGenerateColumns = False
            gv.DataSource = Tabla.GetRecords(TableName)
        End Sub

        Public Shared Sub FillGridView(ByVal gv As DataGridView, ByVal TableName As String, ByVal autoGenColumns As Boolean)
            Dim Tabla As QUERY = New QUERY()
            gv.AutoGenerateColumns = autoGenColumns
            gv.DataSource = Tabla.GetRecords(TableName)
        End Sub

        Public Shared Sub FillGridView(ByVal gv As DataGridView, ByVal myDataTable As DataTable)
            Dim Tabla As QUERY = New QUERY()
            gv.AutoGenerateColumns = False
            gv.DataSource = myDataTable
        End Sub

        Public Shared Sub FillGridView(ByVal gv As DataGridView, ByVal myDataTable As DataTable, ByVal autoGenColumns As Boolean)
            Dim Tabla As QUERY = New QUERY()
            gv.AutoGenerateColumns = autoGenColumns
            gv.DataSource = myDataTable
        End Sub

        Public Shared Function soloDigitos(ByVal sender As Object, ByVal e As KeyPressEventArgs) As Boolean
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

            Return e.Handled
        End Function

        Public Shared Function soloDecimal(ByVal sender As Object, ByVal e As KeyPressEventArgs, ByVal Texto As String) As Boolean
            Dim SeparadorDecimal As String = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator

            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            ElseIf e.KeyChar = Convert.ToChar(SeparadorDecimal) AndAlso Texto.IndexOf(Convert.ToChar(SeparadorDecimal)) <> -1 Then
                e.Handled = True
            ElseIf e.KeyChar = Convert.ToChar(SeparadorDecimal) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

            Return e.Handled
        End Function

        Public Shared Function validaConsecutivos(ByVal cajadeTexto As TextBox) As Boolean
            Dim resultado As Boolean = False

            Try
                Dim num, numSiguiente As Integer, contador As Integer = 1

                For i As Integer = 0 To cajadeTexto.TextLength - 1
                    num = Integer.Parse(cajadeTexto.Text.Substring(i, 1))

                    If i + 1 < cajadeTexto.TextLength Then
                        numSiguiente = Integer.Parse(cajadeTexto.Text.Substring(i + 1, 1))

                        If numSiguiente = num + 1 Then
                            contador += 1
                        End If
                    End If
                Next

                If contador = (cajadeTexto.TextLength) Then resultado = True
            Catch e As Exception
                MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try

            Return resultado
        End Function

        Public Shared Function validaInversos(ByVal cajadeTexto As TextBox) As Boolean
            Dim resultado As Boolean = False
            Dim num, numSiguiente As Integer, contador As Integer = 1

            Try

                For i As Integer = 0 To cajadeTexto.TextLength - 1
                    num = Integer.Parse(cajadeTexto.Text.Substring(i, 1))

                    If i + 1 < cajadeTexto.TextLength Then
                        numSiguiente = Integer.Parse(cajadeTexto.Text.Substring(i + 1, 1))

                        If num = numSiguiente + 1 Then
                            contador += 1
                        End If
                    End If
                Next

                If contador = (cajadeTexto.TextLength) Then resultado = True
            Catch e As Exception
                MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try

            Return resultado
        End Function

        Public Shared Sub enabledTextBox(ByVal objeto As Control, ByVal enable As Boolean)
            For Each ctl As Control In objeto.Controls

                If ctl.[GetType]() = GetType(System.Windows.Forms.TextBox) Then
                    ctl.Enabled = enable
                End If
            Next
        End Sub
        Public Shared Sub clearTextBox(ByVal objeto As Control)
            For Each ctl As Control In objeto.Controls

                If ctl.[GetType]() = GetType(System.Windows.Forms.TextBox) Then
                    ctl.ResetText()
                End If
            Next
        End Sub
        Public Shared Sub enabledComboBox(ByVal objeto As Control, ByVal enable As Boolean)
            For Each ctl As Control In objeto.Controls

                If ctl.[GetType]() = GetType(System.Windows.Forms.ComboBox) Then
                    ctl.Enabled = enable
                End If
            Next
        End Sub

        Public Shared Sub enabledBotones(ByVal objeto As Control, ByVal enable As Boolean)
            For Each ctl As Control In objeto.Controls

                If ctl.[GetType]() = GetType(System.Windows.Forms.Button) Then
                    ctl.Enabled = enable
                End If
            Next
        End Sub

        Public Shared Function CheckIgualValues(ByVal value1 As String, ByVal value2 As String) As Boolean
            If value1.Trim() = value2.Trim() Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function CheckIgualValues(ByVal value1 As Integer, ByVal value2 As Integer) As Boolean
            If value1 = value2 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function CompareImages(ByVal I1 As Image, ByVal I2 As Image) As Boolean
            Dim BM1 As Bitmap = I1
            Dim BM2 As Bitmap = I2
            For X = 0 To BM1.Width - 1
                For y = 0 To BM2.Height - 1
                    If BM1.GetPixel(X, y) <> BM2.GetPixel(X, y) Then
                        Return False
                    End If
                Next
            Next
            Return True
        End Function
    End Class
End Namespace
