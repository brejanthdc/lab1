Public Class Lab1
    'Lab 1: Average Units Shipped
    'By: Brejanth Rajendran
    'Date:2/6/2018
    'Description: User will add each days total shipping units for a week and get an average units sold per day


    Dim output As String = String.Empty 'This variable is used to store the validated user input and creat a giant list
    Dim userInput As String = String.Empty 'This variable is used to inital user input before it is validated

    Const TOTAL_DAYS As Integer = 7 'This constant variable is the maximum days in a week
    Const MAXIMUM_UNITS_SOLD As Integer = 1000 'This constant variable is the maximum days in a week
    Const MINIMUM_UNITS_SOLD As Integer = 0 'This constant variable is the minimum days in a week
    Dim unitsShipped(TOTAL_DAYS - 1) As Integer ''This is an array which is used to store the user input

    Dim userInputValidated As Integer 'This variable is used to store the validated user input 
    Dim counter As Integer = 0 'This variable is used to as a counter
    Dim averageUnits As Double 'This variable is used to store the average units per day


    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lblUnits.Click

    End Sub

    Private Sub Lab1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUserEntry_TextChanged(sender As Object, e As EventArgs) Handles txtUserEntry.TextChanged


    End Sub

    Private Sub btnEnterButton_Click(sender As Object, e As EventArgs) Handles btnEnterButton.Click
        userInput = txtUserEntry.Text ' converts whatever is in the textbox into the user input variable
        lblAverageOutput.Text = "" ' Sets the output lbl to blank so the error msessage doesn't stay

        If counter = TOTAL_DAYS - 1 Then ' If the user inputs 7 numbers then

            btnEnterButton.Enabled = False 'The enter button on the appilcation gets disabled
            txtUserEntry.ReadOnly = True ' The text box that the user inputs into aslo gets disabled

        End If

        If (Integer.TryParse(txtUserEntry.Text, userInputValidated)) Then 'Checks if the user input is a number 


            If userInputValidated >= MINIMUM_UNITS_SOLD AndAlso userInputValidated <= MAXIMUM_UNITS_SOLD AndAlso userInputValidated >= 0 Then 'Checks if the user input (number) is a number within the specfied range

                unitsShipped(counter) = userInputValidated 'Stores the validated user input into the array slot based of what day it is
                output += unitsShipped(counter).ToString() & vbCrLf ' Stores the validated user input into the output string and also ends the line
                counter = counter + 1 'Increasesd the counter by 1 to proceed to the next day
                txtUserEntry.Clear() 'Clears the text box so the user can enter a number without erasing thier previous entry
                txtUserEntry.Focus() 'Sets the focus back to the text box so the user doesn't have to reclick on the text box

                If counter < TOTAL_DAYS Then 'As long as the counter is less then 7 days, This code is here to prevent the program from saying "Day 8"
                    lblDayCount.Text = "Day " & counter + 1 'Outputs to the Day label and says writes what day the user is about tp enter

                End If

            Else


                lblAverageOutput.Text = "Please ensure the number you input is between 0 and 100" 'Error message if user enters a number lower then 0 and greater then 1000

                txtUserEntry.Clear() 'Clears the text box so the user can enter a number without erasing thier previous entry
                txtUserEntry.Focus() 'Sets the focus back to the text box so the user doesn't have to reclick on the text box

            End If



        Else
            lblAverageOutput.Text = "Invalid number, Please enter a number" 'Error message if user enters something that isnt a number

            txtUserEntry.Clear() 'Clears the text box so the user can enter a number without erasing thier previous entry
            txtUserEntry.Focus() 'Sets the focus back to the text box so the user doesn't have to reclick on the text box         
        End If

        lblUnitsShipped.Text = output 'Outputs the list of numbers the user has entered

        If counter = TOTAL_DAYS Then 'Checks if the counter is 7 or user has inputed 7 numbers

            For avgCounter As Integer = 0 To TOTAL_DAYS - 1 'Creates a for loop that counts for each day of the week
                averageUnits = averageUnits + unitsShipped(avgCounter) 'Adds all the numbers the user inputed into the array
            Next
            averageUnits = averageUnits / TOTAL_DAYS ' takes the total and divides with amount of days that the users enters in data

            lblAverageOutput.Text = "Average per day: " & Math.Round(averageUnits, 2) 'Outputs the average with two decimal places to the output/error label

        End If




    End Sub

    Private Sub btnResetButton_Click(sender As Object, e As EventArgs) Handles btnResetButton.Click

        txtUserEntry.Clear() ' Clears the text box 
        ReDim unitsShipped(TOTAL_DAYS - 1) 'Resets the Array
        averageUnits = 0 ' Sets the averageUnits varible to 0
        output = String.Empty ' Sets the output string varible back to empty
        lblAverageOutput.Text = "" ' Sets the output string varible back to empty
        lblUnitsShipped.Text = "" ' Sets the output string varible back to empty
        txtUserEntry.Focus() 'Sets the focus back to the user input 
        btnEnterButton.Enabled = True 'The enter button on the appilcation gets re-enabled
        txtUserEntry.ReadOnly = False 'The txtUserEntry textbox on the appilcation gets re-enabled
        counter = 0 ' Sets the counter back to 0
        lblDayCount.Text = "Day 1" ' Sets the day lbl Back to day 1


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'Exits the program
    End Sub
End Class
