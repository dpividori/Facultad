using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    abstract class Persona
    {
        String _nombre;
        String _apellido;
        DateTime _fechaNacimiento;
        // Deby linda
        // cÉSAR GENIO

        protected abstract void GetCredencial();
        protected virtual void GetNombreCompleto()
        {
            Console.WriteLine("Nombre: " + _nombre + " " + _apellido);
        }
        protected abstract void getSaludoInformal();


    }
}
