Public Class frm_staff_a167688
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub frm_staff_a167688_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A167688"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "NAME"
        grd_staff.Columns(2).HeaderText = "EMAIL"
        grd_staff.Columns(3).HeaderText = "PHONE NUMBER"

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertstaff_a167688.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updatestaff_a167688.Show()
        Me.Hide()
    End Sub
End Class