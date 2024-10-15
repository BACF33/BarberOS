namespace BarberOS.Vista
{
    partial class VistaTemporal
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
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.txtPoster = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // picPerfil
            // 
            this.picPerfil.BackColor = System.Drawing.Color.Red;
            this.picPerfil.Location = new System.Drawing.Point(30, -52);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(218, 207);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfil.TabIndex = 8;
            this.picPerfil.TabStop = false;
            // 
            // txtPoster
            // 
            this.txtPoster.AutoSize = true;
            this.txtPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoster.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPoster.Location = new System.Drawing.Point(724, 23);
            this.txtPoster.Name = "txtPoster";
            this.txtPoster.Size = new System.Drawing.Size(326, 73);
            this.txtPoster.TabIndex = 7;
            this.txtPoster.Text = "Posteador";
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(-44, 199);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(1226, 417);
            this.txtTexto.TabIndex = 6;
            // 
            // VistaTemporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 564);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.txtPoster);
            this.Controls.Add(this.txtTexto);
            this.Name = "VistaTemporal";
            this.Text = "VistaTemporal";
            this.Load += new System.EventHandler(this.VistaTemporal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picPerfil;
        public System.Windows.Forms.Label txtPoster;
        public System.Windows.Forms.TextBox txtTexto;
    }
}