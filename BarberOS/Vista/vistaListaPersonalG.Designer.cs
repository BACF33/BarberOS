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
            this.btnACortes = new System.Windows.Forms.Button();
            this.btnAgregarEmpleados = new System.Windows.Forms.Button();
            this.btnActualizarEmpleados = new System.Windows.Forms.Button();
            this.btnBorrarEmpleados = new System.Windows.Forms.Button();
            this.empleadoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoContraseña = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoFull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listEmpleados = new System.Windows.Forms.ListView();
            this.btnActualizarEmpleados2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.empleadoNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnACortes
            // 
            this.btnACortes.BackColor = System.Drawing.Color.Coral;
            this.btnACortes.Location = new System.Drawing.Point(1244, 2);
            this.btnACortes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnACortes.Name = "btnACortes";
            this.btnACortes.Size = new System.Drawing.Size(317, 902);
            this.btnACortes.TabIndex = 10;
            this.btnACortes.Text = "Cortes";
            this.btnACortes.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEmpleados
            // 
            this.btnAgregarEmpleados.BackColor = System.Drawing.Color.Coral;
            this.btnAgregarEmpleados.Location = new System.Drawing.Point(11, 2);
            this.btnAgregarEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            this.btnAgregarEmpleados.Size = new System.Drawing.Size(127, 53);
            this.btnAgregarEmpleados.TabIndex = 1;
            this.btnAgregarEmpleados.Text = "Agregar";
            this.btnAgregarEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnActualizarEmpleados
            // 
            this.btnActualizarEmpleados.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarEmpleados.Location = new System.Drawing.Point(145, 2);
            this.btnActualizarEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarEmpleados.Name = "btnActualizarEmpleados";
            this.btnActualizarEmpleados.Size = new System.Drawing.Size(124, 53);
            this.btnActualizarEmpleados.TabIndex = 6;
            this.btnActualizarEmpleados.Text = "Actualizar";
            this.btnActualizarEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnBorrarEmpleados
            // 
            this.btnBorrarEmpleados.BackColor = System.Drawing.Color.Coral;
            this.btnBorrarEmpleados.Location = new System.Drawing.Point(277, 2);
            this.btnBorrarEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarEmpleados.Name = "btnBorrarEmpleados";
            this.btnBorrarEmpleados.Size = new System.Drawing.Size(125, 53);
            this.btnBorrarEmpleados.TabIndex = 7;
            this.btnBorrarEmpleados.Text = "Borrar";
            this.btnBorrarEmpleados.UseVisualStyleBackColor = false;
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
            this.empleadoContraseña.Width = 180;
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
            // listEmpleados
            // 
            this.listEmpleados.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empleadoId,
            this.empleadoNombre,
            this.empleadoContraseña,
            this.empleadoFull,
            this.empleadoCargo,
            this.empleadoNumero});
            this.listEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEmpleados.ForeColor = System.Drawing.Color.Black;
            this.listEmpleados.FullRowSelect = true;
            this.listEmpleados.GridLines = true;
            this.listEmpleados.HideSelection = false;
            this.listEmpleados.Location = new System.Drawing.Point(0, 63);
            this.listEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(1247, 841);
            this.listEmpleados.TabIndex = 0;
            this.listEmpleados.UseCompatibleStateImageBehavior = false;
            this.listEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // btnActualizarEmpleados2
            // 
            this.btnActualizarEmpleados2.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarEmpleados2.Location = new System.Drawing.Point(411, 2);
            this.btnActualizarEmpleados2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarEmpleados2.Name = "btnActualizarEmpleados2";
            this.btnActualizarEmpleados2.Size = new System.Drawing.Size(132, 53);
            this.btnActualizarEmpleados2.TabIndex = 8;
            this.btnActualizarEmpleados2.Text = "Actualizar2";
            this.btnActualizarEmpleados2.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Coral;
            this.btnSearch.Location = new System.Drawing.Point(789, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 50);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(927, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(308, 37);
            this.txtSearch.TabIndex = 10;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Coral;
            this.btnVolver.Location = new System.Drawing.Point(640, 4);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(141, 50);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // empleadoNumero
            // 
            this.empleadoNumero.Text = "Numero";
            this.empleadoNumero.Width = 480;
            // 
            // vistaListaPersonalG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.btnAgregarEmpleados);
            this.Controls.Add(this.btnACortes);
            this.Controls.Add(this.btnActualizarEmpleados);
            this.Controls.Add(this.btnBorrarEmpleados);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.btnActualizarEmpleados2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "vistaListaPersonalG";
            this.Text = "vistaListaBarbero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnACortes;
        public System.Windows.Forms.Button btnAgregarEmpleados;
        public System.Windows.Forms.Button btnActualizarEmpleados;
        public System.Windows.Forms.Button btnBorrarEmpleados;
        private System.Windows.Forms.ColumnHeader empleadoId;
        private System.Windows.Forms.ColumnHeader empleadoNombre;
        private System.Windows.Forms.ColumnHeader empleadoContraseña;
        private System.Windows.Forms.ColumnHeader empleadoFull;
        private System.Windows.Forms.ColumnHeader empleadoCargo;
        public System.Windows.Forms.ListView listEmpleados;
        public System.Windows.Forms.Button btnActualizarEmpleados2;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ColumnHeader empleadoNumero;
    }
}