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
    public class datNomina
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datNomina _instancia = new datNomina();
        //privado para evitar la instanciación directa
        public static datNomina Instancia
        {
            get
            {
                return datNomina._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public Boolean InsertarNomina(entNomina no)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNomina", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", no.ID_Trabajador);
                cmd.Parameters.AddWithValue("@Fecha", no.Fecha_Nomina);
                cmd.Parameters.AddWithValue("@Sueldo", no.Sueldo);
                cmd.Parameters.AddWithValue("@Bonificaciones", no.Bonificaciones);
                cmd.Parameters.AddWithValue("@Total_pago", no.Total_pago);
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
        public entNomina BuscarNomina(int idtra)
        {
            SqlCommand cmd = null;
            entNomina eva = new entNomina();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarNomina", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", idtra);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    eva.ID_Nomina = Convert.ToInt32(dr["ID_Nomina"]);
                    eva.ID_Trabajador = Convert.ToInt32(dr["ID_Trabajador"]);
                    eva.Fecha_Nomina = Convert.ToDateTime(dr["Fecha"]);
                    eva.Sueldo = Convert.ToInt32(dr["Sueldo"]);
                    eva.Bonificaciones = Convert.ToInt32(dr["Bonificacion"]);
                    eva.Total_pago = Convert.ToInt32(dr["Total_pago"]);



                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return eva;
        }
        #endregion metodos
    }
}
