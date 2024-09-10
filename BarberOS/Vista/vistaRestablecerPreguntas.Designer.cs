namespace BarberOS.Vista
{
    partial class vistaRestablecerPreguntas
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.txtBDay = new System.Windows.Forms.TextBox();
            this.txtFavorite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::BarberOS.Properties.Resources.Fondo_negro_de_barberia;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1264, 681);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.txtFavorite);
            this.panel1.Controls.Add(this.txtBDay);
            this.panel1.Controls.Add(this.txtSchool);
            this.panel1.Controls.Add(this.txtHome);
            this.panel1.Location = new System.Drawing.Point(259, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 541);
            this.panel1.TabIndex = 11;
            // 
            // txtHome
            // 
            this.txtHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHome.Location = new System.Drawing.Point(21, 221);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(320, 35);
            this.txtHome.TabIndex = 0;
            // 
            // txtSchool
            // 
            this.txtSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchool.Location = new System.Drawing.Point(421, 221);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(306, 35);
            this.txtSchool.TabIndex = 1;
            // 
            // txtBDay
            // 
            this.txtBDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDay.Location = new System.Drawing.Point(21, 473);
            this.txtBDay.Name = "txtBDay";
            this.txtBDay.Size = new System.Drawing.Size(320, 35);
            this.txtBDay.TabIndex = 2;
            // 
            // txtFavorite
            // 
            this.txtFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFavorite.Location = new System.Drawing.Point(421, 473);
            this.txtFavorite.Name = "txtFavorite";
            this.txtFavorite.Size = new System.Drawing.Size(306, 35);
            this.txtFavorite.TabIndex = 3;
            // 
            // vistaRestablecerPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "vistaRestablecerPreguntas";
            this.Text = "vistaRestablecerPreguntas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFavorite;
        private System.Windows.Forms.TextBox txtBDay;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.TextBox txtHome;
    }
}