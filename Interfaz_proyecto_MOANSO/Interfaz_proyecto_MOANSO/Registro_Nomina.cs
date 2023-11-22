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
    public partial class Registro_Nomina : Form
    {
        public Registro_Nomina()
        {
            InitializeComponent();
           
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

            int bo = Convert.ToInt32(bono.Text);
            int sueldo = Convert.ToInt32(Sueldo.Text);
            int pago = sueldo + bo;
            pagot.Text = Convert.ToString(pago);
            entNomina no = new entNomina();
            no.ID_Trabajador = Convert.ToInt32(txtidtraba.Text);
            no.Fecha_Nomina = fecha.Value;
            no.Sueldo= Convert.ToInt32(Sueldo.Text); 
            no.Bonificaciones= Convert.ToInt32(bono.Text);
            no.Total_pago= pago;
            logNomina.Instancia.Insertarnomina(no);
            MessageBox.Show("SE REGISTRO CORRECTAMENTE", "REGISTRO DE NOMINA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
