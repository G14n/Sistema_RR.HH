using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDA
{
    public class entEvaluacion
    {
        public int ID_Evaluacion { get; set; }
        public int ID_Trabajador { get; set; }
        public DateTime Fecha { get; set; }
        public int Porcentaje { get; set; }
    }
}
