namespace BarberOS.Vista
{
    partial class VistaListaCortes
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
            this.flpCabello = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpCabello
            // 
            this.flpCabello.AutoScroll = true;
            this.flpCabello.BackgroundImage = global::BarberOS.Properties.Resources.Background_BarberOS;
            this.flpCabello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCabello.Location = new System.Drawing.Point(0, 0);
            this.flpCabello.Name = "flpCabello";
            this.flpCabello.Size = new System.Drawing.Size(1350, 729);
            this.flpCabello.TabIndex = 0;
            // 
            // VistaListaCortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.flpCabello);
            this.Name = "VistaListaCortes";
            this.Text = "vistaListaCortes";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flpCabello;
    }
}