<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFiltros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CmbOperadores = New System.Windows.Forms.ComboBox()
        Me.CmbCampos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblValores = New System.Windows.Forms.Label()
        Me.LblSiNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmbOperadores
        '
        Me.CmbOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOperadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbOperadores.FormattingEnabled = True
        Me.CmbOperadores.Location = New System.Drawing.Point(268, 64)
        Me.CmbOperadores.Name = "CmbOperadores"
        Me.CmbOperadores.Size = New System.Drawing.Size(405, 32)
        Me.CmbOperadores.TabIndex = 0
        '
        'CmbCampos
        '
        Me.CmbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCampos.FormattingEnabled = True
        Me.CmbCampos.Location = New System.Drawing.Point(12, 64)
        Me.CmbCampos.Name = "CmbCampos"
        Me.CmbCampos.Size = New System.Drawing.Size(214, 32)
        Me.CmbCampos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione valores para establecer el filtro"
        '
        'TxtValor
        '
        Me.TxtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValor.Location = New System.Drawing.Point(713, 64)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(394, 29)
        Me.TxtValor.TabIndex = 3
        Me.TxtValor.Visible = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(298, 144)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(375, 34)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(713, 144)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(375, 34)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblValores
        '
        Me.LblValores.AutoSize = True
        Me.LblValores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValores.Location = New System.Drawing.Point(709, 22)
        Me.LblValores.Name = "LblValores"
        Me.LblValores.Size = New System.Drawing.Size(530, 24)
        Me.LblValores.TabIndex = 7
        Me.LblValores.Text = "Teclee valores entre comillas simples  y separados por comas"
        Me.LblValores.Visible = False
        '
        'LblSiNo
        '
        Me.LblSiNo.AutoSize = True
        Me.LblSiNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSiNo.Location = New System.Drawing.Point(1113, 66)
        Me.LblSiNo.Name = "LblSiNo"
        Me.LblSiNo.Size = New System.Drawing.Size(136, 25)
        Me.LblSiNo.TabIndex = 8
        Me.LblSiNo.Text = "Teclee S ó N"
        Me.LblSiNo.Visible = False
        '
        'FrmFiltros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1289, 190)
        Me.Controls.Add(Me.LblSiNo)
        Me.Controls.Add(Me.LblValores)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbCampos)
        Me.Controls.Add(Me.CmbOperadores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmFiltros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtrar Productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbOperadores As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCampos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents LblValores As System.Windows.Forms.Label
    Friend WithEvents LblSiNo As Label
End Class
