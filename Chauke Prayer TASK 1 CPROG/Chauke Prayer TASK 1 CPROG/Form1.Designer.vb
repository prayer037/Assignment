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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbMonitor = New System.Windows.Forms.RadioButton()
        Me.rbLaptop = New System.Windows.Forms.RadioButton()
        Me.rbRouter = New System.Windows.Forms.RadioButton()
        Me.rbComputerCase = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMouse = New System.Windows.Forms.CheckBox()
        Me.chkPrinter = New System.Windows.Forms.CheckBox()
        Me.chkKeyboard = New System.Windows.Forms.CheckBox()
        Me.chkHDMICable = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Display = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(490, 417)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(143, 32)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Promotion"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(634, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 32)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(383, 417)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 32)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMonitor)
        Me.GroupBox1.Controls.Add(Me.rbLaptop)
        Me.GroupBox1.Controls.Add(Me.rbRouter)
        Me.GroupBox1.Controls.Add(Me.rbComputerCase)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 143)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Group A Items"
        '
        'rbMonitor
        '
        Me.rbMonitor.AutoSize = True
        Me.rbMonitor.Location = New System.Drawing.Point(46, 38)
        Me.rbMonitor.Name = "rbMonitor"
        Me.rbMonitor.Size = New System.Drawing.Size(60, 17)
        Me.rbMonitor.TabIndex = 10
        Me.rbMonitor.TabStop = True
        Me.rbMonitor.Text = "Monitor"
        Me.rbMonitor.UseVisualStyleBackColor = True
        '
        'rbLaptop
        '
        Me.rbLaptop.AutoSize = True
        Me.rbLaptop.Location = New System.Drawing.Point(46, 61)
        Me.rbLaptop.Name = "rbLaptop"
        Me.rbLaptop.Size = New System.Drawing.Size(58, 17)
        Me.rbLaptop.TabIndex = 11
        Me.rbLaptop.TabStop = True
        Me.rbLaptop.Text = "Laptop"
        Me.rbLaptop.UseVisualStyleBackColor = True
        '
        'rbRouter
        '
        Me.rbRouter.AutoSize = True
        Me.rbRouter.Location = New System.Drawing.Point(46, 84)
        Me.rbRouter.Name = "rbRouter"
        Me.rbRouter.Size = New System.Drawing.Size(57, 17)
        Me.rbRouter.TabIndex = 12
        Me.rbRouter.TabStop = True
        Me.rbRouter.Text = "Router"
        Me.rbRouter.UseVisualStyleBackColor = True
        '
        'rbComputerCase
        '
        Me.rbComputerCase.AutoSize = True
        Me.rbComputerCase.Location = New System.Drawing.Point(46, 107)
        Me.rbComputerCase.Name = "rbComputerCase"
        Me.rbComputerCase.Size = New System.Drawing.Size(97, 17)
        Me.rbComputerCase.TabIndex = 13
        Me.rbComputerCase.TabStop = True
        Me.rbComputerCase.Text = "Computer Case"
        Me.rbComputerCase.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMouse)
        Me.GroupBox2.Controls.Add(Me.chkPrinter)
        Me.GroupBox2.Controls.Add(Me.chkKeyboard)
        Me.GroupBox2.Controls.Add(Me.chkHDMICable)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 129)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Group B Items"
        '
        'chkMouse
        '
        Me.chkMouse.AutoSize = True
        Me.chkMouse.Location = New System.Drawing.Point(46, 31)
        Me.chkMouse.Name = "chkMouse"
        Me.chkMouse.Size = New System.Drawing.Size(58, 17)
        Me.chkMouse.TabIndex = 9
        Me.chkMouse.Text = "Mouse"
        Me.chkMouse.UseVisualStyleBackColor = True
        '
        'chkPrinter
        '
        Me.chkPrinter.AutoSize = True
        Me.chkPrinter.Location = New System.Drawing.Point(190, 31)
        Me.chkPrinter.Name = "chkPrinter"
        Me.chkPrinter.Size = New System.Drawing.Size(56, 17)
        Me.chkPrinter.TabIndex = 10
        Me.chkPrinter.Text = "Printer"
        Me.chkPrinter.UseVisualStyleBackColor = True
        '
        'chkKeyboard
        '
        Me.chkKeyboard.AutoSize = True
        Me.chkKeyboard.Location = New System.Drawing.Point(46, 69)
        Me.chkKeyboard.Name = "chkKeyboard"
        Me.chkKeyboard.Size = New System.Drawing.Size(71, 17)
        Me.chkKeyboard.TabIndex = 11
        Me.chkKeyboard.Text = "Keyboard"
        Me.chkKeyboard.UseVisualStyleBackColor = True
        '
        'chkHDMICable
        '
        Me.chkHDMICable.AutoSize = True
        Me.chkHDMICable.Location = New System.Drawing.Point(190, 69)
        Me.chkHDMICable.Name = "chkHDMICable"
        Me.chkHDMICable.Size = New System.Drawing.Size(84, 17)
        Me.chkHDMICable.TabIndex = 12
        Me.chkHDMICable.Text = "HDMI Cable"
        Me.chkHDMICable.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Surname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Phone number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.txtContact)
        Me.GroupBox3.Controls.Add(Me.txtSurname)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(691, 100)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Details"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(394, 31)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(144, 20)
        Me.txtEmail.TabIndex = 11
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(394, 60)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(144, 20)
        Me.txtContact.TabIndex = 10
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(87, 60)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(134, 20)
        Me.txtSurname.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(87, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 20)
        Me.txtName.TabIndex = 8
        '
        'Display
        '
        Me.Display.FormattingEnabled = True
        Me.Display.Location = New System.Drawing.Point(371, 171)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(347, 225)
        Me.Display.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(20, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 42)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Takealot.com"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 525)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents chkMouse As CheckBox
    Friend WithEvents chkPrinter As CheckBox
    Friend WithEvents chkKeyboard As CheckBox
    Friend WithEvents chkHDMICable As CheckBox
    Friend WithEvents Display As ListBox
    Friend WithEvents rbMonitor As RadioButton
    Friend WithEvents rbLaptop As RadioButton
    Friend WithEvents rbRouter As RadioButton
    Friend WithEvents rbComputerCase As RadioButton
    Friend WithEvents Label5 As Label
End Class
