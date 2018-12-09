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
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

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
            If Not dtsRPedidos.Tables("Prods") Is Nothing Then
                dtsRPedidos.Tables("Prods").Rows.Clear()
            End If
            dtaProduto.Fill(dtsRPedidos, "Prods")
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

End Class