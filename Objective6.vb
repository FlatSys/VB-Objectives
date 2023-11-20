Imports System
Module Objective6
    Sub obj6()
        DisplayMenu()
    End Sub

    Sub DisplayMenu()
        While True
            Console.WriteLine("                Objective 6 Counter Controlled Iterations    ")
            Console.WriteLine()
            Console.WriteLine("Select a program:")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("1. Example program")
            Console.WriteLine()
            Console.WriteLine("2. Write the program to output all the squares of a number between 1 and 20")
            Console.WriteLine()
            Console.WriteLine("3. Write a program to produce the Fibonacci sequence of 20 numbers")
            Console.WriteLine()
            Console.WriteLine("4. outputs the numbers from 1 to 100. for multiples of three output Fizz, multiples of five output Buzz. multiples of both are FizzBuzz")
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
        'repeating code!
        For counter = 1 To 5
            Console.WriteLine("This is how you get code to repeat")
        Next
        Console.WriteLine()

        For counter = 7 To 12
            Console.WriteLine("The counter is " & counter)
        Next
        Console.WriteLine()

        Dim word As String = "Hello"
        For counter = 1 To Len(word)
            Console.WriteLine("Letter " & counter & " is " & Mid(word, counter, 1))
        Next
        Console.WriteLine()
    End Sub

    Sub Program2() ' Write the program to output all the squares of a number between 1 and 20
        For i As Integer = 1 To 20
            Dim square As Integer = i * i
            Console.WriteLine($"{i} Squared is {square}")
        Next
    End Sub

    Sub Program3() ' Write a program to produce the Fibonacci sequence of 20 numbers. 
        Dim fibonacci_sequence(19) As Integer
        fibonacci_sequence(0) = 0
        fibonacci_sequence(1) = 1
        Console.WriteLine(fibonacci_sequence(1))
        For i As Integer = 2 To 19
            fibonacci_sequence(i) = fibonacci_sequence(i - 1) + fibonacci_sequence(i - 2)
            Console.WriteLine(fibonacci_sequence(i))
        Next
    End Sub

    Sub Program4()
        ''' Write a program that outputs the numbers from 1 to 100. 
        ''' But for multiples of three output “Fizz” instead of the number and for the multiples of five output “Buzz”.
        ''' For numbers which are multiples of both three and five output “FizzBuzz” 
        For i As Integer = 1 To 100
            If i Mod 3 = 0 AndAlso i Mod 5 = 0 Then
                Console.WriteLine("FizzBuzz")
            ElseIf i Mod 3 = 0 Then
                Console.WriteLine("Fizz")
            ElseIf i Mod 5 = 0 Then
                Console.WriteLine("Buzz")
            Else
                Console.WriteLine(i)
            End If
        Next
    End Sub

End Module



