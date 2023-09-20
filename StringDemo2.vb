Module StringDemo2
    'Bradley McNeely
    '9/20/23
    'More String functions


    Sub Main()
        Dim name, input1, input2, input3 As String
        Console.Write("Please enter your name -> ")
        name = Console.ReadLine() 'read from the console everything until a new line
        Console.WriteLine("hello " & name) ' concatonate the sting literal and the string variable
        Console.WriteLine()

        Console.WriteLine("Lets play a game where i say something and i ""Shout"" it back")
        Console.Write("What should i ""shout""? -> ")
        input1 = Console.ReadLine
        Console.WriteLine(input1.ToUpper & vbNewLine) 'the ToUpper method is a string function to make all the text uppercase

        Console.WriteLine("That was fun. Let's do it again!")
        Console.Write("now, what should i ""shout""? -> ")
        input2 = Console.ReadLine
        Console.WriteLine(input2.ToUpper & vbNewLine)

        Console.WriteLine("I like this! Let;s do it again!")
        Console.Write("One more time, What should i ""shout""? -> ")
        input3 = Console.ReadLine
        Console.WriteLine(input3.ToUpper & vbNewLine)

        Console.WriteLine("Oh that wsa fun! Let's try ""whispering"" all of that back now")
        Console.WriteLine(input1.ToLower)
        Console.WriteLine(input2.ToLower)
        Console.WriteLine(input3.ToLower)
        Console.ReadKey()




    End Sub

End Module


