﻿using BarberOS.Modelo.Dao;
using BarberOS.Vista;

namespace BarberOS.Controlador
{
    internal class controlListaClientesG
    {
        private vistaMenu menuForm;
        private vistaListaClientesG controladaVista;
        private daoListaClientesG dao = new daoListaClientesG();
        public controlListaClientesG(vistaListaClientesG vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;

            //Logica de botones
            controladaVista.btnAProms.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaListaPromocionesG(passedMenuForm));
            controladaVista.btnAgregarClientes.Click += (sender, e) => insertData();
            controladaVista.btnActualizarClientes.Click += (sender, e) => getData();
            controladaVista.btnBorrarClientes.Click += (sender, e) => deleteData();
            controladaVista.btnActualizarClientes2.Click += (sender, e) => updateData();
            //Logica de botones

            getData();
        }

        public void updateData()
        {
            vistaActualizarCliente actualizar;
            if (controladaVista.listClientes.SelectedItems.Count > 0)
            {
                string selectedId = controladaVista.listClientes.SelectedItems[0].Text;
                actualizar = new vistaActualizarCliente(selectedId);
                actualizar.Show();
            }
        }


        public void insertData()
        {
            vistaAgregarCliente agregarPersonal = new vistaAgregarCliente();
            agregarPersonal.Show();
        }

        public void getData()
        {
            dao.Populate(controladaVista);
        }

        public void deleteData()
        {
            if (controladaVista.listClientes.SelectedItems.Count > 0)
                dao.Delete(controladaVista);

            getData();
        }
    }
}
