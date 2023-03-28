using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Metodo Sumar
/// </summary>
/// <param name="a">Numero 1</param>
/// <param name="b">Numero 2</param>
/// <param name="c">Numero 3</param>
/// <param name="anguloCoseno">Numero 4</param>
/// <returna></returna>
/// 
namespace BlsCoseno
{
    public class ClsCoseno
    {

        public static double Coseno(double a, double b, double c, double anguloCoseno=0)
        {
            return anguloCoseno = (Math.Pow(a, 2) + Math.Pow(b, 2)) - Math.Pow(c, 2) * (2 * a * b);
        }

    }
}
