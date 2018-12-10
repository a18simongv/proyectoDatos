Imports System.Data.OleDb

Public Class FrmRecepPedido

    'Declaramos el dataset que vamos a utilizar
    Dim dtsRPedidos As DataSet
    'Declaramos los adaptadores para cada tabla
    Dim dtaProduto, dtaProveedores, dtaPedidosC, dtaPedidosL As OleDbDataAdapter
    'Declaramos un contador para comprobar si se seleccionaron todas las linas de pedidos -> indicaria cambiar CPedido a - R - Recibido
    Dim contadorLineasPedido As Integer = 0
    'Definimos dos variables booleanas para comprobar posteriormente si al pulsar el botón Recepcionar pedidos marcados hay alguno seleccionado, y que estos tengan precio
    Dim seleccionados, precios As Boolean

    Dim fPedC, filaLinea, FilaProducto As DataRow 'cargamos una linea vacia de cada tabla

    Private Sub FrmRecepPedido_Load(sender As Object, e As EventArgs) Handles Me.Load

        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        'CnnGestion = New OleDbConnection _
        '("provider=microsoft.jet.oledb.4.0;data source=" &
        '"c:\users\a18simongv\source\repos\a18simongv\proyectodatos\gestion comercial.mdb")

        dtsRPedidos = New DataSet

        'cargamos la tabla cabeceras de pedidos con situacion = N -> creamos el commandBuilder correspondiente porque se haran cambios en la tabla
        dtaPedidosC = New OleDbDataAdapter("Select * from CPedidosC where Situacion like 'N'", CnnGestion)
        dtaPedidosC.Fill(dtsRPedidos, "PedC")
        Dim cmbPedC As New OleDbCommandBuilder(dtaPedidosC)

        'enlazamos el dtgPedidosC con sus valores
        dtgPedidosC.DataSource = dtsRPedidos.Tables("PedC")

        'agregamos una columna al dtgPedidosC de checkbox
        Dim columnaSel As New DataGridViewCheckBoxColumn
        columnaSel.Name = "Seleccion"
        columnaSel.HeaderText = "Recibido"
        dtgPedidosC.Columns.Add(columnaSel)

        'realizamos la configuracion del grid
        ConfigurarGridPedidos()

    End Sub

    Private Sub ConfigurarGridPedidos()

        With dtgPedidosC
            .Columns(0).HeaderText = "Año"
            .Columns(1).HeaderText = "Nº Pedidos"
            .Columns(2).HeaderText = "Fecha"
            .Columns(3).HeaderText = "Proveedor"
            .Columns(4).HeaderText = "Situación"

            .Columns(2).DefaultCellStyle.Format = "dd/MM/yyyy"

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
        End With

    End Sub

    Private Sub dtgPedidosC_SelectionChanged(sender As Object, e As EventArgs) Handles dtgPedidosC.SelectionChanged

        Dim posicion As Integer

        Try

            posicion = Me.BindingContext(dtsRPedidos.Tables("PedC")).Position

            'guardamos en el datarow el ped seleccionado
            fPedC = dtsRPedidos.Tables("PedC").Rows(posicion)

            'siempre que seleccionemos un pedido ponemos la casilla de seleccion en false
            If posicion >= 0 And dtgPedidosC.Columns.Count = 6 Then
                dtgPedidosC.Rows(posicion).Cells("Seleccion").Value = False
            End If

            'cargamos las lineas correspondientes al pedido seleccionado que están en situacion = N
            dtaPedidosL = New OleDbDataAdapter("Select * from CPedidosL where Situac like 'N' and Año = " & fPedC("Año") &
                                               " and NPedido = " & fPedC("NPedido"), CnnGestion)
            If Not dtsRPedidos.Tables("PedL") Is Nothing Then
                dtsRPedidos.Tables("PedL").Rows.Clear()
            End If
            dtaPedidosL.Fill(dtsRPedidos, "PedL")
            Dim cmbPedL As New OleDbCommandBuilder(dtaPedidosL)

            'enlazamos el dtgLineas a la tabla correspondiente LineasPedido
            dtgLineas.DataSource = dtsRPedidos.Tables("PedL")
            'agregamos la columna para seleccionar -> solo si no está ya creada
            If dtgLineas.Columns.Count = 7 Then
                Dim columnaSel As New DataGridViewCheckBoxColumn
                columnaSel.Name = "Recibido"
                columnaSel.HeaderText = "Recibido"
                dtgLineas.Columns.Add(columnaSel)
            End If

            'configuramos el grid
            ConfigurarGridLineas()

            'Mostramos los datos del proveedor -> para ello cargamos el dataset los datos del proveedor y enlazamos la propiedad text de las etiquetas
            MostrarDatosProveedor()

            'Cargamos en el dataset los productos asociados a la linea de pedido
            dtaProduto = New OleDbDataAdapter("select * from Productos where CodProd in (Select CodProd from CPedidosL where Situac like 'N' and Año = " & fPedC("Año") &
                                               " and NPedido = " & fPedC("NPedido") & ")", CnnGestion)
            If Not dtsRPedidos.Tables("Prod") Is Nothing Then
                dtsRPedidos.Tables("Prod").Rows.Clear()
            End If
            dtaProduto.Fill(dtsRPedidos, "Prod")
            Dim cmbProds As New OleDbCommandBuilder(dtaProduto)

        Catch ex As IndexOutOfRangeException
        Catch ex2 As ArgumentOutOfRangeException

        End Try
    End Sub

    Private Sub ConfigurarGridLineas()
        With dtgLineas
            .Columns(0).HeaderText = "Año"
            .Columns(1).HeaderText = "Nº de Pedido"
            .Columns(2).HeaderText = "Nº de línea"
            .Columns(3).HeaderText = "Producto"
            .Columns(4).HeaderText = "Unidades"
            .Columns(5).HeaderText = "Precio"
            .Columns(6).HeaderText = "Situación"

            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(6).ReadOnly = True
        End With
    End Sub

    Private Sub MostrarDatosProveedor()
        'cargamos el proveedor correspondiente al pedido
        dtaProveedores = New OleDbDataAdapter("select * from Proveedores where Codigo = " & dtgPedidosC.CurrentRow.Cells(3).Value, CnnGestion)
        'borramos el anterior
        If Not dtsRPedidos.Tables("Prov") Is Nothing Then
            dtsRPedidos.Tables("Prov").Rows.Clear()
        End If
        dtaProveedores.Fill(dtsRPedidos, "Prov")

        'Solo enlazamos las etiquetas una vez, cuando no estan enlazadas
        If LblNif.DataBindings.Count = 0 Then

            LblNif.DataBindings.Add("Text", dtsRPedidos.Tables("Prov"), "NIF")
            lblNombre.DataBindings.Add("Text", dtsRPedidos.Tables("Prov"), "Nombre")
            lblDirec.DataBindings.Add("Text", dtsRPedidos.Tables("Prov"), "Dirección")
            lblCodPos.DataBindings.Add("Text", dtsRPedidos.Tables("Prov"), "CodPos")
            lblPob.DataBindings.Add("Text", dtsRPedidos.Tables("Prov"), "Poblac")
            lblTel.DataBindings.Add("Text", dtsRPedidos.Tables("Prov"), "Tfno")
            lblEmail.DataBindings.Add("Text", dtsRPedidos.Tables("Prov"), "email")

        End If
    End Sub

    Private Sub dtgLineas_SelectionChanged(sender As Object, e As EventArgs) Handles dtgLineas.SelectionChanged
        If dtgLineas.CurrentRow Is Nothing Then
            Exit Sub
        End If
        'Buscamos el producto cuyo código coincide con el seleccionado
        Dim posicionProd As Integer
        If Not dtsRPedidos.Tables("Prod") Is Nothing Then
            dtsRPedidos.Tables("Prod").DefaultView.Sort = "CodProd"
            posicionProd = dtsRPedidos.Tables("Prod").DefaultView.Find(dtgLineas.CurrentRow.Cells(3).Value)

            Me.BindingContext(dtsRPedidos.Tables("Prod")).Position = posicionProd
            'mostramos el produto seleccionado
            MuestraProducto()
        End If
    End Sub

    Private Sub MuestraProducto()

        If lblCodProd.DataBindings.Count = 0 Then
            lblCodProd.DataBindings.Add("Text", dtsRPedidos.Tables("Prod"), "CodProd")
            lblDescri.DataBindings.Add("Text", dtsRPedidos.Tables("Prod"), "Descri")
            lblExist.DataBindings.Add("Text", dtsRPedidos.Tables("Prod"), "Exist")
            lblStkMin.DataBindings.Add("Text", dtsRPedidos.Tables("Prod"), "StMin")
            lblStkRep.DataBindings.Add("Text", dtsRPedidos.Tables("Prod"), "StRep")
            lblPCM.DataBindings.Add("Text", dtsRPedidos.Tables("Prod"), "PCM")
        End If

    End Sub

    '  Cuando cambia el estado de la casilla de verificación en el pedido seleccionado, si se activa, se marcan todas las lineas
    'del pedido y si se desactiva se desmarcan. Esto requiere 2 eventos (CurrentCellDirtyStateChange y CellValueChange) -> el primero
    'se necesita para que en el segundo tenga el valor real (modificado)
    Private Sub dtgPedidosC_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dtgPedidosC.CurrentCellDirtyStateChanged
        If dtgPedidosC.IsCurrentCellDirty Then
            dtgPedidosC.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dtgPedidosC_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPedidosC.CellValueChanged

        If Not dtgPedidosC.CurrentRow Is Nothing Then
            If dtgPedidosC.CurrentRow.Cells(5).Value = False Then
                DesmarcarLineas()
            Else
                MarcarLineas()
            End If
        End If
    End Sub

    Private Sub MarcarLineas()
        'se recorre el dtg y se desmarcan todas las casillas
        Dim fila As DataGridViewRow
        For Each fila In dtgLineas.Rows
            fila.Cells(7).Value = True
        Next
    End Sub
    Private Sub DesmarcarLineas()
        'se recorre el dtg y se desmarcan todas las casillas
        Dim fila As DataGridViewRow
        For Each fila In dtgLineas.Rows
            fila.Cells(7).Value = False
        Next
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        contadorLineasPedido = 0
        'cuando pulsamos el boton registrar pedidos marcados -> actualizamos las lineas de pedidos marcadas y los productos correspondientes
        ActualizarLineasPedido()

        'si estaban todas las lineas marcadas en el datagrid de lineas se cambia la situacion de la cabecera
        If contadorLineasPedido = dtgLineas.Rows.Count Then
            ActualizarPedido()
        End If

        'se actualizan los datos en la base de datos
        dtaPedidosC.Update(dtsRPedidos.Tables("PedC"))
        dtaPedidosL.Update(dtsRPedidos.Tables("PedL"))
        dtaProduto.Update(dtsRPedidos.Tables("Prod"))

        'se aceptan los cambios en el dataset
        dtsRPedidos.Tables("PedC").AcceptChanges()
        dtsRPedidos.Tables("PedL").AcceptChanges()
        dtsRPedidos.Tables("Prod").AcceptChanges()

        'se limpia el dataset
        dtsRPedidos.Tables("PedC").Rows.Clear()
        dtsRPedidos.Tables("PedL").Rows.Clear()
        dtsRPedidos.Tables("Prod").Rows.Clear()

        'se vuelve a hcer el fill de las cabeceras para que no aparezcan los recibidos
        dtaPedidosC.Fill(dtsRPedidos, "PedC")

    End Sub

    Private Sub ActualizarLineasPedido()
        'hacemos un primer recorrido del grid de lineas para comprobar que hay lineas seleccionadas y tiene el precio introducido
        precios = True
        seleccionados = False

        For i As Integer = 0 To dtsRPedidos.Tables("PedL").Rows.Count - 1
            If dtgLineas.Rows(i).Cells(7).Value = True Then
                seleccionados = True
                filaLinea = dtsRPedidos.Tables("PedL").Rows(i)
                If filaLinea("Precio") = 0 Then
                    precios = False
                End If
            End If
        Next

        'si no han sido introducidos los precios en las lineas seleccionadas
        If Not precios Then
            MsgBox("Debe introducir los precios de los productos seleccionados", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        'si no hay ninguna linea de pedidos seleccionada
        If Not seleccionados Then
            MsgBox("No ha seleccionado ningún producto del pedido", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        Dim posicion As Integer = 0
        Dim codigo As Integer
        For i As Integer = 0 To dtsRPedidos.Tables("PedL").Rows.Count - 1

            If dtgLineas.Rows(i).Cells(7).Value = True Then
                'Actualiza la linea de pedido
                filaLinea = dtsRPedidos.Tables("PedL").Rows(i)
                filaLinea.BeginEdit()
                codigo = filaLinea("CodProd")
                filaLinea("Situac") = "R"
                filaLinea.EndEdit()
                contadorLineasPedido += 1
                'actualiza el producto correspondiente hay que buscar el código en la tabla "Prod" del dataset
                dtsRPedidos.Tables("Prod").DefaultView.Sort = "CodProd"
                posicion = dtsRPedidos.Tables("Prod").DefaultView.Find(codigo)
                FilaProducto = dtsRPedidos.Tables("Prod").Rows(posicion)
                'y se actualiza el campo pendiente(false), el pcm y las exist
                FilaProducto.BeginEdit()
                FilaProducto("Pendiente") = False

                'variables intermedias para pcm
                Dim vPcm, vPrecio As Single
                Dim vExist, vUnid As Integer
                vPcm = FilaProducto("PCM")
                vPrecio = filaLinea("Precio")
                vExist = FilaProducto("Exist")
                vUnid = filaLinea("Unidades")
                'MUY IMPORTANTE -> hay que actualizar antes el PCM que las existencias que si no cambia la formula
                FilaProducto("PCM") = ((vPcm + vExist) + (vUnid + vPrecio)) / (vExist + vUnid)
                FilaProducto("Exist") += filaLinea("Unidades")
                FilaProducto.EndEdit()

            End If

        Next
    End Sub

    Private Sub ActualizarPedido()
        fPedC.BeginEdit()
        fPedC("Situacion") = "R"
        fPedC.EndEdit()
    End Sub

    'comprobamos que en el TextBox de precio solo se introduzcan numeros
    Private Sub dtgLineas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dtgLineas.EditingControlShowing
        'referencia a la celda
        Dim validar As TextBox = CType(e.Control, TextBox)
        AddHandler validar.KeyPress, AddressOf numDecimal
    End Sub

End Class