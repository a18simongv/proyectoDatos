<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepPedido
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
        Me.dtgPedidosC = New System.Windows.Forms.DataGridView()
        Me.dtgLineas = New System.Windows.Forms.DataGridView()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblPob = New System.Windows.Forms.Label()
        Me.lblCodPos = New System.Windows.Forms.Label()
        Me.lblDirec = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.LblNif = New System.Windows.Forms.Label()
        CType(Me.dtgPedidosC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgPedidosC
        '
        Me.dtgPedidosC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPedidosC.Location = New System.Drawing.Point(97, 148)
        Me.dtgPedidosC.Name = "dtgPedidosC"
        Me.dtgPedidosC.Size = New System.Drawing.Size(663, 152)
        Me.dtgPedidosC.TabIndex = 0
        '
        'dtgLineas
        '
        Me.dtgLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLineas.Location = New System.Drawing.Point(97, 411)
        Me.dtgLineas.Name = "dtgLineas"
        Me.dtgLineas.Size = New System.Drawing.Size(790, 156)
        Me.dtgLineas.TabIndex = 1
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(323, 317)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(172, 37)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 59)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Recepción de Pedidos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblTel)
        Me.GroupBox1.Controls.Add(Me.lblPob)
        Me.GroupBox1.Controls.Add(Me.lblCodPos)
        Me.GroupBox1.Controls.Add(Me.lblDirec)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.LblNif)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Location = New System.Drawing.Point(850, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 220)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedor"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 17)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Teléfono:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Poblacion:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Cod. Postal:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Dirección:"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Nombre: "
        '
        'label
        '
        Me.label.Location = New System.Drawing.Point(16, 16)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(100, 17)
        Me.label.TabIndex = 6
        Me.label.Text = "NIF:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(896, 411)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 226)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produto"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 22)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 22)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(122, 190)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 17)
        Me.lblEmail.TabIndex = 19
        '
        'lblTel
        '
        Me.lblTel.Location = New System.Drawing.Point(122, 161)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(100, 17)
        Me.lblTel.TabIndex = 18
        '
        'lblPob
        '
        Me.lblPob.Location = New System.Drawing.Point(122, 132)
        Me.lblPob.Name = "lblPob"
        Me.lblPob.Size = New System.Drawing.Size(100, 17)
        Me.lblPob.TabIndex = 17
        '
        'lblCodPos
        '
        Me.lblCodPos.Location = New System.Drawing.Point(122, 103)
        Me.lblCodPos.Name = "lblCodPos"
        Me.lblCodPos.Size = New System.Drawing.Size(100, 17)
        Me.lblCodPos.TabIndex = 16
        '
        'lblDirec
        '
        Me.lblDirec.Location = New System.Drawing.Point(122, 74)
        Me.lblDirec.Name = "lblDirec"
        Me.lblDirec.Size = New System.Drawing.Size(100, 17)
        Me.lblDirec.TabIndex = 15
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(122, 45)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(100, 17)
        Me.lblNombre.TabIndex = 14
        '
        'LblNif
        '
        Me.LblNif.Location = New System.Drawing.Point(122, 16)
        Me.LblNif.Name = "LblNif"
        Me.LblNif.Size = New System.Drawing.Size(100, 17)
        Me.LblNif.TabIndex = 13
        '
        'FrmRecepPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 632)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.dtgLineas)
        Me.Controls.Add(Me.dtgPedidosC)
        Me.Name = "FrmRecepPedido"
        Me.Text = "FrmRecepPedido"
        CType(Me.dtgPedidosC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgPedidosC As DataGridView
    Friend WithEvents dtgLineas As DataGridView
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents label As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblPob As Label
    Friend WithEvents lblCodPos As Label
    Friend WithEvents lblDirec As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents LblNif As Label
End Class
