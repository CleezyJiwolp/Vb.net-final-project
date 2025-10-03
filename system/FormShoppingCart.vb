Imports MySql.Data.MySqlClient
Imports system.Data.SqlClient

Public Class FormShoppingCart
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=shop_db")

    Private Sub FormShoppingCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        LoadCart()
    End Sub

    Private Sub LoadProducts()
        Dim query As String = "SELECT product_id, name, price, quantity FROM products"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        dgvProducts.DataSource = dt
    End Sub

    Private Sub LoadCart()
        Dim query As String = "SELECT c.cart_id, p.name, c.quantity, c.total_price 
                               FROM cart c 
                               JOIN products p ON c.product_id = p.product_id"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        dgvCart.DataSource = dt

        ' Calculate total
        Dim total As Decimal = 0
        For Each row As DataRow In dt.Rows
            total += Convert.ToDecimal(row("total_price"))
        Next
        lblTotal.Text = "Total: ₱" & total.ToString("N2")
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product")
            Return
        End If

        Dim productId As Integer = dgvProducts.SelectedRows(0).Cells("product_id").Value
        Dim price As Decimal = dgvProducts.SelectedRows(0).Cells("price").Value
        Dim quantity As Integer = numQuantity.Value

        If quantity <= 0 Then
            MessageBox.Show("Quantity must be greater than 0")
            Return
        End If

        Dim totalPrice As Decimal = price * quantity

        Dim query As String = "INSERT INTO cart (product_id, quantity, total_price) 
                               VALUES (@pid, @qty, @total)"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@pid", productId)
            cmd.Parameters.AddWithValue("@qty", quantity)
            cmd.Parameters.AddWithValue("@total", totalPrice)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using

        LoadCart()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvCart.SelectedRows.Count = 0 Then
            MessageBox.Show("Select an item to remove")
            Return
        End If

        Dim cartId As Integer = dgvCart.SelectedRows(0).Cells("cart_id").Value
        Dim query As String = "DELETE FROM cart WHERE cart_id=@id"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", cartId)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using

        LoadCart()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        MessageBox.Show("Checkout successful! Thank you for your purchase.")
        ' Clear the cart
        Dim query As String = "DELETE FROM cart"
        Using cmd As New MySqlCommand(query, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
        LoadCart()
    End Sub
End Class
