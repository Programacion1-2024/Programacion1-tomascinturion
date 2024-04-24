// Se ingresa el código de producto (son 10 productos, codificados del 1 al 10), luego el precio y la cantidad que hay del mismo. La carga finaliza cuando se ingresa un código = 0 ; al terminar indicar el código de producto que mayor cantidad tiene.
float precio = 0;
int cant = 0;
int codigo = 0;
float cantmax = 0;
int codigomax = 0;
do
{
    Console.Write("Ingrese el codigo del producto: ");
    if (int.TryParse(Console.ReadLine(), out codigo) && codigo <= 10 && codigo > 0)
    {
        Console.Write("Ingrese el precio del producto: ");
        if(float.TryParse(Console.ReadLine().Replace(".",","),out precio))
        {
            Console.Write("Ingrese la cantidad comprada: ");
            if(int.TryParse(Console.ReadLine(),out cant))
            {
                if (cantmax < cant)
                {
                    cantmax = cant;
                    codigomax = codigo;
                }
            }
            else
            {
                Console.WriteLine("Error, ingrese una cantidad valida");
            }
        }
        else
        {
            Console.WriteLine("Error, ingrese un precio valido");
        }
    }
    else
    {
        Console.WriteLine("Error, ingrese un codigo valido");
    }
}
while (codigo != 0);
Console.WriteLine($"El codigo que mayor cantidad tiene es {codigomax}");
