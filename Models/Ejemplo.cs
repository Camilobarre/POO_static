using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;
public class Ejemplo
{
    public string Nombre {get; set;}
    public string Apellido {get; set;}

    public Ejemplo()
    {
        Nombre = "Camilo";
        Apellido = "Barreneche Escobar";
    }

    public void Saludar(){
        Console.WriteLine($"Hola a todos, soy {Nombre} {Apellido}");
    }        
}