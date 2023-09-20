Module Module1
    'Bradley McNeely
    '9/20/23
    'String Variable And Input Demo
    Sub Main()
        Dim name As String 'declare a variable to hold text 
        Dim MovieTitle1 As String
        Dim MovieTitle2 As String
        Dim MovieTitle3 As String = "Trolls World Tour" 'You can initalize (give a calue) to a variable when you create it
        Dim MovieYear1, MovieYear2, MovieYear3 As String ' you can declare multple variables of the same type

        Console.Write("Please enter your name -> ")
        name = Console.ReadLine() 'read from the console everything until a new line
        Console.WriteLine("hello " & name) ' concatonate the sting literal and the string variable
        Console.Write("Please enter your first favorite movie of all time -> ") 'promt the user for input
        MovieTitle1 = Console.ReadLine()
        Console.Write("Please enter the year in came out -> ")
        MovieYear1 = Console.ReadLine("Please enter your Second favorite movie of all time -> ") 'promt the user for input
        MovieTitle2 = Console.ReadLine()
        Console.Write("Please enter the year in came out -> ")
        MovieYear2 = Console.ReadLine

        'print the string. Escape the quote with an additional "
        Console.WriteLine("Thank you. Your ""Top 3"" Movies of all time are listed below" & vbNewLine)

        'print a line of dashes for the top of the table
        Console.WriteLine("".PadRight(50, "-"))
        'use a string formatter
        Console.WriteLine("| {0} | {1} | {2} |", "1", "Title".PadRight(30), "Year Released".PadRight(15))

        Console.WriteLine("| 1 | " & "Title".PadRight(30) & "|" & "Year Released".PadRight(15) & " |")

        Console.WriteLine("| {0} | {1} | {2} |", "1", MovieTitle1.PadRight(30), MovieYear1.PadRight(15))
        Console.WriteLine("| {0} | {1} | {2} |", "1", MovieTitle2.PadRight(30), MovieYear2.PadRight(15))
        Console.WriteLine("| {0} | {1} | {2} |", "1", MovieTitle3.PadRight(30), MovieYear3.PadRight(15))
        Console.WriteLine("".PadRight(56, ""))

        Console.ReadKey()

    End Sub


End Module
