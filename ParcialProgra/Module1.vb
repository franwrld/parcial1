Module Module1

    Sub Main()
        Dim numeros(14) As Integer
        Dim conta2(14) As Integer
        Dim moda As Integer = 0
        Dim repeticion As Integer = 0
        Dim Posicion As Integer = 0
        Dim Posicion2 As Integer = 0
        Dim repeticion2 As Integer = 0
        Dim suma As Integer = 0
        Dim media As Integer = 0

        Console.WriteLine("_____________________________________________________")
        Console.WriteLine("   Parcial l Programacion Orientada a Objetos l")
        Console.WriteLine("              Carlos Francisco Ruiz Cortez")
        Console.WriteLine("_____________________________________________________")

        For contador = 0 To 14 Step 1
            Console.WriteLine("Ingresar un numero: " & contador + 1)
            numeros(contador) = Console.ReadLine()

            suma += numeros(contador)

        Next
        For contador = 0 To 14 Step 1
            conta2(contador) = 0

        Next
        For contador = 0 To 14 Step 1
            repeticion = numeros(contador)
            Posicion = contador
            For Posicion2 = contador To 15 - 1
                If (numeros(Posicion2) = repeticion) Then conta2(Posicion) += 1

            Next

        Next
        repeticion2 = conta2(0)
        moda = 0
        For contador = 0 To 14 Step 1
            If conta2(contador) > repeticion2 Then
                moda = contador
                repeticion2 = conta2(contador)

            End If

        Next
        Console.WriteLine("____________________________________________________")
        Console.WriteLine("MODA : " & numeros(moda))
        Console.WriteLine("____________________________________________________")
        Console.ReadLine()

        media = suma / numeros.Length
        Console.WriteLine("____________________________________________________")
        Console.WriteLine("MEDIA: " & media)
        Console.WriteLine("____________________________________________________")
        Console.ReadLine()

        Array.Sort(numeros)
        Console.WriteLine("____________________________________________________")
        Console.WriteLine("Numero Menor: " & numeros(0))
        Console.WriteLine("Numero Mayor: " & numeros(numeros.Length - 1))
        Console.WriteLine("____________________________________________________")
        Console.ReadLine()

    End Sub

End Module