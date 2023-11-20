

Module Objective5
    Sub obj5()
        DisplayMenu()
    End Sub

    Sub DisplayMenu()
        While True
            Console.WriteLine("                Objective 5 Arithmetic Operations and Random Numbers   ")
            Console.WriteLine()
            Console.WriteLine("Select a program:")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("1. Example program")
            Console.WriteLine()
            Console.WriteLine("2. Write a program that asks the user how many sides a dice has and outputs a random number for that dice.")
            Console.WriteLine()
            Console.WriteLine("3. A cash machine dispenses £10 and £20 notes to a maximum of £250.  Write a program that shows the user their balance of £231, asks them how much to withdraw,")
            Console.WriteLine()
            Console.WriteLine("4. How many days are in the month")
            Console.WriteLine()
            Console.WriteLine("5. Return to main menu")
            Console.WriteLine()
            Console.Write("Enter your choice: ")

            Dim choice As String = Console.ReadLine()
            Console.Clear()

            Select Case choice
                Case "1"
                    Program1()
                Case "2"
                    Program2()
                Case "3"
                    Program3()
                Case "4"
                    Program4()
                Case "5"
                    ExitProgram()
                    Exit While ' Exit the loop when the user chooses to exit
                Case Else
                    Console.WriteLine("Invalid choice. Please enter a valid option.")
            End Select

            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Press Enter to return to objective menu...")
            Console.ForegroundColor = ConsoleColor.White
            Console.ReadLine()
            Console.Clear()

        End While
    End Sub

    Sub ExitProgram()
        Console.WriteLine("             MAIN MENU")
        Console.WriteLine()
    End Sub

    Sub Program1() ' Example program
        'Declare variables
        Dim power_of_result As Integer
        Dim number1, number2 As Integer
        Dim division_result As Decimal
        Dim integer_division_result As Integer
        Dim modulus_result As Integer
        'Get user input
        Console.Write("Enter first number: ")
        number1 = Console.ReadLine
        Console.Write("Enter second number: ")
        number2 = Console.ReadLine
        'Make calculations
        power_of_result = number1 ^ number2
        division_result = number1 / number2
        integer_division_result = number1 \ number2
        modulus_result = number1 Mod number2
        'Output results
        Console.WriteLine()
        Console.WriteLine(number1 & " to the power of " & number2 & " is " & power_of_result)
        Console.WriteLine(number1 & " divided by " & number2 & " is " & division_result)
        Console.WriteLine(number1 & " divided by " & number2 & " is " & integer_division_result)
        Console.WriteLine(number1 & " divided by " & number2 & " has a remainder of " & modulus_result)
        Console.WriteLine()


        'Declare variables
        Dim random_number As Integer
        'Generate a new random number seed
        Randomize()
        'Roll the dice
        random_number = CInt(Rnd() * 5) + 1
        Console.WriteLine("You rolled a " & random_number)

    End Sub

    Sub Program2() ' Write a program that asks the user how many sides a dice has and outputs a random number for that dice.
        ' Get user input for dice sides
        Console.Write("Enter the number of sides for the dice: ")
        Dim diceSides As Integer = Convert.ToInt32(Console.ReadLine())

        ' Create a new instance of the Random class
        Dim random As New Random()

        ' Generate a random number between 1 and the number of dice sides
        Dim randomNumber As Integer = random.Next(1, diceSides + 1)

        ' Output the result
        Console.WriteLine("You rolled a " & randomNumber)
    End Sub

    Sub Program3()
    ' A cash machine dispenses £10 and £20 notes to a maximum of £250.  Write a program that shows the user their balance of £231, asks them how much to withdraw, ensures this is a valid amount without going overdrawn and with the notes available, and outputs the new balance. 
    ' Initialize the balance and available notes
    Dim balance As Integer = 231
    Dim tenNotes As Integer = 0
    Dim twentyNotes As Integer = 0

    ' Calculate the maximum withdrawal amount
    Dim maxWithdrawal As Integer = Math.Min(balance, 250)

    ' Ask the user for the withdrawal amount
    Console.Write("Enter the amount to withdraw (max £" & maxWithdrawal & "): ")
    Dim withdrawalAmount As Integer = Convert.ToInt32(Console.ReadLine())

    ' Check if the withdrawal amount is valid
    If withdrawalAmount <= maxWithdrawal AndAlso withdrawalAmount Mod 10 = 0 Then
            ' Calculate the number of £10 and £20 notes to dispense
            twentyNotes = withdrawalAmount \ 20
            tenNotes = (withdrawalAmount Mod 20) \ 10

            ' Update the balance
            balance -= withdrawalAmount

        ' Output the new balance and the number of notes dispensed
        Console.WriteLine("New balance: £" & balance)
        Console.WriteLine("Dispensed notes:")
        Console.WriteLine("£20 notes: " & twentyNotes)
        Console.WriteLine("£10 notes: " & tenNotes)
    Else
        ' Output an error message if the withdrawal amount is invalid
        Console.WriteLine("Invalid withdrawal amount!")
    End If


    End Sub

    Sub Program4()
        ''' Write a program that lets the user enter a year, and a month number between 1 and 12.  The program outputs the month name for that month number and the number of days in the month.  
        ''' The input 3 would therefore display March has 31 days.   
        '''Remember February has 28 Or 29 days depending on whether it Is a leap year.  It Is a leap year if the year Is exactly divisible by 4. 

        ' Get user input for year and month number
        Console.Write("Enter a year: ")
        Dim year As Integer = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter a month number (1-12): ")
        Dim month As Integer = Convert.ToInt32(Console.ReadLine())

        ' Define an array of month names
        Dim monthNames() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        ' Define an array of days in each month
        Dim daysInMonth() As Integer = {31, IIf(IsLeapYear(year), 29, 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

        ' Check if the month number is valid
        If month >= 1 AndAlso month <= 12 Then
            ' Retrieve the month name
            Dim monthName As String = monthNames(month - 1)

            ' Retrieve the number of days in the month
            Dim numberOfDays As Integer = daysInMonth(month - 1)

            ' Output the result
            Console.WriteLine(monthName & " has " & numberOfDays & " days.")
        Else
            ' Output an error message for invalid month number
            Console.WriteLine("Invalid month number!")
        End If

    End Sub

    Function IsLeapYear(year As Integer) As Boolean
        Return year Mod 4 = 0 AndAlso (year Mod 100 <> 0 OrElse year Mod 400 = 0)
    End Function
End Module



