Imports System.Data.OleDb

Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")
    End Sub

    Private Sub BtnProd_Click(sender As Object, e As EventArgs) Handles BtnProd.Click
        Dim frm As New FrmMainProd
        frm.ShowDialog()
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        frnMainProv.ShowDialog()
    End Sub
End Class