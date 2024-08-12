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
    public partial class vistaListaPromociones : Form
    {
        public vistaListaPromociones(vistaMenu pasadoMenu, dtoPanelProducto seleccionadoProducto)
        {
            InitializeComponent();
            controlListaPromociones controladorVista = new controlListaPromociones(this, pasadoMenu, seleccionadoProducto);
        }
    }
}
