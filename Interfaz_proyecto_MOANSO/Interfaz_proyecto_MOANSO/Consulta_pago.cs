using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDA;
using CAPA_LOGICA;
namespace Interfaz_proyecto_MOANSO
{
    public partial class Consulta_pago : Form
    {
        int idtra;
        public Consulta_pago()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtra = Convert.ToInt32(txtBusca.Text); // se obtiene el valor de una celda 
            entNomina no = logNomina.Instancia.buscarNomina(idtra);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Nomina");
            dt.Columns.Add("ID_Trabajador");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Sueldo");
            dt.Columns.Add("Bonificacion");
            dt.Columns.Add("Pago Total");
            dt.Rows.Add(
                no.ID_Nomina,
                no.ID_Trabajador,
                no.Fecha_Nomina,
                no.Sueldo,
                no.Bonificaciones,
                no.Total_pago

                );
            dgvconsultaeva.DataSource = dt;
            txtBusca.Text = "";
        }
    }
}
