using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Bedel : Empleado
    {

        // ATRIBUTOS
        protected string _apodo;


        // PROPIEDADES
        public string Apodo { get => _apodo; set => _apodo = value; }


        protected override void GetNombreCompleto()
        {
        }
        protected override string ListarEmpleados(bool listarConID)
        {
            return "";
        }


}
