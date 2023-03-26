'Author: 
'Date: 
'Program description: 

Option Strict On
Option Explicit On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPoints.Text = ""
        txtPoints.Focus()
        lblPayResult.Text = ""
        rdoGourmetCheese.Checked = True
        rdoPrepay.Checked = True
        'All others set to false
        rdoFruit.Checked = False
        rdoPinwheel.Checked = False
        rdoSausandCheese.Checked = False
        rdoVeggie.Checked = False
        rdoPayPickup.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Variable declaration below
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decLoyaltyPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strLoyalty As String = ""
        Dim intLoyalty As Integer
        'loyaltypoints = txtPoints / 10 gives 5% for every 10 points
        'first group box if else statements
        If IsNumeric(txtPoints.Text) Then
            intLoyalty = Convert.ToInt32(txtPoints.Text)
            strLoyalty = " after discount of " & intLoyalty.ToString() & " loyalty points."
            'First group box radio button check and setting the cost and the output text appropriately.
            If rdoGourmetCheese.Checked = True Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf rdoPinwheel.Checked = True Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf rdoVeggie.Checked = True Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf rdoSausandCheese.Checked = True Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf rdoFruit.Checked = True Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            '2nd group box radio button check and setting output text appropriately.
            If rdoPrepay.Checked = True Then
                strPay = vbNewLine & " using Pre-Pay"
            ElseIf rdoPayPickup.Checked = True Then
                strPay = " with Pay upon Pickup"
            End If
            'This will do the calculation taking the loyalty points in and dividing them by 10 using Integer data type
            intLoyalty = Convert.ToInt32(intLoyalty / 100I)

            'This takes the newly divided number result and multiplies by the discount amount of 5 (aka 5%)
            'then divides by 100 
            decLoyaltyPoints = (intLoyalty * cdecDiscount) / 100

            If decLoyaltyPoints > 1 Then
                decLoyaltyPoints = 1
            End If
            'final calculation.  Used the round to 2 places function because it was coming over as much more sometimes
            decFinal = Math.Round(decCost * (1 - decLoyaltyPoints), 2)


            'This is where you print out all the results to the label. I have previously used + signs in my code and now seeing amper
            'sands do the same thing. Not too sure what is best practice for VB.  Moving towards this for now. 
            lblPayResult.Visible = True
            lblPayResult.Text = "Your order " & strOrder & " platter costs " & decFinal.ToString("C") & strPay & strLoyalty
        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            btnClear.PerformClick()

        End If

    End Sub
End Class
