//Ejercicio 4: Calcular promedio de notas utilizando una lista
//Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas
//notas y mostrarlo en la consola. Utiliza una lista para almacenar las notas.
using System;

List<float> notas = new List<float>();
float suma = 0;
float promedio = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write("Ingrese una nota: ");
    if(float.TryParse(Console.ReadLine(), out float not))
    {
        notas.Add(not);
        suma += not;
    }
    else
    {
        Console.WriteLine("Error, ingrese un numero valido");
        i--;
    }
}
Console.WriteLine(promedio = suma / notas.Count());