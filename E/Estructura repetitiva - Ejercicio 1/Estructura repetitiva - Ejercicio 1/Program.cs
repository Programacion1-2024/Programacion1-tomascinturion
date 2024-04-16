using System;
using System.Timers;
Console.Write("Ingrese 5 numeros: ");

float suma = 0;
for (int i = 0; i <= 4; i++)
{
    Console.Write($"valor {i}: ");
    if(!float.TryParse(Console.ReadLine(), out float numero))
    {
        Console.WriteLine("Error, numero no valido");
        i--;
    }
    else
    {
        suma += numero;
    }
}
Console.WriteLine($"El valor de la suma es de: {suma}");
