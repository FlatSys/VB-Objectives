Imports System
Module Objective7
    Sub obj7()
        DisplayMenu()
    End Sub

    Sub DisplayMenu()
        While True
            Console.WriteLine("                Objective 7 Condition Controlled Iterations     ")
            Console.WriteLine()
            Console.WriteLine("Select a program:")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("1. Example program")
            Console.WriteLine()
            Console.WriteLine("2. Write a program that presents a simple menu to the user: 1. Play Game 2. Instructions 3. Quit ")
            Console.WriteLine()
            Console.WriteLine("3. Guess the number between 1 to 100 in the least amount of attempts possible!")
            Console.WriteLine()
            Console.WriteLine("4. Rock Paper Scissors against the computer, first to 10 wins! ")
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
        'Program to add up numbers until 0 is entered
        'Initialize variables
        Dim total As Decimal = 0
        Dim number_entered As Decimal = 1
        'Enter numbers to add
        Do While number_entered > 0
            Console.WriteLine("Enter a number")
            number_entered = Console.ReadLine()
            'Add number to total
            total = total + number_entered
        Loop
        'Output result
        Console.WriteLine("The sum of the numbers is: " & total)
        Console.WriteLine()

        'Program to add up numbers until 0 is entered
        'Initialize variables        Dim total As Decimal = 0
        'Enter numbers to add
        Do
            Console.WriteLine("Enter a number")
            number_entered = Console.ReadLine()

            'Add number to total
            total = total + number_entered
        Loop While number_entered > 0
        'Output result
        Console.WriteLine("The sum of the numbers is: " & total)
        Console.WriteLine()

    End Sub

    Sub Program2()
        ''' Write a program that presents a simple menu to the user: 1. Play Game 2. Instructions 3. Quit 
        '''The program should ask the user For a number between 1 And 3 And will output “Let’s go” only When a valid entry Is made, repeating the menu selection until a valid entry Is made. 
        Do
            Console.WriteLine("1. Play Game")
            Console.WriteLine("2. Instructions")
            Console.WriteLine("3. Quit")
            Console.WriteLine("Enter a number between 1 and 3:")
            Dim choice As Integer = Console.ReadLine()

            If choice >= 1 And choice <= 3 Then
                Console.WriteLine("Let's go")
                Exit Do
            End If
        Loop While True
    End Sub

    Sub Program3() ' 
        ''' The computer guesses a number between 1 and 100.  The player has to try and guess the number in as few attempts as possible.  
        ''' When the user enters a number they are told if the guess is too high or too low until the number is guessed correctly.  
        ''' The player is told how many guesses they made.  Write a program to play the game
        Dim targetNumber As Integer = New Random().Next(1, 101)
        Dim userGuess As Integer
        Dim numGuesses As Integer = 0

        Do
            Console.WriteLine("Enter your guess:")
            Console.WriteLine("You have had " & numGuesses & " guesses so far!")
            userGuess = Console.ReadLine()
            numGuesses += 1

            If userGuess < targetNumber Then
                Console.WriteLine("Too low!")
            ElseIf userGuess > targetNumber Then
                Console.WriteLine("Too high!")
            Else
                Console.WriteLine("Congratulations! You guessed the number in " & numGuesses & " attempts.")
            End If
        Loop While userGuess <> targetNumber
    End Sub

    Sub Program4()
        '''The computer and player choose one of rock, paper, or scissors.  The output of the encounter is then displayed with rock beating scissors, scissors beating paper, and paper beating rock.  
        '''The winner scores 1 point for a win.  The score for both players should be output.  
        '''The game is won when one player reaches 10 points.
        Dim playerScore As Integer = 0
        Dim computerScore As Integer = 0

        Do While playerScore < 10 And computerScore < 10
            Console.WriteLine("Choose: 1. Rock 2. Paper 3. Scissors")
            Console.WriteLine("Enter your choice:")
            Dim playerChoice As Integer = Console.ReadLine()

            Dim computerChoice As Integer = New Random().Next(1, 4)

            Select Case playerChoice
                Case 1
                    Select Case computerChoice
                        Case 1
                            Console.WriteLine("It's a tie!")
                        Case 2
                            Console.WriteLine("Computer wins! Paper beats rock.")
                            computerScore += 1
                        Case 3
                            Console.WriteLine("Player wins! Rock beats scissors.")
                            playerScore += 1
                    End Select
                Case 2
                    Select Case computerChoice
                        Case 1
                            Console.WriteLine("Player wins! Paper beats rock.")
                            playerScore += 1
                        Case 2
                            Console.WriteLine("It's a tie!")
                        Case 3
                            Console.WriteLine("Computer wins! Scissors beats paper.")
                            computerScore += 1
                    End Select
                Case 3
                    Select Case computerChoice
                        Case 1
                            Console.WriteLine("Computer wins! Rock beats scissors.")
                            computerScore += 1
                        Case 2
                            Console.WriteLine("Player wins! Scissors beats paper.")
                            playerScore += 1
                        Case 3
                            Console.WriteLine("It's a tie!")
                    End Select
            End Select

            Console.WriteLine("Player Score: " & playerScore)
            Console.WriteLine("Computer Score: " & computerScore)
            Console.WriteLine()
        Loop

        If playerScore >= 10 Then
            Console.WriteLine("Player wins the game!")
        ElseIf computerScore >= 10 Then
            Console.WriteLine("Computer wins the game!")
        End If

    End Sub

End Module



