<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainFPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCad = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.txtDescri = New System.Windows.Forms.TextBox()
        Me.txtCodPago = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtgFPago = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSalir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DtgFPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCad
        '
        Me.txtCad.BackColor = System.Drawing.SystemColors.Control
        Me.txtCad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCad.Location = New System.Drawing.Point(212, 166)
        Me.txtCad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCad.Name = "txtCad"
        Me.txtCad.Size = New System.Drawing.Size(148, 22)
        Me.txtCad.TabIndex = 15
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.SystemColors.Control
        Me.txtPlazo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPlazo.Location = New System.Drawing.Point(212, 123)
        Me.txtPlazo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.Size = New System.Drawing.Size(148, 22)
        Me.txtPlazo.TabIndex = 14
        '
        'txtDescri
        '
        Me.txtDescri.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescri.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDescri.Location = New System.Drawing.Point(212, 80)
        Me.txtDescri.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescri.Name = "txtDescri"
        Me.txtDescri.Size = New System.Drawing.Size(148, 22)
        Me.txtDescri.TabIndex = 13
        '
        'txtCodPago
        '
        Me.txtCodPago.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodPago.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodPago.Location = New System.Drawing.Point(212, 37)
        Me.txtCodPago.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodPago.Name = "txtCodPago"
        Me.txtCodPago.Size = New System.Drawing.Size(148, 22)
        Me.txtCodPago.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(46, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 34)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cadencia:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(46, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 34)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Plazos:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(46, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 34)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripcion:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(46, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 34)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CodFPago:"
        '
        'DtgFPago
        '
        Me.DtgFPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgFPago.GridColor = System.Drawing.Color.Gainsboro
        Me.DtgFPago.Location = New System.Drawing.Point(128, 296)
        Me.DtgFPago.Name = "DtgFPago"
        Me.DtgFPago.ReadOnly = True
        Me.DtgFPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DtgFPago.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight
        Me.DtgFPago.Size = New System.Drawing.Size(640, 123)
        Me.DtgFPago.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnUltimo)
        Me.GroupBox1.Controls.Add(Me.BtnSiguiente)
        Me.GroupBox1.Controls.Add(Me.BtnAnterior)
        Me.GroupBox1.Controls.Add(Me.BtnPrimero)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(49, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 72)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'BtnUltimo
        '
        Me.BtnUltimo.Location = New System.Drawing.Point(517, 33)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(89, 33)
        Me.BtnUltimo.TabIndex = 3
        Me.BtnUltimo.Text = ">>"
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Location = New System.Drawing.Point(368, 33)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(89, 33)
        Me.BtnSiguiente.TabIndex = 2
        Me.BtnSiguiente.Text = ">"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Location = New System.Drawing.Point(222, 33)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(89, 33)
        Me.BtnAnterior.TabIndex = 1
        Me.BtnAnterior.Text = "<"
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnPrimero
        '
        Me.BtnPrimero.Location = New System.Drawing.Point(65, 33)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(89, 33)
        Me.BtnPrimero.TabIndex = 0
        Me.BtnPrimero.Text = "<<"
        Me.BtnPrimero.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnModificar)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(487, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 176)
        Me.Panel2.TabIndex = 40
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(66, 124)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(214, 32)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar Forma de Pago"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(43, 74)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(253, 32)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar Datos Forma de Pago"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(66, 20)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(214, 32)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nueva forma de pago"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.tsSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNuevo, Me.tsModificar, Me.tsEliminar})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'tsNuevo
        '
        Me.tsNuevo.Name = "tsNuevo"
        Me.tsNuevo.Size = New System.Drawing.Size(125, 22)
        Me.tsNuevo.Text = "&Nuevo"
        '
        'tsModificar
        '
        Me.tsModificar.Name = "tsModificar"
        Me.tsModificar.Size = New System.Drawing.Size(125, 22)
        Me.tsModificar.Text = "&Modificar"
        '
        'tsEliminar
        '
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.Size = New System.Drawing.Size(125, 22)
        Me.tsEliminar.Text = "&Eliminar"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'tsSalir
        '
        Me.tsSalir.Name = "tsSalir"
        Me.tsSalir.Size = New System.Drawing.Size(41, 20)
        Me.tsSalir.Text = "&Salir"
        '
        'FrmMainFPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 422)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DtgFPago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCad)
        Me.Controls.Add(Me.txtPlazo)
        Me.Controls.Add(Me.txtDescri)
        Me.Controls.Add(Me.txtCodPago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMainFPago"
        Me.Text = "FrmMainFPago"
        CType(Me.DtgFPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCad As TextBox
    Friend WithEvents txtPlazo As TextBox
    Friend WithEvents txtDescri As TextBox
    Friend WithEvents txtCodPago As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DtgFPago As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnUltimo As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnPrimero As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsNuevo As ToolStripMenuItem
    Friend WithEvents tsModificar As ToolStripMenuItem
    Friend WithEvents tsEliminar As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsSalir As ToolStripMenuItem
End Class
