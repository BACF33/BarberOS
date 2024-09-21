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
    internal class ControlPanelBarbero
    {
        PanelBarbero controladoPanel = null;
        public ControlPanelBarbero(PanelBarbero pasadoPanel, string passedId, string passedName, string passedRole)
        {
            //Los valores que se obtuvieron de una fila de la tabla de personal se le asignaran al panel (control de usuario) de un barberos y se creara el control de usuario
            controladoPanel = pasadoPanel;
            DtoPanelBarbero infoEste = new DtoPanelBarbero();
            infoEste.BarberoId = passedId;
            infoEste.BarberoName = passedName;
            infoEste.BarberoRole = passedRole;

            pasadoPanel.lblId.Text = passedId;
            pasadoPanel.lblName.Text = passedName;
            pasadoPanel.lblRole.Text = passedRole;
        }
    }
 }
