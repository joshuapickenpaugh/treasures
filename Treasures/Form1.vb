'Joshua Pickenpaugh
'September 30th, 2016
'Treasures Calculator

Public Class frmMain

    Dim itmCalc As New ItemCalculator()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Assigns property to text box:
        Decimal.TryParse(txtItemPrice.Text, itmCalc.ItemPrice)

        lblSubtotal.Text = itmCalc.GetSubTotal().ToString("C2")
        lblSalesTax.Text = itmCalc.GetSalesTax().ToString("C2")
        lblShipping.Text = itmCalc.GetShipping().ToString("C2")
        lblTotalDue.Text = itmCalc.TotalDue().ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the object fields, ready for new calculations:
        itmCalc.Clear()

        txtItemPrice.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblSalesTax.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTotalDue.Text = String.Empty

    End Sub

    Private Sub txtItemPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemPrice.KeyPress

        'Allows only numbers, ".", and the backspace key in the text boxes:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
