﻿namespace BarberOS.Vista
{
    partial class vistaListaRegistros
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarEmpleados = new System.Windows.Forms.Button();
            this.btnActualizarEmpleados = new System.Windows.Forms.Button();
            this.btnBorrarEmpleados = new System.Windows.Forms.Button();
            this.listEmpleados = new System.Windows.Forms.ListView();
            this.empleadoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoContraseña = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoFull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.listEmpleados);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnAgregarEmpleados
            // 
            this.btnAgregarEmpleados.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            this.btnAgregarEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEmpleados.TabIndex = 1;
            this.btnAgregarEmpleados.Text = "Agregar";
            this.btnAgregarEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEmpleados
            // 
            this.btnActualizarEmpleados.Location = new System.Drawing.Point(84, 3);
            this.btnActualizarEmpleados.Name = "btnActualizarEmpleados";
            this.btnActualizarEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarEmpleados.TabIndex = 6;
            this.btnActualizarEmpleados.Text = "Actualizar";
            this.btnActualizarEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnBorrarEmpleados
            // 
            this.btnBorrarEmpleados.Location = new System.Drawing.Point(165, 3);
            this.btnBorrarEmpleados.Name = "btnBorrarEmpleados";
            this.btnBorrarEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarEmpleados.TabIndex = 7;
            this.btnBorrarEmpleados.Text = "Borrar";
            this.btnBorrarEmpleados.UseVisualStyleBackColor = true;
            // 
            // listEmpleados
            // 
            this.listEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empleadoId,
            this.empleadoNombre,
            this.empleadoContraseña,
            this.empleadoFull,
            this.empleadoCargo});
            this.listEmpleados.FullRowSelect = true;
            this.listEmpleados.GridLines = true;
            this.listEmpleados.HideSelection = false;
            this.listEmpleados.Location = new System.Drawing.Point(3, 32);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(684, 426);
            this.listEmpleados.TabIndex = 0;
            this.listEmpleados.UseCompatibleStateImageBehavior = false;
            this.listEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // empleadoId
            // 
            this.empleadoId.DisplayIndex = 4;
            this.empleadoId.Text = "ID";
            // 
            // empleadoNombre
            // 
            this.empleadoNombre.DisplayIndex = 0;
            this.empleadoNombre.Text = "Nombre";
            // 
            // empleadoContraseña
            // 
            this.empleadoContraseña.DisplayIndex = 1;
            this.empleadoContraseña.Text = "Contraseña";
            // 
            // empleadoFull
            // 
            this.empleadoFull.DisplayIndex = 2;
            this.empleadoFull.Text = "Nombre completo";
            // 
            // empleadoCargo
            // 
            this.empleadoCargo.DisplayIndex = 3;
            this.empleadoCargo.Text = "Cargo";
            // 
            // vistaListaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "vistaListaRegistros";
            this.Text = "vistaListaRegistros";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnAgregarEmpleados;
        public System.Windows.Forms.Button btnActualizarEmpleados;
        public System.Windows.Forms.Button btnBorrarEmpleados;
        public System.Windows.Forms.ListView listEmpleados;
        private System.Windows.Forms.ColumnHeader empleadoId;
        private System.Windows.Forms.ColumnHeader empleadoNombre;
        private System.Windows.Forms.ColumnHeader empleadoContraseña;
        private System.Windows.Forms.ColumnHeader empleadoFull;
        private System.Windows.Forms.ColumnHeader empleadoCargo;
    }
}