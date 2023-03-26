<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.rdoGourmetCheese = New System.Windows.Forms.RadioButton()
        Me.rdoPinwheel = New System.Windows.Forms.RadioButton()
        Me.rdoVeggie = New System.Windows.Forms.RadioButton()
        Me.rdoSausandCheese = New System.Windows.Forms.RadioButton()
        Me.rdoFruit = New System.Windows.Forms.RadioButton()
        Me.grpBoxFood = New System.Windows.Forms.GroupBox()
        Me.grpBoxPay = New System.Windows.Forms.GroupBox()
        Me.rdoPayPickup = New System.Windows.Forms.RadioButton()
        Me.rdoPrepay = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPayText = New System.Windows.Forms.Label()
        Me.lblPayResult = New System.Windows.Forms.Label()
        Me.grpBoxFood.SuspendLayout()
        Me.grpBoxPay.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(62, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(114, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Catering"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.Location = New System.Drawing.Point(63, 54)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(121, 23)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Star Market"
        '
        'rdoGourmetCheese
        '
        Me.rdoGourmetCheese.AutoSize = True
        Me.rdoGourmetCheese.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoGourmetCheese.Location = New System.Drawing.Point(6, 20)
        Me.rdoGourmetCheese.Name = "rdoGourmetCheese"
        Me.rdoGourmetCheese.Size = New System.Drawing.Size(199, 23)
        Me.rdoGourmetCheese.TabIndex = 2
        Me.rdoGourmetCheese.TabStop = True
        Me.rdoGourmetCheese.Text = "Gourmet Cheese $49.99"
        Me.rdoGourmetCheese.UseVisualStyleBackColor = True
        '
        'rdoPinwheel
        '
        Me.rdoPinwheel.AutoSize = True
        Me.rdoPinwheel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPinwheel.Location = New System.Drawing.Point(6, 54)
        Me.rdoPinwheel.Name = "rdoPinwheel"
        Me.rdoPinwheel.Size = New System.Drawing.Size(194, 23)
        Me.rdoPinwheel.TabIndex = 3
        Me.rdoPinwheel.TabStop = True
        Me.rdoPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.rdoPinwheel.UseVisualStyleBackColor = True
        '
        'rdoVeggie
        '
        Me.rdoVeggie.AutoSize = True
        Me.rdoVeggie.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoVeggie.Location = New System.Drawing.Point(6, 88)
        Me.rdoVeggie.Name = "rdoVeggie"
        Me.rdoVeggie.Size = New System.Drawing.Size(130, 23)
        Me.rdoVeggie.TabIndex = 4
        Me.rdoVeggie.TabStop = True
        Me.rdoVeggie.Text = "Veggie $29.99"
        Me.rdoVeggie.UseVisualStyleBackColor = True
        '
        'rdoSausandCheese
        '
        Me.rdoSausandCheese.AutoSize = True
        Me.rdoSausandCheese.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSausandCheese.Location = New System.Drawing.Point(6, 122)
        Me.rdoSausandCheese.Name = "rdoSausandCheese"
        Me.rdoSausandCheese.Size = New System.Drawing.Size(226, 23)
        Me.rdoSausandCheese.TabIndex = 5
        Me.rdoSausandCheese.TabStop = True
        Me.rdoSausandCheese.Text = "Sausage and Cheese $49.99"
        Me.rdoSausandCheese.UseVisualStyleBackColor = True
        '
        'rdoFruit
        '
        Me.rdoFruit.AutoSize = True
        Me.rdoFruit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFruit.Location = New System.Drawing.Point(6, 156)
        Me.rdoFruit.Name = "rdoFruit"
        Me.rdoFruit.Size = New System.Drawing.Size(114, 23)
        Me.rdoFruit.TabIndex = 6
        Me.rdoFruit.TabStop = True
        Me.rdoFruit.Text = "Fruit $29.99"
        Me.rdoFruit.UseVisualStyleBackColor = True
        '
        'grpBoxFood
        '
        Me.grpBoxFood.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grpBoxFood.Controls.Add(Me.rdoGourmetCheese)
        Me.grpBoxFood.Controls.Add(Me.rdoFruit)
        Me.grpBoxFood.Controls.Add(Me.rdoPinwheel)
        Me.grpBoxFood.Controls.Add(Me.rdoSausandCheese)
        Me.grpBoxFood.Controls.Add(Me.rdoVeggie)
        Me.grpBoxFood.Location = New System.Drawing.Point(25, 100)
        Me.grpBoxFood.Name = "grpBoxFood"
        Me.grpBoxFood.Size = New System.Drawing.Size(330, 199)
        Me.grpBoxFood.TabIndex = 7
        Me.grpBoxFood.TabStop = False
        '
        'grpBoxPay
        '
        Me.grpBoxPay.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grpBoxPay.Controls.Add(Me.rdoPayPickup)
        Me.grpBoxPay.Controls.Add(Me.rdoPrepay)
        Me.grpBoxPay.Location = New System.Drawing.Point(76, 318)
        Me.grpBoxPay.Name = "grpBoxPay"
        Me.grpBoxPay.Size = New System.Drawing.Size(200, 100)
        Me.grpBoxPay.TabIndex = 8
        Me.grpBoxPay.TabStop = False
        '
        'rdoPayPickup
        '
        Me.rdoPayPickup.AutoSize = True
        Me.rdoPayPickup.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPayPickup.Location = New System.Drawing.Point(7, 58)
        Me.rdoPayPickup.Name = "rdoPayPickup"
        Me.rdoPayPickup.Size = New System.Drawing.Size(144, 23)
        Me.rdoPayPickup.TabIndex = 1
        Me.rdoPayPickup.TabStop = True
        Me.rdoPayPickup.Text = "Pay upon Pickup"
        Me.rdoPayPickup.UseVisualStyleBackColor = True
        '
        'rdoPrepay
        '
        Me.rdoPrepay.AutoSize = True
        Me.rdoPrepay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPrepay.Location = New System.Drawing.Point(7, 22)
        Me.rdoPrepay.Name = "rdoPrepay"
        Me.rdoPrepay.Size = New System.Drawing.Size(81, 23)
        Me.rdoPrepay.TabIndex = 0
        Me.rdoPrepay.TabStop = True
        Me.rdoPrepay.Text = "Pre-Pay"
        Me.rdoPrepay.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.catering_app.My.Resources.Resources.platter
        Me.PictureBox1.Location = New System.Drawing.Point(384, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(414, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(424, 306)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(124, 19)
        Me.lblPoints.TabIndex = 10
        Me.lblPoints.Text = "Loyalty Points"
        '
        'txtPoints
        '
        Me.txtPoints.Location = New System.Drawing.Point(593, 305)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(100, 20)
        Me.txtPoints.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(416, 386)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 39)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(609, 386)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 39)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPayText
        '
        Me.lblPayText.AutoSize = True
        Me.lblPayText.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayText.Location = New System.Drawing.Point(55, 496)
        Me.lblPayText.Name = "lblPayText"
        Me.lblPayText.Size = New System.Drawing.Size(118, 23)
        Me.lblPayText.TabIndex = 14
        Me.lblPayText.Text = "Please Pay:"
        '
        'lblPayResult
        '
        Me.lblPayResult.AutoSize = True
        Me.lblPayResult.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayResult.Location = New System.Drawing.Point(194, 501)
        Me.lblPayResult.Name = "lblPayResult"
        Me.lblPayResult.Size = New System.Drawing.Size(63, 19)
        Me.lblPayResult.TabIndex = 15
        Me.lblPayResult.Text = "Label1"
        Me.lblPayResult.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(810, 585)
        Me.Controls.Add(Me.lblPayResult)
        Me.Controls.Add(Me.lblPayText)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpBoxPay)
        Me.Controls.Add(Me.grpBoxFood)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        Me.grpBoxFood.ResumeLayout(False)
        Me.grpBoxFood.PerformLayout()
        Me.grpBoxPay.ResumeLayout(False)
        Me.grpBoxPay.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents rdoGourmetCheese As RadioButton
    Friend WithEvents rdoPinwheel As RadioButton
    Friend WithEvents rdoVeggie As RadioButton
    Friend WithEvents rdoSausandCheese As RadioButton
    Friend WithEvents rdoFruit As RadioButton
    Friend WithEvents grpBoxFood As GroupBox
    Friend WithEvents grpBoxPay As GroupBox
    Friend WithEvents rdoPayPickup As RadioButton
    Friend WithEvents rdoPrepay As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPoints As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPayText As Label
    Friend WithEvents lblPayResult As Label
End Class
