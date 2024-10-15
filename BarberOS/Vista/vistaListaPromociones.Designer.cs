namespace BarberOS.Vista
{
    partial class VistaListaPromociones
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
            this.flpPromociones = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpPromociones
            // 
            this.flpPromociones.BackgroundImage = global::BarberOS.Properties.Resources.Background_BarberOS1;
            this.flpPromociones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPromociones.Location = new System.Drawing.Point(0, 0);
            this.flpPromociones.Name = "flpPromociones";
            this.flpPromociones.Size = new System.Drawing.Size(1350, 729);
            this.flpPromociones.TabIndex = 0;
            // 
            // VistaListaPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.flpPromociones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VistaListaPromociones";
            this.Text = "vistaListaPromociones";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpPromociones;
    }
}