//Crear un programa que maneje el registro de los estudiantes de la Unidad curricular de Redes III 
//utilizando lista enlazadas. Los estudiantes aprobados deben insertarse por el inicio y los reprobados
//por el final de la lista. Los datos requeridos por cada estudiante son los siguientes:
//cédula, nombre, apellido, correo, nota definitiva (escala: 1-10). El programa debe permitir las operaciones de:
//a. Agregar estudiante.
//b. Buscar estudiante por cédula.
//c. Eliminar un estudiante.
//d. Total estudiantes aprobados y reprobados.
using System;
using System.Collections.Generic;
public class Estudiante
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public double Nota { get; set; }
}
public class RegistroEstudiantes
{
    LinkedList<Estudiante> lista = new LinkedList<Estudiante>(); //Lista enlazada de estudiantes
    public void AgregarEstudiante()
    {
        //Crear un nuevo estudiante
        Estudiante est = new Estudiante();
        Console.Write("Cédula: ");
        est.Cedula = Console.ReadLine();
        Console.Write("Nombre: ");
        est.Nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        est.Apellido = Console.ReadLine();
        Console.Write("Correo: ");
        est.Correo = Console.ReadLine();
        Console.Write("Nota definitiva (1-10): ");
        est.Nota = double.Parse(Console.ReadLine());
        //Insertar segun la nota
        if (est.Nota >= 6)
        {
            lista.AddFirst(est); //Aprobado al inicio
            Console.WriteLine("Estudiante agregado al inicio (Aprobado).");
        }
        else
        {
            lista.AddLast(est); //Reprobado al final
            Console.WriteLine("Estudiante agregado al final (Reprobado).");
        }
    }
    public void BuscarPorCedula()
    {
        Console.Write("Ingrese la cédula a buscar: ");
        string cedula = Console.ReadLine();
        foreach (var est in lista)
        {
            if (est.Cedula == cedula)
            {
                MostrarEstudiante(est);
                return;
            }
        }
        Console.WriteLine("Estudiante no encontrado.");
    }
    public void EliminarEstudiante()
    {
        Console.Write("Ingrese la cédula del estudiante a eliminar: ");
        string cedula = Console.ReadLine();
        var nodo = lista.First;
        while (nodo != null)
        {
            if (nodo.Value.Cedula == cedula)
            {
                lista.Remove(nodo);
                Console.WriteLine("Estudiante eliminado.");
                return;
            }
            nodo = nodo.Next;
        }
        Console.WriteLine("Estudiante no encontrado.");
    }
    public void MostrarTotales()
    {
        int aprobados = 0, reprobados = 0;
        foreach (var est in lista)
        {
            if (est.Nota >= 6) aprobados++;
            else
                reprobados++;
        }
        Console.WriteLine($"Total estudiantes aprobados: {aprobados}");
        Console.WriteLine($"Total estudiantes reprobados: {reprobados}");
    }
    private void MostrarEstudiante(Estudiante est)
    {
        Console.WriteLine($"Cédula: {est.Cedula}, Nombre: {est.Nombre}, Apellido {est.Apellido}, Correo {est.Correo}, Nota {est.Nota}");
    }
}