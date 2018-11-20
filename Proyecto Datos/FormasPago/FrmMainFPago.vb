Imports System.Data.OleDb
Public Class FrmMainFPago

    Dim dtsFPago As DataSet
    Dim dtaFPago As OleDbDataAdapter

    Private Sub FrmMainFPago_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

        dtsFPago = New DataSet

        dtaFPago = New OleDbDataAdapter("Select * from FormasPago order by CodFPago", CnnGestion)
        dtaFPago.Fill(dtsFPago, "pago")
        Dim cmbProv As New OleDbCommandBuilder(dtaFPago)

        enlazarDatos()
    End Sub

    Private Sub enlazarDatos()
        txtCodPago.DataBindings.Add("Text", dtsFPago.Tables("pago"), "CodFPago")
        txtDescri.DataBindings.Add("Text", dtsFPago.Tables("pago"), "Descrip")
        txtPlazo.DataBindings.Add("Text", dtsFPago.Tables("pago"), "Plazos")
        txtCad.DataBindings.Add("Text", dtsFPago.Tables("pago"), "Cadencia")

        DtgFPago.DataSource = dtsFPago.Tables("pago")
    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click, btsPri.Click
        Me.BindingContext(dtsFPago.Tables("pago")).Position = 0
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click, btsAnt.Click
        Me.BindingContext(dtsFPago.Tables("pago")).Position -= 1
    End Sub
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click, btsSig.Click
        Me.BindingContext(dtsFPago.Tables("pago")).Position += 1
    End Sub
    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click, btsUlt.Click
        Me.BindingContext(dtsFPago.Tables("pago")).Position = Me.BindingContext(dtsFPago.Tables("pago")).Count - 1
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click, tsNuevo.Click
        Dim frmNuevo As New FrmEdicionFPago

        frmNuevo.Text = "Nueva forma de pago"

        frmNuevo.lblFPago.Visible = False
        frmNuevo.txtCodPago.Visible = False

        If frmNuevo.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        'preparamos el nuevo prov
        Dim fpago As DataRow
        fpago = dtsFPago.Tables("pago").NewRow
        fpago("CodFPago") = ObtenerUltimoCodigo()
        cargarDatos(frmNuevo, fpago)

        'realizamos la insercion
        dtsFPago.Tables("pago").Rows.Add(fpago)
        dtaFPago.Update(dtsFPago.Tables("pago")) '¡¡¡ OJO DTAAAA!!!!
        dtsFPago.Tables("pago").AcceptChanges()
        BtnUltimo_Click(Nothing, Nothing)

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click, tsModificar.Click
        Dim FrmModif As New FrmEdicionFPago
        pasarDatos(FrmModif)

        FrmModif.txtCodPago.ReadOnly = True

        FrmModif.Text = "Modificar Tipo Iva"
        If FrmModif.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        'Obtenemos la fila correspondiente a la posicion del dataset en la tabla productos mediante el binding contest del formulario
        Dim fprover As DataRow
        fprover = dtsFPago.Tables("pago").Rows(Me.BindingContext(dtsFPago.Tables("pago")).Position)

        fprover.BeginEdit()
        cargarDatos(FrmModif, fprover)
        fprover.EndEdit()
        dtaFPago.Update(dtsFPago.Tables("pago"))
        dtsFPago.Tables("pago").AcceptChanges()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click, tsEliminar.Click
        If MsgBox("Eliminar forma de pago", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Cogemos la fila vinculada en el contexto. Explicado en BtnModificar_click.
        Dim fprover As DataRow
        fprover = dtsFPago.Tables("pago").Rows(Me.BindingContext(dtsFPago.Tables("pago")).Position)

        'eliminamos la fila
        fprover.Delete()
        dtaFPago.Update(dtsFPago.Tables("pago"))
        dtsFPago.Tables("pago").AcceptChanges()
    End Sub

    Public Sub cargarDatos(formOr As FrmEdicionFPago, fila As DataRow)
        With formOr
            fila("Descrip") = .txtDescri.Text
            fila("Plazos") = .txtPlazo.Text
            fila("Cadencia") = .txtCad.Text
        End With
    End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(CodFPago) from FormasPago", CnnGestion)
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

    Public Sub pasarDatos(frmDest As FrmEdicionFPago)
        With frmDest
            .txtCodPago.Text = txtCodPago.Text
            .txtDescri.Text = txtDescri.Text
            .txtPlazo.Text = txtPlazo.Text
            .txtCad.Text = txtCad.Text
        End With
    End Sub

    Private Sub tsSalir_Click(sender As Object, e As EventArgs) Handles tsSalir.Click
        Me.Close()
    End Sub
End Class