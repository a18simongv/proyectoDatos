<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAuxiliar
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTCodigo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblCodProd = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPCM = New System.Windows.Forms.TextBox()
        Me.TxtPVP = New System.Windows.Forms.TextBox()
        Me.TxtStRep = New System.Windows.Forms.TextBox()
        Me.TxtStMin = New System.Windows.Forms.TextBox()
        Me.TxtExist = New System.Windows.Forms.TextBox()
        Me.TxtDescri = New System.Windows.Forms.TextBox()
        Me.CmbTiposIva = New System.Windows.Forms.ComboBox()
        Me.CmbProveedores = New System.Windows.Forms.ComboBox()
        Me.ChkPendiente = New System.Windows.Forms.CheckBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(73, 881)
        Me.Label10.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 24)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Pendiente:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 788)
        Me.Label9.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 24)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Código de Proveedor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(73, 698)
        Me.Label8.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 24)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tipo I.V.A.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 288)
        Me.Label7.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Precio Compra medio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 247)
        Me.Label6.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "P.V.P.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 206)
        Me.Label5.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Stock Reposición:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 165)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Stock mínimo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Existencias:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Descripción:"
        '
        'LblTCodigo
        '
        Me.LblTCodigo.AutoSize = True
        Me.LblTCodigo.Location = New System.Drawing.Point(95, 42)
        Me.LblTCodigo.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.LblTCodigo.Name = "LblTCodigo"
        Me.LblTCodigo.Size = New System.Drawing.Size(157, 24)
        Me.LblTCodigo.TabIndex = 10
        Me.LblTCodigo.Text = "Código Producto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(95, 411)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Pendiente:"
        '
        'LblCodProd
        '
        Me.LblCodProd.Location = New System.Drawing.Point(309, 42)
        Me.LblCodProd.Name = "LblCodProd"
        Me.LblCodProd.Size = New System.Drawing.Size(83, 24)
        Me.LblCodProd.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(95, 370)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Proveedor:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(95, 329)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 24)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "IVA:"
        '
        'TxtPCM
        '
        Me.TxtPCM.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtPCM.Location = New System.Drawing.Point(313, 285)
        Me.TxtPCM.Name = "TxtPCM"
        Me.TxtPCM.Size = New System.Drawing.Size(100, 29)
        Me.TxtPCM.TabIndex = 29
        Me.TxtPCM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPVP
        '
        Me.TxtPVP.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtPVP.Location = New System.Drawing.Point(313, 247)
        Me.TxtPVP.Name = "TxtPVP"
        Me.TxtPVP.Size = New System.Drawing.Size(100, 29)
        Me.TxtPVP.TabIndex = 28
        Me.TxtPVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtStRep
        '
        Me.TxtStRep.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtStRep.Location = New System.Drawing.Point(313, 201)
        Me.TxtStRep.Name = "TxtStRep"
        Me.TxtStRep.Size = New System.Drawing.Size(100, 29)
        Me.TxtStRep.TabIndex = 27
        Me.TxtStRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtStMin
        '
        Me.TxtStMin.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtStMin.Location = New System.Drawing.Point(313, 165)
        Me.TxtStMin.Name = "TxtStMin"
        Me.TxtStMin.Size = New System.Drawing.Size(100, 29)
        Me.TxtStMin.TabIndex = 26
        Me.TxtStMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtExist
        '
        Me.TxtExist.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtExist.Location = New System.Drawing.Point(313, 121)
        Me.TxtExist.Name = "TxtExist"
        Me.TxtExist.Size = New System.Drawing.Size(100, 29)
        Me.TxtExist.TabIndex = 25
        Me.TxtExist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDescri
        '
        Me.TxtDescri.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtDescri.Location = New System.Drawing.Point(313, 83)
        Me.TxtDescri.Name = "TxtDescri"
        Me.TxtDescri.Size = New System.Drawing.Size(449, 29)
        Me.TxtDescri.TabIndex = 24
        '
        'CmbTiposIva
        '
        Me.CmbTiposIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTiposIva.FormattingEnabled = True
        Me.CmbTiposIva.Location = New System.Drawing.Point(313, 329)
        Me.CmbTiposIva.Name = "CmbTiposIva"
        Me.CmbTiposIva.Size = New System.Drawing.Size(100, 32)
        Me.CmbTiposIva.TabIndex = 30
        '
        'CmbProveedores
        '
        Me.CmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProveedores.FormattingEnabled = True
        Me.CmbProveedores.Location = New System.Drawing.Point(313, 370)
        Me.CmbProveedores.Name = "CmbProveedores"
        Me.CmbProveedores.Size = New System.Drawing.Size(449, 32)
        Me.CmbProveedores.TabIndex = 31
        '
        'ChkPendiente
        '
        Me.ChkPendiente.AutoSize = True
        Me.ChkPendiente.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ChkPendiente.Location = New System.Drawing.Point(313, 421)
        Me.ChkPendiente.Name = "ChkPendiente"
        Me.ChkPendiente.Size = New System.Drawing.Size(15, 14)
        Me.ChkPendiente.TabIndex = 32
        Me.ChkPendiente.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(229, 472)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(117, 36)
        Me.BtnAceptar.TabIndex = 33
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(585, 472)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(117, 36)
        Me.BtnCancelar.TabIndex = 34
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmAuxiliar
        '
        Me.AcceptButton = Me.BtnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(870, 543)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.ChkPendiente)
        Me.Controls.Add(Me.CmbProveedores)
        Me.Controls.Add(Me.CmbTiposIva)
        Me.Controls.Add(Me.TxtPCM)
        Me.Controls.Add(Me.TxtPVP)
        Me.Controls.Add(Me.TxtStRep)
        Me.Controls.Add(Me.TxtStMin)
        Me.Controls.Add(Me.TxtExist)
        Me.Controls.Add(Me.TxtDescri)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LblCodProd)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTCodigo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmAuxiliar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAuxiliar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTCodigo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblCodProd As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtPCM As TextBox
    Friend WithEvents TxtPVP As TextBox
    Friend WithEvents TxtStRep As TextBox
    Friend WithEvents TxtStMin As TextBox
    Friend WithEvents TxtExist As TextBox
    Friend WithEvents TxtDescri As TextBox
    Friend WithEvents CmbTiposIva As ComboBox
    Friend WithEvents CmbProveedores As ComboBox
    Friend WithEvents ChkPendiente As CheckBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
End Class
