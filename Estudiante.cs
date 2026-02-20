using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO_CastilloJaseth_GraciasAlexandra
{
    public class Estudiante : IMostrable
    {

        private string nomb, id, carrera;
        private List<Calificacion> calificaciones = new List<Calificacion>();

        // Propiedades
        public string Nombre
        {
            //si no hay nombre:
            get => nomb;
            set => nomb = value ?? throw new ArgumentException("El nombre no puede ser nulo.");
        }

        public string Id
        {
            //si no existe ID
            get => id;
            set => id = value ?? throw new ArgumentException("El ID no puede ser nulo.");
        }

        public string Carrera
        {
            //si la carrera es nula:
            get => carrera;
            set => carrera = value ?? throw new ArgumentException("La carrera no puede ser nula.");
        }

        public List<Calificacion> Calificaciones => calificaciones; // solo lectura externa

        // Constructor de la clase estudiante
        public Estudiante(string nombre, string id, string carrera)
        {
            Nombre = nombre;
            Id = id;
            Carrera = carrera;
        }

        // Método para calcular el promedio
        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0) return 0;

            double sumaPonderada = 0;
            int sumaCreditos = 0;

            foreach (Calificacion c in Calificaciones)
            {
                sumaPonderada += c.Nota * c.Materia.Creditos;
                sumaCreditos += c.Materia.Creditos;
            }

            return sumaCreditos > 0 ? sumaPonderada / sumaCreditos : 0;
        }

        // Método de salida
        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Estudiante: {Nombre} ({Id}) - Carrera: {Carrera}");
            Console.WriteLine($"Promedio: {CalcularPromedio():F2}\n");
        }
    }
}
