Public Class frm_customer_a167688
    Public Property frm_mainmenu_a167688 As Object

    Private Sub frm_customer_a167688_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A167688"

        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

        grd_customer.Columns(0).HeaderText = "CUST ID"
        grd_customer.Columns(1).HeaderText = "CUST NAME"
        grd_customer.Columns(2).HeaderText = "CUST PHONE NUMBER"
        grd_customer.Columns(3).HeaderText = "PHONE EMAIL"

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updatecustomer_a167688.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertcustomer_a167688.Show()
        Me.Hide()
    End Sub


End Class