Public Class FrmEdicionTIva
    Private Sub FrmEdicionTIva_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler TxtPorcen.KeyPress, AddressOf numEnterosPos
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class