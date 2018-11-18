<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdicionClt
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
        Me.cmbPobl = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpAlta = New System.Windows.Forms.DateTimePicker()
        Me.CmbFPago = New System.Windows.Forms.ComboBox()
        Me.CmbSuc = New System.Windows.Forms.ComboBox()
        Me.CmbBan = New System.Windows.Forms.ComboBox()
        Me.cmbProv = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.TxtTelef = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtCodPos = New System.Windows.Forms.TextBox()
        Me.TxtDirec = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtNIF = New System.Windows.Forms.TextBox()
        Me.TxtCodClt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCodClt = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtDirEnv = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbPobl
        '
        Me.cmbPobl.FormattingEnabled = True
        Me.cmbPobl.Location = New System.Drawing.Point(182, 253)
        Me.cmbPobl.Name = "cmbPobl"
        Me.cmbPobl.Size = New System.Drawing.Size(108, 21)
        Me.cmbPobl.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 250)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 26)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Población:"
        '
        'dtpAlta
        '
        Me.dtpAlta.Location = New System.Drawing.Point(182, 405)
        Me.dtpAlta.Name = "dtpAlta"
        Me.dtpAlta.Size = New System.Drawing.Size(240, 20)
        Me.dtpAlta.TabIndex = 98
        '
        'CmbFPago
        '
        Me.CmbFPago.FormattingEnabled = True
        Me.CmbFPago.Location = New System.Drawing.Point(182, 557)
        Me.CmbFPago.Name = "CmbFPago"
        Me.CmbFPago.Size = New System.Drawing.Size(108, 21)
        Me.CmbFPago.TabIndex = 97
        '
        'CmbSuc
        '
        Me.CmbSuc.FormattingEnabled = True
        Me.CmbSuc.Location = New System.Drawing.Point(182, 481)
        Me.CmbSuc.Name = "CmbSuc"
        Me.CmbSuc.Size = New System.Drawing.Size(108, 21)
        Me.CmbSuc.TabIndex = 96
        '
        'CmbBan
        '
        Me.CmbBan.FormattingEnabled = True
        Me.CmbBan.Location = New System.Drawing.Point(182, 443)
        Me.CmbBan.Name = "CmbBan"
        Me.CmbBan.Size = New System.Drawing.Size(108, 21)
        Me.CmbBan.TabIndex = 95
        '
        'cmbProv
        '
        Me.cmbProv.FormattingEnabled = True
        Me.cmbProv.Location = New System.Drawing.Point(182, 215)
        Me.cmbProv.Name = "cmbProv"
        Me.cmbProv.Size = New System.Drawing.Size(108, 21)
        Me.cmbProv.TabIndex = 94
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(571, 542)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(93, 29)
        Me.BtnCancelar.TabIndex = 93
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(431, 542)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(93, 29)
        Me.BtnAceptar.TabIndex = 92
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtFax
        '
        Me.TxtFax.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtFax.Location = New System.Drawing.Point(182, 329)
        Me.TxtFax.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(188, 20)
        Me.TxtFax.TabIndex = 91
        '
        'TxtTelef
        '
        Me.TxtTelef.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtTelef.Location = New System.Drawing.Point(182, 291)
        Me.TxtTelef.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelef.Name = "TxtTelef"
        Me.TxtTelef.Size = New System.Drawing.Size(188, 20)
        Me.TxtTelef.TabIndex = 90
        Me.TxtTelef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtEmail
        '
        Me.TxtEmail.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtEmail.Location = New System.Drawing.Point(182, 367)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(188, 20)
        Me.TxtEmail.TabIndex = 89
        '
        'TxtCodPos
        '
        Me.TxtCodPos.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtCodPos.Location = New System.Drawing.Point(182, 177)
        Me.TxtCodPos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodPos.Name = "TxtCodPos"
        Me.TxtCodPos.Size = New System.Drawing.Size(188, 20)
        Me.TxtCodPos.TabIndex = 88
        Me.TxtCodPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDirec
        '
        Me.TxtDirec.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtDirec.Location = New System.Drawing.Point(182, 139)
        Me.TxtDirec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDirec.Name = "TxtDirec"
        Me.TxtDirec.Size = New System.Drawing.Size(188, 20)
        Me.TxtDirec.TabIndex = 87
        '
        'TxtNombre
        '
        Me.TxtNombre.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtNombre.Location = New System.Drawing.Point(182, 101)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(188, 20)
        Me.TxtNombre.TabIndex = 86
        '
        'TxtNIF
        '
        Me.TxtNIF.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtNIF.Location = New System.Drawing.Point(182, 63)
        Me.TxtNIF.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNIF.Name = "TxtNIF"
        Me.TxtNIF.Size = New System.Drawing.Size(188, 20)
        Me.TxtNIF.TabIndex = 85
        '
        'TxtCodClt
        '
        Me.TxtCodClt.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodClt.Location = New System.Drawing.Point(182, 25)
        Me.TxtCodClt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodClt.Name = "TxtCodClt"
        Me.TxtCodClt.Size = New System.Drawing.Size(188, 20)
        Me.TxtCodClt.TabIndex = 84
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 554)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 26)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Forma pago:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 478)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 26)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Cod. Sucursal:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 440)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 26)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Código Banco:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 402)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 26)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Fecha alta:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 364)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 26)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 326)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 26)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Fax:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 288)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 26)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Teléfono:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 212)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 26)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Provincia:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 26)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Cod. Postal:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 26)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 26)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 26)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "NIF:"
        '
        'LblCodClt
        '
        Me.LblCodClt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodClt.Location = New System.Drawing.Point(23, 22)
        Me.LblCodClt.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblCodClt.Name = "LblCodClt"
        Me.LblCodClt.Size = New System.Drawing.Size(150, 26)
        Me.LblCodClt.TabIndex = 71
        Me.LblCodClt.Text = "Código Cliente:"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(23, 516)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 26)
        Me.Label17.TabIndex = 101
        Me.Label17.Text = "Direc. Envio:"
        '
        'TxtDirEnv
        '
        Me.TxtDirEnv.Location = New System.Drawing.Point(182, 519)
        Me.TxtDirEnv.Name = "TxtDirEnv"
        Me.TxtDirEnv.Size = New System.Drawing.Size(188, 20)
        Me.TxtDirEnv.TabIndex = 102
        '
        'FrmEdicionClt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 625)
        Me.Controls.Add(Me.TxtDirEnv)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbPobl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpAlta)
        Me.Controls.Add(Me.CmbFPago)
        Me.Controls.Add(Me.CmbSuc)
        Me.Controls.Add(Me.CmbBan)
        Me.Controls.Add(Me.cmbProv)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtFax)
        Me.Controls.Add(Me.TxtTelef)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtCodPos)
        Me.Controls.Add(Me.TxtDirec)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtNIF)
        Me.Controls.Add(Me.TxtCodClt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblCodClt)
        Me.Name = "FrmEdicionClt"
        Me.Text = "FrmEdicionClt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbPobl As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpAlta As DateTimePicker
    Friend WithEvents CmbFPago As ComboBox
    Friend WithEvents CmbSuc As ComboBox
    Friend WithEvents CmbBan As ComboBox
    Friend WithEvents cmbProv As ComboBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents TxtTelef As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtCodPos As TextBox
    Friend WithEvents TxtDirec As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtNIF As TextBox
    Friend WithEvents TxtCodClt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblCodClt As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtDirEnv As TextBox
End Class
