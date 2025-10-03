<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckoutForm
    Inherits system.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As system.ComponentModel.IContainer

    'Clean up
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Form Designer code
    Private Sub InitializeComponent()
        Me.lblCustomerID = New system.Windows.Forms.Label()
        Me.txtCustomerID = New system.Windows.Forms.TextBox()
        Me.lblProductID = New system.Windows.Forms.Label()
        Me.txtProductID = New system.Windows.Forms.TextBox()
        Me.lblQuantity = New system.Windows.Forms.Label()
        Me.txtQuantity = New system.Windows.Forms.TextBox()
        Me.lblTotal = New system.Windows.Forms.Label()
        Me.txtTotal = New system.Windows.Forms.TextBox()
        Me.lblPayment = New system.Windows.Forms.Label()
        Me.cmbPayment = New system.Windows.Forms.ComboBox()
        Me.btnCheckout = New system.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New system.Drawing.Point(30, 30)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New system.Drawing.Size(68, 15)
        Me.lblCustomerID.Text = "Customer ID"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New system.Drawing.Point(150, 27)
        Me.txtCustomerID.Size = New system.Drawing.Size(200, 23)
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New system.Drawing.Point(30, 70)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New system.Drawing.Size(62, 15)
        Me.lblProductID.Text = "Product ID"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New system.Drawing.Point(150, 67)
        Me.txtProductID.Size = New system.Drawing.Size(200, 23)
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New system.Drawing.Point(30, 110)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New system.Drawing.Size(53, 15)
        Me.lblQuantity.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New system.Drawing.Point(150, 107)
        Me.txtQuantity.Size = New system.Drawing.Size(200, 23)
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New system.Drawing.Point(30, 150)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New system.Drawing.Size(69, 15)
        Me.lblTotal.Text = "Total Price ₱"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New system.Drawing.Point(150, 147)
        Me.txtTotal.Size = New system.Drawing.Size(200, 23)
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New system.Drawing.Point(30, 190)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New system.Drawing.Size(92, 15)
        Me.lblPayment.Text = "Payment Method"
        '
        'cmbPayment
        '
        Me.cmbPayment.DropDownStyle = system.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayment.Items.AddRange(New Object() {"Cash", "GCash", "Credit Card"})
        Me.cmbPayment.Location = New system.Drawing.Point(150, 187)
        Me.cmbPayment.Size = New system.Drawing.Size(200, 23)
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New system.Drawing.Point(150, 230)
        Me.btnCheckout.Size = New system.Drawing.Size(100, 30)
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'CheckoutForm
        '
        Me.ClientSize = New system.Drawing.Size(400, 300)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.cmbPayment)
        Me.Controls.Add(Me.btnCheckout)
        Me.Name = "CheckoutForm"
        Me.Text = "Checkout Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblProductID As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents cmbPayment As ComboBox
    Friend WithEvents btnCheckout As Button
End Class
