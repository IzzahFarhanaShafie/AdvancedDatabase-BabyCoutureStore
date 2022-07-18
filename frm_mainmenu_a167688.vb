Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Baby Couture Store!")

        Dim current_date As String = Date.Now
        lbl_date.Text = current_date


    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_a167688.Show()
        Me.Hide()


    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a167688.Show()
        Me.Hide()


    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customer_a167688.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a167688.Show()
        Me.Hide()
    End Sub

    Private Sub btn_productdetails_Click(sender As Object, e As EventArgs) Handles btn_productdetails.Click
        frm_productdetails_a167688.Show()
        Me.Hide()
    End Sub
End Class
