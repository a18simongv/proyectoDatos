﻿Imports System.Data.OleDb
Public Class FrmEdicionProv
    Dim dtsDependencias As DataSet
    Dim DtaSuc, DtaBan, DtaPobl As OleDbDataAdapter
    Private Sub FrmEdicionProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

        dtsDependencias = New DataSet

        'DtaBan = New OleDbDataAdapter("Select * from Bancos", CnnGestion)
        'DtaBan.Fill(dtsDependencias, "banco")

        DtaSuc = New OleDbDataAdapter("Select * from Sucursales", CnnGestion)
        DtaSuc.Fill(dtsDependencias, "sucursal")
    End Sub

    'Private Sub CmbBan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBan.SelectedIndexChanged
    '    With Me
    '        .CmbSuc.DisplayMember = "nombresuc"
    '        .CmbSuc.ValueMember = "codsuc"
    '        .CmbSuc.DataSource = dtsDependencias.Tables("sucursal").Select("CodBanco = " & .CmbBan.SelectedItem)
    '    End With

    'End Sub

    Private Sub CmbBan_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbBan.SelectionChangeCommitted
        With Me
            .CmbSuc.DisplayMember = "nombresuc"
            .CmbSuc.ValueMember = "codsuc"
            .CmbSuc.DataSource = dtsDependencias.Tables("sucursal").Select("CodBanco = " & .CmbBan.SelectedIndex)
        End With
    End Sub
End Class