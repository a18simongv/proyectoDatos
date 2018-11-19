Imports System.Data.OleDb
Module Procedimientos_y_datos_globales
    Public CnnGestion As OleDbConnection

    'Procedimiento de enlace de combos
    Public Sub MostrarVlrCombo(tabla As DataTable, campo As String, cmb As ComboBox, buscarCmb As String)
        tabla.DefaultView.RowFilter = ""
        tabla.DefaultView.Sort = campo
        Dim posicion As Integer = tabla.DefaultView.Find(buscarCmb)

        If posicion = -1 Then
            cmb.SelectedIndex = 0
        Else
            cmb.SelectedIndex = posicion
        End If

    End Sub

    Public Sub dependenciaComb(tabla As DataTable, cmb As ComboBox, filtrar As String)
        tabla.DefaultView.RowFilter = filtrar
        cmb.DataSource = tabla
    End Sub

    'eventos de keypress
    Public Sub numEnterosPos(sender As Object, e As KeyPressEventArgs)
        Dim txtbox As TextBox
        txtbox = TryCast(sender, TextBox)

        Dim valores As String = "0123456789" & Chr(8)

        If Not valores.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Sub numEnteros(sender As Object, e As KeyPressEventArgs)
        Dim txtbox As TextBox
        txtbox = TryCast(sender, TextBox)

        Dim valores As String = "-0123456789" & Chr(8)

        If Not valores.Contains(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = "-" Then
            If txtbox.Text.Contains(e.KeyChar) Then
                e.Handled = True
            Else
                txtbox.Text = e.KeyChar & txtbox.Text
            End If
        End If
    End Sub
    Public Sub email(sender As Object, e As KeyPressEventArgs)
        Dim txtbox As TextBox
        txtbox = TryCast(sender, TextBox)

        Dim valores As String = "0123456789" & Chr(8)

        If Not valores.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Sub numDecimal(sender As Object, e As KeyPressEventArgs)
        Dim txtbox As TextBox
        txtbox = TryCast(sender, TextBox)

        Dim valores As String = "0123456789" & Chr(8)

        If Not valores.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Module
