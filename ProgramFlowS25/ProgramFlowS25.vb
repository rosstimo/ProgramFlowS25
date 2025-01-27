
Option Explicit On
Option Strict On

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
        Console.WriteLine("Please enter your age:")
        userInput = Console.ReadLine()
        myNumber = CInt(userInput)

        Select Case myNumber
            Case 0 To 3

            Case 4 To 10

            Case 11 To 64

            Case 65 To 99

            Case > 100

            Case Else

        End Select



    End Sub

End Module
