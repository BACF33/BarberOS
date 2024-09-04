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
            this.components = new System.ComponentModel.Container();
            this.listRegistros = new System.Windows.Forms.ListView();
            this.registroId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroProductoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroProductoPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regisroPromocionNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroPromocionPoder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registroTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnActualizarRegistros = new System.Windows.Forms.Button();
            this.btnBorrarEmpleados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listRegistros
            // 
            this.listRegistros.BackColor = System.Drawing.Color.Silver;
            this.listRegistros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.registroId,
            this.registroProductoNombre,
            this.registroProductoPrecio,
            this.regisroPromocionNombre,
            this.registroPromocionPoder,
            this.registroTotal});
            this.listRegistros.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRegistros.FullRowSelect = true;
            this.listRegistros.GridLines = true;
            this.listRegistros.HideSelection = false;
            this.listRegistros.Location = new System.Drawing.Point(469, 150);
            this.listRegistros.Name = "listRegistros";
            this.listRegistros.Size = new System.Drawing.Size(694, 460);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnUpdate2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 72);
            this.panel2.TabIndex = 128;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1083, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 104;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 44);
            this.label1.TabIndex = 125;
            this.label1.Text = "BarberOs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 44);
            this.label3.TabIndex = 114;
            this.label3.Text = "BarberOs";
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate2.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate2.Location = new System.Drawing.Point(856, 18);
            this.btnUpdate2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(119, 31);
            this.btnUpdate2.TabIndex = 129;
            this.btnUpdate2.Text = "Restablecer";
            this.btnUpdate2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(349, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 29);
            this.textBox1.TabIndex = 123;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBorrar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(982, 18);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(95, 35);
            this.btnBorrar.TabIndex = 102;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(246, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 28);
            this.btnSearch.TabIndex = 124;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnActualizarRegistros
            // 
            this.btnActualizarRegistros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarRegistros.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRegistros.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarRegistros.Location = new System.Drawing.Point(54, 352);
            this.btnActualizarRegistros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizarRegistros.Name = "btnActualizarRegistros";
            this.btnActualizarRegistros.Size = new System.Drawing.Size(136, 31);
            this.btnActualizarRegistros.TabIndex = 131;
            this.btnActualizarRegistros.Text = "Agregar";
            this.btnActualizarRegistros.UseVisualStyleBackColor = true;
            // 
            // btnBorrarEmpleados
            // 
            this.btnBorrarEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrarEmpleados.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarEmpleados.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarEmpleados.Location = new System.Drawing.Point(198, 352);
            this.btnBorrarEmpleados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrarEmpleados.Name = "btnBorrarEmpleados";
            this.btnBorrarEmpleados.Size = new System.Drawing.Size(141, 31);
            this.btnBorrarEmpleados.TabIndex = 130;
            this.btnBorrarEmpleados.Text = "Actualizar";
            this.btnBorrarEmpleados.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnActualizarRegistros);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnBorrarEmpleados);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.txtPuntos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(48, 184);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 426);
            this.panel1.TabIndex = 133;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(55, 280);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 20);
            this.txtEmail.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 126;
            this.label9.Text = "Personal Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 123;
            this.label6.Text = "Personal Puntos";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(34, 23);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(0, 25);
            this.LblNombre.TabIndex = 0;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPuntos.Location = new System.Drawing.Point(55, 237);
            this.txtPuntos.Margin = new System.Windows.Forms.Padding(5);
            this.txtPuntos.MaxLength = 60;
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(284, 20);
            this.txtPuntos.TabIndex = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 38);
            this.label5.TabIndex = 121;
            this.label5.Text = "Agregar Barberos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 133);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Personal Nombre";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.Location = new System.Drawing.Point(55, 194);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.txtContraseña.MaxLength = 60;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(284, 20);
            this.txtContraseña.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(55, 151);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 20);
            this.txtName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Personal Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 38);
            this.label2.TabIndex = 132;
            this.label2.Text = "Lista de Barberos";
            // 
            // VistaListaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1194, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listRegistros);
            this.Name = "VistaListaRegistros";
            this.Text = "vistaListaRegistros";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnActualizarRegistros;
        public System.Windows.Forms.Button btnUpdate2;
        public System.Windows.Forms.Button btnBorrarEmpleados;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label LblNombre;
        public System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}