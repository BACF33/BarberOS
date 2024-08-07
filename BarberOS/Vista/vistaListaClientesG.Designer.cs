namespace BarberOS.Vista
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAProms = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.btnActualizarClientes = new System.Windows.Forms.Button();
            this.btnBorrarClientes = new System.Windows.Forms.Button();
            this.listClientes = new System.Windows.Forms.ListView();
            this.empleadoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoContraseña = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoFull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empleadoCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnActualizarClientes2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAProms);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(702, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(98, 450);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // btnAProms
            // 
            this.btnAProms.BackColor = System.Drawing.Color.Gold;
            this.btnAProms.Location = new System.Drawing.Point(3, 3);
            this.btnAProms.Name = "btnAProms";
            this.btnAProms.Size = new System.Drawing.Size(96, 456);
            this.btnAProms.TabIndex = 10;
            this.btnAProms.Text = "Promociones";
            this.btnAProms.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarClientes);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarClientes);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrarClientes);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarClientes2);
            this.flowLayoutPanel1.Controls.Add(this.listClientes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(696, 450);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClientes.TabIndex = 1;
            this.btnAgregarClientes.Text = "Agregar";
            this.btnAgregarClientes.UseVisualStyleBackColor = true;
            // 
            // btnActualizarClientes
            // 
            this.btnActualizarClientes.Location = new System.Drawing.Point(84, 3);
            this.btnActualizarClientes.Name = "btnActualizarClientes";
            this.btnActualizarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarClientes.TabIndex = 6;
            this.btnActualizarClientes.Text = "Actualizar";
            this.btnActualizarClientes.UseVisualStyleBackColor = true;
            // 
            // btnBorrarClientes
            // 
            this.btnBorrarClientes.Location = new System.Drawing.Point(165, 3);
            this.btnBorrarClientes.Name = "btnBorrarClientes";
            this.btnBorrarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarClientes.TabIndex = 7;
            this.btnBorrarClientes.Text = "Borrar";
            this.btnBorrarClientes.UseVisualStyleBackColor = true;
            // 
            // listClientes
            // 
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empleadoId,
            this.empleadoNombre,
            this.empleadoContraseña,
            this.empleadoFull,
            this.empleadoCargo});
            this.listClientes.FullRowSelect = true;
            this.listClientes.GridLines = true;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(3, 32);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(684, 426);
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
            // 
            // empleadoContraseña
            // 
            this.empleadoContraseña.Text = "Contraseña";
            // 
            // empleadoFull
            // 
            this.empleadoFull.Text = "Puntos";
            // 
            // empleadoCargo
            // 
            this.empleadoCargo.Text = "Cargo";
            // 
            // btnActualizarClientes2
            // 
            this.btnActualizarClientes2.Location = new System.Drawing.Point(246, 3);
            this.btnActualizarClientes2.Name = "btnActualizarClientes2";
            this.btnActualizarClientes2.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarClientes2.TabIndex = 8;
            this.btnActualizarClientes2.Text = "Actualizar2";
            this.btnActualizarClientes2.UseVisualStyleBackColor = true;
            // 
            // vistaListaClientesG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "vistaListaClientesG";
            this.Text = "vistaListaClientesG";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.Button btnAProms;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
    }
}