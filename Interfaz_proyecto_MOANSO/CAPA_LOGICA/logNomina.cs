using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDA;
namespace CAPA_LOGICA
{
   public class logNomina
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logNomina _instancia = new logNomina();
        //privado para evitar la instanciación directa
        public static logNomina Instancia
        {
            get
            {
                return logNomina._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public void Insertarnomina(entNomina no)
        {
            datNomina.Instancia.InsertarNomina(no);
        }
        public entNomina buscarNomina(int idtra)
        {
            try
            {
                return datNomina.Instancia.BuscarNomina(idtra);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos
    }
}
