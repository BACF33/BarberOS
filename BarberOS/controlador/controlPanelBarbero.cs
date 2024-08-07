using BarberOS.Modelo.Dto;
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
        public controlPanelBarbero(panelBarbero pasadoPanel, string passedId, string passedName, string passedRole)
        {
            controladoPanel = pasadoPanel;
            dtoPanelBarbero infoEste = new dtoPanelBarbero();
            infoEste.BarberoId = passedId;
            infoEste.BarberoName = passedName;
            infoEste.BarberoRole = passedRole;

            pasadoPanel.lblId.Text = passedId;
            pasadoPanel.lblName.Text = passedName;
            pasadoPanel.lblRole.Text = passedRole;
        }
    }
 }
