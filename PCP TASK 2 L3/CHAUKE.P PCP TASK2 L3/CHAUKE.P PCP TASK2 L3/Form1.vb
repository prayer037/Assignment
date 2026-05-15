Imports System.IO

Public Class Form1


    ' SUB to save customer details
    Private Sub SaveCustomerDetails()

        Dim filePath As String = "C:\Principles of Computer Programming\PCP TASK 2 L3\CUSTOMER DETAILS.txt"

        ' Get values from textboxes
        Dim firstName As String
        Dim surname As String
        Dim email As String
        Dim phoneNumber As String
        Dim PhysicalAddress As String

        firstName = txtNames.Text
        surname = txtSurname.Text
        email = txtEmail.Text
        phoneNumber = mskContact.Text
        PhysicalAddress = txtAddress.Text


        ' Create line to save
        Dim customerRecord As String =
            firstName & "," &
            surname & "," &
            email & "," &
            phoneNumber

        MessageBox.Show("Customer details saved!")
        If txtNames.Text = "" Then
            MessageBox.Show("Enter Name!")
        End If
        If txtSurname.Text = "" Then
            MessageBox.Show("Enter Surname!")
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("Enter Email!")
        End If
        If txtAddress.Text = "" Then
            MessageBox.Show("Enter Address!")
        End If
        If mskContact.Text = "" Then
            MessageBox.Show("Enter Phone number!")
        End If
        ' Write to file
        Using writer As StreamWriter = New StreamWriter(filePath, True)
            writer.WriteLine(customerRecord)
        End Using

    End Sub


    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        SaveCustomerDetails()
    End Sub

    Private Sub ReadCustomersDetails()

        ' Clear existing items
        lstDisplay.Items.Clear()

        Dim filePath As String = "C:\Principles of Computer Programming\PCP TASK 2 L3\CUSTOMER DETAILS.txt"

        ' Check if file exists
        If File.Exists(filePath) Then

            ' Read all lines from file
            Dim lines() As String = File.ReadAllLines(filePath)

            ' Add each line to the ListBox
            For Each line As String In lines
                lstDisplay.Items.Add(line)
            Next

        Else
            MessageBox.Show("Customer file not found.")
        End If


    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ReadCustomersDetails()
    End Sub

    Private Sub SortCustomerFile()

        Dim filePath As String = "C:\Principles of Computer Programming\PCP TASK 2 L3\CUSTOMER DETAILS.txt"

        ' Check if file exists
        If File.Exists(filePath) Then

            ' Read all lines
            Dim lines() As String = File.ReadAllLines(filePath)

            ' Sort alphabetically
            Dim sortedLines = lines.OrderBy(Function(x) x).ToArray()

            ' Write sorted lines back to file
            File.WriteAllLines(filePath, sortedLines)

            MessageBox.Show("Customer file sorted!")

        Else
            MessageBox.Show("File not found.")
        End If

    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        SortCustomerFile()
    End Sub

    Private Sub SearchCustomer()

        Dim filePath As String = "C:\Principles of Computer Programming\PCP TASK 2 L3\CUSTOMER DETAILS.txt"
        Dim searchText As String = txtSearch.Text.ToLower()

        ' Clear previous results
        lstDisplay.Items.Clear()

        ' Check if file exists
        If File.Exists(filePath) Then

            ' Read all lines
            Dim lines() As String = File.ReadAllLines(filePath)

            ' Search through lines
            For Each line As String In lines

                If line.ToLower().Contains(searchText) Then
                    lstDisplay.Items.Add(line)
                End If

            Next

            ' If nothing found
            If lstDisplay.Items.Count = 0 Then
                MessageBox.Show("No customer found.")
            End If

        Else
            MessageBox.Show("File not found.")
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchCustomer()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim intanswer As Integer
        intanswer = MessageBox.Show("Are you sure?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intanswer = DialogResult.Yes Then
            txtNames.Clear()
            txtSurname.Clear()
            txtEmail.Clear()
            txtAddress.Clear()
            txtSearch.Clear()
            lstDisplay.Items.Clear()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim intanswer As Integer
        intanswer = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If intanswer = DialogResult.Yes Then
            'terminate the program
            Application.Exit()
        End If
    End Sub
End Class
