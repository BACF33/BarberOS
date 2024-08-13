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

            //Cuando se presionen los botones marcados en la izquierda se ejecutaran las funciones a la derech
            //por ejemplo si se presiona personal se abrira una lista de personal
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
            //1 Se abirar un formulario agregarPersonal como nueva ventana
            vistaAgregarProducto agregarPersonal = new vistaAgregarProducto();
            agregarPersonal.Show();
        }

        public void getData()
        {
            //1 Se ejecutara la funcion populate del dao
            dao.Populate(controladaVista);
        }

        public void deleteData()
        {
            //1 Si existe una fila en la tabla de la vista que el usuario haya seleccionado se ejecutara lo siguiente
            if (controladaVista.listCortes.SelectedItems.Count > 0)
                //2 Se ejecutara la funcion delete del dao
                dao.Delete(controladaVista);

            getData();
        }

        public void updateData()
        {
            vistaActualizarCortes actualizar;
            //1 Si en la vista el usuario selecciono una fila en la tabla se ejecutara lo siguiente
            if (controladaVista.listCortes.SelectedItems.Count > 0)
            {
                //2 Se obtendra el primer valor de la fila seleccionada en la tabla, es decir la id
                string selectedId = controladaVista.listCortes.SelectedItems[0].Text;
                //3 Se abirar una vistaActualizarCorte como nueva ventana
                actualizar = new vistaActualizarCortes(selectedId);
                actualizar.Show();
            }
        }

        public void searchData()
        {
            //1 Se obtendran los datos que el usuario ingreso en la barra de busqueda
            string searchingFor = controladaVista.txtSearch.Text;
            //2 Se ejecutara la funcion searchData del dao
            dao.searchData(searchingFor, controladaVista);
        }
    }
}