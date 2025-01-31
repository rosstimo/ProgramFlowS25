﻿Option Explicit On
Option Strict On
Option Compare Text

Imports System.Net.Security

Module ProgramFlowS25

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim getOutOfHere As Boolean = False
        Dim userInput As String

        Do
            'get first number from user
            'always runs at least once
            'run until valid number or user quits

            Do
                Console.WriteLine("Enter the first number")
                Console.WriteLine("Enter Q to quit")
                userInput = Console.ReadLine()
                Console.WriteLine($"you entered {userInput}")
                Try
                    firstNumber = CInt(userInput)
                    getOutOfHere = True

                Catch ex As Exception
                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} is not whole number... :(  ")
                    Else
                        getOutOfHere = True
                    End If
                End Try
            Loop Until getOutOfHere = True

            'get second number from user
            'only runs if user has not already quit
            'run until valid number or user quits
            getOutOfHere = False 'reset flag
            Do While userInput <> "Q" And getOutOfHere = False
                Console.WriteLine("Enter the second number")
                Console.WriteLine("Enter Q to quit")
                userInput = Console.ReadLine()
                Console.WriteLine($"you entered {userInput}")
                Try
                    secondNumber = CInt(userInput)
                    getOutOfHere = True

                Catch ex As Exception
                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} is not whole number... :(  ")
                    Else
                        getOutOfHere = True
                    End If
                End Try
            Loop


            'get user choice 
            'only runs if user has not already quit
            'run until valid choice or user quits




        Loop While userInput <> "Q"




    End Sub

End Module
