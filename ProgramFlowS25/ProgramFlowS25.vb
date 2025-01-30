
Option Explicit On
Option Strict On
Option Compare Text

Module ProgramFlowS25

    Sub Main()
        Dim firstNumber As Integer


        Do
            Console.WriteLine("In the first loop. Loop While firstNumber <= 3")
            firstNumber += 1
            Console.WriteLine($"FirstNumber is {firstNumber}!")
        Loop While firstNumber <= 3

        Console.WriteLine()

        Do
            Console.WriteLine("In the second loop. Loop While firstNumber <= 3")
            firstNumber += 1
            Console.WriteLine($"FirstNumber is {firstNumber}!")
        Loop While firstNumber <= 3

        Console.WriteLine()

        Do Until firstNumber >= 3
            Console.WriteLine("In the third loop. Do Until firstNumber >= 3")
            firstNumber += 1
            Console.WriteLine($"FirstNumber is {firstNumber}!")
        Loop

        Do While firstNumber >= 3
            Console.WriteLine("In the fourth loop. Do While firstNumber >= 3")
            firstNumber -= 1
            Console.WriteLine($"FirstNumber is {firstNumber}!")
        Loop

        Console.WriteLine()

    End Sub

End Module
