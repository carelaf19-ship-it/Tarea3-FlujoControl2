using System;
using System.Collections.Generic;

/*
 * Actividad 2 - Flujo de Control Parte 2
 * Programación Básica
 *
 * Programa que permite al usuario introducir las 4 calificaciones de
 * "n" cantidad de estudiantes, calcula el promedio de cada uno y
 * determina si aprobó o reprobó. Al final se muestra una tabla con
 * todos los resultados.
 */

class Estudiante
{
    public string Nombre { get; set; }
    public double[] Notas { get; set; }
    public double Promedio { get; set; }
    public string Estatus { get; set; }
}

class Program
{
    const double NOTA_MINIMA_APROBACION = 70;

    static void Main(string[] args)
    {
        Console.WriteLine(new string('=', 60));
        Console.WriteLine("PROGRAMA DE CALIFICACIONES DE ESTUDIANTES");
        Console.WriteLine(new string('=', 60));

        int cantidadEstudiantes = PedirEnteroPositivo("¿Cuántos estudiantes deseas registrar? ");

        List<Estudiante> estudiantes = new List<Estudiante>();

        for (int i = 1; i <= cantidadEstudiantes; i++)
        {
            Console.WriteLine($"\n--- Estudiante #{i} ---");
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = $"Estudiante {i}";
            }

            double[] notas = new double[4];
            for (int j = 0; j < 4; j++)
            {
                notas[j] = PedirNota($"  Introduce la nota {j + 1} de {nombre}: ");
            }

            double promedio = CalcularPromedio(notas);
            string estatus = DeterminarEstatus(promedio);

            estudiantes.Add(new Estudiante
            {
                Nombre = nombre,
                Notas = notas,
                Promedio = promedio,
                Estatus = estatus
            });
        }

        ImprimirTabla(estudiantes);
    }

    static int PedirEnteroPositivo(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string valor = Console.ReadLine();
            if (int.TryParse(valor, out int numero) && numero > 0)
            {
                return numero;
            }
            Console.WriteLine("Entrada inválida. Debes escribir un número entero mayor que 0.\n");
        }
    }

    static double PedirNota(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string valor = Console.ReadLine();
            if (double.TryParse(valor, out double nota) && nota >= 0 && nota <= 100)
            {
                return nota;
            }
            Console.WriteLine("Entrada inválida. La nota debe ser un número entre 0 y 100.\n");
        }
    }

    static double CalcularPromedio(double[] notas)
    {
        double suma = 0;
        foreach (double nota in notas)
        {
            suma += nota;
        }
        return suma / notas.Length;
    }

    static string DeterminarEstatus(double promedio)
    {
        return promedio >= NOTA_MINIMA_APROBACION ? "Aprobado" : "Reprobado";
    }

    static void ImprimirTabla(List<Estudiante> estudiantes)
    {
        string encabezado = string.Format(
            "{0,-20}{1,10}{2,10}{3,10}{4,10}{5,12}{6,12}",
            "Estudiante", "Nota 1", "Nota 2", "Nota 3", "Nota 4", "Promedio", "Estatus");

        Console.WriteLine();
        Console.WriteLine(encabezado);
        Console.WriteLine(new string('-', encabezado.Length));

        foreach (Estudiante est in estudiantes)
        {
            string fila = string.Format(
                "{0,-20}{1,10:F2}{2,10:F2}{3,10:F2}{4,10:F2}{5,12:F2}{6,12}",
                est.Nombre, est.Notas[0], est.Notas[1], est.Notas[2], est.Notas[3],
                est.Promedio, est.Estatus);
            Console.WriteLine(fila);
        }
    }
}
