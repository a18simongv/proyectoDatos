Imports System.Data.OleDb

Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")
    End Sub

    Private Sub BtnProd_Click(sender As Object, e As EventArgs) Handles BtnProd.Click
        Dim frm As New FrmMainProd
        frm.ShowDialog()
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        Dim frm As New frnMainProv
        frm.ShowDialog()
    End Sub

    Private Sub BtnClt_Click(sender As Object, e As EventArgs) Handles BtnClt.Click
        Dim frm As New FrmMainClt
        frm.ShowDialog()
    End Sub

    Private Sub BtnTiposIva_Click(sender As Object, e As EventArgs) Handles BtnTiposIva.Click
        Dim frm As New FrmMainTIva
        frm.ShowDialog()
    End Sub

    Private Sub BtnFPago_Click(sender As Object, e As EventArgs) Handles BtnFPago.Click
        Dim frm As New FrmMainFPago
        frm.ShowDialog()
    End Sub

    Private Sub btnGesPed_Click(sender As Object, e As EventArgs) Handles btnGesPed.Click
        Dim frm As New FormGestionPedidos
        frm.ShowDialog()
    End Sub

    Private Sub btnRecPed_Click(sender As Object, e As EventArgs) Handles btnRecPed.Click
        Dim frm As New FrmRecepPedido
        frm.ShowDialog()
    End Sub
End Class