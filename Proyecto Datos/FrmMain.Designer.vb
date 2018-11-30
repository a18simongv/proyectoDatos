<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClt = New System.Windows.Forms.Button()
        Me.BtnFPago = New System.Windows.Forms.Button()
        Me.BtnTiposIva = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.BtnProd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGesPed = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRecPed = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.BtnClt)
        Me.Panel1.Controls.Add(Me.BtnFPago)
        Me.Panel1.Controls.Add(Me.BtnTiposIva)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnProveedores)
        Me.Panel1.Controls.Add(Me.BtnProd)
        Me.Panel1.Location = New System.Drawing.Point(54, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(166, 226)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Tag = "Mantenimiento"
        '
        'BtnClt
        '
        Me.BtnClt.Location = New System.Drawing.Point(38, 105)
        Me.BtnClt.Name = "BtnClt"
        Me.BtnClt.Size = New System.Drawing.Size(96, 27)
        Me.BtnClt.TabIndex = 5
        Me.BtnClt.Text = "Clientes"
        Me.BtnClt.UseVisualStyleBackColor = True
        '
        'BtnFPago
        '
        Me.BtnFPago.Location = New System.Drawing.Point(38, 167)
        Me.BtnFPago.Name = "BtnFPago"
        Me.BtnFPago.Size = New System.Drawing.Size(96, 27)
        Me.BtnFPago.TabIndex = 4
        Me.BtnFPago.Text = "Formas de pago"
        Me.BtnFPago.UseVisualStyleBackColor = True
        '
        'BtnTiposIva
        '
        Me.BtnTiposIva.Location = New System.Drawing.Point(38, 136)
        Me.BtnTiposIva.Name = "BtnTiposIva"
        Me.BtnTiposIva.Size = New System.Drawing.Size(96, 27)
        Me.BtnTiposIva.TabIndex = 3
        Me.BtnTiposIva.Text = "Tipos Iva"
        Me.BtnTiposIva.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mantenimiento"
        '
        'BtnProveedores
        '
        Me.BtnProveedores.Location = New System.Drawing.Point(38, 74)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(96, 27)
        Me.BtnProveedores.TabIndex = 1
        Me.BtnProveedores.Text = "Proveedores"
        Me.BtnProveedores.UseVisualStyleBackColor = True
        '
        'BtnProd
        '
        Me.BtnProd.Location = New System.Drawing.Point(38, 43)
        Me.BtnProd.Name = "BtnProd"
        Me.BtnProd.Size = New System.Drawing.Size(96, 27)
        Me.BtnProd.TabIndex = 0
        Me.BtnProd.Text = "Productos"
        Me.BtnProd.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Controls.Add(Me.btnRecPed)
        Me.Panel2.Controls.Add(Me.btnGesPed)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(239, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(156, 226)
        Me.Panel2.TabIndex = 1
        '
        'btnGesPed
        '
        Me.btnGesPed.Location = New System.Drawing.Point(15, 43)
        Me.btnGesPed.Name = "btnGesPed"
        Me.btnGesPed.Size = New System.Drawing.Size(128, 27)
        Me.btnGesPed.TabIndex = 1
        Me.btnGesPed.Text = "Gestión de pedidos"
        Me.btnGesPed.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Compras"
        '
        'btnRecPed
        '
        Me.btnRecPed.Location = New System.Drawing.Point(15, 78)
        Me.btnRecPed.Name = "btnRecPed"
        Me.btnRecPed.Size = New System.Drawing.Size(128, 27)
        Me.btnRecPed.TabIndex = 2
        Me.btnRecPed.Text = "Recepción de Pedidos"
        Me.btnRecPed.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 493)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMain"
        Me.Text = "FrmMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnProveedores As Button
    Friend WithEvents BtnProd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFPago As Button
    Friend WithEvents BtnTiposIva As Button
    Friend WithEvents BtnClt As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGesPed As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRecPed As Button
End Class
