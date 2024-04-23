//Para calcular el consumo total de un cliente, el usuario primero ingresará cuántos productos compró; luego el sistema solicitará que ingrese el costo de cada uno de esos productos consumidos; al terminar informará el total adeudado por el cliente.
using System;
int cant = 0;
int i = 1;
float precio = 0;
float factura = 0;
Console.Write("Ingrese la cantidad de productos comprada: ");
if(int.TryParse(Console.ReadLine(), out cant))
{
        while (i <= cant)
        {

            Console.Write($"Ingrese el costo del producto {i}: ");
            if (float.TryParse(Console.ReadLine(), out precio))
            {
                factura += precio;
                i += 1;
            }
            else
            {
                Console.WriteLine("Error, ingrese un precio valido");

            }
        }
    Console.WriteLine($"El monto a pagar es de {factura}");
}
else
{
    Console.WriteLine("Error, ingrese una cantidad valida");
}

