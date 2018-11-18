<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilterClt
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
        Me.dtpBuscar = New System.Windows.Forms.DateTimePicker()
        Me.LblSiNo = New System.Windows.Forms.Label()
        Me.LblValores = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbCampos = New System.Windows.Forms.ComboBox()
        Me.CmbOperadores = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'dtpBuscar
        '
        Me.dtpBuscar.Location = New System.Drawing.Point(714, 70)
        Me.dtpBuscar.Name = "dtpBuscar"
        Me.dtpBuscar.Size = New System.Drawing.Size(394, 20)
        Me.dtpBuscar.TabIndex = 26
        '
        'LblSiNo
        '
        Me.LblSiNo.AutoSize = True
        Me.LblSiNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSiNo.Location = New System.Drawing.Point(1114, 70)
        Me.LblSiNo.Name = "LblSiNo"
        Me.LblSiNo.Size = New System.Drawing.Size(136, 25)
        Me.LblSiNo.TabIndex = 25
        Me.LblSiNo.Text = "Teclee S ó N"
        Me.LblSiNo.Visible = False
        '
        'LblValores
        '
        Me.LblValores.AutoSize = True
        Me.LblValores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValores.Location = New System.Drawing.Point(710, 26)
        Me.LblValores.Name = "LblValores"
        Me.LblValores.Size = New System.Drawing.Size(530, 24)
        Me.LblValores.TabIndex = 24
        Me.LblValores.Text = "Teclee valores entre comillas simples  y separados por comas"
        Me.LblValores.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(714, 148)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(375, 34)
        Me.BtnCancelar.TabIndex = 23
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(299, 148)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(375, 34)
        Me.BtnAceptar.TabIndex = 22
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtValor
        '
        Me.TxtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValor.Location = New System.Drawing.Point(714, 68)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(394, 29)
        Me.TxtValor.TabIndex = 21
        Me.TxtValor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Seleccione valores para establecer el filtro"
        '
        'CmbCampos
        '
        Me.CmbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCampos.FormattingEnabled = True
        Me.CmbCampos.Location = New System.Drawing.Point(13, 68)
        Me.CmbCampos.Name = "CmbCampos"
        Me.CmbCampos.Size = New System.Drawing.Size(214, 32)
        Me.CmbCampos.TabIndex = 19
        '
        'CmbOperadores
        '
        Me.CmbOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOperadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbOperadores.FormattingEnabled = True
        Me.CmbOperadores.Location = New System.Drawing.Point(269, 68)
        Me.CmbOperadores.Name = "CmbOperadores"
        Me.CmbOperadores.Size = New System.Drawing.Size(405, 32)
        Me.CmbOperadores.TabIndex = 18
        '
        'FrmFilterClt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 212)
        Me.Controls.Add(Me.dtpBuscar)
        Me.Controls.Add(Me.LblSiNo)
        Me.Controls.Add(Me.LblValores)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbCampos)
        Me.Controls.Add(Me.CmbOperadores)
        Me.Name = "FrmFilterClt"
        Me.Text = "FrmFilterClt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpBuscar As DateTimePicker
    Friend WithEvents LblSiNo As Label
    Friend WithEvents LblValores As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbCampos As ComboBox
    Friend WithEvents CmbOperadores As ComboBox
End Class
