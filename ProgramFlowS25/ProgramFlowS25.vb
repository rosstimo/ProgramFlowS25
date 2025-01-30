Option Explicit On
Option Strict On
Option Compare Text

Imports System.Net.Security

Module ProgramFlowS25

    Sub Main()
        Dim firstNumber As Integer
        Dim getOutOfHere As Boolean = False
        Dim userInput As String

        Do
            Console.WriteLine("Enter a number")
            Console.WriteLine("Enter Q to quit")
            userInput = Console.ReadLine()
            Console.WriteLine($"you entered {userInput}")
            Try
                firstNumber = CInt(userInput)

            Catch ex As Exception
                If userInput <> "Q" Then
                    Console.WriteLine($"{userInput} is not whole number... :(  ")
                End If
            End Try



            ' Console.Clear()

        Loop While userInput <> "Q"




    End Sub

End Module
