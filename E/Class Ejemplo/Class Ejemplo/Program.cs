using System;

class coche
{//atributos
    string Modelo;
    int Anio;
    string Color;
    //Constructos
    public coche(string Modelo, int Anio, string Color)
    {
        this.Modelo = Modelo;
        this.Anio = Anio;
        this.Color = Color;
    }
    //Metodos
    public string getModelo()
    {
        return Modelo;
    }
    public void setModelo(string Modelo)
    {
        this.Modelo=Modelo;
    }
    public void Correrle(coche autito)
    {
        Console.WriteLine($"El { getModelo()} le corre a {autito.getModelo()}");
    }
}
public class Terminal
{
    public static void Main(string[] args)
    {
        coche auto1 = new coche("Corolla", 2006, "blanco");
        coche auto2 = new coche("Cruze", 2020, "negro");
        //auto1.getModelo();
        //  auto2.getModelo();
        //auto1.setModelo("Etios");
        auto1.Correrle(auto2);//el (corolla), le corre a  (cruze)
    }
}
