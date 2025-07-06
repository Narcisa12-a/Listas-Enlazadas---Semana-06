//Crear una lista enlazada con 50 numeros enteros del 1 al 999 generados aleatoriamente.
//Una vez creada la lista, se deben eliminar los nodos que esten fuera de un rango de valores leidos desde el teclado.
using System;
using System.Collections.Generic;
public class ListasNumeros
{
    LinkedList<int> numeros = new LinkedList<int>(); //Lista enlasada de numeros
    Random random = new Random();
    public void CrearLista()
    {
        Console.WriteLine("\nGenerarndo 50 numeros aleatorios entre 1 y 999...");
        for (int i = 0; i < 50; i++)
        {
            int numero = random.Next(1, 1000); //Genera numeros entre el 1 y el 999
            numeros.AddLast(numero); //Agrega el final de la lista
        }
        MostrarLista("Lista original:");
    }
    public void
    EliminarFueraDeRango()
    {
        //Pedir rango al usuario
        Console.Write("Ingrese el valor minimo del rango: ");
        int minimo = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor maximo del rango: ");
        int maximo = int.Parse(Console.ReadLine());
        //Recorrer la lista y eliminar valores fuera del rango
        var nodoActual = numeros.First;
        while (nodoActual != null)
        {
            var siguiente = nodoActual.Next; //Guardar referencias al siguiente nodo
            if (nodoActual.Value < minimo || nodoActual.Value > maximo)
            {
                numeros.Remove(nodoActual); // Eliminar nodo fuera de rango
            }
            nodoActual = siguiente; //Pasar al siguiente nodo
        }
        MostrarLista("Lista despues de eliminar valores fuera del rango:");
    }
    private void MostrarLista(string mensaje)
    {
        Console.WriteLine(mensaje);
        foreach (var numero in numeros)
        {
            Console.Write(numero + "");
        }
        Console.WriteLine();
    }
}