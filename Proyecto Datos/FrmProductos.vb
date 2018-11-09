Imports System.Data.OleDb
Public Class FrmProductos
    Dim DtsMProductos As DataSet
    Dim DtaProductos, DtaTiposIva, DtaProveedores As OleDbDataAdapter
    Public OperadoresString, OperadoresNumFec As String()
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load

        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "L:\DesenvolvementoInterfaces\Proyectos\Gestion comercial.mdb")
        DtaProductos = New OleDbDataAdapter("Select * from Productos order by CodProd", CnnGestion)
        DtsMProductos = New DataSet
        DtaProductos.Fill(DtsMProductos, "Prod")
        Dim cmbProductos As New OleDbCommandBuilder(DtaProductos)

        DtaTiposIva = New OleDbDataAdapter("Select * from TiposIva order by Porcentaje", CnnGestion)
        DtaTiposIva.Fill(DtsMProductos, "Iva")

        DtaProveedores = New OleDbDataAdapter("Select * from Proveedores order by Nombre", CnnGestion)
        DtaProveedores.Fill(DtsMProductos, "Prove")

        EnlazarControles()

    End Sub
    Private Sub EnlazarControles()
        TxtCodProd.DataBindings.Add("Text", DtsMProductos.Tables("Prod"), "CodProd")
        TxtDescri.DataBindings.Add("Text", DtsMProductos.Tables("Prod"), "Descri")
        TxtExist.DataBindings.Add("Text", DtsMProductos.Tables("Prod"), "Exist")
        TxtStMin.DataBindings.Add("Text", DtsMProductos.Tables("Prod"), "StMin")
        TxtStRep.DataBindings.Add("Text", DtsMProductos.Tables("Prod"), "StRep")
        TxtPVP.DataBindings.Add("Text", DtsMProductos.Tables("Prod"), "PVP")
        TxtPCM.DataBindings.Add("Text", DtsMProductos.Tables("Prod"), "PCM")
        TxtTipoIva.DataBindings.Add("Text", DtsMProductos.Tables("Prod"), "TipoIva")
        TxtCodProv.DataBindings.Add("Text", DtsMProductos.Tables("Prod"), "CodProv")
        ChkPendiente.DataBindings.Add("Checked", DtsMProductos.Tables("Prod"), "Pendiente")
        'Dtg datagrid Dts datasource
        DtgProductos.DataSource = DtsMProductos.Tables("Prod")
        ConfigurationGrid()
    End Sub

    Private Sub ConfigurationGrid()
        With DtgProductos
            .Columns("CodProd").HeaderText = "Id"
            .Columns("Descri").HeaderText = "Descripcion"
            .Columns("Exist").HeaderText = "Existencias"
            .Columns("StMin").HeaderText = "Stock minimo"
            .Columns("StRep").HeaderText = "Stock Reposicion"
            .Columns("PCM").HeaderText = "Precio de compra"
            .Columns("TipoIVA").HeaderText = "IVA"
            .Columns("CodProv").HeaderText = "Codigo proveedor"
            .Columns("Pendiente").HeaderText = "Recibir"
        End With
    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        Me.BindingContext(DtsMProductos.Tables("Prod")).Position = 0
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        Me.BindingContext(DtsMProductos.Tables("Prod")).Position -= 1
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Me.BindingContext(DtsMProductos.Tables("Prod")).Position += 1
    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click
        Me.BindingContext(DtsMProductos.Tables("Prod")).Position =
            Me.BindingContext(DtsMProductos.Tables("Prod")).Count - 1
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim FrmNuevo As New FrmAuxiliar
        EnlazarCombos(FrmNuevo)
        FrmNuevo.Text = "Nuevo Producto"
        FrmNuevo.LblTCodigo.Visible = False
        FrmNuevo.LblCodProd.Visible = False
        If FrmNuevo.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fproducto As DataRow
        fproducto = DtsMProductos.Tables("Prod").NewRow()
        fproducto("CodProd") = ObtenerUltimoCodigo()
        CargarDatos(FrmNuevo, fproducto)
        DtsMProductos.Tables("Prod").Rows.Add(fProducto)
        DtaProductos.Update(DtsMProductos.Tables("Prod"))
        DtsMProductos.Tables("Prod").AcceptChanges()
        BtnUltimo_Click(Nothing, Nothing)

    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim FrmModif As New FrmAuxiliar
        EnlazarCombos(FrmModif)
        FrmModif.Text = "Modificar Producto"
        PasarDatos(FrmModif)
        If FrmModif.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fproducto As DataRow
        fproducto = DtsMProductos.Tables("Prod").Rows(Me.BindingContext(DtsMProductos.Tables("Prod")).Position)
        fproducto.BeginEdit()
        CargarDatos(FrmModif, fproducto)
        fproducto.EndEdit()
        DtaProductos.Update(DtsMProductos.Tables("Prod"))
        DtsMProductos.Tables("Prod").AcceptChanges()

    End Sub
    Private Sub PasarDatos(FormularioDestino As FrmAuxiliar)
        With FormularioDestino
            .LblCodProd.Text = TxtCodProd.Text
            .TxtDescri.Text = TxtDescri.Text
            .TxtExist.Text = TxtExist.Text
            .TxtStMin.Text = TxtStMin.Text
            .TxtStRep.Text = TxtStRep.Text
            .TxtPVP.Text = TxtPVP.Text
            .TxtPCM.Text = TxtPCM.Text
            .ChkPendiente.Checked = ChkPendiente.Checked
        End With

    End Sub
    Private Sub EnlazarCombos(formauxM As FrmAuxiliar)
        With formauxM
            .CmbTiposIva.DataSource = DtsMProductos.Tables("Iva")
            .CmbTiposIva.DisplayMember = "Porcentaje"
            .CmbTiposIva.ValueMember = "TipoIva"
            .CmbProveedores.DataSource = DtsMProductos.Tables("Prove")
            .CmbProveedores.DisplayMember = "Nombre"
            .CmbProveedores.ValueMember = "Codigo"
        End With

    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("Eliminar producto", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim fproducto As DataRow
        fproducto = DtsMProductos.Tables("Prod").Rows(Me.BindingContext(DtsMProductos.Tables("Prod")).Position)
        fproducto.Delete()
        DtaProductos.Update(DtsMProductos.Tables("Prod"))
        DtsMProductos.Tables("Prod").AcceptChanges()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtCodBuscar.Text = "" Then
            MsgBox("Debe teclear un código de producto", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        Dim posicion As Integer
        DtsMProductos.Tables("Prod").DefaultView.Sort = "CodProd"
        posicion = DtsMProductos.Tables("Prod").DefaultView.Find(TxtCodBuscar.Text)
        If posicion = -1 Then
            MsgBox("No hay ningún Producto con el Código " & TxtCodBuscar.Text, MsgBoxStyle.Information, "Atención")
            TxtCodBuscar.Focus()
            TxtCodBuscar.SelectAll()

            Exit Sub
        End If
        TxtCodBuscar.Text = ""
        Me.BindingContext(DtsMProductos.Tables("Prod")).Position = posicion
    End Sub



    Private Sub CargarDatos(FormularioOrigen As FrmAuxiliar, fila As DataRow)
        With FormularioOrigen

            fila("Descri") = .TxtDescri.Text
            fila("Exist") = CShort(.TxtExist.Text)
            fila("StMin") = CShort(.TxtStMin.Text)
            fila("StRep") = CShort(.TxtStRep.Text)
            fila("PVP") = CSng(.TxtPVP.Text)
            fila("PCM") = CSng(.TxtPCM.Text)
            fila("TipoIva") = .CmbTiposIva.SelectedValue
            fila("CodProv") = .CmbProveedores.SelectedValue
            fila("Pendiente") = .ChkPendiente.Checked
        End With

    End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Click

    '    Dim a = Color.CadetBlue.ToArgb


    'End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(Codprod) from Productos", CnnGestion)
        Dim ultimo As Object
        Dim ultimoCod As Short
        CnnGestion.Open()
        ultimo = cmdultimo.ExecuteScalar
        CnnGestion.Close()

        If ultimo Is DBNull.Value Then
            ultimoCod = 1
        Else
            ultimoCod = CShort(ultimo) + 1
        End If
        Return ultimoCod
    End Function

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Try
            OperadoresString = {"Igual a...", "Empieza por...", "Contiene...", "Es uno de estos...", "Distinto de"}
            OperadoresNumFec = {"=", "<", ">", "<=", ">=", "<>"}
            Dim TitulosCampos As String() = {"Código de producto", "Descripción", "Existencias", "Stock mínimo", "Stock de reposición", "PVP", "Precio compra medio", "Tipo de IVA", "Código de proveedor", "Pendiente"}

            If BtnFiltrar.Text = "Ver Todos" Then
                DtsMProductos.Tables("Prod").DefaultView.RowFilter = ""
                BtnFiltrar.Text = "..."
                PictureBox1.Visible = False
                Timer1.Stop()

                Exit Sub
            End If

            Dim frmf As New FrmFiltros
            frmf.LblValores.Visible = False

            frmf.CmbCampos.Items.AddRange(TitulosCampos)
            'Dim columna As DataColumn
            'For Each columna In DtsMProductos.Tables("Prod").Columns
            '    frmf.CmbCampos.Items.Add(columna.ColumnName)
            'Next
            frmf.CmbCampos.SelectedIndex = 0

            If frmf.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            'Dim sfiltro As String = frmf.CmbCampos.Text
            Dim sfiltro As String = DtsMProductos.Tables("Prod").Columns(frmf.CmbCampos.SelectedIndex).ColumnName
            Select Case frmf.CmbCampos.SelectedIndex
                Case 1

                    Select Case frmf.CmbOperadores.SelectedIndex

                        Case 0

                            sfiltro += " like '" & frmf.TxtValor.Text & "'"
                        Case 1

                            sfiltro += " like '" & frmf.TxtValor.Text & "%'"
                        Case 2

                            sfiltro += " like '%" & frmf.TxtValor.Text & "%'"
                        Case 3
                            sfiltro += " IN (" & frmf.TxtValor.Text & ")"
                        Case 4
                            sfiltro += "<> '" & frmf.TxtValor.Text & "'"
                    End Select
                Case 0, 2, 3, 4, 5, 6, 7, 8
                    sfiltro += frmf.CmbOperadores.Text & frmf.TxtValor.Text
                Case 9
                    If frmf.TxtValor.Text <> "N" And frmf.TxtValor.Text <> "S" Then
                        Exit Sub
                    End If
                    Dim Valor As Boolean = IIf(frmf.TxtValor.Text.ToUpper = "S", True, False)
                    sfiltro += frmf.CmbOperadores.Text & Valor
            End Select
            Me.Cursor = Cursors.WaitCursor
            DtsMProductos.Tables("Prod").DefaultView.RowFilter = sfiltro
            Me.Cursor = Cursors.Default
            PictureBox1.Visible = True
            Timer1.Start()
            BtnFiltrar.Text = "Ver Todos"
        Catch ErrorNoNumerico As InvalidCastException
            MsgBox("No se pudo filtrar, revise el valor introducido", MsgBoxStyle.Exclamation, "Atención")

        Catch ErrorFiltro As EvaluateException
            MsgBox("No se pudo filtrar, revise el valor introducido", MsgBoxStyle.Exclamation, "Atención")

        Catch ErrorGeneral As Exception
            MsgBox("Error de la aplicación, avise a mantenimiento", MsgBoxStyle.Critical, "Atención")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = Not PictureBox1.Visible

    End Sub
End Class