using System;
//Calcular el perímetro de un triángulo.
Console.Write("Ingrese un lado: ");
float lado1, lado2, lado3, perimetro;
if (!float.TryParse(Console.ReadLine(), out lado1))
{
    Console.WriteLine("Error, ingrese un numero");
}
else
{
    Console.Write("Ingrese el segundo lado: ");
    if(!float.TryParse(Console.ReadLine(),out lado2))
    {
        Console.WriteLine("Error, ingrese un numero");
    }
    else
    {
        Console.Write("Ingrese el tercer lado: ");
        if (!float.TryParse(Console.ReadLine(), out lado3))
        {
            Console.WriteLine("Error, ingerese un numero");
        }
        else
        {
            perimetro = (lado1 + lado2 + lado3);
            Console.WriteLine("El perimetro del triangulo es: " +  perimetro);
        }
    }
}