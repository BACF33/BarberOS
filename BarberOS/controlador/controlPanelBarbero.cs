using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class controlPanelBarbero
    {
        panelBarbero controladoPanel = null;
        public controlPanelBarbero(panelBarbero pasadoPanel)
        {
            controladoPanel = pasadoPanel;
            }
        }
    }
