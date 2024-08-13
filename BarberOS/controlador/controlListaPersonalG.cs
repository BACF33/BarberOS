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
    internal class controlListaPersonalG
    {
        private vistaMenu menuForm;
        private vistaListaPersonalG controladaVista;
        private daoListaPersonalG dao = new daoListaPersonalG();

        public controlListaPersonalG(vistaListaPersonalG vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;

            controladaVista.btnActualizarEmpleados.Click += (sender, e) => getData();
            controladaVista.btnBorrarEmpleados.Click += (sender, e) => deleteData();
            controladaVista.btnAgregarEmpleados.Click += (sender, e) => insertData();
            controladaVista.btnACortes.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaListaCortesG(passedMenuForm));
            controladaVista.btnActualizarEmpleados2.Click += (sender, e) => updateData();
            controladaVista.btnSearch.Click += (sender, e) => searchData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaInicioGestion(passedMenuForm));
            getData();
        }

        public void updateData()
        {
            vistaActualizarPersonal actualizar;
            if (controladaVista.listEmpleados.SelectedItems.Count > 0)
            {
                string selectedId = controladaVista.listEmpleados.SelectedItems[0].Text;
                actualizar = new vistaActualizarPersonal(selectedId);
                actualizar.Show();
            }
        }

        public void insertData()
        {
            vistaAgregarPersonal agregarPersonal = new vistaAgregarPersonal();
            agregarPersonal.Show();
        }

        public void getData()
        {
            dao.Populate(controladaVista);
        }

        public void deleteData()
        {
            if (controladaVista.listEmpleados.SelectedItems.Count > 0)
                dao.Delete(controladaVista);

                getData();
        }

        public void searchData()
        {
            string searchingFor = controladaVista.txtSearch.Text;
            dao.searchData(searchingFor, controladaVista);
        }
    }
}