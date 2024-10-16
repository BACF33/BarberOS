using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlOrdenes
    {
        DaoOrdenes daoThis = new DaoOrdenes();

        public ControlOrdenes(vistaMenu pasadoMenu, VistaOrdenes vistaPasada) 
        {
            daoThis.Populate(vistaPasada);
            daoThis.PopulateUsers(vistaPasada);

            vistaPasada.btnAgregar.Click += (sender, e) =>
            {
                daoThis.Insert(vistaPasada);
                daoThis.Populate(vistaPasada);
            };

            vistaPasada.btnActualizar2.Click += (sender, e) =>
            {
                daoThis.Update(vistaPasada);
                daoThis.Populate(vistaPasada);
            };

            vistaPasada.btnBorrar.Click += (sender, e) =>
            {
                daoThis.Delete(vistaPasada);
                daoThis.Populate(vistaPasada);
            };

            vistaPasada.listEmpleados.SelectedIndexChanged += (sender, e) =>
            {
                if (vistaPasada.listEmpleados.SelectedItems.Count > 0)
                {
                    ListViewItem seleccionado = vistaPasada.listEmpleados.SelectedItems[0];
                    vistaPasada.txtId.Text = seleccionado.SubItems[0].Text;
                    vistaPasada.cmbUsers.Text = seleccionado.SubItems[1].Text;
                    vistaPasada.dtpTime.Text = seleccionado.SubItems[2].Text;
                    vistaPasada.txtOrder.Text = seleccionado.SubItems[3].Text;
                }
                else
                {
                    vistaPasada.txtId.Text = null;
                    vistaPasada.cmbUsers.Text = null;
                    vistaPasada.dtpTime.Text = null;
                    vistaPasada.txtOrder.Text = null;
                }
            };
        }
    }
}
