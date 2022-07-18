Public Class frm_order_a167688
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub frm_order_a167688_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        Me.Hide()
        frm_makeorder_a167688.Show()

    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click
        Me.Hide()
        frm_vieworder_a167688.Show()


    End Sub
End Class