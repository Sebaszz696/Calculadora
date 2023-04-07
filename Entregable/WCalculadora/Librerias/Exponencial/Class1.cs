using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponencial
{
    public class ClsExponencial
    {
        /// <summary>
        /// Metodo Exponencial 
        /// </summary>
        /// <param name="Num1"></param>
        /// <param name="Num2"></param>
        /// <returns></returns>
        public static double Exponencial(double Num1, double Num2)
        {
            double total = Math.Pow(Num1, Num2);
            return total;
        }
    }
}
