Imports MySql.Data.MySqlClient
Imports system.Data.SqlClient

Public Class CheckoutForm
    Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=shopdb")

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Validate inputs
        If txtCustomerID.Text = "" Or txtProductID.Text = "" Or txtQuantity.Text = "" Or txtTotal.Text = "" Or cmbPayment.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim sql As String = "INSERT INTO checkout (customer_id, product_id, quantity, total_price, payment_method, checkout_date) 
                                 VALUES (@customer_id, @product_id, @quantity, @total_price, @payment_method, NOW())"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@customer_id", txtCustomerID.Text)
            cmd.Parameters.AddWithValue("@product_id", txtProductID.Text)
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@total_price", txtTotal.Text)
            cmd.Parameters.AddWithValue("@payment_method", cmbPayment.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Checkout successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear fields after saving
            txtCustomerID.Clear()
            txtProductID.Clear()
            txtQuantity.Clear()
            txtTotal.Clear()
            cmbPayment.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
