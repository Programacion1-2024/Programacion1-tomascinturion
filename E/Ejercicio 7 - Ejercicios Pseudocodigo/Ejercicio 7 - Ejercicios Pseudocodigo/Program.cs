using System;

Console.Write("Ingrese un numero: ");
float num1, num2, mayor;
if(!float.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Error, ingrese un numero");
}
else
{
    Console.Write("Ingrese el segundo numero: ");
    if(!float.TryParse(Console.ReadLine(),out num2))
    {
        Console.WriteLine("Error, ingrese un numero");
    }
    else
    {
        if(num1 > num2)
        {
            mayor = num1;
            Console.WriteLine("El mayor de los dos numeros es el: " + mayor);
        }
        else
        {
            mayor = num2;
            Console.WriteLine("El mayor de los dos numeros es el: " + mayor);
        }
    }
}

