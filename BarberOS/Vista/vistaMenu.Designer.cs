namespace BarberOS.Vista
{
    partial class vistaMenu
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBarberos = new System.Windows.Forms.Button();
            this.btnCortes = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCurrentUser = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.Location = new System.Drawing.Point(4, 558);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(261, 54);
            this.btnIngresar.TabIndex = 25;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnBarberos
            // 
            this.btnBarberos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBarberos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBarberos.Location = new System.Drawing.Point(4, 402);
            this.btnBarberos.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.btnBarberos.Name = "btnBarberos";
            this.btnBarberos.Size = new System.Drawing.Size(261, 54);
            this.btnBarberos.TabIndex = 26;
            this.btnBarberos.Text = "BARBEROS";
            this.btnBarberos.UseVisualStyleBackColor = false;
            // 
            // btnCortes
            // 
            this.btnCortes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCortes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCortes.Location = new System.Drawing.Point(4, 480);
            this.btnCortes.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.btnCortes.Name = "btnCortes";
            this.btnCortes.Size = new System.Drawing.Size(261, 54);
            this.btnCortes.TabIndex = 24;
            this.btnCortes.Text = "CORTES";
            this.btnCortes.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicio.Location = new System.Drawing.Point(4, 324);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(261, 54);
            this.btnInicio.TabIndex = 23;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnCurrentUser);
            this.flowLayoutPanel1.Controls.Add(this.btnInicio);
            this.flowLayoutPanel1.Controls.Add(this.btnBarberos);
            this.flowLayoutPanel1.Controls.Add(this.btnCortes);
            this.flowLayoutPanel1.Controls.Add(this.btnIngresar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 897);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarberOS.Properties.Resources.BarberOs;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCurrentUser
            // 
            this.btnCurrentUser.BackColor = System.Drawing.Color.Coral;
            this.btnCurrentUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCurrentUser.Location = new System.Drawing.Point(4, 246);
            this.btnCurrentUser.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.btnCurrentUser.Name = "btnCurrentUser";
            this.btnCurrentUser.Size = new System.Drawing.Size(261, 54);
            this.btnCurrentUser.TabIndex = 27;
            this.btnCurrentUser.Text = "No has iniciado sesion";
            this.btnCurrentUser.UseVisualStyleBackColor = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Silver;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(263, 0);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.PanelContenedor.MaximumSize = new System.Drawing.Size(2560, 1329);
            this.PanelContenedor.MinimumSize = new System.Drawing.Size(1067, 738);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1537, 897);
            this.PanelContenedor.TabIndex = 28;
            // 
            // vistaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2554, 1318);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "vistaMenu";
            this.Text = "Inicio";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.Button btnBarberos;
        public System.Windows.Forms.Button btnCortes;
        public System.Windows.Forms.Button btnInicio;
        public System.Windows.Forms.Panel PanelContenedor;
        public System.Windows.Forms.Button btnCurrentUser;
    }
}