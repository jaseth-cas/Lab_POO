using System;
using System.Collections.Generic;
using ParcialPOO_CastilloJaseth_GraciasAlexandra;

namespace ParcialPOO_CastilloJaseth_GraciasAlexandra
{
    public class Program
    {
        public static void Main()
        {
            // Creamos las materias por nombre, codigo, creditos, cupos e inscritos
            var m1 = new Materia("Programación", "INF101", 4, 30, 28);
            var m2 = new Materia("Matemáticas", "MAT202", 3, 40, 35);
            var m3 = new Materia("Historia", "HIS303", 2, 25, 20);

            // Creamos la serie de estudiante con su nombre, id, carrera y lista de calificacion
            var e1 = new EstudianteBecado("Ana López", "E001", "Ingeniería", 40);
            var e2 = new Estudiante("Carlos Ruiz", "E002", "Matemáticas");
            var e3 = new Estudiante("Lucía Pérez", "E003", "Historia");

            // Creamos las calificaciones con su respectivo estudaiante, materia y nota
            var c1 = new Calificacion(e1, m1, 98);
            var c2 = new Calificacion(e2, m2, 85);
            var c3 = new Calificacion(e3, m3, 90);

            // ponemos las calificaciones
            e1.Calificaciones.Add(c1);
            e2.Calificaciones.Add(c2);
            e3.Calificaciones.Add(c3);

            // Creamos una lista polimorfica que contendra los estudiantes, las materias y las calificaciones
            List<IMostrable> items = new List<IMostrable>()
            {
                e1, e2, e3, m1, m2, m3, c1, c2, c3
            };

            // Mostrar los datos en una interfaz
            Console.WriteLine(" Datos Polimórficos\n");
            foreach (IMostrable i in items)
            {
                i.MostrarDatos();
            }

            // mostramos las resultados
            Console.WriteLine("\n resultados:");
            Console.WriteLine($"Promedio de {e1.Nombre}: {e1.CalcularPromedio():F2}");
            Console.WriteLine($"Carga semanal de {m1.Nombre}: {m1.CalcularCargaSemanal(3)} horas");
            Console.WriteLine($"Puntos de {c1.Materia.Nombre}: {c1.CalcularPuntos():F2}");
            Console.WriteLine($"Matrícula con descuento de {e1.Nombre}: {e1.CalcularMatriculaConDescuento(1200):F2}");

            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine($"1️. {e1.Nombre} ({e1.Carrera}) → Estudiante becada con un {e1.PorcentajeBeca}% de descuento en matrícula.");
            Console.WriteLine($"   Promedio general: {e1.CalcularPromedio():F2}");

            Console.WriteLine($"\n2️. {e2.Nombre} ({e2.Carrera}) → Estudiante regular sin beca.");
            Console.WriteLine($"   Promedio general: {e2.CalcularPromedio():F2}");

            Console.WriteLine($"\n3️. {e3.Nombre} ({e3.Carrera}) → Estudiante regular sin beca.");
            Console.WriteLine($"   Promedio general: {e3.CalcularPromedio():F2}");
        }
    }
}
