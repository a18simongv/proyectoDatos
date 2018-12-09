Imports System.Data.OleDb
Public Class FormGestionPedidos

    Dim DtsGPedidos As DataSet
    Dim DtaProductos, DtaPedidosC, DtaPedidosL, DtAPedGen As OleDbDataAdapter
    Dim UltimaC, UltimaL, PrimeraC As Integer

    Private Sub FrmGPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

        DtaProductos = New OleDbDataAdapter("Select * from Productos where Exist < StMin and Pendiente = False Order By CodProv,CodProd", CnnGestion)

        DtsGPedidos = New DataSet
        DtaProductos.Fill(DtsGPedidos, "Prod")
        Dim cmbProductos As New OleDbCommandBuilder(DtaProductos)

        DtaPedidosC = New OleDbDataAdapter("Select * from CPedidosC where 0 = 1", CnnGestion)
        DtaPedidosC.Fill(DtsGPedidos, "PedC")
        Dim cmbPedidosC As New OleDbCommandBuilder(DtaPedidosC)

        DtaPedidosL = New OleDbDataAdapter("Select * from CPedidosL where 0 = 1", CnnGestion)
        DtaPedidosL.Fill(DtsGPedidos, "PedL")
        Dim cmbPedidosL As New OleDbCommandBuilder(DtaPedidosL)

        dtgProductos.DataSource = DtsGPedidos.Tables("Prod")

        Dim columnaSel As New DataGridViewCheckBoxColumn 'crea una columna de datagrid de tipo check box
        columnaSel.Name = "Seleccion"
        columnaSel.HeaderText = "Seleccionar"
        dtgProductos.Columns.Add(columnaSel)
        ConfigurarGrid()

    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles btnRealizar.Click

        If DtsGPedidos.Tables("Prod").DefaultView.Count = 0 Then
            MsgBox("No se necesita hacer ningún pedido", MsgBoxStyle.Information, "Generar pedidos")
            Exit Sub
        End If
        UltimaC = UltimoNumeroPedido() 'numero id del nuevo pedido
        PrimeraC = UltimaC
        UltimaL = 1
        Dim NProdSeleccionados As Integer = 0
        Dim f As New DataGridViewRow 'crea una fila del dtg para recorrer el foreach
        Dim vProve As Integer = -1
        Dim posicion As Integer
        Me.Cursor = Cursors.WaitCursor
        For Each f In dtgProductos.Rows 'foreach que recorre todo el dtg y comprueba si la linea esta seleccionada
            If f.Cells(10).Value = True Then
                NProdSeleccionados += 1 'suma uno al contador de produtos seleccionados
                posicion = f.Cells(10).RowIndex 'coge la posicion de la fila
                If DtsGPedidos.Tables("Prod").Rows(posicion)("CodProv") <> vProve Then 'mira que no exista ya el pedido
                    GuardarCabeceraPedido(posicion) 'inserta el pedido
                    vProve = DtsGPedidos.Tables("Prod").Rows(posicion)("CodProv")
                End If
                GuardarLineaPedido(posicion) 'inserta las lineas de pedido acorde a la cabecera
            End If
        Next
        If NProdSeleccionados = 0 Then
            MsgBox("No hay productos seleccionados para hacer pedido", MsgBoxStyle.Information, "Generar pedidos")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        'aplica los cambios en las db
        DtaPedidosC.Update(DtsGPedidos.Tables("PedC"))
        DtsGPedidos.Tables("PedC").AcceptChanges()
        DtaPedidosL.Update(DtsGPedidos.Tables("PedL"))
        DtsGPedidos.Tables("Pedl").AcceptChanges()
        DtaProductos.Update(DtsGPedidos.Tables("Prod"))
        DtsGPedidos.Tables("Prod").AcceptChanges()


        Me.Cursor = Cursors.Default
        MsgBox("Se han generado los pedidos de los productos seleccionados", MsgBoxStyle.Information, "Generación")
        DtsGPedidos.Tables("Prod").Rows.Clear() 'limpia el dts
        DtaProductos.Fill(DtsGPedidos, "Prod") 'vuelve a cargar el dts produtos
        MostrarPedidos() 'Vuelve a cargar los datos en los dtg

    End Sub
    Private Sub GuardarCabeceraPedido(Pos As Integer)
        Dim fCPedido As DataRow
        fCPedido = DtsGPedidos.Tables("PedC").NewRow
        fCPedido("Año") = Year(Today)
        fCPedido("NPedido") = UltimaC
        fCPedido("Fecha") = Today
        fCPedido("CodProv") = DtsGPedidos.Tables("Prod").Rows(Pos)("CodProv")
        fCPedido("Situacion") = "N"
        DtsGPedidos.Tables("PedC").Rows.Add(fCPedido)
        UltimaC += 1
        UltimaL = 1
    End Sub
    Private Sub GuardarLineaPedido(Pos As Integer)
        Dim fLPedido As DataRow
        fLPedido = DtsGPedidos.Tables("PedL").NewRow
        fLPedido("Año") = Year(Today)
        fLPedido("NPedido") = UltimaC - 1
        fLPedido("Nlinea") = UltimaL
        fLPedido("CodProd") = DtsGPedidos.Tables("Prod").Rows(Pos)("CodProd")
        fLPedido("Unidades") = DtsGPedidos.Tables("Prod").Rows(Pos)("StRep") - DtsGPedidos.Tables("Prod").Rows(Pos)("Exist")
        fLPedido("Precio") = 0
        fLPedido("Situac") = "N"
        DtsGPedidos.Tables("PedL").Rows.Add(fLPedido)
        UltimaL += 1
        Actualizarproducto(Pos)
    End Sub
    Private Sub Actualizarproducto(Pos As Integer)
        Dim fProducto As DataRow
        fProducto = DtsGPedidos.Tables("Prod").Rows(Pos)
        fProducto.BeginEdit()
        fProducto("Pendiente") = True
        fProducto.EndEdit()
    End Sub
    Private Function UltimoNumeroPedido() As Integer
        Dim ultimoCPed As Object

        Dim cmdUltimo As New OleDbCommand("Select max(NPedido) from CPedidosC where Año = " & Year(Today), CnnGestion)
        CnnGestion.Open()
        ultimoCPed = cmdUltimo.ExecuteScalar
        CnnGestion.Close()
        If ultimoCPed Is DBNull.Value Then
            UltimoNumeroPedido = CInt("1")
        Else
            UltimoNumeroPedido = CType(ultimoCPed, Integer) + 1

        End If
    End Function

    Private Sub ConfigurarGrid()
        With dtgProductos
            .Columns(8).Width = 60
            .Columns(9).Width = 60

            .Columns(0).HeaderText = "Producto"
            .Columns(1).HeaderText = "Descripción"
            .Columns(2).HeaderText = "Existencias"
            .Columns(3).HeaderText = "Stock min."
            .Columns(4).HeaderText = "Stock rep."
            .Columns(5).HeaderText = "P.V.P."
            .Columns(6).HeaderText = "P.C.M."
            .Columns(7).HeaderText = "Tipo de IVA"
            .Columns(8).HeaderText = "Proveedor"
            .Columns(9).HeaderText = "Pendiente"

            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.LightGreen
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(5).DefaultCellStyle.Format = "##,###,##0.00"
            .Columns(6).DefaultCellStyle.Format = "##,###,##0.00"

            For i As Integer = 0 To 9 'deja solo la ultima columna como readOnly false para poder trabajar con seleccionar
                .Columns(i).ReadOnly = True
            Next
            .Columns(0).Width = 58
            .Columns(1).Width = 180
            .Columns(2).Width = 70
            .Columns(3).Width = 90
            .Columns(4).Width = 90
            .Columns(5).Width = 80
            .Columns(6).Width = 80
            .Columns(7).Width = 100
            .Columns(8).Width = 95
            .Columns(9).Width = 95
            .Columns(10).Width = 80
        End With
    End Sub
    Private Sub ChkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodos.CheckedChanged
        If ChkTodos.Checked = True Then
            Dim a As DataGridViewRow
            For Each a In dtgProductos.Rows
                a.Cells("Seleccion").Value = True
                a.DefaultCellStyle.BackColor = Color.LightGreen
            Next
            ChkTodos.Text = "Ninguno"
        Else
            Dim a As DataGridViewRow
            For Each a In dtgProductos.Rows
                a.Cells("Seleccion").Value = False
                a.DefaultCellStyle.BackColor = Color.White
            Next
            ChkTodos.Text = "Todos"
        End If
    End Sub
    Private Sub MostrarPedidos()
        'pilla todos los pedidos respecto a una cabecera
        DtAPedGen = New OleDbDataAdapter("Select a.Año, a.NPedido, b.Nlinea, a.Fecha, b.CodProd, c.Descri, a.CodProv, d.Nombre, b.Unidades " &
                                         "From CPedidosC As a,  CPedidosL As b, Productos As c, Proveedores as d where " &
            "a.Año = b.Año and a.NPedido = b.NPedido and b.CodProd = c.CodProd and a.CodProv = d.Codigo " &
            "and a.año = " & Year(Today) & " and a.NPedido >= " & PrimeraC & " Order By a.NPedido,b.NLinea", CnnGestion)
        DtAPedGen.Fill(DtsGPedidos, "PedGen")
        dtgPedidos.DataSource = DtsGPedidos.Tables("PedGen")
        ConfigurarGridPedidos()
        'LblPedidos.Visible = True
        dtgPedidos.Visible = True
    End Sub
    Private Sub ConfigurarGridPedidos()
        With DtgPedidos
            .Columns(0).HeaderText = "Año"
            .Columns(1).HeaderText = "Nº de Pedido"
            .Columns(2).HeaderText = "Nº de línea"
            .Columns(3).HeaderText = "Fecha"
            .Columns(4).HeaderText = "Producto"
            .Columns(5).HeaderText = "Descripción"
            .Columns(6).HeaderText = "Proveedor"
            .Columns(7).HeaderText = "Nombre"
            .Columns(8).HeaderText = "Unidades"

            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns(5).DefaultCellStyle.BackColor = Color.LightGreen
            .Columns(8).DefaultCellStyle.BackColor = Color.LightGreen

            .Columns(5).DefaultCellStyle.Format = "dd/MM/yyyy"

        End With
    End Sub



    Private Sub DtgProductos_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgProductos.CurrentCellDirtyStateChanged
        If dtgProductos.IsCurrentCellDirty Then
            dtgProductos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


    Private Sub DtgProductos_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgProductos.CellValueChanged
        If Not dtgProductos.CurrentRow Is Nothing Then
            If dtgProductos.CurrentRow.Cells(10).Value = False Then
                dtgProductos.CurrentRow.DefaultCellStyle.BackColor = Color.White
            Else
                dtgProductos.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        End If
    End Sub

End Class