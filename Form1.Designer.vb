<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblChinaTownStoreReceipt = New Label()
        lblQuality = New Label()
        lblAddress = New Label()
        lblClientDetails = New Label()
        lblTransactionID = New Label()
        lblReceptNo = New Label()
        lblDate = New Label()
        lblItems = New Label()
        lblQuantity = New Label()
        lblPrice = New Label()
        lblAmount = New Label()
        txtClient = New TextBox()
        lblSubTotal = New Label()
        lblVat = New Label()
        lblDiscount = New Label()
        Label4 = New Label()
        txtItem1 = New TextBox()
        txtItem2 = New TextBox()
        txtItem3 = New TextBox()
        txtItem4 = New TextBox()
        txtQty1 = New TextBox()
        txtQty2 = New TextBox()
        txtQty3 = New TextBox()
        txtQty4 = New TextBox()
        txtPrice1 = New TextBox()
        txtPrice2 = New TextBox()
        txtPrice3 = New TextBox()
        txtPrice4 = New TextBox()
        txtAmount1 = New TextBox()
        txtAmount2 = New TextBox()
        txtAmount3 = New TextBox()
        txtAmount4 = New TextBox()
        txtTransId = New TextBox()
        txtReceiptno = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        txtSubTotal = New TextBox()
        txtVat = New TextBox()
        txtDiscount = New TextBox()
        txtTamount = New TextBox()
        lblItemAdded = New Label()
        lblItemAmount = New Label()
        txtItem = New TextBox()
        txtPrice = New TextBox()
        txtReceipt = New TextBox()
        txtTotal = New TextBox()
        btnCalculate = New Button()
        btnAddItems = New Button()
        btnCompute = New Button()
        btnPrint = New Button()
        lblServedBy = New Label()
        txtServedBy = New TextBox()
        cboPaymentMethod = New ComboBox()
        lblPaymentMethod = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        SuspendLayout()
        ' 
        ' lblChinaTownStoreReceipt
        ' 
        lblChinaTownStoreReceipt.AutoSize = True
        lblChinaTownStoreReceipt.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChinaTownStoreReceipt.ForeColor = Color.SaddleBrown
        lblChinaTownStoreReceipt.Location = New Point(179, -3)
        lblChinaTownStoreReceipt.Name = "lblChinaTownStoreReceipt"
        lblChinaTownStoreReceipt.Size = New Size(574, 50)
        lblChinaTownStoreReceipt.TabIndex = 0
        lblChinaTownStoreReceipt.Text = "CHINA TOWN  STORE RECEIPT"
        ' 
        ' lblQuality
        ' 
        lblQuality.AutoSize = True
        lblQuality.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuality.ForeColor = Color.SaddleBrown
        lblQuality.Location = New Point(12, 59)
        lblQuality.Name = "lblQuality"
        lblQuality.Size = New Size(257, 21)
        lblQuality.TabIndex = 1
        lblQuality.Text = "QUALITY  IS OUR FIRST PRIORITY"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.ForeColor = Color.SaddleBrown
        lblAddress.Location = New Point(12, 80)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(153, 45)
        lblAddress.TabIndex = 2
        lblAddress.Text = "Located at Ntida Plot 211" & vbCrLf & "Tel: 0772772039 03334568" & vbCrLf & "manifestgroup@gmail.com"
        ' 
        ' lblClientDetails
        ' 
        lblClientDetails.AutoSize = True
        lblClientDetails.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblClientDetails.ForeColor = Color.SaddleBrown
        lblClientDetails.Location = New Point(12, 138)
        lblClientDetails.Name = "lblClientDetails"
        lblClientDetails.Size = New Size(78, 13)
        lblClientDetails.TabIndex = 3
        lblClientDetails.Text = "Client Details:"
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        lblTransactionID.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTransactionID.ForeColor = Color.SaddleBrown
        lblTransactionID.Location = New Point(686, 80)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(83, 13)
        lblTransactionID.TabIndex = 4
        lblTransactionID.Text = "Transaction ID:"
        ' 
        ' lblReceptNo
        ' 
        lblReceptNo.AutoSize = True
        lblReceptNo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReceptNo.ForeColor = Color.SaddleBrown
        lblReceptNo.Location = New Point(702, 112)
        lblReceptNo.Name = "lblReceptNo"
        lblReceptNo.Size = New Size(67, 13)
        lblReceptNo.TabIndex = 5
        lblReceptNo.Text = "Receipt No:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.SaddleBrown
        lblDate.Location = New Point(735, 138)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(34, 13)
        lblDate.TabIndex = 6
        lblDate.Text = "Date:"
        ' 
        ' lblItems
        ' 
        lblItems.AutoSize = True
        lblItems.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblItems.ForeColor = Color.SaddleBrown
        lblItems.Location = New Point(38, 173)
        lblItems.Name = "lblItems"
        lblItems.Size = New Size(35, 13)
        lblItems.TabIndex = 7
        lblItems.Text = "Items"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuantity.ForeColor = Color.SaddleBrown
        lblQuantity.Location = New Point(162, 173)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(52, 13)
        lblQuantity.TabIndex = 8
        lblQuantity.Text = "Quantity"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrice.ForeColor = Color.SaddleBrown
        lblPrice.Location = New Point(277, 173)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(32, 13)
        lblPrice.TabIndex = 9
        lblPrice.Text = "Price"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAmount.ForeColor = Color.SaddleBrown
        lblAmount.Location = New Point(379, 173)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(50, 13)
        lblAmount.TabIndex = 10
        lblAmount.Text = "Amount"
        ' 
        ' txtClient
        ' 
        txtClient.Location = New Point(113, 131)
        txtClient.Name = "txtClient"
        txtClient.Size = New Size(169, 23)
        txtClient.TabIndex = 11
        ' 
        ' lblSubTotal
        ' 
        lblSubTotal.AutoSize = True
        lblSubTotal.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubTotal.ForeColor = Color.SaddleBrown
        lblSubTotal.Location = New Point(322, 317)
        lblSubTotal.Name = "lblSubTotal"
        lblSubTotal.Size = New Size(55, 13)
        lblSubTotal.TabIndex = 12
        lblSubTotal.Text = "Sub Total"
        ' 
        ' lblVat
        ' 
        lblVat.AutoSize = True
        lblVat.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVat.ForeColor = Color.SaddleBrown
        lblVat.Location = New Point(327, 346)
        lblVat.Name = "lblVat"
        lblVat.Size = New Size(26, 13)
        lblVat.TabIndex = 13
        lblVat.Text = "VAT"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDiscount.ForeColor = Color.SaddleBrown
        lblDiscount.Location = New Point(324, 374)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(53, 13)
        lblDiscount.TabIndex = 14
        lblDiscount.Text = "Discount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(306, 403)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 13)
        Label4.TabIndex = 15
        Label4.Text = "Total Amount"
        ' 
        ' txtItem1
        ' 
        txtItem1.Location = New Point(12, 189)
        txtItem1.Name = "txtItem1"
        txtItem1.Size = New Size(123, 23)
        txtItem1.TabIndex = 16
        ' 
        ' txtItem2
        ' 
        txtItem2.Location = New Point(12, 218)
        txtItem2.Name = "txtItem2"
        txtItem2.Size = New Size(123, 23)
        txtItem2.TabIndex = 17
        ' 
        ' txtItem3
        ' 
        txtItem3.Location = New Point(12, 247)
        txtItem3.Name = "txtItem3"
        txtItem3.Size = New Size(123, 23)
        txtItem3.TabIndex = 18
        ' 
        ' txtItem4
        ' 
        txtItem4.Location = New Point(12, 276)
        txtItem4.Name = "txtItem4"
        txtItem4.Size = New Size(123, 23)
        txtItem4.TabIndex = 19
        ' 
        ' txtQty1
        ' 
        txtQty1.Location = New Point(152, 189)
        txtQty1.Name = "txtQty1"
        txtQty1.Size = New Size(62, 23)
        txtQty1.TabIndex = 20
        ' 
        ' txtQty2
        ' 
        txtQty2.Location = New Point(152, 218)
        txtQty2.Name = "txtQty2"
        txtQty2.Size = New Size(62, 23)
        txtQty2.TabIndex = 21
        ' 
        ' txtQty3
        ' 
        txtQty3.Location = New Point(152, 247)
        txtQty3.Name = "txtQty3"
        txtQty3.Size = New Size(62, 23)
        txtQty3.TabIndex = 22
        ' 
        ' txtQty4
        ' 
        txtQty4.Location = New Point(152, 276)
        txtQty4.Name = "txtQty4"
        txtQty4.Size = New Size(62, 23)
        txtQty4.TabIndex = 23
        ' 
        ' txtPrice1
        ' 
        txtPrice1.Location = New Point(228, 189)
        txtPrice1.Name = "txtPrice1"
        txtPrice1.Size = New Size(111, 23)
        txtPrice1.TabIndex = 24
        ' 
        ' txtPrice2
        ' 
        txtPrice2.Location = New Point(228, 218)
        txtPrice2.Name = "txtPrice2"
        txtPrice2.Size = New Size(111, 23)
        txtPrice2.TabIndex = 25
        ' 
        ' txtPrice3
        ' 
        txtPrice3.Location = New Point(231, 247)
        txtPrice3.Name = "txtPrice3"
        txtPrice3.Size = New Size(111, 23)
        txtPrice3.TabIndex = 26
        ' 
        ' txtPrice4
        ' 
        txtPrice4.Location = New Point(231, 276)
        txtPrice4.Name = "txtPrice4"
        txtPrice4.Size = New Size(111, 23)
        txtPrice4.TabIndex = 27
        ' 
        ' txtAmount1
        ' 
        txtAmount1.Location = New Point(348, 189)
        txtAmount1.Name = "txtAmount1"
        txtAmount1.Size = New Size(131, 23)
        txtAmount1.TabIndex = 28
        ' 
        ' txtAmount2
        ' 
        txtAmount2.Location = New Point(348, 218)
        txtAmount2.Name = "txtAmount2"
        txtAmount2.Size = New Size(131, 23)
        txtAmount2.TabIndex = 29
        ' 
        ' txtAmount3
        ' 
        txtAmount3.Location = New Point(348, 247)
        txtAmount3.Name = "txtAmount3"
        txtAmount3.Size = New Size(131, 23)
        txtAmount3.TabIndex = 30
        ' 
        ' txtAmount4
        ' 
        txtAmount4.Location = New Point(348, 276)
        txtAmount4.Name = "txtAmount4"
        txtAmount4.Size = New Size(131, 23)
        txtAmount4.TabIndex = 31
        ' 
        ' txtTransId
        ' 
        txtTransId.Location = New Point(776, 73)
        txtTransId.Name = "txtTransId"
        txtTransId.Size = New Size(192, 23)
        txtTransId.TabIndex = 32
        ' 
        ' txtReceiptno
        ' 
        txtReceiptno.Location = New Point(776, 102)
        txtReceiptno.Name = "txtReceiptno"
        txtReceiptno.Size = New Size(192, 23)
        txtReceiptno.TabIndex = 33
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(776, 131)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(192, 23)
        DateTimePicker1.TabIndex = 34
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.Location = New Point(390, 307)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.Size = New Size(89, 23)
        txtSubTotal.TabIndex = 35
        ' 
        ' txtVat
        ' 
        txtVat.Location = New Point(390, 335)
        txtVat.Name = "txtVat"
        txtVat.Size = New Size(89, 23)
        txtVat.TabIndex = 36
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Location = New Point(390, 364)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(89, 23)
        txtDiscount.TabIndex = 37
        ' 
        ' txtTamount
        ' 
        txtTamount.Location = New Point(390, 393)
        txtTamount.Name = "txtTamount"
        txtTamount.Size = New Size(89, 23)
        txtTamount.TabIndex = 38
        ' 
        ' lblItemAdded
        ' 
        lblItemAdded.AutoSize = True
        lblItemAdded.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblItemAdded.ForeColor = Color.SaddleBrown
        lblItemAdded.Location = New Point(718, 199)
        lblItemAdded.Name = "lblItemAdded"
        lblItemAdded.Size = New Size(68, 13)
        lblItemAdded.TabIndex = 39
        lblItemAdded.Text = "Item Added"
        ' 
        ' lblItemAmount
        ' 
        lblItemAmount.AutoSize = True
        lblItemAmount.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblItemAmount.ForeColor = Color.SaddleBrown
        lblItemAmount.Location = New Point(718, 228)
        lblItemAmount.Name = "lblItemAmount"
        lblItemAmount.Size = New Size(58, 13)
        lblItemAmount.TabIndex = 40
        lblItemAmount.Text = "Item Price"
        ' 
        ' txtItem
        ' 
        txtItem.Location = New Point(792, 189)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(176, 23)
        txtItem.TabIndex = 41
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(794, 224)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(174, 23)
        txtPrice.TabIndex = 42
        ' 
        ' txtReceipt
        ' 
        txtReceipt.Location = New Point(700, 307)
        txtReceipt.Name = "txtReceipt"
        txtReceipt.Size = New Size(268, 23)
        txtReceipt.TabIndex = 43
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(792, 346)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(176, 23)
        txtTotal.TabIndex = 44
        ' 
        ' btnCalculate
        ' 
        btnCalculate.ForeColor = Color.RoyalBlue
        btnCalculate.Location = New Point(700, 343)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(86, 26)
        btnCalculate.TabIndex = 45
        btnCalculate.Text = "Calc"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnAddItems
        ' 
        btnAddItems.ForeColor = Color.RoyalBlue
        btnAddItems.Location = New Point(744, 264)
        btnAddItems.Name = "btnAddItems"
        btnAddItems.Size = New Size(116, 26)
        btnAddItems.TabIndex = 46
        btnAddItems.Text = "Add Item"
        btnAddItems.UseVisualStyleBackColor = True
        ' 
        ' btnCompute
        ' 
        btnCompute.ForeColor = Color.RoyalBlue
        btnCompute.Location = New Point(231, 305)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(92, 31)
        btnCompute.TabIndex = 47
        btnCompute.Text = "COMPUTE"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.ForeColor = Color.RoyalBlue
        btnPrint.Location = New Point(12, 475)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(103, 39)
        btnPrint.TabIndex = 48
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' lblServedBy
        ' 
        lblServedBy.AutoSize = True
        lblServedBy.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblServedBy.ForeColor = Color.SaddleBrown
        lblServedBy.Location = New Point(719, 494)
        lblServedBy.Name = "lblServedBy"
        lblServedBy.Size = New Size(61, 13)
        lblServedBy.TabIndex = 49
        lblServedBy.Text = "Served By:"
        ' 
        ' txtServedBy
        ' 
        txtServedBy.Location = New Point(792, 484)
        txtServedBy.Name = "txtServedBy"
        txtServedBy.Size = New Size(182, 23)
        txtServedBy.TabIndex = 50
        ' 
        ' cboPaymentMethod
        ' 
        cboPaymentMethod.FormattingEnabled = True
        cboPaymentMethod.Items.AddRange(New Object() {"Cash", "Bank", "Mobile Money"})
        cboPaymentMethod.Location = New Point(786, 452)
        cboPaymentMethod.Name = "cboPaymentMethod"
        cboPaymentMethod.Size = New Size(182, 23)
        cboPaymentMethod.TabIndex = 51
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPaymentMethod.ForeColor = Color.SaddleBrown
        lblPaymentMethod.Location = New Point(679, 462)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(101, 13)
        lblPaymentMethod.TabIndex = 52
        lblPaymentMethod.Text = "Payment Method:"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(1032, 526)
        Controls.Add(lblPaymentMethod)
        Controls.Add(cboPaymentMethod)
        Controls.Add(txtServedBy)
        Controls.Add(lblServedBy)
        Controls.Add(btnPrint)
        Controls.Add(btnCompute)
        Controls.Add(btnAddItems)
        Controls.Add(btnCalculate)
        Controls.Add(txtTotal)
        Controls.Add(txtReceipt)
        Controls.Add(txtPrice)
        Controls.Add(txtItem)
        Controls.Add(lblItemAmount)
        Controls.Add(lblItemAdded)
        Controls.Add(txtTamount)
        Controls.Add(txtDiscount)
        Controls.Add(txtVat)
        Controls.Add(txtSubTotal)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtReceiptno)
        Controls.Add(txtTransId)
        Controls.Add(txtAmount4)
        Controls.Add(txtAmount3)
        Controls.Add(txtAmount2)
        Controls.Add(txtAmount1)
        Controls.Add(txtPrice4)
        Controls.Add(txtPrice3)
        Controls.Add(txtPrice2)
        Controls.Add(txtPrice1)
        Controls.Add(txtQty4)
        Controls.Add(txtQty3)
        Controls.Add(txtQty2)
        Controls.Add(txtQty1)
        Controls.Add(txtItem4)
        Controls.Add(txtItem3)
        Controls.Add(txtItem2)
        Controls.Add(txtItem1)
        Controls.Add(Label4)
        Controls.Add(lblDiscount)
        Controls.Add(lblVat)
        Controls.Add(lblSubTotal)
        Controls.Add(txtClient)
        Controls.Add(lblAmount)
        Controls.Add(lblPrice)
        Controls.Add(lblQuantity)
        Controls.Add(lblItems)
        Controls.Add(lblDate)
        Controls.Add(lblReceptNo)
        Controls.Add(lblTransactionID)
        Controls.Add(lblClientDetails)
        Controls.Add(lblAddress)
        Controls.Add(lblQuality)
        Controls.Add(lblChinaTownStoreReceipt)
        Name = "Form1"
        Text = "RECEIPT"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblChinaTownStoreReceipt As Label
    Friend WithEvents lblQuality As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblClientDetails As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents lblReceptNo As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblItems As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtClient As TextBox
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItem1 As TextBox
    Friend WithEvents txtItem2 As TextBox
    Friend WithEvents txtItem3 As TextBox
    Friend WithEvents txtItem4 As TextBox
    Friend WithEvents txtQty1 As TextBox
    Friend WithEvents txtQty2 As TextBox
    Friend WithEvents txtQty3 As TextBox
    Friend WithEvents txtQty4 As TextBox
    Friend WithEvents txtPrice1 As TextBox
    Friend WithEvents txtPrice2 As TextBox
    Friend WithEvents txtPrice3 As TextBox
    Friend WithEvents txtPrice4 As TextBox
    Friend WithEvents txtAmount1 As TextBox
    Friend WithEvents txtAmount2 As TextBox
    Friend WithEvents txtAmount3 As TextBox
    Friend WithEvents txtAmount4 As TextBox
    Friend WithEvents txtTransId As TextBox
    Friend WithEvents txtReceiptno As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtTamount As TextBox
    Friend WithEvents lblItemAdded As Label
    Friend WithEvents lblItemAmount As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtReceipt As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnAddItems As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblServedBy As Label
    Friend WithEvents txtServedBy As TextBox
    Friend WithEvents cboPaymentMethod As ComboBox
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument

End Class
