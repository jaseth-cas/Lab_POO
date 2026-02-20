using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO_CastilloJaseth_GraciasAlexandra
{
    public class Calificacion: IMostrable
    {
        // Campos privados para las calificaciones
        private Estudiante estudiante;
        private Materia materia;
        private double nota;

        // Propiedades con validación
        public Estudiante Estudiante
        {
            //por si no existe el estudiante
            get => estudiante;
            set => estudiante = value ?? throw new ArgumentException("El estudiante no puede ser nulo.");
        }

        public Materia Materia
        {
            //por si la materia no existe
            get => materia;
            set => materia = value ?? throw new ArgumentException("La materia no puede ser nula.");
        }

        public double Nota
        {
            get => nota;
            set
            {
                //si la nota es menor a 0 o mayor a 100
                if (value < 0 || value > 100)
                    throw new ArgumentException("La nota debe estar entre 0 y 100.");
                nota = value;
            }
        }

        // Constructor de calificaciones 
        public Calificacion(Estudiante estudiante, Materia materia, double nota)
        {
            Estudiante = estudiante;
            Materia = materia;
            Nota = nota;
        }

        // Método para calcular los puntos
        public double CalcularPuntos()
        {
            return Nota * Materia.Creditos;
        }

        // Método para mostrar datos
        public void MostrarDatos()
        {
            Console.WriteLine($"Calificación: {Estudiante.Nombre} - {Materia.Nombre} = {Nota}");
        }
    }
}
