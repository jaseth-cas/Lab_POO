using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO_CastilloJaseth_GraciasAlexandra
{
    public class EstudianteBecado: Estudiante
    {
        // Campo adicional

        private double porcentajeBeca;

        // Propiedad con validación
        public double PorcentajeBeca
        {
            get => porcentajeBeca;
            set
                //por si el porcentaje es menor a 0 o mayor a 100
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("El porcentaje de beca debe estar entre 0 y 100.");
                porcentajeBeca = value;
            }
        }

        // Constructor de estudiantebecado
        public EstudianteBecado(string nombre, string id, string carrera, double porcentajeBeca)
            : base(nombre, id, carrera)
        {
            PorcentajeBeca = porcentajeBeca;
        }

        // Método de calculo de descuento
        public double CalcularMatriculaConDescuento(double matriculaBase)
        {
            return matriculaBase * (1 - (PorcentajeBeca / 100.0));
        }

        // Método de salida (override)
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Porcentaje de beca: {PorcentajeBeca}%");
        }
    }
}
