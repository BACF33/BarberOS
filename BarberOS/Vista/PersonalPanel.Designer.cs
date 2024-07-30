namespace BarberOS
{
    partial class PersonalPanel
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(212, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Nombre";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(212, 97);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(67, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Especialidad";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(212, 149);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(62, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Disponible?";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(212, 200);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(61, 13);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Calificacion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(422, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 250);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(303, 149);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(35, 13);
            this.lblDisponible.TabIndex = 8;
            this.lblDisponible.Text = "label1";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(303, 97);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(35, 13);
            this.lblEspecialidad.TabIndex = 7;
            this.lblEspecialidad.Text = "label1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(303, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "label1";
            // 
            // PersonalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonalPanel";
            this.Size = new System.Drawing.Size(518, 257);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblNombre;
    }
}
