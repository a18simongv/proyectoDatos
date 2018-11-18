Public Class FrmFilterProv
    Implements IFilterForm

    Dim Operadores_Strings As String() = {"Igual a...", "Empieza por...", "Contiene...", "Es uno de estos...", "Distinto de"} 'Para mostrar en el combo
    Dim Operadores_Numbers As String() = {"=", "<", ">", "<=", ">=", "<>"} 'Para crear el 
    Dim TitulosCampos As String() = {"Codigo", "NIF", "Nombre", "Dirección", "DosPos", "Poblac", "Provin", "Tfno", "Fax", "email", "FecAlta", "CodBan", "CosSuc", "CodFPago"}

    Private Sub FrmFiltros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Seteamos los componenetes por defecto del formulario
        CmbCampos.Items.AddRange(TitulosCampos) 'Añado el arrayList como valores. Comentado abajo está el codigo para obtener los nombres de las columnas
        CmbCampos.SelectedIndex = 0
        CmbOperadores.Items.AddRange(Operadores_Numbers)
        CmbOperadores.SelectedIndex = 0
        TxtValor.Visible = True
        LblValores.Visible = False
        dtpBuscar.Visible = False
    End Sub

    Private Sub CmbCampos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbCampos.SelectionChangeCommitted
        CmbOperadores.Items.Clear()
        LblSiNo.Hide()
        Select Case CmbCampos.SelectedIndex
            Case 1, 2, 3, 7, 8, 9
                CmbOperadores.Items.AddRange(Operadores_Strings)
            Case 0, 4, 5, 6, 11, 12, 13
                CmbOperadores.Items.AddRange(Operadores_Numbers)
            Case 9
                LblSiNo.Show()
                CmbOperadores.Items.Add("=")
            Case 10
                CmbOperadores.Items.AddRange(Operadores_Numbers)
                dtpBuscar.Visible = True
                TxtValor.Visible = False
        End Select
        CmbOperadores.SelectedIndex = 0
    End Sub

    Private Sub CmbOperadores_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbOperadores.SelectionChangeCommitted
        If CmbOperadores.SelectedItem = "Es uno de estos..." Then
            LblValores.Visible = True
        Else
            LblValores.Visible = False
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtValor.Text = "" And TxtValor.Visible = True Then
            MsgBox("No ha escrito ningún valor", MsgBoxStyle.Exclamation, "Atención")
            TxtValor.Focus()
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public Function CreateFilterQuery(DtsManager As DataSet) As String Implements IFilterForm.CreateFilterQuery
        Dim queryFiltro As String = ""
        Try
            queryFiltro = DtsManager.Tables("Prov").Columns(CmbCampos.SelectedIndex).ColumnName 'Obtenemos el nombre de la columna
            Select Case CmbCampos.SelectedIndex
                Case 1, 2, 3, 7, 8, 9 'Para texto
                    Select Case CmbOperadores.SelectedIndex 'traduce el nombre al operador SQL
                        Case 0
                            queryFiltro += " like '" & TxtValor.Text & "'"
                        Case 1
                            queryFiltro += " like '" & TxtValor.Text & "%'"
                        Case 2
                            queryFiltro += " like '%" & TxtValor.Text & "%'"
                        Case 3
                            queryFiltro += " IN (" & TxtValor.Text & ")"
                        Case 4
                            queryFiltro += "<> '" & TxtValor.Text & "'"
                    End Select
                Case 0, 4, 5, 6, 11, 12, 13 'Para numeros
                    queryFiltro += CmbOperadores.Text & TxtValor.Text
                Case 9 'Para booleanos
                    If TxtValor.Text <> "N" And TxtValor.Text <> "S" Then
                        Throw New EvaluateException
                    End If
                    Dim Valor As Boolean = If(TxtValor.Text.ToUpper = "S", True, False) 'If ternario
                    queryFiltro += CmbOperadores.Text & Valor
                Case 10 'para fechas
                    queryFiltro += CmbOperadores.Text & "'" & Format(dtpBuscar.Value, "Short Date") & "'"
            End Select
        Catch ErrorNoNumerico As InvalidCastException
            MsgBox("No se pudo filtrar, revise el valor introducido", MsgBoxStyle.Exclamation, "Atención")
        Catch ErrorFiltro As EvaluateException
            MsgBox("No se pudo filtrar, revise el valor introducido", MsgBoxStyle.Exclamation, "Atención")
        Catch ErrorGeneral As Exception
            MsgBox("Error de la aplicación, avise a mantenimiento", MsgBoxStyle.Critical, "Atención")
        Finally
            Me.Cursor = Cursors.Default
        End Try
        Return queryFiltro
    End Function
End Class