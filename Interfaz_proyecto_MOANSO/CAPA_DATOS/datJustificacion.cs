using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDA;
namespace CAPA_DATOS
{
    public class datJustificacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datJustificacion _instancia = new datJustificacion();
        //privado para evitar la instanciación directa
        public static datJustificacion Instancia
        {
            get
            {
                return datJustificacion._instancia;
            }
        }
        #endregion singleton
        #region metodos 
        public Boolean InsertarJustificacion(entJustificacion jus)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaJustificacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", jus.ID_Trabajador);
                cmd.Parameters.AddWithValue("@Descripcion", jus.Descripcion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                  
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        #endregion metodos
    }
}
