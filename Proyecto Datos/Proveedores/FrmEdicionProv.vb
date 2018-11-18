Imports System.Data.OleDb
Public Class FrmEdicionProv

    Dim dtstablas As DataSet

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub cmbProv_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbProv.SelectionChangeCommitted
        Dim filter As String = "CodProv =" & cmbProv.SelectedValue
        dependenciaComb(dtstablas, "mun", cmbPobl, filter)
    End Sub

    Private Sub CmbBan_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbBan.SelectionChangeCommitted

        Dim filter As String = "CodBanco =" & CmbBan.SelectedValue
        dependenciaComb(dtstablas, "sucursal", CmbSuc, filter)
    End Sub

    '------------------------------------------------------------------------------------
    Public Sub SetDts(dts As DataSet)
        dtstablas = dts
    End Sub
End Class