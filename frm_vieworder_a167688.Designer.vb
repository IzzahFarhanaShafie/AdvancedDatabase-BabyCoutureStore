<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_a167688
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
        Me.lbl_total2 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_orderid3 = New System.Windows.Forms.Label()
        Me.txt_customerid = New System.Windows.Forms.TextBox()
        Me.cbb_orderid = New System.Windows.Forms.ComboBox()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_customerid = New System.Windows.Forms.Label()
        Me.lbl_orderid2 = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.grd_orderdetails = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_total2
        '
        Me.lbl_total2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_total2.AutoSize = True
        Me.lbl_total2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total2.ForeColor = System.Drawing.Color.Teal
        Me.lbl_total2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_total2.Location = New System.Drawing.Point(524, 395)
        Me.lbl_total2.Name = "lbl_total2"
        Me.lbl_total2.Size = New System.Drawing.Size(81, 28)
        Me.lbl_total2.TabIndex = 112
        Me.lbl_total2.Text = "TOTAL"
        Me.lbl_total2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_total2.UseMnemonic = False
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_total.Location = New System.Drawing.Point(437, 395)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(81, 28)
        Me.lbl_total.TabIndex = 111
        Me.lbl_total.Text = "TOTAL"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_total.UseMnemonic = False
        '
        'lbl_orderid3
        '
        Me.lbl_orderid3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_orderid3.AutoSize = True
        Me.lbl_orderid3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid3.ForeColor = System.Drawing.Color.Teal
        Me.lbl_orderid3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_orderid3.Location = New System.Drawing.Point(278, 395)
        Me.lbl_orderid3.Name = "lbl_orderid3"
        Me.lbl_orderid3.Size = New System.Drawing.Size(127, 28)
        Me.lbl_orderid3.TabIndex = 110
        Me.lbl_orderid3.Text = "ORDER ID "
        Me.lbl_orderid3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orderid3.UseMnemonic = False
        '
        'txt_customerid
        '
        Me.txt_customerid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_customerid.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customerid.Location = New System.Drawing.Point(634, 125)
        Me.txt_customerid.Name = "txt_customerid"
        Me.txt_customerid.ReadOnly = True
        Me.txt_customerid.Size = New System.Drawing.Size(102, 21)
        Me.txt_customerid.TabIndex = 109
        '
        'cbb_orderid
        '
        Me.cbb_orderid.FormattingEnabled = True
        Me.cbb_orderid.Location = New System.Drawing.Point(164, 125)
        Me.cbb_orderid.Name = "cbb_orderid"
        Me.cbb_orderid.Size = New System.Drawing.Size(102, 21)
        Me.cbb_orderid.TabIndex = 108
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.ForeColor = System.Drawing.Color.Black
        Me.lbl_orderid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_orderid.Location = New System.Drawing.Point(59, 124)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(99, 23)
        Me.lbl_orderid.TabIndex = 107
        Me.lbl_orderid.Text = "ORDER ID "
        Me.lbl_orderid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orderid.UseMnemonic = False
        '
        'lbl_staffid
        '
        Me.lbl_staffid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.ForeColor = System.Drawing.Color.Black
        Me.lbl_staffid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_staffid.Location = New System.Drawing.Point(287, 124)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(83, 23)
        Me.lbl_staffid.TabIndex = 106
        Me.lbl_staffid.Text = "STAFF ID"
        Me.lbl_staffid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_staffid.UseMnemonic = False
        '
        'lbl_customerid
        '
        Me.lbl_customerid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_customerid.AutoSize = True
        Me.lbl_customerid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerid.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid.ForeColor = System.Drawing.Color.Black
        Me.lbl_customerid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_customerid.Location = New System.Drawing.Point(495, 124)
        Me.lbl_customerid.Name = "lbl_customerid"
        Me.lbl_customerid.Size = New System.Drawing.Size(133, 23)
        Me.lbl_customerid.TabIndex = 105
        Me.lbl_customerid.Text = "CUSTOMER ID"
        Me.lbl_customerid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_customerid.UseMnemonic = False
        '
        'lbl_orderid2
        '
        Me.lbl_orderid2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_orderid2.AutoSize = True
        Me.lbl_orderid2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid2.ForeColor = System.Drawing.Color.Black
        Me.lbl_orderid2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_orderid2.Location = New System.Drawing.Point(145, 395)
        Me.lbl_orderid2.Name = "lbl_orderid2"
        Me.lbl_orderid2.Size = New System.Drawing.Size(127, 28)
        Me.lbl_orderid2.TabIndex = 104
        Me.lbl_orderid2.Text = "ORDER ID "
        Me.lbl_orderid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orderid2.UseMnemonic = False
        '
        'txt_staffid
        '
        Me.txt_staffid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_staffid.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffid.Location = New System.Drawing.Point(376, 126)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(102, 21)
        Me.txt_staffid.TabIndex = 103
        '
        'grd_orderdetails
        '
        Me.grd_orderdetails.AllowUserToAddRows = False
        Me.grd_orderdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_orderdetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetails.Location = New System.Drawing.Point(20, 171)
        Me.grd_orderdetails.Name = "grd_orderdetails"
        Me.grd_orderdetails.ReadOnly = True
        Me.grd_orderdetails.Size = New System.Drawing.Size(760, 182)
        Me.grd_orderdetails.TabIndex = 102
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Sitka Small", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(203, 28)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(426, 71)
        Me.lbl_title.TabIndex = 101
        Me.lbl_title.Text = "ORDER DETAILS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_title.UseMnemonic = False
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(705, 402)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 113
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_vieworder_a167688
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_total2)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_orderid3)
        Me.Controls.Add(Me.txt_customerid)
        Me.Controls.Add(Me.cbb_orderid)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.lbl_customerid)
        Me.Controls.Add(Me.lbl_orderid2)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.grd_orderdetails)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_vieworder_a167688"
        Me.Text = "frm_vieworder_a167688"
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_total2 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_orderid3 As Label
    Friend WithEvents txt_customerid As TextBox
    Friend WithEvents cbb_orderid As ComboBox
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_customerid As Label
    Friend WithEvents lbl_orderid2 As Label
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents grd_orderdetails As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_back As Button
End Class
