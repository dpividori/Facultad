using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    abstract class Persona
    {
        // ATRIBUTOS
        private String _nombre;
        private String _apellido;
        private DateTime _fechaNacimiento;

        // PROPIEDADES
        protected string Nombre { get => _nombre; set => _nombre = value; }
        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        protected abstract void GetCredencial();
        // ES ABSTRACT PORQUE NO SE IMPLEMENTA EN LA CLASE PADRE
        // NO SE PUEDE IMPLEMENTAR EN LA CLASE PADRE PORQUE NO SE SABE QUE VALOR TENDRÁ
        // DEPENDE DE LA CLASE HIJA
        // SE DEBE IMPLEMENTAR EN LA CLASE HIJA
        // NO LLEVA LLAVES DE IMPLEMENTACIÓN

        protected virtual void GetNombreCompleto()
        {
            // SE PUEDE IMPLEMENTAR EN LA CLASE PADRE
            // SE PUEDE SOBREESCRIBIR EN LA CLASE HIJA
            // LLEVA LLAVES DE IMPLEMENTACIÓN
            // SE PUEDE SOBREESCRIBIR O NO EN LA CLASE HIJA
            // ES UNA IMPLEMENTACIÓN POR DEFECTO, SI O SI ESTOY OBLIGADO A ESCRIBIR ALGO.


        }
        protected void getSaludoInformal()
        {}


    }
}
