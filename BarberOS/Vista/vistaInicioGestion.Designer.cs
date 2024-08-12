namespace BarberOS.Vista
{
    partial class vistaInicioGestion
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.Location = new System.Drawing.Point(76, 68);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(563, 181);
            this.button3.TabIndex = 34;
            this.button3.Text = "Informacion";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Gray;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClientes.Location = new System.Drawing.Point(76, 247);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(293, 403);
            this.btnClientes.TabIndex = 36;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPersonal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPersonal.Location = new System.Drawing.Point(364, 247);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(275, 399);
            this.btnPersonal.TabIndex = 37;
            this.btnPersonal.Text = "PERSONAL";
            this.btnPersonal.UseVisualStyleBackColor = false;
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackColor = System.Drawing.Color.Coral;
            this.btnRegistros.Location = new System.Drawing.Point(764, 520);
            this.btnRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(390, 138);
            this.btnRegistros.TabIndex = 47;
            this.btnRegistros.Text = "REGISTROS";
            this.btnRegistros.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BarberOS.Properties.Resources.registros;
            this.pictureBox5.Location = new System.Drawing.Point(764, 68);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(390, 455);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 49;
            this.pictureBox5.TabStop = false;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnPersonal);
            this.pnlAdmin.Controls.Add(this.button3);
            this.pnlAdmin.Controls.Add(this.btnClientes);
            this.pnlAdmin.Controls.Add(this.pictureBox5);
            this.pnlAdmin.Controls.Add(this.btnRegistros);
            this.pnlAdmin.Location = new System.Drawing.Point(64, 41);
            this.pnlAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(1256, 667);
            this.pnlAdmin.TabIndex = 50;
            // 
            // vistaInicioGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pnlAdmin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vistaInicioGestion";
            this.Text = "vistaInicioGestion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Button btnPersonal;
        public System.Windows.Forms.Button btnClientes;
        public System.Windows.Forms.Button btnRegistros;
        public System.Windows.Forms.Panel pnlAdmin;
    }
}