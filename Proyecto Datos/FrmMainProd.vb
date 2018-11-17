Imports System.Data.OleDb
Public Class FrmMainProd

    Dim DtsMProductos As DataSet 'El conjunto de dataadapters de las tablas y sus relaciones. DaTaSetManagerPRODUCTOS?
    Dim DtaProductos, DtaTiposIva, DtaProveedores As OleDbDataAdapter
    Public Operadores_Strings, Operadores_Numbers As String()

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load 'Captura el evento de carga del formulario

        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

        DtsMProductos = New DataSet 'Instanciamos el datasetManager que contendra la gestion de las tablas necesarias

        DtaProductos = New OleDbDataAdapter("Select * from Productos order by CodProd", CnnGestion) 'DataAdapter de productos
        DtaProductos.Fill(DtsMProductos, "Prod") 'Metemos en el dataset el dataAdapter con la referencia Prod
        Dim cmbProductos As New OleDbCommandBuilder(DtaProductos) '???

        DtaTiposIva = New OleDbDataAdapter("Select * from TiposIva order by Porcentaje", CnnGestion) 'DataAdapter de TiposIva
        DtaTiposIva.Fill(DtsMProductos, "Iva") 'Metemos en el dataset el dataAdapter con la referencia Iva

        DtaProveedores = New OleDbDataAdapter("Select * from Proveedores order by Nombre", CnnGestion) 'DataAdapter de Proveedores
        DtaProveedores.Fill(DtsMProductos, "Prove") 'Metemos en el dataset el dataAdapter con la referencia Prove

        'En este momento tenemos un DataSet con tres dataadapters referenciados por sus alias y con relaciones implícitas sobre ellos.
        'Ahora tendremos que gestionar este dataset generando vistas o similares para obtener los datos que nos interesen.
        EnlazarControles()

    End Sub
    Private Sub EnlazarControles()
        'Este procedimiento enlaza los componenetes de la interfaz gráfica con una celda del dataset.
        'El primer argumento del add es la propiedad del elemento a enlazar. El segundo el el datasource del dataset y el tercero el nombre del campo.
        'En este caso solo usamos la tabla de productos porque no necesitamos hacer referencias... pero... ¿y si queremos?
        'El binding provee la funcionalidad de enlazar el valor del campo de un sitio (el dataset p.e.) con el valor de la propiedad de un control.
        'TODO o si?
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
        'Vinculamos el datasource de la vista dtgProductos de tipo DataGridView con la tabla Prod del dataset
        DtgProductos.DataSource = DtsMProductos.Tables("Prod")
        ConfigurationGrid()
    End Sub

    Private Sub ConfigurationGrid()
        'Cambiamos el texto del titulo de la columna por un string.
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
        'El BindingContext es una propiedad del form que vincula ¿el formulario? con la posicion del dataset.
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
        Dim FrmNuevo As New FrmEdicionProd 'Creamos una instancia del formulario quequeremos lanzar
        EnlazarCombos(FrmNuevo) 'Pasamos la referencia para trabajar con los campos del nuevo formulario que lanzaremos
        FrmNuevo.Text = "Nuevo Producto" 'Propiedad del titulo
        FrmNuevo.LblTCodigo.Visible = False 'No queremos ver este campo del formulario que vamos a lanzar
        FrmNuevo.LblCodProd.Visible = False 'No queremos ver este campo del formulario que vamos a lanzar
        If FrmNuevo.ShowDialog = DialogResult.Cancel Then 'Visualizamos el formulario y se para aqui el procedimiento. Si se pulsa cancel, se sale del mismo y no se sigue ejecutando.
            Exit Sub
        End If
        Dim fproducto As DataRow 'Creamos una instancia de fila
        fproducto = DtsMProductos.Tables("Prod").NewRow() 'Creamos una nueva fila en el adapter de la tabla productos
        fproducto("CodProd") = ObtenerUltimoCodigo()
        CargarDatos(FrmNuevo, fproducto) 'Pasamos por referencia los objetos para obtener los introducido en la ventana desplegada
        DtsMProductos.Tables("Prod").Rows.Add(fproducto) 'Añadimos a la tabla la fila
        DtaProductos.Update(DtsMProductos.Tables("Prod")) 'Ejecutamos la insercion de la tabla.
        DtsMProductos.Tables("Prod").AcceptChanges() 'Aceptamos los cambios del dataset.
        BtnUltimo_Click(Nothing, Nothing) 'Nos colocamos en el ultimo registro (el recién insertado).
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim FrmModif As New FrmEdicionProd
        EnlazarCombos(FrmModif)
        FrmModif.Text = "Modificar Producto"
        PasarDatos(FrmModif) 'Pasamos los valores de los componeentes de esta ventana a los componenetes de la que vamos a abrir (frmModif)
        If FrmModif.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        'Obtenemos la fila correspondiente a la posicion del dataset en la tabla productos mediante el binding contest del formulario
        Dim fproducto As DataRow
        fproducto = DtsMProductos.Tables("Prod").Rows(Me.BindingContext(DtsMProductos.Tables("Prod")).Position)

        fproducto.BeginEdit() 'Iniciamos la edicion mediante algo similar a una transaccion i guess
        CargarDatos(FrmModif, fproducto) 'Pasamos por referencia los objetos, con lo que fproducto cambia de valores
        fproducto.EndEdit()
        DtaProductos.Update(DtsMProductos.Tables("Prod"))
        DtsMProductos.Tables("Prod").AcceptChanges()
    End Sub

    Private Sub EnlazarCombos(formauxM As FrmEdicionProd)
        With formauxM
            .CmbTiposIva.DataSource = DtsMProductos.Tables("Iva") 'Vinculamos el combo a un datasource - la tabla iva del dataset
            .CmbTiposIva.DisplayMember = "Porcentaje"
            .CmbTiposIva.ValueMember = "TipoIva"
            .CmbProveedores.DataSource = DtsMProductos.Tables("Prove") 'Vinculamos el otro combo a un datasource - la tabla prove del dataset
            .CmbProveedores.DisplayMember = "Nombre" 'Lo que vemos
            .CmbProveedores.ValueMember = "Codigo" 'El código real
        End With
    End Sub

    Private Sub CargarDatos(FormularioOrigen As FrmEdicionProd, fila As DataRow)
        'Devolvemos los datos del formulario lanzado.
        'Como se pasan los argumentos por referencia, el parametro fila-fpProducto cambia de valores en este método.
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

    Private Sub PasarDatos(FormularioDestino As FrmEdicionProd)
        With FormularioDestino
            .LblCodProd.Text = TxtCodProd.Text
            .TxtDescri.Text = TxtDescri.Text
            .TxtExist.Text = TxtExist.Text
            .TxtStMin.Text = TxtStMin.Text
            .TxtStRep.Text = TxtStRep.Text
            .TxtPVP.Text = TxtPVP.Text
            .TxtPCM.Text = TxtPCM.Text
            .ChkPendiente.Checked = ChkPendiente.Checked

            MostrarVlrCombo(DtsMProductos.Tables("Iva"), "TipoIva", .CmbTiposIva, TxtTipoIva.Text)
            MostrarVlrCombo(DtsMProductos.Tables("Prove"), "Codigo", .CmbProveedores, TxtCodProv.Text)
        End With

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'Creamos una alerta de seguridad con un MsgBox
        If MsgBox("Eliminar producto", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Cogemos la fila vinculada en el contexto. Explicado en BtnModificar_click.
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
        'Necesario ordenar por campo antes de buscar el registro con ese campo
        DtsMProductos.Tables("Prod").DefaultView.Sort = "CodProd"
        posicion = DtsMProductos.Tables("Prod").DefaultView.Find(TxtCodBuscar.Text)
        If posicion = -1 Then
            MsgBox("No hay ningún Producto con el Código " & TxtCodBuscar.Text, MsgBoxStyle.Information, "Atención")
            TxtCodBuscar.Focus()
            TxtCodBuscar.SelectAll()
            Exit Sub
        End If
        TxtCodBuscar.Text = ""
        Me.BindingContext(DtsMProductos.Tables("Prod")).Position = posicion 'Colocamos el dataset del contexto en la posicion del dataset
    End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(Codprod) from Productos", CnnGestion)
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

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        'Veo el texto del botón y ejecuto una acción o no en consecuencia.
        If BtnFiltrar.Text = "Ver Todos" Then
            DtsMProductos.Tables("Prod").DefaultView.RowFilter = "" 'Sin filtros. Recoge todas las filas.
            BtnFiltrar.Text = "..."
            Exit Sub
        End If

        Dim frmf As New FrmFilterProd 'Instancio el formulario
        If frmf.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        Dim queryFiltro As String = frmf.createFilterQuery(DtsMProductos)
        Me.Cursor = Cursors.WaitCursor 'Cambiamos el estilo del cursor a la ruedita.
        DtsMProductos.Tables("Prod").DefaultView.RowFilter = queryFiltro 'Defaultview.Find vs DefaultView.RowFilter
        Me.Cursor = Cursors.Default 'Cambiamos de la ruedita al cursor normal
        BtnFiltrar.Text = "Ver Todos" 'Cambiamos el texto del botón
    End Sub

End Class