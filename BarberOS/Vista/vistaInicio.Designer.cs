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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbInicio = new System.Windows.Forms.Label();
            this.btnBarberos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCortes = new System.Windows.Forms.Button();
            this.btnComunicados = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 555);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel2.TabIndex = 47;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackgroundImage = global::BarberOS.Properties.Resources.Background_BarberOS;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnComunicados, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbInicio, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBarberos, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnCortes, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(772, 549);
            this.tableLayoutPanel3.TabIndex = 50;
            // 
            // lbInicio
            // 
            this.lbInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInicio.AutoSize = true;
            this.lbInicio.BackColor = System.Drawing.Color.Transparent;
            this.lbInicio.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInicio.Location = new System.Drawing.Point(261, 20);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(250, 57);
            this.lbInicio.TabIndex = 48;
            this.lbInicio.Text = "Menu De Inicio";
            // 
            // btnBarberos
            // 
            this.btnBarberos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBarberos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBarberos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarberos.ForeColor = System.Drawing.Color.White;
            this.btnBarberos.Location = new System.Drawing.Point(267, 341);
            this.btnBarberos.Name = "btnBarberos";
            this.btnBarberos.Size = new System.Drawing.Size(237, 65);
            this.btnBarberos.TabIndex = 47;
            this.btnBarberos.Text = "Barberos";
            this.btnBarberos.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(267, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 66);
            this.button2.TabIndex = 46;
            this.button2.Text = "Agendar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnCortes
            // 
            this.btnCortes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCortes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCortes.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCortes.ForeColor = System.Drawing.Color.White;
            this.btnCortes.Location = new System.Drawing.Point(267, 122);
            this.btnCortes.Name = "btnCortes";
            this.btnCortes.Size = new System.Drawing.Size(237, 70);
            this.btnCortes.TabIndex = 23;
            this.btnCortes.Text = "Cortes";
            this.btnCortes.UseVisualStyleBackColor = false;
            // 
            // btnComunicados
            // 
            this.btnComunicados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComunicados.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnComunicados.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComunicados.ForeColor = System.Drawing.Color.White;
            this.btnComunicados.Location = new System.Drawing.Point(267, 446);
            this.btnComunicados.Name = "btnComunicados";
            this.btnComunicados.Size = new System.Drawing.Size(237, 81);
            this.btnComunicados.TabIndex = 49;
            this.btnComunicados.Text = "Comunicados";
            this.btnComunicados.UseVisualStyleBackColor = false;
            // 
            // VistaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "VistaInicio";
            this.Text = "vistaInicio";
            this.Load += new System.EventHandler(this.VistaInicio_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Button btnComunicados;
        private System.Windows.Forms.Label lbInicio;
        public System.Windows.Forms.Button btnBarberos;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnCortes;
    }
}