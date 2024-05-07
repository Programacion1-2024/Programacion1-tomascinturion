//Ejercicio 2: Calcular promedio de notas utilizando un arreglo
//Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas
//notas y mostrarlo en la consola. Utiliza un arreglo para almacenar las notas.

using System;

float[] notas = new float[5];
float not = 0;
float promedio = 0;
float suma = 0;

for (int i = 0; i <= 4; i++)
{
    Console.Write("Ingrese una nota: ");
    if (float.TryParse(Console.ReadLine().Replace(".",","), out not))
    {
        notas[i] = not;
        suma += notas[i];
    }
    else
    {
        Console.WriteLine("Error, ingrese un numero valido");
        i--;
    }
}
Console.WriteLine(promedio = suma / notas.Length);
