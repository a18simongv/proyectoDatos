<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdicionTIva
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPorcen = New System.Windows.Forms.TextBox()
        Me.txtTpIva = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipIv = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "%"
        '
        'TxtPorcen
        '
        Me.TxtPorcen.Location = New System.Drawing.Point(190, 128)
        Me.TxtPorcen.Name = "TxtPorcen"
        Me.TxtPorcen.Size = New System.Drawing.Size(63, 20)
        Me.TxtPorcen.TabIndex = 8
        Me.TxtPorcen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTpIva
        '
        Me.txtTpIva.Location = New System.Drawing.Point(190, 83)
        Me.txtTpIva.Name = "txtTpIva"
        Me.txtTpIva.Size = New System.Drawing.Size(63, 20)
        Me.txtTpIva.TabIndex = 7
        Me.txtTpIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Procentaje: "
        '
        'lblTipIv
        '
        Me.lblTipIv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipIv.Location = New System.Drawing.Point(44, 82)
        Me.lblTipIv.Name = "lblTipIv"
        Me.lblTipIv.Size = New System.Drawing.Size(100, 23)
        Me.lblTipIv.TabIndex = 5
        Me.lblTipIv.Text = "Tipo Iva:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(191, 182)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(93, 29)
        Me.BtnCancelar.TabIndex = 64
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(51, 182)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(93, 29)
        Me.BtnAceptar.TabIndex = 63
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmEdicionTIva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 306)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPorcen)
        Me.Controls.Add(Me.txtTpIva)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTipIv)
        Me.Name = "FrmEdicionTIva"
        Me.Text = "FrmEdicionTIva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPorcen As TextBox
    Friend WithEvents txtTpIva As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTipIv As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
End Class
