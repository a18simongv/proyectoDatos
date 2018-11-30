<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionPedidos
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
        Me.dtgProductos = New System.Windows.Forms.DataGridView()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.btnRealizar = New System.Windows.Forms.Button()
        Me.dtgPedidos = New System.Windows.Forms.DataGridView()
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion pedidos"
        '
        'dtgProductos
        '
        Me.dtgProductos.AllowUserToAddRows = False
        Me.dtgProductos.AllowUserToDeleteRows = False
        Me.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProductos.Location = New System.Drawing.Point(47, 143)
        Me.dtgProductos.Name = "dtgProductos"
        Me.dtgProductos.Size = New System.Drawing.Size(959, 186)
        Me.dtgProductos.TabIndex = 1
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(872, 109)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'btnRealizar
        '
        Me.btnRealizar.Location = New System.Drawing.Point(410, 369)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(206, 28)
        Me.btnRealizar.TabIndex = 3
        Me.btnRealizar.Text = "Realizar pedidos"
        Me.btnRealizar.UseVisualStyleBackColor = True
        '
        'dtgPedidos
        '
        Me.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPedidos.Location = New System.Drawing.Point(47, 443)
        Me.dtgPedidos.Name = "dtgPedidos"
        Me.dtgPedidos.Size = New System.Drawing.Size(959, 150)
        Me.dtgPedidos.TabIndex = 4
        '
        'FormGestionPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 639)
        Me.Controls.Add(Me.dtgPedidos)
        Me.Controls.Add(Me.btnRealizar)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.dtgProductos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormGestionPedidos"
        Me.Text = "FormGestionPedidos"
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtgProductos As DataGridView
    Friend WithEvents chkTodos As CheckBox
    Friend WithEvents btnRealizar As Button
    Friend WithEvents dtgPedidos As DataGridView
End Class
