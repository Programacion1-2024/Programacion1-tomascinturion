using System;

//Calcular el promedio de tres números.

Console.Write("Ingrese un numero: ");
float num1, num2, num3, prom;
if (!float.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Error, ingrese un numero");
}

else
{
    Console.Write("Ingrese el segunto numero: ");
    if(!float.TryParse(Console.ReadLine(),out num2))
    {
        Console.WriteLine("Error, ingrese un numero");
    }
    else
    {
        Console.Write("Ingrese el tercer numero: ");
        if(!float.TryParse(Console.ReadLine(),out num3))
        {
            Console.WriteLine("Error, ingrese un numero");
        }
        else
        {
            prom = (num1 + num2 + num3) / 3;
            Console.WriteLine("El promedio es de: " +  prom);
        }
    }
}

