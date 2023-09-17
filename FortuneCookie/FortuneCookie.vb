'Zachary Christensen
'RCET 2265
'Fall 2023
'Fortune Cookie
'https://github.com/Minidude140/FortuneCookie.git


Option Explicit On
Option Strict On

Module FortuneCookie

    'TODO
    '[*~]Make main loop: Quit, CLear messages, and Open cookie
    '[]OpenCookie Sub that writes message to the user
    '[]OpenCookie Sub should take random number to determine the response
    '[]Create at least 3 responses



    Sub Main()
        Dim exitFlag As Boolean = False
        Dim userInput As String

        Do While exitFlag = False
            Console.WriteLine("Hello, would you like a fortune cookie?" & vbLf & "(Press any key to Open a Cookie or Press Q to leave)")
            userInput = Console.ReadLine()
            Console.WriteLine()

            Select Case userInput
                Case = "Q", "q"
                    exitFlag = True
                Case Else
                    'open cookie routine
                    Console.WriteLine("*hands too weak to open cookie*" & vbLf & "You reluctantly return the cookie" & vbLf)
            End Select
        Loop


    End Sub

End Module
