Imports System.Data.OleDb
Public Class FrmMainTIva

    Dim dtsIva As DataSet
    Dim dtaTpIv As OleDbDataAdapter

    Private Sub FrmMainTIva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CnnGestion = New OleDbConnection _
        '("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        '"C:\Users\simon\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb") 'Inicializamos la conexión estática del módulo
        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\a18simongv\source\repos\a18simongv\proyectoDatos\Gestion comercial.mdb")

        dtsIva = New DataSet

        dtaTpIv = New OleDbDataAdapter("Select * from TiposIva order by TipoIva", CnnGestion)
        dtaTpIv.Fill(dtsIva, "iva")
        Dim cmbProv As New OleDbCommandBuilder(dtaTpIv)

        enlazarDatos()
    End Sub

    Private Sub enlazarDatos()
        txtTpIva.DataBindings.Add("Text", dtsIva.Tables("iva"), "TipoIva")
        TxtPorcen.DataBindings.Add("Text", dtsIva.Tables("iva"), "Porcentaje")

        DtgTIva.DataSource = dtsIva.Tables("iva")
    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click, btsPri.Click
        Me.BindingContext(dtsIva.Tables("iva")).Position = 0
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click, btsAnt.Click
        Me.BindingContext(dtsIva.Tables("iva")).Position -= 1
    End Sub
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click, btsSig.Click
        Me.BindingContext(dtsIva.Tables("iva")).Position += 1
    End Sub
    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click, btsUlt.Click
        Me.BindingContext(dtsIva.Tables("iva")).Position = Me.BindingContext(dtsIva.Tables("iva")).Count - 1
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click, tsNuevo.Click
        Dim frmNuevo As New FrmEdicionTIva

        frmNuevo.Text = "Nuevo tipo iva"

        frmNuevo.lblTipIv.Visible = False
        frmNuevo.txtTpIva.Visible = False

        If frmNuevo.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        'preparamos el nuevo prov
        Dim ftip As DataRow
        ftip = dtsIva.Tables("iva").NewRow
        ftip("TipoIva") = ObtenerUltimoCodigo()
        cargarDatos(frmNuevo, ftip)

        'realizamos la insercion
        dtsIva.Tables("iva").Rows.Add(ftip)
        dtaTpIv.Update(dtsIva.Tables("iva")) '¡¡¡ OJO DTAAAA!!!!
        dtsIva.Tables("iva").AcceptChanges()
        BtnUltimo_Click(Nothing, Nothing)

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click, tsModificar.Click
        Dim FrmModif As New FrmEdicionTIva
        pasarDatos(FrmModif)

        FrmModif.txtTpIva.ReadOnly = True

        FrmModif.Text = "Modificar Tipo Iva"
        If FrmModif.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        'Obtenemos la fila correspondiente a la posicion del dataset en la tabla productos mediante el binding contest del formulario
        Dim fprover As DataRow
        fprover = dtsIva.Tables("iva").Rows(Me.BindingContext(dtsIva.Tables("iva")).Position)

        fprover.BeginEdit()
        cargarDatos(FrmModif, fprover)
        fprover.EndEdit()
        dtaTpIv.Update(dtsIva.Tables("iva"))
        dtsIva.Tables("iva").AcceptChanges()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click, tsEliminar.Click
        If MsgBox("Eliminar Tipo Iva", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Cogemos la fila vinculada en el contexto. Explicado en BtnModificar_click.
        Dim fprover As DataRow
        fprover = dtsIva.Tables("iva").Rows(Me.BindingContext(dtsIva.Tables("iva")).Position)

        'eliminamos la fila
        fprover.Delete()
        dtaTpIv.Update(dtsIva.Tables("iva"))
        dtsIva.Tables("iva").AcceptChanges()
    End Sub

    Public Sub cargarDatos(formOr As FrmEdicionTIva, fila As DataRow)
        With formOr
            fila("Porcentaje") = .TxtPorcen.Text
        End With
    End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(TipoIva) from TiposIva", CnnGestion)
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

    Public Sub pasarDatos(frmDest As FrmEdicionTIva)
        With frmDest
            .txtTpIva.Text = txtTpIva.Text
            .TxtPorcen.Text = TxtPorcen.Text
        End With
    End Sub

    Private Sub tsSalir_Click(sender As Object, e As EventArgs) Handles tsSalir.Click
        Me.Close()
    End Sub
End Class