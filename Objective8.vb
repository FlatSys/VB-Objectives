Imports System
Module Objective8
    Sub obj8()
        DisplayMenu()
    End Sub

    Sub DisplayMenu()
        While True
            Console.WriteLine("                Objective 8 Functions & Subroutines     ")
            Console.WriteLine()
            Console.WriteLine("Select a program:")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("1. Example program")
            Console.WriteLine()
            Console.WriteLine("2. VAT calculator ")
            Console.WriteLine()
            Console.WriteLine("3. Conversion Calculator")
            Console.WriteLine()
            Console.WriteLine("4. Snake Eyes")
            Console.WriteLine()
            Console.WriteLine("5. Return to main menu")
            Console.WriteLine()
            Console.Write("Enter your choice: ")

            Dim choice As String = Console.ReadLine()
            Console.Clear()

            Select Case choice
                Case "1"
                    Program81.prog11()
                Case "2"
                    Program82.prog2()
                Case "3"
                    Program83.prog3()
                Case 4
                    Program84.prog4()
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

End Module

Module Program81 ' Example program
    'Global variables accessed by all subroutines
    Dim MaxNoOfStars, NoOfStars, NoOfSpaces As Integer

    'Main program starts here
    Sub prog11()
        Console.WriteLine("Star draw program")
        InitialiseNoOfSpacesAndStars()
        Do
            OutputLeadingSpaces()
            OutputLineOfStars()
            AdjustNoOfSpacesAndStars()
        Loop While NoOfStars <= MaxNoOfStars
        Console.WriteLine()
        Console.WriteLine("Press Enter to Continue")
        Console.ReadLine()
        prog12()
    End Sub

    'Set the size of the pyramid of stars
    Sub InitialiseNoOfSpacesAndStars()
        Console.Write("How many stars at the base (1-40)? ")
        MaxNoOfStars = Console.ReadLine()
        'Calculate spaces needed from tip
        NoOfSpaces = MaxNoOfStars / 2
        'Set tip of pyramid to one star
        NoOfStars = 1
    End Sub

    'Outputs spaces before stars
    Sub OutputLeadingSpaces()
        Dim count As Integer
        For count = 1 To NoOfSpaces Step 1
            Console.Write(" ")
        Next count
    End Sub

    'Outputs stars
    Sub OutputLineOfStars()
        Dim count As Integer
        For count = 1 To NoOfStars
            Console.Write("*")
        Next
        'Move to next line
        Console.WriteLine()
    End Sub

    'Adjusts number of stars & spaces after output
    Sub AdjustNoOfSpacesAndStars()
        NoOfSpaces = NoOfSpaces - 1
        NoOfStars = NoOfStars + 2
    End Sub
    '------------------------------------------------------------------------------------
    'Program to output a set of random numbers
    Sub prog12()
        Dim number, max As Integer
        Console.Clear()
        Console.WriteLine("Program to output a set of random numbers")
        Console.Write("How many numbers do you want to output? (max 32,767) ")
        number = Console.ReadLine()
        Console.Write("What is the maximum number? ")
        max = Console.ReadLine
        outputrandoms(number, max)
        Console.WriteLine()
    End Sub

    'Output random numbers
    Sub outputrandoms(ByVal n As Integer, ByVal m As Integer)
        Dim counter, randomnum As Integer
        For counter = 1 To n
            randomnum = CInt(Rnd() * m)
            Console.WriteLine("Number " & counter & " is " & randomnum)
        Next
    End Sub
End Module

