Imports System
Imports System.DateTime
'2.2. Crear un proyecto y un m�dulo llamado �Nueva_fecha� con una funci�n que reciba un valor
'fecha y un valor entero que representa una cantidad de d�as y retorne a la fecha sumada la
'cantidad de d�as. En el m�dulo principal ingresar una fecha y la cantidad de d�as, invocar a la
'funci�n creada y mostrar el valor obtenido.
Module Nueva_fecha
    Sub Main(args As String())
        Dim fecha As Date
        Dim cantidadDias As UShort
        Console.WriteLine("Ingrese una fecha :")
        fecha = Console.ReadLine
        Console.WriteLine("Ingrese una cantidad de dias :")
        cantidadDias = Console.ReadLine
        Console.WriteLine(recibeFecha(fecha, cantidadDias))
    End Sub

    Function recibeFecha(fecha As Date, cantidadDias As UShort) As String
        Return fecha.AddDays(cantidadDias)
    End Function
End Module
