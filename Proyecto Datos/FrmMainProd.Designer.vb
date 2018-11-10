<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainProd
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainProd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCodProd = New System.Windows.Forms.TextBox()
        Me.TxtDescri = New System.Windows.Forms.TextBox()
        Me.TxtExist = New System.Windows.Forms.TextBox()
        Me.TxtStMin = New System.Windows.Forms.TextBox()
        Me.TxtStRep = New System.Windows.Forms.TextBox()
        Me.TxtPVP = New System.Windows.Forms.TextBox()
        Me.TxtPCM = New System.Windows.Forms.TextBox()
        Me.TxtTipoIva = New System.Windows.Forms.TextBox()
        Me.TxtCodProv = New System.Windows.Forms.TextBox()
        Me.ChkPendiente = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtCodBuscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DtgProductos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblFiltrar = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Existencias:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 199)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stock mínimo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock Reposición:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 299)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "P.V.P.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 349)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Precio Compra medio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 399)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo I.V.A.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 448)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Código de Proveedor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 498)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Pendiente:"
        '
        'TxtCodProd
        '
        Me.TxtCodProd.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodProd.Location = New System.Drawing.Point(315, 49)
        Me.TxtCodProd.Name = "TxtCodProd"
        Me.TxtCodProd.ReadOnly = True
        Me.TxtCodProd.Size = New System.Drawing.Size(100, 29)
        Me.TxtCodProd.TabIndex = 10
        '
        'TxtDescri
        '
        Me.TxtDescri.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtDescri.Location = New System.Drawing.Point(315, 97)
        Me.TxtDescri.Name = "TxtDescri"
        Me.TxtDescri.ReadOnly = True
        Me.TxtDescri.Size = New System.Drawing.Size(449, 29)
        Me.TxtDescri.TabIndex = 11
        '
        'TxtExist
        '
        Me.TxtExist.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtExist.Location = New System.Drawing.Point(315, 146)
        Me.TxtExist.Name = "TxtExist"
        Me.TxtExist.ReadOnly = True
        Me.TxtExist.Size = New System.Drawing.Size(100, 29)
        Me.TxtExist.TabIndex = 12
        Me.TxtExist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtStMin
        '
        Me.TxtStMin.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtStMin.Location = New System.Drawing.Point(315, 196)
        Me.TxtStMin.Name = "TxtStMin"
        Me.TxtStMin.ReadOnly = True
        Me.TxtStMin.Size = New System.Drawing.Size(100, 29)
        Me.TxtStMin.TabIndex = 13
        Me.TxtStMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtStRep
        '
        Me.TxtStRep.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtStRep.Location = New System.Drawing.Point(315, 246)
        Me.TxtStRep.Name = "TxtStRep"
        Me.TxtStRep.ReadOnly = True
        Me.TxtStRep.Size = New System.Drawing.Size(100, 29)
        Me.TxtStRep.TabIndex = 14
        Me.TxtStRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPVP
        '
        Me.TxtPVP.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtPVP.Location = New System.Drawing.Point(315, 298)
        Me.TxtPVP.Name = "TxtPVP"
        Me.TxtPVP.ReadOnly = True
        Me.TxtPVP.Size = New System.Drawing.Size(100, 29)
        Me.TxtPVP.TabIndex = 15
        Me.TxtPVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPCM
        '
        Me.TxtPCM.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtPCM.Location = New System.Drawing.Point(315, 346)
        Me.TxtPCM.Name = "TxtPCM"
        Me.TxtPCM.ReadOnly = True
        Me.TxtPCM.Size = New System.Drawing.Size(100, 29)
        Me.TxtPCM.TabIndex = 16
        Me.TxtPCM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTipoIva
        '
        Me.TxtTipoIva.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtTipoIva.Location = New System.Drawing.Point(315, 396)
        Me.TxtTipoIva.Name = "TxtTipoIva"
        Me.TxtTipoIva.ReadOnly = True
        Me.TxtTipoIva.Size = New System.Drawing.Size(25, 29)
        Me.TxtTipoIva.TabIndex = 17
        Me.TxtTipoIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCodProv
        '
        Me.TxtCodProv.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtCodProv.Location = New System.Drawing.Point(315, 445)
        Me.TxtCodProv.Name = "TxtCodProv"
        Me.TxtCodProv.ReadOnly = True
        Me.TxtCodProv.Size = New System.Drawing.Size(100, 29)
        Me.TxtCodProv.TabIndex = 18
        Me.TxtCodProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkPendiente
        '
        Me.ChkPendiente.AutoSize = True
        Me.ChkPendiente.Enabled = False
        Me.ChkPendiente.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ChkPendiente.Location = New System.Drawing.Point(315, 500)
        Me.ChkPendiente.Name = "ChkPendiente"
        Me.ChkPendiente.Size = New System.Drawing.Size(15, 14)
        Me.ChkPendiente.TabIndex = 19
        Me.ChkPendiente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnUltimo)
        Me.GroupBox1.Controls.Add(Me.BtnSiguiente)
        Me.GroupBox1.Controls.Add(Me.BtnAnterior)
        Me.GroupBox1.Controls.Add(Me.BtnPrimero)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(63, 545)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1111, 72)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'BtnUltimo
        '
        Me.BtnUltimo.Location = New System.Drawing.Point(868, 33)
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
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(85, 106)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(126, 36)
        Me.BtnFiltrar.TabIndex = 3
        Me.BtnFiltrar.Text = "..."
        Me.BtnFiltrar.UseVisualStyleBackColor = True
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
        Me.TxtCodBuscar.Size = New System.Drawing.Size(100, 29)
        Me.TxtCodBuscar.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(16, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Cod.Producto:"
        '
        'DtgProductos
        '
        Me.DtgProductos.AllowUserToAddRows = False
        Me.DtgProductos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DtgProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgProductos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtgProductos.Location = New System.Drawing.Point(12, 647)
        Me.DtgProductos.Name = "DtgProductos"
        Me.DtgProductos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DtgProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgProductos.RowHeadersWidth = 20
        Me.DtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgProductos.Size = New System.Drawing.Size(1135, 196)
        Me.DtgProductos.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblFiltrar)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.BtnFiltrar)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.TxtCodBuscar)
        Me.Panel1.Location = New System.Drawing.Point(809, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 162)
        Me.Panel1.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(217, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 24)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Buscar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnModificar)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(809, 249)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 176)
        Me.Panel2.TabIndex = 24
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(66, 124)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(214, 32)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar Producto"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(43, 74)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(253, 32)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar Datos Producto"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(66, 20)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(214, 32)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo Producto"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1159, 873)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DtgProductos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChkPendiente)
        Me.Controls.Add(Me.TxtCodProv)
        Me.Controls.Add(Me.TxtTipoIva)
        Me.Controls.Add(Me.TxtPCM)
        Me.Controls.Add(Me.TxtPVP)
        Me.Controls.Add(Me.TxtStRep)
        Me.Controls.Add(Me.TxtStMin)
        Me.Controls.Add(Me.TxtExist)
        Me.Controls.Add(Me.TxtDescri)
        Me.Controls.Add(Me.TxtCodProd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de productos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCodProd As TextBox
    Friend WithEvents TxtDescri As TextBox
    Friend WithEvents TxtExist As TextBox
    Friend WithEvents TxtStMin As TextBox
    Friend WithEvents TxtStRep As TextBox
    Friend WithEvents TxtPVP As TextBox
    Friend WithEvents TxtPCM As TextBox
    Friend WithEvents TxtTipoIva As TextBox
    Friend WithEvents TxtCodProv As TextBox
    Friend WithEvents ChkPendiente As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnUltimo As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnPrimero As Button
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtCodBuscar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DtgProductos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblFiltrar As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
