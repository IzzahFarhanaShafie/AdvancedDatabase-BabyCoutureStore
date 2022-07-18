Public Class frm_makeorder_a167688
    Dim number1 As Double
    Dim c As String
    Dim duit As Double
    Dim num As Integer
    Dim current_code As String
    Dim current_code1 As String
    Dim current_code2 As String

    Private Sub frm_makeorder_a167688_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
        Dim current_date As String = Date.Now
        txt_orderdate.Text = current_date
        c = 100
        refresh_count()
        refresh_staff()
        btn_addtocart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False


        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A167688"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_id.Text)

    End Sub

    Private Sub refresh_text(product As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A167688 WHERE FLD_PRODUCT_ID='" & product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_productid2.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_productname.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_gender.Text = mydatatable.Rows(0).Item("FLD_GENDER")
        txt_material.Text = mydatatable.Rows(0).Item("FLD_MATERIAL")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        lbl_subtotal2.Text = num * txt_price.Text

        Try

            pic_product.BackgroundImage = Image.FromFile("baby clothes/" & lbl_productid2.Text & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("baby clothes/0.jpg")

        End Try
    End Sub

    Private Sub lst_id_MouseCLick(sender As System.Object, e As System.EventArgs) Handles lst_id.MouseClick
        refresh_text(lst_id.Text)
    End Sub

    Private Sub nud_quantity_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nud_quantity.ValueChanged
        num = nud_quantity.Value
        number1 = txt_price.Text()
        lbl_subtotal2.Text = num * number1
    End Sub

    Private Sub refresh_grid()
        Dim mysql2 As String = "SELECT * FROM TBL_CUSTOMER_A167688"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        grd_customer.DataSource = mydatatable2
        grd_customer.Columns(0).HeaderText = "ID"
        grd_customer.Columns(1).HeaderText = "NAME"
        grd_customer.Columns(2).HeaderText = "PHONE NO"
        grd_customer.Columns(3).HeaderText = "EMAIL"

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_code = grd_customer(0, current_row).Value
        lbl_customerid2.Text = current_code
        txt_customername.Text = grd_customer(1, current_row).Value
    End Sub

    Private Sub grd_customer_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_code()
    End Sub

    Private Sub refresh_staff()

        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A167688"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cbb_staffid.DataSource = mydatatable
        cbb_staffid.DisplayMember = "FLD_STAFF_ID"

    End Sub

    Private Sub refresh_count()

        Dim count As Integer = 1
        Dim mysql As String = "SELECT COUNT (FLD_ORDER_ID) As count_id FROM TBL_ORDER_A167688"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        count += mydatatable.Rows(0).Item("count_id")
        lbl_orderid2.Text = "D" + count.ToString("000")

    End Sub


    Private Sub btn_neworder_Click(sender As System.Object, e As System.EventArgs) Handles btn_neworder.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try

            Dim mysql As String = "INSERT INTO TBL_ORDER_A167688 (FLD_ORDER_ID, FLD_ORDER_DATE, FLD_CUST_ID, FLD_STAFF_ID) values (""" &
            lbl_orderid2.Text & """,""" & txt_orderdate.Text & """,""" & lbl_customerid2.Text & """,""" & cbb_staffid.Text & """)"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("You can make new order now!")
            refresh_grid()
            grd_orderdetails.Rows.Clear()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addtocart.Enabled = True
        btn_confirm.Enabled = True
        btn_remove.Enabled = True
        btn_neworder.Enabled = False

    End Sub

    Private Sub btn_addtocart_Click(sender As System.Object, e As System.EventArgs) Handles btn_addtocart.Click
        grd_orderdetails.Rows.Add(New String() {lbl_productid2.Text, nud_quantity.Value, lbl_subtotal2.Text})
        lbl_subtotal2.Text = ""
        nud_quantity.Value = 0
        lbl_total2.Text = ""
        refresh_price()
    End Sub

    Private Sub refresh_price()

        If grd_orderdetails.RowCount > 0 Then
            duit = 0

            For index As Integer = 0 To grd_orderdetails.RowCount - 1
                duit += Convert.ToDouble(grd_orderdetails.Rows(index).Cells(2).Value)
            Next

            lbl_total2.Text = duit

        ElseIf grd_orderdetails.RowCount = 1 Then

            lbl_total2.Text = "RM 0"

        End If

    End Sub

    Private Sub btn_remove_Click(sender As System.Object, e As System.EventArgs) Handles btn_remove.Click
        Dim delete_order = MsgBox("Confirm to delete this item from list?", MsgBoxStyle.YesNo)

        If delete_order = MsgBoxResult.Yes Then
            grd_orderdetails.Rows.Remove(grd_orderdetails.CurrentRow)
            refresh_price()
        Else
            refresh_price()
        End If
    End Sub

    Private Sub btn_confirm_Click(sender As System.Object, e As System.EventArgs) Handles btn_confirm.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction
        Try
            For i As Integer = 0 To grd_orderdetails.RowCount - 1
                Dim productid As String = grd_orderdetails(0, i).Value
                Dim quantity As String = grd_orderdetails(1, i).Value
                Dim price As String = grd_orderdetails(2, i).Value

                Dim mysql As String = "insert into TBL_ORDERDETAIL_A167688 (FLD_ORDER_ID, FLD_PRODUCT_ID, FLD_QUANTITY, FLD_PRICE) values (""" & lbl_orderid2.Text & """,""" & productid & """, """ & quantity & """, """ & price & """)"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)


                mywriter.ExecuteNonQuery()

            Next
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Transaction successful!")
            refresh_grid()
            grd_orderdetails.Rows.Clear()

        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addtocart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False
        btn_neworder.Enabled = True
        nud_quantity.Value = 0
        lbl_total2.Text = "0"
        refresh_count()
    End Sub

    Private Sub btn_invoice_Click(sender As System.Object, e As System.EventArgs) Handles btn_invoice.Click
        frm_vieworder_a167688.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frm_order_a167688.Show()
    End Sub
End Class