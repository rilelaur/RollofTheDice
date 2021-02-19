'Laura Riley
'RCET 0265
'Spring 2021
'

Option Explicit On
Option Strict Off
Module RollOfTheDice

    Sub Main()
        Dim roll(12) As Integer

        Console.WriteLine("Roll of the Dice")

        'rolls the dice 1000 times  
        For i = 0 To 1000
            roll(RollDice(12)) += 1
        Next

        'writes the line above the row
        Console.WriteLine(StrDup(77, "-"))

        'writes the numbers 2 to 12
        For i = 2 To 12
            Console.Write(Str(i).PadLeft(6) & "|")
        Next

        'starts a new line and then writes a line of dashes
        Console.WriteLine(vbCrLf & StrDup(77, "-"))

        '
        For i = 2 To UBound(roll)
            Console.Write(CStr(roll(i)).PadLeft(6) & "|")
        Next
        Console.ReadLine()
    End Sub

    '
    Function RollDice(maxNumber As Integer) As Integer
        Randomize()

        'Generates a number between 2 and 12
        maxNumber = Int((12 - 2 + 1) * Rnd() + 2)

        Return CInt(maxNumber)
    End Function
End Module
