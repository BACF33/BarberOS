using BarberOS.Modelo.Dao;
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

            //Si se presiona promociones se abrira un formulario vistaListaPromocionesG
            controladaVista.btnAProms.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaListaPromocionesG(passedMenuForm));
            //Si se presiona agregar se ejecutara la funcion insertData
            controladaVista.btnAgregarClientes.Click += (sender, e) => insertData();
            //Si se presiona actualizar se ejecutara la funcion getData
            controladaVista.btnActualizarClientes.Click += (sender, e) => getData();
            //Si se presiona borrar se ejecutara la funcion deleteData
            controladaVista.btnBorrarClientes.Click += (sender, e) => deleteData();
            //Si se presiona actualizar2 se ejecutara la funcion updateData
            controladaVista.btnActualizarClientes2.Click += (sender, e) => updateData();
            //Si se presiona volver se volvera a la vista inicio gestion
            controladaVista.btnVolver.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaInicioGestion(passedMenuForm));
            //Si se presiona buscar se ejecutara la funcion searchdata
            controladaVista.btnBuscar.Click += (sender, e) => searhData();
            getData();
        }

        public void updateData()
        {
            vistaActualizarCliente actualizar;
            //1 Si en la vista el usuario selecciono una fila en la tabla se ejecutara lo siguiente
            if (controladaVista.listClientes.SelectedItems.Count > 0)
            {
                //2 Se obtendra el primer valor de la fila seleccionada en la tabla, es decir la id
                string selectedId = controladaVista.listClientes.SelectedItems[0].Text;
                //3 Se abirar una vistaActualizarCliente como nueva ventana
                actualizar = new vistaActualizarCliente(selectedId);
                actualizar.Show();
            }
        }


        public void insertData()
        {
            //1 Se abirar un formulario agregarPersonal como nueva ventana
            vistaAgregarCliente agregarPersonal = new vistaAgregarCliente();
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
            if (controladaVista.listClientes.SelectedItems.Count > 0)
                //2 Se ejecutara la funcion delete del dao
                dao.Delete(controladaVista);

            getData();
        }

        public void searhData()
        {
            //1 Se obtendran los datos que el usuario ingreso en la barra de busqueda
            string searchingFor = controladaVista.txtSearchingFor.Text;
            //2 Se ejecutara la funcion searchData del dao
            dao.searchData(searchingFor, controladaVista);
        }
    }
}
