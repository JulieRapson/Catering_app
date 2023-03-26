'Author: Julie Rapson
'Date: 3/26/2023
'Program description: This app is a catering ordering app that allows for selecting of various items, selecting a payment method
'and entering loyalty points (which is the stores point system).  It will calculate what you owe based on the item you choose and 
'how many loyalty points you have. 

Option Strict On 'these options force full declaration of variables
Option Explicit On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on the form loading, we are calling the button clear click so that all the actions that we are doing for the clear
        'functionality happen here without retyping all the same items.
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear we will zap out all the text in the result label and the point box.  Set the point box to focus
        'and make sure the correct radio buttons are defaulted again .
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
        'Variable declaration below. 
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decLoyaltyPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strLoyalty As String = ""
        Dim intLoyalty As Integer
        'loyaltypoints discount gives 5% for every 100 points
        'first group box if else statements. Check if numeric and convert. set all radio button
        'selections to have the correct price.
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
            'this is strictly the pay options.
            If rdoPrepay.Checked = True Then
                strPay = vbNewLine & " using Pre-Pay"
            ElseIf rdoPayPickup.Checked = True Then
                strPay = " with Pay upon Pickup"
            End If
            'This will do the calculation taking the loyalty points in and dividing them by 100 using Integer data type
            intLoyalty = Convert.ToInt32(intLoyalty / 100I)

            'This takes the newly divided number result and multiplies by the discount amount of 5 (aka 5%)
            'then divides by 100 
            decLoyaltyPoints = (intLoyalty * cdecDiscount) / 100
            'this I saw in the video for homework basically its saying if the loyalty points are greater 1, set it to 1
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
