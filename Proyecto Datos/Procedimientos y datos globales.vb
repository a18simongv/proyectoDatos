Imports System.Data.OleDb
Module Procedimientos_y_datos_globales
    Public CnnGestion As OleDbConnection

    'Procedimiento de enlace de combos
    Public Sub MostrarVlrCombo(tabla As DataTable, campo As String, cmb As ComboBox, buscarCmb As String)
        tabla.DefaultView.Sort = campo
        Dim posicion As Integer = tabla.DefaultView.Find(buscarCmb)

        If posicion = -1 Then
            cmb.SelectedIndex = 0
        Else
            cmb.SelectedIndex = posicion
        End If

    End Sub
End Module
