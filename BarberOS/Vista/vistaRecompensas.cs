using BarberOS.Controlador;
using BarberOS.Modelo.Dto;
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
    public partial class vistaRecompensas : Form
    {
        public vistaRecompensas(dtoPanelPromocion pasadaPromocion, vistaMenu pasadoMenu, dtoPanelProducto seleccionadoProducto)
        {
            InitializeComponent();
            controlTotal controladorVista = new controlTotal(pasadoMenu, this, pasadaPromocion, seleccionadoProducto);
        }
    }
}
