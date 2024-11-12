using System;
using System.Collections.Generic;


public static class Logica
{
    static List<Alumno> alumnos = new List<Alumno>();

    public static string Alta()
    {

        Console.Write("Ingrese el DNI del alumno: ");
        if (int.TryParse(Console.ReadLine(), out int dni)) // Intentamos convertir a double
        {
            // Verificamos si el DNI ya existe
            // Exist es propio de las listas y devuelve true o false
            if (alumnos.Exists(a => a.DNI == dni))
            {
                return "Error: El DNI ya está registrado."; // Salimos sin agregar el alumno
            }

            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine() ?? ""; // Aseguramos que no sea null

            Console.Write("Ingrese la nota del alumno: ");
            if (int.TryParse(Console.ReadLine(), out int nota)) // Intentamos convertir la nota
            {// Verificamos si la nota está dentro del rango de 1 a 10
                if (nota >= 1 && nota <= 10)
                {
                    // Agregamos el alumno
                    alumnos.Add(new Alumno(dni, nombre, nota));
                    return "Alumno agregado con éxito.";
                }
                else
                {
                    return "La nota debe estar entre 1 y 10."; // Mensaje si la nota está fuera de rango
                }
            }
            else
            {
                return "Nota inválida."; // Mensaje si la nota no es válida
            }
        }
        else
        {
            return "DNI inválido."; // Mensaje si el DNI no se puede convertir
        }
    }


    public static string Baja()
    {
        Console.Write("Ingrese el DNI del alumno a eliminar: ");
        if (double.TryParse(Console.ReadLine(), out double dni)) // Intentamos convertir a double
        {
            Alumno? alumno = alumnos.Find(a => a.DNI == dni); // Buscamos el alumno por DNI
            if (alumno != null)
            {
                alumnos.Remove(alumno); // Lo eliminamos
                return "Alumno eliminado con éxito.";
            }
            else
            {
                return "Alumno no encontrado."; // Mensaje si no se encuentra el alumno
            }
        }
        else
        {
            return "DNI inválido."; // Mensaje de error si no se pudo convertir
        }
    }
    public static string Modificacion()
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
                    return "Datos actualizados con éxito.";
                }
                else
                {
                    return "Nota inválida.";
                }
            }
            else
            {
                return "Alumno no encontrado.";
            }
        }
        else
        {
            return "DNI inválido.";
        }
    }

    public static string Consulta()
    {
        if (alumnos.Count == 0)
        {
            return "No hay alumnos registrados.";
        }
        else
        {
            string resultado = "\nLista de Alumnos:";
            foreach (var alumno in alumnos)
            {
                resultado += $"DNI: {alumno.DNI}, Nombre: {alumno.Nombre}, Nota: {alumno.Nota}";
            }
            return resultado;
        }
    }

    public static string NotaMasAlta()
    {
        if (alumnos.Count == 0)
        {
            return "No hay alumnos registrados.";
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
                return $"Alumno con la nota más alta: {mejorAlumno.Nombre}, Nota: {mejorAlumno.Nota}";
            }
            return "No se pudo determinar la nota más alta.";
        }
    }

    public static string PromedioGeneral()
    {
        if (alumnos.Count == 0)
        {
            return "No hay alumnos registrados.";
        }
        else
        {
            double sumaNotas = 0;
            foreach (var alumno in alumnos)
            {
                sumaNotas += alumno.Nota; // Sumar cada nota
            }

            double promedio = sumaNotas / alumnos.Count; // Dividir la suma por la cantidad de alumnos
            return $"Promedio general de notas: {promedio:F2}"; // Mostrar el promedio con 2 decimales
        }
    }
}

