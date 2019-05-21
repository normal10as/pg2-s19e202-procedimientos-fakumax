Imports System
Imports System.Math
'2.3. Crear un proyecto y un m�dulo llamado �Hipotenusa� que implemente una funci�n que
'reciba el tama�o de los lados A y B, calcule y devuelva C (hipotenusa). Dados los lados A y
'B de un tri�ngulo rect�ngulo, seg�n el teorema de Pit�goras, el cuadrado de la hipotenusa
'(C), es igual a la suma del cuadrado de los catetos (lados) de lo que se da la siguiente
'f�rmula: c� = a� + b�. Ingresar los valores por teclado y mostrar el resultado en consola.
Module Hipotenusa
    Sub Main(args As String())
        Dim a, b As Double
        Console.WriteLine("Ingrese lado 'A' : ")
        a = Console.ReadLine
        Console.WriteLine("Ingrese lado 'B' : ")
        b = Console.ReadLine
        Console.WriteLine("El resultado 'C' es : " & hipotenusa(a, b))

    End Sub
    Function hipotenusa(a As Double, b As Double) As Decimal
        Return Sqrt((a ^ 2) + (b ^ 2))
    End Function
End Module
