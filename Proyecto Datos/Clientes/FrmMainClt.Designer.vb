<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainClt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainClt))
        Me.dtpAlta = New System.Windows.Forms.DateTimePicker()
        Me.DtgClientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblFiltrar = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtCodBuscar = New System.Windows.Forms.TextBox()
        Me.TxtCodFPago = New System.Windows.Forms.TextBox()
        Me.TxtCodBan = New System.Windows.Forms.TextBox()
        Me.TxtCodSuc = New System.Windows.Forms.TextBox()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.TxtTelef = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPobl = New System.Windows.Forms.TextBox()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProv = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtDirecEnv = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btsPri = New System.Windows.Forms.ToolStripButton()
        Me.btsAnt = New System.Windows.Forms.ToolStripButton()
        Me.btsSig = New System.Windows.Forms.ToolStripButton()
        Me.btsUlt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.DtgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpAlta
        '
        Me.dtpAlta.Enabled = False
        Me.dtpAlta.Location = New System.Drawing.Point(256, 424)
        Me.dtpAlta.Name = "dtpAlta"
        Me.dtpAlta.Size = New System.Drawing.Size(244, 20)
        Me.dtpAlta.TabIndex = 69
        '
        'DtgClientes
        '
        Me.DtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgClientes.GridColor = System.Drawing.Color.Gainsboro
        Me.DtgClientes.Location = New System.Drawing.Point(12, 647)
        Me.DtgClientes.Name = "DtgClientes"
        Me.DtgClientes.ReadOnly = True
        Me.DtgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DtgClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight
        Me.DtgClientes.Size = New System.Drawing.Size(1111, 132)
        Me.DtgClientes.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnUltimo)
        Me.GroupBox1.Controls.Add(Me.BtnSiguiente)
        Me.GroupBox1.Controls.Add(Me.BtnAnterior)
        Me.GroupBox1.Controls.Add(Me.BtnPrimero)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(12, 554)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1111, 72)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'BtnUltimo
        '
        Me.BtnUltimo.Location = New System.Drawing.Point(877, 33)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(89, 33)
        Me.BtnUltimo.TabIndex = 3
        Me.BtnUltimo.Text = ">>"
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Location = New System.Drawing.Point(601, 33)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(89, 33)
        Me.BtnSiguiente.TabIndex = 2
        Me.BtnSiguiente.Text = ">"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Location = New System.Drawing.Point(334, 33)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(89, 33)
        Me.BtnAnterior.TabIndex = 1
        Me.BtnAnterior.Text = "<"
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnPrimero
        '
        Me.BtnPrimero.Location = New System.Drawing.Point(67, 33)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(89, 33)
        Me.BtnPrimero.TabIndex = 0
        Me.BtnPrimero.Text = "<<"
        Me.BtnPrimero.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnModificar)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(738, 284)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 176)
        Me.Panel2.TabIndex = 66
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(66, 124)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(214, 32)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar Cliente"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(43, 74)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(253, 32)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar DatosCliente"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(66, 20)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(214, 32)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo Cliente"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblFiltrar)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.BtnFiltrar)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.TxtCodBuscar)
        Me.Panel1.Location = New System.Drawing.Point(738, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 162)
        Me.Panel1.TabIndex = 65
        '
        'LblFiltrar
        '
        Me.LblFiltrar.AutoSize = True
        Me.LblFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltrar.ForeColor = System.Drawing.Color.White
        Me.LblFiltrar.Location = New System.Drawing.Point(16, 112)
        Me.LblFiltrar.Name = "LblFiltrar"
        Me.LblFiltrar.Size = New System.Drawing.Size(63, 24)
        Me.LblFiltrar.TabIndex = 5
        Me.LblFiltrar.Text = "Filtrar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(16, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 24)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Buscar"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(85, 106)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(126, 36)
        Me.BtnFiltrar.TabIndex = 3
        Me.BtnFiltrar.Text = "..."
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(16, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Cod. Cliente:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(265, 55)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(54, 29)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtCodBuscar
        '
        Me.TxtCodBuscar.Location = New System.Drawing.Point(150, 55)
        Me.TxtCodBuscar.Name = "TxtCodBuscar"
        Me.TxtCodBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodBuscar.TabIndex = 1
        '
        'TxtCodFPago
        '
        Me.TxtCodFPago.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtCodFPago.Location = New System.Drawing.Point(256, 560)
        Me.TxtCodFPago.Name = "TxtCodFPago"
        Me.TxtCodFPago.ReadOnly = True
        Me.TxtCodFPago.Size = New System.Drawing.Size(142, 20)
        Me.TxtCodFPago.TabIndex = 64
        '
        'TxtCodBan
        '
        Me.TxtCodBan.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtCodBan.Location = New System.Drawing.Point(256, 458)
        Me.TxtCodBan.Name = "TxtCodBan"
        Me.TxtCodBan.ReadOnly = True
        Me.TxtCodBan.Size = New System.Drawing.Size(142, 20)
        Me.TxtCodBan.TabIndex = 63
        Me.TxtCodBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCodSuc
        '
        Me.TxtCodSuc.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtCodSuc.Location = New System.Drawing.Point(256, 492)
        Me.TxtCodSuc.Name = "TxtCodSuc"
        Me.TxtCodSuc.ReadOnly = True
        Me.TxtCodSuc.Size = New System.Drawing.Size(142, 20)
        Me.TxtCodSuc.TabIndex = 62
        Me.TxtCodSuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFax
        '
        Me.TxtFax.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtFax.Location = New System.Drawing.Point(256, 356)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.ReadOnly = True
        Me.TxtFax.Size = New System.Drawing.Size(142, 20)
        Me.TxtFax.TabIndex = 61
        Me.TxtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTelef
        '
        Me.TxtTelef.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtTelef.Location = New System.Drawing.Point(256, 322)
        Me.TxtTelef.Name = "TxtTelef"
        Me.TxtTelef.ReadOnly = True
        Me.TxtTelef.Size = New System.Drawing.Size(142, 20)
        Me.TxtTelef.TabIndex = 60
        Me.TxtTelef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtEmail
        '
        Me.TxtEmail.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtEmail.Location = New System.Drawing.Point(256, 390)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(142, 20)
        Me.TxtEmail.TabIndex = 59
        '
        'TxtPobl
        '
        Me.TxtPobl.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtPobl.Location = New System.Drawing.Point(256, 288)
        Me.TxtPobl.Name = "TxtPobl"
        Me.TxtPobl.ReadOnly = True
        Me.TxtPobl.Size = New System.Drawing.Size(142, 20)
        Me.TxtPobl.TabIndex = 57
        Me.TxtPobl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCodPos
        '
        Me.TxtCodPos.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtCodPos.Location = New System.Drawing.Point(256, 220)
        Me.TxtCodPos.Name = "TxtCodPos"
        Me.TxtCodPos.ReadOnly = True
        Me.TxtCodPos.Size = New System.Drawing.Size(142, 20)
        Me.TxtCodPos.TabIndex = 56
        Me.TxtCodPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDirec
        '
        Me.TxtDirec.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtDirec.Location = New System.Drawing.Point(256, 186)
        Me.TxtDirec.Name = "TxtDirec"
        Me.TxtDirec.ReadOnly = True
        Me.TxtDirec.Size = New System.Drawing.Size(142, 20)
        Me.TxtDirec.TabIndex = 55
        '
        'TxtNombre
        '
        Me.TxtNombre.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtNombre.Location = New System.Drawing.Point(256, 152)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(142, 20)
        Me.TxtNombre.TabIndex = 54
        '
        'TxtNIF
        '
        Me.TxtNIF.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtNIF.Location = New System.Drawing.Point(256, 118)
        Me.TxtNIF.Name = "TxtNIF"
        Me.TxtNIF.ReadOnly = True
        Me.TxtNIF.Size = New System.Drawing.Size(142, 20)
        Me.TxtNIF.TabIndex = 53
        '
        'TxtCodClt
        '
        Me.TxtCodClt.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodClt.Location = New System.Drawing.Point(256, 84)
        Me.TxtCodClt.Name = "TxtCodClt"
        Me.TxtCodClt.ReadOnly = True
        Me.TxtCodClt.Size = New System.Drawing.Size(142, 20)
        Me.TxtCodClt.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(45, 560)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 21)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Forma pago:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(45, 492)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 21)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Cod. Sucursal:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(45, 458)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 21)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Código Banco:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 424)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 21)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Fecha alta:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 390)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 21)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 356)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 21)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Fax:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 322)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 21)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 288)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 21)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Población:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 220)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 21)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Cod. Postal:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 21)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 21)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 21)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "NIF:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 21)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Código cliente:"
        '
        'TxtProv
        '
        Me.TxtProv.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtProv.Location = New System.Drawing.Point(256, 254)
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.ReadOnly = True
        Me.TxtProv.Size = New System.Drawing.Size(142, 20)
        Me.TxtProv.TabIndex = 71
        Me.TxtProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 254)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 21)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Provincia:"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(45, 526)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 21)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "Direc. Envio:"
        '
        'TxtDirecEnv
        '
        Me.TxtDirecEnv.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDirecEnv.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtDirecEnv.Location = New System.Drawing.Point(256, 526)
        Me.TxtDirecEnv.Name = "TxtDirecEnv"
        Me.TxtDirecEnv.Size = New System.Drawing.Size(142, 20)
        Me.TxtDirecEnv.TabIndex = 73
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.tsSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1141, 24)
        Me.MenuStrip1.TabIndex = 74
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNuevo, Me.tsModificar, Me.tsEliminar})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'tsNuevo
        '
        Me.tsNuevo.Name = "tsNuevo"
        Me.tsNuevo.Size = New System.Drawing.Size(125, 22)
        Me.tsNuevo.Text = "&Nuevo"
        '
        'tsModificar
        '
        Me.tsModificar.Name = "tsModificar"
        Me.tsModificar.Size = New System.Drawing.Size(125, 22)
        Me.tsModificar.Text = "&Modificar"
        '
        'tsEliminar
        '
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.Size = New System.Drawing.Size(125, 22)
        Me.tsEliminar.Text = "&Eliminar"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'tsSalir
        '
        Me.tsSalir.Name = "tsSalir"
        Me.tsSalir.Size = New System.Drawing.Size(41, 20)
        Me.tsSalir.Text = "&Salir"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btsPri, Me.btsAnt, Me.btsSig, Me.btsUlt, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1141, 25)
        Me.ToolStrip1.TabIndex = 75
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btsPri
        '
        Me.btsPri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btsPri.Image = CType(resources.GetObject("btsPri.Image"), System.Drawing.Image)
        Me.btsPri.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btsPri.Name = "btsPri"
        Me.btsPri.Size = New System.Drawing.Size(23, 22)
        Me.btsPri.Text = "ToolStripButton4"
        '
        'btsAnt
        '
        Me.btsAnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btsAnt.Image = CType(resources.GetObject("btsAnt.Image"), System.Drawing.Image)
        Me.btsAnt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btsAnt.Name = "btsAnt"
        Me.btsAnt.Size = New System.Drawing.Size(23, 22)
        Me.btsAnt.Text = "ToolStripButton3"
        '
        'btsSig
        '
        Me.btsSig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btsSig.Image = CType(resources.GetObject("btsSig.Image"), System.Drawing.Image)
        Me.btsSig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btsSig.Name = "btsSig"
        Me.btsSig.Size = New System.Drawing.Size(23, 22)
        Me.btsSig.Text = "ToolStripButton2"
        '
        'btsUlt
        '
        Me.btsUlt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btsUlt.Image = CType(resources.GetObject("btsUlt.Image"), System.Drawing.Image)
        Me.btsUlt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btsUlt.Name = "btsUlt"
        Me.btsUlt.Size = New System.Drawing.Size(23, 22)
        Me.btsUlt.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FrmMainClt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 790)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TxtDirecEnv)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtProv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpAlta)
        Me.Controls.Add(Me.DtgClientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtCodFPago)
        Me.Controls.Add(Me.TxtCodBan)
        Me.Controls.Add(Me.TxtCodSuc)
        Me.Controls.Add(Me.TxtFax)
        Me.Controls.Add(Me.TxtTelef)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtPobl)
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
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMainClt"
        Me.Text = "FrmMainClt"
        CType(Me.DtgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpAlta As DateTimePicker
    Friend WithEvents DtgClientes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnUltimo As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnPrimero As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblFiltrar As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtCodBuscar As TextBox
    Friend WithEvents TxtCodFPago As TextBox
    Friend WithEvents TxtCodBan As TextBox
    Friend WithEvents TxtCodSuc As TextBox
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents TxtTelef As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPobl As TextBox
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtProv As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtDirecEnv As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsNuevo As ToolStripMenuItem
    Friend WithEvents tsModificar As ToolStripMenuItem
    Friend WithEvents tsEliminar As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsSalir As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btsPri As ToolStripButton
    Friend WithEvents btsAnt As ToolStripButton
    Friend WithEvents btsSig As ToolStripButton
    Friend WithEvents btsUlt As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
