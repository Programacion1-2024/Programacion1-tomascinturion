//Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de los números negativos ingresados.
float numero = 0;
float promedio = 0;
int cont = -1;
float suma = 0;
do
{
    Console.Write("Ingrese un numero, la lista finalizara cuando ingrese un positivo: ");
    if (!float.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Error, ingrese un numero valido");
    }
    else
    {
        cont += 1;
        suma += numero;
        promedio = suma / cont;
    }
    
}
while (numero < 0);
Console.WriteLine($"El promedio de los numeros ingresados es de {promedio}");


