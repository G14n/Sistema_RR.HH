
namespace Interfaz_proyecto_MOANSO
{
    partial class Registro_Nomina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidtraba = new System.Windows.Forms.TextBox();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.bono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pagot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Trabajador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo  :";
            // 
            // txtidtraba
            // 
            this.txtidtraba.Location = new System.Drawing.Point(78, 134);
            this.txtidtraba.Name = "txtidtraba";
            this.txtidtraba.Size = new System.Drawing.Size(149, 20);
            this.txtidtraba.TabIndex = 3;
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(523, 134);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(117, 20);
            this.Sueldo.TabIndex = 4;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(255, 134);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 5;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(557, 313);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(99, 52);
            this.btnregistrar.TabIndex = 6;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // bono
            // 
            this.bono.Location = new System.Drawing.Point(82, 201);
            this.bono.Name = "bono";
            this.bono.Size = new System.Drawing.Size(149, 20);
            this.bono.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bonificaciones:";
            // 
            // pagot
            // 
            this.pagot.Location = new System.Drawing.Point(255, 201);
            this.pagot.Name = "pagot";
            this.pagot.Size = new System.Drawing.Size(200, 20);
            this.pagot.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total a pagar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // Registro_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pagot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.Sueldo);
            this.Controls.Add(this.txtidtraba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Nomina";
            this.Text = "Registro_Nomina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidtraba;
        private System.Windows.Forms.TextBox Sueldo;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox bono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pagot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}