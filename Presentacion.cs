using System;

public class Programa
{
    public static void Main()
    {
        int opcion;
        do
        {
            MostrarMenu();

            // Lee la entrada y verifica si es un número válido
            string? input = Console.ReadLine();

            if (int.TryParse(input, out opcion))
            {
                EjecutarOpcion(opcion);
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

        } while (opcion != 7);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nMenú de Alumnos:");
        Console.WriteLine("1. Alta");
        Console.WriteLine("2. Baja");
        Console.WriteLine("3. Modificación");
        Console.WriteLine("4. Consulta");
        Console.WriteLine("5. Nota más alta");
        Console.WriteLine("6. Promedio general");
        Console.WriteLine("7. Salir");
        Console.Write("Seleccione una opción: ");
    }

    static void EjecutarOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                Logica.Alta();
                break;
            case 2:
                Logica.Baja();
                break;
            case 3:
                Logica.Modificacion();
                break;
            case 4:
                string resultadoConsulta = Logica.Consulta();
                Console.WriteLine(resultadoConsulta);
                break;
            case 5:
                string resultadoNotaMasAlta = Logica.NotaMasAlta();
                Console.WriteLine(resultadoNotaMasAlta);
                break;
            case 6:
                string resultadoPromedioGral = Logica.PromedioGeneral();
                Console.WriteLine(resultadoPromedioGral);
                break;
            case 7:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
