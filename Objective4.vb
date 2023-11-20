

Module Objective4
    Sub obj4()
        DisplayMenu()
    End Sub

    Sub DisplayMenu()
        While True
            Console.WriteLine("                Objective 4 Selection Statements  ")
            Console.WriteLine()
            Console.WriteLine("Select a program:")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("1. Example program")
            Console.WriteLine()
            Console.WriteLine("2. Write a program that reads the temperature of water in Centigrade and outputs if the water is frozen, boiling or neither.")
            Console.WriteLine()
            Console.WriteLine("3. Write a program that inputs a mark for sections of a project, calculates the grade band, mark, and how many marks needed for next mark band")
            Console.WriteLine()
            Console.WriteLine("4. Output info about specific elements")
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
                    Program4.P4main()
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

        ' Declare a number variable
        Dim number As Integer
        ' Ask user for the number
        Console.WriteLine("Enter a number 1-3: ")
        number = Console.ReadLine
        ' Check the value of the number
        If number = 1 Then
            Console.WriteLine("You entered one")
        End If
        If number = 2 Then
            Console.WriteLine("You entered two")
        End If
        If number = 3 Then
            Console.WriteLine("You entered three")
        End If
        Console.WriteLine()


        ' Works out whether a candidate passed or failed
        Dim score As Integer
        Console.WriteLine("Enter the test score 1-100: ")
        score = Console.ReadLine
        ' Branch depending on the value of the variable
        If score > 40 Then
            Console.WriteLine("You passed")
        Else
            Console.WriteLine("You failed")
        End If
        Console.WriteLine()

        ' finding if two numbers are the same
        Dim num1, num2 As Integer
        Console.Write("Enter the first number: ")
        num1 = Console.ReadLine
        Console.Write("Enter the second number: ")
        num2 = Console.ReadLine
        ' Branch depending on the value of the variable
        If num1 <> num2 Then
            Console.WriteLine("The numbers are different")
        Else
            Console.WriteLine("The numbers are the same")
        End If
        Console.WriteLine()

        ' Using logic operators
        Dim choice As String
        Console.WriteLine("Enter a number 1-3: ")
        choice = Console.ReadLine
        If choice > "@" And choice < "3" Then
            Console.WriteLine("Valid input")
        Else
            Console.WriteLine("Invalid input")
        End If
        Console.WriteLine()


        ' Using case selection
        ' Ask user for the number
        Console.WriteLine("1. Add numbers")
        Console.WriteLine("2. Subtract numbers")
        Console.WriteLine("3. Quit")
        Console.WriteLine("Enter your choice: ")
        choice = Console.ReadLine
        ' Multiple branches depending on selection
        Select Case choice
            Case Is = "1"
                Console.WriteLine("Add numbers chosen")
            Case Is = "2"
                Console.WriteLine("Subtract numbers chosen")
            Case Is = "3"
                Console.WriteLine("Quit chosen")
        End Select



    End Sub

    Sub Program2() ' 
        ' Program to check the temperature of water in a container and state if boiling 
        Dim temperature As Integer

        Console.WriteLine("Enter the temperature of water in Centigrade: ")
        temperature = Console.ReadLine()

        ' Check the temperature and display appropriate message
        If temperature <= 0 Then
            Console.WriteLine("The water is frozen.")
        ElseIf temperature >= 100 Then
            Console.WriteLine("The water is boiling.")
        Else
            Console.WriteLine("The water is neither frozen nor boiling.")
        End If

    End Sub

    Sub Program3() ' Write a program that inputs a mark for sections of a project, calculates the grade band, mark, and how many marks needed for next mark band
        ' Program to calculate total mark, grade, and marks needed for next band
        Dim analysis As Integer
        Dim design As Integer
        Dim implementation As Integer
        Dim evaluation As Integer

        Console.WriteLine("Enter the mark for 'analysis': ")
        analysis = Console.ReadLine()

        Console.WriteLine("Enter the mark for 'design': ")
        design = Console.ReadLine()

        Console.WriteLine("Enter the mark for 'implementation': ")
        implementation = Console.ReadLine()

        Console.WriteLine("Enter the mark for 'evaluation': ")
        evaluation = Console.ReadLine()

        Dim total_mark As Integer = analysis + design + implementation + evaluation
        Dim grade As String
        Dim marks_needed As Integer

        If total_mark < 2 Then
            grade = "U"
            marks_needed = 2 - total_mark
        ElseIf total_mark < 4 Then
            grade = "1"
            marks_needed = 4 - total_mark
        ElseIf total_mark < 13 Then
            grade = "2"
            marks_needed = 13 - total_mark
        ElseIf total_mark < 22 Then
            grade = "3"
            marks_needed = 22 - total_mark
        ElseIf total_mark < 31 Then
            grade = "4"
            marks_needed = 31 - total_mark
        ElseIf total_mark < 41 Then
            grade = "5"
            marks_needed = 41 - total_mark
        ElseIf total_mark < 54 Then
            grade = "6"
            marks_needed = 54 - total_mark
        ElseIf total_mark < 67 Then
            grade = "7"
            marks_needed = 67 - total_mark
        Else
            grade = "8"
            marks_needed = -1
        End If

        Console.WriteLine("Total Mark: " & total_mark)
        Console.WriteLine("Grade: " & grade)
        Console.WriteLine("Marks Needed for Next Band: " & marks_needed)

    End Sub

