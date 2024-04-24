//Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese un número mayor a 3 cifras. Mostrar la suma total de todos los ingresados antes del corte.
using System;

float suma = 0;
float num = 0;
do
{
    Console.Write("Ingrese un numero, la lista finalizara cuando ingrese un numero mayor a tres cifras: ");
    if (float.TryParse(Console.ReadLine().Replace(".",","), out num))
    {
        if(num < 100 && num > -100)
        {
            suma += num;
        }
    }
    else
    {
        Console.WriteLine("Error, ingrese un numero valido");
    }
}
while (num < 100 && num > -100);
Console.WriteLine(suma);
