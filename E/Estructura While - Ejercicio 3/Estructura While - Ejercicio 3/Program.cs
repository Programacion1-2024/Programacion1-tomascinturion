//El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío, sin datos; el sistema informará cuántos nombres de han ingresado.
using System;
int cant = -1;
string nombre ="a";
Console.WriteLine("Ingrese el nombre: ");
while (!string.IsNullOrEmpty(nombre))
{
    
    nombre = Console.ReadLine();
    cant += 1;

};
Console.WriteLine($"La cantidad de nombres ingresados es de: {cant}");


