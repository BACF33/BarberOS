﻿namespace BarberOS.Vista
{
    partial class vistaListaClientesG
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
            this.btnAProms = new System.Windows.Forms.Button();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.btnActualizarClientes = new System.Windows.Forms.Button();
            this.btnBorrarClientes = new System.Windows.Forms.Button();
            this.btnActualizarClientes2 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.listClientes = new System.Windows.Forms.ListView();
            this.empleadoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoContraseña = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoFull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAProms
            // 
            this.btnAProms.BackColor = System.Drawing.Color.Coral;
            this.btnAProms.Location = new System.Drawing.Point(923, -3);
            this.btnAProms.Name = "btnAProms";
            this.btnAProms.Size = new System.Drawing.Size(215, 734);
            this.btnAProms.TabIndex = 10;
            this.btnAProms.Text = "Promociones";
            this.btnAProms.UseVisualStyleBackColor = false;
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.BackColor = System.Drawing.Color.Coral;
            this.btnAgregarClientes.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(89, 46);
            this.btnAgregarClientes.TabIndex = 1;
            this.btnAgregarClientes.Text = "Agregar";
            this.btnAgregarClientes.UseVisualStyleBackColor = false;
            // 
            // btnActualizarClientes
            // 
            this.btnActualizarClientes.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarClientes.Location = new System.Drawing.Point(107, 12);
            this.btnActualizarClientes.Name = "btnActualizarClientes";
            this.btnActualizarClientes.Size = new System.Drawing.Size(89, 46);
            this.btnActualizarClientes.TabIndex = 6;
            this.btnActualizarClientes.Text = "Actualizar";
            this.btnActualizarClientes.UseVisualStyleBackColor = false;
            // 
            // btnBorrarClientes
            // 
            this.btnBorrarClientes.BackColor = System.Drawing.Color.Coral;
            this.btnBorrarClientes.Location = new System.Drawing.Point(199, 12);
            this.btnBorrarClientes.Name = "btnBorrarClientes";
            this.btnBorrarClientes.Size = new System.Drawing.Size(89, 46);
            this.btnBorrarClientes.TabIndex = 7;
            this.btnBorrarClientes.Text = "Borrar";
            this.btnBorrarClientes.UseVisualStyleBackColor = false;
            // 
            // btnActualizarClientes2
            // 
            this.btnActualizarClientes2.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarClientes2.Location = new System.Drawing.Point(294, 12);
            this.btnActualizarClientes2.Name = "btnActualizarClientes2";
            this.btnActualizarClientes2.Size = new System.Drawing.Size(89, 46);
            this.btnActualizarClientes2.TabIndex = 8;
            this.btnActualizarClientes2.Text = "Actualizar2";
            this.btnActualizarClientes2.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Coral;
            this.btnVolver.Location = new System.Drawing.Point(828, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 46);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // listClientes
            // 
            this.listClientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empleadoId,
            this.empleadoNombre,
            this.empleadoContraseña,
            this.empleadoFull,
            this.empleadoCargo});
            this.listClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClientes.FullRowSelect = true;
            this.listClientes.GridLines = true;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(-1, 64);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(927, 667);
            this.listClientes.TabIndex = 0;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            // 
            // empleadoId
            // 
            this.empleadoId.Text = "ID";
            // 
            // empleadoNombre
            // 
            this.empleadoNombre.Text = "Nombre";
            this.empleadoNombre.Width = 120;
            // 
            // empleadoContraseña
            // 
            this.empleadoContraseña.Text = "Contraseña";
            this.empleadoContraseña.Width = 160;
            // 
            // empleadoFull
            // 
            this.empleadoFull.Text = "Puntos";
            this.empleadoFull.Width = 120;
            // 
            // empleadoCargo
            // 
            this.empleadoCargo.Text = "Cargo";
            this.empleadoCargo.Width = 120;
            // 
            // vistaListaClientesG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnAProms);
            this.Controls.Add(this.btnAgregarClientes);
            this.Controls.Add(this.btnActualizarClientes);
            this.Controls.Add(this.btnBorrarClientes);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.btnActualizarClientes2);
            this.Controls.Add(this.btnVolver);
            this.Name = "vistaListaClientesG";
            this.Text = "vistaListaClientesG";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnAProms;
        public System.Windows.Forms.Button btnAgregarClientes;
        public System.Windows.Forms.Button btnActualizarClientes;
        public System.Windows.Forms.Button btnBorrarClientes;
        public System.Windows.Forms.ListView listClientes;
        private System.Windows.Forms.ColumnHeader empleadoId;
        private System.Windows.Forms.ColumnHeader empleadoNombre;
        private System.Windows.Forms.ColumnHeader empleadoContraseña;
        private System.Windows.Forms.ColumnHeader empleadoFull;
        private System.Windows.Forms.ColumnHeader empleadoCargo;
        public System.Windows.Forms.Button btnActualizarClientes2;
        public System.Windows.Forms.Button btnVolver;
    }
}