Imports System.Data.OleDb
Public Class frnMainProv

    Dim dtsManProv As DataSet
    Dim dtaProve, dtaMun, dtaProvn, dtaSucur, dtaFmsPg As OleDbDataAdapter

    Private Sub frnMainProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo

        dtsManProv = New DataSet 'dts utilizar para proveedores

        'iniciamos los dta's
        dtaProve = New OleDbDataAdapter("Select * from Proveedores", CnnGestion)
        dtaProve.Fill(dtsManProv, "Prov")

        'dtaMun = New OleDbDataAdapter("Select * from Municipios", CnnGestion)
        'dtaMun.Fill(dtsManProv, "Mun")

        dtaProvn = New OleDbDataAdapter("Select * from Provincias", CnnGestion)
        dtaProvn.Fill(dtsManProv, "Provn")

        'dtaSucur = New OleDbDataAdapter("Select * from Sucursales", CnnGestion)
        'dtaSucur.Fill(dtsManProv, "Suc")

        dtaFmsPg = New OleDbDataAdapter("Select * from FormasPago", CnnGestion)
        dtaFmsPg.Fill(dtsManProv, "FmsPago")

        enlazarDatos()
    End Sub

    Private Sub enlazarDatos()
        TxtCodProv.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "CodProv")
        TxtNIF.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "NIF")
        TxtNombre.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "Nombre")
        TxtDirec.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "Dirección")
        TxtCodPos.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "CodPos")
        TxtPobl.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "Poblac")
        TxtProv.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "Provin")
        TxtTelef.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "Tfno")
        TxtFax.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "Fax")
        TxtEmail.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "email")
        TxtFecAlta.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "FecAlta")
    End Sub
End Class