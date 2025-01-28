
Option Explicit On
Option Strict On
Option Compare Text

Module ProgramFlowS25

    Sub Main()
        Dim myNumber As Integer
        Dim userInput As String

        ''assign 5 to myNumber
        'myNumber = 5

        ''test is myNumber greater than 6
        ''display the result on the console
        'If myNumber > 6 Then
        '    Console.WriteLine(myNumber > 6)
        'End If

        'If myNumber > 3 Then
        '    Console.WriteLine(myNumber > 3)
        'End If

        'If myNumber > 4 Then
        '    Console.WriteLine(myNumber > 4)
        'End If

        ''if anything evaluates to true all other evaluations are skipped
        'If myNumber > 6 Then
        '    Console.WriteLine(myNumber > 6)
        'ElseIf myNumber > 3 Then
        '    Console.WriteLine(myNumber > 3)
        'ElseIf myNumber > 4 Then
        '    Console.WriteLine(myNumber > 4)
        'End If


        'myNumber -= 3
        ''if none of the conditions evaluates to true the Else clause triggers
        'If myNumber > 6 Then
        '    Console.WriteLine($"{myNumber} is a big number!")
        'ElseIf myNumber > 3 Then
        '    Console.WriteLine($"Sorry not tall enough..")
        'ElseIf myNumber > 4 Then
        '    Console.WriteLine($"who cares")
        'Else
        '    Console.WriteLine($"Not sure what happened")
        'End If

        'Do
        '    Console.WriteLine("Please enter your age:")
        '    userInput = Console.ReadLine()

        '    Try
        '        myNumber = CInt(userInput)
        '        Select Case myNumber
        '            Case 0 To 3
        '                Console.WriteLine("Where are your parents?")
        '            Case 4 To 10
        '                Console.WriteLine("Sorry kid, why don't you try the tea cups...")
        '            Case 11 To 64
        '                Console.WriteLine("Enjoy the ride?")
        '            Case 65 To 99
        '                Console.WriteLine("Please sign this liability release form.")
        '            Case > 100
        '                Console.WriteLine("Someone misplace their mamauh!")
        '            Case Else
        '                Console.WriteLine("Well this is weird...")
        '        End Select
        '    Catch ex As Exception
        '        Console.WriteLine($"You entered {userInput}.")
        '    End Try

        'Loop Until userInput = "Q"

        'Console.WriteLine("Have a nice day!")



        'userInput = "5"


        'Do
        '    'Console.WriteLine("Type something and press enter:")
        '    'userInput = Console.ReadLine()
        '    Console.WriteLine($"In the Do, Loop Until: ")
        '    userInput = "q"
        'Loop Until userInput = "Q"

        Do Until userInput = "Q"
            Console.WriteLine("Type something and press enter:")
            userInput = Console.ReadLine()
            Console.WriteLine($"In the Do Until, Loop: ")
        Loop




    End Sub

End Module
