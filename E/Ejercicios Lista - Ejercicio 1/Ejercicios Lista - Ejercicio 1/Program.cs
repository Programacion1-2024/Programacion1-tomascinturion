//Ejercicio 3: Ingresar datos en una lista y mostrarlos
//Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos
//números en una lista y luego mostrarlos en la consola.
using System;
  
List<int> numeros = new List<int>();
for (int i = 0; i < 5; i++)
{
    Console.Write("Ingrese un numero entero: ");
    if(int.TryParse(Console.ReadLine(),out int num))
    {
        numeros.Add(num);
    }
    else
    {
        Console.WriteLine("Error, ingrese un numero valido.");
        i--;
    }
}
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}