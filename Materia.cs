using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO_CastilloJaseth_GraciasAlexandra
{
    public class Materia : IMostrable
    {

        // Campos privados para el get  y set
        private string nombre;
        private string codigo;
        private int creditos;
        private int cupos;
        private int inscritos;

        // Propiedades con validación
        public string Nombre
        {
            //si el nombre es nul
            get => nombre;
            set => nombre = value ?? throw new ArgumentException("El nombre no puede ser nulo.");
        }

        public string Codigo
        {
            //si no existe codigo de materia
            get => codigo;
            set => codigo = value ?? throw new ArgumentException("El código no puede ser nulo.");
        }

        public int Creditos
        {
            //por si los creditos son negativos
            get => creditos;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Los créditos deben ser mayores que 0.");
                creditos = value;
            }
        }

        public int Cupos
        {
            //por si los cupos son negativos
            get => cupos;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Los cupos deben ser ≥ 0.");
                cupos = value;
            }
        }

        public int Inscritos
        {
            //si los inscritos son menor que 0 o se pasa de los cupos
            get => inscritos;
            set
            {
                if (value < 0 || value > Cupos)
                    throw new ArgumentException("Inscritos debe estar entre 0 y Cupos.");
                inscritos = value;
            }
        }

        // Constructor de la clase materia
        public Materia(string nombre, string codigo, int creditos, int cupos = 0, int inscritos = 0)
        {
            Nombre = nombre;
            Codigo = codigo;
            Creditos = creditos;
            Cupos = cupos;
            Inscritos = inscritos;
        }

        // Método de cargasemanal
        public int CalcularCargaSemanal(int horasPorCredito)
        {
            return Creditos * horasPorCredito;
        }

        // Método para mostrar los datos
        public void MostrarDatos()
        {
            Console.WriteLine($"Materia: {Nombre} ({Codigo}) | Créditos: {Creditos} | Cupos: {Inscritos}/{Cupos}");
        }
    }
}
