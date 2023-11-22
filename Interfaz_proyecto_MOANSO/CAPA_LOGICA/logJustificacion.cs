using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDA;
using CAPA_DATOS;
namespace CAPA_LOGICA
{
    public class logJustificacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logJustificacion _instancia = new logJustificacion();
        //privado para evitar la instanciación directa
        public static logJustificacion Instancia
        {
            get
            {
                return logJustificacion._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public void InsertarJustificacion(entJustificacion jus)
        {
            datJustificacion.Instancia.InsertarJustificacion(jus);
        }
        #endregion metodos
    }
}
