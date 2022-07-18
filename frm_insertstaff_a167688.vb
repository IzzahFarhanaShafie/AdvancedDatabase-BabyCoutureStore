Public Class frm_insertstaff_a167688
    Private Sub frm_insertstaff_a1676788_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
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
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click


        Dim mysql As String = "INSERT INTO TBL_STAFF_A167688 VALUES ('” & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_email.Text & "', '" & txt_phonenum.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            refresh_grid()
            clear_fields()

        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try



    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_staff_a167688.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs) Handles btn_mainmenu.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_title_Click(sender As Object, e As EventArgs) Handles lbl_title.Click

    End Sub

    Private Sub txt_shift_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class