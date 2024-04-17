//El usuario ingresa un número entero positivo N y se deben mostrar todos los números enteros positivos pares desde 0 (incluido) hasta N.


using System;

Console.Write("Ingrese un entero positivo: ");
int N;

if (int.TryParse(Console.ReadLine(), out N) & N >= 0)
{
    for (int i = 0; i <= N; i += 2)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Error, ingrese un entero positivo");
}