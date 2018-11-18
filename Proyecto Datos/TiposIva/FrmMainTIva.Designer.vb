<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainTIva
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTpIva = New System.Windows.Forms.TextBox()
        Me.TxtPorcen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.DtgTIva = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgTIva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Iva:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Procentaje: "
        '
        'txtTpIva
        '
        Me.txtTpIva.Location = New System.Drawing.Point(183, 68)
        Me.txtTpIva.Name = "txtTpIva"
        Me.txtTpIva.Size = New System.Drawing.Size(63, 20)
        Me.txtTpIva.TabIndex = 2
        Me.txtTpIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPorcen
        '
        Me.TxtPorcen.Location = New System.Drawing.Point(183, 113)
        Me.TxtPorcen.Name = "TxtPorcen"
        Me.TxtPorcen.Size = New System.Drawing.Size(63, 20)
        Me.TxtPorcen.TabIndex = 3
        Me.TxtPorcen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(252, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "%"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnModificar)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(450, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 176)
        Me.Panel2.TabIndex = 35
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(66, 124)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(214, 32)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar Tipo Iva"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(43, 74)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(253, 32)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar Datos Tipo Iva"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(66, 20)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(214, 32)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo Tipo Iva"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnUltimo)
        Me.GroupBox1.Controls.Add(Me.BtnSiguiente)
        Me.GroupBox1.Controls.Add(Me.BtnAnterior)
        Me.GroupBox1.Controls.Add(Me.BtnPrimero)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 72)
        Me.GroupBox1.TabIndex = 36
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
        'DtgTIva
        '
        Me.DtgTIva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgTIva.GridColor = System.Drawing.Color.Gainsboro
        Me.DtgTIva.Location = New System.Drawing.Point(91, 306)
        Me.DtgTIva.Name = "DtgTIva"
        Me.DtgTIva.ReadOnly = True
        Me.DtgTIva.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DtgTIva.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight
        Me.DtgTIva.Size = New System.Drawing.Size(512, 123)
        Me.DtgTIva.TabIndex = 37
        '
        'FrmMainTIva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 466)
        Me.Controls.Add(Me.DtgTIva)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPorcen)
        Me.Controls.Add(Me.txtTpIva)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMainTIva"
        Me.Text = "FrmMainTIva"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgTIva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTpIva As TextBox
    Friend WithEvents TxtPorcen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnUltimo As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnPrimero As Button
    Friend WithEvents DtgTIva As DataGridView
End Class
