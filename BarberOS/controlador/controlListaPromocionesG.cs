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
            //Cuando se presionen los botones marcados en la izquierda se ejecutaran las funciones a la derech
            //por ejemplo si se presiona eliminar se ejecutara la funcion deleteData
            controladaVista.btnActualizarPromocion.Click += (sender, e) => getData();
            controladaVista.btnBorrarPromocion.Click += (sender, e) => deleteData();
            controladaVista.btnAgregarPromocion.Click += (sender, e) => insertData();
            controladaVista.btnActualizarPromocion2.Click += (sender, e) => updateData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenu.controladorMenu.AbrirFormulario(new vistaInicioGestion(passedMenu));
            getData();
            controladaVista.btnSearch.Click += (sender, e) => searchData();
        }

        public void getData()
        {
            //Se ejecutara la funcion populate del dao 
            dao.Populate(controladaVista);
        }

        public void deleteData()
        {
            //1 Si existe una fila en la tabla de la vista que el usuario haya seleccionado se ejecutara lo siguiente
            if (controladaVista.listPromociones.SelectedItems.Count > 0)
                //2 Se ejecutara la funcion delete del dao
                dao.Delete(controladaVista);

            getData();
        }

        public void insertData()
        {
            //1 Se obtendran los datos que el usuario ingreso en la barra de busqueda
            vistaAgregarPromocion agregarPromocion = new vistaAgregarPromocion();
            //2 Se ejecutara la funcion searchData del dao
            agregarPromocion.Show();
        }

        public void updateData()
        {
            vistaActualizarPromocion actualizar;
            //1 Si en la vista el usuario selecciono una fila en la tabla se ejecutara lo siguiente
            if (controladaVista.listPromociones.SelectedItems.Count > 0)
            {
                //2 Se obtendra el primer valor de la fila seleccionada en la tabla, es decir la id
                string selectedId = controladaVista.listPromociones.SelectedItems[0].Text;
                //3 Se abirar una vistaActualizarCorte como nueva ventana
                actualizar = new vistaActualizarPromocion(selectedId);
                actualizar.Show();
            }
        }

        public void searchData()
        {
            //1 Se obtendran los datos que el usuario ingreso en la barra de busqueda
            string searchingFor = controladaVista.txtSearchingFor.Text;
            //2 Se ejecutara la funcion searchData del dao
            dao.searchData(searchingFor, controladaVista);
        }
    }
}
