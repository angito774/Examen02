using Examen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clase
{
    public class Gerente : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        //=> Lambda: Funciones pequeñas
        public override double SueldoBase => 8000;

        public double CalcularBonificacion()
        {
            return 1000;
        }
        public double DescontarSueldo()
        {
            return SueldoBase * Constantes.desc20;
        }

        public override double CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }


    }
}
