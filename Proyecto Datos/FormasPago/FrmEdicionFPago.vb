Public Class FrmEdicionFPago
    Private Sub FrmEdicionFPago_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler txtPlazo.KeyPress, AddressOf numEnterosPos
        AddHandler txtCad.KeyPress, AddressOf numEnterosPos
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class