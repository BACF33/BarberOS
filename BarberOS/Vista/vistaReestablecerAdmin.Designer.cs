﻿namespace BarberOS.Vista
{
    partial class VistaReestablecerAdmin
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
            this.btnRecoverId = new System.Windows.Forms.Button();
            this.txtRecoverId = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.pnl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(139, 115);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(232, 28);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(139, 199);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(232, 28);
            this.txtPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Un administrador debera iniciar sesion en el apartado inferior \r\n                " +
    "         para reestablecer su contraseña\r\n";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.Coral;
            this.btnRestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Location = new System.Drawing.Point(176, 267);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(134, 58);
            this.btnRestablecer.TabIndex = 5;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.btnRestablecer);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.txtPass);
            this.pnl1.Controls.Add(this.txtUser);
            this.pnl1.Location = new System.Drawing.Point(335, 231);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(539, 373);
            this.pnl1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNUser);
            this.panel1.Location = new System.Drawing.Point(403, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 304);
            this.panel1.TabIndex = 7;
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.Coral;
            this.btnDo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDo.Location = new System.Drawing.Point(83, 214);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(154, 75);
            this.btnDo.TabIndex = 8;
            this.btnDo.Text = "Confirmar";
            this.btnDo.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nueva contraseña";
            // 
            // txtNPass
            // 
            this.txtNPass.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPass.Location = new System.Drawing.Point(27, 161);
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.Size = new System.Drawing.Size(278, 40);
            this.txtNPass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre de usuario";
            // 
            // txtNUser
            // 
            this.txtNUser.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUser.Location = new System.Drawing.Point(27, 63);
            this.txtNUser.Name = "txtNUser";
            this.txtNUser.Size = new System.Drawing.Size(278, 40);
            this.txtNUser.TabIndex = 0;
            // 
            // btnRecoverId
            // 
            this.btnRecoverId.BackColor = System.Drawing.Color.Coral;
            this.btnRecoverId.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverId.Location = new System.Drawing.Point(446, 646);
            this.btnRecoverId.Name = "btnRecoverId";
            this.btnRecoverId.Size = new System.Drawing.Size(138, 47);
            this.btnRecoverId.TabIndex = 8;
            this.btnRecoverId.Text = "Reestablecer por numero";
            this.btnRecoverId.UseVisualStyleBackColor = false;
            // 
            // txtRecoverId
            // 
            this.txtRecoverId.Location = new System.Drawing.Point(634, 646);
            this.txtRecoverId.Name = "txtRecoverId";
            this.txtRecoverId.Size = new System.Drawing.Size(156, 20);
            this.txtRecoverId.TabIndex = 9;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(634, 691);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(156, 20);
            this.txtUserId.TabIndex = 10;
            // 
            // VistaReestablecerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtRecoverId);
            this.Controls.Add(this.btnRecoverId);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.panel1);
            this.Name = "VistaReestablecerAdmin";
            this.Text = "reestablecer";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        public System.Windows.Forms.Button btnRecoverId;
        public System.Windows.Forms.TextBox txtRecoverId;
        public System.Windows.Forms.TextBox txtUserId;
    }
}