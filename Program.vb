Imports System

Module Program
    Dim Base As Integer
    Dim Area As Integer
    Dim Altezza As Integer
    Sub Main()
        Dim scelta As String = "Si"
        While scelta = "Si" Or scelta = "SI" Or scelta = "si"
            Console.Write("Inserisci la Base del Triangolo: ")
            Base = Console.ReadLine
            Console.Clear()
            Console.Write("Inserisci la Altezza del Triangolo: ")
            Altezza = Console.ReadLine
            Console.Clear()
            Call AreaTriangolo()
            Console.WriteLine("Area: " & Area)
            Console.WriteLine("Vuoi Continuare? Si o No?")
            scelta = Console.ReadLine()
        End While
    End Sub
    Sub AreaTriangolo()
        Area = (1 / 2) * Base * Altezza
    End Sub
End Module
