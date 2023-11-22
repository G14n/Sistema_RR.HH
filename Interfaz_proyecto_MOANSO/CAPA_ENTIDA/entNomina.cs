using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDA
{
   public class entNomina
    {
        public int ID_Nomina { get; set; }
        public int ID_Trabajador { get; set; }
        public DateTime Fecha_Nomina { get; set; }
        public int Sueldo { get; set; }
        public int Total_pago { get; set; }
        public int Bonificaciones { get; set; }
    }
}
