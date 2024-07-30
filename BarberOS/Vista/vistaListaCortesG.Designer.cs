namespace BarberOS.Vista
{
    partial class vistaListaCortesG
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
            this.txtToKill = new System.Windows.Forms.TextBox();
            this.btnBorrarCortes = new System.Windows.Forms.Button();
            this.btnActualizarCortes = new System.Windows.Forms.Button();
            this.txtNuevoDisponible = new System.Windows.Forms.TextBox();
            this.txtNuevoTipo = new System.Windows.Forms.TextBox();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarCortes = new System.Windows.Forms.Button();
            this.listCortes = new System.Windows.Forms.ListView();
            this.corteId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cortePrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteDisponible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnACortes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtToKill
            // 
            this.txtToKill.Location = new System.Drawing.Point(573, 331);
            this.txtToKill.Name = "txtToKill";
            this.txtToKill.Size = new System.Drawing.Size(100, 20);
            this.txtToKill.TabIndex = 17;
            // 
            // btnBorrarCortes
            // 
            this.btnBorrarCortes.Location = new System.Drawing.Point(375, 363);
            this.btnBorrarCortes.Name = "btnBorrarCortes";
            this.btnBorrarCortes.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCortes.TabIndex = 16;
            this.btnBorrarCortes.Text = "Borrar";
            this.btnBorrarCortes.UseVisualStyleBackColor = true;
            this.btnBorrarCortes.Click += new System.EventHandler(this.btnBorrarCortes_Click);
            // 
            // btnActualizarCortes
            // 
            this.btnActualizarCortes.Location = new System.Drawing.Point(262, 363);
            this.btnActualizarCortes.Name = "btnActualizarCortes";
            this.btnActualizarCortes.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarCortes.TabIndex = 15;
            this.btnActualizarCortes.Text = "Actualizar";
            this.btnActualizarCortes.UseVisualStyleBackColor = true;
            this.btnActualizarCortes.Click += new System.EventHandler(this.btnActualizarCortes_Click);
            // 
            // txtNuevoDisponible
            // 
            this.txtNuevoDisponible.Location = new System.Drawing.Point(573, 197);
            this.txtNuevoDisponible.Name = "txtNuevoDisponible";
            this.txtNuevoDisponible.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoDisponible.TabIndex = 14;
            // 
            // txtNuevoTipo
            // 
            this.txtNuevoTipo.Location = new System.Drawing.Point(573, 159);
            this.txtNuevoTipo.Name = "txtNuevoTipo";
            this.txtNuevoTipo.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoTipo.TabIndex = 13;
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(573, 119);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoPrecio.TabIndex = 12;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(573, 79);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoNombre.TabIndex = 11;
            // 
            // btnAgregarCortes
            // 
            this.btnAgregarCortes.Location = new System.Drawing.Point(143, 363);
            this.btnAgregarCortes.Name = "btnAgregarCortes";
            this.btnAgregarCortes.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCortes.TabIndex = 10;
            this.btnAgregarCortes.Text = "Agregar";
            this.btnAgregarCortes.UseVisualStyleBackColor = true;
            this.btnAgregarCortes.Click += new System.EventHandler(this.btnAgregarCortes_Click);
            // 
            // listCortes
            // 
            this.listCortes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.corteId,
            this.corteNombre,
            this.cortePrecio,
            this.corteTipo,
            this.corteDisponible});
            this.listCortes.FullRowSelect = true;
            this.listCortes.GridLines = true;
            this.listCortes.HideSelection = false;
            this.listCortes.Location = new System.Drawing.Point(143, 56);
            this.listCortes.Name = "listCortes";
            this.listCortes.Size = new System.Drawing.Size(307, 256);
            this.listCortes.TabIndex = 9;
            this.listCortes.UseCompatibleStateImageBehavior = false;
            this.listCortes.View = System.Windows.Forms.View.Details;
            // 
            // corteId
            // 
            this.corteId.DisplayIndex = 4;
            this.corteId.Text = "ID";
            // 
            // corteNombre
            // 
            this.corteNombre.DisplayIndex = 0;
            this.corteNombre.Text = "Nombre";
            // 
            // cortePrecio
            // 
            this.cortePrecio.DisplayIndex = 1;
            this.cortePrecio.Text = "Precio";
            // 
            // corteTipo
            // 
            this.corteTipo.DisplayIndex = 2;
            this.corteTipo.Text = "Tipo";
            // 
            // corteDisponible
            // 
            this.corteDisponible.DisplayIndex = 3;
            this.corteDisponible.Text = "Disponible";
            // 
            // btnACortes
            // 
            this.btnACortes.BackColor = System.Drawing.Color.Gold;
            this.btnACortes.Location = new System.Drawing.Point(-1, -4);
            this.btnACortes.Name = "btnACortes";
            this.btnACortes.Size = new System.Drawing.Size(96, 456);
            this.btnACortes.TabIndex = 18;
            this.btnACortes.Text = "Personal";
            this.btnACortes.UseVisualStyleBackColor = false;
            // 
            // vistaListaCortesG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnACortes);
            this.Controls.Add(this.txtToKill);
            this.Controls.Add(this.btnBorrarCortes);
            this.Controls.Add(this.btnActualizarCortes);
            this.Controls.Add(this.txtNuevoDisponible);
            this.Controls.Add(this.txtNuevoTipo);
            this.Controls.Add(this.txtNuevoPrecio);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.btnAgregarCortes);
            this.Controls.Add(this.listCortes);
            this.Name = "vistaListaCortesG";
            this.Text = "vistaListaCortesGcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToKill;
        private System.Windows.Forms.Button btnBorrarCortes;
        private System.Windows.Forms.Button btnActualizarCortes;
        private System.Windows.Forms.TextBox txtNuevoDisponible;
        private System.Windows.Forms.TextBox txtNuevoTipo;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Button btnAgregarCortes;
        private System.Windows.Forms.ListView listCortes;
        private System.Windows.Forms.ColumnHeader corteId;
        private System.Windows.Forms.ColumnHeader corteNombre;
        private System.Windows.Forms.ColumnHeader cortePrecio;
        private System.Windows.Forms.ColumnHeader corteTipo;
        private System.Windows.Forms.ColumnHeader corteDisponible;
        private System.Windows.Forms.Button btnACortes;
    }
}