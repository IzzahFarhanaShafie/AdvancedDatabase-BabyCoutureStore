Public Class frm_product_a167688
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub frm_product_a167688_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A167688"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable

        grd_product.Columns(0).HeaderText = "PRODUCT ID"
        grd_product.Columns(1).HeaderText = "NAME"
        grd_product.Columns(2).HeaderText = "PRICE"
        grd_product.Columns(3).HeaderText = "BRAND"
        grd_product.Columns(4).HeaderText = "TYPE"
        grd_product.Columns(5).HeaderText = "GENDER"
        grd_product.Columns(6).HeaderText = "MATERIAL"
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertproduct_a167688.Show()
        Me.Hide()
    End Sub


End Class