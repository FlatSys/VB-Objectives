Imports System.Net.Security
Imports Microsoft.VisualBasic

Module Objective2
    Sub obj2()
        DisplayMenu()
    End Sub

    Sub DisplayMenu()
        While True
            Console.WriteLine("                Objective 2 Variables ")
            Console.WriteLine()
            Console.WriteLine("Select a program:")
            Console.WriteLine()
            Console.WriteLine("1. Example program")

            Console.WriteLine("4. Return to main menu")
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
    Sub Program1()

    End Sub

    Sub Program2()

    End Sub
End Module
