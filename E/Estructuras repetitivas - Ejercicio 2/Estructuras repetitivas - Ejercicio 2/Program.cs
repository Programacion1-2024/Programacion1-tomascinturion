using System;
Console.WriteLine("Ingrese los numeros: ");

float promedio = 0;
for (int i = 0; i <= 7; i++)
{
    Console.Write($"Numero {i}: ");
    if (!float.TryParse(Console.ReadLine(), out float suma))
    {
        Console.WriteLine("Error, ingrese un numero valido");
        i--;
    }
    else
    {
        promedio += suma;
    }
}
float resutado = promedio / 8;
Console.WriteLine($"El promedio es de: {resutado}");
