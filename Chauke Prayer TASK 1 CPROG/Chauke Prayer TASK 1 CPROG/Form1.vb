Public Class Form1
    Dim totalPrice As Double = 0
    Const VAT As Double = 0.15
    Dim CountGroupB As Integer = 0


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim intAnswer As Integer
        intAnswer = MessageBox.Show("Are you sure you want to clear!", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intAnswer = DialogResult.Yes Then
            'Clears all the inputs and outputs
            txtName.Clear()
            txtSurname.Clear()
            txtEmail.Clear()
            txtContact.Clear()
            rbComputerCase.Checked = False
            rbLaptop.Checked = False
            rbMonitor.Checked = False
            rbRouter.Checked = False
            chkHDMICable.Checked = False
            chkKeyboard.Checked = False
            chkMouse.Checked = False
            chkPrinter.Checked = False
            Display.Items.Clear()
            txtName.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim intAnswer As Integer
        intAnswer = MessageBox.Show("Are you sure you want to exit!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intAnswer = DialogResult.Yes Then
            'Closes the program
            Application.Exit()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim DiscountAmount As Double

        If chkHDMICable.Checked Then CountGroupB += 1
        If chkKeyboard.Checked Then CountGroupB += 1
        If chkMouse.Checked Then CountGroupB += 1
        If chkPrinter.Checked Then CountGroupB += 1


        DiscountAmount = calcDiscount()

        Display.Items.Add("................TAKEALOT STORE.................")
        Display.Items.Add("NAME    :" & txtName.Text())
        Display.Items.Add("SURNAME :" & txtSurname.Text())
        Display.Items.Add("EMAIL   :" & txtEmail.Text())
        Display.Items.Add("CONTACT :" & txtContact.Text())
        Display.Items.Add("")
        Display.Items.Add("==============================================")
        Display.Items.Add("")
        If rbMonitor.Checked Then
            Display.Items.Add("MONITOR........................:R2 000")
        End If
        If rbLaptop.Checked Then
            Display.Items.Add("LAPTOP.........................:R5 500")
        End If
        If rbComputerCase.Checked Then
            Display.Items.Add("COMPUTER CASE..................:R3 000")
        End If
        If rbRouter.Checked Then
            Display.Items.Add("ROUTER.........................:R900")
        End If
        If chkHDMICable.Checked Then
            Display.Items.Add("HDMI CABLE.....................:R400")
        End If
        If chkKeyboard.Checked Then
            Display.Items.Add("KEYBOARD.......................:R250")
        End If
        If chkMouse.Checked Then
            Display.Items.Add("MOUSE..........................:R100")
        End If
        If chkPrinter.Checked Then
            Display.Items.Add("PRINTER........................:R1 300")
        End If

        Display.Items.Add("Sub total.......................:R" & totalAmount())
        Display.Items.Add("DISCOUNT AMAOUNT.................:R" & DiscountAmount)
        Display.Items.Add("VAT RATE..........................: R" & calcVAT())
        Display.Items.Add("TOTAL PRICE TO PAY :R" & Amount())

    End Sub
    Public Function totalAmount() As Integer

        totalPrice = 0
        'Group A items and prices
        If rbComputerCase.Checked Then totalPrice += 3000
        If rbLaptop.Checked Then totalPrice += 5500
        If rbMonitor.Checked Then totalPrice += 2000
        If rbRouter.Checked Then totalPrice += 900

        'Group B items and prices
        If chkHDMICable.Checked Then totalPrice += 400
        If chkKeyboard.Checked Then totalPrice += 250
        If chkMouse.Checked Then totalPrice += 100
        If chkPrinter.Checked Then totalPrice += 1300

        Return totalPrice
    End Function
    Private Function calcDiscount() As Integer
        ' 0 Group B = No discount
        If CountGroupB = 0 Then
            Return 0

            ' 1 Group B = 5% discount
        ElseIf CountGroupB = 1 Then
            Return totalPrice * 0.05

            ' 2 or more Group B = 15% discount
        Else
            Return totalPrice * 0.15
        End If

    End Function
    Private Function calcVAT() As Double
        ' Calculating the 15% VAT rate
        Dim VATrate As Double
        VATrate = totalPrice * 0.15
        Return VATrate
    End Function
    Private Function Amount() As Integer
        'Calculating the Final amount to be payed
        Dim Amount_to_Pay As Integer
        Amount_to_Pay = totalPrice - CountGroupB + 0.15
        Return Amount_to_Pay
    End Function
End Class
