Imports System.Data.OleDb
Public Class frnMainProv

    Dim dtsManProv As DataSet
    Dim dtaProve, dtaMun, dtaProvn, dtaBan, dtaSucur, dtaFmsPg As OleDbDataAdapter

    Private Sub frnMainProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

        dtsManProv = New DataSet 'dts utilizar para proveedores

        'iniciamos los dta's
        dtaProve = New OleDbDataAdapter("Select * from Proveedores", CnnGestion)
        dtaProve.Fill(dtsManProv, "Prov")

        dtaMun = New OleDbDataAdapter("Select * from Municipios", CnnGestion)
        dtaMun.Fill(dtsManProv, "Mun")

        dtaProvn = New OleDbDataAdapter("Select * from Provincias", CnnGestion)
        dtaProvn.Fill(dtsManProv, "Provn")

        dtaSucur = New OleDbDataAdapter("Select * from Sucursales", CnnGestion)
        dtaSucur.Fill(dtsManProv, "sucursal")

        dtaBan = New OleDbDataAdapter("Select * from Bancos", CnnGestion)
        dtaBan.Fill(dtsManProv, "banco")

        dtaFmsPg = New OleDbDataAdapter("Select * from FormasPago", CnnGestion)
        dtaFmsPg.Fill(dtsManProv, "FmsPago")

        enlazarDatos()
    End Sub

    Private Sub enlazarDatos()
        'enlazamos textbox
        TxtCodProv.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "Codigo")
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
        TxtCodBan.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "CodBan")
        TxtCodSuc.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "CodSuc")
        TxtCodFPago.DataBindings.Add("Text", dtsManProv.Tables("Prov"), "CodFPago")
        'enlazamos datagridview
        DtgProveedores.DataSource = dtsManProv.Tables("Prov")
        ConfigurationGrid()
    End Sub
    Private Sub ConfigurationGrid()
        'Cambiamos el texto del titulo de la columna por un string.
        With DtgProveedores
            .Columns("Codigo").HeaderText = "Id"
            .Columns("NIF").HeaderText = "Nif"
            .Columns("Nombre").HeaderText = "Nombre"
            .Columns("Dirección").HeaderText = "Dirección"
            .Columns("CodPos").HeaderText = "Cod.Postal"
            .Columns("Poblac").HeaderText = "Población"
            .Columns("Provin").HeaderText = "Provincia"
            .Columns("Tfno").HeaderText = "Telefono"
            .Columns("Fax").HeaderText = "Fax"
            .Columns("email").HeaderText = "Email"
            .Columns("FecAlta").HeaderText = "Fecha alta"
            .Columns("CodBan").HeaderText = "Cod.Banco"
            .Columns("CodSuc").HeaderText = "Cod.Sucursal"
            .Columns("CodFPago").HeaderText = "Forma pago"

        End With
    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        Me.BindingContext(dtsManProv.Tables("prov")).Position = 0
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        Me.BindingContext(dtsManProv.Tables("prov")).Position -= 1
    End Sub
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Me.BindingContext(dtsManProv.Tables("prov")).Position += 1
    End Sub
    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click
        Me.BindingContext(dtsManProv.Tables("prov")).Position = Me.BindingContext(dtsManProv.Tables("prov")).Count - 1
    End Sub

    Private Sub BuscarProv(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtCodBuscar.Text = "" Then
            MsgBox("Debe teclear un código de proveedor", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        Dim posicion As Integer
        'Necesario ordenar por campo antes de buscar el registro con ese campo
        dtsManProv.Tables("prov").DefaultView.Sort = "Codigo"
        posicion = dtsManProv.Tables("prov").DefaultView.Find(TxtCodBuscar.Text)
        If posicion = -1 Then
            MsgBox("No hay ningún proveedor con el Código " & TxtCodBuscar.Text, MsgBoxStyle.Information, "Atención")
            TxtCodBuscar.Focus()
            TxtCodBuscar.SelectAll()
            Exit Sub
        End If
        TxtCodBuscar.Text = ""
        Me.BindingContext(dtsManProv.Tables("prov")).Position = posicion 'Colocamos el dataset del contexto en la posicion del dataset
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frmNuevo As New FrmEdicionProv
        enlazarCombos(frmNuevo)
        frmNuevo.ShowDialog()
    End Sub

    Private Sub enlazarCombos(frmAux As FrmEdicionProv)
        With frmAux
            .CmbBan.DataSource = dtsManProv.Tables("banco")
            .CmbBan.DisplayMember = "Nombre"
            .CmbBan.ValueMember = "CodBanco"

            .CmbSuc.DataSource = dtsManProv.Tables("sucursal")
            .CmbSuc.DisplayMember = "nombresuc"
            .CmbSuc.ValueMember = "codsuc"

            .cmbPobl.DataSource = dtsManProv.Tables("mun")
            .cmbPobl.DisplayMember = "nombre"
            .cmbPobl.ValueMember = "codmun"

            .cmbProv.DataSource = dtsManProv.Tables("provn")
            .cmbProv.DisplayMember = "nombre"
            .cmbProv.ValueMember = "codprov"

            .CmbFPago.DataSource = dtsManProv.Tables("fmspago")
            .CmbFPago.DisplayMember = "descrip"
            .CmbFPago.ValueMember = "codfpago"
        End With
    End Sub
End Class