using System;
using System.Timers;
Console.WriteLine("Ingrese los costos y cantidad de preductos:");

float factura = 0;

for (int i = 0; i <= 4 ; i++)
{
    Console.Write($"Ingrese el costo {i}: ");
    if (float.TryParse( Console.ReadLine(),out float cost))
    {
        Console.Write($"Ingrese la cantidad comprada del producto {i}: ");
        if(int.TryParse( Console.ReadLine(),out int cant))
        {
            factura += (cost * cant);
            
        }
        else
        {
            Console.WriteLine("Error, ingrese un numero valido");
            i--;
        }
    }
    else
    {
        Console.WriteLine("Error, ingrese un numero valido");
        i--;
    }
}
Console.WriteLine("El monto final de la factura es de: " + factura);
