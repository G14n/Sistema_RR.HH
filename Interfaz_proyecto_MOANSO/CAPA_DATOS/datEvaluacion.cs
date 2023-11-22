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
    public class datEvaluacion
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEvaluacion _instancia = new datEvaluacion();
        //privado para evitar la instanciación directa
        public static datEvaluacion Instancia
        {
            get
            {
                return datEvaluacion._instancia;
            }
        }
        #endregion singleton
        #region metodos 
        public List<entEvaluacion> ListarEvaluacion()
        {
            SqlCommand cmd = null;
            List<entEvaluacion> lista = new List<entEvaluacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarEvaluacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEvaluacion eva = new entEvaluacion();


                    eva.ID_Evaluacion = Convert.ToInt32(dr["ID_Evaluacion"]);
                    eva.ID_Trabajador = Convert.ToInt32(dr["ID_Trabajador"]);
                    eva.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    eva.Porcentaje = Convert.ToInt32(dr["Porcentaje"]);
                    lista.Add(eva);
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
            return lista;


        }
        public Boolean InsertarEvaluacion(entEvaluacion eva)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEvaluacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", eva.ID_Trabajador);
                cmd.Parameters.AddWithValue("@Fecha", eva.Fecha);
                cmd.Parameters.AddWithValue("@Porcentaje", eva.Porcentaje);
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
        //////////////////////////////////EditaCliente
        public Boolean EditarEvaluacion(entEvaluacion eva)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarEvaluacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Evaluacion", eva.ID_Evaluacion);
                cmd.Parameters.AddWithValue("@ID_Trabajador", eva.ID_Trabajador);
                cmd.Parameters.AddWithValue("@Fecha", eva.Fecha);
                cmd.Parameters.AddWithValue("@Porcentaje", eva.Porcentaje);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        public entEvaluacion Buscarevaluacion(int idtra)
        {
            SqlCommand cmd = null;
            entEvaluacion eva = new entEvaluacion();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarevaluacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Trabajador", idtra);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    eva.ID_Evaluacion = Convert.ToInt32(dr["ID_Evaluacion"]);
                    eva.ID_Trabajador = Convert.ToInt32(dr["ID_Trabajador"]);
                    eva.Fecha = Convert.ToDateTime( dr["Fecha"]);
                    eva.Porcentaje = Convert.ToInt32(dr["Porcentaje"]);
                    


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
