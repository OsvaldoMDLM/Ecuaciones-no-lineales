using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuaciones_no_lineales
{
    class Fx_funciones
    {

        Ecuaciones fx = new Ecuaciones();

        public double Fx_Funciones(string fn, double n)
        {
            string fun = fn;
            double vt = fx.ValorF(fun, n);
            return vt;
        }
    }
}
