using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// método logaritmo
/// </summary>
/// <param name="num">operando 1</param>
/// <param name="log">operando 2</param>
/// <returns></returns>

namespace BlLogaritmo
{
    public class ClsLogaritmo
    {
       
        public static double Logaritmo(double num, double log)

        {
            return log = Math.Log(num) / Math.Log(log);
        }
    }
}