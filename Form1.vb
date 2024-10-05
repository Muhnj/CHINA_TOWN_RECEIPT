Imports System.Drawing.Printing
Imports System.Net.Sockets
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class Form1
    Private items As New List(Of String)()
    Private total As Decimal = 0D
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'calculate amount of each item
        Dim qty1 As Decimal = CDec(txtQty1.Text)
        Dim qty2 As Decimal = CDec(txtQty2.Text)
        Dim qty3 As Decimal = CDec(txtQty3.Text)
        Dim qty4 As Decimal = CDec(txtQty4.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim amount1 As Decimal = (qty1 * price1)
        Dim amount2 As Decimal = (qty2 * price2)
        Dim amount3 As Decimal = (qty3 * price3)
        Dim amount4 As Decimal = (qty4 * price4)
        Dim subtotal = amount1 + amount2 + amount3 + amount4
        Dim vat As Decimal = 0.18 * subtotal
        Dim discount As Decimal = 0.1 * subtotal
        Dim tamount = subtotal - discount
        'display results of the amounts vat discount and total amount textbox
        txtAmount1.Text = amount1.ToString()
        txtAmount2.Text = amount2.ToString()
        txtAmount3.Text = amount3.ToString()
        txtAmount4.Text = amount4.ToString()
        txtVat.Text = vat.ToString()
        txtSubTotal.Text = subtotal.ToString()
        txtDiscount.Text = discount.ToString()
        txtTamount.Text = tamount.ToString()
    End Sub

    Private Sub btnAddItems_Click(sender As Object, e As EventArgs) Handles btnAddItems.Click
        Dim itemName As String = txtItem.Text
        Dim itemPrice As Decimal

        If Decimal.TryParse(txtPrice.Text, itemPrice) Then
            items.Add(itemName & " - shs" & itemPrice.ToString("F2"))
            total += itemPrice

            ' Update the receipt display
            txtReceipt.Text &= itemName & " - shs" & itemPrice.ToString("F2") & Environment.NewLine
            txtTotal.Text = total.ToString("F2")

            ' Clear input fields
            txtItem.Clear()
            txtPrice.Clear()
            txtItem.Focus()
        Else
            MessageBox.Show("Please enter a valid price.")
        End If
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        MessageBox.Show("Total Amount: shs" & total.ToString("F2"))
    End Sub

    Private Sub PrintReceipt()
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument1

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument1
        txtTransId.Text = Guid.NewGuid().ToString

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Set the font and other properties
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Brown)

        ' Define the receipt content
        Dim receiptContent As String = "CHINA TOWN  STORE  RECEIPT" & Environment.NewLine &
                                    "----------------------------------------" & Environment.NewLine &
                                    " Quality as priority" & Environment.NewLine &
                                   "0772 772039 0742 226707" & Environment.NewLine &
                                   "manifestgroup@gmail.com" & Environment.NewLine &
                                   "Transaction ID: " & txtTransId.Text & Environment.NewLine &
                                   "Receipt No: " & txtReceiptno.Text & Environment.NewLine &
                                   "Date: " & DateTime.Now.ToString("dddd, d MMMM yyyy") & Environment.NewLine &
                                   "CLIENT DETAILS:" & Environment.NewLine &
                                   "Name:" & txtClient.Text & Environment.NewLine &
                                   "----------------------------------------" & Environment.NewLine &
                                   "ITEMS:" & Environment.NewLine &
                                    "1." & txtItem1.Text & "  " & txtQty1.Text & "pcs" & "  " & txtPrice1.Text & "shs" & Environment.NewLine &
                                    "2." & txtItem2.Text & "  " & txtQty2.Text & "pcs" & "  " & txtPrice2.Text & "shs" & Environment.NewLine &
                                    "3." & txtItem3.Text & "  " & txtQty3.Text & "pcs" & "  " & txtPrice3.Text & "shs" & Environment.NewLine &
                                    "4." & txtItem4.Text & "  " & txtQty4.Text & "pcs" & "  " & txtPrice4.Text & "shs" & Environment.NewLine &
                                   "----------------------------------------" & Environment.NewLine &
                                   "ADDED ITEMS:" & Environment.NewLine &
                                    "1." & txtReceipt.Text & Environment.NewLine


        receiptContent &= "----------------------------------------" & Environment.NewLine &
                          "Subtotal: " & txtSubTotal.Text & "shs" & Environment.NewLine &
                          "VAT: " & txtVat.Text & "shs" & Environment.NewLine &
                          "Discount: " & txtDiscount.Text & "shs" & Environment.NewLine &
                          "Total Amount: " & txtTamount.Text & "shs" & Environment.NewLine &
                          "----------------------------------------" & Environment.NewLine &
                          "Payment Method: " & cboPaymentMethod.Text & Environment.NewLine &
                          "Served By: " & txtServedBy.Text

        ' Print the content
        e.Graphics.DrawString(receiptContent, font, brush, 10, 10)






    End Sub

End Class