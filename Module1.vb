Module Module1

    Sub Main()

        Console.WriteLine("enter a defense item")
        Dim method As String = Console.ReadLine

        Console.WriteLine("enter the baloon colour")
        Dim colour As String = Console.ReadLine

        Dim balloon1 As Balloon = New Balloon(method, colour)

        balloon1 = defend(balloon1)

        Console.ReadLine()

    End Sub

    Function defend(myballoon)
        Dim strength As Integer
        Console.WriteLine("what is the strength of the opponent?")
        strength = Console.ReadLine

        myballoon.changehealth(-strength)
        Console.WriteLine("defenseitem: " & myballoon.getdefenceitem)

        If myballoon.checkhealth = True Then

            Console.WriteLine("defense failed")
        Else

            Console.WriteLine("defense succeeded")
        End If

        Return myballoon

        Console.ReadLine()
    End Function

End Module
