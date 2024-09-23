namespace BarberOS.Vista
{
    partial class VistaPerfilUsuario
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
            this.pnlBarberos = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBarberos = new System.Windows.Forms.Button();
            this.pnlAgendar = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.pnlBarberos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAgendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarberos
            // 
            this.pnlBarberos.Controls.Add(this.pictureBox2);
            this.pnlBarberos.Controls.Add(this.btnBarberos);
            this.pnlBarberos.Location = new System.Drawing.Point(424, 301);
            this.pnlBarberos.Name = "pnlBarberos";
            this.pnlBarberos.Size = new System.Drawing.Size(270, 71);
            this.pnlBarberos.TabIndex = 113;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pictureBox2.Image = global::BarberOS.Properties.Resources.Proyecto_nuevo__8_;
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 110;
            this.pictureBox2.TabStop = false;
            // 
            // btnBarberos
            // 
            this.btnBarberos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.btnBarberos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarberos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarberos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBarberos.Location = new System.Drawing.Point(0, 2);
            this.btnBarberos.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.btnBarberos.Name = "btnBarberos";
            this.btnBarberos.Size = new System.Drawing.Size(281, 66);
            this.btnBarberos.TabIndex = 102;
            this.btnBarberos.TabStop = false;
            this.btnBarberos.Text = "     BARBEROS";
            this.btnBarberos.UseVisualStyleBackColor = false;
            // 
            // pnlAgendar
            // 
            this.pnlAgendar.Controls.Add(this.pictureBox6);
            this.pnlAgendar.Controls.Add(this.btnAgendar);
            this.pnlAgendar.Location = new System.Drawing.Point(400, 150);
            this.pnlAgendar.Name = "pnlAgendar";
            this.pnlAgendar.Size = new System.Drawing.Size(281, 60);
            this.pnlAgendar.TabIndex = 117;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pictureBox6.Image = global::BarberOS.Properties.Resources._52462901;
            this.pictureBox6.Location = new System.Drawing.Point(10, 10);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 114;
            this.pictureBox6.TabStop = false;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgendar.Location = new System.Drawing.Point(3, 3);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(270, 54);
            this.btnAgendar.TabIndex = 105;
            this.btnAgendar.TabStop = false;
            this.btnAgendar.Text = "      AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = false;
            // 
            // VistaPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 673);
            this.Controls.Add(this.pnlAgendar);
            this.Controls.Add(this.pnlBarberos);
            this.Name = "VistaPerfilUsuario";
            this.Text = "vistaPerfilUsuario";
            this.pnlBarberos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlAgendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlBarberos;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btnBarberos;
        public System.Windows.Forms.Panel pnlAgendar;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.Button btnAgendar;
    }
}