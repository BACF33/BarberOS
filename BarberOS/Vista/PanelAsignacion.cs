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
    public partial class PanelAsignacion : UserControl
    {
        public ControlAsignacion controladorThis;
        public PanelAsignacion(string pasadoTexto, DateTime pasadaFecha, vistaMenu pasadoMenu, int pasadaId)
        {
            InitializeComponent();
            controladorThis = new ControlAsignacion(this, pasadoTexto, pasadaFecha, pasadaId);
        }

        private void PanelAsignacion_Load(object sender, EventArgs e)
        {

        }
    }
}
