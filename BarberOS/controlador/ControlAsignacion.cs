using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    public class ControlAsignacion
    {
        PanelAsignacion panelControlado;
        public int panelId;
        DaoAsignacion daoThis = new DaoAsignacion();

        public ControlAsignacion(PanelAsignacion panelPasado, string ordenTexto, DateTime ordenFecha, int ordenId) 
        {
            panelId = ordenId;
            panelControlado = panelPasado;

            panelPasado.txtOrden.Text = ordenTexto;
            panelPasado.dtpLimite.Value = ordenFecha;
            panelPasado.btnCompletar.Click += (sender,e) => Completar();
        }

        public void Completar() 
        {
            panelControlado.txtOrden.Visible = false;
            panelControlado.dtpLimite.Visible = false;
            panelControlado.btnCompletar.Visible = false;
            panelControlado.imgCompletado.Visible = true;

            panelControlado.BackColor = System.Drawing.Color.Green;
            daoThis.Eliminar(panelControlado);
        }
    }
}
