using BarberOS.Modelo.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarberOS.Controlador;

namespace BarberOS.Vista
{
    public partial class vistaRestablecerCorreo : Form
    {
        public vistaRestablecerCorreo(vistaMenu pasadoMenu)
        {
            InitializeComponent();
            new ControlRestablecerCorreo(this, pasadoMenu);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}