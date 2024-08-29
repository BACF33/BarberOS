namespace BarberOS.Vista
{
    partial class VistaListaCortesG
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
            this.btnAgregarEmpleados = new System.Windows.Forms.Button();
            this.btnActualizarEmpleados = new System.Windows.Forms.Button();
            this.btnBorrarEmpleados = new System.Windows.Forms.Button();
            this.btnActualizarEmpleados2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.listCortes = new System.Windows.Forms.ListView();
            this.corteId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cortePrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAPersonal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarEmpleados
            // 
            this.btnAgregarEmpleados.BackColor = System.Drawing.Color.Coral;
            this.btnAgregarEmpleados.Location = new System.Drawing.Point(12, 9);
            this.btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            this.btnAgregarEmpleados.Size = new System.Drawing.Size(83, 43);
            this.btnAgregarEmpleados.TabIndex = 100;
            this.btnAgregarEmpleados.Text = "Agregar";
            this.btnAgregarEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnActualizarEmpleados
            // 
            this.btnActualizarEmpleados.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarEmpleados.Location = new System.Drawing.Point(101, 9);
            this.btnActualizarEmpleados.Name = "btnActualizarEmpleados";
            this.btnActualizarEmpleados.Size = new System.Drawing.Size(80, 43);
            this.btnActualizarEmpleados.TabIndex = 101;
            this.btnActualizarEmpleados.Text = "Actualizar";
            this.btnActualizarEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnBorrarEmpleados
            // 
            this.btnBorrarEmpleados.BackColor = System.Drawing.Color.Coral;
            this.btnBorrarEmpleados.Location = new System.Drawing.Point(196, 9);
            this.btnBorrarEmpleados.Name = "btnBorrarEmpleados";
            this.btnBorrarEmpleados.Size = new System.Drawing.Size(81, 43);
            this.btnBorrarEmpleados.TabIndex = 102;
            this.btnBorrarEmpleados.Text = "Borrar";
            this.btnBorrarEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnActualizarEmpleados2
            // 
            this.btnActualizarEmpleados2.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarEmpleados2.Location = new System.Drawing.Point(292, 9);
            this.btnActualizarEmpleados2.Name = "btnActualizarEmpleados2";
            this.btnActualizarEmpleados2.Size = new System.Drawing.Size(82, 43);
            this.btnActualizarEmpleados2.TabIndex = 103;
            this.btnActualizarEmpleados2.Text = "Actualizar2";
            this.btnActualizarEmpleados2.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Coral;
            this.btnSearch.Location = new System.Drawing.Point(652, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 43);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(736, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 20);
            this.txtSearch.TabIndex = 105;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Coral;
            this.btnVolver.Location = new System.Drawing.Point(566, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 43);
            this.btnVolver.TabIndex = 104;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // listCortes
            // 
            this.listCortes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listCortes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.corteId,
            this.corteNombre,
            this.cortePrecio,
            this.corteTipo});
            this.listCortes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCortes.FullRowSelect = true;
            this.listCortes.GridLines = true;
            this.listCortes.HideSelection = false;
            this.listCortes.Location = new System.Drawing.Point(12, 58);
            this.listCortes.Name = "listCortes";
            this.listCortes.Size = new System.Drawing.Size(914, 671);
            this.listCortes.TabIndex = 0;
            this.listCortes.UseCompatibleStateImageBehavior = false;
            this.listCortes.View = System.Windows.Forms.View.Details;
            // 
            // corteId
            // 
            this.corteId.Text = "ID";
            // 
            // corteNombre
            // 
            this.corteNombre.Text = "Nombre";
            this.corteNombre.Width = 120;
            // 
            // cortePrecio
            // 
            this.cortePrecio.Text = "Precio";
            this.cortePrecio.Width = 120;
            // 
            // corteTipo
            // 
            this.corteTipo.Text = "Tipo";
            this.corteTipo.Width = 120;
            // 
            // btnAPersonal
            // 
            this.btnAPersonal.BackColor = System.Drawing.Color.Coral;
            this.btnAPersonal.Location = new System.Drawing.Point(923, -2);
            this.btnAPersonal.Name = "btnAPersonal";
            this.btnAPersonal.Size = new System.Drawing.Size(217, 736);
            this.btnAPersonal.TabIndex = 107;
            this.btnAPersonal.Text = "Personal";
            this.btnAPersonal.UseVisualStyleBackColor = false;
            // 
            // vistaListaCortesG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnActualizarEmpleados2);
            this.Controls.Add(this.btnBorrarEmpleados);
            this.Controls.Add(this.btnActualizarEmpleados);
            this.Controls.Add(this.btnAgregarEmpleados);
            this.Controls.Add(this.btnAPersonal);
            this.Controls.Add(this.listCortes);
            this.Name = "vistaListaCortesG";
            this.Text = "vistaListaCortesGcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnAgregarEmpleados;
        public System.Windows.Forms.Button btnActualizarEmpleados;
        public System.Windows.Forms.Button btnBorrarEmpleados;
        public System.Windows.Forms.ListView listCortes;
        private System.Windows.Forms.ColumnHeader corteId;
        private System.Windows.Forms.ColumnHeader corteNombre;
        private System.Windows.Forms.ColumnHeader cortePrecio;
        private System.Windows.Forms.ColumnHeader corteTipo;
        public System.Windows.Forms.Button btnActualizarEmpleados2;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.Button btnAPersonal;
    }
}