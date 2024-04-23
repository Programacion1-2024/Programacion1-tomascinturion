//Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave, repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788.
using System;
int contra;

do
{
    Console.Write("Usuario: ");
    Console.ReadLine();
    Console.Write("Contraseña: ");
    if (!int.TryParse(Console.ReadLine(), out contra) && contra != 667788)
    {
        Console.WriteLine("Contraseña incorrecta");
    }

}
while (contra != 667788);
Console.WriteLine("Ingresando");