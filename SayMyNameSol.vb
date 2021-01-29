
Option Strict On
Option Explicit On
'Sean Gingerich
'RCET0265
'Fall 2020
'Say My Name Again
'https://github.com/gingsean5/SayMyName
Module SayMyNameSol

    Sub Main()
        Dim userName As String

        'While problem = True
        Console.WriteLine("What is your name?")
        userName = Console.ReadLine()
        If userName = "Emily" Then
            Console.WriteLine("So nice to see you again Emily!")
        ElseIf userName = "emily" Then
            Console.WriteLine("So nice to see you again Emily!")
        ElseIf userName = "Joe" Then
            Console.WriteLine("So nice to see you again Joe!")
        ElseIf userName = "joe" Then
            Console.WriteLine("So nice to see you again Joe!")
        ElseIf userName = "Sean" Then
            Console.WriteLine("Thank you for the gift of life your excellency")
        ElseIf userName = "sean" Then
            Console.WriteLine("Thank you for the gift of life your excellency")
        Else
            Console.WriteLine($"Why should I care {userName}? ")
        End If

        Console.Read()
    End Sub

End Module
