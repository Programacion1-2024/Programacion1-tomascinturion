using System;
using System.ComponentModel.Design;


Console.Write("Ingrese el numero: ");
int numero;
if (!Int32.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Error al ingresar el número.");
}
else
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("Es Par");
    }
    else
    {
        Console.WriteLine("Es Impar");
    }
}
