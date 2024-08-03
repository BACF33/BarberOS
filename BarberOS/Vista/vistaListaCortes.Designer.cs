namespace BarberOS.Vista
{
    partial class vistaListaCortes
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
            this.flpBarba = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flpCabello.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCabello
            // 
            this.flpCabello.AutoScroll = true;
            this.flpCabello.Controls.Add(this.button1);
            this.flpCabello.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpCabello.Location = new System.Drawing.Point(0, 0);
            this.flpCabello.Name = "flpCabello";
            this.flpCabello.Size = new System.Drawing.Size(405, 450);
            this.flpCabello.TabIndex = 0;
            // 
            // flpBarba
            // 
            this.flpBarba.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpBarba.Location = new System.Drawing.Point(411, 0);
            this.flpBarba.Name = "flpBarba";
            this.flpBarba.Size = new System.Drawing.Size(389, 450);
            this.flpBarba.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "CABELLO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // vistaListaCortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpBarba);
            this.Controls.Add(this.flpCabello);
            this.Name = "vistaListaCortes";
            this.Text = "vistaListaCortes";
            this.flpCabello.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpBarba;
        public System.Windows.Forms.FlowLayoutPanel flpCabello;
        private System.Windows.Forms.Button button1;
    }
}