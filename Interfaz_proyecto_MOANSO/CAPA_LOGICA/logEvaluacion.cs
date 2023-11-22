using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDA;
using CAPA_DATOS;
namespace CAPA_LOGICA
{
   public class logEvaluacion
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEvaluacion _instancia = new logEvaluacion();
        //privado para evitar la instanciación directa
        public static logEvaluacion Instancia
        {
            get
            {
                return logEvaluacion._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entEvaluacion> ListarEvaluacion()
        {

            return datEvaluacion.Instancia.ListarEvaluacion();
        }
        ///inserta
        public void InsertarEvaluacion(entEvaluacion eva)
        {
            datEvaluacion.Instancia.InsertarEvaluacion(eva);
        }
        //edita
        public void EditarEvaluacion(entEvaluacion eva)
        {
            datEvaluacion.Instancia.EditarEvaluacion (eva);
        }
        public entEvaluacion buscarevaluacion(int idtra)
        {
            try
            {
                return datEvaluacion.Instancia.Buscarevaluacion(idtra);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos
    }
}
