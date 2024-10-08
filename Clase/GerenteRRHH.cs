using Examen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clase
{
    public class GerenteRRHH : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        public override double SueldoBase => 5000;

        public double CalcularBonificacion()
        {
            return 0;
        }

        public double DescontarSueldo()
        {
            return SueldoBase * Constantes.desc10;
        }

        public override double CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }


    }
}
