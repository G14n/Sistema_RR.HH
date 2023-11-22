using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_LOGICA;
using CAPA_ENTIDA;
namespace Interfaz_proyecto_MOANSO
{
    public partial class Consulta_Evaluacion : Form
    {
        int idtra;
        public Consulta_Evaluacion()
        {
            InitializeComponent();
            listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtra = Convert.ToInt32(txtBusca.Text); // se obtiene el valor de una celda 
            entEvaluacion eva = logEvaluacion.Instancia.buscarevaluacion(idtra);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Evaluacion");
            dt.Columns.Add("ID_Trabajador");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Porcentaje");
            dt.Rows.Add(
                eva.ID_Evaluacion,
                eva.ID_Trabajador,
                eva.Fecha,
                eva.Porcentaje
                
                );
            dgvconsultaeva.DataSource = dt;
            txtBusca.Text = "";
        }
        private void listar()
        {
             dgvconsultaeva.DataSource= logEvaluacion.Instancia.ListarEvaluacion();
        }
    }
}