Module Program82
    '''Write a program that asks the user for a price of an item.  
    ''' Write a program that asks the user for a price of an item.  
    '''Include a Function that returns the VAT For the item.  This should be output In the main program. 
    'Program to calculate VAT for an item
    Sub prog2()
        Dim itemPrice As Double
        Console.Write("Enter the price of the item: ")
        itemPrice = CDbl(Console.ReadLine())
        Console.WriteLine("The VAT for the item is: " & CalculateVAT(itemPrice))
    End Sub

    'Function to calculate VAT
    Function CalculateVAT(ByVal price As Double) As Double
        Dim VATRate As Double = 0.2
        Return price * VATRate
    End Function
End Module

Module Program83
    'Subroutine for the metric to imperial conversion utility
    Sub prog3()
        Dim choice As Integer

        Do
            choice = ShowMenu()

            Select Case choice
                Case 1
                    ConvertCentimetersToInches()
                Case 2
                    ConvertKilogramsToPounds()
                Case 3
                    ConvertLitersToGallons()
                Case 4
                    ConvertCelsiusToFahrenheit()
                Case 5
                    Exit Do
                Case Else
                    Console.WriteLine("Invalid choice. Please try again.")
            End Select
        Loop While True

        Console.ReadLine()
    End Sub

    'Function to display the conversion menu and get the user's choice
    Function ShowMenu() As Integer
        Console.Clear()
        Console.WriteLine("Conversion Menu:")
        Console.WriteLine("1. Convert centimeters to inches")
        Console.WriteLine("2. Convert kilograms to pounds")
        Console.WriteLine("3. Convert liters to gallons")
        Console.WriteLine("4. Convert Celsius to Fahrenheit")
        Console.WriteLine("5. Exit")
        Console.Write("Enter your choice: ")

        Return CInt(Console.ReadLine())
    End Function

    'Subroutine to convert centimeters to inches
    Sub ConvertCentimetersToInches()
        Dim centimeters As Double
        Console.WriteLine()
        Console.Write("Enter the length in centimeters: ")
        centimeters = CDbl(Console.ReadLine())

        Dim inches As Double = centimeters * 0.393701
        Console.WriteLine()
        Console.WriteLine(centimeters & " centimeters is equal to " & inches & " inches.")
        Console.WriteLine()
        Console.WriteLine("Press Enter to Continue")
        Console.ReadLine()
    End Sub

    'Subroutine to convert kilograms to pounds
    Sub ConvertKilogramsToPounds()
        Dim kilograms As Double
        Console.WriteLine()
        Console.Write("Enter the weight in kilograms: ")
        kilograms = CDbl(Console.ReadLine())

        Dim pounds As Double = kilograms * 2.20462
        Console.WriteLine()
        Console.WriteLine(kilograms & " kilograms is equal to " & pounds & " pounds.")
        Console.WriteLine()
        Console.WriteLine("Press Enter to Continue")
        Console.ReadLine()
    End Sub

    'Subroutine to convert liters to gallons
    Sub ConvertLitersToGallons()
        Dim liters As Double
        Console.WriteLine()
        Console.Write("Enter the volume in liters: ")
        liters = CDbl(Console.ReadLine())

        Dim gallons As Double = liters * 0.264172
        Console.WriteLine()

        Console.WriteLine(liters & " liters is equal to " & gallons & " gallons.")
        Console.WriteLine()
        Console.WriteLine("Press Enter to Continue")
        Console.ReadLine()
    End Sub

    'Subroutine to convert Celsius to Fahrenheit
    Sub ConvertCelsiusToFahrenheit()
        Dim celsius As Double
        Console.WriteLine()
        Console.Write("Enter the temperature in Celsius: ")
        celsius = CDbl(Console.ReadLine())

        Dim fahrenheit As Double = (celsius * 9 / 5) + 32
        Console.WriteLine()

        Console.WriteLine(celsius & " degrees Celsius is equal to " & fahrenheit & " degrees Fahrenheit.")
        Console.WriteLine()
        Console.WriteLine("Press Enter to Continue")
        Console.ReadLine()
    End Sub

End Module

Module Program84
    Dim playerScores(1) As Integer
    Dim currentPlayer As Integer = 0
    Dim runningTotal As Integer = 0

    Sub prog4()
        Console.WriteLine("Welcome to the Dice Game!")
        Console.WriteLine("Roll a double 1 to reset your score to 0.")
        Console.WriteLine("Roll a single 1 to lose your running total.")
        Console.WriteLine("Reach a total of 100 to win the game.")
        Console.WriteLine()

        Do While playerScores(currentPlayer) < 100
            Console.WriteLine($"Player {currentPlayer + 1}'s turn")
            Console.WriteLine($"Current Score: {playerScores(currentPlayer)} | Running Total: {runningTotal}")
            Console.WriteLine("1. Roll the dice")
            Console.WriteLine("2. Bank the score")
            Console.Write("Choose an option (1 or 2): ")

            Dim choice As Integer = CInt(Console.ReadLine())

            Select Case choice
                Case 1
                    RollDice()
                Case 2
                    BankScore()
            End Select

            SwitchPlayer()
        Loop

        Console.WriteLine($"Player {currentPlayer + 1} wins with a score of {playerScores(currentPlayer)}!")
    End Sub

    Sub RollDice()
        Dim dice1 As Integer = New Random().Next(1, 7)
        Dim dice2 As Integer = New Random().Next(1, 7)

        Console.WriteLine($"Dice Roll: {dice1} + {dice2} = {dice1 + dice2}")

        If dice1 = 1 OrElse dice2 = 1 Then
            Console.WriteLine("You rolled a 1! Running total reset to 0.")
            runningTotal = 0
            SwitchPlayer()
        ElseIf dice1 = 1 And dice2 = 1 Then
            Console.WriteLine("Double 1! Running total reset to 0.")
            playerScores(currentPlayer) = 0
            runningTotal = 0
            SwitchPlayer()
        Else
            runningTotal += dice1 + dice2
            Console.WriteLine($"Running Total: {runningTotal}")
            Console.WriteLine("1. Roll again")
            Console.WriteLine("2. Bank the score")
            Console.Write("Choose an option (1 or 2): ")
            Dim choice As Integer = CInt(Console.ReadLine())

            If choice = 2 Then
                BankScore()
            Else
                RollDice()
            End If
        End If
    End Sub

    Sub BankScore()
        playerScores(currentPlayer) += runningTotal
        Console.WriteLine($"Score banked! New total: {playerScores(currentPlayer)}")
        runningTotal = 0
    End Sub

    Sub SwitchPlayer()
        currentPlayer = (currentPlayer + 1) Mod 2
        Threading.Thread.Sleep(100) ' Pause for a sec to make it more readable
    End Sub
End Module