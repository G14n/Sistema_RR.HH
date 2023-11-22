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
    public partial class Registro_Evaluacion : Form
    {
        public Registro_Evaluacion()
        {
            InitializeComponent();
            listarEvaluacion();
        }

        private void AgregarTrabajador_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entEvaluacion eva = new entEvaluacion();
                eva.ID_Trabajador = Convert.ToInt32( txtIDTRA.Text.Trim());
                eva.Fecha =Convert.ToDateTime(Fecha.Value);
                eva.Porcentaje = Convert.ToInt32(txtPorcen.Text);
                logEvaluacion.Instancia.InsertarEvaluacion(eva);
                MessageBox.Show("SE REGISTRO CORRECTAMENTE", "REGISTRO DE EVALUACION", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarEvaluacion();
        }

        private void dgvEvaluacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEvaluacion.Rows[e.RowIndex];
            txtIDEVA.Text = filaActual.Cells[0].Value.ToString();
            txtIDTRA.Text = filaActual.Cells[1].Value.ToString();
            Fecha.Value = Convert.ToDateTime(filaActual.Cells[2].Value);
            txtPorcen.Text = filaActual.Cells[3].Value.ToString();
            
        }
        private void listarEvaluacion()
        {
            dgvEvaluacion.DataSource = logEvaluacion.Instancia.ListarEvaluacion();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEvaluacion eva = new entEvaluacion();
                eva.ID_Evaluacion = int.Parse(txtIDEVA.Text.Trim());
                eva.ID_Trabajador = int.Parse(txtIDTRA.Text.Trim());
                eva.Fecha = Fecha.Value;
                eva.Porcentaje = Convert.ToInt32( txtPorcen.Text.Trim());
                logEvaluacion.Instancia.EditarEvaluacion(eva);
                MessageBox.Show("SE MODIFICO CORRECTAMENTE", "MODIFICAR EVALUACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            listarEvaluacion();
           
        }
    }
}
