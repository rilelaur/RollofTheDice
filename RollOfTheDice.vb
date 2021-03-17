'Laura Riley
'RCET 0265
'Spring 2021
'Roll of the Dice
'https://github.com/rilelaur/RollofTheDice.git

Option Explicit On
Option Strict On
Module RollOfTheDice

    Sub Main()
        Dim roll(12) As Integer

        Console.WriteLine(StrDup(33, " ") & "Roll of the Dice" & StrDup(33, " "))

        'rolls the dice 1000 times and increments whichever number that is generated
        For i = 1 To 1000
            roll(RandomNumber(6) + RandomNumber(6)) += 1
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

    'Generates a random number
    Function RandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Ceiling(Rnd() * maxNumber))
    End Function
End Module
