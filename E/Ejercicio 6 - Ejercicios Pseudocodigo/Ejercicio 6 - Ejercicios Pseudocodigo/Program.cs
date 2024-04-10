using System;

Console.Write("Ingrese un numero: ");
float num;
if (!float.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Error, ingrese un numero");
}
else
{
    if(num > 0)
    {
        Console.WriteLine("El numero es positivo");
    }
}
