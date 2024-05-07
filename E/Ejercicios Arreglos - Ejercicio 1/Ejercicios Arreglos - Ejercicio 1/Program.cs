// Ejercicio 1: Ingresar datos en un arreglo y mostrarlos
//Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos
//números en un arreglo y luego mostrarlos en la consola.


using System;

int[] numeros = new int[5];
int num = 0;
for (int i = 0; i <= 4; i++)
{
    Console.Write("Ingrese un numero entero: ");
    if (int.TryParse(Console.ReadLine(), out num))
    {
        numeros[i] = num;
    }
    else
    {
        Console.WriteLine("Error, ingrese un numero valido");
        i--;
    }
}

for (int i = 0; i < 5; i++)
{
    Console.Write($"{numeros[i]}, ");
}
