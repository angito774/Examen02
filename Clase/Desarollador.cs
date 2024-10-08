using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clase
{
    public class Desarollador : EmpleadoBase
    {
        public override double SueldoBase => 3000;

        public override double CalcularSueldo()
        {
            return SueldoBase;
        }
    }
}
