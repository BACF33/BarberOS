namespace BarberOS.Vista
{
    partial class VistaComunicados
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
            this.flpComunicados = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpComunicados
            // 
            this.flpComunicados.BackgroundImage = global::BarberOS.Properties.Resources.Background_BarberOS1;
            this.flpComunicados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpComunicados.Location = new System.Drawing.Point(0, 0);
            this.flpComunicados.Name = "flpComunicados";
            this.flpComunicados.Size = new System.Drawing.Size(1350, 729);
            this.flpComunicados.TabIndex = 0;
            // 
            // VistaComunicados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BarberOS.Properties.Resources.Background_BarberOS1;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.flpComunicados);
            this.Name = "VistaComunicados";
            this.Text = "VistaComunicados";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpComunicados;
    }
}