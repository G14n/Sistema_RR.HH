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
    public partial class Registro_Justificacion : Form
    {
        public Registro_Justificacion()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                entJustificacion jus = new entJustificacion();
                jus.ID_Trabajador =Convert.ToInt32( txtidtra.Text.Trim());
                jus.Descripcion = txtdescrip.Text;
                logJustificacion.Instancia.InsertarJustificacion(jus);
                MessageBox.Show("SE REGISTRO CORRECTAMENTE", "REGISTRO DE JUSTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
           
        }
    }
}
