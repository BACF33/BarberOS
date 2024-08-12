namespace BarberOS.Vista
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
            this.btnActualizarRegistros = new System.Windows.Forms.Button();
            this.btnBorrarEmpleados = new System.Windows.Forms.Button();
            this.listRegistros = new System.Windows.Forms.ListView();
            this.registroId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroProductoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroProductoPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regisroPromocionNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroPromocionPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarRegistros);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrarEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate2);
            this.flowLayoutPanel1.Controls.Add(this.listRegistros);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnActualizarRegistros
            // 
            this.btnActualizarRegistros.Location = new System.Drawing.Point(3, 3);
            this.btnActualizarRegistros.Name = "btnActualizarRegistros";
            this.btnActualizarRegistros.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarRegistros.TabIndex = 6;
            this.btnActualizarRegistros.Text = "Actualizar";
            this.btnActualizarRegistros.UseVisualStyleBackColor = true;
            // 
            // btnBorrarEmpleados
            // 
            this.btnBorrarEmpleados.Location = new System.Drawing.Point(84, 3);
            this.btnBorrarEmpleados.Name = "btnBorrarEmpleados";
            this.btnBorrarEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarEmpleados.TabIndex = 7;
            this.btnBorrarEmpleados.Text = "Borrar";
            this.btnBorrarEmpleados.UseVisualStyleBackColor = true;
            // 
            // listRegistros
            // 
            this.listRegistros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.registroId,
            this.registroProductoNombre,
            this.registroProductoPrecio,
            this.regisroPromocionNombre,
            this.registroPromocionPrecio,
            this.registroTotal});
            this.listRegistros.FullRowSelect = true;
            this.listRegistros.GridLines = true;
            this.listRegistros.HideSelection = false;
            this.listRegistros.Location = new System.Drawing.Point(3, 32);
            this.listRegistros.Name = "listRegistros";
            this.listRegistros.Size = new System.Drawing.Size(684, 426);
            this.listRegistros.TabIndex = 0;
            this.listRegistros.UseCompatibleStateImageBehavior = false;
            this.listRegistros.View = System.Windows.Forms.View.Details;
            // 
            // registroId
            // 
            this.registroId.Text = "Id registro";
            // 
            // registroProductoNombre
            // 
            this.registroProductoNombre.Text = "Nombre producto";
            // 
            // registroProductoPrecio
            // 
            this.registroProductoPrecio.Text = "Precio producto";
            // 
            // regisroPromocionNombre
            // 
            this.regisroPromocionNombre.Text = "Nombre promocion";
            // 
            // registroPromocionPrecio
            // 
            this.registroPromocionPrecio.Text = "Poder promocion";
            // 
            // registroTotal
            // 
            this.registroTotal.Text = "Total";
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.Location = new System.Drawing.Point(165, 3);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate2.TabIndex = 8;
            this.btnUpdate2.Text = "Actualizar 2";
            this.btnUpdate2.UseVisualStyleBackColor = true;
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
        public System.Windows.Forms.ListView listRegistros;
        private System.Windows.Forms.ColumnHeader registroId;
        private System.Windows.Forms.ColumnHeader registroProductoNombre;
        private System.Windows.Forms.ColumnHeader registroProductoPrecio;
        private System.Windows.Forms.ColumnHeader regisroPromocionNombre;
        private System.Windows.Forms.ColumnHeader registroPromocionPrecio;
        private System.Windows.Forms.ColumnHeader registroTotal;
        public System.Windows.Forms.Button btnActualizarRegistros;
        public System.Windows.Forms.Button btnBorrarEmpleados;
        public System.Windows.Forms.Button btnUpdate2;
    }
}