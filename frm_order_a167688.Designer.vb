<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_a167688
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_vieworder = New System.Windows.Forms.Button()
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(288, 41)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(59, 24)
        Me.lbl_title.TabIndex = 12
        Me.lbl_title.Text = "Order"
        '
        'btn_vieworder
        '
        Me.btn_vieworder.Location = New System.Drawing.Point(387, 148)
        Me.btn_vieworder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.Size = New System.Drawing.Size(116, 68)
        Me.btn_vieworder.TabIndex = 14
        Me.btn_vieworder.Text = "VIEW ORDER"
        Me.btn_vieworder.UseVisualStyleBackColor = True
        '
        'btn_makeorder
        '
        Me.btn_makeorder.Location = New System.Drawing.Point(135, 147)
        Me.btn_makeorder.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(116, 69)
        Me.btn_makeorder.TabIndex = 13
        Me.btn_makeorder.Text = "MAKE ORDER"
        Me.btn_makeorder.UseVisualStyleBackColor = True
        '
        'frm_order_a167688
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(640, 360)
        Me.Controls.Add(Me.btn_vieworder)
        Me.Controls.Add(Me.btn_makeorder)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_order_a167688"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_vieworder As Button
    Friend WithEvents btn_makeorder As Button
End Class
