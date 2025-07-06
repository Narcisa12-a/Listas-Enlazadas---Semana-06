//Programa principal que muestra un menu para ejecutar.
//1- Lista de numeros aleatorios con eliminacion por rango.
//2- Registro de estudiantes con listas enlazadas.
using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        //Creamos instancias de los dos programas.
        ListasNumeros listaNumeros = new ListasNumeros(); 
        RegistroEstudiantes registro = new RegistroEstudiantes();
        string opcion;
        do
        {
            //Menu principal
            Console.WriteLine("\n===MENÚ PRINCIPAL===");
            Console.WriteLine("1. Lista enlasada de números aleatorios");
            Console.WriteLine("2. Registro de estudiantes");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1": //Ejecuta el primer programa
                    listaNumeros.CrearLista();
                    listaNumeros.EliminarFueraDeRango();
                    break;
                case "2": //Ejecuta el segundo programa (abre se propio menú)
                    MenuRegistro(registro);
                    break;
                case "0": //Salir del menu 
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.Write("Opción invalida.");
                    break;
            }
        } while (opcion != "0");
    }
    static void
    MenuRegistro(RegistroEstudiantes registro)
    {
        string opcion;
        do
        {
            //Menu secundario para el registro de estudiantes
            Console.WriteLine("\n---MENÚ REGISTRO DE ESTUDIANTES---");
            Console.WriteLine("a) Agregar Estudiante");
            Console.WriteLine("b) Buscar Estudiante Por Cédula");
            Console.WriteLine("c) Eliminar Estudiante");
            Console.WriteLine("d) Total Aprobados  Reprobados");
            Console.WriteLine("e) Volver al Menú Principal");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "a":
                    registro.AgregarEstudiante();
                    break;
                case "b":
                    registro.BuscarPorCedula();
                    break;
                case "c":
                    registro.EliminarEstudiante();
                    break;
                case "d":
                    registro.MostrarTotales();
                    break;
                case "e":
                    Console.WriteLine("Volviendo al menu principal...");
                    break;
                default:
                    Console.WriteLine("Opción invalida.");
                    break;
            }
        } while (opcion != "e");
    }
}
