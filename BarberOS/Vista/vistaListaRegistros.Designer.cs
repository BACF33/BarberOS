namespace BarberOS.Vista
{
    partial class VistaListaRegistros
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
            this.listRegistros = new System.Windows.Forms.ListView();
            this.registroId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroProductoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroProductoPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regisroPromocionNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroPromocionPoder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.btnBorrarEmpleados = new System.Windows.Forms.Button();
            this.btnActualizarRegistros = new System.Windows.Forms.Button();
            this.txtSearchingFor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRegistros
            // 
            this.listRegistros.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listRegistros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.registroId,
            this.registroProductoNombre,
            this.registroProductoPrecio,
            this.regisroPromocionNombre,
            this.registroPromocionPoder,
            this.registroTotal});
            this.listRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRegistros.FullRowSelect = true;
            this.listRegistros.GridLines = true;
            this.listRegistros.HideSelection = false;
            this.listRegistros.Location = new System.Drawing.Point(3, 70);
            this.listRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.listRegistros.Name = "listRegistros";
            this.listRegistros.Size = new System.Drawing.Size(1545, 825);
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
            this.registroProductoNombre.Width = 222;
            // 
            // registroProductoPrecio
            // 
            this.registroProductoPrecio.Text = "Precio producto";
            this.registroProductoPrecio.Width = 222;
            // 
            // regisroPromocionNombre
            // 
            this.regisroPromocionNombre.Text = "Nombre promocion";
            this.regisroPromocionNombre.Width = 222;
            // 
            // registroPromocionPoder
            // 
            this.registroPromocionPoder.Text = "Poder promocion";
            this.registroPromocionPoder.Width = 200;
            // 
            // registroTotal
            // 
            this.registroTotal.Text = "Total";
            this.registroTotal.Width = 120;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Coral;
            this.btnVolver.Location = new System.Drawing.Point(977, 5);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(125, 58);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.BackColor = System.Drawing.Color.Coral;
            this.btnUpdate2.Location = new System.Drawing.Point(321, 5);
            this.btnUpdate2.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(137, 58);
            this.btnUpdate2.TabIndex = 8;
            this.btnUpdate2.Text = "Actualizar 2";
            this.btnUpdate2.UseVisualStyleBackColor = false;
            // 
            // btnBorrarEmpleados
            // 
            this.btnBorrarEmpleados.BackColor = System.Drawing.Color.Coral;
            this.btnBorrarEmpleados.Location = new System.Drawing.Point(176, 5);
            this.btnBorrarEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarEmpleados.Name = "btnBorrarEmpleados";
            this.btnBorrarEmpleados.Size = new System.Drawing.Size(137, 58);
            this.btnBorrarEmpleados.TabIndex = 7;
            this.btnBorrarEmpleados.Text = "Borrar";
            this.btnBorrarEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnActualizarRegistros
            // 
            this.btnActualizarRegistros.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarRegistros.Location = new System.Drawing.Point(16, 5);
            this.btnActualizarRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarRegistros.Name = "btnActualizarRegistros";
            this.btnActualizarRegistros.Size = new System.Drawing.Size(152, 58);
            this.btnActualizarRegistros.TabIndex = 6;
            this.btnActualizarRegistros.Text = "Actualizar";
            this.btnActualizarRegistros.UseVisualStyleBackColor = false;
            // 
            // txtSearchingFor
            // 
            this.txtSearchingFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchingFor.Location = new System.Drawing.Point(1261, 5);
            this.txtSearchingFor.Name = "txtSearchingFor";
            this.txtSearchingFor.Size = new System.Drawing.Size(274, 41);
            this.txtSearchingFor.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Coral;
            this.btnSearch.Location = new System.Drawing.Point(1119, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 51);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // vistaListaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchingFor);
            this.Controls.Add(this.listRegistros);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.btnBorrarEmpleados);
            this.Controls.Add(this.btnActualizarRegistros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vistaListaRegistros";
            this.Text = "vistaListaRegistros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listRegistros;
        private System.Windows.Forms.ColumnHeader registroId;
        private System.Windows.Forms.ColumnHeader registroProductoNombre;
        private System.Windows.Forms.ColumnHeader registroProductoPrecio;
        private System.Windows.Forms.ColumnHeader regisroPromocionNombre;
        private System.Windows.Forms.ColumnHeader registroPromocionPoder;
        private System.Windows.Forms.ColumnHeader registroTotal;
        public System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.Button btnUpdate2;
        public System.Windows.Forms.Button btnBorrarEmpleados;
        public System.Windows.Forms.Button btnActualizarRegistros;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSearchingFor;
    }
}