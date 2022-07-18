<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a167688
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
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_notes = New System.Windows.Forms.Label()
        Me.lbl_group = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_productid = New System.Windows.Forms.Label()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_mainmenu = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(808, 611)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(119, 38)
        Me.btn_insert.TabIndex = 0
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(1040, 552)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(112, 35)
        Me.btn_back.TabIndex = 1
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_material
        '
        Me.txt_material.Location = New System.Drawing.Point(328, 543)
        Me.txt_material.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(148, 26)
        Me.txt_material.TabIndex = 29
        '
        'txt_gender
        '
        Me.txt_gender.Location = New System.Drawing.Point(117, 543)
        Me.txt_gender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.Size = New System.Drawing.Size(148, 26)
        Me.txt_gender.TabIndex = 28
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(548, 542)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(148, 26)
        Me.txt_type.TabIndex = 27
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(758, 453)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(148, 26)
        Me.txt_brand.TabIndex = 26
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(544, 453)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(148, 26)
        Me.txt_price.TabIndex = 25
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(327, 453)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(148, 26)
        Me.txt_name.TabIndex = 24
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(117, 453)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(148, 26)
        Me.txt_id.TabIndex = 23
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Location = New System.Drawing.Point(323, 519)
        Me.lbl_quantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(65, 20)
        Me.lbl_quantity.TabIndex = 22
        Me.lbl_quantity.Text = "Material"
        '
        'lbl_notes
        '
        Me.lbl_notes.AutoSize = True
        Me.lbl_notes.Location = New System.Drawing.Point(117, 519)
        Me.lbl_notes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_notes.Name = "lbl_notes"
        Me.lbl_notes.Size = New System.Drawing.Size(63, 20)
        Me.lbl_notes.TabIndex = 21
        Me.lbl_notes.Text = "Gender"
        '
        'lbl_group
        '
        Me.lbl_group.AutoSize = True
        Me.lbl_group.Location = New System.Drawing.Point(544, 519)
        Me.lbl_group.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_group.Name = "lbl_group"
        Me.lbl_group.Size = New System.Drawing.Size(43, 20)
        Me.lbl_group.TabIndex = 20
        Me.lbl_group.Text = "Type"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.Location = New System.Drawing.Point(754, 429)
        Me.lbl_brand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(52, 20)
        Me.lbl_brand.TabIndex = 19
        Me.lbl_brand.Text = "Brand"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(539, 429)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(44, 20)
        Me.lbl_price.TabIndex = 18
        Me.lbl_price.Text = "Price"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(322, 429)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(55, 20)
        Me.lbl_name.TabIndex = 17
        Me.lbl_name.Text = " Name"
        '
        'lbl_productid
        '
        Me.lbl_productid.AutoSize = True
        Me.lbl_productid.Location = New System.Drawing.Point(117, 429)
        Me.lbl_productid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_productid.Name = "lbl_productid"
        Me.lbl_productid.Size = New System.Drawing.Size(30, 20)
        Me.lbl_productid.TabIndex = 16
        Me.lbl_productid.Text = " ID"
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(986, 345)
        Me.btn_picture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(170, 35)
        Me.btn_picture.TabIndex = 34
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(1005, 305)
        Me.txt_picture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(148, 26)
        Me.txt_picture.TabIndex = 33
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(1005, 125)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(150, 169)
        Me.pic_product.TabIndex = 32
        Me.pic_product.TabStop = False
        '
        'grd_products
        '
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(57, 125)
        Me.grd_products.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.Size = New System.Drawing.Size(870, 252)
        Me.grd_products.TabIndex = 31
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(435, 54)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(277, 33)
        Me.lbl_title.TabIndex = 30
        Me.lbl_title.Text = "Insert New Products"
        '
        'btn_mainmenu
        '
        Me.btn_mainmenu.Location = New System.Drawing.Point(1041, 611)
        Me.btn_mainmenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mainmenu.Name = "btn_mainmenu"
        Me.btn_mainmenu.Size = New System.Drawing.Size(111, 38)
        Me.btn_mainmenu.TabIndex = 35
        Me.btn_mainmenu.Text = "Main Menu"
        Me.btn_mainmenu.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(616, 613)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(112, 35)
        Me.btn_delete.TabIndex = 38
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(418, 613)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(112, 35)
        Me.btn_update.TabIndex = 37
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'frm_insertproduct_a167688
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_mainmenu)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.txt_gender)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_notes)
        Me.Controls.Add(Me.lbl_group)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_productid)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_insert)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_insertproduct_a167688"
        Me.Text = "frm_insertproduct_a167688"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_material As TextBox
    Friend WithEvents txt_gender As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_notes As Label
    Friend WithEvents lbl_group As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_productid As Label
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_mainmenu As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
End Class
