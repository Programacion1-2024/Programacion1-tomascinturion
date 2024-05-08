//1 - Ordenar palabras alfabéticamente
//El usuario ingresará una lista de palabras. El programa debe guardar, ordenar estas
//palabras alfabéticamente y mostrarlas en la consola.

List<string> palabras = new List<string>();
string palabra;
do
{
    Console.Write("Ingresa una palabra, finaliza la carga con un lugar en blanco: ");
    palabra = Console.ReadLine();
    if (!string.IsNullOrEmpty(palabra))
    {
        palabras.Add(palabra);
        palabras.Sort();
    }
}
while (!string.IsNullOrEmpty(palabra));
foreach(string pal in palabras)
{
    Console.WriteLine(pal);
}