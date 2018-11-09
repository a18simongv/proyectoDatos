Imports System.Data.OleDb
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CnnGestion = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\gaiasb\profes$\porto\VB NET\Bases datos ejemplo\Gestion comercial.mdb")
    End Sub

    Private Sub BtnCalcNProd_Click(sender As Object, e As EventArgs) Handles BtnCalcNProd.Click
        Dim Nproductos As Object
        Dim NumProductos As Integer
        Dim CmdContar As New OleDbCommand("Select count(*) from Productos", CnnGestion)
        CnnGestion.Open()
        Nproductos = CmdContar.ExecuteScalar
        CnnGestion.Close()
        If Nproductos Is DBNull.Value Then
            NumProductos = 0
        Else
            NumProductos = CInt(Nproductos)
        End If
        LblNProd.Text = NumProductos.ToString

    End Sub

    Private Sub ButnValorar_Click(sender As Object, e As EventArgs) Handles ButnValorar.Click
        Dim VTotal As Object
        Dim ValorTotal As Double
        Dim CmdValorar As New OleDbCommand("Select SUM(exist*PCM) from Productos", CnnGestion)
        CnnGestion.Open()
        VTotal = CmdValorar.ExecuteScalar
        CnnGestion.Close()
        If VTotal Is DBNull.Value Then
            ValorTotal = 0
        Else
            ValorTotal = CDbl(VTotal)
        End If
        LblValor.Text = Format(ValorTotal, "###,##0.00 €")
    End Sub

    Private Sub BtnComenzar_Click(sender As Object, e As EventArgs) Handles BtnComenzar.Click
        Dim cmdSubir As New OleDbCommand("Update Productos SET PVP = PVP + (PVP * " & TxtSubida.Text & " /100) where Codprov = " &
            LstProveedores.SelectedItem, CnnGestion)
        Dim NProductosProve As Integer
        CnnGestion.Open()
        NProductosProve = cmdSubir.ExecuteNonQuery
        CnnGestion.Close()
        MsgBox("Se ha cambiado el PVP a " & NProductosProve & " Productos")
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        Dim Drproductos As OleDbDataReader
        Dim CmdProductos As New OleDbCommand("Select * from Productos", CnnGestion)
        CnnGestion.Open()
        Drproductos = CmdProductos.ExecuteReader

        Do While Drproductos.Read
            CmbProductos.Items.Add(Drproductos("Descri"))
        Loop
        CnnGestion.Close()
        CmbProductos.SelectedIndex = 0
    End Sub
End Class
