namespace BarberOS.Vista
{
    partial class VistaActualizarPromocion
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
            this.txtNNPromocion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNNProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPNProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNPPromocion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNNPromocion
            // 
            this.txtNNPromocion.Location = new System.Drawing.Point(204, 171);
            this.txtNNPromocion.Name = "txtNNPromocion";
            this.txtNNPromocion.Size = new System.Drawing.Size(217, 20);
            this.txtNNPromocion.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 93);
            this.button2.TabIndex = 56;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(15, 336);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(238, 93);
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.Text = "Finalizar proceso";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Descuento de la promocion";
            // 
            // txtNNProducto
            // 
            this.txtNNProducto.Location = new System.Drawing.Point(204, 12);
            this.txtNNProducto.Name = "txtNNProducto";
            this.txtNNProducto.Size = new System.Drawing.Size(217, 20);
            this.txtNNProducto.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nombre de la promocion";
            // 
            // txtPNProducto
            // 
            this.txtPNProducto.Location = new System.Drawing.Point(204, 93);
            this.txtPNProducto.Name = "txtPNProducto";
            this.txtPNProducto.Size = new System.Drawing.Size(217, 20);
            this.txtPNProducto.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Precio de la promocion";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(443, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 161);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Tipo de la promocion";
            // 
            // txtNPPromocion
            // 
            this.txtNPPromocion.FormattingEnabled = true;
            this.txtNPPromocion.Items.AddRange(new object[] {
            "Cabello",
            "Barba"});
            this.txtNPPromocion.Location = new System.Drawing.Point(204, 255);
            this.txtNPPromocion.Name = "txtNPPromocion";
            this.txtNPPromocion.Size = new System.Drawing.Size(217, 21);
            this.txtNPPromocion.TabIndex = 61;
            // 
            // vistaActualizarPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.txtNPPromocion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNNPromocion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNNProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPNProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "vistaActualizarPromocion";
            this.Text = "vistaActualizarPromocion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNNPromocion;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNNProducto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPNProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox txtNPPromocion;
    }
}