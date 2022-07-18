Public Class frm_productdetails_a167688
    Private Sub frm_productdetails_a169386_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_BABYCOUTURESTORE_A167688.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A167688  WHERE FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_giftsid.DataSource = mydatatable
        lst_giftsid.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_giftsid.Text)

    End Sub


    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_giftsid.MouseClick
        refresh_text(lst_giftsid.Text)

    End Sub


    Private Sub refresh_text(productid As String)
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_BABYCOUTURESTORE_A167688.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A167688 WHERE FLD_PRODUCT_ID='" & productid & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_gender.Text = mydatatable.Rows(0).Item("FLD_GENDER")
        txt_material.Text = mydatatable.Rows(0).Item("FLD_MATERIAL")
        Try
            pic_gifts.BackgroundImage = Image.FromFile("baby clothes/" & txt_id.Text & ".jpg")

        Catch ex As Exception
            pic_gifts.BackgroundImage = Image.FromFile("baby clothes/" & "0.jpg")
        End Try
    End Sub





    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_title_Click(sender As Object, e As EventArgs) Handles lbl_title.Click

    End Sub
End Class