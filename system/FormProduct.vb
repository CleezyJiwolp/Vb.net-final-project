Imports MySql.Data.MySqlClient
Imports system.Data.SqlClient

Public Class FormProducts
    Private connString As String = "server=127.0.0.1;userid=root;password=;database=shop_db;SslMode=none"
    Private selectedProductId As Integer = -1

    Private Sub FormProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub LoadProducts()
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim sql As String = "SELECT id, name, description, price, quantity, image_path FROM products ORDER BY id DESC"
                Dim cmd As New MySqlCommand(sql, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvProducts.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading products: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ClearFields()
        txtName.Text = ""
        txtDescription.Text = ""
        txtPrice.Text = ""
        txtQuantity.Text = ""
        txtImagePath.Text = ""
        selectedProductId = -1
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Product name is required.")
            Return False
        End If
        Dim priceVal As Decimal
        If Not Decimal.TryParse(txtPrice.Text, priceVal) Then
            MessageBox.Show("Price must be numeric.")
            Return False
        End If
        Dim qtyVal As Integer
        If Not Integer.TryParse(txtQuantity.Text, qtyVal) Then
            MessageBox.Show("Quantity must be an integer.")
            Return False
        End If
        Return True
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateInputs() Then Return
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO products (name, description, price, quantity, image_path) VALUES (@name, @desc, @price, @qty, @img)"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim())
                cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text))
                cmd.Parameters.AddWithValue("@qty", Integer.Parse(txtQuantity.Text))
                cmd.Parameters.AddWithValue("@img", txtImagePath.Text.Trim())
                cmd.ExecuteNonQuery()
                MessageBox.Show("Product added successfully.")
                LoadProducts()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error adding product: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedProductId = -1 Then
            MessageBox.Show("No product selected.")
            Return
        End If
        If Not ValidateInputs() Then Return
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim sql As String = "UPDATE products SET name=@name, description=@desc, price=@price, quantity=@qty, image_path=@img WHERE id=@id"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim())
                cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text))
                cmd.Parameters.AddWithValue("@qty", Integer.Parse(txtQuantity.Text))
                cmd.Parameters.AddWithValue("@img", txtImagePath.Text.Trim())
                cmd.Parameters.AddWithValue("@id", selectedProductId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Product updated successfully.")
                LoadProducts()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error updating product: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedProductId = -1 Then
            MessageBox.Show("No product selected.")
            Return
        End If
        If MessageBox.Show("Delete this product?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim sql As String = "DELETE FROM products WHERE id=@id"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", selectedProductId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Product deleted.")
                LoadProducts()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvProducts.Rows(e.RowIndex)
        selectedProductId = Convert.ToInt32(row.Cells("id").Value)
        txtName.Text = row.Cells("name").Value.ToString()
        txtDescription.Text = row.Cells("description").Value.ToString()
        txtPrice.Text = row.Cells("price").Value.ToString()
        txtQuantity.Text = row.Cells("quantity").Value.ToString()
        txtImagePath.Text = row.Cells("image_path").Value.ToString()
        btnAdd.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If ofdImage.ShowDialog() = DialogResult.OK Then
            txtImagePath.Text = ofdImage.FileName
        End If
    End Sub
End Class
