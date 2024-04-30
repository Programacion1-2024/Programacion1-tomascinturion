// Retomando el ejercicio 1 ; al finalizar la carga de productos, se ingresan las ventas que hubo por cada código, puede haber más de 1 venta por cada articulo. El ingreso finaliza al colocar un código en 0. Informar al final los que tienen una cantidad (o sea la cantidad inicial , restando las ventas que tuvo) menor o igual a 0.
int stock = 0;
int cant = 0;
int codigo = 0;
do
{
    Console.Write("Ingrese el codigo del producto: ");
    if (int.TryParse(Console.ReadLine(), out codigo) && codigo <= 10 && codigo > 0)
    {
        Console.Write("Ingrese el stock del producto: ");
        if (int.TryParse(Console.ReadLine().Replace(".", ","), out stock))
        {
            Console.Write("Ingrese la cantidad comprada: ");
            if (int.TryParse(Console.ReadLine(), out cant))
            {
                stock -= cant;
                if (stock <= 0)
                {
                    Console.WriteLine($"Falta stock del producto {codigo}");
                }
            }
            else
            {
                Console.WriteLine("Error, ingrese una cantidad valida");
            }
        }
        else
        {
            Console.WriteLine("Error, ingrese un stock valido");
        }
    }
    else
    {
        Console.WriteLine("Error, ingrese un codigo valido");
    }
}
while (codigo != 0);
