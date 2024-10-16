namespace BarberOS.Vista
{
    partial class PanelAsignacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompletar = new System.Windows.Forms.Button();
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.imgCompletado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompletado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompletar
            // 
            this.btnCompletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(103)))), ((int)(((byte)(89)))));
            this.btnCompletar.Location = new System.Drawing.Point(465, 155);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(185, 88);
            this.btnCompletar.TabIndex = 0;
            this.btnCompletar.Text = "Completado";
            this.btnCompletar.UseVisualStyleBackColor = false;
            // 
            // dtpLimite
            // 
            this.dtpLimite.Enabled = false;
            this.dtpLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLimite.Location = new System.Drawing.Point(465, 50);
            this.dtpLimite.Name = "dtpLimite";
            this.dtpLimite.Size = new System.Drawing.Size(185, 44);
            this.dtpLimite.TabIndex = 1;
            // 
            // txtOrden
            // 
            this.txtOrden.Enabled = false;
            this.txtOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrden.Location = new System.Drawing.Point(33, 50);
            this.txtOrden.Multiline = true;
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(367, 193);
            this.txtOrden.TabIndex = 2;
            // 
            // imgCompletado
            // 
            this.imgCompletado.Image = global::BarberOS.Properties.Resources.chque21;
            this.imgCompletado.Location = new System.Drawing.Point(217, 16);
            this.imgCompletado.Name = "imgCompletado";
            this.imgCompletado.Size = new System.Drawing.Size(242, 200);
            this.imgCompletado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCompletado.TabIndex = 3;
            this.imgCompletado.TabStop = false;
            this.imgCompletado.Visible = false;
            // 
            // PanelAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.imgCompletado);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.dtpLimite);
            this.Controls.Add(this.btnCompletar);
            this.Name = "PanelAsignacion";
            this.Size = new System.Drawing.Size(674, 279);
            this.Load += new System.EventHandler(this.PanelAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCompletado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtOrden;
        public System.Windows.Forms.DateTimePicker dtpLimite;
        public System.Windows.Forms.Button btnCompletar;
        public System.Windows.Forms.PictureBox imgCompletado;
    }
}
