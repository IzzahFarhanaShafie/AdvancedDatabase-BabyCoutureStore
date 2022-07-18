Public Class frm_vieworder_a167688
    Dim t As Double
    Private Sub frm_vieworder_a167688_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A167688"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cbb_orderid.DataSource = mydatatable
        cbb_orderid.DisplayMember = "FLD_ORDER_ID"

        refresh_text(cbb_orderid.Text)
        refresh_grid()
        refresh_price()
    End Sub

    Private Sub refresh_text(ByVal orderId As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A167688 WHERE FLD_ORDER_ID='" & orderId & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_customerid.Text = mydatatable.Rows(0).Item("FLD_CUST_ID")
        txt_staffid.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT FLD_PRODUCT_ID, FLD_QUANTITY, FLD_PRICE FROM TBL_ORDERDETAIL_A167688 where FLD_ORDER_ID like""%" & cbb_orderid.Text & "%"""
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_orderdetails.DataSource = mydatatable

        grd_orderdetails.Columns(0).HeaderText = "Product ID"
        grd_orderdetails.Columns(1).HeaderText = "Order Quantity"
        grd_orderdetails.Columns(2).HeaderText = "Total Price"

    End Sub

    Private Sub cbb_orderid_MouseClick(sender As System.Object, e As System.EventArgs) Handles cbb_orderid.MouseClick
        refresh_text(cbb_orderid.Text)
    End Sub

    Private Sub cbb_orderid_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbb_orderid.SelectedIndexChanged
        refresh_grid()
        lbl_orderid3.Text = cbb_orderid.Text
        refresh_price()
    End Sub

    Private Sub refresh_price()

        If grd_orderdetails.RowCount > 1 Then
            t = 0
            For index As Integer = 0 To grd_orderdetails.RowCount - 1
                t += Convert.ToDouble(grd_orderdetails.Rows(index).Cells(2).Value)
            Next
            lbl_total2.Text = "$ " & t
        ElseIf grd_orderdetails.RowCount = 1 Then
            lbl_total2.Text = "$ 0"
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        frm_makeorder_a167688.Show()

    End Sub


End Class