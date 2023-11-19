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
            Console.WriteLine("2. Write a program that asks the user for two numbers, adds them together and output")
            Console.WriteLine("3. Write a program to convert a person’s height in inches into centimetres and their weight in stones into kilograms.")
            Console.WriteLine("4. Write a program to calculate and output the radius, area, circumference and arc length of a circle given arc length and diameter.")
            Console.WriteLine("5. Return to main menu")
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
        Dim myName As String
        myName = "John" ' fake name!
        Console.WriteLine(myName)
        Console.WriteLine()

        ' Display user name and age
        Dim name As String
        Dim age As Integer

        Console.Write("Enter your name: ")
        name = Console.ReadLine()

        Console.Write("Enter your age: ")
        age = Console.ReadLine()

        Console.WriteLine("Thank you " & name & ". You have registered an age of " & age & ".")


    End Sub

    Sub Program2() ' Write a program that asks the user for two numbers, adds them together and output
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim sum As Integer

        Console.Write("Enter the first number: ")
        firstNumber = Console.ReadLine()

        Console.Write("Enter the second number: ")
        secondNumber = Console.ReadLine()

        sum = firstNumber + secondNumber

        Console.WriteLine("The sum of " & firstNumber & " and " & secondNumber & " is " & sum & ".")

    End Sub

    Sub Program3() ' Write a program to convert a person’s height in inches into centimetres and their weight in stones into kilograms.  (1 inch = 2.54 cm and 1 stone = 6.364 kg) 

        Dim heightInInches As Double
        Dim weightInStones As Double
        Dim heightInCm As Double
        Dim weightInKg As Double

        Console.Write("Enter your height in inches: ")
        heightInInches = Console.ReadLine()
        heightInCm = heightInInches * 2.54
        Console.WriteLine("Your height in cm is: " & heightInCm)

        Console.Write("Enter your weight in stones: ")
        weightInStones = Console.ReadLine()
        weightInKg = weightInStones * 6.364
        Console.WriteLine("Your weight in kg is: " & weightInKg)
    End Sub

    Sub Program4()
        ''' Write a program that asks the user for the diameter of a circle and the arc angle.  
        ''' The program should then calculate and output the radius, area, circumference and arc length of the circle.

        Dim diameter As Double
        Dim arcAngle As Double
        Dim radius As Double
        Dim area As Double
        Dim circumference As Double
        Dim arcLength As Double

        Console.Write("Enter the diameter of a circle: ")
        diameter = Console.ReadLine()
        Console.Write("Enter the arc angle: ")
        arcAngle = Console.ReadLine()

        radius = diameter / 2
        area = 3.14 * radius ^ 2
        circumference = 3.14 * diameter
        arcLength = circumference * arcAngle / 360

        Console.WriteLine("The radius of the circle is: " & radius)
        Console.WriteLine("The area of the circle is: " & area)
        Console.WriteLine("The circumference of the circle is: " & circumference)
        Console.WriteLine("The arc length of the circle is: " & arcLength)
    End Sub
End Module
