using BarberOS.Modelo.Dao;
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
    internal class controlListaPromocionesG
    {
        private vistaMenu menuForm;
        private vistaListaPromocionesG controladaVista;
        private daoListaPromocionesG dao = new daoListaPromocionesG();
        public controlListaPromocionesG(vistaListaPromocionesG passedVista, vistaMenu passedMenu)
        {
            menuForm = passedMenu;
            controladaVista = passedVista;
            controladaVista.btnActualizarPromocion.Click += (sender, e) => getData();
            controladaVista.btnBorrarPromocion.Click += (sender, e) => deleteData();
            controladaVista.btnAgregarPromocion.Click += (sender, e) => insertData();
            controladaVista.btnActualizarPromocion2.Click += (sender, e) => updateData();
            getData();
        }

        public void getData()
        {
            dao.Populate(controladaVista);
        }

        public void deleteData()
        {
            if (controladaVista.listPromociones.SelectedItems.Count > 0)
                dao.Delete(controladaVista);

            getData();
        }

        public void insertData()
        {
            vistaAgregarPromocion agregarPromocion = new vistaAgregarPromocion();
            agregarPromocion.Show();
        }

        public void updateData()
        {
            vistaActualizarPromocion actualizar;
            if (controladaVista.listPromociones.SelectedItems.Count > 0)
            {
                MessageBox.Show("aea");
                string selectedId = controladaVista.listPromociones.SelectedItems[0].Text;
                actualizar = new vistaActualizarPromocion(selectedId);
                actualizar.Show();
            }
        }
    }
}
