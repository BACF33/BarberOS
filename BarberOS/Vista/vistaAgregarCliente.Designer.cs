namespace BarberOS.Vista
{
    partial class VistaAgregarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoFull = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNuevoNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Puntos del nuevo cliente";
            // 
            // txtNuevoFull
            // 
            this.txtNuevoFull.Location = new System.Drawing.Point(204, 153);
            this.txtNuevoFull.Name = "txtNuevoFull";
            this.txtNuevoFull.Size = new System.Drawing.Size(217, 20);
            this.txtNuevoFull.TabIndex = 102;
            this.txtNuevoFull.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuevosPuntosV);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 93);
            this.button2.TabIndex = 105;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 336);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(238, 93);
            this.btnAgregar.TabIndex = 104;
            this.btnAgregar.Text = "Finalizar proceso";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Correo del nuevo cliente";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(204, 12);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNuevoNombre.TabIndex = 100;
            this.txtNuevoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuevoNombreV);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre del nuevo cliente";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(204, 93);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(217, 20);
            this.txtNuevaContraseña.TabIndex = 101;
            this.txtNuevaContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuevaContraseñaV);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Contraseña del nuevo cliente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(443, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 161);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // txtNuevoNumero
            // 
            this.txtNuevoNumero.Location = new System.Drawing.Point(204, 234);
            this.txtNuevoNumero.Name = "txtNuevoNumero";
            this.txtNuevoNumero.Size = new System.Drawing.Size(209, 20);
            this.txtNuevoNumero.TabIndex = 103;
            this.txtNuevoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuevoNumeroV);
            // 
            // vistaAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNuevoFull);
            this.Controls.Add(this.txtNuevoNumero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "vistaAgregarCliente";
            this.Text = "vistaAgregarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNuevoFull;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox txtNuevoNumero;
    }
}