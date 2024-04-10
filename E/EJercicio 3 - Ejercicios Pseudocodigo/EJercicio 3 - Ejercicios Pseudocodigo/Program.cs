using System;
Console.Write("Ingrese el lado: ");
int lado;
if (!Int32.TryParse(Console.ReadLine(), out lado))
{
    Console.WriteLine("Error un numero");
}
else
{
    Console.WriteLine("El area del cuadrado es de " + (lado * lado));
}