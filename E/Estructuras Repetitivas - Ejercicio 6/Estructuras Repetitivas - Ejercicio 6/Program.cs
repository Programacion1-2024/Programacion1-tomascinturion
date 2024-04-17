//El usuario ingresa un número N y se debe mostrar como resultado el factorial de dicho número.

using System;

Console.WriteLine("Ingrese un numero entero: ");
int numero = 0;
int factorial = 1;
if (int.TryParse(Console.ReadLine(), out numero))
{
    for (int i = 1; i <= numero; i++)
    {
        factorial *= i;
    }
    
}
else
{
    Console.WriteLine("Error, ingrese un numero valido");
    
}
Console.WriteLine($"El factorial del numero ingresado es {factorial}");

