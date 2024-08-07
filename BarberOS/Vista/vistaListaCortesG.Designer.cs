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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarEmpleados = new System.Windows.Forms.Button();
            this.btnActualizarEmpleados = new System.Windows.Forms.Button();
            this.btnBorrarEmpleados = new System.Windows.Forms.Button();
            this.btnActualizarEmpleados2 = new System.Windows.Forms.Button();
            this.listCortes = new System.Windows.Forms.ListView();
            this.corteId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cortePrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.corteTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAPersonal = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarEmpleados2);
            this.flowLayoutPanel1.Controls.Add(this.listCortes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(104, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(696, 450);
            this.flowLayoutPanel1.TabIndex = 13;
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
            // btnActualizarEmpleados2
            // 
            this.btnActualizarEmpleados2.Location = new System.Drawing.Point(246, 3);
            this.btnActualizarEmpleados2.Name = "btnActualizarEmpleados2";
            this.btnActualizarEmpleados2.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarEmpleados2.TabIndex = 8;
            this.btnActualizarEmpleados2.Text = "Actualizar2";
            this.btnActualizarEmpleados2.UseVisualStyleBackColor = true;
            // 
            // listCortes
            // 
            this.listCortes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.corteId,
            this.corteNombre,
            this.cortePrecio,
            this.corteTipo});
            this.listCortes.FullRowSelect = true;
            this.listCortes.GridLines = true;
            this.listCortes.HideSelection = false;
            this.listCortes.Location = new System.Drawing.Point(3, 32);
            this.listCortes.Name = "listCortes";
            this.listCortes.Size = new System.Drawing.Size(684, 426);
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
            // 
            // cortePrecio
            // 
            this.cortePrecio.Text = "Precio";
            // 
            // corteTipo
            // 
            this.corteTipo.Text = "Tipo";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAPersonal);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(98, 450);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // btnAPersonal
            // 
            this.btnAPersonal.BackColor = System.Drawing.Color.Gold;
            this.btnAPersonal.Location = new System.Drawing.Point(3, 3);
            this.btnAPersonal.Name = "btnAPersonal";
            this.btnAPersonal.Size = new System.Drawing.Size(96, 456);
            this.btnAPersonal.TabIndex = 16;
            this.btnAPersonal.Text = "Personal";
            this.btnAPersonal.UseVisualStyleBackColor = false;
            // 
            // vistaListaCortesG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "vistaListaCortesG";
            this.Text = "vistaListaCortesGcs";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnAgregarEmpleados;
        public System.Windows.Forms.Button btnActualizarEmpleados;
        public System.Windows.Forms.Button btnBorrarEmpleados;
        public System.Windows.Forms.ListView listCortes;
        private System.Windows.Forms.ColumnHeader corteId;
        private System.Windows.Forms.ColumnHeader corteNombre;
        private System.Windows.Forms.ColumnHeader cortePrecio;
        private System.Windows.Forms.ColumnHeader corteTipo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.Button btnAPersonal;
        public System.Windows.Forms.Button btnActualizarEmpleados2;
    }
}