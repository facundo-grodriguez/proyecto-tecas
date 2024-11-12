using System;
using System.Collections.Generic;


public static class Logica
{
    static List<Alumno> alumnos = new List<Alumno>();

    public static void Alta()
    {

        Console.Write("Ingrese el DNI del alumno: ");
        if (int.TryParse(Console.ReadLine(), out int dni)) // Intentamos convertir a double
        {
            // Verificamos si el DNI ya existe
            // Exist es propio de las listas y devuelve true o false
            if (alumnos.Exists(a => a.DNI == dni))
            {
                Console.WriteLine("Error: El DNI ya está registrado."); // Mensaje si ya existe
                return; // Salimos sin agregar el alumno
            }

            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine() ?? (""); // Aseguramos que no sea null

            Console.Write("Ingrese la nota del alumno: ");
            if (int.TryParse(Console.ReadLine(), out int nota)) // Intentamos convertir la nota
            {// Verificamos si la nota está dentro del rango de 1 a 10
                if (nota >= 1 && nota <= 10)
                {
                    // Agregamos el alumno
                    alumnos.Add(new Alumno(dni, nombre, nota));
                    Console.WriteLine("Alumno agregado con éxito.");
                }
                else
                {
                    Console.WriteLine("La nota debe estar entre 1 y 10."); // Mensaje si la nota está fuera de rango
                }
            }
            else
            {
                Console.WriteLine("Nota inválida."); // Mensaje si la nota no es válida
            } 
        }
        else
        {
            Console.WriteLine("DNI inválido."); // Mensaje si el DNI no se puede convertir
        }
    }


    public static void Baja()
    {
        Console.Write("Ingrese el DNI del alumno a eliminar: ");
        if (double.TryParse(Console.ReadLine(), out double dni)) // Intentamos convertir a double
        {
            Alumno? alumno = alumnos.Find(a => a.DNI == dni); // Buscamos el alumno por DNI
            if (alumno != null)
            {
                alumnos.Remove(alumno); // Lo eliminamos
                Console.WriteLine("Alumno eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Alumno no encontrado."); // Mensaje si no se encuentra el alumno
            }
        }
        else
        {
            Console.WriteLine("DNI inválido."); // Mensaje de error si no se pudo convertir
        }
    }
    public static void Modificacion()
    {
        Console.Write("Ingrese el DNI del alumno a modificar: ");
        if (double.TryParse(Console.ReadLine(), out double dni))
        {
            Alumno? alumno = alumnos.Find(a => a.DNI == dni);
            if (alumno != null)
            {
                Console.Write("Ingrese el nuevo nombre: ");
                alumno.Nombre = Console.ReadLine();

                Console.Write("Ingrese la nueva nota: ");
                if (double.TryParse(Console.ReadLine(), out double nuevaNota))
                {
                    alumno.Nota = nuevaNota;
                    Console.WriteLine("Datos actualizados con éxito.");
                }
                else
                {
                    Console.WriteLine("Nota inválida.");
                }
            }
            else
            {
                Console.WriteLine("Alumno no encontrado.");
            }
        }
        else
        {
            Console.WriteLine("DNI inválido.");
        }
    }

    public static void Consulta()
    {
        if (alumnos.Count == 0)
        {
            Console.WriteLine("No hay alumnos registrados.");
        }
        else
        {
            Console.WriteLine("\nLista de Alumnos:");
            foreach (var alumno in alumnos)
            {
                Console.WriteLine($"DNI: {alumno.DNI}, Nombre: {alumno.Nombre}, Nota: {alumno.Nota}");
            }
        }
    }

    public static void NotaMasAlta()
{
    if (alumnos.Count == 0)
    {
        Console.WriteLine("No hay alumnos registrados.");
    }
    else
    {
        Alumno? mejorAlumno = null;
        double maxNota = 0;

        // Iteramos sobre cada alumno en la lista para encontrar la nota más alta
        foreach (var alumno in alumnos)
        {
            if (alumno.Nota > maxNota)
            {
                maxNota = alumno.Nota;
                mejorAlumno = alumno;
            }
        }

        // Mostramos el alumno con la nota más alta
        if (mejorAlumno != null)
        {
            Console.WriteLine($"Alumno con la nota más alta: {mejorAlumno.Nombre}, Nota: {mejorAlumno.Nota}");
        }
    }
}

    public static void PromedioGeneral()
    {
        if (alumnos.Count == 0)
        {
            Console.WriteLine("No hay alumnos registrados.");
        }
        else
        {
            double sumaNotas = 0;
            foreach (var alumno in alumnos)
            {
                sumaNotas += alumno.Nota; // Sumar cada nota
            }

            double promedio = sumaNotas / alumnos.Count; // Dividir la suma por la cantidad de alumnos
            Console.WriteLine($"Promedio general de notas: {promedio:F2}"); // Mostrar el promedio con 2 decimales
        }
    }
}

