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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.chbTodos = New System.Windows.Forms.CheckBox()
        Me.btnRealizar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 143)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(906, 186)
        Me.DataGridView1.TabIndex = 1
        '
        'chbTodos
        '
        Me.chbTodos.AutoSize = True
        Me.chbTodos.Location = New System.Drawing.Point(872, 109)
        Me.chbTodos.Name = "chbTodos"
        Me.chbTodos.Size = New System.Drawing.Size(56, 17)
        Me.chbTodos.TabIndex = 2
        Me.chbTodos.Text = "Todos"
        Me.chbTodos.UseVisualStyleBackColor = True
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
        'FormGestionPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 471)
        Me.Controls.Add(Me.btnRealizar)
        Me.Controls.Add(Me.chbTodos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormGestionPedidos"
        Me.Text = "FormGestionPedidos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents chbTodos As CheckBox
    Friend WithEvents btnRealizar As Button
End Class
