namespace BarberOS.Vista
{
    partial class PanelComunicado
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtPoster = new System.Windows.Forms.Label();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Enabled = false;
            this.txtTexto.Location = new System.Drawing.Point(43, 129);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(518, 248);
            this.txtTexto.TabIndex = 0;
            // 
            // txtPoster
            // 
            this.txtPoster.AutoSize = true;
            this.txtPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoster.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPoster.Location = new System.Drawing.Point(337, 49);
            this.txtPoster.Name = "txtPoster";
            this.txtPoster.Size = new System.Drawing.Size(163, 37);
            this.txtPoster.TabIndex = 1;
            this.txtPoster.Text = "Posteador";
            // 
            // picPerfil
            // 
            this.picPerfil.BackColor = System.Drawing.Color.Red;
            this.picPerfil.Location = new System.Drawing.Point(99, 13);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(134, 110);
            this.picPerfil.TabIndex = 2;
            this.picPerfil.TabStop = false;
            // 
            // PanelComunicado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.txtPoster);
            this.Controls.Add(this.txtTexto);
            this.Name = "PanelComunicado";
            this.Size = new System.Drawing.Size(600, 390);
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTexto;
        public System.Windows.Forms.Label txtPoster;
        public System.Windows.Forms.PictureBox picPerfil;
    }
}
