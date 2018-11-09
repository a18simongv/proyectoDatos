<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblNProd = New System.Windows.Forms.Label()
        Me.BtnCalcNProd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.ButnValorar = New System.Windows.Forms.Button()
        Me.BtnComenzar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSubida = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LstProveedores = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbProductos = New System.Windows.Forms.ComboBox()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº de Productos:"
        '
        'LblNProd
        '
        Me.LblNProd.Location = New System.Drawing.Point(411, 100)
        Me.LblNProd.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblNProd.Name = "LblNProd"
        Me.LblNProd.Size = New System.Drawing.Size(140, 24)
        Me.LblNProd.TabIndex = 1
        '
        'BtnCalcNProd
        '
        Me.BtnCalcNProd.Location = New System.Drawing.Point(855, 88)
        Me.BtnCalcNProd.Name = "BtnCalcNProd"
        Me.BtnCalcNProd.Size = New System.Drawing.Size(95, 36)
        Me.BtnCalcNProd.TabIndex = 2
        Me.BtnCalcNProd.Text = "Calcular"
        Me.BtnCalcNProd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor Mercancía:"
        '
        'LblValor
        '
        Me.LblValor.Location = New System.Drawing.Point(411, 146)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(140, 24)
        Me.LblValor.TabIndex = 4
        '
        'ButnValorar
        '
        Me.ButnValorar.Location = New System.Drawing.Point(855, 141)
        Me.ButnValorar.Name = "ButnValorar"
        Me.ButnValorar.Size = New System.Drawing.Size(95, 34)
        Me.ButnValorar.TabIndex = 5
        Me.ButnValorar.Text = "Calcular"
        Me.ButnValorar.UseVisualStyleBackColor = True
        '
        'BtnComenzar
        '
        Me.BtnComenzar.Location = New System.Drawing.Point(823, 205)
        Me.BtnComenzar.Name = "BtnComenzar"
        Me.BtnComenzar.Size = New System.Drawing.Size(167, 33)
        Me.BtnComenzar.TabIndex = 6
        Me.BtnComenzar.Text = "Comenzar"
        Me.BtnComenzar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Subir Precios"
        '
        'TxtSubida
        '
        Me.TxtSubida.Location = New System.Drawing.Point(191, 206)
        Me.TxtSubida.Name = "TxtSubida"
        Me.TxtSubida.Size = New System.Drawing.Size(100, 29)
        Me.TxtSubida.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(297, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "% a los productos del Proveedor"
        '
        'LstProveedores
        '
        Me.LstProveedores.FormattingEnabled = True
        Me.LstProveedores.ItemHeight = 24
        Me.LstProveedores.Items.AddRange(New Object() {"1", "2"})
        Me.LstProveedores.Location = New System.Drawing.Point(585, 196)
        Me.LstProveedores.Name = "LstProveedores"
        Me.LstProveedores.Size = New System.Drawing.Size(26, 52)
        Me.LstProveedores.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Productos"
        '
        'CmbProductos
        '
        Me.CmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProductos.FormattingEnabled = True
        Me.CmbProductos.Location = New System.Drawing.Point(160, 274)
        Me.CmbProductos.Name = "CmbProductos"
        Me.CmbProductos.Size = New System.Drawing.Size(307, 32)
        Me.CmbProductos.TabIndex = 12
        '
        'BtnCargar
        '
        Me.BtnCargar.Location = New System.Drawing.Point(486, 274)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(182, 32)
        Me.BtnCargar.TabIndex = 13
        Me.BtnCargar.Text = "Cargar"
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 480)
        Me.Controls.Add(Me.BtnCargar)
        Me.Controls.Add(Me.CmbProductos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LstProveedores)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtSubida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnComenzar)
        Me.Controls.Add(Me.ButnValorar)
        Me.Controls.Add(Me.LblValor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCalcNProd)
        Me.Controls.Add(Me.LblNProd)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Pruebas de datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblNProd As Label
    Friend WithEvents BtnCalcNProd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LblValor As Label
    Friend WithEvents ButnValorar As Button
    Friend WithEvents BtnComenzar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSubida As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LstProveedores As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbProductos As ComboBox
    Friend WithEvents BtnCargar As Button
End Class
