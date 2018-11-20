Imports System.Data.OleDb
Public Class FrmMainClt
    Dim dtsManClt As DataSet
    Dim dtaclte, dtaMun, dtaProvn, dtaBan, dtaSucur, dtaFmsPg As OleDbDataAdapter

    Private Sub frnMainclt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        CnnGestion = New OleDbConnection _
        ("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

        dtsManClt = New DataSet 'dts utilizar para clteedores

        'iniciamos los dta's
        dtaclte = New OleDbDataAdapter("Select * from Clientes order by Codigo", CnnGestion)
        dtaclte.Fill(dtsManclt, "clt")
        Dim cmbclt As New OleDbCommandBuilder(dtaclte)

        dtaMun = New OleDbDataAdapter("Select * from Municipios order by CodMun", CnnGestion)
        dtaMun.Fill(dtsManclt, "Mun")

        dtaProvn = New OleDbDataAdapter("Select * from Provincias order by CodProv", CnnGestion)
        dtaProvn.Fill(dtsManclt, "provn")

        dtaSucur = New OleDbDataAdapter("Select * from Sucursales order by CodSuc", CnnGestion)
        dtaSucur.Fill(dtsManclt, "sucursal")

        dtaBan = New OleDbDataAdapter("Select * from Bancos order by CodBanco", CnnGestion)
        dtaBan.Fill(dtsManclt, "banco")

        dtaFmsPg = New OleDbDataAdapter("Select * from FormasPago order by CodFPago", CnnGestion)
        dtaFmsPg.Fill(dtsManclt, "FmsPago")

        enlazarDatos()
    End Sub

    Private Sub enlazarDatos()
        'enlazamos textbox
        TxtCodClt.DataBindings.Add("Text", dtsManclt.Tables("clt"), "Codigo")
        TxtNIF.DataBindings.Add("Text", dtsManclt.Tables("clt"), "NIF")
        TxtNombre.DataBindings.Add("Text", dtsManclt.Tables("clt"), "Nombre")
        TxtDirec.DataBindings.Add("Text", dtsManclt.Tables("clt"), "Dirección")
        TxtCodPos.DataBindings.Add("Text", dtsManclt.Tables("clt"), "CodPos")
        TxtPobl.DataBindings.Add("Text", dtsManclt.Tables("clt"), "Poblac")
        TxtProv.DataBindings.Add("Text", dtsManClt.Tables("clt"), "Provin")
        TxtTelef.DataBindings.Add("Text", dtsManclt.Tables("clt"), "Tfno")
        TxtFax.DataBindings.Add("Text", dtsManclt.Tables("clt"), "Fax")
        TxtEmail.DataBindings.Add("Text", dtsManclt.Tables("clt"), "email")
        dtpAlta.DataBindings.Add("value", dtsManclt.Tables("clt"), "FecAlta")
        TxtCodBan.DataBindings.Add("Text", dtsManclt.Tables("clt"), "CodBan")
        TxtCodSuc.DataBindings.Add("Text", dtsManClt.Tables("clt"), "CodSuc")
        TxtDirecEnv.DataBindings.Add("Text", dtsManClt.Tables("clt"), "DirEnv")
        TxtCodFPago.DataBindings.Add("Text", dtsManclt.Tables("clt"), "CodFPago")
        'enlazamos datagridview
        DtgClientes.DataSource = dtsManclt.Tables("clt")
        ConfigurationGrid()
    End Sub
    Private Sub ConfigurationGrid()
        'Cambiamos el texto del titulo de la columna por un string.
        With DtgClientes
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
            .Columns("DirEnv").HeaderText = "Dir. Envio"
            .Columns("CodFPago").HeaderText = "Forma pago"

        End With
    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click, btsPri.Click
        Me.BindingContext(dtsManClt.Tables("clt")).Position = 0
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click, btsAnt.Click
        Me.BindingContext(dtsManClt.Tables("clt")).Position -= 1
    End Sub
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click, btsSig.Click
        Me.BindingContext(dtsManClt.Tables("clt")).Position += 1
    End Sub
    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click, btsUlt.Click
        Me.BindingContext(dtsManClt.Tables("clt")).Position = Me.BindingContext(dtsManClt.Tables("clt")).Count - 1
    End Sub

    Private Sub Buscarclt(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtCodBuscar.Text = "" Then
            MsgBox("Debe teclear un código de clteedor", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        Dim posicion As Integer
        'Necesario ordenar por campo antes de buscar el registro con ese campo
        dtsManclt.Tables("clt").DefaultView.Sort = "Codigo"
        posicion = dtsManclt.Tables("clt").DefaultView.Find(TxtCodBuscar.Text)
        If posicion = -1 Then
            MsgBox("No hay ningún cliente con el Código " & TxtCodBuscar.Text, MsgBoxStyle.Information, "Atención")
            TxtCodBuscar.Focus()
            TxtCodBuscar.SelectAll()
            Exit Sub
        End If
        TxtCodBuscar.Text = ""
        Me.BindingContext(dtsManclt.Tables("clt")).Position = posicion 'Colocamos el dataset del contexto en la posicion del dataset
    End Sub

    Private Sub enlazarCombos(frmAux As FrmEdicionClt)
        With frmAux
            .CmbBan.DataSource = dtsManClt.Tables("banco")
            .CmbBan.DisplayMember = "Nombre"
            .CmbBan.ValueMember = "CodBanco"

            .CmbSuc.DataSource = dtsManClt.Tables("sucursal")
            .CmbSuc.DisplayMember = "nombresuc"
            .CmbSuc.ValueMember = "codsuc"

            .cmbPobl.DataSource = dtsManClt.Tables("mun")
            .cmbPobl.DisplayMember = "nombre"
            .cmbPobl.ValueMember = "codmun"

            .cmbProv.DataSource = dtsManClt.Tables("provn")
            .cmbProv.DisplayMember = "nombre"
            .cmbProv.ValueMember = "codProv"

            .CmbFPago.DataSource = dtsManClt.Tables("fmspago")
            .CmbFPago.DisplayMember = "descrip"
            .CmbFPago.ValueMember = "codfpago"
        End With
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click, tsNuevo.Click
        Dim frmNuevo As New FrmEdicionClt

        frmNuevo.Text = "Nuevo Cliente"

        frmNuevo.LblCodClt.Visible = False
        frmNuevo.TxtCodClt.Visible = False

        frmNuevo.SetDts(dtsManClt)
        enlazarCombos(frmNuevo)
        If frmNuevo.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        'preparamos el nuevo clt
        Dim fclt As DataRow
        fclt = dtsManClt.Tables("clt").NewRow
        fclt("Codigo") = ObtenerUltimoCodigo()
        cargarDatos(frmNuevo, fclt)

        'realizamos la insercion
        dtsManClt.Tables("clt").Rows.Add(fclt)
        dtaclte.Update(dtsManClt.Tables("clt")) '¡¡¡ OJO DTAAAA!!!!
        dtsManClt.Tables("clt").AcceptChanges()
        BtnUltimo_Click(Nothing, Nothing)

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click, tsModificar.Click
        Dim FrmModif As New FrmEdicionClt
        enlazarCombos(FrmModif)
        pasarDatos(FrmModif)

        FrmModif.SetDts(dtsManClt)

        FrmModif.TxtCodClt.ReadOnly = True
        FrmModif.dtpAlta.Enabled = False

        FrmModif.Text = "Modificar Cliente"
        If FrmModif.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        'Obtenemos la fila correspondiente a la posicion del dataset en la tabla productos mediante el binding contest del formulario
        Dim fclter As DataRow
        fclter = dtsManClt.Tables("clt").Rows(Me.BindingContext(dtsManClt.Tables("clt")).Position)

        fclter.BeginEdit()
        cargarDatos(FrmModif, fclter)
        fclter.EndEdit()
        dtaclte.Update(dtsManClt.Tables("clt"))
        dtsManClt.Tables("clt").AcceptChanges()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click, BtnEliminar.Click
        If MsgBox("Eliminar cliente", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Cogemos la fila vinculada en el contexto. Explicado en BtnModificar_click.
        Dim fclter As DataRow
        fclter = dtsManClt.Tables("clt").Rows(Me.BindingContext(dtsManClt.Tables("clt")).Position)

        'eliminamos la fila
        fclter.Delete()
        dtaclte.Update(dtsManClt.Tables("clt"))
        dtsManClt.Tables("clt").AcceptChanges()
    End Sub

    Public Sub cargarDatos(formOr As FrmEdicionClt, fila As DataRow)
        With formOr
            fila("NIF") = .TxtNIF.Text
            fila("Nombre") = .TxtNombre.Text
            fila("Dirección") = .TxtDirec.Text
            fila("CodPos") = .TxtCodPos.Text
            fila("Poblac") = .cmbPobl.SelectedValue
            fila("Provin") = CShort(.cmbProv.SelectedValue)
            fila("Tfno") = .TxtTelef.Text
            fila("Fax") = .TxtFax.Text
            fila("email") = .TxtEmail.Text
            fila("FecAlta") = .dtpAlta.Value
            fila("CodBan") = CShort(.CmbBan.SelectedValue)
            fila("CodSuc") = CShort(.CmbSuc.SelectedValue)
            fila("DirEnv") = CShort(.TxtDirEnv.Text)
            fila("CodFPago") = CShort(.CmbFPago.SelectedValue)
        End With
    End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(Codigo) from Clientes", CnnGestion)
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

    Public Sub pasarDatos(frmDest As FrmEdicionClt)
        With frmDest
            .TxtCodClt.Text = TxtCodClt.Text
            .TxtNIF.Text = TxtNIF.Text
            .TxtNombre.Text = TxtNombre.Text
            .TxtDirec.Text = TxtDirec.Text
            .TxtCodPos.Text = TxtCodPos.Text
            MostrarVlrCombo(dtsManClt.Tables("mun"), "CodMun", .cmbPobl, TxtPobl.Text)
            MostrarVlrCombo(dtsManClt.Tables("provn"), "CodProv", .cmbProv, TxtProv.Text)
            .TxtTelef.Text = TxtTelef.Text
            .TxtFax.Text = TxtFax.Text
            .TxtEmail.Text = TxtEmail.Text
            .dtpAlta.Value = dtpAlta.Value
            MostrarVlrCombo(dtsManClt.Tables("banco"), "CodBanco", .CmbBan, TxtCodBan.Text)
            MostrarVlrCombo(dtsManClt.Tables("sucursal"), "CodSuc", .CmbSuc, TxtCodSuc.Text)
            .TxtDirEnv.Text = TxtDirecEnv.Text
            MostrarVlrCombo(dtsManClt.Tables("FmsPago"), "CodFPago", .CmbFPago, TxtCodFPago.Text)
        End With
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        'Veo el texto del botón y ejecuto una acción o no en consecuencia.
        If BtnFiltrar.Text = "Ver Todos" Then
            dtsManClt.Tables("clt").DefaultView.RowFilter = "" 'Sin filtros. Recoge todas las filas.
            BtnFiltrar.Text = "..."
            Exit Sub
        End If

        Dim frmf As New FrmFilterClt 'Instancio el formulario
        If frmf.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        Dim queryFiltro As String = frmf.CreateFilterQuery(dtsManClt)
        Me.Cursor = Cursors.WaitCursor 'Cambiamos el estilo del cursor a la ruedita.
        dtsManClt.Tables("clt").DefaultView.RowFilter = queryFiltro 'Defaultview.Find vs DefaultView.RowFilter
        Me.Cursor = Cursors.Default 'Cambiamos de la ruedita al cursor normal
        BtnFiltrar.Text = "Ver Todos" 'Cambiamos el texto del botón
    End Sub

    Private Sub tsSalir_Click(sender As Object, e As EventArgs) Handles tsSalir.Click
        Me.Close()
    End Sub
End Class