using BarberOS.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaPrimerLogin : Form
    {
        public VistaPrimerLogin(string userPasado, vistaMenu menuPasado)
        {
            InitializeComponent();
            new ControlPrimerLogin(this, userPasado, menuPasado);
        }
    }
}
