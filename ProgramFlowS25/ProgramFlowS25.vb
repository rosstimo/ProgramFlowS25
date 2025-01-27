
Option Explicit On
Option Strict On

Module ProgramFlowS25

    Sub Main()
        Dim myNumber As Integer

        'assign 5 to myNumber
        myNumber = 5

        'test is myNumber greater than 6
        'display the result on the console
        If myNumber > 6 Then
            Console.WriteLine(myNumber > 6)
        End If

        If myNumber > 3 Then
            Console.WriteLine(myNumber > 3)
        End If

        If myNumber > 4 Then
            Console.WriteLine(myNumber > 4)
        End If

        'if anything evaluates to true all other evaluations are skipped
        If myNumber > 6 Then
            Console.WriteLine(myNumber > 6)
        ElseIf myNumber > 3 Then
            Console.WriteLine(myNumber > 3)
        ElseIf myNumber > 4 Then
            Console.WriteLine(myNumber > 4)
        End If


        myNumber -= 3
        'if none of the conditions evaluates to true the Else clause triggers
        If myNumber > 6 Then
            Console.WriteLine($"{myNumber} is a big number!")
        ElseIf myNumber > 3 Then
            Console.WriteLine($"Sorry not tall enough..")
        ElseIf myNumber > 4 Then
            Console.WriteLine($"who cares")
        Else
            Console.WriteLine($"Not sure what happened")
        End If



    End Sub

End Module
