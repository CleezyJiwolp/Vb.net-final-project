<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProducts
    Inherits system.Windows.Forms.Form

    Private components As system.ComponentModel.IContainer

    <system.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtName = New system.Windows.Forms.TextBox()
        Me.txtDescription = New system.Windows.Forms.TextBox()
        Me.txtPrice = New system.Windows.Forms.TextBox()
        Me.txtQuantity = New system.Windows.Forms.TextBox()
        Me.txtImagePath = New system.Windows.Forms.TextBox()
        Me.btnAdd = New system.Windows.Forms.Button()
        Me.btnUpdate = New system.Windows.Forms.Button()
        Me.btnDelete = New system.Windows.Forms.Button()
        Me.btnClear = New system.Windows.Forms.Button()
        Me.btnBrowse = New system.Windows.Forms.Button()
        Me.dgvProducts = New system.Windows.Forms.DataGridView()
        Me.ofdImage = New system.Windows.Forms.OpenFileDialog()
        Me.lblName = New system.Windows.Forms.Label()
        Me.lblDescription = New system.Windows.Forms.Label()
        Me.lblPrice = New system.Windows.Forms.Label()
        Me.lblQuantity = New system.Windows.Forms.Label()
        Me.lblImage = New system.Windows.Forms.Label()
        CType(Me.dgvProducts, system.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Location = New system.Drawing.Point(20, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New system.Drawing.Size(100, 20)
        Me.lblName.Text = "Product Name:"
        '
        'txtName
        '
        Me.txtName.Location = New system.Drawing.Point(20, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New system.Drawing.Size(200, 23)
        '
        'lblDescription
        '
        Me.lblDescription.Location = New system.Drawing.Point(20, 50)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New system.Drawing.Size(100, 20)
        Me.lblDescription.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New system.Drawing.Point(20, 70)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Size = New system.Drawing.Size(200, 60)
        Me.txtDescription.Name = "txtDescription"
        '
        'lblPrice
        '
        Me.lblPrice.Location = New system.Drawing.Point(20, 135)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New system.Drawing.Size(100, 20)
        Me.lblPrice.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New system.Drawing.Point(20, 155)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New system.Drawing.Size(200, 23)
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New system.Drawing.Point(20, 185)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New system.Drawing.Size(100, 20)
        Me.lblQuantity.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New system.Drawing.Point(20, 205)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New system.Drawing.Size(200, 23)
        '
        'lblImage
        '
        Me.lblImage.Location = New system.Drawing.Point(20, 235)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Size = New system.Drawing.Size(100, 20)
        Me.lblImage.Text = "Image Path:"
        '
        'txtImagePath
        '
        Me.txtImagePath.Location = New system.Drawing.Point(20, 255)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.Size = New system.Drawing.Size(200, 23)
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New system.Drawing.Point(230, 255)
        Me.btnBrowse.Text = "Browse"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New system.Drawing.Point(20, 300)
        Me.btnAdd.Text = "Add"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New system.Drawing.Point(100, 300)
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New system.Drawing.Point(180, 300)
        Me.btnDelete.Text = "Delete"
        '
        'btnClear
        '
        Me.btnClear.Location = New system.Drawing.Point(260, 300)
        Me.btnClear.Text = "Clear"
        '
        'dgvProducts
        '
        Me.dgvProducts.Location = New system.Drawing.Point(20, 340)
        Me.dgvProducts.Size = New system.Drawing.Size(550, 200)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.SelectionMode = system.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'FormProducts
        '
        Me.ClientSize = New system.Drawing.Size(600, 570)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblImage)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtImagePath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvProducts)
        Me.Name = "FormProducts"
        Me.Text = "Product Management"
        CType(Me.dgvProducts, system.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents ofdImage As OpenFileDialog
    Friend WithEvents lblName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblImage As Label
End Class
