﻿namespace BarberOS.Vista
{
    partial class vistaListaPromocionesG
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAClientes = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarPromocion = new System.Windows.Forms.Button();
            this.btnActualizarPromocion = new System.Windows.Forms.Button();
            this.btnBorrarPromocion = new System.Windows.Forms.Button();
            this.listPromociones = new System.Windows.Forms.ListView();
            this.corteId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cortePrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteDisponible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAClientes);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(98, 450);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // btnAClientes
            // 
            this.btnAClientes.BackColor = System.Drawing.Color.Gold;
            this.btnAClientes.Location = new System.Drawing.Point(3, 3);
            this.btnAClientes.Name = "btnAClientes";
            this.btnAClientes.Size = new System.Drawing.Size(96, 456);
            this.btnAClientes.TabIndex = 16;
            this.btnAClientes.Text = "Clientes";
            this.btnAClientes.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarPromocion);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarPromocion);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrarPromocion);
            this.flowLayoutPanel1.Controls.Add(this.listPromociones);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(104, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(696, 450);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnAgregarPromocion
            // 
            this.btnAgregarPromocion.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarPromocion.Name = "btnAgregarPromocion";
            this.btnAgregarPromocion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPromocion.TabIndex = 1;
            this.btnAgregarPromocion.Text = "Agregar";
            this.btnAgregarPromocion.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPromocion
            // 
            this.btnActualizarPromocion.Location = new System.Drawing.Point(84, 3);
            this.btnActualizarPromocion.Name = "btnActualizarPromocion";
            this.btnActualizarPromocion.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPromocion.TabIndex = 6;
            this.btnActualizarPromocion.Text = "Actualizar";
            this.btnActualizarPromocion.UseVisualStyleBackColor = true;
            // 
            // btnBorrarPromocion
            // 
            this.btnBorrarPromocion.Location = new System.Drawing.Point(165, 3);
            this.btnBorrarPromocion.Name = "btnBorrarPromocion";
            this.btnBorrarPromocion.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarPromocion.TabIndex = 7;
            this.btnBorrarPromocion.Text = "Borrar";
            this.btnBorrarPromocion.UseVisualStyleBackColor = true;
            // 
            // listPromociones
            // 
            this.listPromociones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.corteId,
            this.corteNombre,
            this.cortePrecio,
            this.corteTipo,
            this.corteDisponible});
            this.listPromociones.FullRowSelect = true;
            this.listPromociones.GridLines = true;
            this.listPromociones.HideSelection = false;
            this.listPromociones.Location = new System.Drawing.Point(3, 32);
            this.listPromociones.Name = "listPromociones";
            this.listPromociones.Size = new System.Drawing.Size(684, 426);
            this.listPromociones.TabIndex = 0;
            this.listPromociones.UseCompatibleStateImageBehavior = false;
            this.listPromociones.View = System.Windows.Forms.View.Details;
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
            this.corteTipo.Text = "Nombre completo";
            // 
            // corteDisponible
            // 
            this.corteDisponible.DisplayIndex = 3;
            this.corteDisponible.Text = "Disponible";
            // 
            // vistaListaPromocionesG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "vistaListaPromocionesG";
            this.Text = "vistaListaPromocionesG";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.Button btnAClientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnAgregarPromocion;
        public System.Windows.Forms.Button btnActualizarPromocion;
        public System.Windows.Forms.Button btnBorrarPromocion;
        public System.Windows.Forms.ListView listPromociones;
        private System.Windows.Forms.ColumnHeader corteId;
        private System.Windows.Forms.ColumnHeader corteNombre;
        private System.Windows.Forms.ColumnHeader cortePrecio;
        private System.Windows.Forms.ColumnHeader corteTipo;
        private System.Windows.Forms.ColumnHeader corteDisponible;
    }
}