End Module
Module Program4
    ''' Write a program that asks the user to enter the symbol or name of an element, or group it belongs to.  The program should output the name of the element and its atomic weight.  E.g.
    'The user enters Li.  The program outputs
    'Element: Lithium(Li)
    'Atomic weight:  6.94
    'Group: Alkali metals
    'If the Then user enters Alkali metals, the program outputs the data For all the elements In the alkali metals group.
    'If the Then user enters Lithium, it will output all the data For Lithium
    'You only need to get this working for 6 elements from two different groups
    ' Dictionary to store element data, indexed by symbol
    ' executed within a module due to the larage amount of Subs and Functions
    Dim elementData As New Dictionary(Of String, Dictionary(Of String, String))()

    Sub P4main()
        ' Initialize element data for a few elements
        InitializeElementData()

        ' Main program loop
        While True
            Console.WriteLine("Enter an element symbol, name, or group: ")
            Dim userInput As String = Console.ReadLine().Trim()

            ' Check if the input exists as an element symbol, name, or group
            Dim matchingElements = elementData.Where(Function(element) element.Key.ToLower() = userInput.ToLower() OrElse
                                                       element.Value("name").ToLower() = userInput.ToLower() OrElse
                                                       element.Value("group").ToLower() = userInput.ToLower())

            If matchingElements.Count() > 0 Then
                ' Display information for matching elements
                For Each element In matchingElements
                    DisplayElementInfo(element.Key, element.Value)
                Next
            Else
                Console.WriteLine("No matching elements found.")
            End If
        End While
    End Sub

    Sub InitializeElementData()
        ' Initialize element data for elements
        AddElement("H", "Hydrogen", "1.008", "Nonmetals")
        AddElement("Li", "Lithium", "6.94", "Alkali metals")
        AddElement("Na", "Sodium", "22.99", "Alkali metals")
        AddElement("Be", "Beryllium", "9.012", "Alkaline earth metals")
        AddElement("Mg", "Magnesium", "24.305", "Alkaline earth metals")
        AddElement("Ca", "Calcium", "40.078", "Alkaline earth metals")
    End Sub

    Sub AddElement(symbol As String, name As String, atomicWeight As String, group As String)
        ' Add element data to the dictionary
        elementData.Add(symbol, New Dictionary(Of String, String) From {
            {"name", name},
            {"atomicWeight", atomicWeight},
            {"group", group}
        })
    End Sub

    Sub DisplayElementInfo(symbol As String, elementInfo As Dictionary(Of String, String))
        ' Display element information
        Console.WriteLine("Symbol: " & symbol)
        Console.WriteLine("Name: " & elementInfo("name"))
        Console.WriteLine("Atomic Weight: " & elementInfo("atomicWeight"))
        Console.WriteLine("Group: " & elementInfo("group"))
        Console.WriteLine()
    End Sub

    Function FindMatchingElements(input As String) As Dictionary(Of String, Dictionary(Of String, String))
        ' Find elements or groups matching the user input
        Dim matchingElements = New Dictionary(Of String, Dictionary(Of String, String))()

        ' Check for elements with matching symbol or name
        For Each kvp In elementData
            If kvp.Key = input OrElse kvp.Value("name").Equals(input, StringComparison.OrdinalIgnoreCase) Then
                matchingElements.Add(kvp.Key, kvp.Value)
            End If
        Next

        ' Check for elements in the specified group
        Dim elementsInGroup = elementData.Where(Function(e) e.Value("group").Equals(input, StringComparison.OrdinalIgnoreCase))
        For Each kvp In elementsInGroup
            matchingElements.Add(kvp.Key, kvp.Value)
        Next

        ' Return matchingElements
        Return matchingElements
    End Function

End Module
