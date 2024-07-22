using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;
public class EjemploEstatico    
{
    public static string Nombre {get; set;}
    public static string Apellido {get; set;}

    public EjemploEstatico()
    {
        Nombre = "Camilo";
        Apellido = "Barreneche Escobar";
    }

    public static void Saludar(){
        Console.WriteLine($"Hola a todos, soy {Nombre} {Apellido}");
    }         
}