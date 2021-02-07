Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/dylannelson58/Mulitiplication_Table

Module Multiplication_Table

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim table As String


        Console.WriteLine($"Enter the first number for your multiplication table.")
        firstNumber = CInt(Console.ReadLine())
        Console.WriteLine($"Enter the second number for your multiplication table.")
        secondNumber = CInt(Console.ReadLine())
        Console.Write($"{firstNumber} to {secondNumber}.")

        Console.Clear()
        Console.WriteLine($"Enjoy your {firstNumber} x {secondNumber} table!")


        For j = 1 To CInt(firstNumber)

            For i = 1 To CInt(secondNumber)


                table = CStr(j * i)
                Console.Write(table.padleft(5))


            Next
            Console.WriteLine()
        Next
        Console.Read()

    End Sub

End Module
