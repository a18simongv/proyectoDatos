Imports System.Data.OleDb

Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\Pablo\source\repos\a18pablodv\AccesoDatosInterfaces\Gestion comercial.mdb")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class