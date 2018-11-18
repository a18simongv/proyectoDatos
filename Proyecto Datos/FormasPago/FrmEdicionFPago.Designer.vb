<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdicionFPago
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
        Me.lblFPago = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodPago = New System.Windows.Forms.TextBox()
        Me.txtDescri = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.txtCad = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFPago
        '
        Me.lblFPago.Location = New System.Drawing.Point(53, 49)
        Me.lblFPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFPago.Name = "lblFPago"
        Me.lblFPago.Size = New System.Drawing.Size(119, 28)
        Me.lblFPago.TabIndex = 0
        Me.lblFPago.Text = "CodFPago:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(53, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(53, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Plazos:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(53, 163)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cadencia:"
        '
        'txtCodPago
        '
        Me.txtCodPago.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodPago.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodPago.Location = New System.Drawing.Point(203, 52)
        Me.txtCodPago.Name = "txtCodPago"
        Me.txtCodPago.Size = New System.Drawing.Size(100, 22)
        Me.txtCodPago.TabIndex = 4
        '
        'txtDescri
        '
        Me.txtDescri.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescri.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDescri.Location = New System.Drawing.Point(203, 90)
        Me.txtDescri.Name = "txtDescri"
        Me.txtDescri.Size = New System.Drawing.Size(100, 22)
        Me.txtDescri.TabIndex = 5
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.SystemColors.Control
        Me.txtPlazo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPlazo.Location = New System.Drawing.Point(203, 128)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.Size = New System.Drawing.Size(100, 22)
        Me.txtPlazo.TabIndex = 6
        '
        'txtCad
        '
        Me.txtCad.BackColor = System.Drawing.SystemColors.Control
        Me.txtCad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCad.Location = New System.Drawing.Point(203, 166)
        Me.txtCad.Name = "txtCad"
        Me.txtCad.Size = New System.Drawing.Size(100, 22)
        Me.txtCad.TabIndex = 7
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(230, 214)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(93, 29)
        Me.BtnCancelar.TabIndex = 66
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(90, 214)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(93, 29)
        Me.BtnAceptar.TabIndex = 65
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmEdicionFPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 312)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.txtCad)
        Me.Controls.Add(Me.txtPlazo)
        Me.Controls.Add(Me.txtDescri)
        Me.Controls.Add(Me.txtCodPago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFPago)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEdicionFPago"
        Me.Text = "FrmEdicionFPago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFPago As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodPago As TextBox
    Friend WithEvents txtDescri As TextBox
    Friend WithEvents txtPlazo As TextBox
    Friend WithEvents txtCad As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
End Class
