// Siguiendo con el ejercicio anterior, al ingresar uno mayor a 3 cifras se mostrará el promedio de los ingresados.
float suma = 0;
float num = 0;
float promedio = 0;
int cont = 0;
do
{
    Console.Write("Ingrese un numero, la lista finalizara cuando ingrese un numero mayor a tres cifras: ");
    if (float.TryParse(Console.ReadLine().Replace(".", ","), out num))
    {
        if (num < 100 && num > -100)
        {
            suma += num;
            cont++;
        }
        else
        {
            promedio = 0;
        }
    }
    else
    {
        Console.WriteLine("Error, ingrese un numero valido");
    }
}
while (num < 100 && num > -100);

if(cont != 0)
{
    promedio = suma / cont;
    Console.WriteLine($"El promedio es de {promedio}");
}
else
{
    Console.WriteLine("El promedio es inexistente");
}
