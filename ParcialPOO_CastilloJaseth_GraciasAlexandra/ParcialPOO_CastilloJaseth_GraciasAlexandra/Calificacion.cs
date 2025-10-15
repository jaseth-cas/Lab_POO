using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO_CastilloJaseth_GraciasAlexandra
{
    public class Calificacion: IMostrable
    {
        // Campos privados
        private Estudiante estudiante;
        private Materia materia;
        private double nota;

        // Propiedades con validación
        public Estudiante Estudiante
        {
            get => estudiante;
            set => estudiante = value ?? throw new ArgumentException("El estudiante no puede ser nulo.");
        }

        public Materia Materia
        {
            get => materia;
            set => materia = value ?? throw new ArgumentException("La materia no puede ser nula.");
        }

        public double Nota
        {
            get => nota;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("La nota debe estar entre 0 y 100.");
                nota = value;
            }
        }

        // Constructor
        public Calificacion(Estudiante estudiante, Materia materia, double nota)
        {
            Estudiante = estudiante;
            Materia = materia;
            Nota = nota;
        }

        // Método aritmético
        public double CalcularPuntos()
        {
            return Nota * Materia.Creditos;
        }

        // Método de salida
        public void MostrarDatos()
        {
            Console.WriteLine($"Calificación: {Estudiante.Nombre} - {Materia.Nombre} = {Nota}");
        }
    }
}
