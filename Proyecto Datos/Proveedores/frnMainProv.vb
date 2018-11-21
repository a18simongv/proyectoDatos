Imports System.Data.OleDb
Public Class frnMainProv

    Dim dtsManProv As DataSet
    Dim dtaProve, dtaMun, dtaProvn, dtaBan, dtaSucur, dtaFmsPg As OleDbDataAdapter

    Private Sub frnMainProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

        dtsManProv = New DataSet 'dts utilizar para proveedores

        'iniciamos los dta's
        dtaProve = New OleDbDataAdapter("Select * from Proveedores order by Codigo", CnnGestion)
        dtaProve.Fill(dtsManProv, "Prov")
        Dim cmbProv As New OleDbCommandBuilder(dtaProve)

        dtaMun = New OleDbDataAdapter("Select * from Municipios order by CodMun", CnnGestion)
        dtaMun.Fill(dtsManProv, "Mun")

        dtaProvn = New OleDbDataAdapter("Select * from Provincias order by CodProv", CnnGestion)
        dtaProvn.Fill(dtsManProv, "Provn")

        dtaSucur = New OleDbDataAdapter("Select * from Sucursales order by CodSuc", CnnGestion)
        dtaSucur.Fill(dtsManProv, "sucursal")

        dtaBan = New OleDbDataAdapter("Select * from Bancos order by CodBanco", CnnGestion)
        dtaBan.Fill(dtsManProv, "banco")

        dtaFmsPg = New OleDbDataAdapter("Select * from FormasPago order by CodFPago", CnnGestion)
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
        dtpAlta.DataBindings.Add("value", dtsManProv.Tables("Prov"), "FecAlta")
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click, tsNuevo.Click
        Dim frmNuevo As New FrmEdicionProv

        frmNuevo.Text = "Nuevo proveedor"

        frmNuevo.LblCodProv.Visible = False
        frmNuevo.TxtCodProv.Visible = False

        frmNuevo.SetDts(dtsManProv)
        enlazarCombos(frmNuevo)
        If frmNuevo.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        'preparamos el nuevo prov
        Dim fprov As DataRow
        fprov = dtsManProv.Tables("Prov").NewRow
        fprov("Codigo") = ObtenerUltimoCodigo()
        cargarDatos(frmNuevo, fprov)

        'realizamos la insercion
        dtsManProv.Tables("Prov").Rows.Add(fprov)
        dtaProve.Update(dtsManProv.Tables("Prov")) '¡¡¡ OJO DTAAAA!!!!
        dtsManProv.Tables("Prov").AcceptChanges()
        BtnUltimo_Click(Nothing, Nothing)

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click, tsModificar.Click
        Dim FrmModif As New FrmEdicionProv
        enlazarCombos(FrmModif)
        pasarDatos(FrmModif)

        FrmModif.SetDts(dtsManProv)

        FrmModif.TxtCodProv.ReadOnly = True
        FrmModif.dtpAlta.Enabled = False

        FrmModif.Text = "Modificar Proveedor"
        If FrmModif.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        'Obtenemos la fila correspondiente a la posicion del dataset en la tabla productos mediante el binding contest del formulario
        Dim fprover As DataRow
        fprover = dtsManProv.Tables("Prov").Rows(Me.BindingContext(dtsManProv.Tables("Prov")).Position)

        fprover.BeginEdit()
        cargarDatos(FrmModif, fprover)
        fprover.EndEdit()
        dtaProve.Update(dtsManProv.Tables("Prov"))
        dtsManProv.Tables("Prov").AcceptChanges()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click, tsEliminar.Click
        If MsgBox("Eliminar proveedor", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Cogemos la fila vinculada en el contexto. Explicado en BtnModificar_click.
        Dim fprover As DataRow
        fprover = dtsManProv.Tables("Prov").Rows(Me.BindingContext(dtsManProv.Tables("Prov")).Position)

        'eliminamos la fila
        fprover.Delete()
        dtaProve.Update(dtsManProv.Tables("Prov"))
        dtsManProv.Tables("Prov").AcceptChanges()
    End Sub

    Public Sub cargarDatos(formOr As FrmEdicionProv, fila As DataRow)
        With formOr
            fila("NIF") = .TxtNIF.Text
            fila("Nombre") = .TxtNombre.Text
            fila("Dirección") = .TxtDirec.Text
            fila("CodPos") = .TxtCodPos.Text
            fila("Poblac") = CShort(.cmbPobl.SelectedValue)
            fila("Provin") = CShort(.cmbProv.SelectedValue)
            fila("Tfno") = .TxtTelef.Text
            fila("Fax") = .TxtFax.Text
            fila("email") = .TxtEmail.Text
            fila("FecAlta") = .dtpAlta.Value
            fila("CodBan") = CShort(.CmbBan.SelectedValue)
            fila("CodSuc") = CShort(.CmbSuc.SelectedValue)
            fila("CodFPago") = CShort(.CmbFPago.SelectedValue)
        End With
    End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(Codigo) from Proveedores", CnnGestion)
        Dim ultimo As Object
        Dim ultimoCod As Short
        CnnGestion.Open() 'Objeto del contexto
        ultimo = cmdultimo.ExecuteScalar 'Ejecutar la busqueda de un solo campo. Retorna la primera columna de la primera fila.
        CnnGestion.Close()

        If ultimo Is DBNull.Value Then
            ultimoCod = 1 'Si no hay valores -> 1
        Else
            ultimoCod = CShort(ultimo) + 1
        End If
        Return ultimoCod 'Amo los returns.
    End Function

    Public Sub pasarDatos(frmDest As FrmEdicionProv)
        With frmDest
            .TxtCodProv.Text = TxtCodProv.Text
            .TxtNIF.Text = TxtNIF.Text
            .TxtNombre.Text = TxtNombre.Text
            .TxtDirec.Text = TxtDirec.Text
            .TxtCodPos.Text = TxtCodPos.Text
            MostrarVlrCombo(dtsManProv.Tables("mun"), "CodMun", .cmbPobl, TxtPobl.Text)
            MostrarVlrCombo(dtsManProv.Tables("Provn"), "CodProv", .cmbProv, TxtProv.Text)
            .TxtTelef.Text = TxtTelef.Text
            .TxtFax.Text = TxtFax.Text
            .TxtEmail.Text = TxtEmail.Text
            .dtpAlta.Value = dtpAlta.Value
            MostrarVlrCombo(dtsManProv.Tables("banco"), "CodBanco", .CmbBan, TxtCodBan.Text)
            MostrarVlrCombo(dtsManProv.Tables("sucursal"), "CodSuc", .CmbSuc, TxtCodSuc.Text)
            MostrarVlrCombo(dtsManProv.Tables("FmsPago"), "CodFPago", .CmbFPago, TxtCodFPago.Text)
        End With
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        'Veo el texto del botón y ejecuto una acción o no en consecuencia.
        If BtnFiltrar.Text = "Ver Todos" Then
            dtsManProv.Tables("Prov").DefaultView.RowFilter = "" 'Sin filtros. Recoge todas las filas.
            BtnFiltrar.Text = "..."
            Exit Sub
        End If

        Dim frmf As New FrmFilterProv 'Instancio el formulario
        If frmf.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        Dim queryFiltro As String = frmf.CreateFilterQuery(dtsManProv)
        Me.Cursor = Cursors.WaitCursor 'Cambiamos el estilo del cursor a la ruedita.
        dtsManProv.Tables("Prov").DefaultView.RowFilter = queryFiltro 'Defaultview.Find vs DefaultView.RowFilter
        Me.Cursor = Cursors.Default 'Cambiamos de la ruedita al cursor normal
        BtnFiltrar.Text = "Ver Todos" 'Cambiamos el texto del botón
    End Sub

    Private Sub tsSalir_Click(sender As Object, e As EventArgs) Handles tsSalir.Click
        Me.Close()
    End Sub
End Class