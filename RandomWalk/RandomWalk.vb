Option Strict On
Option Explicit On
Option Compare Text

Module RandomWalk

    Sub Main()
        Dim userInput As String
        Dim randomNumber As Integer
        Do While userInput <> "Q"
            For i = 1 To 10
                GetRandomNumber(1, 10)
                Console.WriteLine(randomNumber)
                Console.ReadLine()
            Next
            userInput = Console.ReadLine()
            Console.Clear()
        Loop
    End Sub

    'Sub RandomExample()
    '    Dim userInput As String
    '    Randomize()
    '    Dim value As Integer
    '    Do While userInput <> "Q"
    '        For i = 1 To 10
    '            value = CInt(Int((6 * Rnd()) + 1))
    '            Console.WriteLine(value)
    '        Next
    '        userInput = Console.ReadLine()
    '        Console.Clear()
    '    Loop
    'End Sub

    Function GetRandomNumber(ByVal Minimum As Integer, ByVal Maximum As Integer) As Integer

        Dim value As Single

        Randomize()

        value = CInt(Int((6 * Rnd()) + 1))
        value = ((Maximum - Minimum + 1) * Rnd())


        Console.WriteLine(value)
        Console.WriteLine(CInt(value))
        Return CInt(value)


    End Function




End Module
