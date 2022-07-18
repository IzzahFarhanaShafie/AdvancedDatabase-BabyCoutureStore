<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomer_a167688
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_phonenum = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_phonenum = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.btn_mainmenu = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(1058, 631)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(112, 35)
        Me.btn_back.TabIndex = 25
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(876, 630)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(112, 35)
        Me.btn_delete.TabIndex = 24
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(702, 630)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(112, 35)
        Me.btn_update.TabIndex = 23
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txt_phonenum
        '
        Me.txt_phonenum.Location = New System.Drawing.Point(603, 520)
        Me.txt_phonenum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_phonenum.Name = "txt_phonenum"
        Me.txt_phonenum.Size = New System.Drawing.Size(148, 26)
        Me.txt_phonenum.TabIndex = 22
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(852, 520)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(148, 26)
        Me.txt_email.TabIndex = 21
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(373, 520)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(148, 26)
        Me.txt_name.TabIndex = 20
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(143, 520)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(148, 26)
        Me.txt_id.TabIndex = 19
        '
        'grd_customer
        '
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(143, 138)
        Me.grd_customer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.Size = New System.Drawing.Size(860, 297)
        Me.grd_customer.TabIndex = 18
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(848, 486)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(48, 20)
        Me.lbl_email.TabIndex = 17
        Me.lbl_email.Text = "Email"
        '
        'lbl_phonenum
        '
        Me.lbl_phonenum.AutoSize = True
        Me.lbl_phonenum.Location = New System.Drawing.Point(599, 486)
        Me.lbl_phonenum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_phonenum.Name = "lbl_phonenum"
        Me.lbl_phonenum.Size = New System.Drawing.Size(92, 20)
        Me.lbl_phonenum.TabIndex = 16
        Me.lbl_phonenum.Text = "Phone Num"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(368, 486)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(51, 20)
        Me.lbl_name.TabIndex = 15
        Me.lbl_name.Text = "Name"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(139, 486)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(26, 20)
        Me.lbl_id.TabIndex = 14
        Me.lbl_id.Text = "ID"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(467, 64)
        Me.lbl_customer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(243, 33)
        Me.lbl_customer.TabIndex = 13
        Me.lbl_customer.Text = "Update Customer"
        '
        'btn_mainmenu
        '
        Me.btn_mainmenu.Location = New System.Drawing.Point(1058, 571)
        Me.btn_mainmenu.Name = "btn_mainmenu"
        Me.btn_mainmenu.Size = New System.Drawing.Size(112, 40)
        Me.btn_mainmenu.TabIndex = 26
        Me.btn_mainmenu.Text = "Main Menu"
        Me.btn_mainmenu.UseVisualStyleBackColor = True
        '
        'frm_updatecustomer_a167688
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btn_mainmenu)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_phonenum)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_phonenum)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_customer)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_updatecustomer_a167688"
        Me.Text = "frm_updatecustomer_a167688"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_phonenum As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_phonenum As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_customer As Label
    Friend WithEvents btn_mainmenu As Button
End Class
