Imports System
Imports System.Data
Imports System.Runtime.InteropServices
'''  Compile from VS terminal 
'''  (without .NET core) dotnet publish -r win-x64 -p:PublishSingleFile=True --self-contained false --output "C:\abc" VB-Objectives.vbproj
'''  (with .NET core) dotnet publish -r win-x64 /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true /p:PublishTrimmed=true --output "C:\abc" VB-Objectives.vbproj
Module Launch
    Sub Main()

        Console.ForegroundColor = ConsoleColor.Green
        DisplayMenu()

        Dim choice As Integer = GetUserChoice()

        Select Case choice
            Case 1
                Objective1.obj1()
            Case 2
                Objective2.obj2()
            Case 3
                Objective3.obj3()
            Case 4
                Objective4.obj4()
            Case 5
                Objective5.obj5()
            Case 6
                Objective6.obj6()
            Case 7
                Objective7.obj7()
            Case Else
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.WriteLine("Invalid choice. Please choose a valid file number from the list.")

        End Select

        Main()
    End Sub

    Sub DisplayMenu()
        Console.WriteLine("Welcome to my project directory for A level Computer Science")
        Console.WriteLine()
        Console.WriteLine("Please Select a project:")
        Console.WriteLine()
        Console.WriteLine("1. Objective 1 Text Strings ")
        Console.WriteLine("2. Objective 2 Variables")
        Console.WriteLine("3. Objective 3 String Manipulation ")
        Console.WriteLine("4. Objective 4 Selection Statements")
        Console.WriteLine("5. Objective 5 Arithmetic Operations and Random Numbers")
        Console.WriteLine("6. Objective 6 Counter Controlled Iterations ")
        Console.WriteLine("7. Objective 7 Condition Controlled Iterations ")
        Console.WriteLine()
    End Sub

    Function GetUserChoice() As Integer
        Console.Write("Enter which Objective to run: ")
        Console.ForegroundColor = ConsoleColor.White
        Dim input As String = Console.ReadLine()
        Console.WriteLine()
        Dim choice As Integer

        If Integer.TryParse(input, choice) Then
            Console.Clear()
            Return choice
        Else
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("Invalid input. Please enter a number.")
            Console.WriteLine()
            Return GetUserChoice()
        End If
    End Function
End Module
