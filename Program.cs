using POO_static.Models;

//Uso de Propiedades y métodos
Console.Clear();
// var ejemplo1 = new Ejemplo();
// Console.WriteLine("Nombre=> "+ ejemplo1.Nombre);
// Console.WriteLine("Apellido => "+ ejemplo1.Apellido);
// ejemplo1.Saludar();

//Uso de propiedades y métodos pero con el STATIC
//Sirve para acceder a las propiedades sin necesidad de instanciarlas
// EjemploEstatico.Nombre ="Camilo";
// EjemploEstatico.Apellido = "Barreneche Escobar";
// EjemploEstatico.Saludar();
// Console.WriteLine("Nombre=> "+ EjemploEstatico.Nombre);
// Console.WriteLine("Apellido => "+ EjemploEstatico.Apellido);
// EjemploEstatico.Saludar();

//Uso de un Constructor static
// EjemploEstatico.Saludar();

EjemploHibrido.MostrarHeader();
var nuevoUsuario = new EjemploHibrido(1,"Camilo", "Barreneche Escobar", 180);
Console.WriteLine(EjemploHibrido.FechaActual);
nuevoUsuario.MostrarInformacion();
EjemploHibrido.MostrarFooter();