<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a167688
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
        Me.lbl_RM = New System.Windows.Forms.Label()
        Me.lbl_total2 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_RM2 = New System.Windows.Forms.Label()
        Me.lbl_subtotal2 = New System.Windows.Forms.Label()
        Me.nud_quantity = New System.Windows.Forms.NumericUpDown()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.btn_addtocart = New System.Windows.Forms.Button()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.lbl_productid2 = New System.Windows.Forms.Label()
        Me.lbl_productid = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.grd_orderdetails = New System.Windows.Forms.DataGridView()
        Me.FLD_PRODUCT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_neworder = New System.Windows.Forms.Button()
        Me.txt_orderdate = New System.Windows.Forms.TextBox()
        Me.lbl_customerid2 = New System.Windows.Forms.Label()
        Me.lbl_orderdate = New System.Windows.Forms.Label()
        Me.lbl_customername = New System.Windows.Forms.Label()
        Me.lbl_customerid = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_orderid2 = New System.Windows.Forms.Label()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.cbb_staffid = New System.Windows.Forms.ComboBox()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_RM
        '
        Me.lbl_RM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_RM.AutoSize = True
        Me.lbl_RM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RM.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RM.ForeColor = System.Drawing.Color.Teal
        Me.lbl_RM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_RM.Location = New System.Drawing.Point(501, 537)
        Me.lbl_RM.Name = "lbl_RM"
        Me.lbl_RM.Size = New System.Drawing.Size(15, 16)
        Me.lbl_RM.TabIndex = 159
        Me.lbl_RM.Text = "$"
        Me.lbl_RM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_RM.UseMnemonic = False
        '
        'lbl_total2
        '
        Me.lbl_total2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_total2.AutoSize = True
        Me.lbl_total2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total2.ForeColor = System.Drawing.Color.Teal
        Me.lbl_total2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_total2.Location = New System.Drawing.Point(519, 537)
        Me.lbl_total2.Name = "lbl_total2"
        Me.lbl_total2.Size = New System.Drawing.Size(47, 16)
        Me.lbl_total2.TabIndex = 158
        Me.lbl_total2.Text = "TOTAL"
        Me.lbl_total2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_total2.UseMnemonic = False
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_total.Location = New System.Drawing.Point(445, 537)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(47, 16)
        Me.lbl_total.TabIndex = 155
        Me.lbl_total.Text = "TOTAL"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_total.UseMnemonic = False
        '
        'btn_invoice
        '
        Me.btn_invoice.BackColor = System.Drawing.Color.Silver
        Me.btn_invoice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.ForeColor = System.Drawing.Color.Black
        Me.btn_invoice.Location = New System.Drawing.Point(585, 556)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(110, 32)
        Me.btn_invoice.TabIndex = 157
        Me.btn_invoice.Text = "INVOICE"
        Me.btn_invoice.UseVisualStyleBackColor = False
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.Silver
        Me.btn_confirm.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.Black
        Me.btn_confirm.Location = New System.Drawing.Point(585, 521)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(110, 32)
        Me.btn_confirm.TabIndex = 156
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_brand)
        Me.GroupBox4.Controls.Add(Me.lbl_brand)
        Me.GroupBox4.Controls.Add(Me.lbl_RM2)
        Me.GroupBox4.Controls.Add(Me.lbl_subtotal2)
        Me.GroupBox4.Controls.Add(Me.nud_quantity)
        Me.GroupBox4.Controls.Add(Me.txt_material)
        Me.GroupBox4.Controls.Add(Me.txt_gender)
        Me.GroupBox4.Controls.Add(Me.txt_type)
        Me.GroupBox4.Controls.Add(Me.btn_addtocart)
        Me.GroupBox4.Controls.Add(Me.txt_price)
        Me.GroupBox4.Controls.Add(Me.txt_productname)
        Me.GroupBox4.Controls.Add(Me.lbl_subtotal)
        Me.GroupBox4.Controls.Add(Me.lbl_quantity)
        Me.GroupBox4.Controls.Add(Me.lbl_material)
        Me.GroupBox4.Controls.Add(Me.lbl_gender)
        Me.GroupBox4.Controls.Add(Me.lbl_type)
        Me.GroupBox4.Controls.Add(Me.lbl_price)
        Me.GroupBox4.Controls.Add(Me.lbl_productname)
        Me.GroupBox4.Controls.Add(Me.lbl_productid2)
        Me.GroupBox4.Controls.Add(Me.lbl_productid)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(522, 173)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(259, 342)
        Me.GroupBox4.TabIndex = 152
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Choose item(s)"
        '
        'txt_brand
        '
        Me.txt_brand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_brand.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(115, 189)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(138, 21)
        Me.txt_brand.TabIndex = 145
        '
        'lbl_brand
        '
        Me.lbl_brand.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.Color.Black
        Me.lbl_brand.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_brand.Location = New System.Drawing.Point(7, 189)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(62, 19)
        Me.lbl_brand.TabIndex = 144
        Me.lbl_brand.Text = "BRAND"
        Me.lbl_brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_brand.UseMnemonic = False
        '
        'lbl_RM2
        '
        Me.lbl_RM2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_RM2.AutoSize = True
        Me.lbl_RM2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RM2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RM2.ForeColor = System.Drawing.Color.Teal
        Me.lbl_RM2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_RM2.Location = New System.Drawing.Point(112, 255)
        Me.lbl_RM2.Name = "lbl_RM2"
        Me.lbl_RM2.Size = New System.Drawing.Size(18, 19)
        Me.lbl_RM2.TabIndex = 143
        Me.lbl_RM2.Text = "$"
        Me.lbl_RM2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_RM2.UseMnemonic = False
        '
        'lbl_subtotal2
        '
        Me.lbl_subtotal2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_subtotal2.AutoSize = True
        Me.lbl_subtotal2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtotal2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal2.ForeColor = System.Drawing.Color.Teal
        Me.lbl_subtotal2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_subtotal2.Location = New System.Drawing.Point(145, 255)
        Me.lbl_subtotal2.Name = "lbl_subtotal2"
        Me.lbl_subtotal2.Size = New System.Drawing.Size(82, 19)
        Me.lbl_subtotal2.TabIndex = 142
        Me.lbl_subtotal2.Text = "SUBTOTAL"
        Me.lbl_subtotal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_subtotal2.UseMnemonic = False
        '
        'nud_quantity
        '
        Me.nud_quantity.Location = New System.Drawing.Point(114, 225)
        Me.nud_quantity.Name = "nud_quantity"
        Me.nud_quantity.Size = New System.Drawing.Size(138, 23)
        Me.nud_quantity.TabIndex = 141
        '
        'txt_material
        '
        Me.txt_material.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_material.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_material.Location = New System.Drawing.Point(115, 164)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.ReadOnly = True
        Me.txt_material.Size = New System.Drawing.Size(138, 21)
        Me.txt_material.TabIndex = 140
        '
        'txt_gender
        '
        Me.txt_gender.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_gender.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gender.Location = New System.Drawing.Point(115, 137)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.ReadOnly = True
        Me.txt_gender.Size = New System.Drawing.Size(138, 21)
        Me.txt_gender.TabIndex = 139
        '
        'txt_type
        '
        Me.txt_type.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_type.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(115, 109)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(138, 21)
        Me.txt_type.TabIndex = 138
        '
        'btn_addtocart
        '
        Me.btn_addtocart.BackColor = System.Drawing.Color.Silver
        Me.btn_addtocart.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtocart.ForeColor = System.Drawing.Color.Black
        Me.btn_addtocart.Location = New System.Drawing.Point(74, 295)
        Me.btn_addtocart.Name = "btn_addtocart"
        Me.btn_addtocart.Size = New System.Drawing.Size(110, 32)
        Me.btn_addtocart.TabIndex = 118
        Me.btn_addtocart.Text = "ADD TO CART"
        Me.btn_addtocart.UseVisualStyleBackColor = False
        '
        'txt_price
        '
        Me.txt_price.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_price.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(115, 82)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(138, 21)
        Me.txt_price.TabIndex = 137
        '
        'txt_productname
        '
        Me.txt_productname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_productname.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productname.Location = New System.Drawing.Point(115, 55)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.ReadOnly = True
        Me.txt_productname.Size = New System.Drawing.Size(138, 21)
        Me.txt_productname.TabIndex = 128
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_subtotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_subtotal.Location = New System.Drawing.Point(7, 255)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(82, 19)
        Me.lbl_subtotal.TabIndex = 136
        Me.lbl_subtotal.Text = "SUBTOTAL"
        Me.lbl_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_subtotal.UseMnemonic = False
        '
        'lbl_quantity
        '
        Me.lbl_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.Color.Black
        Me.lbl_quantity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_quantity.Location = New System.Drawing.Point(6, 225)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(84, 19)
        Me.lbl_quantity.TabIndex = 135
        Me.lbl_quantity.Text = "QUANTITY"
        Me.lbl_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_quantity.UseMnemonic = False
        '
        'lbl_material
        '
        Me.lbl_material.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_material.AutoSize = True
        Me.lbl_material.BackColor = System.Drawing.Color.Transparent
        Me.lbl_material.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_material.ForeColor = System.Drawing.Color.Black
        Me.lbl_material.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_material.Location = New System.Drawing.Point(7, 164)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(82, 19)
        Me.lbl_material.TabIndex = 134
        Me.lbl_material.Text = "MATERIAL"
        Me.lbl_material.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_material.UseMnemonic = False
        '
        'lbl_gender
        '
        Me.lbl_gender.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.ForeColor = System.Drawing.Color.Black
        Me.lbl_gender.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_gender.Location = New System.Drawing.Point(7, 137)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(70, 19)
        Me.lbl_gender.TabIndex = 133
        Me.lbl_gender.Text = "GENDER"
        Me.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_gender.UseMnemonic = False
        '
        'lbl_type
        '
        Me.lbl_type.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.ForeColor = System.Drawing.Color.Black
        Me.lbl_type.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_type.Location = New System.Drawing.Point(7, 109)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(43, 19)
        Me.lbl_type.TabIndex = 132
        Me.lbl_type.Text = "TYPE"
        Me.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_type.UseMnemonic = False
        '
        'lbl_price
        '
        Me.lbl_price.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Black
        Me.lbl_price.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_price.Location = New System.Drawing.Point(7, 82)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(55, 19)
        Me.lbl_price.TabIndex = 131
        Me.lbl_price.Text = "PRICE "
        Me.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_price.UseMnemonic = False
        '
        'lbl_productname
        '
        Me.lbl_productname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.ForeColor = System.Drawing.Color.Black
        Me.lbl_productname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_productname.Location = New System.Drawing.Point(7, 55)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(55, 19)
        Me.lbl_productname.TabIndex = 130
        Me.lbl_productname.Text = "NAME"
        Me.lbl_productname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_productname.UseMnemonic = False
        '
        'lbl_productid2
        '
        Me.lbl_productid2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_productid2.AutoSize = True
        Me.lbl_productid2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productid2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productid2.ForeColor = System.Drawing.Color.Gray
        Me.lbl_productid2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_productid2.Location = New System.Drawing.Point(112, 30)
        Me.lbl_productid2.Name = "lbl_productid2"
        Me.lbl_productid2.Size = New System.Drawing.Size(24, 19)
        Me.lbl_productid2.TabIndex = 129
        Me.lbl_productid2.Text = "ID"
        Me.lbl_productid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_productid2.UseMnemonic = False
        '
        'lbl_productid
        '
        Me.lbl_productid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_productid.AutoSize = True
        Me.lbl_productid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productid.ForeColor = System.Drawing.Color.Black
        Me.lbl_productid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_productid.Location = New System.Drawing.Point(7, 30)
        Me.lbl_productid.Name = "lbl_productid"
        Me.lbl_productid.Size = New System.Drawing.Size(99, 19)
        Me.lbl_productid.TabIndex = 128
        Me.lbl_productid.Text = "PRODUCT ID"
        Me.lbl_productid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_productid.UseMnemonic = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_remove)
        Me.GroupBox3.Controls.Add(Me.grd_orderdetails)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 394)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(404, 194)
        Me.GroupBox3.TabIndex = 153
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item(s) on cart"
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.Silver
        Me.btn_remove.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.ForeColor = System.Drawing.Color.Black
        Me.btn_remove.Location = New System.Drawing.Point(147, 153)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(110, 32)
        Me.btn_remove.TabIndex = 122
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'grd_orderdetails
        '
        Me.grd_orderdetails.AllowUserToAddRows = False
        Me.grd_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FLD_PRODUCT_ID, Me.FLD_QUANTITY, Me.FLD_PRICE})
        Me.grd_orderdetails.Location = New System.Drawing.Point(7, 23)
        Me.grd_orderdetails.Name = "grd_orderdetails"
        Me.grd_orderdetails.ReadOnly = True
        Me.grd_orderdetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grd_orderdetails.Size = New System.Drawing.Size(391, 122)
        Me.grd_orderdetails.TabIndex = 128
        '
        'FLD_PRODUCT_ID
        '
        Me.FLD_PRODUCT_ID.HeaderText = "PRODUCT ID"
        Me.FLD_PRODUCT_ID.Name = "FLD_PRODUCT_ID"
        Me.FLD_PRODUCT_ID.ReadOnly = True
        '
        'FLD_QUANTITY
        '
        Me.FLD_QUANTITY.HeaderText = "QUANTITY"
        Me.FLD_QUANTITY.Name = "FLD_QUANTITY"
        Me.FLD_QUANTITY.ReadOnly = True
        '
        'FLD_PRICE
        '
        Me.FLD_PRICE.HeaderText = "PRICE (RM)"
        Me.FLD_PRICE.Name = "FLD_PRICE"
        Me.FLD_PRICE.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_neworder)
        Me.GroupBox2.Controls.Add(Me.txt_orderdate)
        Me.GroupBox2.Controls.Add(Me.lbl_customerid2)
        Me.GroupBox2.Controls.Add(Me.lbl_orderdate)
        Me.GroupBox2.Controls.Add(Me.lbl_customername)
        Me.GroupBox2.Controls.Add(Me.lbl_customerid)
        Me.GroupBox2.Controls.Add(Me.grd_customer)
        Me.GroupBox2.Controls.Add(Me.txt_customername)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 248)
        Me.GroupBox2.TabIndex = 154
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer informations"
        '
        'btn_neworder
        '
        Me.btn_neworder.BackColor = System.Drawing.Color.Silver
        Me.btn_neworder.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_neworder.ForeColor = System.Drawing.Color.Black
        Me.btn_neworder.Location = New System.Drawing.Point(281, 193)
        Me.btn_neworder.Name = "btn_neworder"
        Me.btn_neworder.Size = New System.Drawing.Size(110, 32)
        Me.btn_neworder.TabIndex = 122
        Me.btn_neworder.Text = "NEW ORDER"
        Me.btn_neworder.UseVisualStyleBackColor = False
        '
        'txt_orderdate
        '
        Me.txt_orderdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_orderdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderdate.Location = New System.Drawing.Point(143, 213)
        Me.txt_orderdate.Name = "txt_orderdate"
        Me.txt_orderdate.ReadOnly = True
        Me.txt_orderdate.Size = New System.Drawing.Size(132, 21)
        Me.txt_orderdate.TabIndex = 127
        '
        'lbl_customerid2
        '
        Me.lbl_customerid2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_customerid2.AutoSize = True
        Me.lbl_customerid2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerid2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid2.ForeColor = System.Drawing.Color.Gray
        Me.lbl_customerid2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_customerid2.Location = New System.Drawing.Point(139, 160)
        Me.lbl_customerid2.Name = "lbl_customerid2"
        Me.lbl_customerid2.Size = New System.Drawing.Size(24, 19)
        Me.lbl_customerid2.TabIndex = 126
        Me.lbl_customerid2.Text = "ID"
        Me.lbl_customerid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_customerid2.UseMnemonic = False
        '
        'lbl_orderdate
        '
        Me.lbl_orderdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_orderdate.AutoSize = True
        Me.lbl_orderdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderdate.ForeColor = System.Drawing.Color.Black
        Me.lbl_orderdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_orderdate.Location = New System.Drawing.Point(17, 212)
        Me.lbl_orderdate.Name = "lbl_orderdate"
        Me.lbl_orderdate.Size = New System.Drawing.Size(101, 19)
        Me.lbl_orderdate.TabIndex = 125
        Me.lbl_orderdate.Text = "ORDER DATE"
        Me.lbl_orderdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orderdate.UseMnemonic = False
        '
        'lbl_customername
        '
        Me.lbl_customername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_customername.AutoSize = True
        Me.lbl_customername.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customername.ForeColor = System.Drawing.Color.Black
        Me.lbl_customername.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_customername.Location = New System.Drawing.Point(17, 185)
        Me.lbl_customername.Name = "lbl_customername"
        Me.lbl_customername.Size = New System.Drawing.Size(55, 19)
        Me.lbl_customername.TabIndex = 124
        Me.lbl_customername.Text = "NAME"
        Me.lbl_customername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_customername.UseMnemonic = False
        '
        'lbl_customerid
        '
        Me.lbl_customerid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_customerid.AutoSize = True
        Me.lbl_customerid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid.ForeColor = System.Drawing.Color.Black
        Me.lbl_customerid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_customerid.Location = New System.Drawing.Point(17, 160)
        Me.lbl_customerid.Name = "lbl_customerid"
        Me.lbl_customerid.Size = New System.Drawing.Size(24, 19)
        Me.lbl_customerid.TabIndex = 123
        Me.lbl_customerid.Text = "ID"
        Me.lbl_customerid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_customerid.UseMnemonic = False
        '
        'grd_customer
        '
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(7, 23)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.Size = New System.Drawing.Size(391, 127)
        Me.grd_customer.TabIndex = 0
        '
        'txt_customername
        '
        Me.txt_customername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_customername.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customername.Location = New System.Drawing.Point(143, 185)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.ReadOnly = True
        Me.txt_customername.Size = New System.Drawing.Size(132, 21)
        Me.txt_customername.TabIndex = 102
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_orderid2)
        Me.GroupBox1.Controls.Add(Me.lbl_orderid)
        Me.GroupBox1.Controls.Add(Me.cbb_staffid)
        Me.GroupBox1.Controls.Add(Me.lbl_staffid)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 65)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic informations"
        '
        'lbl_orderid2
        '
        Me.lbl_orderid2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_orderid2.AutoSize = True
        Me.lbl_orderid2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid2.ForeColor = System.Drawing.Color.Gray
        Me.lbl_orderid2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_orderid2.Location = New System.Drawing.Point(288, 28)
        Me.lbl_orderid2.Name = "lbl_orderid2"
        Me.lbl_orderid2.Size = New System.Drawing.Size(24, 19)
        Me.lbl_orderid2.TabIndex = 125
        Me.lbl_orderid2.Text = "ID"
        Me.lbl_orderid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orderid2.UseMnemonic = False
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.ForeColor = System.Drawing.Color.Black
        Me.lbl_orderid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_orderid.Location = New System.Drawing.Point(204, 28)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(78, 19)
        Me.lbl_orderid.TabIndex = 124
        Me.lbl_orderid.Text = "ORDER ID"
        Me.lbl_orderid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orderid.UseMnemonic = False
        '
        'cbb_staffid
        '
        Me.cbb_staffid.FormattingEnabled = True
        Me.cbb_staffid.Location = New System.Drawing.Point(93, 25)
        Me.cbb_staffid.Name = "cbb_staffid"
        Me.cbb_staffid.Size = New System.Drawing.Size(83, 25)
        Me.cbb_staffid.TabIndex = 123
        '
        'lbl_staffid
        '
        Me.lbl_staffid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.ForeColor = System.Drawing.Color.Black
        Me.lbl_staffid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_staffid.Location = New System.Drawing.Point(17, 28)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(71, 19)
        Me.lbl_staffid.TabIndex = 122
        Me.lbl_staffid.Text = "STAFF ID"
        Me.lbl_staffid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_staffid.UseMnemonic = False
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.Control
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_product.Location = New System.Drawing.Point(582, 69)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(125, 98)
        Me.pic_product.TabIndex = 150
        Me.pic_product.TabStop = False
        '
        'lst_id
        '
        Me.lst_id.BackColor = System.Drawing.Color.White
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.Location = New System.Drawing.Point(431, 173)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(85, 342)
        Me.lst_id.TabIndex = 149
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Sitka Small", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_title.Location = New System.Drawing.Point(251, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(279, 54)
        Me.lbl_title.TabIndex = 148
        Me.lbl_title.Text = "MAKE ORDER"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_title.UseMnemonic = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 561)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 160
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_makeorder_a167688
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 607)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_RM)
        Me.Controls.Add(Me.lbl_total2)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_id)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_makeorder_a167688"
        Me.Text = "frm_makeorder_a167688"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_RM As Label
    Friend WithEvents lbl_total2 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_subtotal2 As Label
    Friend WithEvents nud_quantity As NumericUpDown
    Friend WithEvents txt_material As TextBox
    Friend WithEvents txt_gender As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents btn_addtocart As Button
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_material As Label
    Friend WithEvents lbl_gender As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_productname As Label
    Friend WithEvents lbl_productid2 As Label
    Friend WithEvents lbl_productid As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_remove As Button
    Friend WithEvents grd_orderdetails As DataGridView
    Friend WithEvents FLD_PRODUCT_ID As DataGridViewTextBoxColumn
    Friend WithEvents FLD_QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRICE As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_neworder As Button
    Friend WithEvents txt_orderdate As TextBox
    Friend WithEvents lbl_customerid2 As Label
    Friend WithEvents lbl_orderdate As Label
    Friend WithEvents lbl_customername As Label
    Friend WithEvents lbl_customerid As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents txt_customername As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_orderid2 As Label
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents cbb_staffid As ComboBox
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lst_id As ListBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_RM2 As Label
    Friend WithEvents Button1 As Button
End Class
