namespace BarberOS.Vista
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
            this.btnAClientes = new System.Windows.Forms.Button();
            this.btnAgregarPromocion = new System.Windows.Forms.Button();
            this.btnActualizarPromocion = new System.Windows.Forms.Button();
            this.btnBorrarPromocion = new System.Windows.Forms.Button();
            this.btnActualizarPromocion2 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.listPromociones = new System.Windows.Forms.ListView();
            this.promocionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.promocionNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.promocionPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.promocionTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.promocionPoder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchingFor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAClientes
            // 
            this.btnAClientes.BackColor = System.Drawing.Color.Coral;
            this.btnAClientes.Location = new System.Drawing.Point(925, 1);
            this.btnAClientes.Name = "btnAClientes";
            this.btnAClientes.Size = new System.Drawing.Size(217, 728);
            this.btnAClientes.TabIndex = 107;
            this.btnAClientes.Text = "Clientes";
            this.btnAClientes.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPromocion
            // 
            this.btnAgregarPromocion.BackColor = System.Drawing.Color.Coral;
            this.btnAgregarPromocion.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarPromocion.Name = "btnAgregarPromocion";
            this.btnAgregarPromocion.Size = new System.Drawing.Size(91, 48);
            this.btnAgregarPromocion.TabIndex = 100;
            this.btnAgregarPromocion.Text = "Agregar";
            this.btnAgregarPromocion.UseVisualStyleBackColor = false;
            // 
            // btnActualizarPromocion
            // 
            this.btnActualizarPromocion.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarPromocion.Location = new System.Drawing.Point(119, 12);
            this.btnActualizarPromocion.Name = "btnActualizarPromocion";
            this.btnActualizarPromocion.Size = new System.Drawing.Size(87, 48);
            this.btnActualizarPromocion.TabIndex = 101;
            this.btnActualizarPromocion.Text = "Actualizar";
            this.btnActualizarPromocion.UseVisualStyleBackColor = false;
            // 
            // btnBorrarPromocion
            // 
            this.btnBorrarPromocion.BackColor = System.Drawing.Color.Coral;
            this.btnBorrarPromocion.Location = new System.Drawing.Point(223, 12);
            this.btnBorrarPromocion.Name = "btnBorrarPromocion";
            this.btnBorrarPromocion.Size = new System.Drawing.Size(90, 48);
            this.btnBorrarPromocion.TabIndex = 102;
            this.btnBorrarPromocion.Text = "Borrar";
            this.btnBorrarPromocion.UseVisualStyleBackColor = false;
            // 
            // btnActualizarPromocion2
            // 
            this.btnActualizarPromocion2.BackColor = System.Drawing.Color.Coral;
            this.btnActualizarPromocion2.Location = new System.Drawing.Point(328, 12);
            this.btnActualizarPromocion2.Name = "btnActualizarPromocion2";
            this.btnActualizarPromocion2.Size = new System.Drawing.Size(89, 48);
            this.btnActualizarPromocion2.TabIndex = 103;
            this.btnActualizarPromocion2.Text = "Actualizar 2";
            this.btnActualizarPromocion2.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Coral;
            this.btnVolver.Location = new System.Drawing.Point(568, 11);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 48);
            this.btnVolver.TabIndex = 104;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // listPromociones
            // 
            this.listPromociones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listPromociones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.promocionId,
            this.promocionNombre,
            this.promocionPrecio,
            this.promocionTipo,
            this.promocionPoder});
            this.listPromociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPromociones.FullRowSelect = true;
            this.listPromociones.GridLines = true;
            this.listPromociones.HideSelection = false;
            this.listPromociones.Location = new System.Drawing.Point(3, 66);
            this.listPromociones.Name = "listPromociones";
            this.listPromociones.Size = new System.Drawing.Size(926, 663);
            this.listPromociones.TabIndex = 0;
            this.listPromociones.UseCompatibleStateImageBehavior = false;
            this.listPromociones.View = System.Windows.Forms.View.Details;
            // 
            // promocionId
            // 
            this.promocionId.Text = "ID";
            // 
            // promocionNombre
            // 
            this.promocionNombre.Text = "Nombre";
            this.promocionNombre.Width = 120;
            // 
            // promocionPrecio
            // 
            this.promocionPrecio.Text = "Precio";
            this.promocionPrecio.Width = 120;
            // 
            // promocionTipo
            // 
            this.promocionTipo.Text = "Tipo";
            this.promocionTipo.Width = 120;
            // 
            // promocionPoder
            // 
            this.promocionPoder.Text = "Poder";
            this.promocionPoder.Width = 120;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Coral;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(664, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 50);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchingFor
            // 
            this.txtSearchingFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchingFor.Location = new System.Drawing.Point(758, 19);
            this.txtSearchingFor.Name = "txtSearchingFor";
            this.txtSearchingFor.Size = new System.Drawing.Size(151, 29);
            this.txtSearchingFor.TabIndex = 105;
            // 
            // vistaListaPromocionesG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtSearchingFor);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAClientes);
            this.Controls.Add(this.listPromociones);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnActualizarPromocion2);
            this.Controls.Add(this.btnBorrarPromocion);
            this.Controls.Add(this.btnActualizarPromocion);
            this.Controls.Add(this.btnAgregarPromocion);
            this.Name = "vistaListaPromocionesG";
            this.Text = "vistaListaPromocionesG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnAClientes;
        public System.Windows.Forms.Button btnAgregarPromocion;
        public System.Windows.Forms.Button btnActualizarPromocion;
        public System.Windows.Forms.Button btnBorrarPromocion;
        public System.Windows.Forms.ListView listPromociones;
        private System.Windows.Forms.ColumnHeader promocionId;
        private System.Windows.Forms.ColumnHeader promocionNombre;
        private System.Windows.Forms.ColumnHeader promocionPrecio;
        private System.Windows.Forms.ColumnHeader promocionTipo;
        private System.Windows.Forms.ColumnHeader promocionPoder;
        public System.Windows.Forms.Button btnActualizarPromocion2;
        public System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSearchingFor;
    }
}