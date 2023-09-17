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
    '[~]OpenCookie Sub that writes message to the user
    '[~]OpenCookie Sub should take random number to determine the response
    '[~]Create at least 3 responses



    Sub Main()
        Dim exitFlag As Boolean = False
        Dim userInput As String
        Dim cookiesOpened As Integer = 0

        Do While exitFlag = False

            If cookiesOpened = 0 Then
                Console.WriteLine("Hello, would you like a fortune cookie?" & vbLf & "(Press any key to Open a Cookie or Press Q to leave)")
                userInput = Console.ReadLine()
                Console.WriteLine()

                If userInput = "Q" Or userInput = "q" Then
                    exitFlag = True
                Else
                    'open cookie routine
                    'Console.WriteLine("*hands too weak to open cookie*" & vbLf & "You reluctantly return the cookie" & vbLf)
                    OpenCookie()
                    cookiesOpened += 1
                End If
            Else
                Console.WriteLine("Would you like another cookie?" & vbLf & "(Press any key to Open another Cookie, 'C' to throw away the old fortunes, or 'Q' to leave)")
                userInput = Console.ReadLine()
                Console.WriteLine()

                Select Case userInput
                    Case = "Q", "q"
                        exitFlag = True
                    Case = "C", "c"
                        Console.Clear()
                    Case Else
                        OpenCookie()
                End Select
            End If


        Loop


    End Sub

    Sub OpenCookie()
        Dim randomNumber As Integer
        Randomize()
        randomNumber = CInt((Rnd() * 10) / 2)
        Select Case randomNumber
            Case = 0
                '-Obi-Wan Kenobi, A New Hope
                Console.WriteLine("Who is the more foolish? The fool, or the fool who follows him?" & vbLf)
            Case = 1
                '-Obi-Wan Kenobi, The Clone Wars (2008)
                Console.WriteLine("A great leap forward often requires first taking two steps back." & vbLf)
            Case = 2
                'Plo-Koon, The Clone Wars (2008)
                Console.WriteLine("When You Ask For Trouble, You Should Not Be Surprised If It Finds You." & vbLf)
            Case = 3
                'Shmi Skywalker, The phantom Menace
                Console.WriteLine("The Biggest Problem In The Universe Is That Nobody Helps Each Other." & vbLf)
            Case = 4
                'Qui-Gon Jinn, The Phantom Menace
                Console.WriteLine("Your Focus Determines Your Reality." & vbLf)
            Case = 5
                'G-Man, Half-Life 2
                Console.WriteLine("The right man in the wrong place can make all the difference in the world." & vbLf)

        End Select

    End Sub

End Module
