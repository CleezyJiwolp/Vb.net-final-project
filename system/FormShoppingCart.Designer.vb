<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormShoppingCart
    Inherits system.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <system.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As system.ComponentModel.IContainer

    <system.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvProducts = New system.Windows.Forms.DataGridView()
        Me.lblProducts = New system.Windows.Forms.Label()
        Me.numQuantity = New system.Windows.Forms.NumericUpDown()
        Me.lblQuantity = New system.Windows.Forms.Label()
        Me.btnAddToCart = New system.Windows.Forms.Button()
        Me.dgvCart = New system.Windows.Forms.DataGridView()
        Me.lblCart = New system.Windows.Forms.Label()
        Me.btnRemove = New system.Windows.Forms.Button()
        Me.btnCheckout = New system.Windows.Forms.Button()
        Me.lblTotal = New system.Windows.Forms.Label()
        CType(Me.dgvProducts, system.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQuantity, system.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCart, system.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AutoSizeColumnsMode = system.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProducts.ColumnHeadersHeightSizeMode = system.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New system.Drawing.Point(20, 40)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.SelectionMode = system.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New system.Drawing.Size(600, 200)
        Me.dgvProducts.TabIndex = 0
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Location = New system.Drawing.Point(20, 20)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New system.Drawing.Size(90, 15)
        Me.lblProducts.TabIndex = 1
        Me.lblProducts.Text = "Available Products"
        '
        'numQuantity
        '
        Me.numQuantity.Location = New system.Drawing.Point(90, 260)
        Me.numQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New system.Drawing.Size(100, 23)
        Me.numQuantity.TabIndex = 2
        Me.numQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New system.Drawing.Point(20, 262)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New system.Drawing.Size(56, 15)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity:"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New system.Drawing.Point(210, 258)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New system.Drawing.Size(120, 25)
        Me.btnAddToCart.TabIndex = 4
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToDeleteRows = False
        Me.dgvCart.AutoSizeColumnsMode = system.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.ColumnHeadersHeightSizeMode = system.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Location = New system.Drawing.Point(20, 320)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.ReadOnly = True
        Me.dgvCart.SelectionMode = system.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New system.Drawing.Size(600, 180)
        Me.dgvCart.TabIndex = 5
        '
        'lblCart
        '
        Me.lblCart.AutoSize = True
        Me.lblCart.Location = New system.Drawing.Point(20, 300)
        Me.lblCart.Name = "lblCart"
        Me.lblCart.Size = New system.Drawing.Size(74, 15)
        Me.lblCart.TabIndex = 6
        Me.lblCart.Text = "Shopping Cart"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New system.Drawing.Point(20, 510)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New system.Drawing.Size(120, 25)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove Item"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New system.Drawing.Point(500, 510)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New system.Drawing.Size(120, 25)
        Me.btnCheckout.TabIndex = 8
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New system.Drawing.Font("Segoe UI", 10.0!, system.Drawing.FontStyle.Bold, system.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New system.Drawing.Point(350, 512)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New system.Drawing.Size(110, 19)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Total: ₱0.00"
        '
        'FormShoppingCart
        '
        Me.AutoScaleDimensions = New system.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = system.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New system.Drawing.Size(650, 560)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblCart)
        Me.Controls.Add(Me.dgvCart)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.numQuantity)
        Me.Controls.Add(Me.lblProducts)
        Me.Controls.Add(Me.dgvProducts)
        Me.Name = "FormShoppingCart"
        Me.Text = "Shopping Cart"
        CType(Me.dgvProducts, system.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQuantity, system.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCart, system.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents lblProducts As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents lblCart As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblTotal As Label
End Class
