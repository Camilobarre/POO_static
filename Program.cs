﻿using POO_static.Models;

//Uso de Propiedades y métodos
Console.Clear();
var ejemplo1 = new Ejemplo();
Console.WriteLine("Nombre=> "+ ejemplo1.Nombre);
Console.WriteLine("Apellido => "+ ejemplo1.Apellido);
ejemplo1.Saludar();

//Uso de propiedades y métodos pero con el STATIC
//Sirve para acceder a las propiedades sin necesidad de instanciarlas
EjemploEstatico.Nombre ="Camilo";
EjemploEstatico.Apellido = "Barreneche Escobar";
EjemploEstatico.Saludar();
Console.WriteLine("Nombre=> "+ ejemplo1.Nombre);
Console.WriteLine("Apellido => "+ ejemplo1.Apellido);
ejemplo1.Saludar();