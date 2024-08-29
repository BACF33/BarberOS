namespace BarberOS.Vistas
{
    partial class VistaInicio
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
            this.btnBarberos = new System.Windows.Forms.Button();
            this.btnCortes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBarberos
            // 
            this.btnBarberos.BackColor = System.Drawing.Color.Coral;
            this.btnBarberos.Location = new System.Drawing.Point(825, 166);
            this.btnBarberos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBarberos.Name = "btnBarberos";
            this.btnBarberos.Size = new System.Drawing.Size(266, 166);
            this.btnBarberos.TabIndex = 33;
            this.btnBarberos.Text = "Barberos";
            this.btnBarberos.UseVisualStyleBackColor = false;
            // 
            // btnCortes
            // 
            this.btnCortes.BackColor = System.Drawing.Color.Coral;
            this.btnCortes.Location = new System.Drawing.Point(447, 166);
            this.btnCortes.Margin = new System.Windows.Forms.Padding(4);
            this.btnCortes.Name = "btnCortes";
            this.btnCortes.Size = new System.Drawing.Size(265, 166);
            this.btnCortes.TabIndex = 22;
            this.btnCortes.Text = "Cortes";
            this.btnCortes.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::BarberOS.Properties.Resources.barLog;
            this.pictureBox1.Location = new System.Drawing.Point(425, 428);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(13, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1565, 123);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // vistaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 971);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBarberos);
            this.Controls.Add(this.btnCortes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1918, 1018);
            this.MinimumSize = new System.Drawing.Size(1818, 944);
            this.Name = "vistaInicio";
            this.Text = "vistaInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btnCortes;
        public System.Windows.Forms.Button btnBarberos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}