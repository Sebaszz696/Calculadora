using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlRadicacion
{
    public class ClsRadicacion
    {
        public static double Raiz(double Numero, double indice)
        {
            indice = 1 / indice;
            return Math.Pow(Numero, indice);
        }
    }
}
