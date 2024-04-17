//El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0 (cero). El sistema deberá informar la suma de los ingresados.
float numero;
float suma = 0;
do
{
    Console.Write("Ingrese un numero positivo: ");
    if (float.TryParse(Console.ReadLine().Replace(".",","), out numero) & numero >= 0)
    {
        suma += numero;
    }
    else
    {
        Console.WriteLine("Error, Ingrese un numero positivo");
    }
}
    while(numero  > 0);
Console.WriteLine($"La suma de los numeros ingresado es: {suma}");