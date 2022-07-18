Public Class frm_updatestaff_a167688
    Dim current_code As String

    Private Sub frm_updatestaff_a167688_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A167688"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_phonenum.Text = ""
        txt_email.Text = ""


    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_code = grd_staff(0, current_row).Value
        txt_id.Text = current_code
        txt_name.Text = grd_staff(1, current_row).Value
        txt_email.Text = grd_staff(2, current_row).Value
        txt_phonenum.Text = grd_staff(3, current_row).Value


    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFF_A167688 SET FLD_STAFF_NAME='" &
                        txt_name.Text & "', FLD_STAFF_EMAIL='" &
                        txt_email.Text & "', FLD_STAFF_PHONE='" &
                        txt_phonenum.Text & "' WHERE FLD_STAFF_ID='" & current_code & "'")



        Beep()
        MsgBox("You have successfully updated the Staff """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A167688 WHERE FLD_STAFF_ID ='" & current_code & "'")

            Beep()

            MsgBox("The staff """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If


    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_staff_a167688.Show()
        Me.Hide()
    End Sub
    Private Sub button_refresh()

        If (txt_id.Text IsNot "" And txt_name.Text IsNot "" And txt_email IsNot "" And txt_phonenum IsNot "") Then
            btn_update.Enabled = True

        Else
            btn_update.Enabled = False
        End If
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        button_refresh()
    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged
        button_refresh()
    End Sub

    Private Sub txt_phonenum_TextChanged(sender As Object, e As EventArgs) Handles txt_phonenum.TextChanged
        button_refresh()
    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged
        button_refresh()
    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_code()
        button_refresh()
    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs) Handles btn_mainmenu.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick

    End Sub
End Class