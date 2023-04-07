using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlTangente
{
    /// <summary>
    /// Nombre:Paola Ruiz Osorio
    /// Fecha:28/03/2023
    /// Descripcion: Hayar la Tangente
    /// </summary>
    
    public class ClsObtenerTangente
    {
        
        
        public static double ObtenerTangente (double Angulo)
        {
            double Result = Angulo * Math.PI / 180;
            return Math.Tan(Result);
        }
    }
}
