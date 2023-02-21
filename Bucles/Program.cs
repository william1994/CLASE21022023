// See https://aka.ms/new-console-template for more information



#region Bucles
//La primera parte de un bucle for es para inicializar la iteracion
//Segunda parte es decirle hasta donde llegara el bucle for
//Tercera parte es indicar de cuanto sera el crecimiento de nuestra variable inicial
//for (int indice=0;indice<=10;indice++) {
//    Console.WriteLine($"Hello, World! {indice}");
//}
//int[] numero = { 1, 2, 36, 6 };
//Arreglo de una dimension
//String[] Estudiantes = {"Steven","Amy","Kenia"};

//for (int i=0; i < Estudiantes.Length; i++ ) {
//    Console.WriteLine(Estudiantes[i]);
//}

//Console.WriteLine(Estudiantes[1]);

//foreach (var mostrar in Estudiantes) {
//    Console.WriteLine(mostrar);
//}
#endregion

#region Arreglos 

using Bucles.Entidades;
using Bucles.Negocio;

Estudiante estudiante = new Estudiante();
ClsEstudiante ClsEstudiante = new ClsEstudiante();

estudiante.Nombre = "William";
estudiante.Apellido = "Diaz";
estudiante.Edad = 28;

var Listado= ClsEstudiante.AgregarEstudiante(estudiante);
//foreach (var mostrar in Listado) { }

#endregion