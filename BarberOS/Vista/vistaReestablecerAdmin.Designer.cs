namespace BarberOS.Vista
{
    partial class vistaReestablecerAdmin
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNUser = new System.Windows.Forms.TextBox();
            this.pnl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(81, 104);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(232, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(81, 168);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(232, 20);
            this.txtPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Un administrador debera iniciar sesion en el apartado inferior \r\n                " +
    "         para reestablecer su contraseña\r\n";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(119, 237);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(134, 58);
            this.btnRestablecer.TabIndex = 5;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.btnRestablecer);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.txtPass);
            this.pnl1.Controls.Add(this.txtUser);
            this.pnl1.Location = new System.Drawing.Point(489, 54);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(369, 323);
            this.pnl1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNUser);
            this.panel1.Location = new System.Drawing.Point(196, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 195);
            this.panel1.TabIndex = 7;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(93, 148);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 23);
            this.btnDo.TabIndex = 8;
            this.btnDo.Text = "Confirmar";
            this.btnDo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nueva contraseña";
            // 
            // txtNPass
            // 
            this.txtNPass.Location = new System.Drawing.Point(27, 107);
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.Size = new System.Drawing.Size(197, 20);
            this.txtNPass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre de usuario";
            // 
            // txtNUser
            // 
            this.txtNUser.Location = new System.Drawing.Point(27, 47);
            this.txtNUser.Name = "txtNUser";
            this.txtNUser.Size = new System.Drawing.Size(197, 20);
            this.txtNUser.TabIndex = 0;
            // 
            // vistaReestablecerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.panel1);
            this.Name = "vistaReestablecerAdmin";
            this.Text = "reestablecer";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnRestablecer;
        public System.Windows.Forms.Panel pnl1;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnDo;
        public System.Windows.Forms.TextBox txtNUser;
        public System.Windows.Forms.TextBox txtNPass;
    }
}