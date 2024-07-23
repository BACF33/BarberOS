namespace BarberOS.Vista
{
    partial class vistaListaPersonalG
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
            this.listEmpleados = new System.Windows.Forms.ListView();
            this.empleadoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoContraseña = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoFull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarEmpleados = new System.Windows.Forms.Button();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtNuevoFull = new System.Windows.Forms.TextBox();
            this.txtNuevoCargo = new System.Windows.Forms.TextBox();
            this.btnActualizarEmpleados = new System.Windows.Forms.Button();
            this.btnBorrarEmpleados = new System.Windows.Forms.Button();
            this.txtToKill = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnACortes = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listEmpleados.Location = new System.Drawing.Point(149, 67);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(307, 256);
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
            // btnAgregarEmpleados
            // 
            this.btnAgregarEmpleados.Location = new System.Drawing.Point(149, 362);
            this.btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            this.btnAgregarEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEmpleados.TabIndex = 1;
            this.btnAgregarEmpleados.Text = "Agregar";
            this.btnAgregarEmpleados.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleados.Click += new System.EventHandler(this.btnAgregarEmpleados_Click);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(569, 82);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoNombre.TabIndex = 2;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(569, 118);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaContraseña.TabIndex = 3;
            // 
            // txtNuevoFull
            // 
            this.txtNuevoFull.Location = new System.Drawing.Point(569, 160);
            this.txtNuevoFull.Name = "txtNuevoFull";
            this.txtNuevoFull.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoFull.TabIndex = 4;
            // 
            // txtNuevoCargo
            // 
            this.txtNuevoCargo.Location = new System.Drawing.Point(569, 200);
            this.txtNuevoCargo.Name = "txtNuevoCargo";
            this.txtNuevoCargo.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoCargo.TabIndex = 5;
            // 
            // btnActualizarEmpleados
            // 
            this.btnActualizarEmpleados.Location = new System.Drawing.Point(261, 362);
            this.btnActualizarEmpleados.Name = "btnActualizarEmpleados";
            this.btnActualizarEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarEmpleados.TabIndex = 6;
            this.btnActualizarEmpleados.Text = "Actualizar";
            this.btnActualizarEmpleados.UseVisualStyleBackColor = true;
            this.btnActualizarEmpleados.Click += new System.EventHandler(this.btnActualizarEmpleados_Click);
            // 
            // btnBorrarEmpleados
            // 
            this.btnBorrarEmpleados.Location = new System.Drawing.Point(381, 362);
            this.btnBorrarEmpleados.Name = "btnBorrarEmpleados";
            this.btnBorrarEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarEmpleados.TabIndex = 7;
            this.btnBorrarEmpleados.Text = "Borrar";
            this.btnBorrarEmpleados.UseVisualStyleBackColor = true;
            this.btnBorrarEmpleados.Click += new System.EventHandler(this.btnBorrarEmpleados_Click);
            // 
            // txtToKill
            // 
            this.txtToKill.Location = new System.Drawing.Point(569, 332);
            this.txtToKill.Name = "txtToKill";
            this.txtToKill.Size = new System.Drawing.Size(100, 20);
            this.txtToKill.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 447);
            this.button1.TabIndex = 9;
            this.button1.Text = "Promociones";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnACortes
            // 
            this.btnACortes.BackColor = System.Drawing.Color.Gold;
            this.btnACortes.Location = new System.Drawing.Point(705, 0);
            this.btnACortes.Name = "btnACortes";
            this.btnACortes.Size = new System.Drawing.Size(96, 456);
            this.btnACortes.TabIndex = 10;
            this.btnACortes.Text = "Cortes";
            this.btnACortes.UseVisualStyleBackColor = false;
            this.btnACortes.Click += new System.EventHandler(this.btnACortes_Click);
            // 
            // vistaListaPersonalG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnACortes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtToKill);
            this.Controls.Add(this.btnBorrarEmpleados);
            this.Controls.Add(this.btnActualizarEmpleados);
            this.Controls.Add(this.txtNuevoCargo);
            this.Controls.Add(this.txtNuevoFull);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.btnAgregarEmpleados);
            this.Controls.Add(this.listEmpleados);
            this.Name = "vistaListaPersonalG";
            this.Text = "vistaListaBarbero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listEmpleados;
        private System.Windows.Forms.ColumnHeader empleadoNombre;
        private System.Windows.Forms.ColumnHeader empleadoContraseña;
        private System.Windows.Forms.ColumnHeader empleadoFull;
        private System.Windows.Forms.ColumnHeader empleadoCargo;
        private System.Windows.Forms.Button btnAgregarEmpleados;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtNuevoFull;
        private System.Windows.Forms.TextBox txtNuevoCargo;
        private System.Windows.Forms.Button btnActualizarEmpleados;
        private System.Windows.Forms.ColumnHeader empleadoId;
        private System.Windows.Forms.Button btnBorrarEmpleados;
        private System.Windows.Forms.TextBox txtToKill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnACortes;
    }
}