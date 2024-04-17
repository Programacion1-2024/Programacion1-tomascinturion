//Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados.

using System;


float numero;
float suma = 0;
float promedio;
int cant = -1;
do
{
    Console.Write("Ingrese un numero positivo: ");
    if (float.TryParse(Console.ReadLine().Replace(".", ","), out numero) & numero >= 0)
    {
        suma += numero;
        cant += 1;
    }
    else
    {
        Console.WriteLine("Error, Ingrese un numero positivo");
    }
}
while (numero > 0);
promedio = suma / cant;
Console.WriteLine($"El promedio de los numeros ingresado es: {promedio}");
