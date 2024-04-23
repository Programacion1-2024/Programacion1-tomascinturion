// Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que ingrese un positivo.
float numero = 0;
do
{
    Console.Write("Ingrese un numero: ");
    if (!float.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Error, ingrese un numero valido");
    }
}
while (numero < 0);
