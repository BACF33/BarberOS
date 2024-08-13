using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BarberOS.Controlador
{
    internal class controlListaCortesG
    {
        private vistaMenu menuForm;
        private vistaListaCortesG controladaVista;
        private daoListaCortesG dao = new daoListaCortesG();

        public controlListaCortesG(vistaListaCortesG pasadaVista, vistaMenu passedMenuForm)
        {
            controladaVista = pasadaVista;
            menuForm = passedMenuForm;
            controladaVista.btnActualizarEmpleados.Click += (sender, e) => getData();
            controladaVista.btnBorrarEmpleados.Click += (sender, e) => deleteData();
            controladaVista.btnActualizarEmpleados2.Click += (sender, e) => updateData();
            controladaVista.btnAgregarEmpleados.Click += (sender, e) => insertData();
            controladaVista.btnSearch.Click += (sender, e) => searchData();
            controladaVista.btnAPersonal.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaListaPersonalG(passedMenuForm));
            controladaVista.btnVolver.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaInicioGestion(passedMenuForm));
            getData();
        }

        public void insertData()
        {
            vistaAgregarProducto agregarPersonal = new vistaAgregarProducto();
            agregarPersonal.Show();
        }

        public void getData()
        {
            dao.Populate(controladaVista);
        }

        public void deleteData()
        {
            if (controladaVista.listCortes.SelectedItems.Count > 0)
                dao.Delete(controladaVista);

            getData();
        }

        public void updateData()
        {
            vistaActualizarCortes actualizar;
            if (controladaVista.listCortes.SelectedItems.Count > 0)
            {
                string selectedId = controladaVista.listCortes.SelectedItems[0].Text;
                actualizar = new vistaActualizarCortes(selectedId);
                actualizar.Show();
            }
        }

        public void searchData()
        {
            string searchingFor = controladaVista.txtSearch.Text;
            dao.searchData(searchingFor, controladaVista);
        }
    }
}