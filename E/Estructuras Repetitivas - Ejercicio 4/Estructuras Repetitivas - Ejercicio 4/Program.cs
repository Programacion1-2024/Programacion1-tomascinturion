using System;

Console.WriteLine("Ingrese la lista de numeros");
float max = 0;
float num;

for (int i = 0; i < 7; i++)
{
    Console.Write($"Ingrese el numero {i}: ");
    if (!float.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Error, ingrese un numero valido");
        i--;
    }
    else
    {
        if( i == 0)
        {
            max = num;
        }
        else if (num > max)
        {
            max = num;
        }
    }
}
Console.WriteLine($"El numero mayor es {max}");
