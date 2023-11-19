Imports System.Net.Security
Imports Microsoft.VisualBasic

Module Objective1
    Sub obj1()
        DisplayMenu()
    End Sub

    Sub DisplayMenu()
        While True
            Console.WriteLine("                Objective 1 Text Strings ")
            Console.WriteLine()
            Console.WriteLine("Select a program:")
            Console.WriteLine()
            Console.WriteLine("1. Example program")
            Console.WriteLine("2. Write a program that will output the number 5 on a dice")
            Console.WriteLine("3. Write a program that outputs your name in ASCII Art")
            Console.WriteLine("4. Return to main menu")
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
    Sub Program1() ' Example Program
        'write two blocks of text
        Console.WriteLine("Hello World" & " This is my first program")
        'blank line
        Console.WriteLine()
        'end of message
        Console.WriteLine("I am learning to code..")
        Console.WriteLine("And it is fun!")
        Console.WriteLine()
        Console.WriteLine("Computers only do exactly as they are told…")
        Console.WriteLine("They are not intelligent!")
        Console.WriteLine("…so you need the code to be correct!")
        Console.WriteLine()
        Console.WriteLine("If you make any mistake with the commands, it won’t work ")
    End Sub

    Sub Program2() ' Write a program that will output the number 5 on a dice
        Console.WriteLine("Display a 5 on a dice with text")
        Console.WriteLine()
        Console.WriteLine("oooooooooooo")
        Console.WriteLine("o          o")
        Console.WriteLine("o  #    #  o")
        Console.WriteLine("o    #     o")
        Console.WriteLine("o  #    #  o")
        Console.WriteLine("o          o")
        Console.WriteLine("oooooooooooo")

    End Sub

    Sub Program3() ' Write a program that outputs your name in ASCII Art
        Console.WriteLine(" _     _  _     _    ___  _")
        Console.WriteLine("/ \   / \/ \   / \   \  \//")
        Console.WriteLine("| |   | || |   | |    \  / ")
        Console.WriteLine("| |_/\| || |_/\| |_/\ / /  ")
        Console.WriteLine("\____/\_/\____/\____//_/   ")
    End Sub
End Module
