using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Empleado : Persona
    {

        // ATRIBUTOS
        private DateTime fechaIngreso;
        private int legajo;


        // PROPIEDADES
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int Legajo { get => legajo; set => legajo = value; }

        // PROPIEDADES HEREDADAS
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        // propiedades custom
        public int Antiguedad { get => _legajo; set => _legajo = value; }

        // Métodos: implemento porque debo hacerlo
        public override void GetCredencial()
        {
            Console.WriteLine("Credencial de empleado");
        }
    }
}  
    
