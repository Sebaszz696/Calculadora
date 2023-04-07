using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moda
{
    public class ClsModa
    {
        public static long Moda(double Num1d, double Num2d, double Num3d, double Num4d)
        {

            int Num1 = Convert.ToInt16(Num1d);
            int Num2 = Convert.ToInt16(Num2d);
            int Num3 = Convert.ToInt16(Num3d);
            int Num4 = Convert.ToInt16(Num4d);

            int[] Datos = new int[] { Num1, Num2, Num3, Num4 };

            int MaxNumero = Datos[0];
            int MaxVeces = 0;

            int i = 0;

            while (i < Datos.Length)
            {
                int NumVeces = 0;
                int j = 0;
                while (j < Datos.Length)
                {
                    if (Datos[j] == Datos[i]) NumVeces++;
                    j++;
                }
                if (NumVeces > MaxVeces)
                {
                    MaxNumero = Datos[i];
                    MaxVeces = NumVeces;
                }

                i++;
            }

            Num1d = Convert.ToDouble(Num1);
            Num2d = Convert.ToDouble(Num2);
            Num3d = Convert.ToDouble(Num3);
            Num4d = Convert.ToDouble(Num4);
            return MaxNumero;
        }
    }
}
