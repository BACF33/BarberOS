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
            this.btnACortes = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            // btnAgregarEmpleados
            // 
            this.btnAgregarEmpleados.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            this.btnAgregarEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEmpleados.TabIndex = 1;
            this.btnAgregarEmpleados.Text = "Agregar";
            this.btnAgregarEmpleados.UseVisualStyleBackColor = true;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(246, 3);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(78, 20);
            this.txtNuevoNombre.TabIndex = 2;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(330, 3);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(75, 20);
            this.txtNuevaContraseña.TabIndex = 3;
            // 
            // txtNuevoFull
            // 
            this.txtNuevoFull.Location = new System.Drawing.Point(411, 3);
            this.txtNuevoFull.Name = "txtNuevoFull";
            this.txtNuevoFull.Size = new System.Drawing.Size(79, 20);
            this.txtNuevoFull.TabIndex = 4;
            // 
            // txtNuevoCargo
            // 
            this.txtNuevoCargo.Location = new System.Drawing.Point(496, 3);
            this.txtNuevoCargo.Name = "txtNuevoCargo";
            this.txtNuevoCargo.Size = new System.Drawing.Size(85, 20);
            this.txtNuevoCargo.TabIndex = 5;
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
            // txtToKill
            // 
            this.txtToKill.Location = new System.Drawing.Point(587, 3);
            this.txtToKill.Name = "txtToKill";
            this.txtToKill.Size = new System.Drawing.Size(100, 20);
            this.txtToKill.TabIndex = 8;
            // 
            // btnACortes
            // 
            this.btnACortes.BackColor = System.Drawing.Color.Gold;
            this.btnACortes.Location = new System.Drawing.Point(3, 3);
            this.btnACortes.Name = "btnACortes";
            this.btnACortes.Size = new System.Drawing.Size(96, 456);
            this.btnACortes.TabIndex = 10;
            this.btnACortes.Text = "Cortes";
            this.btnACortes.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.txtNuevoNombre);
            this.flowLayoutPanel1.Controls.Add(this.txtNuevaContraseña);
            this.flowLayoutPanel1.Controls.Add(this.txtNuevoFull);
            this.flowLayoutPanel1.Controls.Add(this.txtNuevoCargo);
            this.flowLayoutPanel1.Controls.Add(this.txtToKill);
            this.flowLayoutPanel1.Controls.Add(this.listEmpleados);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(696, 450);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnACortes);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(702, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(98, 450);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // vistaListaPersonalG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "vistaListaPersonalG";
            this.Text = "vistaListaBarbero";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader empleadoNombre;
        private System.Windows.Forms.ColumnHeader empleadoContraseña;
        private System.Windows.Forms.ColumnHeader empleadoFull;
        private System.Windows.Forms.ColumnHeader empleadoCargo;
        private System.Windows.Forms.ColumnHeader empleadoId;
        private System.Windows.Forms.Button btnACortes;
        public System.Windows.Forms.Button btnAgregarEmpleados;
        public System.Windows.Forms.Button btnActualizarEmpleados;
        public System.Windows.Forms.Button btnBorrarEmpleados;
        public System.Windows.Forms.ListView listEmpleados;
        public System.Windows.Forms.TextBox txtNuevoNombre;
        public System.Windows.Forms.TextBox txtNuevaContraseña;
        public System.Windows.Forms.TextBox txtNuevoFull;
        public System.Windows.Forms.TextBox txtNuevoCargo;
        public System.Windows.Forms.TextBox txtToKill;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}