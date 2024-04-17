//El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado, indicar el cliente que gastó más.


using System;
using System.ComponentModel.Design;

Console.WriteLine("Ingrese los nombres");
String nombres = "";
String nombremax = "";
float total = 0;
float totalmax = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ingrese el nombre {i}: ");
    nombres = Console.ReadLine();
    if (string.IsNullOrEmpty(nombres))
    {
        Console.WriteLine("Error, ingrese un nombre");
        i--;
    }
    else
    {
        Console.Write($"Ingrese el monto total del cliente {i}: ");
        if (float.TryParse(Console.ReadLine(), out total))
        {
            if (total > totalmax)
            {
                nombremax = nombres;
                totalmax = total;

            }
        }
        else
        {
            Console.WriteLine("Error, ingrese un numero valido");
        }
    }
}
Console.WriteLine($"El cliente que mas gasto fue {nombremax}");