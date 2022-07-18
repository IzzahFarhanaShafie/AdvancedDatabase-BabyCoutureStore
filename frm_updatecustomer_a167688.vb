Public Class frm_updatecustomer_a167688
    Dim current_code As String
    Private Sub frm_updatecustomer_a167688_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub



    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A167688"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable

        grd_customer.Columns(0).HeaderText = "CUST ID"
        grd_customer.Columns(1).HeaderText = "CUST NAME"
        grd_customer.Columns(2).HeaderText = "CUST EMAIL"
        grd_customer.Columns(3).HeaderText = "PHONE NUMBER"


    End Sub

    Private Sub clear_fields()

        txt_name.Text = ""
        txt_id.Text = ""
        txt_phonenum.Text = ""
        txt_email.Text = ""

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_code = grd_customer(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_customer(1, current_row).Value
        txt_phonenum.Text = grd_customer(2, current_row).Value
        txt_email.Text = grd_customer(3, current_row).Value

    End Sub



    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_CUSTOMER_A167688 SET FLD_CUST_ID='" & txt_id.Text & "' WHERE FLD_CUST_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_CUSTOMER_A167688 SET FLD_CUST_NAME='" & txt_name.Text & "' WHERE FLD_CUST_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_CUSTOMER_A167688 SET FLD_CUST_EMAIL='" & txt_email.Text & "' WHERE FLD_CUST_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_CUSTOMER_A167688 SET FLD_CUST_PHONENUM='" & txt_phonenum.Text & "' WHERE FLD_CUST_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the CUSTOMER """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the CUSTOMER """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMER_A167688 WHERE FLD_CUST_ID='" & current_code & "'")

            Beep()

            MsgBox("The CUSTOMER """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_customer_a167688.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs) Handles btn_mainmenu.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class