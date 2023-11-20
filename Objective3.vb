Imports System.Net.Security
Imports Microsoft.VisualBasic

Module Objective3
    Sub obj3()
        DisplayMenu()
    End Sub

    Sub DisplayMenu()
        While True
            Console.WriteLine("                Objective 3 String Manipulation  ")
            Console.WriteLine()
            Console.WriteLine("Select a program:")
            Console.WriteLine()
            Console.WriteLine("1. Example program")
            Console.WriteLine("2. Ask for a person’s forename and surname, outputting their first initial and the rest of their name in capitals")
            Console.WriteLine("3. Output the first 4 characters of two cities inputted by the user in capital letters, separated by a dash.")
            Console.WriteLine("4. Allow user to input name on one line, The program will then seperate it out and ouput on 2 lines.")
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
        ' UCase changes a string to upper case
        Dim forename, forename_uppercase As String
        Console.Write("Enter your surname: ")
        forename = Console.ReadLine()
        forename_uppercase = UCase(forename)
        Console.WriteLine("Your name in capital letters is: " & forename_uppercase)
        Console.WriteLine()

        ' LCase changes a string to lower case
        Dim email, email_lowercase As String
        Console.Write("Enter your email address: ")
        email = Console.ReadLine()
        email_lowercase = LCase(email)
        Console.WriteLine("Your email address in lowercase is: " & email_lowercase)
        Console.WriteLine()

        'len returns length of string
        Dim name As String
        Console.Write("Enter your name: ")
        name = Console.ReadLine()
        Dim name_length As Integer = name.Length
        Console.WriteLine("The number of characters in your name is: " & name_length)
        Console.WriteLine()

        Dim sentence, characters As String
        sentence = "I saw a wolf in the forest. A lonely wolf."
        ' Extract the leftmost 5 characters from the sentence
        characters = Left(sentence, 5)
        Console.WriteLine(characters)
        Console.WriteLine()

        sentence = "I saw a wolf in the forest. A lonely wolf."
        ' Extract the rightmost 12 characters from the sentence
        characters = Right(sentence, 12)
        Console.WriteLine(characters)
        Console.WriteLine()

        sentence = "I saw a wolf in the forest. A lonely wolf."
        ' Extract 6 characters starting from the 21st character in the sentence
        characters = Mid(sentence, 21, 6)
        Console.WriteLine(characters)
        Console.WriteLine()

        ' Instr returns the location of one string inside another
        Dim word As String
        Dim position As Integer

        sentence = "I saw a wolf in the forest. A lonely wolf."
        Console.WriteLine(sentence)
        Console.Write("Enter the word to find: ")
        word = Console.ReadLine
        position = InStr(sentence, word)
        Console.WriteLine("The word " & word & " is at character " & position)
        Console.WriteLine()
    End Sub

    Sub Program2() ' Ask for a person’s forename and surname, outputting their first initial and the rest of their name in capitals
        ' Ask for the person's forename and surname
        Dim forename As String
        Dim surname As String

        Console.WriteLine("Enter your forename: ")
        forename = Console.ReadLine()

        Console.WriteLine("Enter your surname: ")
        surname = Console.ReadLine()

        ' Get the first initial and the rest of the surname in capitals
        Dim initial As Char = Char.ToUpper(forename(0))
        Dim restOfSurname As String = surname.ToUpper()

        ' Output the result
        Console.WriteLine(initial & " " & restOfSurname)
    End Sub

    Sub Program3() ' Output the first 4 characters of two cities inputted by the user in capital letters, separated by a dash.
        ' Declare two variables to hold the names of the two cities
        Dim cityl, city2 As String

        ' Prompt the user to enter the name of the first city and store it in the cityl variable
        Console.Write("Enter the name of the first city: ")
        cityl = Console.ReadLine()

        ' Prompt the user to enter the name of the second city and store it in the city2 variable
        Console.Write("Enter the name of the second city: ")
        city2 = Console.ReadLine()

        ' Extract the first 4 characters of each city name using the 'Substring' function,
        ' convert them to uppercase using the 'ToUpper' function, and put them with a hyphen in between
        Dim abbreviation As String = cityl.Substring(0, 4).ToUpper() & "-" & city2.Substring(0, 4).ToUpper()

        ' Output the abbreviation to the console using the 'WriteLine' function
        Console.WriteLine(abbreviation)

    End Sub

    Sub Program4() ' Allow user to input name on one line, The program will then seperate it out and ouput on 2 lines.
        Dim fullName As String

        Console.Write("Enter your full name: ")

        fullName = Console.ReadLine()

        ' Find the index of the space
        Dim spaceIndex As Integer = fullName.IndexOf(" ")

        ' Extract the forename and surname
        Dim forename As String = fullName.Substring(0, spaceIndex) ' Get the characters before the space
        Dim surname As String = fullName.Substring(spaceIndex + 1) ' Get the characters after the space

        ' Output the results
        Console.WriteLine("Forename: " & forename) ' Display the forename
        Console.WriteLine("Surname: " & surname) ' Display the surname

    End Sub
End Module
