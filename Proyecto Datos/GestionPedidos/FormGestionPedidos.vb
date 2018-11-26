Imports System.Data.OleDb
Public Class FormGestionPedidos

    Dim dtsPedidos As DataSet
    Dim dtaProd, dtaPedC, dtaPedL As OleDbDataAdapter

    Private Sub FormGestionPedidos_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

        dtsPedidos = New DataSet

        dtaProd = New OleDbDataAdapter("select * from Productos where Exist < StMin and Pendiente = false order by CodProv, CodProd", CnnGestion)
        dtaProd.Fill(dtsPedidos, "Prod")
        Dim cmbProd As New OleDbCommandBuilder(dtaProd)

        dtaPedC = New OleDbDataAdapter("select *from CPedidosC where 0=1", CnnGestion)
        dtaPedC.Fill(dtsPedidos, "PedC")
        Dim cmbPedC As New OleDbCommandBuilder(dtaPedC)

        dtaPedL = New OleDbDataAdapter("select * from CPedidosL where 0=1", CnnGestion)
        dtaPedL.Fill(dtsPedidos, "PedL")
        Dim cmbPedL As New OleDbCommandBuilder(dtaPedL)


    End Sub
End Class