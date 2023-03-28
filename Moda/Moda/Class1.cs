using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moda
{
    public class ClsModa
    {
        public static long Moda(List<long> numeros)
        {
            Dictionary<long, int> frecuencias = new Dictionary<long, int>();
            foreach (long numero in numeros)
            {
                if (frecuencias.ContainsKey(numero))
                    frecuencias[numero]++;
                else
                    frecuencias[numero] = 1;
            }
            int maxFrecuencia = frecuencias.Values.Max();
            long moda = frecuencias.FirstOrDefault(x => x.Value == maxFrecuencia).Key;
            return moda;
        }
    }
}
