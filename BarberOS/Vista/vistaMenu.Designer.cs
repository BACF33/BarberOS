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
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.Location = new System.Drawing.Point(3, 336);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(196, 44);
            this.btnIngresar.TabIndex = 25;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBarberos
            // 
            this.btnBarberos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBarberos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBarberos.Location = new System.Drawing.Point(3, 286);
            this.btnBarberos.Name = "btnBarberos";
            this.btnBarberos.Size = new System.Drawing.Size(196, 44);
            this.btnBarberos.TabIndex = 26;
            this.btnBarberos.Text = "BARBEROS";
            this.btnBarberos.UseVisualStyleBackColor = false;
            this.btnBarberos.Click += new System.EventHandler(this.btnBarberos_Click);
            // 
            // btnCortes
            // 
            this.btnCortes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCortes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCortes.Location = new System.Drawing.Point(3, 236);
            this.btnCortes.Name = "btnCortes";
            this.btnCortes.Size = new System.Drawing.Size(196, 44);
            this.btnCortes.TabIndex = 24;
            this.btnCortes.Text = "CORTES";
            this.btnCortes.UseVisualStyleBackColor = false;
            this.btnCortes.Click += new System.EventHandler(this.btnCortes_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicio.Location = new System.Drawing.Point(3, 186);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(196, 44);
            this.btnInicio.TabIndex = 23;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnInicio);
            this.flowLayoutPanel1.Controls.Add(this.btnCortes);
            this.flowLayoutPanel1.Controls.Add(this.btnBarberos);
            this.flowLayoutPanel1.Controls.Add(this.btnIngresar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(197, 561);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarberOS.Properties.Resources.BarberOs;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Silver;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(197, 0);
            this.PanelContenedor.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.PanelContenedor.MinimumSize = new System.Drawing.Size(800, 600);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(800, 600);
            this.PanelContenedor.TabIndex = 28;
            // 
            // vistaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "vistaMenu";
            this.Text = "Inicio";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBarberos;
        private System.Windows.Forms.Button btnCortes;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}