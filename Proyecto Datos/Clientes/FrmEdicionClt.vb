Public Class FrmEdicionClt
    Dim dtstablas As DataSet

    Private Sub FrmEdicionClt_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler TxtNIF.KeyPress, AddressOf numEnterosPos
        AddHandler TxtCodPos.KeyPress, AddressOf numEnterosPos
        AddHandler TxtTelef.KeyPress, AddressOf numEnterosPos
        AddHandler TxtFax.KeyPress, AddressOf numEnterosPos
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub cmbProv_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbProv.SelectionChangeCommitted
        Dim filter As String = "CodProv =" & cmbProv.SelectedValue
        dependenciaComb(dtstablas.Tables("mun"), cmbPobl, filter)
    End Sub

    Private Sub CmbBan_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbBan.SelectionChangeCommitted

        Dim filter As String = "CodBanco =" & CmbBan.SelectedValue
        dependenciaComb(dtstablas.Tables("sucursal"), CmbSuc, filter)
    End Sub

    '------------------------------------------------------------------------------------
    Public Sub SetDts(dts As DataSet)
        dtstablas = dts
    End Sub
End Class