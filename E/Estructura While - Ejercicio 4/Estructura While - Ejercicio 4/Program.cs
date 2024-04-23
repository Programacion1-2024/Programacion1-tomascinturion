//Para calcular el total de una factura, el usuario ingresará pares de datos Costo unitario y cantidad comprada; cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado.
using System;

float cost = 1;
int cant = 0;
float factura = 0;
int i = 1;
Console.WriteLine("La lista finalizara al ingresar 0");
while (cost > 0)
{
    Console.Write($"Ingrese el costo unitario {i}: ");
    if (float.TryParse(Console.ReadLine(), out cost))
    {
        Console.Write($"Ingrese la cantidad comprada {i}: ");
        if (int.TryParse(Console.ReadLine(),out cant))
        {
            factura += (cost * cant);
            i += 1;
        }
        else
        {
            Console.WriteLine("Error ingrese una cantidad valida");
        }
    }
    else
    {
        Console.WriteLine("Ingrese un costo valido");
    }
}
Console.WriteLine($"El monto de la factura es de {factura}");