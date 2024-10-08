using Examen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clase
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public abstract double SueldoBase { get; }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public string Puesto { get; set; } = string.Empty;

        public abstract double CalcularSueldo();


        public virtual void MostrarDetalle()
        {
            Console.WriteLine("ID Empleado es: " + IdEmpleado.ToString());
            Console.WriteLine("Nombre Empleado es: " + Nombre);
            Console.WriteLine("Puesto Empleado es: " + Puesto);
            Console.WriteLine("Sueldo Base es: " + SueldoBase);
        }
    }
}
