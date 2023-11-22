
namespace Interfaz_proyecto_MOANSO
{
    partial class Registro_Evaluacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Evaluacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDEVA = new System.Windows.Forms.TextBox();
            this.txtIDTRA = new System.Windows.Forms.TextBox();
            this.txtPorcen = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.AgregarTrabajador = new System.Windows.Forms.Button();
            this.dgvEvaluacion = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Evaluacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Trabajador :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Porcentaje :";
            // 
            // txtIDEVA
            // 
            this.txtIDEVA.Location = new System.Drawing.Point(181, 92);
            this.txtIDEVA.Name = "txtIDEVA";
            this.txtIDEVA.ReadOnly = true;
            this.txtIDEVA.Size = new System.Drawing.Size(158, 20);
            this.txtIDEVA.TabIndex = 4;
            this.txtIDEVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDTRA
            // 
            this.txtIDTRA.Location = new System.Drawing.Point(410, 92);
            this.txtIDTRA.Name = "txtIDTRA";
            this.txtIDTRA.Size = new System.Drawing.Size(158, 20);
            this.txtIDTRA.TabIndex = 5;
            this.txtIDTRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPorcen
            // 
            this.txtPorcen.Location = new System.Drawing.Point(410, 172);
            this.txtPorcen.Name = "txtPorcen";
            this.txtPorcen.Size = new System.Drawing.Size(158, 20);
            this.txtPorcen.TabIndex = 6;
            this.txtPorcen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(181, 172);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 20);
            this.Fecha.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(102)))), ((int)(((byte)(56)))));
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.AgregarTrabajador);
            this.groupBox1.Location = new System.Drawing.Point(27, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 90);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.White;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(393, 19);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(89, 55);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // AgregarTrabajador
            // 
            this.AgregarTrabajador.BackColor = System.Drawing.Color.White;
            this.AgregarTrabajador.FlatAppearance.BorderSize = 0;
            this.AgregarTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarTrabajador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarTrabajador.Image = ((System.Drawing.Image)(resources.GetObject("AgregarTrabajador.Image")));
            this.AgregarTrabajador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarTrabajador.Location = new System.Drawing.Point(173, 19);
            this.AgregarTrabajador.Name = "AgregarTrabajador";
            this.AgregarTrabajador.Size = new System.Drawing.Size(108, 55);
            this.AgregarTrabajador.TabIndex = 22;
            this.AgregarTrabajador.Text = "Agregar";
            this.AgregarTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarTrabajador.UseVisualStyleBackColor = false;
            this.AgregarTrabajador.Click += new System.EventHandler(this.AgregarTrabajador_Click);
            // 
            // dgvEvaluacion
            // 
            this.dgvEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluacion.Location = new System.Drawing.Point(27, 359);
            this.dgvEvaluacion.Name = "dgvEvaluacion";
            this.dgvEvaluacion.Size = new System.Drawing.Size(693, 150);
            this.dgvEvaluacion.TabIndex = 29;
            this.dgvEvaluacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvaluacion_CellDoubleClick);
            // 
            // Registro_Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.dgvEvaluacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.txtPorcen);
            this.Controls.Add(this.txtIDTRA);
            this.Controls.Add(this.txtIDEVA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Evaluacion";
            this.Text = "Registro_Evaluacion";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDEVA;
        private System.Windows.Forms.TextBox txtIDTRA;
        private System.Windows.Forms.TextBox txtPorcen;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button AgregarTrabajador;
        private System.Windows.Forms.DataGridView dgvEvaluacion;
    }
}