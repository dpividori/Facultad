using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    abstract class Empleado : Persona
    {

        // ATRIBUTOS
        protected DateTime _fechaIngreso;
        protected int _legajo;


        // PROPIEDADES
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public int Legajo { get => _legajo; set => _legajo = value; }

        // PROPIEDADES HEREDADAS
        public DateTime FechaNacimiento { get => FechaNac; set => FechaNac = value; }

        // propiedades custom
        public int Antiguedad { get => _legajo; set => _legajo = value; }

        // Métodos: implemento porque debo hacerlo
        protected override void GetCredencial()
        {

        }

        protected abstract string ListarEmpleados(bool listarConId);

    }
}

