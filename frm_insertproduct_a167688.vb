Public Class frm_insertproduct_a167688
    Dim defaultpicture As String = Application.StartupPath & "\pictures\0.jpg"
    Dim current_code As String

    Private Sub frm_insertproducts_a167688_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_A167688")
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile("baby clothes/0.jpg")
        refresh_grid()
        get_current_code()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A167688"

        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable

        grd_products.Columns(0).HeaderText = "PRODUCT ID"
        grd_products.Columns(1).HeaderText = "NAME"
        grd_products.Columns(2).HeaderText = "PRICE"
        grd_products.Columns(3).HeaderText = "BRAND"
        grd_products.Columns(4).HeaderText = "TYPE"
        grd_products.Columns(5).HeaderText = "GENDER"
        grd_products.Columns(6).HeaderText = "MATERIAL"
    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_code = grd_products(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_brand.Text = grd_products(3, current_row).Value
        txt_type.Text = grd_products(4, current_row).Value
        txt_gender.Text = grd_products(5, current_row).Value
        txt_material.Text = grd_products(6, current_row).Value

    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_type.Text = ""
        txt_gender.Text = ""
        txt_material.Text = ""

    End Sub


    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCT_A167688 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "' , '" & txt_brand.Text & " ',  '" & txt_type.Text & "', '" & txt_gender.Text & "' , '" & txt_material.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "baby clothes\" & txt_id.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_A167688")

            txt_id.Text = " "
            txt_name.Text = ""
            txt_price.Text = ""
            txt_brand.Text = " "
            txt_type.Text = ""
            txt_gender.Text = ""
            txt_material.Text = " "

            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile("baby clothes/0.jpg")

        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName




        Catch ex As Exception
            Beep()
            MessageBox.Show("Please select a valid file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_PRODUCT_A167688 SET FLD_PRODUCT_NAME='" &
                        txt_name.Text & "', FLD_PRICE='" &
                        txt_price.Text & "', FLD_TYPE='" &
                        txt_type.Text & "', FLD_GENDER='" &
                        txt_gender.Text & "', FLD_MATERIAL='" &
                        txt_material.Text & "', FLD_BRAND='" &
                        txt_brand.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the products """ & current_code & ".")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub button_refresh()

        If (txt_name.Text IsNot "" And txt_price.Text IsNot "" And txt_brand IsNot "" And txt_type IsNot "" And txt_gender IsNot "" And txt_material IsNot "" And txt_id IsNot "") Then
            btn_update.Enabled = True

        Else
            btn_update.Enabled = False
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCT_A167688 WHERE FLD_PRODUCT_ID='" & current_code & "'")

            Beep()

            MsgBox("The Products """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_product_a167688.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs) Handles btn_mainmenu.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        button_refresh()
    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged
        button_refresh()
    End Sub

    Private Sub txt_price_TextChanged(sender As Object, e As EventArgs) Handles txt_price.TextChanged
        button_refresh()
    End Sub

    Private Sub txt_brand_TextChanged(sender As Object, e As EventArgs) Handles txt_brand.TextChanged
        button_refresh()
    End Sub

    Private Sub txt_type_TextChanged(sender As Object, e As EventArgs) Handles txt_type.TextChanged
        button_refresh()
    End Sub

    Private Sub txt_gender_TextChanged(sender As Object, e As EventArgs) Handles txt_gender.TextChanged
        button_refresh()
    End Sub

    Private Sub txt_material_TextChanged(sender As Object, e As EventArgs) Handles txt_material.TextChanged
        button_refresh()
    End Sub

    Private Sub grd_products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellContentClick
        get_current_code()
    End Sub
End Class